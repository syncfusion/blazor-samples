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

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class SparklinesService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public SparklinesService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create the Excel document with sparklines
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream SparklinesXlsIO()
        {
            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Step 2 : Instantiate the excel application object
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2016;

                //A new workbook is created.[Equivalent to creating a new workbook in Microsoft Excel]
                //Open workbook with Data
                IWorkbook workbook = application.Workbooks.Open(fileDataValue["sparkline.xlsx"]);

                //The first worksheet object in the worksheets collection is accessed
                IWorksheet sheet = workbook.Worksheets[0];

                #region WholeSale Report
                //A new Sparkline group is added to the sheet sparklinegroups
                ISparklineGroup sparklineGroup = sheet.SparklineGroups.Add();

                //Set the Sparkline group type as line
                sparklineGroup.SparklineType = SparklineType.Line;

                //Set to display the empty cell as line
                sparklineGroup.DisplayEmptyCellsAs = SparklineEmptyCells.Line;

                //Sparkline group style properties
                sparklineGroup.ShowFirstPoint = true;
                sparklineGroup.FirstPointColor = Color.Green;
                sparklineGroup.ShowLastPoint = true;
                sparklineGroup.LastPointColor = Color.DarkOrange;
                sparklineGroup.ShowHighPoint = true;
                sparklineGroup.HighPointColor = Color.DarkBlue;
                sparklineGroup.ShowLowPoint = true;
                sparklineGroup.LowPointColor = Color.DarkViolet;
                sparklineGroup.ShowMarkers = true;
                sparklineGroup.MarkersColor = Color.Black;
                sparklineGroup.ShowNegativePoint = true;
                sparklineGroup.NegativePointColor = Color.Red;

                //set the line weight
                sparklineGroup.LineWeight = 0.3;

                //The sparklines are added to the sparklinegroup
                ISparklines sparklines = sparklineGroup.Add();

                //Set the Sparkline Datarange 
                IRange dataRange = sheet.Range["D6:G17"];

                //Set the Sparkline Reference range
                IRange referenceRange = sheet.Range["H6:H17"];

                //Create a sparkline with the datarange and reference range
                sparklines.Add(dataRange, referenceRange);
                #endregion

                #region Retail Trade
                //A new Sparkline group is added to the sheet sparklinegroups
                sparklineGroup = sheet.SparklineGroups.Add();

                //Set the Sparkline group type as column
                sparklineGroup.SparklineType = SparklineType.Column;

                //Set to display the empty cell as zero
                sparklineGroup.DisplayEmptyCellsAs = SparklineEmptyCells.Zero;

                //Sparkline group style properties
                sparklineGroup.ShowHighPoint = true;
                sparklineGroup.HighPointColor = Color.Green;
                sparklineGroup.ShowLowPoint = true;
                sparklineGroup.LowPointColor = Color.Red;
                sparklineGroup.ShowNegativePoint = true;
                sparklineGroup.NegativePointColor = Color.Black;

                //The sparklines are added to the sparklinegroup
                sparklines = sparklineGroup.Add();

                //Set the Sparkline Datarange 
                dataRange = sheet.Range["D21:G32"];

                //Set the Sparkline Reference range
                referenceRange = sheet.Range["H21:H32"];

                //Create a sparkline with the datarange and reference range
                sparklines.Add(dataRange, referenceRange);
                #endregion

                #region Manufacturing Trade
                //A new Sparkline group is added to the sheet sparklinegroups
                sparklineGroup = sheet.SparklineGroups.Add();

                //Set the Sparkline group type as win/loss
                sparklineGroup.SparklineType = SparklineType.ColumnStacked100;

                sparklineGroup.DisplayEmptyCellsAs = SparklineEmptyCells.Zero;

                sparklineGroup.DisplayAxis = true;
                sparklineGroup.AxisColor = Color.Black;
                sparklineGroup.ShowFirstPoint = true;
                sparklineGroup.FirstPointColor = Color.Green;
                sparklineGroup.ShowLastPoint = true;
                sparklineGroup.LastPointColor = Color.Orange;
                sparklineGroup.ShowNegativePoint = true;
                sparklineGroup.NegativePointColor = Color.Red;

                sparklines = sparklineGroup.Add();

                dataRange = sheet.Range["D36:G46"];
                referenceRange = sheet.Range["H36:H46"];

                sparklines.Add(dataRange, referenceRange);
                #endregion

                //Save the document as a stream and return the stream
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