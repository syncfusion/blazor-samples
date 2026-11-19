using BlazorDemos.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using SmartComponents.LocalEmbeddings;
using Syncfusion.Blazor.Buttons;
using Syncfusion.Blazor.FileManager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.Json;
using System.Globalization;

namespace FileManagerAI.Services
{
    public class FileManagerService
    {
        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions { WriteIndented = true };
        public string contentRootPath { get; set; } = string.Empty;
        protected IReadOnlyList<string> allowedExtension { get; set; } = new[] { "*" };
        AccessDetails AccessDetails = new AccessDetails();
        private string rootName = string.Empty;
        protected string hostPath { get; set; } = string.Empty;
        protected string hostName { get; set; } = string.Empty;
        private string accessMessage = string.Empty;
        internal HttpResponse Response = default!;
        public string basePath { get; set; } = string.Empty;
        private string root = string.Empty;
        private string DefaultDirectory = Path.Combine("wwwroot", "Files");
        public static readonly string DemoDirectoryName = "DemoBaseDirectory";
        public string DemoBaseDirectory { get; set; } = Path.Combine("wwwroot", DemoDirectoryName);
        public TagService TagService { get; } = new TagService();
        public AzureAIService OpenAIService { get; set; }
        public Dictionary<string, EmbeddingF32> FileEmbeddings { get; internal set; } = new Dictionary<string, EmbeddingF32>();

        public FileManagerService(IWebHostEnvironment hostingEnvironment, AzureAIService openAIService)
        {
            this.basePath = hostingEnvironment?.ContentRootPath ?? string.Empty;
            this.DemoBaseDirectory = Path.Combine(this.basePath, this.DemoBaseDirectory);
            this.DefaultDirectory = Path.Combine(this.basePath, this.DefaultDirectory);
            if (!Directory.Exists(DemoBaseDirectory))
            {
                Directory.CreateDirectory(DemoBaseDirectory);
            }
            else
            {
                _ = Task.Run(() => CleanUpOldDirectories());
            }
            OpenAIService = openAIService;
        }

        public void RootFolder(string name)
        {
            this.root = Path.Combine(this.DemoBaseDirectory, name);
            this.root = Path.Combine(root, "Files");
            CopyFolder(DefaultDirectory, root);
            this.contentRootPath = root;
            this.hostName = new Uri(contentRootPath).Host;
            if (!string.IsNullOrEmpty(this.hostName))
            {
                int index = contentRootPath.IndexOf(this.hostName, StringComparison.OrdinalIgnoreCase);
                if (index >= 0)
                {
                    this.hostPath = Path.DirectorySeparatorChar + this.hostName + Path.DirectorySeparatorChar + contentRootPath.Substring(index + this.hostName.Length + 1);
                }
            }
        }

        private static void CopyFolder(string source, string destination)
        {
            if (!Directory.Exists(destination))
            {
                Directory.CreateDirectory(destination);
            }

            foreach (var file in Directory.EnumerateFiles(source))
            {
                var dest = Path.Combine(destination, Path.GetFileName(file));
                File.Copy(file, dest);
            }

            foreach (var folder in Directory.EnumerateDirectories(source))
            {
                var dest = Path.Combine(destination, Path.GetFileName(folder));
                CopyFolder(folder, dest);
            }
        }

        public Task CleanUpOldDirectories()
        {
            var directories = Directory.GetDirectories(DemoBaseDirectory)
                                       .Select(dir => new DirectoryInfo(dir))
                                       .Where(dirInfo => dirInfo.CreationTime < DateTime.Now.AddHours(1));

            foreach (var dir in directories)
            {
                if (Directory.Exists(dir.FullName))
                {
                    Directory.Delete(dir.FullName, true);
                }
            }
            return Task.CompletedTask;
        }

        public void SetRules(AccessDetails details)
        {
            this.AccessDetails = details;
            DirectoryInfo root = new DirectoryInfo(this.contentRootPath);
            this.rootName = root.Name;
        }

        public async Task OrganizeFiles(string path, bool showHiddenItems, params FileManagerDirectoryContent[] data)
        {
            try
            {
                if (path == null)
                {
                    path = string.Empty;
                }
                String fullPath = (contentRootPath + path);
                DirectoryInfo directory = new DirectoryInfo(fullPath);
                string[] extensions = this.allowedExtension.ToArray();
                string rootPath = string.IsNullOrEmpty(this.hostPath) ? this.contentRootPath : new DirectoryInfo(this.hostPath).FullName;
                string parentPath = string.IsNullOrEmpty(this.hostPath) ? directory.Parent?.FullName ?? string.Empty : new DirectoryInfo(this.hostPath + (path != "/" ? path : "")).Parent?.FullName ?? string.Empty;
                if (Path.GetFullPath(fullPath) != GetFilePath(fullPath))
                {
                    throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                }
                List<FileManagerDirectoryContent> foundedFiles = new List<FileManagerDirectoryContent>();
                foundedFiles = ReadFiles(directory, extensions, showHiddenItems, data).Cast<FileManagerDirectoryContent>().ToList();
                if (foundedFiles.Count == 0)
                {
                    return;
                }
                var categorizedFiles = await CategorizeFilesAsync(foundedFiles).ConfigureAwait(false);
                foreach (var category in categorizedFiles)
                {
                    if (categorizedFiles.Count > 1 && category.Value.Count != 0)
                    {
                        string newDirectoryPath = Path.Combine(contentRootPath + path, category.Key);
                        if (!Directory.Exists(newDirectoryPath))
                        {
                            Directory.CreateDirectory(newDirectoryPath);
                        }
                        foreach (var item in category.Value)
                        {
                            var dest = Path.Combine(newDirectoryPath, item.Name);
                            var source = Path.Combine(contentRootPath + path, item.Name);
                            File.Copy(source, dest);
                            File.Delete(source);
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException e)
            {
                ErrorDetails er = new ErrorDetails
                {
                    Message = !string.IsNullOrEmpty(accessMessage) ? accessMessage : e.Message,
                    Code = "401"
                };
            }
            catch (IOException e)
            {
                ErrorDetails er = new ErrorDetails
                {
                    Message = e.Message,
                    Code = "417"
                };
            }
            catch (OperationCanceledException e)
            {
                ErrorDetails er = new ErrorDetails
                {
                    Message = e.Message,
                    Code = "417"
                };
            }

        }

        public async Task<Dictionary<string, List<FileManagerDirectoryContent>>> CategorizeFilesAsync(IReadOnlyList<FileManagerDirectoryContent> foundedFiles)
        {
            var prompt = "Categorize the following files based on their name and type. Provide the categories in the exact format:\n\n" +
             "Category: [Category Name]\n" +
             "- [File Name]\n\n";
            var response = await GetCategorizationResponse(prompt, foundedFiles.ToList()).ConfigureAwait(false);
            var categorizedFiles = CategorizeFiles(foundedFiles.ToList(), response);
            return categorizedFiles;
        }

        public static Dictionary<string, List<FileManagerDirectoryContent>> CategorizeFiles(IReadOnlyList<FileManagerDirectoryContent> files, string response)
        {
            response = response ?? string.Empty;
            files = files ?? Array.Empty<FileManagerDirectoryContent>();
            var categorizedFiles = new Dictionary<string, List<FileManagerDirectoryContent>>();
            var lines = response.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            string? currentCategory = null;
            foreach (var line in lines)
            {
                if (line.StartsWith("Category:", StringComparison.Ordinal))
                {
                    currentCategory = line.Substring("Category:".Length).Trim();
                    if (!categorizedFiles.ContainsKey(currentCategory))
                    {
                        categorizedFiles[currentCategory] = new List<FileManagerDirectoryContent>();
                    }
                    continue;
                }
                if (line.Trim().StartsWith('-'))
                {
                    var fileName = line.Trim().Substring(1).Trim();
                    var file = files.FirstOrDefault(f => f.Name.Equals(fileName, StringComparison.OrdinalIgnoreCase));
                    if (file != null && currentCategory != null)
                    {
                        categorizedFiles[currentCategory].Add(file);
                    }
                }
            }
            return categorizedFiles;
        }

        public static string CreatePrompt(IReadOnlyList<FileManagerDirectoryContent> files)
        {
            files = files ?? Array.Empty<FileManagerDirectoryContent>();
            var prompt = "Categorize the following files based on their name and type. Provide the categories in the exact format:\n\n" +
                         "Category: [Category Name]\n" +
                         "- [File Name]\n\n";

            foreach (var file in files)
            {
                prompt += $"File: {file.Name}, Type: {file.Type}\n";
            }

            return prompt;
        }

        public async Task<string> GetCategorizationResponse(string prompt, IReadOnlyList<FileManagerDirectoryContent> foundedFiles)
        {
            foundedFiles = foundedFiles ?? Array.Empty<FileManagerDirectoryContent>();
            string message = string.Empty;
            foreach (var file in foundedFiles)
            {
                message += $"File: {file.Name}, Type: {file.Type}\n";
            }
            var result = await OpenAIService.GetCompletionAsync(prompt + message, false).ConfigureAwait(false);
            return result;
        }

        public async Task<FileManagerResponse<FileManagerDirectoryContent>> GetFiles(string path, bool showHiddenItems, params FileManagerDirectoryContent[] data)
        {
            FileManagerResponse<FileManagerDirectoryContent> readResponse = new FileManagerResponse<FileManagerDirectoryContent>();
            try
            {
                if (path == null)
                {
                    path = string.Empty;
                }
                String fullPath = (contentRootPath + path);
                DirectoryInfo directory = new DirectoryInfo(fullPath);
                string[] extensions = this.allowedExtension.ToArray();
                FileManagerDirectoryContent cwd = new FileManagerDirectoryContent();
                string rootPath = string.IsNullOrEmpty(this.hostPath) ? this.contentRootPath : new DirectoryInfo(this.hostPath).FullName;
                string parentPath = string.IsNullOrEmpty(this.hostPath) ? directory.Parent?.FullName ?? string.Empty
                : new DirectoryInfo(this.hostPath + (path != "/" ? path : "")).Parent?.FullName ?? string.Empty;
                if (Path.GetFullPath(fullPath) != GetFilePath(fullPath))
                {
                    throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                }
                cwd.Name = string.IsNullOrEmpty(this.hostPath) ? directory.Name : new DirectoryInfo(this.hostPath + path).Name;
                cwd.Size = 0;
                cwd.IsFile = false;
                cwd.DateModified = directory.LastWriteTime;
                cwd.DateCreated = directory.CreationTime;
                cwd.HasChild = CheckChild(directory.FullName);
                cwd.Type = directory.Extension;
                cwd.FilterPath = GetRelativePath(rootPath, parentPath + Path.DirectorySeparatorChar);
                cwd.Permission = GetPathPermission(path);
                readResponse.CWD = cwd;
                if (!hasAccess(directory.FullName) || (cwd.Permission != null && !cwd.Permission.Read))
                {
                    readResponse.Files = null;
                    accessMessage = cwd.Permission?.Message ?? string.Empty;
                    throw new UnauthorizedAccessException("'" + cwd.Name + "' is not accessible. You need permission to perform the read action.");
                }
                readResponse.Files = ReadDirectories(directory, extensions, showHiddenItems, data).Cast<FileManagerDirectoryContent>().ToList();
                readResponse.Files = readResponse.Files.Concat(ReadFiles(directory, extensions, showHiddenItems, data)).Cast<FileManagerDirectoryContent>().ToList();
                return await Task.FromResult(readResponse).ConfigureAwait(false);
            }
            catch (UnauthorizedAccessException e)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = e.Message.ToString();
                er.Code = "401";
                if (!string.IsNullOrEmpty(accessMessage)) { er.Message = accessMessage; }
                readResponse.Error = er;
                return await Task.FromResult(readResponse).ConfigureAwait(false);
            }
            catch (IOException e)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = e.Message.ToString();
                er.Code = "417";
                readResponse.Error = er;
                return await Task.FromResult(readResponse).ConfigureAwait(false);
            }
            catch (OperationCanceledException e)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = e.Message.ToString();
                er.Code = "417";
                readResponse.Error = er;
                return await Task.FromResult(readResponse).ConfigureAwait(false);
            }
        }

        protected virtual IEnumerable<FileManagerDirectoryContent> ReadFiles(DirectoryInfo directory, string[] extensions, bool showHiddenItems, params FileManagerDirectoryContent[] data)
        {
            if (directory == null)
            {
                return Array.Empty<FileManagerDirectoryContent>();
            }
            try
            {
                FileManagerResponse<FileManagerDirectoryContent> readFiles = new FileManagerResponse<FileManagerDirectoryContent>();
                if (!showHiddenItems)
                {
                    IEnumerable<FileManagerDirectoryContent> files = extensions.SelectMany(directory.GetFiles).Where(f => (f.Attributes & FileAttributes.Hidden) == 0)
                            .Select(file => new FileManagerDirectoryContent
                            {
                                Name = file.Name,
                                IsFile = true,
                                Size = file.Length,
                                DateModified = file.LastWriteTime,
                                DateCreated = file.CreationTime,
                                HasChild = false,
                                Type = file.Extension,
                                FilterPath = GetRelativePath(this.contentRootPath, directory.FullName),
                                Permission = GetPermission(directory.FullName, file.Name, true)
                            });
                    readFiles.Files = files.Cast<FileManagerDirectoryContent>().ToList();
                }
                else
                {
                    IEnumerable<FileManagerDirectoryContent> files = extensions.SelectMany(directory.GetFiles)
                            .Select(file => new FileManagerDirectoryContent
                            {
                                Name = file.Name,
                                IsFile = true,
                                Size = file.Length,
                                DateModified = file.LastWriteTime,
                                DateCreated = file.CreationTime,
                                HasChild = false,
                                Type = file.Extension,
                                FilterPath = GetRelativePath(this.contentRootPath, directory.FullName),
                                Permission = GetPermission(directory.FullName, file.Name, true)
                            });
                    readFiles.Files = files.Cast<FileManagerDirectoryContent>().ToList();
                }
                return readFiles.Files;
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected string GetRelativePath(string rootPath, string fullPath)
        {
            if (!String.IsNullOrEmpty(rootPath) && !String.IsNullOrEmpty(fullPath))
            {
                DirectoryInfo rootDirectory;
                if (!string.IsNullOrEmpty(this.hostName))
                {
                    if (rootPath.Contains(this.hostName, StringComparison.OrdinalIgnoreCase))
                    {
                        rootPath = rootPath.Substring(rootPath.IndexOf(this.hostName, StringComparison.OrdinalIgnoreCase) + this.hostName.Length);
                    }
                    if (fullPath.Contains(this.hostName, StringComparison.OrdinalIgnoreCase))
                    {
                        fullPath = fullPath.Substring(fullPath.IndexOf(this.hostName, StringComparison.OrdinalIgnoreCase) + this.hostName.Length);
                    }
                    rootDirectory = new DirectoryInfo(rootPath);
                    fullPath = new DirectoryInfo(fullPath).FullName;
                    rootPath = new DirectoryInfo(rootPath).FullName;
                }
                else
                {
                    rootDirectory = new DirectoryInfo(rootPath);
                }
                if (rootDirectory.FullName.Substring(rootDirectory.FullName.Length - 1) == Path.DirectorySeparatorChar.ToString())
                {
                    if (fullPath.Contains(rootDirectory.FullName, StringComparison.OrdinalIgnoreCase))
                    {
                        return fullPath.Substring(rootPath.Length - 1);
                    }
                }
                else if (fullPath.Contains(rootDirectory.FullName + Path.DirectorySeparatorChar, StringComparison.OrdinalIgnoreCase))
                {
                    return Path.DirectorySeparatorChar + fullPath.Substring(rootPath.Length + 1);
                }
            }
            return String.Empty;
        }

        protected virtual IEnumerable<FileManagerDirectoryContent> ReadDirectories(DirectoryInfo directory, string[] extensions, bool showHiddenItems, params FileManagerDirectoryContent[] data)
        {
            FileManagerResponse<FileManagerDirectoryContent> readDirectory = new FileManagerResponse<FileManagerDirectoryContent>();
            try
            {
                if (directory == null)
                {
                    return Array.Empty<FileManagerDirectoryContent>();
                }
                if (!showHiddenItems)
                {
                    IEnumerable<FileManagerDirectoryContent> directories = directory.GetDirectories().Where(f => (f.Attributes & FileAttributes.Hidden) == 0)
                            .Select(subDirectory => new FileManagerDirectoryContent
                            {
                                Name = subDirectory.Name,
                                Size = 0,
                                IsFile = false,
                                DateModified = subDirectory.LastWriteTime,
                                DateCreated = subDirectory.CreationTime,
                                HasChild = CheckChild(subDirectory.FullName),
                                Type = subDirectory.Extension,
                                FilterPath = GetRelativePath(this.contentRootPath, directory.FullName),
                                Permission = GetPermission(directory.FullName, subDirectory.Name, false)
                            });
                    readDirectory.Files = directories.Cast<FileManagerDirectoryContent>().ToList();
                }
                else
                {
                    IEnumerable<FileManagerDirectoryContent> directories = directory.GetDirectories().Select(subDirectory => new FileManagerDirectoryContent
                    {
                        Name = subDirectory.Name,
                        Size = 0,
                        IsFile = false,
                        DateModified = subDirectory.LastWriteTime,
                        DateCreated = subDirectory.CreationTime,
                        HasChild = CheckChild(subDirectory.FullName),
                        Type = subDirectory.Extension,
                        FilterPath = GetRelativePath(this.contentRootPath, directory.FullName),
                        Permission = GetPermission(directory.FullName, subDirectory.Name, false)
                    });
                    readDirectory.Files = directories.Cast<FileManagerDirectoryContent>().ToList();
                }
                return readDirectory.Files;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<FileManagerResponse<FileManagerDirectoryContent>> Create(string path, string name, params FileManagerDirectoryContent[] data)
        {
            FileManagerResponse<FileManagerDirectoryContent> createResponse = new FileManagerResponse<FileManagerDirectoryContent>();
            try
            {
                string validatePath;
                validatePath = Path.Combine(contentRootPath + path);
                if (Path.GetFullPath(validatePath) != GetFilePath(validatePath))
                {
                    throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                }
                AccessPermission? PathPermission = GetPathPermission(path);
                if (PathPermission != null && (!PathPermission.Read || !PathPermission.WriteContents))
                {
                    accessMessage = PathPermission.Message;
                    throw new UnauthorizedAccessException("'" + FileManagerService.getFileNameFromPath(this.rootName + path) + "' is not accessible. You need permission to perform the writeContents action.");
                }

                string newDirectoryPath = Path.Combine(contentRootPath + path, name);
                if (Path.GetFullPath(newDirectoryPath) != GetFilePath(newDirectoryPath) + Path.GetFileName(newDirectoryPath))
                {
                    throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                }
                bool directoryExist = Directory.Exists(newDirectoryPath);

                if (directoryExist)
                {
                    DirectoryInfo exist = new DirectoryInfo(newDirectoryPath);
                    ErrorDetails er = new ErrorDetails();
                    er.Code = "400";
                    er.Message = "A file or folder with the name " + exist.Name.ToString() + " already exists.";
                    createResponse.Error = er;
                    return await Task.FromResult(createResponse).ConfigureAwait(false);
                }
                await Task.Delay(1000).ConfigureAwait(false);
                string physicalPath = GetPath(path);
                Directory.CreateDirectory(newDirectoryPath);
                DirectoryInfo directory = new DirectoryInfo(newDirectoryPath);
                FileManagerDirectoryContent CreateData = new FileManagerDirectoryContent();
                CreateData.Name = directory.Name;
                CreateData.IsFile = false;
                CreateData.Size = 0;
                CreateData.DateModified = directory.LastWriteTime;
                CreateData.DateCreated = directory.CreationTime;
                CreateData.HasChild = CheckChild(directory.FullName);
                CreateData.Type = directory.Extension;
                CreateData.Permission = GetPermission(physicalPath, directory.Name, false);
                FileManagerDirectoryContent[] newData = new FileManagerDirectoryContent[] { CreateData };
                createResponse.Files = newData.Cast<FileManagerDirectoryContent>().ToList();
                return await Task.FromResult(createResponse).ConfigureAwait(false);
            }
            catch (UnauthorizedAccessException)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = "'" + FileManagerService.getFileNameFromPath(this.rootName + path) + "' is not accessible. You need permission to perform the writeContents action.";
                er.Code = "401";
                if (!string.IsNullOrEmpty(accessMessage)) { er.Message = accessMessage; }
                createResponse.Error = er;
                return createResponse;
            }
            catch (IOException)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = "An IO error occurred while creating the folder.";
                er.Code = "417";
                createResponse.Error = er;
                return createResponse;
            }
            catch (OperationCanceledException e)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = e.Message.ToString();
                er.Code = "417";
                createResponse.Error = er;
                return createResponse;
            }
        }
        public virtual FileManagerResponse<FileManagerDirectoryContent> Details(string path, string[] names, params FileManagerDirectoryContent[] data)
        {
            names = names ?? Array.Empty<string>();
            data = data ?? Array.Empty<FileManagerDirectoryContent>();
            FileManagerResponse<FileManagerDirectoryContent> getDetailResponse = new FileManagerResponse<FileManagerDirectoryContent>();
            FileDetails detailFiles = new FileDetails();
            try
            {
                string validatePath;
                validatePath = Path.Combine(contentRootPath + path);
                if (Path.GetFullPath(validatePath) != GetFilePath(validatePath))
                {
                    throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                }
                if (names.Length == 0 || names.Length == 1)
                {
                    if (path == null) { path = string.Empty; };
                    string fullPath = "";
                    if (names.Length == 0)
                    {
                        fullPath = string.Concat(contentRootPath.AsSpan(), path.AsSpan(0, path.Length - 1));
                    }
                    else if (string.IsNullOrEmpty(names[0]))
                    {
                        fullPath = (contentRootPath + path);
                    }
                    else
                    {
                        fullPath = Path.Combine(contentRootPath + path, names[0]);
                        if (Path.GetFullPath(fullPath) != GetFilePath(fullPath) + Path.GetFileName(fullPath))
                        {
                            throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                        }
                    }
                    string physicalPath = GetPath(path);
                    DirectoryInfo directory = new DirectoryInfo(fullPath);
                    FileInfo info = new FileInfo(fullPath);
                    FileDetails fileDetails = new FileDetails();
                    DirectoryInfo baseDirectory = new DirectoryInfo(string.IsNullOrEmpty(this.hostPath) ? this.contentRootPath : this.hostPath);
                    fileDetails.Name = string.IsNullOrEmpty(info.Name) ? directory.Name : info.Name;
                    fileDetails.IsFile = (File.GetAttributes(fullPath) & FileAttributes.Directory) != FileAttributes.Directory;
                    fileDetails.Size = (File.GetAttributes(fullPath) & FileAttributes.Directory) != FileAttributes.Directory ? byteConversion(info.Length).ToString(CultureInfo.InvariantCulture) : byteConversion(GetDirectorySize(new DirectoryInfo(fullPath), 0)).ToString(CultureInfo.InvariantCulture);
                    fileDetails.Created = info.CreationTime.ToString(CultureInfo.InvariantCulture);
                    fileDetails.Location = GetRelativePath(string.IsNullOrEmpty(this.hostName) ? baseDirectory.Parent?.FullName ?? string.Empty : (baseDirectory.Parent?.FullName ?? string.Empty) + Path.DirectorySeparatorChar, info.FullName).Substring(1);
                    fileDetails.Modified = info.LastWriteTime.ToString(CultureInfo.InvariantCulture);
                    fileDetails.Permission = GetPermission(physicalPath, fileDetails.Name, fileDetails.IsFile);
                    detailFiles = fileDetails;
                }
                else
                {
                    bool isVariousFolders = false;
                    string relativePath = "";
                    string previousPath = "";
                    string previousName = "";
                    FileDetails fileDetails = new FileDetails();
                    fileDetails.Size = "0";
                    DirectoryInfo baseDirectory = new DirectoryInfo(string.IsNullOrEmpty(this.hostPath) ? this.contentRootPath : this.hostPath);
                    string parentPath = baseDirectory.Parent?.FullName ?? string.Empty;
                    string baseDirectoryParentPath = string.IsNullOrEmpty(this.hostName) ? parentPath : parentPath + Path.DirectorySeparatorChar;
                    for (int i = 0; i < names.Length; i++)
                    {
                        string fullPath = "";
                        if (names[i] == null)
                        {
                            fullPath = (contentRootPath + path);
                        }
                        else
                        {
                            fullPath = Path.Combine(contentRootPath + path, names[i]);
                            if (Path.GetFullPath(fullPath) != GetFilePath(fullPath) + Path.GetFileName(fullPath))
                            {
                                throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                            }
                        }
                        FileInfo info = new FileInfo(fullPath);
                        fileDetails.Name = string.IsNullOrEmpty(previousName) ? previousName = data[i].Name : previousName = previousName + ", " + data[i].Name;
                        fileDetails.Size = (long.Parse(fileDetails.Size, CultureInfo.InvariantCulture) + (((File.GetAttributes(fullPath) & FileAttributes.Directory) != FileAttributes.Directory) ? info.Length : GetDirectorySize(new DirectoryInfo(fullPath), 0))).ToString(CultureInfo.InvariantCulture);
                        relativePath = GetRelativePath(baseDirectoryParentPath, info.Directory?.FullName ?? string.Empty);
                        previousPath = string.IsNullOrEmpty(previousPath) ? relativePath : previousPath;
                        if (previousPath == relativePath && !isVariousFolders)
                        {
                            previousPath = relativePath;
                        }
                        else
                        {
                            isVariousFolders = true;
                        }
                    }
                    fileDetails.Size = byteConversion(long.Parse(fileDetails.Size, CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture);
                    fileDetails.MultipleFiles = true;
                    detailFiles = fileDetails;
                }
                getDetailResponse.Details = detailFiles;
                return getDetailResponse;
            }
            catch (UnauthorizedAccessException e)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = e.Message.ToString();
                er.Code = "401";
                getDetailResponse.Error = er;
                return getDetailResponse;
            }
            catch (IOException e)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = e.Message.ToString();
                er.Code = "417";
                getDetailResponse.Error = er;
                return getDetailResponse;
            }
            catch (OperationCanceledException e)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = e.Message.ToString();
                er.Code = "417";
                getDetailResponse.Error = er;
                return getDetailResponse;
            }
        }

        public async Task<FileManagerResponse<FileManagerDirectoryContent>> Delete(string path, string[] names, params FileManagerDirectoryContent[] data)
        {
            names = names ?? Array.Empty<string>();
            FileManagerResponse<FileManagerDirectoryContent> DeleteResponse = new FileManagerResponse<FileManagerDirectoryContent>();
            List<FileManagerDirectoryContent> removedFiles = new List<FileManagerDirectoryContent>();
            string validatePath;
            validatePath = Path.Combine(contentRootPath + path);
            if (Path.GetFullPath(validatePath) != GetFilePath(validatePath))
            {
                throw new UnauthorizedAccessException("Access denied for Directory-traversal");
            }
            try
            {
                string physicalPath = GetPath(path);
                string result = String.Empty;
                for (int i = 0; i < names.Length; i++)
                {
                    bool IsFile = !IsDirectory(physicalPath, names[i]);
                    AccessPermission? permission = GetPermission(physicalPath, names[i], IsFile);
                    if (permission != null && (!permission.Read || !permission.Write))
                    {
                        accessMessage = permission.Message;
                        throw new UnauthorizedAccessException("'" + FileManagerService.getFileNameFromPath(this.rootName + path + names[i]) + "' is not accessible.  you need permission to perform the write action.");
                    }
                }
                FileManagerDirectoryContent removingFile;
                for (int i = 0; i < names.Length; i++)
                {
                    string fullPath = Path.Combine((contentRootPath + path), names[i]);
                    if (Path.GetFullPath(fullPath) != GetFilePath(fullPath) + Path.GetFileName(fullPath))
                    {
                        throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                    }
                    DirectoryInfo directory = new DirectoryInfo(fullPath);
                    if (!string.IsNullOrEmpty(names[i]))
                    {
                        FileAttributes attr = File.GetAttributes(fullPath);
                        removingFile = GetFileDetails(fullPath);
                        //detect whether its a directory or file
                        if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                        {
                            result = DeleteDirectory(fullPath);
                        }
                        else
                        {
                            try
                            {
                                File.Delete(fullPath);
                            }
                            catch (Exception e)
                            {
                                if (e.GetType().Name == "UnauthorizedAccessException")
                                {
                                    result = fullPath;
                                }
                                else
                                {
                                    throw;
                                }
                            }
                        }
                        if (!string.IsNullOrEmpty(result))
                        {
                            break;

                        }
                        removedFiles.Add(removingFile);
                    }
                    else
                    {
                        throw new ArgumentNullException(nameof(names), "name should not be null");
                    }
                }
                DeleteResponse.Files = removedFiles;
                if (!string.IsNullOrEmpty(result))
                {
                    string deniedPath = result.Substring(this.contentRootPath.Length);
                    ErrorDetails er = new ErrorDetails();
                    er.Message = "'" + FileManagerService.getFileNameFromPath(deniedPath) + "' is not accessible.  you need permission to perform the write action.";
                    er.Code = "401";
                    if ((er.Code == "401") && !string.IsNullOrEmpty(accessMessage)) { er.Message = accessMessage; }
                    DeleteResponse.Error = er;
                    return await Task.FromResult(DeleteResponse).ConfigureAwait(false);
                }
                else
                {
                    return await Task.FromResult(DeleteResponse).ConfigureAwait(false);
                }
            }
            catch (UnauthorizedAccessException e)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = e.Message.ToString();
                er.Code = "401";
                if (!string.IsNullOrEmpty(accessMessage)) { er.Message = accessMessage; }
                DeleteResponse.Error = er;
                return DeleteResponse;
            }
            catch (IOException e)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = e.Message.ToString();
                er.Code = "417";
                DeleteResponse.Error = er;
                return DeleteResponse;
            }
            catch (OperationCanceledException e)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = e.Message.ToString();
                er.Code = "417";
                DeleteResponse.Error = er;
                return DeleteResponse;
            }
        }

        public async Task<FileManagerResponse<FileManagerDirectoryContent>> Rename(string path, string name, string newName, bool replace = false, bool showFileExtension = true, params FileManagerDirectoryContent[] data)
        {
            FileManagerResponse<FileManagerDirectoryContent> renameResponse = new FileManagerResponse<FileManagerDirectoryContent>();
            try
            {
                string validatePath;
                validatePath = Path.Combine(contentRootPath + path);
                if (Path.GetFullPath(validatePath) != GetFilePath(validatePath))
                {
                    throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                }
                string physicalPath = GetPath(path);
                if (data == null || data.Length == 0 || data[0] == null)
                {
                    renameResponse.Error = new ErrorDetails
                    {
                        Code = "400",
                        Message = "The file metadata (data[0]) is missing or not provided."
                    };
                    return renameResponse;
                }
                if (!showFileExtension && data[0].IsFile)
                {
                    name = name + data[0].Type;
                    newName = newName + data[0].Type;
                }
                bool IsFile = !IsDirectory(physicalPath, name);
                AccessPermission? permission = GetPermission(physicalPath, name, IsFile);
                if (permission != null && (!permission.Read || !permission.Write))
                {
                    accessMessage = permission.Message;
                    throw new UnauthorizedAccessException("'" + FileManagerService.getFileNameFromPath(this.rootName + path + name) + "' is not accessible. You need permission to perform the write action.");
                }

                string tempPath = (contentRootPath + path);
                string oldPath = Path.Combine(tempPath, name);
                if (Path.GetFullPath(oldPath) != GetFilePath(oldPath) + Path.GetFileName(oldPath))
                {
                    throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                }
                string newPath = Path.Combine(tempPath, newName);
                if (Path.GetFullPath(newPath) != GetFilePath(newPath) + Path.GetFileName(newPath))
                {
                    throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                }
                FileAttributes attr = File.GetAttributes(oldPath);

                FileInfo info = new FileInfo(oldPath);
                bool isFile = (File.GetAttributes(oldPath) & FileAttributes.Directory) != FileAttributes.Directory;
                if (isFile)
                {
                    if (File.Exists(newPath) && !oldPath.Equals(newPath, StringComparison.OrdinalIgnoreCase))
                    {
                        FileInfo exist = new FileInfo(newPath);
                        ErrorDetails er = new ErrorDetails();
                        er.Code = "400";
                        er.Message = "Cannot rename " + exist.Name.ToString() + " to " + newName + ": destination already exists.";
                        renameResponse.Error = er;
                        return await Task.FromResult(renameResponse).ConfigureAwait(false);
                    }
                    info.MoveTo(newPath);
                }
                else
                {
                    bool directoryExist = Directory.Exists(newPath);
                    if (directoryExist && !oldPath.Equals(newPath, StringComparison.OrdinalIgnoreCase))
                    {
                        DirectoryInfo exist = new DirectoryInfo(newPath);
                        ErrorDetails er = new ErrorDetails();
                        er.Code = "400";
                        er.Message = "Cannot rename " + exist.Name.ToString() + " to " + newName + ": destination already exists.";
                        renameResponse.Error = er;

                        return await Task.FromResult(renameResponse).ConfigureAwait(false);
                    }
                    else if (oldPath.Equals(newPath, StringComparison.OrdinalIgnoreCase))
                    {
                        tempPath = Path.Combine(tempPath + "Syncfusion_TempFolder");
                        Directory.Move(oldPath, tempPath);
                        Directory.Move(tempPath, newPath);
                    }
                    else
                    {
                        Directory.Move(oldPath, newPath);
                    }
                }
                FileManagerDirectoryContent[] addedData = new[]{
                        GetFileDetails(newPath)
                    };
                renameResponse.Files = addedData.Cast<FileManagerDirectoryContent>().ToList();
                return await Task.FromResult(renameResponse).ConfigureAwait(false);
            }
            catch (UnauthorizedAccessException)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = "'" + FileManagerService.getFileNameFromPath(this.rootName + path + name) + "' is not accessible. You need permission to perform the write action.";
                er.Code = "401";
                if (!string.IsNullOrEmpty(accessMessage)) { er.Message = accessMessage; }
                renameResponse.Error = er;
                return renameResponse;
            }
            catch (IOException)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = "An IO error occurred while renaming the item.";
                er.Code = "417";
                renameResponse.Error = er;
                return renameResponse;
            }
            catch (OperationCanceledException e)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = e.Message.ToString();
                er.Code = "417";
                renameResponse.Error = er;
                return renameResponse;
            }
        }

        public async Task<FileManagerResponse<FileManagerDirectoryContent>> Copy(string path, string targetPath, string[] names, FileManagerDirectoryContent targetData, params FileManagerDirectoryContent[] data)
        {
            names = names ?? Array.Empty<string>();
            FileManagerResponse<FileManagerDirectoryContent> copyResponse = new FileManagerResponse<FileManagerDirectoryContent>();
            try
            {
                string validatePath;
                validatePath = Path.Combine(contentRootPath + path);
                if (Path.GetFullPath(validatePath) != GetFilePath(validatePath))
                {
                    throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                }
                string result = String.Empty;
                string physicalPath = GetPath(path);
                for (int i = 0; i < names.Length; i++)
                {
                    bool IsFile = !IsDirectory(physicalPath, names[i]);
                    AccessPermission? permission = GetPermission(physicalPath, names[i], IsFile);
                    if (permission != null && (!permission.Read || !permission.Copy))
                    {
                        accessMessage = permission.Message;
                        throw new UnauthorizedAccessException("'" + FileManagerService.getFileNameFromPath(this.rootName + path + names[i]) + "' is not accessible. You need permission to perform the copy action.");
                    }
                }
                AccessPermission? PathPermission = GetPathPermission(targetPath);
                if (PathPermission != null && (!PathPermission.Read || !PathPermission.WriteContents))
                {
                    accessMessage = PathPermission.Message;
                    throw new UnauthorizedAccessException("'" + FileManagerService.getFileNameFromPath(this.rootName + targetPath) + "' is not accessible. You need permission to perform the writeContents action.");
                }


                List<string> existFiles = new List<string>();
                List<string> missingFiles = new List<string>();
                List<FileManagerDirectoryContent> copiedFiles = new List<FileManagerDirectoryContent>();
                string tempPath = path;
                for (int i = 0; i < names.Length; i++)
                {
                    string fullname = names[i];
                    int name = names[i].LastIndexOf('/');
                    if (name >= 0)
                    {
                        path = string.Concat(tempPath.AsSpan(), names[i].AsSpan(0, name + 1));
                        names[i] = names[i].Substring(name + 1);
                    }
                    else
                    {
                        path = tempPath;
                    }
                    string itemPath = Path.Combine(contentRootPath + path, names[i]);
                    if (Path.GetFullPath(itemPath) != GetFilePath(itemPath) + Path.GetFileName(itemPath))
                    {
                        throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                    }
                    if (Directory.Exists(itemPath) || File.Exists(itemPath))
                    {
                        if ((File.GetAttributes(itemPath) & FileAttributes.Directory) == FileAttributes.Directory)
                        {
                            string directoryName = names[i];
                            string oldPath = Path.Combine(contentRootPath + path, directoryName);
                            if (Path.GetFullPath(oldPath) != GetFilePath(oldPath) + Path.GetFileName(oldPath))
                            {
                                throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                            }
                            string newPath = Path.Combine(contentRootPath + targetPath, directoryName);
                            if (Path.GetFullPath(newPath) != GetFilePath(newPath) + Path.GetFileName(newPath))
                            {
                                throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                            }
                            bool exist = Directory.Exists(newPath);
                            if (exist)
                            {
                                if ((newPath == oldPath))
                                {
                                    newPath = DirectoryRename(newPath);
                                    result = DirectoryCopy(oldPath, newPath);
                                    if (!string.IsNullOrEmpty(result)) { break; }
                                    FileManagerDirectoryContent detail = GetFileDetails(newPath);
                                    detail.PreviousName = names[i];
                                    copiedFiles.Add(detail);
                                }
                                else
                                {
                                    existFiles.Add(fullname);
                                }
                            }
                            else
                            {
                                result = DirectoryCopy(oldPath, newPath);
                                if (!string.IsNullOrEmpty(result)) { break; }
                                FileManagerDirectoryContent detail = GetFileDetails(newPath);
                                detail.PreviousName = names[i];
                                copiedFiles.Add(detail);
                            }
                        }
                        else
                        {
                            string fileName = names[i];
                            string oldPath = Path.Combine(contentRootPath + path, fileName);
                            if (Path.GetFullPath(oldPath) != GetFilePath(oldPath) + Path.GetFileName(oldPath))
                            {
                                throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                            }
                            string newPath = Path.Combine(contentRootPath + targetPath, fileName);
                            if (Path.GetFullPath(newPath) != GetFilePath(newPath) + Path.GetFileName(newPath))
                            {
                                throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                            }
                            bool fileExist = System.IO.File.Exists(newPath);
                            try
                            {

                                if (fileExist)
                                {
                                    if ((newPath == oldPath))
                                    {
                                        newPath = FileRename(newPath, fileName);
                                        File.Copy(oldPath, newPath);
                                        FileManagerDirectoryContent detail = GetFileDetails(newPath);
                                        detail.PreviousName = names[i];
                                        copiedFiles.Add(detail);
                                    }
                                    else
                                    {
                                        existFiles.Add(fullname);
                                    }
                                }
                                else
                                {
                                    File.Copy(oldPath, newPath);
                                    FileManagerDirectoryContent detail = GetFileDetails(newPath);
                                    detail.PreviousName = names[i];
                                    copiedFiles.Add(detail);
                                }
                            }
                            catch (Exception e)
                            {
                                if (e.GetType().Name == "UnauthorizedAccessException")
                                {
                                    result = newPath;
                                    break;
                                }
                                else
                                {
                                    throw;
                                }
                            }
                        }
                    }
                    else
                    {
                        missingFiles.Add(names[i]);
                    }
                }
                copyResponse.Files = copiedFiles;
                await Task.Delay(1000).ConfigureAwait(false);
                if (!string.IsNullOrEmpty(result))
                {
                    string deniedPath = result.Substring(this.contentRootPath.Length);
                    ErrorDetails er = new ErrorDetails();
                    er.Message = "'" + FileManagerService.getFileNameFromPath(deniedPath) + "' is not accessible. You need permission to perform the copy action.";
                    er.Code = "401";
                    copyResponse.Error = er;
                    return await Task.FromResult(copyResponse).ConfigureAwait(false);
                }

                if (existFiles.Count > 0)
                {
                    ErrorDetails er = new ErrorDetails();
                    er.FileExists = existFiles;
                    er.Code = "400";
                    er.Message = "File Already Exists";
                    copyResponse.Error = er;
                }
                if (missingFiles.Count == 0)
                {
                    return await Task.FromResult(copyResponse).ConfigureAwait(false);
                }
                else
                {
                    string namelist = missingFiles[0];
                    for (int k = 1; k < missingFiles.Count; k++)
                    {
                        namelist = namelist + ", " + missingFiles[k];
                    }
                    throw new FileNotFoundException(namelist + " not found in given location.");
                }
            }
            catch (UnauthorizedAccessException)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = "'" + FileManagerService.getFileNameFromPath(this.rootName + path) + "' is not accessible. You need permission to perform the copy action.";
                er.Code = "401";
                if (!string.IsNullOrEmpty(accessMessage)) { er.Message = accessMessage; }
                er.FileExists = copyResponse.Error?.FileExists;
                copyResponse.Error = er;
                return copyResponse;
            }
            catch (FileNotFoundException)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = "One or more files were not found in the given location.";
                er.Code = "417";
                er.FileExists = copyResponse.Error?.FileExists;
                copyResponse.Error = er;
                return copyResponse;
            }
            catch (IOException)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = "An IO error occurred while copying files.";
                er.Code = "417";
                er.FileExists = copyResponse.Error?.FileExists;
                copyResponse.Error = er;
                return copyResponse;
            }
            catch (OperationCanceledException e)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = e.Message.ToString();
                er.Code = "417";
                er.FileExists = copyResponse.Error?.FileExists;
                copyResponse.Error = er;
                return copyResponse;
            }
        }

        public async Task<FileManagerResponse<FileManagerDirectoryContent>> Move(string path, string targetPath, string[] names, FileManagerDirectoryContent targetData, params FileManagerDirectoryContent[] data)
        {
            names = names ?? Array.Empty<string>();
            FileManagerResponse<FileManagerDirectoryContent> moveResponse = new FileManagerResponse<FileManagerDirectoryContent>();
            try
            {
                string validatePath;
                validatePath = Path.Combine(contentRootPath + path);
                if (Path.GetFullPath(validatePath) != GetFilePath(validatePath))
                {
                    throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                }
                string result = String.Empty;
                string physicalPath = GetPath(path);
                for (int i = 0; i < names.Length; i++)
                {
                    bool IsFile = !IsDirectory(physicalPath, names[i]);
                    AccessPermission? permission = GetPermission(physicalPath, names[i], IsFile);
                    if (permission != null && (!permission.Read || !permission.Write))
                    {
                        accessMessage = permission.Message;
                        throw new UnauthorizedAccessException("'" + FileManagerService.getFileNameFromPath(this.rootName + path + names[i]) + "' is not accessible. You need permission to perform the write action.");
                    }
                }
                AccessPermission? PathPermission = GetPathPermission(targetPath);
                if (PathPermission != null && (!PathPermission.Read || !PathPermission.WriteContents))
                {
                    accessMessage = PathPermission.Message;
                    throw new UnauthorizedAccessException("'" + FileManagerService.getFileNameFromPath(this.rootName + targetPath) + "' is not accessible. You need permission to perform the writeContents action.");
                }

                List<string> existFiles = new List<string>();
                List<string> missingFiles = new List<string>();
                List<FileManagerDirectoryContent> movedFiles = new List<FileManagerDirectoryContent>();
                string tempPath = path;
                for (int i = 0; i < names.Length; i++)
                {
                    string fullName = names[i];
                    int name = names[i].LastIndexOf('/');
                    if (name >= 0)
                    {
                        path = string.Concat(tempPath.AsSpan(), names[i].AsSpan(0, name + 1));
                        names[i] = names[i].Substring(name + 1);
                    }
                    else
                    {
                        path = tempPath;
                    }
                    string itemPath = Path.Combine(contentRootPath + path, names[i]);
                    if (Path.GetFullPath(itemPath) != GetFilePath(itemPath) + Path.GetFileName(itemPath))
                    {
                        throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                    }
                    if (Directory.Exists(itemPath) || File.Exists(itemPath))
                    {
                        if ((File.GetAttributes(itemPath) & FileAttributes.Directory) == FileAttributes.Directory)
                        {
                            string directoryName = names[i];
                            string oldPath = Path.Combine(contentRootPath + path, directoryName);
                            if (Path.GetFullPath(oldPath) != GetFilePath(oldPath) + Path.GetFileName(oldPath))
                            {
                                throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                            }
                            string newPath = Path.Combine(contentRootPath + targetPath, directoryName);
                            if (Path.GetFullPath(newPath) != GetFilePath(newPath) + Path.GetFileName(newPath))
                            {
                                throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                            }
                            bool exist = Directory.Exists(newPath);
                            if (exist)
                            {
                                if ((newPath == oldPath))
                                {
                                    newPath = DirectoryRename(newPath);
                                    result = DirectoryCopy(oldPath, newPath);
                                    if (!string.IsNullOrEmpty(result)) { break; }
                                    bool isExist = Directory.Exists(oldPath);
                                    if (isExist)
                                    {
                                        result = DeleteDirectory(oldPath);
                                        if (!string.IsNullOrEmpty(result)) { break; }
                                    }
                                    FileManagerDirectoryContent detail = GetFileDetails(newPath);
                                    detail.PreviousName = names[i];
                                    movedFiles.Add(detail);
                                }
                                else
                                {
                                    existFiles.Add(fullName);
                                }
                            }
                            else
                            {
                                result = DirectoryCopy(oldPath, newPath);
                                if (!string.IsNullOrEmpty(result)) { break; }
                                bool isExist = Directory.Exists(oldPath);
                                if (isExist)
                                {
                                    result = DeleteDirectory(oldPath);
                                    if (!string.IsNullOrEmpty(result)) { break; }
                                }
                                FileManagerDirectoryContent detail = GetFileDetails(newPath);
                                detail.PreviousName = names[i];
                                movedFiles.Add(detail);
                            }
                        }
                        else
                        {
                            string fileName = names[i];
                            string oldPath = Path.Combine(contentRootPath + path, fileName);
                            if (Path.GetFullPath(oldPath) != GetFilePath(oldPath) + Path.GetFileName(oldPath))
                            {
                                throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                            }
                            string newPath = Path.Combine(contentRootPath + targetPath, fileName);
                            if (Path.GetFullPath(newPath) != GetFilePath(newPath) + Path.GetFileName(newPath))
                            {
                                throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                            }
                            bool fileExist = File.Exists(newPath);
                            try
                            {

                                if (fileExist)
                                {
                                    if ((newPath == oldPath))
                                    {
                                        newPath = FileRename(newPath, fileName);
                                        File.Copy(oldPath, newPath);
                                        bool isExist = File.Exists(oldPath);
                                        if (isExist)
                                        {
                                            File.Delete(oldPath);
                                        }
                                        FileManagerDirectoryContent detail = GetFileDetails(newPath);
                                        detail.PreviousName = names[i];
                                        movedFiles.Add(detail);
                                    }
                                    else
                                    {
                                        existFiles.Add(fullName);
                                    }
                                }
                                else
                                {
                                    File.Copy(oldPath, newPath);
                                    bool isExist = File.Exists(oldPath);
                                    if (isExist)
                                    {
                                        File.Delete(oldPath);
                                    }
                                    FileManagerDirectoryContent detail = GetFileDetails(newPath);
                                    detail.PreviousName = names[i];
                                    movedFiles.Add(detail);
                                }

                            }
                            catch (Exception e)
                            {
                                if (e.GetType().Name == "UnauthorizedAccessException")
                                {
                                    result = newPath;
                                    break;
                                }
                                else
                                {
                                    throw;
                                }
                            }
                        }
                    }
                    else
                    {
                        missingFiles.Add(names[i]);
                    }
                }
                moveResponse.Files = movedFiles;
                await Task.Delay(1000).ConfigureAwait(false);
                if (!string.IsNullOrEmpty(result))
                {
                    string deniedPath = result.Substring(this.contentRootPath.Length);
                    ErrorDetails er = new ErrorDetails();
                    er.Message = "'" + FileManagerService.getFileNameFromPath(deniedPath) + "' is not accessible. You need permission to perform this action.";
                    er.Code = "401";
                    moveResponse.Error = er;
                    return await Task.FromResult(moveResponse).ConfigureAwait(false);
                }
                if (existFiles.Count > 0)
                {
                    ErrorDetails er = new ErrorDetails();
                    er.FileExists = existFiles;
                    er.Code = "400";
                    er.Message = "File Already Exists";
                    moveResponse.Error = er;
                }
                if (missingFiles.Count == 0)
                {
                    return await Task.FromResult(moveResponse).ConfigureAwait(false);
                }
                else
                {
                    string namelist = missingFiles[0];
                    for (int k = 1; k < missingFiles.Count; k++)
                    {
                        namelist = namelist + ", " + missingFiles[k];
                    }
                    throw new FileNotFoundException(namelist + " not found in given location.");
                }
            }
            catch (UnauthorizedAccessException)
            {
                ErrorDetails er = new ErrorDetails
                {
                    Message = "'" + FileManagerService.getFileNameFromPath(this.rootName + path) + "' is not accessible. You need permission to perform this action.",
                    Code = "401",
                    FileExists = moveResponse.Error?.FileExists
                };
                if (!string.IsNullOrEmpty(accessMessage)) { er.Message = accessMessage; }
                moveResponse.Error = er;
                return moveResponse;
            }
            catch (FileNotFoundException)
            {
                ErrorDetails er = new ErrorDetails
                {
                    Message = "One or more files were not found in the given location.",
                    Code = "417",
                    FileExists = moveResponse.Error?.FileExists
                };
                moveResponse.Error = er;
                return moveResponse;
            }
            catch (IOException)
            {
                ErrorDetails er = new ErrorDetails
                {
                    Message = "An IO error occurred while moving files.",
                    Code = "417",
                    FileExists = moveResponse.Error?.FileExists
                };
                moveResponse.Error = er;
                return moveResponse;
            }
            catch (OperationCanceledException e)
            {
                ErrorDetails er = new ErrorDetails
                {
                    Message = e.Message.ToString(),
                    Code = "417",
                    FileExists = moveResponse.Error?.FileExists
                };
                moveResponse.Error = er;
                return moveResponse;
            }
        }

        public async Task<FileManagerResponse<FileManagerDirectoryContent>> Search(string path, string searchString, bool showHiddenItems = false, bool caseSensitive = false, bool isTagSearch = false, params FileManagerDirectoryContent[] data)
        {
            FileManagerResponse<FileManagerDirectoryContent> searchResponse = new FileManagerResponse<FileManagerDirectoryContent>();
            try
            {
                if (path == null) { path = string.Empty; };
                string searchWord = searchString;
                path = isTagSearch ? "/" : path;
                string searchPath = (this.contentRootPath + path);
                DirectoryInfo directory = new DirectoryInfo(this.contentRootPath + path);
                FileManagerDirectoryContent cwd = new FileManagerDirectoryContent();
                cwd.Name = directory.Name;
                cwd.Size = 0;
                cwd.IsFile = false;
                cwd.DateModified = directory.LastWriteTime;
                cwd.DateCreated = directory.CreationTime;
                string rootPath = string.IsNullOrEmpty(this.hostPath) ? this.contentRootPath : new DirectoryInfo(this.hostPath).FullName;
                string parentPath = string.IsNullOrEmpty(this.hostPath) ? directory.Parent?.FullName ?? string.Empty : new DirectoryInfo(this.hostPath + (path != "/" ? path : "")).Parent?.FullName ?? string.Empty;
                cwd.HasChild = CheckChild(directory.FullName);
                cwd.Type = directory.Extension;
                cwd.FilterPath = GetRelativePath(rootPath, parentPath + Path.DirectorySeparatorChar);
                cwd.Permission = GetPathPermission(path);
                if (cwd.Permission != null && !cwd.Permission.Read)
                {
                    accessMessage = cwd.Permission.Message;
                    throw new UnauthorizedAccessException("'" + FileManagerService.getFileNameFromPath(this.rootName + path) + "' is not accessible. You need permission to perform the read action.");
                }
                searchResponse.CWD = cwd;

                List<FileManagerDirectoryContent> foundedFiles = new List<FileManagerDirectoryContent>();
                string[] extensions = this.allowedExtension.ToArray();
                DirectoryInfo searchDirectory = new DirectoryInfo(searchPath);
                List<FileInfo> files = new List<FileInfo>();
                List<DirectoryInfo> directories = new List<DirectoryInfo>();
                if (showHiddenItems)
                {
                    IEnumerable<FileInfo> filteredFileList = GetDirectoryFiles(searchDirectory, files).
                        Where(item => new Regex(WildcardToRegex("*"), (caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase)).IsMatch(item.Name));
                    IEnumerable<DirectoryInfo> filteredDirectoryList = GetDirectoryFolders(searchDirectory, directories).
                        Where(item => new Regex(WildcardToRegex("*"), (caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase)).IsMatch(item.Name));
                    foreach (FileInfo file in filteredFileList)
                    {
                        FileManagerDirectoryContent fileDetails = GetFileDetails(Path.Combine(this.contentRootPath, file.DirectoryName ?? string.Empty, file.Name));
                        bool hasPermission = parentsHavePermission(fileDetails);
                        if (hasPermission)
                        {
                            foundedFiles.Add(fileDetails);
                        }
                    }
                    foreach (DirectoryInfo dir in filteredDirectoryList)
                    {
                        FileManagerDirectoryContent dirDetails = GetFileDetails(Path.Combine(this.contentRootPath, dir.FullName));
                        bool hasPermission = parentsHavePermission(dirDetails);
                        if (hasPermission)
                        {
                            foundedFiles.Add(dirDetails);
                        }
                    }
                }
                else
                {
                    IEnumerable<FileInfo> filteredFileList = GetDirectoryFiles(searchDirectory, files).
                       Where(item => new Regex(WildcardToRegex("*"), (caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase)).IsMatch(item.Name) && (item.Attributes & FileAttributes.Hidden) == 0);
                    IEnumerable<DirectoryInfo> filteredDirectoryList = GetDirectoryFolders(searchDirectory, directories).
                        Where(item => new Regex(WildcardToRegex("*"), (caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase)).IsMatch(item.Name) && (item.Attributes & FileAttributes.Hidden) == 0);
                    foreach (DirectoryInfo dir in filteredDirectoryList)
                    {
                        FileManagerDirectoryContent dirDetails = GetFileDetails(Path.Combine(this.contentRootPath, dir.FullName));
                        bool hasPermission = parentsHavePermission(dirDetails);
                        if (hasPermission)
                        {
                            foundedFiles.Add(dirDetails);
                        }
                    }
                    foreach (FileInfo file in filteredFileList)
                    {
                        FileManagerDirectoryContent fileDetails = GetFileDetails(Path.Combine(this.contentRootPath, file.DirectoryName ?? string.Empty, file.Name));
                        bool hasPermission = parentsHavePermission(fileDetails);
                        if (hasPermission)
                        {
                            foundedFiles.Add(fileDetails);
                        }
                    }
                }
                if (!string.IsNullOrEmpty(searchString))
                {
                    if (isTagSearch)
                    {
                        List<FileManagerDirectoryContent> filteredTagFiles = new List<FileManagerDirectoryContent>();
                        foreach (var file in foundedFiles)
                        {
                            if (file.IsFile)
                            {
                                string[] fileTags = GetTagsFromFile(Path.Combine(this.contentRootPath + file.FilterPath, file.Name));
                                if (fileTags.Any(tag => tag.Contains(searchString.Replace("*", "", StringComparison.Ordinal), StringComparison.OrdinalIgnoreCase)))
                                {
                                    filteredTagFiles.Add(file);
                                }
                            }
                        }
                        searchResponse.Files = filteredTagFiles;
                    }
                    else
                    {
                        using var embedder = new LocalEmbedder();
                        foreach (var category in foundedFiles)
                        {
                            string key = category.FilterPath + category.Name;
                            try
                            {
                                if (!FileEmbeddings.ContainsKey(key))
                                {
                                    FileEmbeddings.Add(key, embedder.Embed($"{category.Name}"));
                                }
                            }
                            catch (InvalidOperationException)
                            {
                                // Skip files that cannot be embedded due to invalid operations
                                continue;
                            }
                            catch (OutOfMemoryException)
                            {
                                // Skip files that cause memory issues during embedding
                                continue;
                            }
                            catch (ArgumentException)
                            {
                                // Skip files with invalid arguments for embedding
                                continue;
                            }

                        }
                        using var targetEmbedder = new LocalEmbedder();
                        var queryVector = targetEmbedder.Embed(searchString);
                        List<FileManagerDirectoryContent> filteredCategories = new List<FileManagerDirectoryContent>();
                        foreach (FileManagerDirectoryContent item in foundedFiles)
                        {
                            double similarity = LocalEmbedder.Similarity(FileEmbeddings[item.FilterPath + item.Name], queryVector);
                            if (similarity > 0.35)
                            {
                                filteredCategories.Add(item);
                            }
                        }
                        searchResponse.Files = filteredCategories;
                    }
                }
                else
                {
                    searchResponse.Files = foundedFiles;
                }
                return await Task.FromResult(searchResponse).ConfigureAwait(false);
            }
            catch (UnauthorizedAccessException e)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = e.Message.ToString();
                er.Code = "401";
                if (!string.IsNullOrEmpty(accessMessage)) { er.Message = accessMessage; }
                searchResponse.Error = er;
                return await Task.FromResult(searchResponse).ConfigureAwait(false);
            }
            catch (IOException e)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = e.Message.ToString();
                er.Code = "417";
                searchResponse.Error = er;
                return await Task.FromResult(searchResponse).ConfigureAwait(false);
            }
            catch (OperationCanceledException e)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = e.Message.ToString();
                er.Code = "417";
                searchResponse.Error = er;
                return await Task.FromResult(searchResponse).ConfigureAwait(false);
            }
        }

        private string GetTagsIndexPath()
        {
            var tagsDir = Path.Combine(this.DemoBaseDirectory, ".tags");
            if (!Directory.Exists(tagsDir))
            {
                Directory.CreateDirectory(tagsDir);
            }
            return Path.Combine(tagsDir, "index.json");
        }

        private string GetRelativeKeyForFile(string filePath)
        {
            var rel = Path.GetRelativePath(this.contentRootPath, filePath);
            return rel.Replace('\\', '/');
        }

        private Dictionary<string, string[]> LoadTagIndex()
        {
            var indexPath = GetTagsIndexPath();
            if (!File.Exists(indexPath))
            {
                return new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase);
            }

            try
            {
                var json = File.ReadAllText(indexPath);
                var dict = JsonSerializer.Deserialize<Dictionary<string, string[]>>(json);
                return dict ?? new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase);
            }
            catch (JsonException)
            {
                return new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase);
            }
            catch (IOException)
            {
                return new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase);
            }
        }

        private void SaveTagIndex(Dictionary<string, string[]> index)
        {
            var indexPath = GetTagsIndexPath();
            var json = JsonSerializer.Serialize(index, JsonOptions);
            File.WriteAllText(indexPath, json);
        }

        public void TagInitialFiles()
        {
            DirectoryInfo rootDirectory = new DirectoryInfo(this.contentRootPath);
            IEnumerable<FileInfo> filteredFileList = GetDirectoryFiles(rootDirectory, new List<FileInfo>()).
                       Where(item => new Regex(WildcardToRegex("*"), (false ? RegexOptions.None : RegexOptions.IgnoreCase)).IsMatch(item.Name) && (item.Attributes & FileAttributes.Hidden) == 0);
            foreach (FileInfo file in filteredFileList)
            {
                FileManagerDirectoryContent fileDetails = GetFileDetails(Path.Combine(this.contentRootPath, file.DirectoryName ?? string.Empty, file.Name));
                bool hasPermission = parentsHavePermission(fileDetails);
                if (hasPermission)
                {
                    List<ChipItem> tags = TagService.GetTags(fileDetails.Name).Select(tag => new ChipItem { Text = tag }).ToList();
                    string filePath = Path.Combine(this.contentRootPath, file.DirectoryName ?? string.Empty, file.Name);
                    UpdateTagsToFile(filePath, tags);
                }
            }

        }

        public void UpdateTagsToFile(string filePath, IReadOnlyList<ChipItem> newTags)
        {
            var index = LoadTagIndex();

            var key = GetRelativeKeyForFile(filePath);
            if (!index.TryGetValue(key, out var existing))
            {
                existing = Array.Empty<string>();
            }

            var merged = existing
                .Concat(newTags.Select(t => t.Text))
                .Where(t => !string.IsNullOrWhiteSpace(t))
                .Select(t => t.Trim())
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToArray();

            index[key] = merged;
            SaveTagIndex(index);
        }

        public string[] GetTagsFromFile(string filePath)
        {
            var index = LoadTagIndex();
            var key = GetRelativeKeyForFile(filePath);
            if (index.TryGetValue(key, out var tags) && tags != null)
            {
                return tags;
            }
            return Array.Empty<string>();
        }

        public void RemoveTagsFromFile(string filePath, string[] tagsToRemove)
        {
            if (tagsToRemove == null || tagsToRemove.Length == 0) return;

            var index = LoadTagIndex();
            var key = GetRelativeKeyForFile(filePath);

            if (!index.TryGetValue(key, out var existing) || existing == null || existing.Length == 0)
            {
                return;
            }

            var updated = existing
                .Where(t => !tagsToRemove.Contains(t, StringComparer.OrdinalIgnoreCase))
                .ToArray();

            if (updated.Length == 0)
            {
                index.Remove(key);
            }
            else
            {
                index[key] = updated;
            }
            SaveTagIndex(index);
        }

        public Task EmbedInitialFiles()
        {
            DirectoryInfo rootDirectory = new DirectoryInfo(this.contentRootPath);
            IEnumerable<FileInfo> filteredFileList = GetDirectoryFiles(rootDirectory, new List<FileInfo>()).
                       Where(item => new Regex(WildcardToRegex("*"), (false ? RegexOptions.None : RegexOptions.IgnoreCase)).IsMatch(item.Name) && (item.Attributes & FileAttributes.Hidden) == 0);
            IEnumerable<DirectoryInfo> filteredDirectoryList = GetDirectoryFolders(rootDirectory, new List<DirectoryInfo>()).
                Where(item => new Regex(WildcardToRegex("*"), (false ? RegexOptions.None : RegexOptions.IgnoreCase)).IsMatch(item.Name) && (item.Attributes & FileAttributes.Hidden) == 0);
            using var embedder = new LocalEmbedder();
            foreach (DirectoryInfo dir in filteredDirectoryList)
            {
                FileManagerDirectoryContent dirDetails = GetFileDetails(Path.Combine(this.contentRootPath, dir.FullName));
                bool hasPermission = parentsHavePermission(dirDetails);
                if (hasPermission)
                {
                    string key = dirDetails.FilterPath + dirDetails.Name;
                    if (!FileEmbeddings.ContainsKey(key))
                    {
                        FileEmbeddings.Add(key, embedder.Embed($"{dirDetails.Name}"));
                    }
                }
            }
            foreach (FileInfo file in filteredFileList)
            {
                FileManagerDirectoryContent fileDetails = GetFileDetails(Path.Combine(this.contentRootPath, file.DirectoryName ?? string.Empty, file.Name));
                bool hasPermission = parentsHavePermission(fileDetails);
                if (hasPermission)
                {
                    string key = fileDetails.FilterPath + fileDetails.Name;
                    if (!FileEmbeddings.ContainsKey(key))
                    {
                        FileEmbeddings.Add(key, embedder.Embed($"{fileDetails.Name}"));
                    }
                }
            }
            return Task.CompletedTask;
        }

        protected static String byteConversion(long fileSize)
        {
            try
            {
                string[] index = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
                if (fileSize == 0)
                {
                    return "0 " + index[0];
                }

                long bytes = Math.Abs(fileSize);
                int loc = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
                double num = Math.Round(bytes / Math.Pow(1024, loc), 1);
                return (Math.Sign(fileSize) * num).ToString(CultureInfo.InvariantCulture) + " " + index[loc];
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected virtual string WildcardToRegex(string pattern)
        {
            return "^" + Regex.Escape(pattern)
                              .Replace(@"\*", ".*", StringComparison.Ordinal)
                              .Replace(@"\?", ".", StringComparison.Ordinal)
                       + "$";
        }

        public async Task<FileStreamResult?> GetImage(string path, bool allowCompress, params FileManagerDirectoryContent[] data)
        {
            try
            {
                AccessPermission? PathPermission = GetFilePermission(path);
                if (PathPermission != null && !PathPermission.Read)
                    return null;
                String fullPath = (contentRootPath + path);
                if (Path.GetFullPath(fullPath) != GetFilePath(fullPath) + FileManagerService.getFileNameFromPath(fullPath))
                {
                    throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                }
                FileStream fileStreamInput = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
                FileStreamResult fileStreamResult = new FileStreamResult(fileStreamInput, "APPLICATION/octet-stream");
                return await Task.FromResult(fileStreamResult).ConfigureAwait(false);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual FileManagerResponse<FileManagerDirectoryContent> Upload(string path, IList<IFormFile> uploadFiles, string action, params FileManagerDirectoryContent[] data)
        {
            path = path ?? string.Empty;
            uploadFiles = uploadFiles ?? Array.Empty<IFormFile>();
            FileManagerResponse<FileManagerDirectoryContent> uploadResponse = new FileManagerResponse<FileManagerDirectoryContent>();
            try
            {
                string validatePath;
                validatePath = Path.Combine(contentRootPath + path);
                if (Path.GetFullPath(validatePath) != GetFilePath(validatePath))
                {
                    throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                }
                AccessPermission? PathPermission = GetPathPermission(path);
                if (PathPermission != null && (!PathPermission.Read || !PathPermission.Upload))
                {
                    accessMessage = PathPermission.Message;
                    throw new UnauthorizedAccessException("'" + FileManagerService.getFileNameFromPath(this.rootName + path) + "' is not accessible. You need permission to perform the upload action.");
                }

                List<string> existFiles = new List<string>();
                foreach (IFormFile file in uploadFiles)
                {
                    var name = file.FileName;
                    string[] folders = name.Split('/');
                    string fileName = folders[folders.Length - 1];
                    var fullName = Path.Combine((this.contentRootPath + path), fileName);
                    if (Path.GetFullPath(fullName) != GetFilePath(fullName) + Path.GetFileName(fullName))
                    {
                        throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                    }
                    if (action == "save")
                    {
                        if (!System.IO.File.Exists(fullName))
                        {
                            using (FileStream fs = System.IO.File.Create(fullName))
                            {
                                file.CopyTo(fs);
                                fs.Flush();
                            }
                        }
                        else
                        {
                            existFiles.Add(fullName);
                        }
                    }
                    else if (action == "remove")
                    {
                        if (System.IO.File.Exists(fullName))
                        {
                            System.IO.File.Delete(fullName);
                        }
                        else
                        {
                            ErrorDetails er = new ErrorDetails();
                            er.Code = "404";
                            er.Message = "File not found.";
                            uploadResponse.Error = er;
                        }
                    }
                    else if (action == "replace")
                    {
                        if (System.IO.File.Exists(fullName))
                        {
                            System.IO.File.Delete(fullName);
                        }
                        using (FileStream fs = System.IO.File.Create(fullName))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                    else if (action == "keepboth")
                    {
                        string newName = fullName;
                        int index = newName.LastIndexOf('.');
                        if (index >= 0)
                            newName = newName.Substring(0, index);
                        int fileCount = 0;
                        while (System.IO.File.Exists(newName + (fileCount > 0 ? "(" + fileCount.ToString(CultureInfo.InvariantCulture) + ")" + Path.GetExtension(name) : Path.GetExtension(name))))
                        {
                            fileCount++;
                        }
                        newName = newName + (fileCount > 0 ? "(" + fileCount.ToString(CultureInfo.InvariantCulture) + ")" : "") + Path.GetExtension(name);
                        using (FileStream fs = System.IO.File.Create(newName))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }
                if (existFiles.Count != 0)
                {
                    ErrorDetails er = new ErrorDetails();
                    er.Code = "400";
                    er.Message = "File already exists.";
                    er.FileExists = existFiles;
                    uploadResponse.Error = er;
                }
                return uploadResponse;
            }
            catch (UnauthorizedAccessException)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = "'" + FileManagerService.getFileNameFromPath(path) + "' is not accessible. You need permission to perform the upload action.";
                er.Code = "401";
                if (!string.IsNullOrEmpty(accessMessage)) { er.Message = accessMessage; }
                uploadResponse.Error = er;
                return uploadResponse;
            }
            catch (IOException)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = "An IO error occurred during file upload.";
                er.Code = "417";
                uploadResponse.Error = er;
                return uploadResponse;
            }
            catch (OperationCanceledException)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = "The upload operation was cancelled.";
                er.Code = "417";
                uploadResponse.Error = er;
                return uploadResponse;
            }
        }

        public virtual FileManagerResponse<FileManagerDirectoryContent> UploadFlatData(string path, IReadOnlyList<Syncfusion.Blazor.Inputs.FileInfo> uploadFiles, string action, params FileManagerDirectoryContent[] data)
        {
            path = path ?? string.Empty;
            uploadFiles = uploadFiles ?? Array.Empty<Syncfusion.Blazor.Inputs.FileInfo>();
            FileManagerResponse<FileManagerDirectoryContent> uploadResponse = new FileManagerResponse<FileManagerDirectoryContent>();
            try
            {
                string validatePath;
                validatePath = Path.Combine(contentRootPath + path);
                if (Path.GetFullPath(validatePath) != GetFilePath(validatePath))
                {
                    throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                }
                AccessPermission? PathPermission = GetPathPermission(path);
                if (PathPermission != null && (!PathPermission.Read || !PathPermission.Upload))
                {
                    accessMessage = PathPermission.Message;
                    throw new UnauthorizedAccessException("'" + FileManagerService.getFileNameFromPath(this.rootName + path) + "' is not accessible. You need permission to perform the upload action.");
                }

                List<string> existFiles = new List<string>();
                foreach (IFormFile file in uploadFiles)
                {
                    var name = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim().ToString();
                    string[] folders = name.Split('/');
                    string fileName = folders[folders.Length - 1];
                    var fullName = Path.Combine((this.contentRootPath + path), fileName);
                    if (Path.GetFullPath(fullName) != GetFilePath(fullName) + Path.GetFileName(fullName))
                    {
                        throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                    }
                    if (action == "save")
                    {
                        if (!System.IO.File.Exists(fullName))
                        {
                            using (FileStream fs = System.IO.File.Create(fullName))
                            {
                                file.CopyTo(fs);
                                fs.Flush();
                            }
                        }
                        else
                        {
                            existFiles.Add(fullName);
                        }
                    }
                    else if (action == "remove")
                    {
                        if (System.IO.File.Exists(fullName))
                        {
                            System.IO.File.Delete(fullName);
                        }
                        else
                        {
                            ErrorDetails er = new ErrorDetails();
                            er.Code = "404";
                            er.Message = "File not found.";
                            uploadResponse.Error = er;
                        }
                    }
                    else if (action == "replace")
                    {
                        if (System.IO.File.Exists(fullName))
                        {
                            System.IO.File.Delete(fullName);
                        }
                        using (FileStream fs = System.IO.File.Create(fullName))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                    else if (action == "keepboth")
                    {
                        string newName = fullName;
                        int index = newName.LastIndexOf('.');
                        if (index >= 0)
                            newName = newName.Substring(0, index);
                        int fileCount = 0;
                        while (System.IO.File.Exists(newName + (fileCount > 0 ? "(" + fileCount.ToString(CultureInfo.InvariantCulture) + ")" + Path.GetExtension(name) : Path.GetExtension(name))))
                        {
                            fileCount++;
                        }
                        newName = newName + (fileCount > 0 ? "(" + fileCount.ToString(CultureInfo.InvariantCulture) + ")" : "") + Path.GetExtension(name);
                        using (FileStream fs = System.IO.File.Create(newName))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }
                if (existFiles.Count != 0)
                {
                    ErrorDetails er = new ErrorDetails();
                    er.Code = "400";
                    er.Message = "File already exists.";
                    er.FileExists = existFiles;
                    uploadResponse.Error = er;
                }
                return uploadResponse;
            }
            catch (UnauthorizedAccessException)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = "'" + FileManagerService.getFileNameFromPath(path) + "' is not accessible. You need permission to perform the upload action.";
                er.Code = "401";
                if (!string.IsNullOrEmpty(accessMessage)) { er.Message = accessMessage; }
                uploadResponse.Error = er;
                return uploadResponse;
            }
            catch (IOException)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = "An IO error occurred during flat data upload.";
                er.Code = "417";
                uploadResponse.Error = er;
                return uploadResponse;
            }
            catch (OperationCanceledException)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = "The flat data upload operation was cancelled.";
                er.Code = "417";
                uploadResponse.Error = er;
                return uploadResponse;
            }
        }

        public virtual FileStreamResult Download(string path, string[] names, params FileManagerDirectoryContent[] data)
        {
            names = names ?? Array.Empty<string>();
            try
            {
                string validatePath;
                string physicalPath = GetPath(path);
                String fullPath;
                int count = 0;
                validatePath = Path.Combine(contentRootPath + path);
                if (Path.GetFullPath(validatePath) != GetFilePath(validatePath))
                {
                    throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                }
                for (int i = 0; i < names.Length; i++)
                {
                    bool IsFile = !IsDirectory(physicalPath, names[i]);
                    AccessPermission? FilePermission = GetPermission(physicalPath, names[i], IsFile);
                    if (FilePermission != null && (!FilePermission.Read || !FilePermission.Download))
                    {
                        throw new UnauthorizedAccessException("'" + this.rootName + path + names[i] + "' is not accessible. Access is denied.");
                    }
                    fullPath = Path.Combine(contentRootPath + path, names[i]);
                    if (Path.GetFullPath(fullPath) != GetFilePath(fullPath) + Path.GetFileName(fullPath))
                    {
                        throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                    }
                    if ((File.GetAttributes(fullPath) & FileAttributes.Directory) != FileAttributes.Directory)
                    {
                        count++;
                    }
                }
                if (count == names.Length)
                {
                    return DownloadFile(path, names);
                }
                else
                {
                    return DownloadFolder(path, names, count);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private FileStreamResult fileStreamResult  = default!;
        protected virtual FileStreamResult DownloadFile(string path, string[]? names = null)
        {
            try
            {
                path = Path.GetDirectoryName(path) ?? string.Empty;
                string tempPath = Path.Combine(Path.GetTempPath(), "temp.zip");
                String fullPath;
                if (names == null || names.Length == 0)
                {
                    fullPath = (contentRootPath + path);
                    if (Path.GetFullPath(fullPath) != GetFilePath(fullPath) + Path.GetFileName(fullPath))
                    {
                        throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                    }
                    byte[] bytes = System.IO.File.ReadAllBytes(fullPath);
                    FileStream fileStreamInput = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
                    fileStreamResult = new FileStreamResult(fileStreamInput, "APPLICATION/octet-stream");
                }
                else if (names.Length == 1)
                {
                    fullPath = Path.Combine(contentRootPath + path, names[0]);
                    if (Path.GetFullPath(fullPath) != GetFilePath(fullPath) + Path.GetFileName(fullPath))
                    {
                        throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                    }
                    FileStream fileStreamInput = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
                    fileStreamResult = new FileStreamResult(fileStreamInput, "APPLICATION/octet-stream");
                    fileStreamResult.FileDownloadName = names[0];
                }
                else if (names.Length > 1)
                {
                    string fileName = Guid.NewGuid().ToString() + "temp.zip";
                    string newFileName = fileName.Substring(36);
                    tempPath = Path.Combine(Path.GetTempPath(), newFileName);
                    if (System.IO.File.Exists(tempPath))
                    {
                        System.IO.File.Delete(tempPath);
                    }
                    string currentDirectory;
                    ZipArchiveEntry zipEntry;
                    ZipArchive archive;
                    for (int i = 0; i < names.Length; i++)
                    {
                        fullPath = Path.Combine((contentRootPath + path), names[i]);
                        if (Path.GetFullPath(fullPath) != GetFilePath(fullPath) + Path.GetFileName(fullPath))
                        {
                            throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                        }
                        if (!string.IsNullOrEmpty(fullPath))
                        {
                            try
                            {
                                using (archive = ZipFile.Open(tempPath, ZipArchiveMode.Update))
                                {
                                    currentDirectory = Path.Combine((contentRootPath + path), names[i]);
                                    if (Path.GetFullPath(currentDirectory) != GetFilePath(currentDirectory) + Path.GetFileName(currentDirectory))
                                    {
                                        throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                                    }
                                    zipEntry = archive.CreateEntryFromFile(Path.Combine(this.contentRootPath, currentDirectory), names[i], CompressionLevel.Fastest);
                                }
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                        }
                        else
                        {
                            throw new ArgumentNullException(nameof(names), "name should not be null");
                        }
                    }
                    try
                    {
                        FileStream fileStreamInput = new FileStream(tempPath, FileMode.Open, FileAccess.Read, FileShare.Delete);
                        fileStreamResult = new FileStreamResult(fileStreamInput, "APPLICATION/octet-stream");
                        fileStreamResult.FileDownloadName = "files.zip";
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                if (File.Exists(tempPath))
                {
                    File.Delete(tempPath);
                }
                return fileStreamResult;
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected FileStreamResult DownloadFolder(string path, string[]? names, int count)
        {
            names = names ?? Array.Empty<string>();
            try
            {
                if (!String.IsNullOrEmpty(path))
                {
                    path = Path.GetDirectoryName(path) ?? string.Empty;
                }
                FileStreamResult fileStreamResult;
                // create a temp.Zip file intially 
                string tempPath = Path.Combine(Path.GetTempPath(), "temp.zip");
                String fullPath;
                if (File.Exists(tempPath))
                {
                    File.Delete(tempPath);
                }
                if (names.Length == 1)
                {
                    fullPath = Path.Combine(contentRootPath + path, names[0]);
                    if (Path.GetFullPath(fullPath) != GetFilePath(fullPath) + Path.GetFileName(fullPath))
                    {
                        throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                    }
                    DirectoryInfo directoryName = new DirectoryInfo(fullPath);
                    ZipFile.CreateFromDirectory(fullPath, tempPath, CompressionLevel.Fastest, true);
                    FileStream fileStreamInput = new FileStream(tempPath, FileMode.Open, FileAccess.Read, FileShare.Delete);
                    fileStreamResult = new FileStreamResult(fileStreamInput, "APPLICATION/octet-stream");
                    fileStreamResult.FileDownloadName = directoryName.Name + ".zip";
                }
                else
                {
                    string currentDirectory;
                    ZipArchiveEntry zipEntry;
                    ZipArchive archive;
                    using (archive = ZipFile.Open(tempPath, ZipArchiveMode.Update))
                    {
                        for (int i = 0; i < names.Length; i++)
                        {
                            currentDirectory = Path.Combine((contentRootPath + path), names[i]);
                            if (Path.GetFullPath(currentDirectory) != GetFilePath(currentDirectory) + Path.GetFileName(currentDirectory))
                            {
                                throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                            }
                            if ((File.GetAttributes(currentDirectory) & FileAttributes.Directory) == FileAttributes.Directory)
                            {
                                string[] files = Directory.GetFiles(currentDirectory, "*.*", SearchOption.AllDirectories);
                                if (files.Length == 0)
                                {
                                    zipEntry = archive.CreateEntry(names[i] + "/");
                                }
                                else
                                {
                                    foreach (string filePath in files)
                                    {
                                        zipEntry = archive.CreateEntryFromFile(filePath, string.Concat(names[i], filePath.AsSpan(currentDirectory.Length)), CompressionLevel.Fastest);
                                    }
                                }
                                foreach (string filePath in Directory.GetDirectories(currentDirectory, "*", SearchOption.AllDirectories))
                                {
                                    if (Directory.GetFiles(filePath).Length == 0)
                                    {
                                        zipEntry = archive.CreateEntry(string.Concat(names[i], filePath.AsSpan(currentDirectory.Length), "/"));
                                    }
                                }
                            }
                            else
                            {
                                zipEntry = archive.CreateEntryFromFile(Path.Combine(this.contentRootPath, currentDirectory), names[i], CompressionLevel.Fastest);
                            }
                        }
                    }
                    FileStream fileStreamInput = new FileStream(tempPath, FileMode.Open, FileAccess.Read, FileShare.Delete);
                    fileStreamResult = new FileStreamResult(fileStreamInput, "application/force-download");
                    fileStreamResult.FileDownloadName = "folders.zip";
                }
                if (File.Exists(tempPath))
                {
                    File.Delete(tempPath);
                }
                return fileStreamResult;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static string DirectoryRename(string newPath)
        {
            int directoryCount = 0;
            while (System.IO.Directory.Exists(newPath + (directoryCount > 0 ? "(" + directoryCount.ToString(CultureInfo.InvariantCulture) + ")" : "")))
            {
                directoryCount++;
            }
            newPath = newPath + (directoryCount > 0 ? "(" + directoryCount.ToString(CultureInfo.InvariantCulture) + ")" : "");
            return newPath;
        }

        private static string FileRename(string newPath, string fileName)
        {
            int name = newPath.LastIndexOf('.');
            if (name >= 0)
            {
                newPath = newPath.Substring(0, name);
            }
            int fileCount = 0;
            while (System.IO.File.Exists(newPath + (fileCount > 0 ? "(" + fileCount.ToString(CultureInfo.InvariantCulture) + ")" + Path.GetExtension(fileName) : Path.GetExtension(fileName))))
            {
                fileCount++;
            }
            newPath = newPath + (fileCount > 0 ? "(" + fileCount.ToString(CultureInfo.InvariantCulture) + ")" : "") + Path.GetExtension(fileName);
            return newPath;
        }

        private string DirectoryCopy(string sourceDirName, string destDirName)
        {
            string result = String.Empty;
            try
            {
                // Gets the subdirectories for the specified directory.
                DirectoryInfo dir = new DirectoryInfo(sourceDirName);
                DirectoryInfo[] dirs = dir.GetDirectories();
                // If the destination directory doesn't exist, creates it.
                if (!Directory.Exists(destDirName))
                {
                    try
                    {
                        Directory.CreateDirectory(destDirName);
                    }
                    catch (Exception e)
                    {
                        if (e.GetType().Name == "UnauthorizedAccessException")
                        {
                            return destDirName;
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                // Gets the files in the directory and copy them to the new location.
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    try
                    {
                        string oldPath = Path.Combine(sourceDirName, file.Name);
                        if (Path.GetFullPath(oldPath) != GetFilePath(oldPath) + Path.GetFileName(oldPath))
                        {
                            throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                        }
                        string temppath = Path.Combine(destDirName, file.Name);
                        if (Path.GetFullPath(temppath) != GetFilePath(temppath) + Path.GetFileName(temppath))
                        {
                            throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                        }
                        File.Copy(oldPath, temppath);
                    }
                    catch (Exception e)
                    {
                        if (e.GetType().Name == "UnauthorizedAccessException")
                        {
                            return file.FullName;
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                foreach (DirectoryInfo direc in dirs)
                {
                    string oldPath = Path.Combine(sourceDirName, direc.Name);
                    if (Path.GetFullPath(oldPath) != GetFilePath(oldPath) + Path.GetFileName(oldPath))
                    {
                        throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                    }
                    string temppath = Path.Combine(destDirName, direc.Name);
                    if (Path.GetFullPath(temppath) != GetFilePath(temppath) + Path.GetFileName(oldPath))
                    {
                        throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                    }
                    result = DirectoryCopy(oldPath, temppath);
                    if (!string.IsNullOrEmpty(result))
                    {
                        return result;
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                if (e.GetType().Name == "UnauthorizedAccessException")
                {
                    return sourceDirName;
                }
                else
                {
                    throw;
                }
            }
        }

        protected virtual string DeleteDirectory(string path)
        {
            try
            {
                string result = String.Empty;
                string[] files = Directory.GetFiles(path);
                string[] dirs = Directory.GetDirectories(path);
                foreach (string file in files)
                {
                    try
                    {
                        File.SetAttributes(file, FileAttributes.Normal);
                        File.Delete(file);
                    }
                    catch (Exception e)
                    {
                        if (e.GetType().Name == "UnauthorizedAccessException")
                        {
                            return file;
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                foreach (string dir in dirs)
                {
                    result = DeleteDirectory(dir);
                    if (!string.IsNullOrEmpty(result))
                    {
                        return result;
                    }
                }
                Directory.Delete(path, true);
                return result;
            }
            catch (Exception e)
            {
                if (e.GetType().Name == "UnauthorizedAccessException")
                {
                    return path;
                }
                else
                {
                    throw;
                }

            }
        }

        protected virtual FileManagerDirectoryContent GetFileDetails(string path)
        {
            try
            {
                FileInfo info = new FileInfo(path);
                FileAttributes attr = File.GetAttributes(path);
                FileInfo detailPath = new FileInfo(info.FullName);
                int folderLength = 0;
                bool isFile = ((attr & FileAttributes.Directory) == FileAttributes.Directory) ? false : true;
                if (!isFile)
                {
                    folderLength = detailPath.Directory?.GetDirectories().Length ?? 0;
                }
                string filterPath = GetRelativePath(this.contentRootPath, info.DirectoryName + Path.DirectorySeparatorChar);
                return new FileManagerDirectoryContent
                {
                    Name = info.Name,
                    Size = isFile ? info.Length : 0,
                    IsFile = isFile,
                    DateModified = info.LastWriteTime,
                    DateCreated = info.CreationTime,
                    Type = info.Extension,
                    HasChild = isFile ? false : (CheckChild(info.FullName)),
                    FilterPath = filterPath,
                    Permission = GetPermission(GetPath(filterPath), info.Name, isFile)
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        protected virtual AccessPermission? GetPermission(string location, string name, bool isFile)
        {
            AccessPermission FilePermission = new AccessPermission();
            if (isFile)
            {
                if (this.AccessDetails.AccessRules == null) return null;
                string nameExtension = Path.GetExtension(name).ToUpperInvariant();
                string fileName = Path.GetFileNameWithoutExtension(name);
                string currentPath = GetFilePath(location + name);
                foreach (AccessRule fileRule in AccessDetails.AccessRules)
                {
                    if (!string.IsNullOrEmpty(fileRule.Path) && fileRule.IsFile && (fileRule.Role == null || fileRule.Role == AccessDetails.Role))
                    {
                        if (fileRule.Path.IndexOf("*.*", StringComparison.Ordinal) > -1)
                        {
                            string parentPath = fileRule.Path.Substring(0, fileRule.Path.IndexOf("*.*", StringComparison.Ordinal));
                            if (currentPath.StartsWith(GetPath(parentPath), StringComparison.Ordinal) || parentPath.Length == 0)
                            {
                                FilePermission = UpdateFileRules(FilePermission, fileRule);
                            }
                        }
                        else if (fileRule.Path.IndexOf("*.", StringComparison.Ordinal) > -1)
                        {
                            string pathExtension = Path.GetExtension(fileRule.Path).ToUpperInvariant();
                            string parentPath = fileRule.Path.Substring(0, fileRule.Path.IndexOf("*.", StringComparison.Ordinal));
                            if ((GetPath(parentPath) == currentPath || parentPath.Length == 0) && nameExtension == pathExtension)
                            {
                                FilePermission = UpdateFileRules(FilePermission, fileRule);
                            }
                        }
                        else if (fileRule.Path.IndexOf(".*", StringComparison.Ordinal) > -1)
                        {
                            string pathName = Path.GetFileNameWithoutExtension(fileRule.Path);
                            string parentPath = fileRule.Path.Substring(0, fileRule.Path.IndexOf(pathName + ".*", StringComparison.Ordinal));
                            if ((GetPath(parentPath) == currentPath || parentPath.Length == 0) && fileName == pathName)
                            {
                                FilePermission = UpdateFileRules(FilePermission, fileRule);
                            }
                        }
                        else if (GetPath(fileRule.Path) == GetValidPath(location + name))
                        {
                            FilePermission = UpdateFileRules(FilePermission, fileRule);
                        }
                    }
                }
                return FilePermission;
            }
            else
            {
                if (this.AccessDetails.AccessRules == null) { return null; }
                foreach (AccessRule folderRule in AccessDetails.AccessRules)
                {
                    if (folderRule.Path != null && folderRule.IsFile == false && (folderRule.Role == null || folderRule.Role == AccessDetails.Role))
                    {
                        if (folderRule.Path.IndexOf('*', StringComparison.Ordinal) > -1)
                        {
                            string parentPath = folderRule.Path.Substring(0, folderRule.Path.IndexOf('*', StringComparison.Ordinal));
                            if (GetValidPath(location + name).StartsWith(GetPath(parentPath), StringComparison.Ordinal) || parentPath.Length == 0)
                            {
                                FilePermission = UpdateFolderRules(FilePermission, folderRule);
                            }
                        }
                        else if (GetPath(folderRule.Path) == GetValidPath(location + name) || GetPath(folderRule.Path) == GetValidPath(location + name + Path.DirectorySeparatorChar))
                        {
                            FilePermission = UpdateFolderRules(FilePermission, folderRule);
                        }
                        else if (GetValidPath(location + name).StartsWith(GetPath(folderRule.Path), StringComparison.Ordinal))
                        {
                            FilePermission.Write = HasPermission(folderRule.WriteContents);
                            FilePermission.WriteContents = HasPermission(folderRule.WriteContents);
                        }
                    }
                }
                return FilePermission;
            }
        }
        protected virtual string GetPath(string path)
        {
            String fullPath = (this.contentRootPath + path);
            DirectoryInfo directory = new DirectoryInfo(fullPath);
            return directory.FullName;
        }
        protected virtual string GetValidPath(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            return directory.FullName;
        }
        protected virtual string GetFilePath(string path)
        {
            return Path.GetDirectoryName(path) + Path.DirectorySeparatorChar;
        }
        protected virtual string[] GetFolderDetails(string path)
        {
            path = path ?? string.Empty;
            string[] str_array = path.Split('/'), fileDetails = new string[2];
            string parentPath = "";
            for (int i = 0; i < str_array.Length - 2; i++)
            {
                parentPath += str_array[i] + "/";
            }
            fileDetails[0] = parentPath;
            fileDetails[1] = str_array[str_array.Length - 2];
            return fileDetails;
        }
        protected virtual AccessPermission? GetPathPermission(string path)
        {
            string[] fileDetails = GetFolderDetails(path);
            return GetPermission(GetPath(fileDetails[0]), fileDetails[1], false);
        }
        protected virtual AccessPermission? GetFilePermission(string path)
        {
            path = path ?? string.Empty;
            string parentPath = path.Substring(0, path.LastIndexOf('/') + 1);
            string fileName = Path.GetFileName(path);
            return GetPermission(GetPath(parentPath), fileName, true);
        }
        protected virtual bool IsDirectory(string path, string fileName)
        {
            try
            {
                string fullPath = Path.Combine(path, fileName);
                if (Path.GetFullPath(fullPath) != GetFilePath(fullPath))
                {
                    throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                }
                FileAttributes attributes = File.GetAttributes(fullPath);

                return ((attributes & FileAttributes.Directory) != FileAttributes.Directory) ? false : true;
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
            catch (FileNotFoundException)
            {
                return false;
            }
            catch (IOException)
            {
                return false;
            }
        }
        protected virtual bool HasPermission(PermissionState rule)
        {
            return rule == PermissionState.Allow ? true : false;
        }
        protected virtual AccessPermission UpdateFileRules(AccessPermission filePermission, AccessRule fileRule)
        {
            filePermission ??= new AccessPermission();
            fileRule ??= new AccessRule();
            filePermission.Copy = HasPermission(fileRule.Copy);
            filePermission.Download = HasPermission(fileRule.Download);
            filePermission.Write = HasPermission(fileRule.Write);
            filePermission.Read = HasPermission(fileRule.Read);
            filePermission.Message = string.IsNullOrEmpty(fileRule.Message) ? string.Empty : fileRule.Message;
            return filePermission;
        }
        protected virtual AccessPermission UpdateFolderRules(AccessPermission folderPermission, AccessRule folderRule)
        {
            folderPermission ??= new AccessPermission();
            folderRule ??= new AccessRule();
            folderPermission.Copy = HasPermission(folderRule.Copy);
            folderPermission.Download = HasPermission(folderRule.Download);
            folderPermission.Write = HasPermission(folderRule.Write);
            folderPermission.WriteContents = HasPermission(folderRule.WriteContents);
            folderPermission.Read = HasPermission(folderRule.Read);
            folderPermission.Upload = HasPermission(folderRule.Upload);
            folderPermission.Message = string.IsNullOrEmpty(folderRule.Message) ? string.Empty : folderRule.Message;
            return folderPermission;
        }
        protected virtual bool parentsHavePermission(FileManagerDirectoryContent fileDetails)
        {
            if (fileDetails == null || string.IsNullOrEmpty(fileDetails.FilterPath))
            {
                return false;
            }
            String parentPath = fileDetails.FilterPath.Replace(Path.DirectorySeparatorChar, '/');
            String[] parents = parentPath.Split('/');
            String currPath = "/";
            bool hasPermission = true;
            for (int i = 0; i <= parents.Length - 2; i++)
            {
                currPath = (parents[i].Length == 0) ? currPath : (currPath + parents[i] + "/");
                AccessPermission? PathPermission = GetPathPermission(currPath);
                if (PathPermission == null)
                {
                    break;
                }
                else if (!PathPermission.Read)
                {
                    hasPermission = false;
                    break;
                }
            }
            return hasPermission;
        }

        private static bool CheckChild(string path)
        {
            bool hasChild;
            try
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                DirectoryInfo[] dir = directory.GetDirectories();
                hasChild = dir.Length != 0;
            }
            catch (Exception e)
            {
                if (e.GetType().Name == "UnauthorizedAccessException")
                {
                    hasChild = false;
                }
                else
                {
                    throw;
                }
            }
            return hasChild;
        }
        private static bool hasAccess(string path)
        {
            bool hasAcceess;
            try
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                DirectoryInfo[] dir = directory.GetDirectories();
                hasAcceess = dir != null;
            }
            catch (Exception e)
            {
                if (e.GetType().Name == "UnauthorizedAccessException")
                {
                    hasAcceess = false;
                }
                else
                {
                    throw;
                }
            }
            return hasAcceess;
        }
        private static long GetDirectorySize(DirectoryInfo dir, long size)
        {
            try
            {
                foreach (DirectoryInfo subdir in dir.GetDirectories())
                {
                    size = GetDirectorySize(subdir, size);
                }
                foreach (FileInfo file in dir.GetFiles())
                {
                    size += file.Length;
                }
            }
            catch (Exception e)
            {
                if (e.GetType().Name != "UnauthorizedAccessException")
                {
                    throw;
                }
            }
            return size;
        }
        private static List<FileInfo> GetDirectoryFiles(DirectoryInfo dir, List<FileInfo> files)
        {
            try
            {
                foreach (DirectoryInfo subdir in dir.GetDirectories())
                {
                    files = GetDirectoryFiles(subdir, files);
                }
                foreach (FileInfo file in dir.GetFiles())
                {
                    files.Add(file);
                }
            }
            catch (Exception e)
            {
                if (e.GetType().Name != "UnauthorizedAccessException")
                {
                    throw;
                }
            }
            return files;
        }
        private static List<DirectoryInfo> GetDirectoryFolders(DirectoryInfo dir, List<DirectoryInfo> files)
        {
            try
            {
                foreach (DirectoryInfo subdir in dir.GetDirectories())
                {
                    files = GetDirectoryFolders(subdir, files);
                }
                foreach (DirectoryInfo file in dir.GetDirectories())
                {
                    files.Add(file);
                }
            }
            catch (Exception e)
            {
                if (e.GetType().Name != "UnauthorizedAccessException")
                {
                    throw;
                }
            }
            return files;
        }
        private static string? getFileNameFromPath(string path)
        {
            string[] segments = path.TrimEnd('/').Split('/');
            return segments.LastOrDefault();
        }

    }

    public class AccessDetails
    {
        public string Role { get; set; }  = string.Empty;
        public IEnumerable<AccessRule>? AccessRules { get; set; }
    }

    public class AccessRule
    {
        public PermissionState Copy { get; set; }
        public PermissionState Download { get; set; }
        public PermissionState Write { get; set; }
        public string Path { get; set; } = string.Empty;
        public PermissionState Read { get; set; }
        public string Role { get; set; } = string.Empty;
        public PermissionState WriteContents { get; set; }
        public PermissionState Upload { get; set; }
        public bool IsFile { get; set; }
        public string Message { get; set; } = string.Empty;
    }
    public enum PermissionState
    {
        Allow,
        Deny
    }
}