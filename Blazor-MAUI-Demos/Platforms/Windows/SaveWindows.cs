#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Popups;

namespace Blazor_MAUI_Demos.Services
{
    public partial class SaveService
    {
        public async partial void SaveAndView(string filename, string contentType, MemoryStream stream)
        {
            StorageFile stFile;
            string extension = Path.GetExtension(filename);
            //Gets process windows handle to open the dialog in application process. 
            IntPtr windowHandle = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
            if (!Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons"))
            {
                //Creates file save picker to save a file. 
                FileSavePicker savePicker = new();
                if (extension == ".xlsx")
                {
                    savePicker.DefaultFileExtension = ".xlsx";
                    savePicker.SuggestedFileName = filename;
                    //Saves the file as xlsx file.
                    savePicker.FileTypeChoices.Add("XLSX", new List<string>() { ".xlsx" });
                }
                if (extension == ".docx")
                {
                    savePicker.DefaultFileExtension = ".docx";
                    savePicker.SuggestedFileName = filename;
                    //Saves the file as Docx file.
                    savePicker.FileTypeChoices.Add("DOCX", new List<string>() { ".docx" });
                }
                else if (extension == ".doc")
                {
                    savePicker.DefaultFileExtension = ".doc";
                    savePicker.SuggestedFileName = filename;
                    //Saves the file as Doc file.
                    savePicker.FileTypeChoices.Add("DOC", new List<string>() { ".doc" });
                }
                else if (extension == ".rtf")
                {
                    savePicker.DefaultFileExtension = ".rtf";
                    savePicker.SuggestedFileName = filename;
                    //Saves the file as Rtf file.
                    savePicker.FileTypeChoices.Add("RTF", new List<string>() { ".rtf" });
                }
                else if (extension == ".pdf")
                {
                    savePicker.DefaultFileExtension = ".pdf";
                    savePicker.SuggestedFileName = filename;
                    //Saves the file as Pdf file.
                    savePicker.FileTypeChoices.Add("PDF", new List<string>() { ".pdf" });
                }
                else if (extension == ".pptx")
                {
                    savePicker.DefaultFileExtension = ".pptx";
                    savePicker.SuggestedFileName = filename;
                    //Saves the file as pptx file.
                    savePicker.FileTypeChoices.Add("PPTX", new List<string>() { ".pptx" });
                }
                else if (extension == ".png")
                {
                    savePicker.DefaultFileExtension = ".png";
                    savePicker.SuggestedFileName = filename;
                    //Saves the file as png file.
                    savePicker.FileTypeChoices.Add("PNG", new List<string>() { ".png" });
                }

                WinRT.Interop.InitializeWithWindow.Initialize(savePicker, windowHandle);
                stFile = await savePicker.PickSaveFileAsync();
            }
            else
            {
                StorageFolder local = ApplicationData.Current.LocalFolder;
                stFile = await local.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);
            }
            if (stFile != null)
            {
                using (IRandomAccessStream zipStream = await stFile.OpenAsync(FileAccessMode.ReadWrite))
                {
                    //Writes compressed data from memory to file.
                    using Stream outstream = zipStream.AsStreamForWrite();
                    outstream.SetLength(0);
                    //Saves the stream as file.
                    byte[] buffer = stream.ToArray();
                    outstream.Write(buffer, 0, buffer.Length);
                    outstream.Flush();
                }
                //Create message dialog box. 
                MessageDialog msgDialog = new("Do you want to view the document?", "File has been created successfully");
                UICommand yesCmd = new("Yes");
                msgDialog.Commands.Add(yesCmd);
                UICommand noCmd = new("No");
                msgDialog.Commands.Add(noCmd);

                WinRT.Interop.InitializeWithWindow.Initialize(msgDialog, windowHandle);

                //Showing a dialog box. 
                IUICommand cmd = await msgDialog.ShowAsync();
                if (cmd.Label == yesCmd.Label)
                {
                    //Launch the saved file. 
                    await Windows.System.Launcher.LaunchFileAsync(stFile);
                }
            }
        }
    }
}
