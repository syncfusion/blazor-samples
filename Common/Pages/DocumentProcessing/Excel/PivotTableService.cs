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

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class PivotTableService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public PivotTableService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create an Excel document with table
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream PivotTableXlsIO(string button, bool RowFilter, bool ColumnFilter, bool MultiplePageFilter, bool PageFilter, bool ApplyGrouping)
        {           
            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;
            IWorkbook workbook = null;
            application.DefaultVersion = ExcelVersion.Xlsx;

            if (button == "CustomizePivotTable")
            {
                workbook = application.Workbooks.Open(fileDataValue["pivot-table.xlsx"], ExcelParseOptions.Default);

                // The first worksheet object in the worksheets collection is accessed.
                IWorksheet sheet = workbook.Worksheets[1];
                sheet.Activate();
                //Access the collection of Pivot Table in the worksheet.
                IPivotTables pivotTables = sheet.PivotTables;

                //Access the Single pivot table from the collection.
                IPivotTable pivotTable = pivotTables[0];

                //Access collection of pivot fields from the pivot table.
                IPivotFields fields = pivotTable.Fields;

                //Access a Pivot field from the collection.
                IPivotField field = fields[2];
                //Add the field to page axis
                field.Axis = PivotAxisTypes.Page;
                fields[1].Axis = PivotAxisTypes.None;               
                fields[3].Axis = PivotAxisTypes.Row;
                fields[4].Axis = PivotAxisTypes.Column;
                IPivotField dataField = fields[5];
                //Accessing the Calculated fields from the pivot table .
                IPivotCalculatedFields calculatedfields = pivotTable.CalculatedFields;

                if (RowFilter)
                {                    
                    pivotTable.Fields[3].Items[0].Visible = false;
                }
                if (ColumnFilter)
                {
                    pivotTable.Fields[4].Items[0].Visible = false;                    
                }
                //Adding Calculatd field to the pivot table.
                //  IPivotField calculatedField = calculatedfields.Add("Percent", "Units/3000*100");
                if (PageFilter)
                {
                    //Create Pivot Filter object to apply filter to page Fields
                    IPivotFilter filterValue = pivotTable.Fields[2].PivotFilters.Add();
                    //Page Field would be filtered with value 'Binder'
                    filterValue.Value1 = "East";                   
                }
                else if (MultiplePageFilter)
                {
                    pivotTable.Fields[2].Items[0].Visible = false;
                }
                if (ApplyGrouping)
                {
                    IPivotFieldGroup group = pivotTable.Fields[0].FieldGroup;
                    group.GroupBy = PivotFieldGroupType.Years | PivotFieldGroupType.Quarters | PivotFieldGroupType.Months;
                }
                sheet.Range[1, 1, 1, 14].ColumnWidth = 11;
                sheet.SetColumnWidth(1, 15.29);
                sheet.SetColumnWidth(2, 15.29);
                
                MemoryStream ms = new MemoryStream();
                workbook.SaveAs(ms);
                ms.Position = 0;

                using (MemoryStream stream = new MemoryStream())
                {
                    //Save the created Excel document to MemoryStream
                    workbook.SaveAs(stream);
                    return stream;
                }                 
            }
            else
            {                
                workbook = application.Workbooks.Open(fileDataValue["pivot-code-date.xlsx"], ExcelParseOptions.Default);

                // The first worksheet object in the worksheets collection is accessed.
                IWorksheet sheet = workbook.Worksheets[0];

                //Access the sheet to draw pivot table.
                IWorksheet pivotSheet = workbook.Worksheets[1];
                pivotSheet.Activate();
                //Select the data to add in cache
                IPivotCache cache = workbook.PivotCaches.Add(sheet["A1:H50"]);

                //Insert the pivot table. 
                IPivotTable pivotTable = pivotSheet.PivotTables.Add("PivotTable1", pivotSheet["A1"], cache);

                if (ApplyGrouping)
                    pivotTable.Fields[0].Axis = PivotAxisTypes.Row;

                pivotTable.Fields[2].Axis = PivotAxisTypes.Row;
                pivotTable.Fields[4].Axis = PivotAxisTypes.Page;
                pivotTable.Fields[6].Axis = PivotAxisTypes.Row;
                pivotTable.Fields[3].Axis = PivotAxisTypes.Column;

                IPivotField field = pivotSheet.PivotTables[0].Fields[5];
                pivotTable.DataFields.Add(field, "Sum of Units", PivotSubtotalTypes.Sum);
                #region Apply RowField Filter
                if (RowFilter)
                {
                    pivotTable.Fields[2].Items[0].Visible = false;
                    pivotTable.Fields[2].Items[1].Visible = false;                    
                }
                #endregion

                #region Column Field Filter
                if (ColumnFilter)
                {                  
                    pivotTable.Fields[3].Items[0].Visible = false;
                    pivotTable.Fields[3].Items[1].Visible = false;                   
                }
                #endregion
                if (PageFilter)
                {
                    //'Create Pivot Filter object to apply filter to page Fields
                    IPivotFilter filterValue = pivotTable.Fields[4].PivotFilters.Add();
                    //Page Field would be filtered with value 'Binder'
                    filterValue.Value1 = "Binder";                    
                }
                else
                {
                    pivotTable.Fields[4].Items[1].Visible = false;
                    pivotTable.Fields[4].Items[2].Visible = false;
                }
                if (ApplyGrouping)
                {
                    IPivotFieldGroup group = pivotTable.Fields[0].FieldGroup;
                    group.GroupBy = PivotFieldGroupType.Years | PivotFieldGroupType.Quarters | PivotFieldGroupType.Months;
                }
                //Apply built in style.
                pivotTable.BuiltInStyle = PivotBuiltInStyles.PivotStyleMedium2;
                pivotSheet.Range[1, 1, 1, 14].ColumnWidth = 11;
                pivotSheet.SetColumnWidth(1, 15.29);
                pivotSheet.SetColumnWidth(2, 15.29);
                //Activate the pivot sheet.
                pivotSheet.Activate();

                workbook.Version = ExcelVersion.Xlsx;
                MemoryStream ms = new MemoryStream();
                workbook.SaveAs(ms);
                ms.Position = 0;

                using (MemoryStream stream = new MemoryStream())
                {
                    //Save the created Excel document to MemoryStream
                    workbook.SaveAs(stream);
                    return stream;
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