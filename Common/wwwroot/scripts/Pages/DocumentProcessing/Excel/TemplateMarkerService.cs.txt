#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Data.FileFormats.XlsIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Syncfusion.XlsIO;
using BlazorDemos.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Security;

namespace BlazorDemos.Pages.DocumentProcessing.Excel
{
    internal class TemplateMarkerService
    {
        #region Private Members
        private DataTable northwindDt;
        Dictionary<string, MemoryStream> FileData;
        Dictionary<string, byte[]> ImgFileData;
        private DataTable numbersDt;
        private string basePath;
        IList<Customer> _customers = new List<Customer>();
        public TemplateMarkerService(Dictionary<string, MemoryStream> fileData, string path, Dictionary<string, byte[]> imgFileData)
        {
            FileData = fileData;
            basePath = path;
            ImgFileData = imgFileData;
        }
        # endregion
        public MemoryStream TemplateMarkerXlsio(string importOption, string typeOfImage, string button)
        {
            if (button == null)
                return null;

            //string basePath = NavigationManager.BaseUri + SampleService.WebAssetsPath;
            string fileName = string.Empty;
            switch (typeOfImage)
            {
                case "Image only":
                    fileName = "templatemarker-image-only.xlsx";
                    break;
                case "Image with size":
                    fileName = "templatemarker-image-with-size.xlsx";
                    break;
                case "Image with position":
                    fileName = "templatemarker-image-with-position.xlsx";
                    break;
                case "Image fit to cell":
                    fileName = "templatemarker-image-fit-to-cell.xlsx";
                    break;
                default:
                    fileName = "templatemarker-image-with-sizeposition.xlsx";
                    break;
            }

            //Save input tamplate
            if (button == "Input Template")
            {
                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;
                //FileStream inputStream = new FileStream(basePath + @"/XlsIO/" + fileName, FileMode.Open, FileAccess.Read);
                IWorkbook workbook = application.Workbooks.Open(FileData[fileName]);
                try
                {
                    workbook.Version = ExcelVersion.Xlsx;
                    MemoryStream ms = new MemoryStream();
                    workbook.SaveAs(ms);
                    ms.Position = 0;

                    return ms;
                }
                catch (Exception)
                {
                }
            }
            else
            {
                //Load Data
                DataSet customersDataSet = new DataSet();
                //FileStream xmlStream = new FileStream(basePath + @"/XlsIO/customers.xml", FileMode.Open, FileAccess.Read);
                customersDataSet.ReadXml(FileData["customers.xml"], XmlReadMode.ReadSchema);
                northwindDt = customersDataSet.Tables[0].Copy();
                //Change the column Data type from string to Byte Array
                northwindDt.Columns.Remove("Image");
                northwindDt.Columns.Add("Image", typeof(byte[]));
                int i = 0;
                //Get the path of Image File and convert the image into bytes
                foreach (DataRow row in customersDataSet.Tables[0].Rows)
                {
                    //northwindDt.Rows[i]["Image"] = System.IO.File.ReadAllBytes(basePath + "data/xlsio/Template_Marker_Images/" + row[4].ToString());
                    northwindDt.Rows[i]["Image"] = ImgFileData[row[4].ToString()];
                    i++;
                }
                customersDataSet.Dispose();
                numbersDt = GetTable();
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Xlsx;

                //Open an existing spreadsheet which will be used as a template for generating the new spreadsheet.
                //After opening, the workbook object represents the complete in-memory object model of the template spreadsheet.
                //FileStream inputStream = new FileStream(basePath + @"/XlsIO/" + fileName, FileMode.Open, FileAccess.Read);
                IWorkbook workbook = application.Workbooks.Open(FileData[fileName]);

                //The first worksheet object in the worksheets collection is accessed.
                IWorksheet sheet1 = workbook.Worksheets[0];
                IWorksheet sheet2 = workbook.Worksheets[1];

                //Create Template Marker Processor
                ITemplateMarkersProcessor marker = workbook.CreateTemplateMarkersProcessor();

                IConditionalFormats conditions = marker.CreateConditionalFormats(sheet1["C5"]);
                #region Data Bar
                //Apply markers using Formula

                IConditionalFormat condition = conditions.AddCondition();

                //Set Data bar and icon set for the same cell
                //Set the format type
                condition.FormatType = ExcelCFType.DataBar;
                IDataBar dataBar = condition.DataBar;

                //Set the constraint
                dataBar.MinPoint.Type = ConditionValueType.LowestValue;
                dataBar.MinPoint.Value = "0";
                dataBar.MaxPoint.Type = ConditionValueType.HighestValue;
                dataBar.MaxPoint.Value = "0";

                //Set color for Bar
                dataBar.BarColor = Syncfusion.Drawing.Color.FromArgb(156, 208, 243);

                //Hide the value in data bar
                dataBar.ShowValue = false;
                #endregion

                #region IconSet
                condition = conditions.AddCondition();
                condition.FormatType = ExcelCFType.IconSet;
                IIconSet iconSet = condition.IconSet;
                iconSet.IconSet = ExcelIconSetType.FourRating;
                iconSet.IconCriteria[0].Type = ConditionValueType.LowestValue;
                iconSet.IconCriteria[0].Value = "0";
                iconSet.IconCriteria[1].Type = ConditionValueType.HighestValue;
                iconSet.IconCriteria[1].Value = "0";
                iconSet.ShowIconOnly = true;
                #endregion

                conditions = marker.CreateConditionalFormats(sheet1["D5"]);

                #region Color Scale

                condition = conditions.AddCondition();

                condition.FormatType = ExcelCFType.ColorScale;
                IColorScale colorScale = condition.ColorScale;

                //Sets 3 - color scale.
                colorScale.SetConditionCount(3);

                colorScale.Criteria[0].FormatColorRGB = Syncfusion.Drawing.Color.FromArgb(230, 197, 218);
                colorScale.Criteria[0].Type = ConditionValueType.LowestValue;
                colorScale.Criteria[0].Value = "0";

                colorScale.Criteria[1].FormatColorRGB = Syncfusion.Drawing.Color.FromArgb(244, 210, 178);
                colorScale.Criteria[1].Type = ConditionValueType.Percentile;
                colorScale.Criteria[1].Value = "50";

                colorScale.Criteria[2].FormatColorRGB = Syncfusion.Drawing.Color.FromArgb(245, 247, 171);
                colorScale.Criteria[2].Type = ConditionValueType.HighestValue;
                colorScale.Criteria[2].Value = "0";
                #endregion

                conditions = marker.CreateConditionalFormats(sheet1["E5"]);

                #region Iconset
                condition = conditions.AddCondition();
                condition.FormatType = ExcelCFType.IconSet;
                iconSet = condition.IconSet;
                iconSet.IconSet = ExcelIconSetType.ThreeSymbols;
                iconSet.IconCriteria[0].Type = ConditionValueType.LowestValue;
                iconSet.IconCriteria[0].Value = "0";
                iconSet.IconCriteria[1].Type = ConditionValueType.HighestValue;
                iconSet.IconCriteria[1].Value = "0";
                iconSet.ShowIconOnly = false;

                #endregion

                if (importOption == "Data Table")
                {
                    sheet1["A5"].Value = sheet1["A5"].Value.Replace("Customers.Hyperlink.", "Customers.");
                    //Northwind customers table            
                    marker.AddVariable("Customers", northwindDt);
                }
                else
                {
                    if (this._customers.Count == 0)
                    {
                        this._customers = GetCustomerAsObjects();
                    }
                    marker.AddVariable("Customers", _customers);
                }

                marker.AddVariable("NumbersTable", numbersDt);

                //Imports data to the workbook by processing the markers in the template.
                marker.ApplyMarkers();
                try
                {
                    //Saving the workbook
                    workbook.Version = ExcelVersion.Xlsx;
                    MemoryStream ms = new MemoryStream();
                    workbook.SaveAs(ms);
                    ms.Position = 0;

                    return ms;
                }
                catch (Exception)
                {
                }

                //Close the workbook.
                workbook.Close();
                excelEngine.Dispose();
            }
            return null;
        }
        # region Helpher Methods
        /// <summary>
        /// Gets the Collection of objects from the XML data.
        /// </summary>
        /// <returns>Collection of Customer Objects</returns>
        private IList<Customer> GetCustomerAsObjects()
        {
            //string basePath = _hostingEnvironment.WebRootPath;
            DataSet customersDataSet = new DataSet();
            //FileStream xmlStream = new FileStream(basePath + @"/XlsIO/customers.xml", FileMode.Open, FileAccess.Read);
            MemoryStream xml = FileData["customers.xml"];
            xml.Position = 0;
            customersDataSet.ReadXml(xml);
            northwindDt = customersDataSet.Tables[0].Copy();
            northwindDt.Columns.Remove("Image");

            //Changing the column data type from string to Byte Array
            northwindDt.Columns.Add("Image", typeof(byte[]));

            //Get the path of Image File and convert it into bytes
            for (int j = 0; j < customersDataSet.Tables[0].Rows.Count; j++)
            {
                //northwindDt.Rows[j]["Image"] = System.IO.File.ReadAllBytes(basePath + @"/XlsIO/Template_Marker_Images/" + customersDataSet.Tables[0].Rows[j]["Image"].ToString().Trim());
                northwindDt.Rows[j]["Image"] = ImgFileData[customersDataSet.Tables[0].Rows[j]["Image"].ToString().Trim()];
            }
            IList<Customer> tmpCustomers = new List<Customer>();
            Customer customer = new Customer();
            numbersDt = GetTable();
            DataRowCollection rows = northwindDt.Rows;
            foreach (DataRow row in rows)
            {
                customer = new Customer();
                customer.SalesPerson = row[0].ToString();
                customer.SalesJanJune = Convert.ToInt32(row[1]);
                customer.SalesJulyDec = Convert.ToInt32(row[2]);
                customer.Change = Convert.ToInt32(row[3]);
                customer.Hyperlink = new Hyperlink("https://help.syncfusion.com/file-formats/xlsio/working-with-template-markers", "", "Hyperlink", "Syncfusion", ExcelHyperLinkType.Url, (byte[])row[4]);
                tmpCustomers.Add(customer);
            }
            return tmpCustomers;
        }
        private DataTable GetTable()
        {
            Random r = new Random();
            DataTable dt = new DataTable("NumbersTable");

            int nCols = 4;
            int nRows = 10;

            for (int i = 0; i < nCols; i++)
                dt.Columns.Add(new DataColumn("Column" + i.ToString()));

            for (int i = 0; i < nRows; ++i)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < nCols; j++)
                    dr[j] = r.Next(0, 10);
                dt.Rows.Add(dr);
            }
            return dt;
        }
        public void Close()
        {
            foreach (KeyValuePair<string, MemoryStream> item in FileData)
            {
                item.Value.Dispose();
            }
            FileData.Clear();
            ImgFileData.Clear();
        }

        #endregion
        #region Hyperlink Class

        public class Hyperlink : IHyperLink
        {
            public IApplication Application { get; private set; }
            public object Parent { get; private set; }
            public string Address { get; set; }
            public string Name { get; private set; }
            public IRange Range { get; private set; }
            public string ScreenTip { get; set; }
            public string SubAddress { get; set; }
            public string TextToDisplay { get; set; }
            public ExcelHyperLinkType Type { get; set; }
            public IShape Shape { get; private set; }
            public ExcelHyperlinkAttachedType AttachedType { get; private set; }
            public byte[] Image { get; set; }

            public Hyperlink(string address, string subAddress, string screenTip, string textToDisplay, ExcelHyperLinkType type, byte[] image)
            {
                Address = address;
                ScreenTip = screenTip;
                SubAddress = subAddress;
                TextToDisplay = textToDisplay;
                Type = type;
                Image = image;
            }
        }

        public class Company
        {
            public string Name { get; set; }
            public Hyperlink Link { get; set; }
        }

        #endregion
        class Customer
        {
            #region Members
            private string m_salesPerson;
            private int m_salesJanJune;
            private int m_salesJulyDec;
            private int m_change;
            private byte[] m_image;
            private Hyperlink m_hyperlink;
            #endregion

            #region Properties
            public string SalesPerson
            {
                get
                {
                    return m_salesPerson;
                }
                set
                {
                    m_salesPerson = value;
                }
            }

            public int SalesJanJune
            {
                get
                {
                    return m_salesJanJune;
                }
                set
                {
                    m_salesJanJune = value;
                }
            }
            public int SalesJulyDec
            {
                get
                {
                    return m_salesJulyDec;
                }
                set
                {
                    m_salesJulyDec = value;
                }

            }
            public int Change
            {
                get
                {
                    return m_change;
                }
                set
                {
                    m_change = value;
                }

            }

            public Hyperlink Hyperlink
            {
                get
                {
                    return m_hyperlink;
                }
                set
                {
                    m_hyperlink = value;
                }

            }

            public byte[] Image
            {
                get
                {
                    return m_image;
                }
                set
                {
                    m_image = value;
                }
            }
            #endregion

            #region Intialization
            public Customer()
            {
            }
            public Customer(string name, int juneToJuly, int julyToDec, int change, byte[] image)
            {
                this.m_salesPerson = name;
                this.m_salesJanJune = juneToJuly;
                this.m_salesJulyDec = julyToDec;
                this.m_change = change;
                this.m_image = image;
            }
            #endregion
        }
    }
}
