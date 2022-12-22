#region Copyright Syncfusion Inc. 2001 - 2022
// Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
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
        /// <summary>
        /// Converts the first page of word document to image
        /// </summary>
        /// <returns>Return the created image as stream</returns>
        public MemoryStream WordToImage(string button)
        {
            string basePath = @"wwwroot/";
            string dataPath = basePath + @"data/word/WordtoImage.docx";
            FileStream fileStream = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            if (button == "View Template")
            {
                MemoryStream ms = new MemoryStream();
                fileStream.Position = 0;
                fileStream.CopyTo(ms);
                fileStream.Dispose();
                return ms;
            }
            fileStream = null;
            // Load the template.
            FileStream fileStreamPath = new FileStream(dataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            WordDocument document = new WordDocument(fileStreamPath, FormatType.Docx);
            fileStreamPath.Dispose();
            fileStreamPath = null;
            DocIORenderer render = new DocIORenderer();
            //Converts the first page of word document to image
            MemoryStream imageStream = (MemoryStream)document.RenderAsImages(0, Syncfusion.DocIO.ExportImageFormat.Jpeg);
            render.Dispose();
            document.Close();
            imageStream.Position = 0;
            return imageStream;
        }
    }  
}