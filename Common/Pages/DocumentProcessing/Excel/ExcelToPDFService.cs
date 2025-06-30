#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.Collections.Generic;
using Syncfusion.XlsIORenderer;
using Syncfusion.Pdf;
using System.IO;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class ExcelToPDFService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public ExcelToPDFService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create an Excel document
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream ExceltoPDFXlsIO(string option)
        {
            XlsIORenderer renderer = new XlsIORenderer();

            //Initialize the PdfDocument Class
            PdfDocument document = new PdfDocument();

            //Initialize the ExcelToPdfConverterSettings class
            XlsIORendererSettings settings = new XlsIORendererSettings();
            settings.IsConvertBlankPage = false;

            //Set the Layout Options for the output Pdf page
            if (option == "NoScaling")
                settings.LayoutOptions = LayoutOptions.NoScaling;
            else if (option == "FitAllRowsOnOnePage")
                settings.LayoutOptions = LayoutOptions.FitAllRowsOnOnePage;
            else if (option == "FitAllColumnsOnOnePage")
                settings.LayoutOptions = LayoutOptions.FitAllColumnsOnOnePage;
            else
                settings.LayoutOptions = LayoutOptions.FitSheetOnOnePage;

            //Assign the output PdfDocument to the TemplateDocument property of ExcelToPdfConverterSettings 
            settings.TemplateDocument = document;
            settings.DisplayGridLines = GridLinesDisplayStyle.Invisible;

            //Convert the Excel document to PDf
            document = renderer.ConvertToPDF(fileDataValue["excel-to-pdf.xlsx"], settings);

            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created PDF document to MemoryStream
                document.Save(stream);
                return stream;
            }
        }
        #region HelperMethod
        public void Close()
        {
            foreach (KeyValuePair<string, MemoryStream> item in fileDataValue)
            {
                item.Value.Dispose();
            }
            fileDataValue.Clear();
        }
        #endregion
    }
}