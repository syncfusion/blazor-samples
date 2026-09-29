using FileManagerAI.Services;
using Syncfusion.Blazor.Buttons;
using Syncfusion.Blazor.FileManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.AISamples.FileManager
{
    public partial class FileManagerTagSearch
    {
        private SfFileManager<FileManagerDirectoryContent>? FileManager;
        private SfChip? AIChip;
        private SfChip? Chip;
        private string FileManagerId { get; set; } = "FileManager_" + Guid.NewGuid().ToString("N");
        private bool isTag { get; set; }
        private bool isSave { get; set; } = true;
        private static readonly string[] ManageTagsArray = { "Manage Tags" };
        private static readonly List<ToolBarItemModel> Items = new List<ToolBarItemModel>(){
            new ToolBarItemModel() { Name = "NewFolder" },
            new ToolBarItemModel() { Name = "Cut" },
            new ToolBarItemModel() { Name = "Copy" },
            new ToolBarItemModel() { Name = "Paste" },
            new ToolBarItemModel() { Name = "Delete" },
            new ToolBarItemModel() { Name = "Download" },
            new ToolBarItemModel() { Name = "Rename" },
            new ToolBarItemModel() { Name = "SortBy" },
            new ToolBarItemModel() { Name = "Refresh" },
            new ToolBarItemModel() { Name = "Selection" },
            new ToolBarItemModel() { Name = "View" },
            new ToolBarItemModel() { Name = "Details" },
        };
        private List<ChipItem>? fileTags = new List<ChipItem>();
        private List<ChipItem>? aiTags = new List<ChipItem>();
        private static readonly string[] FileItems = new string[] { "Manage Tags", "|", "Cut", "Copy", "|", "Delete", "Rename", "|", "Details" };
        private static readonly string[] FolderItems = new string[] { "Open", "|", "Cut", "Copy", "Paste", "|", "Delete", "Rename", "|", "Details" };

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync().ConfigureAwait(true);
        }

        public async Task OnReadAsync(ReadEventArgs<FileManagerDirectoryContent> args)
        {
            if (args == null) { return; }
            if (!Directory.Exists(Path.Combine(FileManagerService.DemoBaseDirectory, FileManagerId)))
            {
                FileManagerService.RootFolder(FileManagerId);
                _ = Task.Run(() => FileManagerService.TagInitialFiles());
            }
            args.Response = await FileManagerService.GetFiles(args.Path, false, args.Folder.ToArray()).ConfigureAwait(true);
        }

        public async Task ItemsDeletingAsync(ItemsDeleteEventArgs<FileManagerDirectoryContent> args)
        {
            if (args == null) { return; }
            string[] names = args.Files.Select(x => x.Name).ToArray();
            args.Response = await FileManagerService.Delete(args.Path, names, args.Files.ToArray()).ConfigureAwait(true);
        }

        public async Task FolderCreatingAsync(FolderCreateEventArgs<FileManagerDirectoryContent> args)
        {
            if (args == null) { return; }
            args.Response = await FileManagerService.Create(args.Path, args.FolderName, args.ParentFolder).ConfigureAwait(true);
        }

        public async Task SearchingAsync(SearchEventArgs<FileManagerDirectoryContent> args)
        {
            if (args == null) { return; }
            args.Response = await FileManagerService.Search(args.Path, args.SearchText, false, false, true).ConfigureAwait(true);
        }

        public async Task ItemRenamingAsync(ItemRenameEventArgs<FileManagerDirectoryContent> args)
        {
            if (args == null) { return; }
            args.Response = await FileManagerService.Rename(args.Path, args.Name, args.NewName, false, args.ShowFileExtension, args.File).ConfigureAwait(true);
        }

        public async Task ItemsMovingAsync(ItemsMoveEventArgs<FileManagerDirectoryContent> args)
        {
            if (args == null) { return; }
            string[] names = args.Files.Select(x => x.Name).ToArray();
            if (args.IsCopy)
            {
                args.Response = await FileManagerService.Copy(args.Path, args.TargetPath, names, args.TargetData, args.Files.ToArray()).ConfigureAwait(true);
            }
            else
            {
                args.Response = await FileManagerService.Move(args.Path, args.TargetPath, names, args.TargetData, args.Files.ToArray()).ConfigureAwait(true);
            }
        }

        public async Task ItemsUploadedAsync(ItemsUploadedEventArgs<FileManagerDirectoryContent> args)
        {
            if (args == null) { return; }
            string currentPath = args.Path;
            try
            {
                foreach (var file in args.Files)
                {
                    var folders = (file.FileInfo.Name).Split('/');
                    if (folders.Length > 1)
                    {
                        for (var i = 0; i < folders.Length - 1; i++)
                        {
                            string newDirectoryPath = Path.Combine(FileManagerService.basePath + currentPath, folders[i]);
                            if (Path.GetFullPath(newDirectoryPath) != (Path.GetDirectoryName(newDirectoryPath) + Path.DirectorySeparatorChar + folders[i]))
                            {
                                throw new UnauthorizedAccessException("Access denied for Directory-traversal");
                            }
                            if (!Directory.Exists(newDirectoryPath))
                            {
                                await FileManagerService.Create(currentPath, folders[i]).ConfigureAwait(false);
                            }
                            currentPath += folders[i] + "/";
                        }
                    }
                    var fullName = Path.Combine((FileManagerService.contentRootPath + currentPath), file.File.Name);
                    using (var filestream = new FileStream(fullName, FileMode.Create, FileAccess.Write))
                    {
                        await file.File.OpenReadStream(long.MaxValue).CopyToAsync(filestream).ConfigureAwait(false);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                 Console.WriteLine($"Unauthorized: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"IO error: {ex.Message}");
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine($"Operation canceled: {ex.Message}");
            }
            catch (ObjectDisposedException ex)
            {
                Console.WriteLine($"Object disposed: {ex.Message}");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task BeforeImageLoadAsync(BeforeImageLoadEventArgs<FileManagerDirectoryContent> args)
        {
            if (args == null) { return Task.CompletedTask; }
            string root = FileManagerService.DemoDirectoryName + "\\" + FileManagerId + "\\" + "Files";
            string relativePath = ($"{root + args.FileDetails.FilterPath + args.FileDetails.Name}").Replace("\\", "/", StringComparison.Ordinal);
            args.ImageUrl = UriHelper.ToAbsoluteUri(relativePath).ToString();
            return Task.CompletedTask;
        }

        public void BeforeDownload(BeforeDownloadEventArgs<FileManagerDirectoryContent> args)
        {
            if (args == null) { return; }
            var downloadData = FileManagerService.Download(args.DownloadData.Path, args.DownloadData.Names, args.DownloadData.DownloadFileDetails.ToArray());
            args.FileStream = downloadData.FileStream;
            args.DownloadFileName = downloadData.FileDownloadName;
        }

        private async Task<string> GetTagsFromAI(string fileContent)
        {
            string promptQuery = $"Generate tags for the following content and provide them in ordered list format without any additional text:\n\n";
            string tags = await openAIService.GetCompletionAsync((promptQuery + fileContent), false).ConfigureAwait(false);
            return tags;
        }

        private async Task AddTags()
        {
            var data = FileManager?.GetSelectedFiles();
            string filePath = FileManagerService.contentRootPath + data?.FirstOrDefault()?.FilterPath + data?.FirstOrDefault()?.Name;
            string fileContent = "File Named as " + data?.FirstOrDefault()?.Name;
            string tagsString = await GetTagsFromAI(fileContent).ConfigureAwait(false);
            try
            {
                var tagsArray = Regex.Split(tagsString, @"\r\n|\n\n|\n")
                .Where(tag => !string.IsNullOrWhiteSpace(tag))
                .Select(tag => tag.Substring(tag.IndexOf(' ', StringComparison.Ordinal) + 1).Trim())
                .ToList();
                aiTags = tagsArray.Select(tag => new ChipItem { Text = tag }).ToList();
                isSave = aiTags.Count == 0 ? true : false;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Parsing error: {ex.Message}");
                ErrorDetails er = new ErrorDetails
                {
                    Code = "401",
                    Message = "Need to clean the AI result"
                };
            }
            catch (RegexMatchTimeoutException ex)
            {
                Console.WriteLine($"Regex timeout: {ex.Message}");
                ErrorDetails er = new ErrorDetails
                {
                    Code = "401",
                    Message = "Need to clean the AI result"
                };
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Null input: {ex.Message}");
                ErrorDetails er = new ErrorDetails
                {
                    Code = "401",
                    Message = "Need to clean the AI result"
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                ErrorDetails er = new ErrorDetails
                {
                    Code = "401",
                    Message = "Need to clean the AI result"
                };
                throw;
            }
        }

        private void SaveTags()
        {
            var data = FileManager?.GetSelectedFiles();
            List<string> tagsList = new List<string>();
            foreach (var item in AIChip?.Chips ?? Enumerable.Empty<ChipItem>())
            {
                tagsList.Add(item.Text);
            }
            aiTags = tagsList.Select(tag => new ChipItem { Text = tag }).ToList();
            string filePath = FileManagerService.contentRootPath + data?.FirstOrDefault()?.FilterPath + data?.FirstOrDefault()?.Name;
            string fileContent = "File Named as " + data?.FirstOrDefault()?.Name;
            FileManagerService.UpdateTagsToFile(filePath, aiTags);
            fileTags = FileManagerService.GetTagsFromFile(filePath).Select(tag => new ChipItem { Text = tag }).ToList();
            aiTags = null;
            isSave = true;
        }

        private void Deleted(ChipDeletedEventArgs args)
        {
            if (Chip?.Chips?.Count == 0)
            {
                fileTags = null;
                isSave = true;
            }
            var data = FileManager?.GetSelectedFiles();
            string filePath = FileManagerService.contentRootPath + data?.FirstOrDefault()?.FilterPath + data?.FirstOrDefault()?.Name;
            FileManagerService.RemoveTagsFromFile(filePath, new string[] { args.Text });
        }

        private void AIDeleted(ChipDeletedEventArgs args)
        {
            if (AIChip?.Chips?.Count == 0)
            {
                aiTags = null;
                isSave = true;
            }
        }

        private void CloseTagContainer()
        {
            this.isTag = false;
            aiTags = null;
            fileTags = null;
        }

        private Task OnMenuClick(MenuClickEventArgs<FileManagerDirectoryContent> args)
        {
            if (args.Item.Text == "Manage Tags")
            {
                string filePath = FileManagerService.contentRootPath + args.FileDetails.FirstOrDefault()?.FilterPath + args.FileDetails.FirstOrDefault()?.Name;
                fileTags = FileManagerService.GetTagsFromFile(filePath).Select(tag => new ChipItem { Text = tag }).ToList();
                this.isTag = true;
            }
            return Task.CompletedTask;
        }

        private void MenuOpened(MenuOpenEventArgs<FileManagerDirectoryContent> args)
        {
            if (args.MenuType == "File" && args.FileDetails.Count > 1)
            {
                FileManager?.DisableMenuItems(ManageTagsArray);
            }
            for (int i = 0; i < args.Items.Count; i++)
            {
                if (args.Items[i].Id == FileManager?.ID + "_cm_manage tags")
                {
                    args.Items[i].IconCss = "e-icons e-bookmark";
                }
            }
        }
    }
}
