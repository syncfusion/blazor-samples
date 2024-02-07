#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.IO;
using System.Collections.Generic;


namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class AdvancedReplaceService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public AdvancedReplaceService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Replace a specific content in the Word document with another document
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream AdvancedReplace(string documentType, string button)
        {
            if (button == "View Template")
            {
                return fileDataValue["master-template.doc"];
            }
            //Creating new documents.
            WordDocument docSource1 = new WordDocument();
            WordDocument docSource2 = new WordDocument();
            WordDocument docMaster = new WordDocument();
            //Load Templates.
            docSource1.Open(fileDataValue["source-template1.doc"], FormatType.Doc);
            docSource2.Open(fileDataValue["source-template2.doc"], FormatType.Doc);
            docMaster.Open(fileDataValue["master-template.doc"], FormatType.Doc);

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
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created Word document to MemoryStream
                docMaster.Save(stream, formatType);
                docMaster.Close();
                stream.Position = 0;
                return stream;
            }
        }
        /// <summary>
        /// Dispose the Dictionary
        /// </summary>
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