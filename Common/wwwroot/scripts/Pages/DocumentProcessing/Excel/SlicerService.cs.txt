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
    public class SlicerService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public SlicerService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Table Slicer
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream SlicerXlsIO(string button, string id1, string id2)
        {
            if (button == "Create Document")
            {
                //Instantiate the spreadsheet creation engine
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    //Instantiate the excel application object
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Xlsx;
                    IWorkbook workbook = application.Workbooks.Open(fileDataValue["table-slicer.xlsx"], ExcelParseOptions.Default);

                    IWorksheet sheet = workbook.Worksheets[0];
                    IListObject table = sheet.ListObjects[0];

                    if (id1 == null)
                        id1 = "Requester";
                    if (id2 == null)
                        id2 = "Status";

                    //Get the column id from the given column name
                    int colId1 = GetColumnId(id1, table);
                    int colId2 = GetColumnId(id2, table);

                    // Add slicer for the table
                    sheet.Slicers.Add(table, colId1, 11, 2);
                    sheet.Slicers.Add(table, colId2, 11, 4);

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
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    //Step 2 : Instantiate the excel application object
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Excel2016;

                    IWorkbook workbook = application.Workbooks.Open(fileDataValue["table-slicer.xlsx"], ExcelParseOptions.Default);

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
        private int GetColumnId(string columnName, IListObject table)
        {
            int colId = 0;
            for (int i = 0; i < table.Columns.Count; i++)
            {
                if (table.Columns[i].Name == columnName)
                {
                    colId = i + 1;
                    break;
                }
            }
            return colId;
        }

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
