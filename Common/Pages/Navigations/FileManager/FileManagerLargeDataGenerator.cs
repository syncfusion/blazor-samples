#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Blazor.FileManager;
using System;
using System.Collections.Generic;

namespace BlazorDemos.Pages.Navigations.FileManager
{
    public static class FileManagerLargeDataGenerator
    {
        private static Random _random = new Random();

        public static List<FileManagerDirectoryContent> GenerateFolders(int totalFolders, string rootName = "Files")
        {
            if (totalFolders < 0) totalFolders = 0;

            var data = new List<FileManagerDirectoryContent>();
            int id = 0;

            var root = new FileManagerDirectoryContent
            {
                Id = id.ToString(),
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
                    Id = id.ToString(),
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

                int randomChoice = _random.Next(0, 3);

                switch (randomChoice)
                {
                    case 0:
                        {
                            int fileCount = _random.Next(1, 5);
                            for (int k = 1; k <= fileCount; k++)
                            {
                                id++;
                                string fileExtension = GetRandomFileExtension(k);
                                long fileSize = GetRandomFileSize();

                                var file = new FileManagerDirectoryContent
                                {
                                    Id = id.ToString(),
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
                            int subfolderCount = _random.Next(1, 4);
                            for (int j = 1; j <= subfolderCount; j++)
                            {
                                id++;
                                var subfolder = new FileManagerDirectoryContent
                                {
                                    Id = id.ToString(),
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
                                int fileCount = _random.Next(2, 4);
                                for (int k = 1; k <= fileCount; k++)
                                {
                                    id++;
                                    string fileExtension = GetRandomFileExtension(k);
                                    long fileSize = GetRandomFileSize();

                                    var file = new FileManagerDirectoryContent
                                    {
                                        Id = id.ToString(),
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
                            int subfolderCount = _random.Next(1, 3);
                            for (int j = 1; j <= subfolderCount; j++)
                            {
                                id++;
                                var subfolder = new FileManagerDirectoryContent
                                {
                                    Id = id.ToString(),
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

                                int subFileCount = _random.Next(1, 3);
                                for (int k = 1; k <= subFileCount; k++)
                                {
                                    id++;
                                    string fileExtension = GetRandomFileExtension(k);
                                    long fileSize = GetRandomFileSize();

                                    var subFile = new FileManagerDirectoryContent
                                    {
                                        Id = id.ToString(),
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

                            int directFileCount = _random.Next(1, 3);
                            for (int m = 1; m <= directFileCount; m++)
                            {
                                id++;
                                string fileExtension = GetRandomFileExtension(m);
                                long fileSize = GetRandomFileSize();

                                var directFile = new FileManagerDirectoryContent
                                {
                                    Id = id.ToString(),
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
            return _random.Next(1024, 5242880);
        }
    }
}