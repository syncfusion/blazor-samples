#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.Collections.Generic;
using Syncfusion.XlsIO;
using System.IO;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class EncryptAndDecryptService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public EncryptAndDecryptService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Encrypt or Decrypt an Excel document
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream EncryptAndDecryptXlsIO(string button, string version)
        {
            if (button == "Encrypt Document")
            {
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    //Step 2 : Instantiate the excel application object
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Excel2016;

                    //Opening the Existing Worksheet from a Workbook
                    IWorkbook workbook = application.Workbooks.Open(fileDataValue["encrypt.xlsx"]);

                    //Encrypt the workbook with password
                    workbook.PasswordToOpen = "PASSWORD";

                    if (version == "XLS")
                        workbook.Version = ExcelVersion.Excel97to2003;

                    //Save the document as a stream and return the stream
                    using (MemoryStream stream = new MemoryStream())
                    {
                        //Save the created Excel document to MemoryStream
                        workbook.SaveAs(stream);
                        return stream;
                    }
                }
            }
            else
            {
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine
                using (ExcelEngine excelEngine = new ExcelEngine())
                {

                    //Step 2 : Instantiate the excel application object
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Excel2016;

                    //Opening the encrypted Workbook
                    IWorkbook workbook = application.Workbooks.Open(fileDataValue["encrypted-workbook.xlsx"], ExcelParseOptions.Default, true, "PASSWORD");

                    //Modify the decrypted document
                    workbook.Worksheets[0].Range["B2"].Text = "Demo for workbook decryption with Essential XlsIO";
                    workbook.Worksheets[0].Range["B5"].Text = "This document is decrypted using password 'PASSWORD'.";

                    workbook.PasswordToOpen = "";

                    if (version == "XLS")
                        workbook.Version = ExcelVersion.Excel97to2003;

                    //Save the document as a stream and return the stream
                    using (MemoryStream stream = new MemoryStream())
                    {
                        //Save the created Excel document to MemoryStream
                        workbook.SaveAs(stream);
                        return stream;
                    }
                }
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