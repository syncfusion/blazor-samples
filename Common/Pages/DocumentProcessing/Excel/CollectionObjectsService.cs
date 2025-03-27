#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.XlsIO;
using System.Collections.Generic;
using System.IO;
using System;
using System.ComponentModel;
using System.Xml.Serialization;
using Syncfusion.Drawing;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class CollectionObjectsService
    {
        public static List<Brand> _sales = new List<Brand>();
        public static List<Brand> businessObjects = null;
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public CollectionObjectsService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create an Excel document with table
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream CollectionObjectsXlsIO(string button, string saveOption)
        {
            

            //Start Business Object Functions
            if (button == "Input Template")
            {
                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;

                // Opening the Existing Worksheet from a Workbook.
                IWorkbook workbook = application.Workbooks.Open(fileDataValue["export-data.xlsx"]);
                try
                {
                   
                    workbook.Version = ExcelVersion.Excel2013;
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
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                IApplication application = excelEngine.Excel;

                if (saveOption == "XLS")
                    application.DefaultVersion = ExcelVersion.Excel97to2003;
                else
                    application.DefaultVersion = ExcelVersion.Xlsx;

                //Open an existing spreadsheet which will be used as a template for generating the new spreadsheet.
                //After opening, the workbook object represents the complete in-memory object model of the template spreadsheet.
                IWorkbook workbook;
                workbook = excelEngine.Excel.Workbooks.Create(1);
                //The first worksheet object in the worksheets collection is accessed.
                IWorksheet sheet = workbook.Worksheets[0];

                //Import Bussiness Object to worksheet
                sheet.ImportData(_sales, 4, 1, true);

                #region Define Styles
                IStyle pageHeader = workbook.Styles.Add("PageHeaderStyle");
                IStyle tableHeader = workbook.Styles.Add("TableHeaderStyle");

                pageHeader.Font.FontName = "Calibri";
                pageHeader.Font.Size = 16;
                pageHeader.Font.Bold = true;
                pageHeader.Color = Color.FromArgb(0, 146, 208, 80);
                pageHeader.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                pageHeader.VerticalAlignment = ExcelVAlign.VAlignCenter;

                tableHeader.Font.Bold = true;
                tableHeader.Font.FontName = "Calibri";
                tableHeader.Color = Color.FromArgb(0, 146, 208, 80);

                #endregion

                #region Apply Styles
                // Apply style for header
                sheet["A1:C2"].Merge();
                sheet["A1"].Text = "Automobile Brands in the US";
                sheet["A1"].CellStyle = pageHeader;

                sheet["A4:C4"].CellStyle = tableHeader;

                sheet["A1:C1"].CellStyle.Font.Bold = true;
                sheet.UsedRange.AutofitColumns();

                #endregion

                try
                {
                    string ContentType = null;
                    string fileName = null;
                    if (saveOption == "XLS")
                    {
                        workbook.Version = ExcelVersion.Excel97to2003;
                        ContentType = "Application/vnd.ms-excel";
                    }
                    else
                    {
                        workbook.Version = ExcelVersion.Xlsx;
                        ContentType = "Application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    }

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

        public List<Brand> ImportExcel()
        {

                //Step 1 : Instantiate the spreadsheet creation engine.
                ExcelEngine excelEngine = new ExcelEngine();
                //Step 2 : Instantiate the excel application object.
                IApplication application = excelEngine.Excel;

                IWorkbook workbook = application.Workbooks.Open(fileDataValue["export-data.xlsx"]);
                IWorksheet sheet = workbook.Worksheets[0];
                //Export Bussiness Objects
                Dictionary<string, string> mappingProperties = new Dictionary<string, string>();
                mappingProperties.Add("Brand", "BrandName");
                mappingProperties.Add("Vehicle Type", "VehicleType.VehicleName");
                mappingProperties.Add("Model", "VehicleType.Model.ModelName");

                List<Brand> businessObjects = sheet.ExportData<Brand>(4, 1, 141, 3, mappingProperties);
                //Close the workbook.
                workbook.Close();
                excelEngine.Dispose();
                int temp = 1;
                foreach (Brand brand in businessObjects)
                {
                    brand.ID = temp;
                    temp++;
                }
                _sales = businessObjects;
                return businessObjects;
                
        }
        public List<Brand> Update(CRUDModel<Brand> myObject)
        {
            List<Brand> salesList = _sales;
            foreach (Brand brand in salesList)
            {
                if (brand.ID == myObject.value.ID)
                {
                    brand.BrandName = myObject.value.BrandName;
                    brand.VehicleType.VehicleName = myObject.value.VehicleType.VehicleName;
                    brand.VehicleType.Model.ModelName = myObject.value.VehicleType.Model.ModelName;
                }
            }
            return salesList;
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

    #region Helper Class
    public class Data
    {

        public bool requiresCounts { get; set; }
        public int skip { get; set; }
        public int take { get; set; }
    }
    public class CRUDModel<T> where T : class
    {
        public string action { get; set; }

        public string table { get; set; }

        public string keyColumn { get; set; }

        public object key { get; set; }

        public T value { get; set; }

        public List<T> added { get; set; }

        public List<T> changed { get; set; }

        public List<T> deleted { get; set; }

        public IDictionary<string, object> @params { get; set; }
    }
    [Serializable]
    public class Brand
    {
        private int m_Id;
        [Bindable(false)]
        public int ID
        {
            get { return m_Id; }
            set { m_Id = value; }
        }

        private string m_brandName;
        [DisplayNameAttribute("Brand")]
        public string BrandName
        {
            get { return m_brandName; }
            set { m_brandName = value; }
        }
        private VehicleType m_vehicleType;
        public VehicleType VehicleType
        {
            get { return m_vehicleType; }
            set { m_vehicleType = value; }
        }
        [Bindable(false)]
        public string VehicleName
        {
            get { return VehicleType?.VehicleName; }
        }
        [Bindable(false)]
        public string ModelName
        {
            get { return VehicleType?.Model?.ModelName; }
        }

        public Brand(string brandName)
        {
            m_brandName = brandName;
        }
        public Brand()
        {

        }
    }

    //[DisplayNameAttribute("Vehicle Type")]
    public class VehicleType
    {
        private string m_vehicleName;

        [DisplayNameAttribute("Vehicle Type")]
        public string VehicleName
        {
            get { return m_vehicleName; }
            set { m_vehicleName = value; }
        }

        private Model m_model;       
        public Model Model
        {
            get { return m_model; }
            set { m_model = value; }
        }

        public VehicleType(string vehicle)
        {
            m_vehicleName = vehicle;
        }
        public VehicleType()
        {

        }
    }
    //[DisplayNameAttribute("Model")]
    public class Model
    {
        private string m_modelName;
        [DisplayNameAttribute("Model")]
        public string ModelName
        {
            get { return m_modelName; }
            set { m_modelName = value; }
        }

        public Model(string name)
        {
            m_modelName = name;
        }
        public Model()
        {

        }
    }
    #endregion
}
