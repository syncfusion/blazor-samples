#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using FileManagerAI.Services;
using Syncfusion.Blazor.FileManager;
using Syncfusion.Blazor.Popups;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Pdf.Parsing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.AISamples.FileManager
{
    public partial class SmartFileManager
    {
        SfFileManager<FileManagerDirectoryContent>? FileManager;
        private string[] SelectedItems { get; set; } = new string[] { "RandomFiles" };
        private bool VisibleProperty { get; set; } = false;
        private string FileManagerId { get; set; } = "FileManager_" + Guid.NewGuid().ToString("N");
        private string DialogTitle { get; set; } = "File Summary";
        private bool IsDialogVisible { get; set; } = false;
        private bool isContentGenerating { get; set; }
        private string selectedOption = "Open AI";
        private string promptQuery = string.Empty;
        private string DialogContent = string.Empty;
        private static readonly HashSet<string> AllowedFileTypes = new HashSet<string>
        {
            ".txt",
            ".docx",
            ".pdf"
        };
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
            new ToolBarItemModel() { Name = "Organize", Text="Organize", TooltipText="Organize", PrefixIcon="e-icons e-folder", Visible=true },
            new ToolBarItemModel() { Name = "Quick Summary", Text="Quick Summary", TooltipText="Get a quick summary of the selected file using AI", PrefixIcon="e-icons e-print-layout", Visible=false },
            new ToolBarItemModel() { Name = "Selection" },
            new ToolBarItemModel() { Name = "View" },
            new ToolBarItemModel() { Name = "Details" },
        };

        public string[] FileItems = new string[] { "Quick Summary", "Cut", "Copy", "|", "Delete", "Rename", "|", "Details" };
        public string[] FolderItems = new string[] { "Organize", "|", "Open", "|", "Cut", "Copy", "Paste", "|", "Delete", "Rename", "|", "Details" };

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            _ = Task.Run(() => FileManagerService.EmbedInitialFiles());
        }

        public async Task OnReadAsync(ReadEventArgs<FileManagerDirectoryContent> args)
        {
            if (!Directory.Exists(Path.Combine(FileManagerService.DemoBaseDirectory, FileManagerId)))
            {
                FileManagerService.RootFolder(FileManagerId);
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
            args.Response = await FileManagerService.Search(args.Path, args.SearchText, false, false);
        }

        public async Task ItemRenamingAsync(ItemRenameEventArgs<FileManagerDirectoryContent> args)
        {
            args.Response = await FileManagerService.Rename(args.Path, args.File.Name, args.NewName, false, args.ShowFileExtension, args.File);
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
            args.ImageUrl = NavigationManager.ToAbsoluteUri(relativePath).ToString();
        }

        public void BeforeDownload(BeforeDownloadEventArgs<FileManagerDirectoryContent> args)
        {
            var downloadData = FileManagerService.Download(args.DownloadData.Path, args.DownloadData.Names, args.DownloadData.DownloadFileDetails.ToArray());
            args.FileStream = downloadData.FileStream;
            args.DownloadFileName = downloadData.FileDownloadName;
        }

        private void FileSelected(FileSelectEventArgs<FileManagerDirectoryContent> args)
        {
            if (AllowedFileTypes.Contains(args.FileDetails.Type) && FileManager?.SelectedItems.Length == 1)
            {
                Items.Where(item => item.Name == "Quick Summary").FirstOrDefault().Visible = true;
            }
            else if (!args.FileDetails.IsFile && FileManager.SelectedItems.Length == 1)
            {
                Items.Where(item => item.Name == "Organize").FirstOrDefault().Visible = true;
            }
            else
            {
                Items.Where(item => item.Name == "Organize").FirstOrDefault().Visible = false;
                Items.Where(item => item.Name == "Quick Summary").FirstOrDefault().Visible = false;
            }
        }

        private async Task ToolbarItemClicked(ToolbarClickEventArgs<FileManagerDirectoryContent> args)
        {
            if (args.Item.Text == "Quick Summary")
            {
                if (args.FileDetails[0].Permission == null)
                {
                    try
                    {
                        await SummarizeAsync(args.FileDetails[0].IsFile, args.FileDetails[0].Type, args.FileDetails[0].FilterPath, args.FileDetails[0].Name);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else if (args.FileDetails[0].Permission != null && !args.FileDetails[0].Permission.Read)
                {
                    this.IsDialogVisible = true;
                    this.DialogContent = args.FileDetails[0].Name + " is not accessible. You do not have permission to read this file.";
                }
            }
            else if (args.Item.Text == "Organize")
            {
                VisibleProperty = true;
                string path = FileManager?.Path + FileManager?.SelectedItems[0] + "/";
                bool showHiddenItems = args.FileDetails[0].ShowHiddenItems;
                await FileManagerService.OrganizeFiles(path, showHiddenItems, args.FileDetails.ToArray());
                VisibleProperty = false;
                await FileManager.OpenFileAsync(args.FileDetails[0].Name);
            }
        }

        private async Task OnMenuClick(MenuClickEventArgs<FileManagerDirectoryContent> args)
        {
            if (args.Item.Text == "Organize")
            {
                VisibleProperty = true;
                string path = FileManager?.Path + FileManager?.SelectedItems[0] + "/";
                bool showHiddenItems = args.FileDetails[0].ShowHiddenItems;
                await FileManagerService.OrganizeFiles(path, showHiddenItems, args.FileDetails.ToArray());
                VisibleProperty = false;
                await FileManager.OpenFileAsync(args.FileDetails[0].Name);
            }
            else if (args.Item.Text == "Quick Summary")
            {
                if (args.FileDetails[0].Permission == null)
                {
                    try
                    {
                        await SummarizeAsync(args.FileDetails[0].IsFile, args.FileDetails[0].Type, args.FileDetails[0].FilterPath, args.FileDetails[0].Name);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else if (args.FileDetails[0].Permission != null && !args.FileDetails[0].Permission.Read)
                {
                    this.IsDialogVisible = true;
                    this.DialogContent = args.FileDetails[0].Name + " is not accessible. You do not have permission to read this file.";
                }
            }
        }

        private void MenuOpened(MenuOpenEventArgs<FileManagerDirectoryContent> args)
        {
            if (FileManager?.SelectedItems.Length == 0 || FileManager?.SelectedItems.Length > 1)
            {
                FileManager?.DisableMenuItems(new string[] { "Organize", "Quick Summary" });
            }
            for (int i = 0; i < args.Items.Count(); i++)
            {
                if (args.Items[i].Id == FileManager?.ID + "_cm_organize")
                {
                    args.Items[i].IconCss = "e-icons e-folder";
                }
                if (args.Items[i].Id == FileManager?.ID + "_cm_quick summary")
                {
                    args.Items[i].IconCss = "e-icons e-print-layout";
                }
            }
        }

        public async Task OnFileOpen(FileOpenEventArgs<FileManagerDirectoryContent> args)
        {
            if (args.FileDetails != null && args.FileDetails.IsFile && AllowedFileTypes.Contains(args.FileDetails.Type))
            {
                if (args.FileDetails.Permission == null)
                {
                    try
                    {
                        await SummarizeAsync(args.FileDetails.IsFile, args.FileDetails.Type, args.FileDetails.FilterPath, args.FileDetails.Name);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else if (args.FileDetails.Permission != null && !args.FileDetails.Permission.Read)
                {
                    this.IsDialogVisible = true;
                    this.DialogContent = args.FileDetails.Name + " is not accessible. You do not have permission to read this file.";
                }
            }
            else
            {
                this.IsDialogVisible = false;
            }
        }
        public async Task SummarizeAsync(bool isFile, string type, string filterPath, string name)
        {
            if (!isFile || string.IsNullOrEmpty(filterPath) || string.IsNullOrEmpty(name))
            {
                this.DialogContent = "Invalid file or path.";
                this.IsDialogVisible = false;
                this.isContentGenerating = false;
                StateHasChanged();
                return;
            }

            this.IsDialogVisible = true;
            this.isContentGenerating = true;
            string root = FileManagerService.DemoDirectoryName + "\\" + FileManagerId + "\\" + "Files";
            string filePath = $"wwwroot\\{root}{filterPath}{name}";
            string fileContent = ExtractTextFromFile(filePath);

            if (string.IsNullOrEmpty(fileContent) || selectedOption != "Open AI")
            {
                this.DialogContent = "Please provide a proper file content to summarize.";
                this.isContentGenerating = false;
                StateHasChanged();
                return;
            }

            string promptQuery = "You are a helpful assistant. Your task is to analyze the provided text and generate a short summary. Provide the summary with highlighted topics in ordered list HTML format and it should be ready for execution :\n\n Do not provide codeblock prefixes or introductory texts such as ``` or html, etc.";
            string query = promptQuery + fileContent;

            string finalSummary = await AzureAIService.GetCompletionAsync(query, false);

            this.DialogContent = !string.IsNullOrEmpty(finalSummary) ? finalSummary : "Please provide a proper file content to summarize.";
            this.isContentGenerating = false;
            StateHasChanged();
        }

        public void OnClose(BeforeCloseEventArgs args)
        {
            this.DialogContent = "";
            this.IsDialogVisible = false;
        }

        private void DialogOverlay()
        {
            this.IsDialogVisible = false;
        }


        private string ExtractTextFromFile(string filePath)
        {
            string text = string.Empty;
            string extension = Path.GetExtension(filePath).ToLower();
            if (extension == ".txt")
            {
                text = File.ReadAllText(filePath);
            }
            else if (extension == ".docx")
            {
                text = ExtractTextFromWord(filePath);
            }
            else if (extension == ".pdf")
            {
                text = ExtractTextFromPdf(filePath);
            }
            return text;
        }

        private string ExtractTextFromWord(string filePath)
        {
            StringBuilder textBuilder = new StringBuilder();
            using (FileStream sourceStreamPath = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (WordDocument document = new WordDocument(sourceStreamPath, FormatType.Docx))
                {
                    string cleanedText = Regex.Replace(document.GetText(), @"[\r\n]+", "");
                    cleanedText = Regex.Replace(cleanedText, @"\s{2,}", "");
                    textBuilder.Append(cleanedText);
                }
            }
            return textBuilder.ToString();
        }

        private string ExtractTextFromPdf(string filePath)
        {
            List<string> extractedText = new List<string>();
            FileStream fileStream = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            using (PdfLoadedDocument loadedDocument = new PdfLoadedDocument(fileStream))
            {
                PdfLoadedPageCollection loadedPages = loadedDocument.Pages;
                using (MemoryStream annotationStream = new MemoryStream())
                {
                    loadedDocument.ExportAnnotations(annotationStream, AnnotationDataFormat.Json);
                    string annotations = ConvertToString(annotationStream);
                    if (!String.IsNullOrEmpty(annotations))
                    {
                        extractedText.Add("Annotations: " + annotations);
                    }
                }
                using (MemoryStream formStream = new MemoryStream())
                {
                    if (loadedDocument.Form != null)
                    {
                        loadedDocument.Form.ExportData(formStream, DataFormat.Json, "form");
                        string formFields = ConvertToString(formStream);
                        if (!String.IsNullOrEmpty(formFields))
                        {
                            extractedText.Add("Form fields: " + formFields);
                        }
                    }
                }
                for (int i = 0; i < loadedPages.Count; i++)
                {
                    string text = $"... Page {i + 1} ...\n";
                    text += loadedPages[i].ExtractText();
                    extractedText.Add(text);
                }
            }
            return String.Join(" ", extractedText.Take(10));
        }

        private string ConvertToString(MemoryStream memoryStream)
        {
            memoryStream.Position = 0;
            using (StreamReader reader = new StreamReader(memoryStream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
