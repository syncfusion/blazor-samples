#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIORenderer;
using Syncfusion.Pdf;
using Syncfusion.Drawing;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Xml;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class WordToImageService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public WordToImageService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Converts the first page of word document to image
        /// </summary>
        /// <returns>Return the created image as stream</returns>
        public MemoryStream WordToImage(string button)
        {
            if (button == "View Template")
            {
                return fileDataValue["word-to-image.docx"];
            }
            // Load the template.
            WordDocument document = new WordDocument(fileDataValue["word-to-image.docx"], FormatType.Docx);
            DocIORenderer render = new DocIORenderer();
            //Converts the first page of word document to image
            MemoryStream imageStream = (MemoryStream)document.RenderAsImages(0, Syncfusion.DocIO.ExportImageFormat.Jpeg);
            render.Dispose();
            document.Close();
            imageStream.Position = 0;
            return imageStream;
        }
        #region HelperMethod
        /// <summary>
        /// Dispose the Dictionary
        /// </summary>
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