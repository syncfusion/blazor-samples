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
using Syncfusion.XlsIO.Implementation;
using Syncfusion.ExcelExport;
using System.Data;
using System;
using System.ComponentModel;
using Syncfusion.Blazor.Charts;


namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class ImportExportDataTableService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public static DataTable dataTable = null;
        public static List<Customer> grid = new List<Customer>();
        public ImportExportDataTableService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        public DataTable ImportFromExcel(string importOption)
        {            
            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            IWorkbook workbook = application.Workbooks.Open(fileDataValue["north-wind-data-template.xls"]);

            IWorksheet sheet = workbook.Worksheets[0];

            if (importOption == "Skip")
            {
                sheet.ExportDataTableEvent += Sheet_ExportDataTableEventSkip;
            }
            else if (importOption == "Replace")
            {
                sheet.ExportDataTableEvent += Sheet_ExportDataTableEventReplace;
            }
            else if (importOption == "Stop")
            {
                sheet.ExportDataTableEvent += Sheet_ExportDataTableEventStop;
            }
            else
            {
                sheet.ExportDataTableEvent += Sheet_ExportDataTableEventNone;
            }

            dataTable = sheet.ExportDataTable(sheet.UsedRange, ExcelExportDataTableOptions.ColumnNames);
            
            Dictionary<string, string> mappingProperties = new Dictionary<string, string>();
            mappingProperties.Add("Customer ID", "Customer.CustomerID");
            mappingProperties.Add("Company Name", "Customer.CompanyName");
            mappingProperties.Add("Contact Name", "Customer.ContactName");
            mappingProperties.Add("Contact Title", "Customer.ContactTitle");
            mappingProperties.Add("Address ", "Customer.Address");
            mappingProperties.Add("City ", "Customer.City");
            //mappingProperties.Add("Region", "Customer.Region");
            //mappingProperties.Add("PostalCode", "Customer.PostalCode");
            //mappingProperties.Add("Country", "Customer.Country");
            //mappingProperties.Add("Phone", "Customer.Phone");
            //mappingProperties.Add("Fax", "Customer.Fax");

            sheet.ImportDataTable(dataTable, true, 1, 1);
            grid = sheet.ExportData<Customer>(1, 1, dataTable.Rows.Count, 11, mappingProperties);

            //Close the workbook.
            workbook.Close();
            excelEngine.Dispose();
            ////Save the document as a stream and return the stream
            //using (MemoryStream stream = new MemoryStream())
            //{
            //    //Save the created Excel document to MemoryStream
            //    workbook.SaveAs(stream);
            //    return stream;
            //}
            return dataTable;
        }

        /// <summary>
        /// Imports the HTML table to Worksheet.
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream ImportExportDataTableServiceXlsIO(string button, string saveOption)
        {
            //Start Business Object Functions
            if (button == "Input Template")
            {
                MemoryStream ms = fileDataValue["north-wind-data-template.xls"];
                ms.Position = 0;
                return ms;
            }
            else
            {
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                IApplication application = excelEngine.Excel;

                if (saveOption == "XLS")
                    application.DefaultVersion = ExcelVersion.Excel97to2003;
                else
                    application.DefaultVersion = ExcelVersion.Excel2016;

                //Open an existing spreadsheet which will be used as a template for generating the new spreadsheet.
                //After opening, the workbook object represents the complete in-memory object model of the template spreadsheet.
                IWorkbook workbook;
                workbook = excelEngine.Excel.Workbooks.Create(1);
                //The first worksheet object in the worksheets collection is accessed.
                IWorksheet sheet = workbook.Worksheets[0];

                //Import data table to worksheet
                sheet.ImportDataTable(dataTable, true, 1, 1, true);

                sheet.UsedRange.AutofitColumns();

                try
                {
                    //Saving the workbook to disk. This spreadsheet is the result of opening and modifying
                    //an existing spreadsheet and then saving the result to a new workbook.
                    string ContentType = null;
                    string fileName = null;
                    if (saveOption == "XLSX")
                    {
                        workbook.Version = ExcelVersion.Excel2013;
                        ContentType = "Application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                        fileName = "ImportExportDataTable.xlsx";
                    }
                    else
                    {
                        ContentType = "Application/vnd.ms-excel";
                        fileName = "ImportExportDataTable.xls";
                    }
                    using (MemoryStream stream = new MemoryStream())
                    {
                        //Save the created Excel document to MemoryStream
                        workbook.SaveAs(stream);
                        stream.Position = 0;
                        return stream;
                    }
                }
                catch (Exception)
                {
                }

                using (MemoryStream stream = new MemoryStream())
                {
                    //Save the created Excel document to MemoryStream
                    workbook.SaveAs(stream);
                    stream.Position = 0;
                    return stream;
                }
            }

        }
        /// <summary>
        /// Skip Row 
        /// </summary>
        /// <param name="exportDataTableArgs">ExportDataTableEventArgs</param>
        public void Sheet_ExportDataTableEventSkip(ExportDataTableEventArgs exportDataTableArgs)
        {
            if (exportDataTableArgs.ExcelColumnIndex == 4 && exportDataTableArgs.ExcelValue.ToString() == "Owner")
                exportDataTableArgs.ExportDataTableAction = ExportDataTableActions.SkipRow;
        }
        /// <summary>
        /// Replace value 
        /// </summary>
        /// <param name="exportDataTableArgs">ExportDataTableEventArgs</param>
        private void Sheet_ExportDataTableEventReplace(ExportDataTableEventArgs exportDataTableArgs)
        {
            if (exportDataTableArgs.ExcelValue != null && exportDataTableArgs.ExcelValue.ToString() == "México D.F.")
                exportDataTableArgs.DataTableValue = "Mexico";
        }
        /// <summary>
        /// Stop Exporting  
        /// </summary>
        /// <param name="exportDataTableArgs">ExportDataTableEventArgs</param>
        private void Sheet_ExportDataTableEventStop(ExportDataTableEventArgs exportDataTableArgs)
        {
            if (exportDataTableArgs.ExcelValue != null && exportDataTableArgs.ExcelValue.ToString() == "BLONP")
                exportDataTableArgs.ExportDataTableAction = ExportDataTableActions.StopExporting;
        }
        private void Sheet_ExportDataTableEventNone(ExportDataTableEventArgs exportDataTableArgs)
        {
            exportDataTableArgs.ExportDataTableAction = ExportDataTableActions.Default;
        }
        public void Close()
        {
            foreach (KeyValuePair<string, MemoryStream> item in fileDataValue)
            {
                item.Value.Dispose();
            }
            fileDataValue.Clear();
        }
    }
    [Serializable]
    public class Customer
    {
        private string m_Id;
        [Bindable(true)]
        [DisplayNameAttribute("Customer ID")]
        public string CustomerID
        {
            get { return m_Id; }
            set { m_Id = value; }
        }

        private string m_CompanyName;
        [DisplayNameAttribute("Company Name")]
        public string CompanyName
        {
            get { return m_CompanyName; }
            set { m_CompanyName = value; }
        }

        private string m_ContactName;
        [DisplayNameAttribute("Contact Name")]
        public string ContactName
        {
            get { return m_ContactName; }
            set { m_ContactName = value; }
        }
        [DisplayNameAttribute("Contact Title")]
        public string ContactTitle
        {
            get; set;
        }

        [DisplayNameAttribute("Address")]
        public string Address
        {
            get; set;
        }

        [DisplayNameAttribute("City")]
        public string City
        {
            get; set;
        }
        //public string Region
        //{
        //    get; set;
        //}
        //public string PostalCode
        //{
        //    get; set;
        //}
        //public string Phone
        //{
        //    get; set;
        //}
        //public string Fax
        //{
        //    get; set;
        //}

        // public Customer(string brandName)
        // {
        //     m_brandName = brandName;
        // }
        public Customer()
        {

        }
    }
}

