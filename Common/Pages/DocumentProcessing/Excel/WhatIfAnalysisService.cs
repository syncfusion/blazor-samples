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

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class WhatIfAnalysisService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public WhatIfAnalysisService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        public MemoryStream WhatIfAnalysisXlsIO(string button, bool chkbox)
        {
            if (button == "Input Document")
            {
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine.
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    //Step 2 : Instantiate the excel application object.
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Excel2016;

                    //Opening an existing workbook.
                    IWorkbook workbook = application.Workbooks.Open(fileDataValue["what-if-analysis-template.xlsx"], ExcelParseOptions.Default);

                    //Save the document as a stream and return the stream.
                    using (MemoryStream stream = new MemoryStream())
                    {
                        //Save the created Excel document to MemoryStream.
                        workbook.SaveAs(stream);
                        return stream;
                    }
                }
            }
            else
            {
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    //Initialize IApplication and set the default application version.
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Xlsx;

                    IWorkbook workbook = application.Workbooks.Open(fileDataValue["what-if-analysis-template.xlsx"]);
                    IWorksheet worksheet = workbook.Worksheets[0];

                    //Initailize list objects with different values for scenarios.
                    List<object> currentChange_Values = new List<object> { 0.23, 0.8, 1.1, 0.5, 0.35, 0.2, 0.4, 0.37, 1.1, 1, 0.94, 0.75 };
                    List<object> increasedChange_Values = new List<object> { 0.45, 0.56, 0.9, 0.5, 0.58, 0.43, 0.39, 0.89, 1.45, 1.2, 0.99, 0.8 };
                    List<object> decreasedChange_Values = new List<object> { 0.3, 0.2, 0.5, 0.3, 0.5, 0.23, 0.2, 0.3, 0.8, 0.6, 0.87, 0.4 };

                    List<object> currentQuantity_Values = new List<object> { 1500, 3000, 5000, 4000, 500, 4000, 1200, 1500, 750, 750, 1200, 7900 };
                    List<object> increasedQuantity_Values = new List<object> { 1000, 5000, 4500, 3900, 10000, 8900, 8000, 3500, 15000, 5500, 4500, 4200 };
                    List<object> decreasedQuantity_Values = new List<object> { 1000, 2000, 3000, 3000, 300, 4000, 1200, 1000, 550, 650, 800, 6900 };

                    //Add scenarios in the worksheet.
                    IScenarios scenarios = worksheet.Scenarios;
                    scenarios.Add("Current % of Change", worksheet.Range["F5:F16"], currentChange_Values);
                    scenarios.Add("Increased % of Change", worksheet.Range["F5:F16"], increasedChange_Values);
                    scenarios.Add("Decreased % of Change", worksheet.Range["F5:F16"], decreasedChange_Values);

                    scenarios.Add("Current Quantity", worksheet.Range["D5:D16"], currentQuantity_Values);
                    scenarios.Add("Increased Quantity", worksheet.Range["D5:D16"], increasedQuantity_Values);
                    scenarios.Add("Decreased Quantity", worksheet.Range["D5:D16"], decreasedQuantity_Values);

                    //Create Summary.
                    if (chkbox)
                    {
                        worksheet.Scenarios.CreateSummary(worksheet.Range["L7"]);
                    }
                    MemoryStream ms = new MemoryStream();
                    workbook.SaveAs(ms);
                    excelEngine.Dispose();

                    return ms;
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