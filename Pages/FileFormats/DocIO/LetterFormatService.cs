#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.Data;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace BlazorDemos.Data.FileFormats.DocIO
{
    public class LetterFormatService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public LetterFormatService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        /// <summary>
        /// Generate a letter using Mail merge functionality of Essential DocIO
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream LetterFormat(string documentType, string button, bool isMapDataField)
        {
            string basePath = _hostingEnvironment.WebRootPath;
            string dataPath = basePath + @"/data/docio/letter-formatting.doc";
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
            WordDocument document = new WordDocument(fileStreamPath, FormatType.Doc);
            fileStreamPath.Dispose();
            fileStreamPath = null;
            //Gets the data table.
            DataTable table = GetDataTable();
            //Checks if data field mapping should be enabled
            if (isMapDataField)
            {
                //Removes paragraph that contains only empty fields.
                document.MailMerge.RemoveEmptyParagraphs = true;
                //To clear the fields with empty value
                document.MailMerge.ClearFields = true;
                //Clear the map fields
                document.MailMerge.MappedFields.Clear();
                //Update the mapping fields
                document.MailMerge.MappedFields.Add("Contact Name", "ContactName");
                document.MailMerge.MappedFields.Add("Company Name", "CompanyName");
                document.MailMerge.MappedFields.Add("CompanyAddress", "Address");
                document.MailMerge.MappedFields.Add("Residing City", "City");
                document.MailMerge.MappedFields.Add("Current Region", "Region");
                document.MailMerge.MappedFields.Add("Home Country", "Country");
            }
            //Mailmerge can be performed with the input as either DataRow, DataField, DataView, IDataReader 
            //or a set of merge field names and values. Here, one particular row is extraced from the table and used.
            DataRow dr = table.Rows[0];
            //Executes mail merge for the selected record or row.
            document.MailMerge.Execute(dr);

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
                document.Save(stream, formatType);
                document.Close();
                stream.Position = 0;
                return stream;
            }
        }
        private DataTable GetDataTable()
        {
            //Data source.
            DataSet ds = new DataSet();
            ds.ReadXml(_hostingEnvironment.WebRootPath + @"/data/docio/customers.xml");
            DataTable table = ds.Tables[0];
            return table;
        }
    }  
}