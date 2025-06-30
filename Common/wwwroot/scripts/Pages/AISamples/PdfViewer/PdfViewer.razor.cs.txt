#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Syncfusion.Blazor.Inputs;
using Syncfusion.Blazor.SfPdfViewer;
using Syncfusion.Pdf.Parsing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.AISamples.PdfViewer
{
    public partial class PdfViewer
    {
        [Inject]
        IJSRuntime JsRuntime { get; set; }
        #region Properties
        [Parameter]
        public bool IsMobileDevice { get; set; } = false;
        [Parameter]
        public bool RefreshContainer { get; set; } = false;
        [Parameter]
        public string ViewerHeight { get; set; } = "inherit";
        private SfPdfViewer2? sfPdfViewer2;
        private SfUploader? uploadFiles;
        private string documentPath = "wwwroot/data/pdfviewer2/smartcomponents/form_document.pdf";
        private MemoryStream documentStream = new MemoryStream();
        private bool isDocumentLoaded = false;
        private bool isSpinnerVisible = false;
        private string displayBlurContainer => isSpinnerVisible ? "block" : "none";
        private List<ContextMenuItem> contextMenuItems = new List<ContextMenuItem>() { ContextMenuItem.Delete };
        private string clipboardText = string.Empty;
        #endregion

        #region Smart Fill Click methods
        private async Task SmartFillClicked()
        {
            this.isSpinnerVisible = true;
            //Read the text from the clipboard
            clipboardText = await JsRuntime.InvokeAsync<string>("navigator.clipboard.readText");
            // Read XFDF content from PDF Viewer as String to provide input to OpenAI
            string inputFileContentAsString = await GetXFDFAsString();
            // Generates a string with custom data for each form field in a PDF viewer
            string CustomValues = await HintValuesforFieldsAsString();

            string mergePrompt = $"Merge the input data into the XFDF file content. Hint text: {CustomValues}. " +
                                 $"Ensure the input data matches suitable field names. " +
                                 $"Here are the details: " +
                                 $"input data: {this.clipboardText}, " +
                                 $"XFDF information: {inputFileContentAsString}. " +
                                 $"Provide the resultant XFDF content directly, without any additional text, code blocks, or formatting markers like ```xml or ```." +
                                 $"Some conditions need to be followed: " +
                                 $"1. Input data is not directly provided as the field name; you need to think and merge appropriately. " +
                                 $"2. When comparing input data and field names, ignore case sensitivity. " +
                                 $"3. First, determine the best match for the field name. If there isn’t an exact match, use the input data to find a close match. " +
                                 $"4. If the input data has the value of a checkbox field, change the value of the checkbox field to ON and other fields should be OFF.";

            // Reuest to AI
            string resultantXfdfFile = await openAIService.GetCompletionAsync(mergePrompt, false);
            if (!string.IsNullOrEmpty(resultantXfdfFile))
            {
                // Convert the string directly to a MemoryStream
                using (MemoryStream inputFileStream = new MemoryStream(Encoding.UTF8.GetBytes(resultantXfdfFile)))
                {
                    // Import the form field data as XFDF
                    if (sfPdfViewer2 != null)
                    {
                        await sfPdfViewer2.ImportFormFieldsAsync(inputFileStream, FormFieldDataFormat.Xfdf);
                    }
                }
            }
            this.isSpinnerVisible = false;
        }

        // Method to read XFDF content from the PDF viewer and return it as a string
        private async Task<string> GetXFDFAsString()
        {
            MemoryStream stream = new MemoryStream();
            if (sfPdfViewer2 != null)
            {
                stream = (MemoryStream)await sfPdfViewer2.ExportFormFieldsAsync(FormFieldDataFormat.Xfdf);
                using (stream)
                {
                    if (stream != null)
                    {
                        using (StreamReader reader = new StreamReader(stream)) // Create a StreamReader to read from the stream
                        {
                            return reader.ReadToEnd(); // Read the stream content to the end and return as string
                        }
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            return "";
        }

        // This method generates a string with custom data for each form field in a PDF viewer
        private async Task<string> HintValuesforFieldsAsString()
        {
            //Load the PDF document.
            if (sfPdfViewer2 != null)
            {
                byte[] bytes = await sfPdfViewer2.GetDocumentAsync();
                documentStream = new MemoryStream(bytes);
                PdfLoadedDocument doc = new PdfLoadedDocument(documentStream);
                //Gets the loaded form.
                PdfLoadedForm form = doc.Form;
                PdfLoadedFormFieldCollection formFields = form.Fields;

                string hintData = string.Empty;

                foreach (var field in formFields)
                {

                    if (field is PdfLoadedListBoxField listBox)
                    {
                        // Append ListBox name and items to the hintData string
                        hintData += "\n" + listBox.Name + " : Collection of Items are :";
                        PdfLoadedListItemCollection options = listBox.Values;
                        foreach (PdfLoadedListItem option in options)
                        {
                            hintData += option.Text + ", ";
                        }
                    }
                    else if (field is PdfLoadedComboBoxField comboBox)
                    {
                        // Append comboBox name and items to the hintData string
                        hintData += "\n" + comboBox.Name + " : Collection of Items are :";
                        PdfLoadedListItemCollection options = comboBox.Values;
                        foreach (PdfLoadedListItem option in options)
                        {
                            hintData += option.Text + ", ";
                        }
                    }
                    else if (field is PdfLoadedRadioButtonListField radio)
                    {
                        // Append radioButton name and items to the hintData string
                        hintData += "\n" + radio.Name + " : Collection of Items are :";
                        PdfLoadedRadioButtonItemCollection options = radio.Items;
                        foreach (PdfLoadedRadioButtonItem option in options)
                        {
                            hintData += option.Value + ", ";
                        }
                    }
                    else if (field is PdfLoadedCheckBoxField checkbox)
                    {
                        try
                        {
                            string value = checkbox.GetValue("ExportValue");
                            // Append CheckBox Button name and value to the hintData string
                            hintData += "\n" + checkbox.Name + " : and the corresponding value is :" + value;
                        }
                        catch (Exception ex)
                        {
                            //throw ex;
                        }
                    }
                    // Check if the form field name contains 'Date', 'dob', or 'date'
                    else if (field is PdfLoadedTextBoxField dob)
                    {
                        if (dob.Name.Contains("Date") || dob.Name.Contains("dob") || dob.Name.Contains("date"))
                        {
                            // Append instructions for date format to the hintData string
                            hintData += "\n" + dob.Name + " : Write Date in MM/dd/YYYY format";
                        }
                    }

                }
                // Return the hintData string if not null, otherwise return an empty string
                if (!string.IsNullOrEmpty(hintData))
                {
                    return hintData;
                }
                else
                {
                    return "";
                }
            }
            return "";
        }
        #endregion

        #region Toolbar click methods
        private async Task CreatedHandler()
        {
            await JsRuntime.InvokeVoidAsync("created");
        }
        private async Task FileUploadSelected(UploadingEventArgs args)
        {
            if (args.FileData.Type == "pdf" && sfPdfViewer2 != null && uploadFiles != null)
            {
                string base64string = args.FileData.RawFile?.ToString();
                //Loads the PDF docuent from the given base64 string in the SfPdfViewer.
                await sfPdfViewer2.LoadAsync(base64string, null);
                await uploadFiles.ClearAllAsync();
            }
        }
        private async void Download()
        {
            if (sfPdfViewer2 != null)
            {
                //Downloads the PDF document being loaded in the PDFViewer2.
                await sfPdfViewer2.DownloadAsync();
            }
        }
        private async void Print()
        {
            if (sfPdfViewer2 != null)
            {
                //Print the PDF document being loaded in the PDFViewer2.
                await sfPdfViewer2.PrintAsync();
            }
        }
        #endregion
        protected async override Task OnParametersSetAsync()
        {
            if (RefreshContainer && sfPdfViewer2 != null)
            {
                await Task.Delay(500);
                await sfPdfViewer2.UpdateViewerContainerAsync();
            }
        }
        private void DocumentLoaded(LoadEventArgs args)
        {
            isDocumentLoaded = true;
        }
        public void Dispose()
        {
            isDocumentLoaded = false;
            documentStream?.Dispose();
            contextMenuItems?.Clear();
        }
    }
}
