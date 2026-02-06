#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
        SfFileManager<FileManagerDirectoryContent>? FileManager;
        SfChip? AIChip;
        SfChip? Chip;
        private string FileManagerId { get; set; } = "FileManager_" + Guid.NewGuid().ToString("N");
        private bool isTag { get; set; } = false;
        private bool isSave { get; set; } = true;
        private string promptQuery = string.Empty;
        public List<ToolBarItemModel> Items = new List<ToolBarItemModel>(){
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
        private List<ChipItem> fileTags = new List<ChipItem>();
        private List<ChipItem> aiTags = new List<ChipItem>();
        public string[] FileItems = new string[] { "Manage Tags", "|", "Cut", "Copy", "|", "Delete", "Rename", "|", "Details" };
        public string[] FolderItems = new string[] { "Open", "|", "Cut", "Copy", "Paste", "|", "Delete", "Rename", "|", "Details" };

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }

        public async Task OnReadAsync(ReadEventArgs<FileManagerDirectoryContent> args)
        {
            if (!Directory.Exists(Path.Combine(FileManagerService.DemoBaseDirectory, FileManagerId)))
            {
                FileManagerService.RootFolder(FileManagerId);
                _ = Task.Run(() => FileManagerService.TagInitialFiles());
            }
            args.Response = await FileManagerService.GetFiles(args.Path, false, args.Folder.ToArray());
        }

        public async Task ItemsDeletingAsync(ItemsDeleteEventArgs<FileManagerDirectoryContent> args)
        {
            string[] names = args.Files.Select(x => x.Name).ToArray();
            args.Response = await FileManagerService.Delete(args.Path, names, args.Files.ToArray());
        }

        public async Task FolderCreatingAsync(FolderCreateEventArgs<FileManagerDirectoryContent> args)
        {
            args.Response = await FileManagerService.Create(args.Path, args.FolderName, args.ParentFolder);
        }

        public async Task SearchingAsync(SearchEventArgs<FileManagerDirectoryContent> args)
        {
            args.Response = await FileManagerService.Search(args.Path, args.SearchText, false, false, true);
        }

        public async Task ItemRenamingAsync(ItemRenameEventArgs<FileManagerDirectoryContent> args)
        {
            args.Response = await FileManagerService.Rename(args.Path, args.Name, args.NewName, false, args.ShowFileExtension, args.File);
        }

        public async Task ItemsMovingAsync(ItemsMoveEventArgs<FileManagerDirectoryContent> args)
        {
            string[] names = args.Files.Select(x => x.Name).ToArray();
            if (args.IsCopy)
            {
                args.Response = await FileManagerService.Copy(args.Path, args.TargetPath, names, args.TargetData, args.Files.ToArray());
            }
            else
            {
                args.Response = await FileManagerService.Move(args.Path, args.TargetPath, names, args.TargetData, args.Files.ToArray());
            }
        }

        public async Task ItemsUploadedAsync(ItemsUploadedEventArgs<FileManagerDirectoryContent> args)
        {
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
                                await FileManagerService.Create(currentPath, folders[i]);
                            }
                            currentPath += folders[i] + "/";
                        }
                    }
                    var fullName = Path.Combine((FileManagerService.contentRootPath + currentPath), file.File.Name);
                    using (var filestream = new FileStream(fullName, FileMode.Create, FileAccess.Write))
                    {
                        await file.File.OpenReadStream(long.MaxValue).CopyToAsync(filestream);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public async Task BeforeImageLoadAsync(BeforeImageLoadEventArgs<FileManagerDirectoryContent> args)
        {
            string root = FileManagerService.DemoDirectoryName + "\\" + FileManagerId + "\\" + "Files";
            string relativePath = ($"{root + args.FileDetails.FilterPath + args.FileDetails.Name}").Replace("\\", "/");
            args.ImageUrl = UriHelper.ToAbsoluteUri(relativePath).ToString();
        }

        public void BeforeDownload(BeforeDownloadEventArgs<FileManagerDirectoryContent> args)
        {
            var downloadData = FileManagerService.Download(args.DownloadData.Path, args.DownloadData.Names, args.DownloadData.DownloadFileDetails.ToArray());
            args.FileStream = downloadData.FileStream;
            args.DownloadFileName = downloadData.FileDownloadName;
        }

        private async Task<string> GetTagsFromAI(string fileContent)
        {
            string promptQuery = $"Generate tags for the following content and provide them in ordered list format without any additional text:\n\n";
            string tags = await openAIService.GetCompletionAsync((promptQuery + fileContent), false);
            return tags;
        }

        private async Task AddTags()
        {
            var data = FileManager?.GetSelectedFiles();
            string filePath = FileManagerService.contentRootPath + data?.FirstOrDefault()?.FilterPath + data?.FirstOrDefault()?.Name;
            string fileContent = "File Named as " + data?.FirstOrDefault()?.Name;
            string tagsString = await GetTagsFromAI(fileContent);
            try
            {
                var tagsArray = Regex.Split(tagsString, @"\r\n|\n\n|\n")
                .Where(tag => !string.IsNullOrWhiteSpace(tag))
                .Select(tag => tag.Substring(tag.IndexOf(' ') + 1).Trim())
                .ToList();
                aiTags = tagsArray.Select(tag => new ChipItem { Text = tag }).ToList();
                isSave = aiTags.Count == 0 ? true : false;
            }
            catch (Exception e)
            {
                ErrorDetails er = new ErrorDetails();
                er.Message = e.Message.ToString();
                er.Code = "401";
                er.Message = "Need to clean the AI result";
            }
        }

        private void SaveTags()
        {
            var data = FileManager?.GetSelectedFiles();
            List<string> tagsList = new List<string>();
            foreach (var item in AIChip?.Chips)
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
            if (Chip.Chips.Count == 0)
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
            if (AIChip.Chips.Count == 0)
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

        private async Task OnMenuClick(MenuClickEventArgs<FileManagerDirectoryContent> args)
        {
            if (args.Item.Text == "Manage Tags")
            {
                string filePath = FileManagerService.contentRootPath + args.FileDetails.FirstOrDefault()?.FilterPath + args.FileDetails.FirstOrDefault()?.Name;
                fileTags = FileManagerService.GetTagsFromFile(filePath).Select(tag => new ChipItem { Text = tag }).ToList();
                this.isTag = true;
            }
        }

        private void MenuOpened(MenuOpenEventArgs<FileManagerDirectoryContent> args)
        {
            if (args.MenuType == "File" && args.FileDetails.Count > 1)
            {
                FileManager?.DisableMenuItems(new string[] { "Manage Tags" });
            }
            for (int i = 0; i < args.Items.Count(); i++)
            {
                if (args.Items[i].Id == FileManager?.ID + "_cm_manage tags")
                {
                    args.Items[i].IconCss = "e-icons e-bookmark";
                }
            }
        }
    }
}
