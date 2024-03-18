#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.IO.Compression;
using Syncfusion.Blazor.FileManager;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using System.Text;

namespace BlazorDemos.Pages.FileManager
{
    public class FileManagerService
    {
        List<FileManagerDirectoryContent> CopyFiles = new List<FileManagerDirectoryContent>();

        List<FileManagerDirectoryContent> Data = new List<FileManagerDirectoryContent>();

        public FileManagerService()
        {
            this.GetData();
        }

        private void GetData()
        {
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterPath = "",
                FilterId = "",
                HasChild = true,
                Id = "0",
                IsFile = false,
                Name = "Files",
                ParentId = null,
                ShowHiddenItems = false,
                Size = 1779448,
                Type = "folder"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/",
                FilterPath = "/",
                HasChild = false,
                Id = "1",
                IsFile = false,
                Name = "Documents",
                ParentId = "0",
                ShowHiddenItems = false,
                Size = 680786,
                Type = "folder"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/",
                FilterPath = "/",
                HasChild = false,
                Id = "2",
                IsFile = false,
                Name = "Downloads",
                ParentId = "0",
                ShowHiddenItems = false,
                Size = 6172,
                Type = "folder"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/",
                FilterPath = "/",
                HasChild = false,
                Id = "3",
                IsFile = false,
                Name = "Music",
                ParentId = "0",
                ShowHiddenItems = false,
                Size = 20,
                Type = "folder"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/",
                FilterPath = "/",
                HasChild = false,
                Id = "4",
                IsFile = false,
                Name = "Videos",
                ParentId = "0",
                ShowHiddenItems = false,
                Size = 20,
                Type = "folder"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/1/",
                FilterPath = "/Documents/",
                HasChild = false,
                Id = "5",
                IsFile = true,
                Name = "EJ2 File Manager.docx",
                ParentId = "1",
                ShowHiddenItems = false,
                Size = 12403,
                Type = ".docx"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/1/",
                FilterPath = "/Documents/",
                HasChild = false,
                Id = "6",
                IsFile = true,
                Name = "EJ2 File Manager.pdf",
                ParentId = "1",
                ShowHiddenItems = false,
                Size = 90099,
                Type = ".pdf"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/1/",
                FilterPath = "/Documents/",
                HasChild = false,
                Id = "7",
                IsFile = true,
                Name = "File Manager PPT.pptx",
                ParentId = "1",
                ShowHiddenItems = false,
                Size = 578010,
                Type = ".pptx"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/1/",
                FilterPath = "/Documents/",
                HasChild = false,
                Id = "8",
                IsFile = true,
                Name = "File Manager.txt",
                ParentId = "1",
                ShowHiddenItems = false,
                Size = 274,
                Type = ".txt"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/2/",
                FilterPath = "/Downloads/",
                HasChild = false,
                Id = "9",
                IsFile = true,
                Name = "Sample Work Sheet.xlsx",
                ParentId = "2",
                ShowHiddenItems = false,
                Size = 6172,
                Type = ".xlsx"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/3/",
                FilterPath = "/Music/",
                HasChild = false,
                Id = "10",
                IsFile = true,
                Name = "Music.mp3",
                ParentId = "3",
                ShowHiddenItems = false,
                Size = 10,
                Type = ".mp3"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/3/",
                FilterPath = "/Music/",
                HasChild = false,
                Id = "11",
                IsFile = true,
                Name = "Sample Music.mp3",
                ParentId = "3",
                ShowHiddenItems = false,
                Size = 10,
                Type = ".mp3"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/4/",
                FilterPath = "/Videos/",
                HasChild = false,
                Id = "12",
                IsFile = true,
                Name = "Demo Video.mp4",
                ParentId = "4",
                ShowHiddenItems = false,
                Size = 10,
                Type = ".mp4"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/4/",
                FilterPath = "/Videos/",
                HasChild = false,
                Id = "13",
                IsFile = true,
                Name = "Sample Video.mp4",
                ParentId = "4",
                ShowHiddenItems = false,
                Size = 10,
                Type = ".mp4"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/",
                FilterPath = "/",
                HasChild = true,
                Id = "14",
                IsFile = false,
                Name = "Pictures",
                ParentId = "0",
                ShowHiddenItems = false,
                Size = 1092490,
                Type = "folder"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/14/",
                FilterPath = "/Pictures/",
                HasChild = false,
                Id = "15",
                IsFile = false,
                Name = "Employees",
                ParentId = "14",
                ShowHiddenItems = false,
                Size = 324650,
                Type = "folder"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/14/15/",
                FilterPath = "/Pictures/Employees/",
                HasChild = false,
                Id = "16",
                IsFile = true,
                Name = "1.png",
                ParentId = "15",
                ShowHiddenItems = false,
                Size = 49792,
                Type = ".png"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/14/15/",
                FilterPath = "/Pictures/Employees/",
                HasChild = false,
                Id = "17",
                IsFile = true,
                Name = "2.png",
                ParentId = "15",
                ShowHiddenItems = false,
                Size = 50801,
                Type = ".png"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/14/15/",
                FilterPath = "/Pictures/Employees/",
                HasChild = false,
                Id = "18",
                IsFile = true,
                Name = "3.png",
                ParentId = "15",
                ShowHiddenItems = false,
                Size = 48951,
                Type = ".png"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/14/15/",
                FilterPath = "/Pictures/Employees/",
                HasChild = false,
                Id = "19",
                IsFile = true,
                Name = "4.png",
                ParentId = "15",
                ShowHiddenItems = false,
                Size = 46393,
                Type = ".png"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/14/15/",
                FilterPath = "/Pictures/Employees/",
                HasChild = false,
                Id = "20",
                IsFile = true,
                Name = "5.png",
                ParentId = "15",
                ShowHiddenItems = false,
                Size = 66523,
                Type = ".png"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/14/15/",
                FilterPath = "/Pictures/Employees/",
                HasChild = false,
                Id = "21",
                IsFile = true,
                Name = "6.png",
                ParentId = "15",
                ShowHiddenItems = false,
                Size = 62190,
                Type = ".png"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/14/",
                FilterPath = "/Pictures/",
                HasChild = false,
                Id = "22",
                IsFile = false,
                Name = "Foods",
                ParentId = "14",
                ShowHiddenItems = false,
                Size = 299969,
                Type = "folder"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/14/22/",
                FilterPath = "/Pictures/Foods/",
                HasChild = false,
                Id = "23",
                IsFile = true,
                Name = "bread.png",
                ParentId = "22",
                ShowHiddenItems = false,
                Size = 100486,
                Type = ".png"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/14/22/",
                FilterPath = "/Pictures/Foods/",
                HasChild = false,
                Id = "24",
                IsFile = true,
                Name = "doughnut.png",
                ParentId = "22",
                ShowHiddenItems = false,
                Size = 99344,
                Type = ".png"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/14/22/",
                FilterPath = "/Pictures/Foods/",
                HasChild = false,
                Id = "25",
                IsFile = true,
                Name = "nuggets.png",
                ParentId = "22",
                ShowHiddenItems = false,
                Size = 100139,
                Type = ".png"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/14/",
                FilterPath = "/Pictures/",
                HasChild = false,
                Id = "26",
                IsFile = false,
                Name = "Nature",
                ParentId = "14",
                ShowHiddenItems = false,
                Size = 467871,
                Type = "folder"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/14/26/",
                FilterPath = "/Pictures/Nature/",
                HasChild = false,
                Id = "27",
                IsFile = true,
                Name = "bird.png",
                ParentId = "26",
                ShowHiddenItems = false,
                Size = 102182,
                Type = ".png"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/14/26/",
                FilterPath = "/Pictures/Nature/",
                HasChild = false,
                Id = "28",
                IsFile = true,
                Name = "sea.png",
                ParentId = "26",
                ShowHiddenItems = false,
                Size = 97145,
                Type = ".png"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/14/26/",
                FilterPath = "/Pictures/Nature/",
                HasChild = false,
                Id = "29",
                IsFile = true,
                Name = "seaview.png",
                ParentId = "26",
                ShowHiddenItems = false,
                Size = 95866,
                Type = ".png"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/14/26/",
                FilterPath = "/Pictures/Nature/",
                HasChild = false,
                Id = "30",
                IsFile = true,
                Name = "snow.png",
                ParentId = "26",
                ShowHiddenItems = false,
                Size = 74666,
                Type = ".png"
            });
            Data.Add(new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = new DateTime(2022, 1, 2),
                DateModified = new DateTime(2022, 2, 3),
                FilterId = "0/14/26/",
                FilterPath = "/Pictures/Nature/",
                HasChild = false,
                Id = "31",
                IsFile = true,
                Name = "snowfall.png",
                ParentId = "26",
                ShowHiddenItems = false,
                Size = 98012,
                Type = ".png"
            });
        }

        public async Task<FileManagerResponse<FileManagerDirectoryContent>> ReadAsync(string path, List<FileManagerDirectoryContent> fileDetails)
        {
            FileManagerResponse<FileManagerDirectoryContent> response = new FileManagerResponse<FileManagerDirectoryContent>();
            if (path == "/")
            {
                string ParentId = Data
                    .Where(x => x.FilterPath == string.Empty)
                    .Select(x => x.Id).First();
                response.CWD = Data
                    .Where(x => x.FilterPath == string.Empty).First();
                response.Files = Data
                    .Where(x => x.ParentId == ParentId).ToList();
            }
            else
            {
                var id = fileDetails.Count > 0 && fileDetails[0] != null ? fileDetails[0].Id : Data
                    .Where(x => x.FilterPath == path)
                    .Select(x => x.ParentId).First();
                response.CWD = Data
                    .Where(x => x.Id == (fileDetails.Count > 0 && fileDetails[0] != null ? fileDetails[0].Id : id)).First();
                response.Files = Data
                    .Where(x => x.ParentId == (fileDetails.Count > 0 && fileDetails[0] != null ? fileDetails[0].Id : id)).ToList();
            }
            await Task.Yield();
            return await Task.FromResult(response);
        }
        public async Task<FileManagerResponse<FileManagerDirectoryContent>> DeleteAsync(string path, List<FileManagerDirectoryContent> fileDetails)
        {
            FileManagerResponse<FileManagerDirectoryContent> response = new FileManagerResponse<FileManagerDirectoryContent>();
            var idsToDelete = fileDetails.Cast<FileManagerDirectoryContent>().Select(x => x.Id).ToList();
            string ParentId = fileDetails[0].ParentId;
            idsToDelete.AddRange(Data.Where(file => idsToDelete.Contains((file).ParentId)).Select(file => (file).Id));
            Data.RemoveAll(file => idsToDelete.Contains((file).Id));
            response.Files = fileDetails.ToList();
            Data.Where(x => ParentId == x.Id).Select(x => x).FirstOrDefault().HasChild = Data.Where(x => (ParentId == x.ParentId) && x.IsFile == false).Count() > 0;
            return await Task.FromResult(response);
        }

        public async Task<FileManagerResponse<FileManagerDirectoryContent>> CreateAsync(string path, string name, FileManagerDirectoryContent fileDetails)
        {
            FileManagerResponse<FileManagerDirectoryContent> response = new FileManagerResponse<FileManagerDirectoryContent>();
            List<FileManagerDirectoryContent> newFolder = new List<FileManagerDirectoryContent>();
            int idValue = Data.Select(x => x).Select(x => x.Id).ToArray().Select(int.Parse).ToArray().Max();
            await Task.Yield();
            newFolder.Add(new FileManagerDirectoryContent()
            {
                Id = (idValue + 1).ToString(),
                Name = name,
                Size = 0,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                Type = "",
                ParentId = fileDetails.Id,
                HasChild = false,
                FilterPath = path,
                FilterId = fileDetails.FilterId + fileDetails.Id + "/",
                IsFile = false,
            });
            response.Files = newFolder;
            Data.AddRange(newFolder);
            Data.Select(x => x).Where(x => x.Id == fileDetails.Id).FirstOrDefault().HasChild = true;
            return await Task.FromResult(response);
        }

        public Task<FileManagerResponse<FileManagerDirectoryContent>> SearchAsync(string path, string searchString)
        {
            FileManagerResponse<FileManagerDirectoryContent> response = new FileManagerResponse<FileManagerDirectoryContent>();
            char[] i = new Char[] { '*' };
            FileManagerDirectoryContent[] searchFiles = Data.Select(x => x).Where(x => x.Name.ToLower().Contains(searchString.TrimStart(i).TrimEnd(i).ToLower())).Select(x => x).ToArray();
            response.Files = searchFiles.ToList();
            return Task.FromResult(response);
        }

        public async Task<FileManagerResponse<FileManagerDirectoryContent>> RenameAsync(string path, string newName, FileManagerDirectoryContent fileDetails)
        {
            FileManagerResponse<FileManagerDirectoryContent> renameResponse = new FileManagerResponse<FileManagerDirectoryContent>();
            renameResponse.Files = new List<FileManagerDirectoryContent>();
            FileManagerDirectoryContent data = Data.Where(x => x.Id == fileDetails.Id).FirstOrDefault();
            Data.Remove(data);
            FileManagerDirectoryContent renamedFile = new FileManagerDirectoryContent()
            {
                CaseSensitive = false,
                DateCreated = data.DateCreated,
                DateModified = DateTime.Now,
                FilterId = data.FilterId,
                FilterPath = data.FilterPath,
                HasChild = data.IsFile ? false : data.HasChild,
                Id = data.Id,
                IsFile = data.IsFile,
                Name = newName,
                ParentId = data.ParentId,
                ShowHiddenItems = data.ShowHiddenItems,
                Size = data.Size,
                Type = data.Type
            };
            renameResponse.Files.Add(renamedFile);
            Data.AddRange(renameResponse.Files);
            List<string> idsToRename = new List<string>() { fileDetails.Id };
            idsToRename.AddRange(Data.Where(file => idsToRename.Contains(file.ParentId)).Select(file => file.Id));
            foreach (FileManagerDirectoryContent child in Data.Where(x => idsToRename.Contains(x.Id)))
            {
                string[] filterIds = child.FilterId.Split('/');
                StringBuilder filterPath = new StringBuilder();
                for (int i = 0; i < filterIds.Length - 1; i++)
                {
                    if (filterIds[i] == "0")
                    {
                        filterPath.Append("/");
                    }
                    else
                    {
                        string fileName = Data.FirstOrDefault(x => x.Id == filterIds[i])?.Name;
                        filterPath.Append(fileName).Append("/");
                    }
                }
                child.FilterPath = filterPath.ToString();
            }
            await Task.Yield();
            return await Task.FromResult(renameResponse);
        }

        public async Task<FileManagerResponse<FileManagerDirectoryContent>> MoveAsync(string path, FileManagerDirectoryContent targetData, List<FileManagerDirectoryContent> fileDetails)
        {
            FileManagerResponse<FileManagerDirectoryContent> moveresponse = new FileManagerResponse<FileManagerDirectoryContent>();
            moveresponse.Files = new List<FileManagerDirectoryContent>();
            foreach (FileManagerDirectoryContent file in fileDetails)
            {
                FileManagerDirectoryContent data = Data.Where(x => x.Id == file.Id).FirstOrDefault();
                Data.Remove(data);
                FileManagerDirectoryContent movedFile = new FileManagerDirectoryContent()
                {
                    CaseSensitive = false,
                    DateCreated = data.DateCreated,
                    DateModified = data.DateModified,
                    FilterId = $"{targetData.FilterId}{targetData.Id}/",
                    FilterPath = $"{targetData.FilterPath.Replace(@"\", "/", StringComparison.Ordinal)}{targetData.Name}/",
                    HasChild = data.IsFile ? false : data.HasChild,
                    Id = data.Id,
                    IsFile = data.IsFile,
                    Name = data.Name,
                    ParentId = targetData.Id,
                    ShowHiddenItems = data.ShowHiddenItems,
                    Size = data.Size,
                    Type = data.Type
                };
                moveresponse.Files.Add(movedFile);
            }
            Data.AddRange(moveresponse.Files);
            await Task.Yield();
            return await Task.FromResult(moveresponse);
        }

        public async Task<FileManagerResponse<FileManagerDirectoryContent>> CopyAsync(string path, FileManagerDirectoryContent targetData, List<FileManagerDirectoryContent> data)
        {
            FileManagerResponse<FileManagerDirectoryContent> copyResponse = new FileManagerResponse<FileManagerDirectoryContent>();
            List<string> children = Data.Where(x => x.ParentId == data[0].Id).Select(x => x.Id).ToList();
            if (children.IndexOf(targetData.Id) != -1 || data[0].Id == targetData.Id)
            {
                ErrorDetails er = new ErrorDetails();
                er.Code = "400";
                er.Message = "The destination folder is the subfolder of the source folder.";
                copyResponse.Error = er;
                return await Task.FromResult(copyResponse);
            }
            foreach (FileManagerDirectoryContent item in data)
            {
                try
                {
                    int idValue = Data.Select(x => x).Select(x => x.Id).ToArray().Select(int.Parse).ToArray().Max();
                    if (item.IsFile)
                    {
                        List<FileManagerDirectoryContent> i = Data.Where(x => x.Id == item.Id).Select(x => x).ToList();
                        FileManagerDirectoryContent CreateData = new FileManagerDirectoryContent()
                        {
                            Id = (idValue + 1).ToString(),
                            Name = item.Name,
                            Size = i[0].Size,
                            DateCreated = DateTime.Now,
                            DateModified = DateTime.Now,
                            Type = i[0].Type,
                            HasChild = false,
                            ParentId = targetData.Id,
                            IsFile = true,
                            FilterPath = targetData.FilterPath + targetData.Name + "/",
                            FilterId = targetData.FilterId + targetData.Id + "/"
                        };
                        CopyFiles.Add(CreateData);
                        Data.Add(CreateData);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                    return null;
                }
            }
            foreach (FileManagerDirectoryContent item in data)
            {
                try
                {
                    if (!item.IsFile)
                    {
                        this.CopyFolderItems(item, targetData);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                    return null;
                }
            }
            await Task.Yield();
            copyResponse.Files = CopyFiles;
            return await Task.FromResult(copyResponse);
        }

        private void CopyFolderItems(FileManagerDirectoryContent item, FileManagerDirectoryContent target)
        {
            if (!item.IsFile)
            {
                int idVal = Data.Select(x => x).Select(x => x.Id).ToArray().Select(int.Parse).ToArray().Max();
                List<FileManagerDirectoryContent> i = Data.Where(x => x.Id == item.Id).Select(x => x).ToList();
                FileManagerDirectoryContent CreateData = new FileManagerDirectoryContent()
                {
                    Id = (idVal + 1).ToString(),
                    Name = item.Name,
                    Size = 0,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    Type = "folder",
                    HasChild = false,
                    ParentId = target.Id,
                    IsFile = false,
                    FilterPath = target.FilterPath + target.Name + "/",
                    FilterId = target.FilterId + target.Id + "/"
                };
                CopyFiles.Add(CreateData);
                Data.Add(CreateData);
                if (target.HasChild == false)
                {
                    Data.Where(x => x.Id == target.Id).Select(x => x).ToList()[0].HasChild = true;
                }
            }
            FileManagerDirectoryContent[] childs = Data.Where(x => x.ParentId == item.Id).Select(x => x).ToArray();
            int idValue = Data.Select(x => x).Select(x => x.Id).ToArray().Select(int.Parse).ToArray().Max();
            if (childs.Length > 0)
            {
                foreach (FileManagerDirectoryContent child in childs)
                {
                    if (child.IsFile)
                    {
                        int idVal = Data.Select(x => x).Select(x => x.Id).ToArray().Select(int.Parse).ToArray().Max();

                        FileManagerDirectoryContent CreateData = new FileManagerDirectoryContent()
                        {
                            Id = (idVal + 1).ToString(),
                            Name = child.Name,
                            Size = child.Size,
                            DateCreated = DateTime.Now,
                            DateModified = DateTime.Now,
                            Type = child.Type,
                            HasChild = false,
                            ParentId = idValue.ToString(),
                            IsFile = true,
                            FilterPath = target.FilterPath + target.Name + "/",
                            FilterId = target.FilterId + target.Id + "/"
                        };
                        Data.Add(CreateData);
                    }
                }
                foreach (FileManagerDirectoryContent child in childs)
                {
                    if (!child.IsFile)
                    {
                        this.CopyFolderItems(child, Data.Where(x => x.Id == (idValue).ToString()).Select(x => x).ToArray()[0]);
                    }
                }
            }
        }
    }
}