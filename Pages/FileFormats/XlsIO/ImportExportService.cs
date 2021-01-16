#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Microsoft.AspNetCore.Hosting;
using Syncfusion.XlsIO;
using Syncfusion.XlsIO.Implementation;
using System.Data;
using System.IO;

namespace blazor_samples.Data.FileFormats.XlsIO
{
    public class ImportExportService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private string importOptions = "";
        public ImportExportService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// Convert the Excel document to JSON
        /// </summary>
        /// <returns>Return the JSON document as stream</returns>
        public DataTable ImportXlsIO(string button, string option, bool isSchema)
        {
            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.
            importOptions = option;
            //Step 1 : Instantiate the spreadsheet creation engine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Step 2 : Instantiate the excel application object
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;

                //Opening the encrypted Workbook
                FileStream inputStream = new FileStream(ResolveApplicationPath("northwind-data-template.xls"), FileMode.Open, FileAccess.Read);
                IWorkbook workbook = application.Workbooks.Open(inputStream, ExcelParseOptions.Default);
                //The first worksheet object in the worksheets collection is accessed.
                IWorksheet worksheet = workbook.Worksheets[0];
                worksheet.ExportDataTableEvent += ExportDataTableEventActions;

                //Read data from spreadsheet.
                DataTable customersTable = worksheet.ExportDataTable(worksheet.UsedRange, ExcelExportDataTableOptions.ColumnNames);
                return customersTable;
            }
        }

        /// <summary>
        /// Export dataTable required actions.
        /// </summary>
        /// <param name="e"></param>
        private void ExportDataTableEventActions(ExportDataTableEventArgs e)
        {
            if (importOptions == "Skip")
            {
                if (e.ExcelValue != null && e.ExcelValue.ToString() == "Owner")
                    e.ExportDataTableAction = ExportDataTableActions.SkipRow;
            }
            if (importOptions == "Stop")
            {
                if (e.ExcelValue != null && e.ExcelValue.ToString() == "CACTU")
                    e.ExportDataTableAction = ExportDataTableActions.StopExporting;
            }
            if (importOptions == "Replace")
            {
                if (e.ExcelValue != null && e.ExcelValue.ToString() == "México D.F.")
                    e.DataTableValue = "Mexico";
            }
        }

        /// <summary>
        /// Convert the Excel document to JSON
        /// </summary>
        /// <returns>Return the JSON document as stream</returns>
        public MemoryStream ImportExportXlsIO(string button, string option, DataTable dataTable)
        {
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
                    FileStream inputStream = new FileStream(ResolveApplicationPath("northwind-data-template.xls"), FileMode.Open, FileAccess.Read);
                    IWorkbook workbook = application.Workbooks.Open(inputStream, ExcelParseOptions.Default);

                    //Save the document as a stream and retrun the stream
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
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open]
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    //Exports the DataTable to a spreadsheet.
                    string fileName = string.Empty;
                    #region Workbook Initialize
                    //Step 2 : Instantiate the excel application object.
                    IApplication application = excelEngine.Excel;
                    //Set the Workbook version as Excel 97to2003
                    if (option == "XLS")
                    {
                        application.DefaultVersion = ExcelVersion.Excel97to2003;
                        fileName = "ExportToExcel.xls";
                    }
                    //Set the Workbook version as Excel 2007
                    else
                    {
                        application.DefaultVersion = ExcelVersion.Excel2007;
                        fileName = "ExportToExcel.xlsx";
                    }
                    //A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
                    //The new workbook will have 3 worksheets
                    IWorkbook workbook = application.Workbooks.Create(1);

                    //The first worksheet object in the worksheets collection is accessed.
                    IWorksheet worksheet = workbook.Worksheets[0];
                    #endregion

                    #region Export DataTable to Excel
                    //Export DataTable.
                    if (dataTable != null)
                    {
                        worksheet.ImportDataTable(dataTable, true, 3, 1, -1, -1);
                    }
                    #endregion

                    #region Formatting the Report
                    //Formatting the Report

                    #region Applying Body Stlye
                    //Body Style
                    IStyle bodyStyle = workbook.Styles.Add("BodyStyle");
                    bodyStyle.BeginUpdate();

                    //Add custom colors to the palette.
                    workbook.SetPaletteColor(9, Syncfusion.Drawing.Color.FromArgb(239, 242, 247));
                    bodyStyle.Color = Syncfusion.Drawing.Color.FromArgb(239, 243, 247);
                    bodyStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                    bodyStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;

                    //Apply Style
                    worksheet.UsedRange.CellStyleName = "BodyStyle";
                    bodyStyle.EndUpdate();
                    #endregion

                    #region Applying Header Style
                    //Header Style
                    IStyle headerStyle = workbook.Styles.Add("HeaderStyle");
                    headerStyle.BeginUpdate();

                    //Add custom colors to the palette.
                    workbook.SetPaletteColor(8, Syncfusion.Drawing.Color.FromArgb(182, 189, 218));
                    headerStyle.Color = Syncfusion.Drawing.Color.FromArgb(182, 189, 218);
                    headerStyle.Font.Bold = true;
                    headerStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Thin;
                    headerStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Thin;
                    headerStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Thin;
                    headerStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Thin;

                    //Apply Style
                    worksheet.Range["A1:K3"].CellStyleName = "HeaderStyle";
                    headerStyle.EndUpdate();
                    #endregion

                    //Remove grid lines in the worksheet.
                    worksheet.IsGridLinesVisible = false;

                    //Autofit Rows and Columns
                    worksheet.UsedRange.AutofitRows();
                    worksheet.UsedRange.AutofitColumns();

                    //Adjust Row Height.
                    worksheet.Rows[1].RowHeight = 25;

                    //Freeze header row.
                    worksheet.Range["A4"].FreezePanes();

                    worksheet.Range["C2"].Text = "Customer Details";
                    worksheet.Range["C2:D2"].Merge();
                    worksheet.Range["C2"].CellStyle.Font.Size = 14;
                    worksheet.Range["C2"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                    #endregion

                    #region Workbook Save and Close
                    //Saving the workbook to disk.
                    //Save the document as a stream and retrun the stream
                    using (MemoryStream stream = new MemoryStream())
                    {
                        //Save the created Excel document to MemoryStream
                        workbook.SaveAs(stream);
                        return stream;
                    }
                    #endregion
                }
            }
        }

        #region HelperMethod
        private string ResolveApplicationPath(string fileName)
        {
            return _hostingEnvironment.WebRootPath + "//data//xlsio//" + fileName;
        }
        #endregion
    }
}