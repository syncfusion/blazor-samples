#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace BlazorDemos.Data.FileFormats.DocIO
{
    public class AdvancedReplaceService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public AdvancedReplaceService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        /// <summary>
        /// Replace a specific content in the Word document with another document
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream AdvancedReplace(string documentType, string button)
        {
            string basePath = _hostingEnvironment.WebRootPath;
            string dataPathTemp = basePath + @"/data/docio/source-template1.doc";
            string dataPathTemplate = basePath + @"/data/docio/source-template2.doc";
            string dataPathMaster = basePath + @"/data/docio/master-template.doc";
            //Load Template document stream.
            FileStream fileStream = new FileStream(dataPathMaster, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);            
            if (button == "View Template")
            {               
                MemoryStream ms = new MemoryStream();
                fileStream.Position = 0;
                fileStream.CopyTo(ms);
                fileStream.Dispose();               
                return ms;
            }
            fileStream = null;
            //Creating new documents.
            WordDocument docSource1 = new WordDocument();
            WordDocument docSource2 = new WordDocument();
            WordDocument docMaster = new WordDocument();
            //Load Templates.
            fileStream = new FileStream(dataPathTemp, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            docSource1.Open(fileStream, FormatType.Doc);
            fileStream.Dispose();
            fileStream = null;
            fileStream = new FileStream(dataPathTemplate, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            docSource2.Open(fileStream, FormatType.Doc);
            fileStream.Dispose();
            fileStream = null;
            fileStream = new FileStream(dataPathMaster, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            docMaster.Open(fileStream, FormatType.Doc);
            fileStream.Dispose();
            fileStream = null;
            //Search for a string and store in TextSelection
            //The TextSelection copies a text segment with formatting.
            TextSelection selection1 = docSource1.Find("PlaceHolder text is replaced with this formatted animated text", false, false);
            //Get the text segment to replace the tex across multiple paragraphs
            TextBodyPart replacePart = new TextBodyPart(docSource2);
            foreach (TextBodyItem bodyItem in docSource2.LastSection.Body.ChildEntities)
                replacePart.BodyItems.Add(bodyItem.Clone());
            //Replacing the placeholder inside Master Template with matches found while
            //search the two template documents. 
            docMaster.Replace("PlaceHolder1", selection1, true, true, true);
            docMaster.ReplaceSingleLine((new System.Text.RegularExpressions.Regex("PlaceHolder2Start:Suppliers/Vendors of Northwind." +
            "Customers of Northwind.Employee details of Northwind traders.The product information.The inventory details.The shippers." +
            "PO transactions i.e Purchase Order transactions.Sales Order transaction.Inventory transactions.Invoices.PlaceHolder2End")), replacePart);

            FormatType formatType = FormatType.Docx;
            //Save as .doc format
            if (documentType == "WordDoc")            
                formatType = FormatType.Doc;                
            //Save as .xml format
            else if (documentType == "WordML")
                formatType = FormatType.WordML;            
            //Save the document as a stream and retrun the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created Word document to MemoryStream
                docMaster.Save(stream, formatType);
                docMaster.Close();
                stream.Position = 0;
                return stream;
            }
        }      
    }   
}