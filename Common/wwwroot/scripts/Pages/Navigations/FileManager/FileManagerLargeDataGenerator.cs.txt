using Syncfusion.Blazor.FileManager;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Globalization;


namespace BlazorDemos.Pages.Navigations.FileManager
{
    public static class FileManagerLargeDataGenerator
    {

        public static IReadOnlyList<FileManagerDirectoryContent> GenerateFolders(int totalFolders, string rootName = "Files")
        {
            if (totalFolders < 0) totalFolders = 0;

            var data = new List<FileManagerDirectoryContent>();
            int id = 0;

            var root = new FileManagerDirectoryContent
            {
                Id = id.ToString(CultureInfo.InvariantCulture),
                Name = rootName,
                ParentId = null,
                IsFile = false,
                Type = "folder",
                Size = 0,
                HasChild = totalFolders > 0,
                FilterId = "",
                FilterPath = "",             
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                CaseSensitive = false,
                ShowHiddenItems = false
            };
            data.Add(root);

            for (int i = 1; i <= totalFolders; i++)
            {
                id++;
                string parentId = root.Id;
                
                var mainFolder = new FileManagerDirectoryContent
                {
                    Id = id.ToString(CultureInfo.InvariantCulture),
                    Name = $"Folder-{i}",
                    ParentId = parentId,
                    IsFile = false,
                    Type = "folder",
                    Size = 0,
                    HasChild = true,
                    FilterId = $"{parentId}/",
                    FilterPath = "/",
                    DateCreated = DateTime.Now.AddDays(-(i)),
                    DateModified = DateTime.Now.AddDays(-(i)),
                    CaseSensitive = false,
                    ShowHiddenItems = false
                };
                data.Add(mainFolder);

                int randomChoice = GetSecureRandomInt(0, 3);

                switch (randomChoice)
                {
                    case 0:
                        {
                            int fileCount = GetSecureRandomInt(1, 5);
                            for (int k = 1; k <= fileCount; k++)
                            {
                                id++;
                                string fileExtension = GetRandomFileExtension(k);
                                long fileSize = GetRandomFileSize();

                                var file = new FileManagerDirectoryContent
                                {
                                    Id = id.ToString(CultureInfo.InvariantCulture),
                                    Name = $"Document-{k}{fileExtension}",
                                    ParentId = mainFolder.Id,
                                    IsFile = true,
                                    Type = fileExtension.TrimStart('.'),
                                    Size = fileSize,
                                    HasChild = false,
                                    FilterId = $"{mainFolder.FilterId}{mainFolder.Id}/",
                                    FilterPath = $"{mainFolder.FilterPath}{mainFolder.Name}/",
                                    DateCreated = DateTime.Now.AddDays(-(i + k)),
                                    DateModified = DateTime.Now.AddDays(-(i)),
                                    CaseSensitive = false,
                                    ShowHiddenItems = false
                                };
                                data.Add(file);
                            }
                            mainFolder.HasChild = true;
                            break;
                        }

                    case 1:
                        {
                            int subfolderCount = GetSecureRandomInt(1, 4);
                            for (int j = 1; j <= subfolderCount; j++)
                            {
                                id++;
                                var subfolder = new FileManagerDirectoryContent
                                {
                                    Id = id.ToString(CultureInfo.InvariantCulture),
                                    Name = $"SubFolder-{j}",
                                    ParentId = mainFolder.Id,
                                    IsFile = false,
                                    Type = "folder",
                                    Size = 0,
                                    HasChild = true,
                                    FilterId = $"{mainFolder.FilterId}{mainFolder.Id}/",
                                    FilterPath = $"{mainFolder.FilterPath}{mainFolder.Name}/",
                                    DateCreated = DateTime.Now.AddDays(-(i + j)),
                                    DateModified = DateTime.Now.AddDays(-(i + j)),
                                    CaseSensitive = false,
                                    ShowHiddenItems = false
                                };
                                data.Add(subfolder);
                                int fileCount = GetSecureRandomInt(2, 4);
                                for (int k = 1; k <= fileCount; k++)
                                {
                                    id++;
                                    string fileExtension = GetRandomFileExtension(k);
                                    long fileSize = GetRandomFileSize();

                                    var file = new FileManagerDirectoryContent
                                    {
                                        Id = id.ToString(CultureInfo.InvariantCulture),
                                        Name = $"File-{k}{fileExtension}",
                                        ParentId = subfolder.Id,
                                        IsFile = true,
                                        Type = fileExtension.TrimStart('.'),
                                        Size = fileSize,
                                        HasChild = false,
                                        FilterId = $"{subfolder.FilterId}{subfolder.Id}/",
                                        FilterPath = $"{subfolder.FilterPath}{subfolder.Name}/",
                                        DateCreated = DateTime.Now.AddDays(-(i + j + k)),
                                        DateModified = DateTime.Now.AddDays(-(i + j)),
                                        CaseSensitive = false,
                                        ShowHiddenItems = false
                                    };
                                    data.Add(file);
                                }
                            }
                            mainFolder.HasChild = true;
                            break;
                        }

                    case 2:
                        {
                            int subfolderCount = GetSecureRandomInt(1, 3);
                            for (int j = 1; j <= subfolderCount; j++)
                            {
                                id++;
                                var subfolder = new FileManagerDirectoryContent
                                {
                                    Id = id.ToString(CultureInfo.InvariantCulture),
                                    Name = $"SubFolder-{j}",
                                    ParentId = mainFolder.Id,
                                    IsFile = false,
                                    Type = "folder",
                                    Size = 0,
                                    HasChild = true,
                                    FilterId = $"{mainFolder.FilterId}{mainFolder.Id}/",
                                    FilterPath = $"{mainFolder.FilterPath}{mainFolder.Name}/",
                                    DateCreated = DateTime.Now.AddDays(-(i + j)),
                                    DateModified = DateTime.Now.AddDays(-(i + j)),
                                    CaseSensitive = false,
                                    ShowHiddenItems = false
                                };
                                data.Add(subfolder);

                                int subFileCount = GetSecureRandomInt(1, 3);
                                for (int k = 1; k <= subFileCount; k++)
                                {
                                    id++;
                                    string fileExtension = GetRandomFileExtension(k);
                                    long fileSize = GetRandomFileSize();

                                    var subFile = new FileManagerDirectoryContent
                                    {
                                        Id = id.ToString(CultureInfo.InvariantCulture),
                                        Name = $"File-{k}{fileExtension}",
                                        ParentId = subfolder.Id,
                                        IsFile = true,
                                        Type = fileExtension.TrimStart('.'),
                                        Size = fileSize,
                                        HasChild = false,
                                        FilterId = $"{subfolder.FilterId}{subfolder.Id}/",
                                        FilterPath = $"{subfolder.FilterPath}{subfolder.Name}/",
                                        DateCreated = DateTime.Now.AddDays(-(i + j + k)),
                                        DateModified = DateTime.Now.AddDays(-(i + j)),
                                        CaseSensitive = false,
                                        ShowHiddenItems = false
                                    };
                                    data.Add(subFile);
                                }
                            }

                            int directFileCount = GetSecureRandomInt(1, 3);
                            for (int m = 1; m <= directFileCount; m++)
                            {
                                id++;
                                string fileExtension = GetRandomFileExtension(m);
                                long fileSize = GetRandomFileSize();

                                var directFile = new FileManagerDirectoryContent
                                {
                                    Id = id.ToString(CultureInfo.InvariantCulture),
                                    Name = $"Document-{m}{fileExtension}",
                                    ParentId = mainFolder.Id,
                                    IsFile = true,
                                    Type = fileExtension.TrimStart('.'),
                                    Size = fileSize,
                                    HasChild = false,
                                    FilterId = $"{mainFolder.FilterId}{mainFolder.Id}/",
                                    FilterPath = $"{mainFolder.FilterPath}{mainFolder.Name}/",
                                    DateCreated = DateTime.Now.AddDays(-(i + m)),
                                    DateModified = DateTime.Now.AddDays(-(i)),
                                    CaseSensitive = false,
                                    ShowHiddenItems = false
                                };
                                data.Add(directFile);
                            }
                            mainFolder.HasChild = true;
                            break;
                        }
                }
            }

            return data;
        }

        private static string GetRandomFileExtension(int seed)
        {
            string[] extensions = { ".txt", ".pdf", ".docx", ".xlsx", ".pptx", ".jpg", ".png", ".zip", ".json", ".xml" };
            return extensions[seed % extensions.Length];
        }

        private static long GetRandomFileSize()
        {
            return GetSecureRandomInt(1024, 5242880);
        }

        private static int GetSecureRandomInt(int minValue, int maxValue)
        {
            if (minValue >= maxValue)
                throw new ArgumentOutOfRangeException(nameof(minValue), "minValue must be less than maxValue.");
            using var rng = RandomNumberGenerator.Create();
            var bytes = new byte[4];
            rng.GetBytes(bytes);
            int value = BitConverter.ToInt32(bytes, 0) & int.MaxValue;
            return minValue + (value % (maxValue - minValue));
        }
    }
}