#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.Collections.Generic;
using Syncfusion.Drawing;
using Syncfusion.XlsIO;
using System.IO;
using BlazorDemos.Pages.GanttChart;
using System;
using Syncfusion.XlsIORenderer;
using Syncfusion.Pdf;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class CommentsService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public CommentsService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        public MemoryStream Comments(string button)
        {
            MemoryStream ms = new MemoryStream();
            if (button == "Input Document")
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
                    IWorkbook workbook = application.Workbooks.Open(fileDataValue["comments-template.xlsx"], ExcelParseOptions.Default);

                    //Save the document as a stream and return the stream
                    using (MemoryStream stream = new MemoryStream())
                    {
                        //Save the created Excel document to MemoryStream
                        workbook.SaveAs(stream);
                        return stream;
                    }
                }
            }
            else if(button == "Create Document")
            {
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    //Initialize IApplication and set the default application version
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Xlsx;

                    //Load the Excel template into IWorkbook and get the worksheet into IWorksheet
                    IWorkbook workbook = application.Workbooks.Open(fileDataValue["comments-template.xlsx"]);
                    IWorksheet worksheet = workbook.Worksheets[0];

                    //Add Comments
                    AddComments(worksheet);

                    workbook.SaveAs(ms);
                    excelEngine.Dispose();

                    return ms;
                }
            }
#if !WASM && !WEBAPP
            else if(button == "Convert To PDF")
            {
                //Initialize ExcelEngine
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    //Initialize IApplication and set the default application version
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Xlsx;

                    //Load the Excel template into IWorkbook and get the worksheet into IWorksheet
                    IWorkbook workbook = application.Workbooks.Open(fileDataValue["comments-template.xlsx"]);
                    IWorksheet worksheet = workbook.Worksheets[0];

                    //Add Comments
                    AddComments(worksheet);

                    //Set print location of comments
                    worksheet.PageSetup.PrintComments = ExcelPrintLocation.PrintSheetEnd;

                    //Initialize XlsIORenderer and convert the Excel document to PDF
                    XlsIORenderer renderer = new XlsIORenderer();
                    PdfDocument document = renderer.ConvertToPDF(workbook);

                    document.Save(ms);
                    excelEngine.Dispose();

                    return ms;

                    
                }
            }
#endif
            return ms;
        }
        private void AddComments(IWorksheet worksheet)
        {
            //Add Comments (Notes)
            IComment comment = worksheet.Range["H1"].AddComment();
            comment.Text = "This Total column comment will be printed at the end of sheet.";
            comment.IsVisible = true;

            //Add Threaded Comments
            IThreadedComment threadedComment = worksheet.Range["H16"].AddThreadedComment("What is the reason for the higher total amount of \"desk\"  in the west region?", "User1", DateTime.Now);
            threadedComment.AddReply("The unit cost of desk is higher compared to other items in the west region. As a result, the total amount is elevated.", "User2", DateTime.Now);
            threadedComment.AddReply("Additionally, Wilson sold 31 desks in the west region, which is also a contributing factor to the increased total amount.", "User3", DateTime.Now);
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