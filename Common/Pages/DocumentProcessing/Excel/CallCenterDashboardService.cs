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
using Syncfusion.Office;
using System;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class CallCenterDashboardService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public CallCenterDashboardService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        public MemoryStream CallCenterDashboardXlsIO(string button)
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
                    IWorkbook workbook = application.Workbooks.Open(fileDataValue["call-center-template.xlsx"], ExcelParseOptions.Default);

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
                #region Workbook Initialize
                //Initialize the spreadsheet creation engine
                ExcelEngine excelEngine = new ExcelEngine();

                //Initialize the Excel application object
                IApplication application = excelEngine.Excel;

                //Set the default application version
                application.DefaultVersion = ExcelVersion.Excel2016;

                //Enable the incremental formula
                application.EnableIncrementalFormula = true;

                //Disable the chart cache serialization
                application.IsChartCacheEnabled = false;

                //Load the existing Excel document into IWorkbook
                IWorkbook workbook = application.Workbooks.Open(fileDataValue["call-center-template.xlsx"]);
                #endregion

                #region Calculation Sheet
                //Access the Calculation sheet
                IWorksheet calculation = workbook.Worksheets["Calculation"];

                //Formula calculation is enabled for the sheet
                calculation.EnableSheetCalculations();

                calculation.Range["A1"].Text = "Week";
                calculation.Range["B1"].Text = "Sorting Control";

                calculation.Range["D2"].NumberFormat = "dd-mmm-yyyy";
                calculation.Range["D2"].Formula = "=DATE(2016,1,4)+7*(A2-1)";

                calculation.Range["E2"].Formula = "=\"Week # \"&A2";

                #region Call data in the week
                calculation.Range["A4"].Text = "Total Calls";
                calculation.Range["B4"].Formula = "=COUNTIF(Data[Column1],TRUE)";

                calculation.Range["A5"].Text = "Calls Answered";
                calculation.Range["B5"].Formula = "=SUMPRODUCT((Data[Answered (Y/N)]=\"Y\")*(Data[Column1]=TRUE))";

                calculation.Range["A6"].Text = "Avg Speed of Answer";
                calculation.Range["B6"].Formula = "=SUMPRODUCT((Data[Speed of Answer]),--(Data[Column1]=TRUE))/B4";

                calculation.Range["A7"].Text = "Abandon Rate";
                calculation.Range["B7"].Formula = "=SUMPRODUCT((Data[Answered (Y/N)]=\"N\")*(Data[Column1]=TRUE))/B4";

                calculation.Range["A8"].Text = "Avg Call/Min";
                calculation.Range["B8"].Formula = "=B4/(7*9*60)";

                calculation.Range["A9"].Text = "Satisfaction Overall";
                calculation.Range["B9"].Formula = "=SUMPRODUCT((Data[Satisfaction rating]),--(Data[Column1]=TRUE))/B5";

                calculation.Range["A10"].Text = "Calls of Less than 180 Seconds";
                calculation.Range["B10"].Formula = "=SUMPRODUCT((Data[Column1]=TRUE)*(Data[Answered (Y/N)]=\"Y\")*(Data[AvgTalkDuration]<TIME(0,3,0)))";

                calculation.Range["A11"].Text = "% Calls of Less than 180 Seconds";
                calculation.Range["B11"].Formula = "=B10/B5";

                calculation.Range["A12"].Text = "Satisfaction less than equal to 3";
                calculation.Range["B12"].Formula = "=SUMPRODUCT((Data[Column1]=TRUE)*(Data[Date]<D2+6)*(Data[Satisfaction rating]<=3))";
                #endregion

                #region Call data of each agent
                calculation.Range["A15"].Text = "Agent Name";
                calculation.Range["B15"].Text = "Total Calls";
                calculation.Range["C15"].Text = "Calls Answered";
                calculation.Range["D15"].Text = "Avg Speed of Answer";
                calculation.Range["E15"].Text = "Call Resolution %";
                calculation.Range["F15"].Text = "Call Resolved";
                calculation.Range["H15"].Text = "For Sorting";
                calculation.Range["M15"].Text = "Total Calls";
                calculation.Range["N15"].Text = "Calls Answered";
                calculation.Range["O15"].Text = "Avg Speed of Answer";
                calculation.Range["P15"].Text = "Call Resolution (%)";

                calculation.Range["A16"].Text = "Diane";
                calculation.Range["A17"].Text = "Becky";
                calculation.Range["A18"].Text = "Stewart";
                calculation.Range["A19"].Text = "Greg";
                calculation.Range["A20"].Text = "Jim";
                calculation.Range["A21"].Text = "Joe";
                calculation.Range["A22"].Text = "Martha";
                calculation.Range["A23"].Text = "Dan";

                calculation.Range["B16:B23"].Formula = "=SUMPRODUCT((Data[Column1]=TRUE)*(Data[Agent]=A16))";
                calculation.Range["C16:C23"].Formula = "=SUMPRODUCT((Data[Column1]=TRUE)*(Data[Agent]=A16)*(Data[Answered (Y/N)]=\"Y\"))";
                calculation.Range["D16:D23"].Formula = "=SUMPRODUCT((Data[Column1]=TRUE)*(Data[Agent]=A16),(Data[Speed of Answer]))/C16";
                calculation.Range["E16:E23"].Formula = "=SUMPRODUCT((Data[Column1]=TRUE)*(Data[Agent]=A16)*(Data[Resolved]=\"Y\"))/B16";
                calculation.Range["F16:F23"].Formula = "=SUMPRODUCT((Data[Column1]=TRUE)*(Data[Agent]=A16)*(Data[Resolved]=\"Y\"))";

                calculation.Range["H16:H23"].Formula = "=INDEX($B$16:$E$23,ROWS($G$16:G16),$B$2)";
                calculation.Range["I16:I23"].Formula = "=H16+ROWS($H$16:H16)/1000000";
                calculation.Range["J16:J23"].Formula = "=IF($B$2=3,SMALL($I$16:$I$23,ROWS($I$16:I16)),LARGE($I$16:$I$23,ROWS($I$16:I16)))";
                calculation.Range["K16:K23"].Formula = "=MATCH(J16,$I$16:$I$23,0)";
                calculation.Range["L16:L23"].Formula = "=INDEX($A$16:$A$23,K16)";
                calculation.Range["M16:M23"].Formula = "=INDEX($A$16:$E$23,MATCH($L16,$A$16:$A$23,0),COLUMNS($K$14:L16))";
                calculation.Range["N16:N23"].Formula = "=INDEX($A$16:$E$23,MATCH($L16,$A$16:$A$23,0),COLUMNS($K$14:M16))";
                calculation.Range["O16:O23"].Formula = "=INDEX($A$16:$E$23,MATCH($L16,$A$16:$A$23,0),COLUMNS($K$14:N16))";
                calculation.Range["P16:P23"].Formula = "=INDEX($A$16:$E$23,MATCH($L16,$A$16:$A$23,0),COLUMNS($K$14:O16))";
                #endregion

                #region Overall Satisfaction chart
                calculation.Range["A25"].Text = "Satisfaction Chart";
                calculation.Range["A26"].Number = 50;
                calculation.Range["A27"].Number = 20;
                calculation.Range["A28"].Number = 30;
                calculation.Range["A29"].Number = 100;

                calculation.Range["B26"].Formula = "=B9*20-2";
                calculation.Range["B27"].Number = 2;
                calculation.Range["B28"].Formula = "=200-B26";
                #endregion

                #region call data of each agent per day
                calculation.Range["A32"].Text = "Agent Name";
                calculation.Range["B32"].Text = "Mon";
                calculation.Range["C32"].Text = "Tue";
                calculation.Range["D32"].Text = "Wed";
                calculation.Range["E32"].Text = "Thu";
                calculation.Range["F32"].Text = "Fri";
                calculation.Range["G32"].Text = "Sat";
                calculation.Range["H32"].Text = "Sun";

                calculation.Range["A33:A40"].Formula = "=L16";
                calculation.Range["B33:B40"].Formula = "=SUMPRODUCT((INT(Data[Date])=($D$2+COLUMNS($A$33:A33)-1))*(Data[Agent]=$A33)*(Data[Resolved]=\"Y\"))";
                calculation.Range["C33:C40"].Formula = "=SUMPRODUCT((INT(Data[Date])=($D$2+COLUMNS($A$33:B33)-1))*(Data[Agent]=$A33)*(Data[Resolved]=\"Y\"))";
                calculation.Range["D33:D40"].Formula = "=SUMPRODUCT((INT(Data[Date])=($D$2+COLUMNS($A$33:C33)-1))*(Data[Agent]=$A33)*(Data[Resolved]=\"Y\"))";
                calculation.Range["E33:E40"].Formula = "=SUMPRODUCT((INT(Data[Date])=($D$2+COLUMNS($A$33:D33)-1))*(Data[Agent]=$A33)*(Data[Resolved]=\"Y\"))";
                calculation.Range["F33:F40"].Formula = "=SUMPRODUCT((INT(Data[Date])=($D$2+COLUMNS($A$33:E33)-1))*(Data[Agent]=$A33)*(Data[Resolved]=\"Y\"))";
                calculation.Range["G33:G40"].Formula = "=SUMPRODUCT((INT(Data[Date])=($D$2+COLUMNS($A$33:F33)-1))*(Data[Agent]=$A33)*(Data[Resolved]=\"Y\"))";
                calculation.Range["H33:H40"].Formula = "=SUMPRODUCT((INT(Data[Date])=($D$2+COLUMNS($A$33:G33)-1))*(Data[Agent]=$A33)*(Data[Resolved]=\"Y\"))";
                #endregion

                #region Satisfaction score for each agent
                calculation.Range["A43"].Text = "Agent Name";
                calculation.Range["B43"].Text = "Satisfaction Score";
                calculation.Range["C43"].Text = "Target";

                calculation.Range["A44:A51"].Formula = "=A33";
                calculation.Range["B44:B51"].Formula = "=SUMPRODUCT((Data[Column1]=TRUE)*(Data[Agent]=$A44),(Data[Satisfaction rating]))/N16";
                calculation.Range["C44:C51"].Number = 3.5;
                calculation.Range["D44:D51"].Formula = "=IF(B44>C44,$A$52&\" \"&A44,A44)";
                calculation.Range["E44:E51"].Formula = "=B44";
                #endregion

                #region call data for each product
                calculation.Range["B54"].Text = "Total Cell";
                calculation.Range["C54"].Text = "Call Answered";
                calculation.Range["D54"].Text = "Abandoned Calls %";
                calculation.Range["E54"].Text = "SLA Limit";
                calculation.Range["F54"].Text = "SLA Breached";

                calculation.Range["A55"].Text = "Washing Machine";
                calculation.Range["A56"].Text = "Toaster";
                calculation.Range["A57"].Text = "Fridge";
                calculation.Range["A58"].Text = "Air Conditioner";
                calculation.Range["A59"].Text = "Television";

                calculation.Range["B55:B59"].Formula = "=SUMPRODUCT((Data[Column1]=TRUE)*(Data[Department]=A55))";
                calculation.Range["C55:C59"].Formula = "=SUMPRODUCT((Data[Column1]=TRUE)*(Data[Department]=A55)*(Data[Answered (Y/N)]=\"Y\"))";
                calculation.Range["D55:D59"].Formula = "=(B55-C55)/B55";
                calculation.Range["E55:E59"].NumberFormat = "0%";
                calculation.Range["E55:E59"].Value = "20%";
                calculation.Range["F55:F59"].Formula = "=IF(D55>E55,D55,NA())";
                #endregion

                //Formula calculation is disabled for the sheet
                calculation.DisableSheetCalculations();
                #endregion

                #region Dashboard Sheet
                //Create Dashboard sheet
                IWorksheet dashboard = workbook.Worksheets.Create("Dashboard");

                dashboard.Range["A1"].ColumnWidth = 0.5;
                dashboard.Range["A1"].RowHeight = 30;
                dashboard.Range["I1"].ColumnWidth = 0.5;

                #region Marcos for selecting the week and sort option
                //Cell Style for B1 to R1
                dashboard.Range["B1:R1"].CellStyle.Color = Color.FromArgb(48, 13, 225);

                //Cell Style and text in B6 - Click to Sort
                dashboard.Range["B6:B7"].Merge();
                dashboard.Range["B6"].Text = "Click to Sort";
                dashboard.Range["B6"].CellStyle.Font.RGBColor = Color.FromArgb(48, 13, 225);
                dashboard.Range["B6"].CellStyle.Font.Italic = true;
                dashboard.Range["B6"].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                dashboard.Range["B6"].VerticalAlignment = ExcelVAlign.VAlignCenter;

                //Macros for Scroll Bar and Option Buttons
                IVbaProject project = workbook.VbaProject;
                IVbaModules vbaModules = project.Modules;

                IVbaModule scrollBar = vbaModules.Add("scrollBar", VbaModuleType.StdModule);
                scrollBar.Code = "Sub Auto_Open()" +
                    "\n Dim Worksheet_Name As String" +
                    "\n Worksheet_Name = \"Dashboard\"" +
                    "\n ThisWorkbook.Worksheets(Worksheet_Name).Select" +
                    "\n ThisWorkbook.Worksheets(Worksheet_Name).ScrollBars.Add(12, 3.5, 96.5, 20).Select" +
                    "\n With Selection" +
                    "\n .Value = 0" + "\n .Min = 1" + "\n .Max = 4" + "\n .SmallChange = 1" +
                    "\n .LargeChange = 10" + "\n .LinkedCell = \"=Calculation!A2\"" + "\n .Display3DShading = True" +
                    "\n End With" +
                    "\n ThisWorkbook.Worksheets(Worksheet_Name).OptionButtons.Add(98.5, 97, 63, 17.5).Select" +
                    "\n Selection.Characters.Text = \"\"" + "\n With Selection" +
                    "\n .Value = xlOn" + "\n .LinkedCell = \"=Calculation!B2\"" + "\n .Display3DShading = False" +
                    "\n End With" +
                    "\n ThisWorkbook.Worksheets(Worksheet_Name).OptionButtons.Add(166, 97, 63, 17.5).Select" +
                    "\n Selection.Characters.Text = \"\"" + "\n With Selection" +
                    "\n .Value = xlOff" + "\n .LinkedCell = \"=Calculation!B2\"" + "\n .Display3DShading = False" +
                    "\n End With" +
                    "\n ThisWorkbook.Worksheets(Worksheet_Name).OptionButtons.Add(270, 97, 63, 17.5).Select" +
                    "\n Selection.Characters.Text = \"\"" + "\n With Selection" +
                    "\n .Value = xlOff" + "\n .LinkedCell = \"=Calculation!B2\"" + "\n .Display3DShading = False" +
                    "\n End With" +
                    "\n ThisWorkbook.Worksheets(Worksheet_Name).OptionButtons.Add(380, 97, 63, 17.5).Select" +
                    "\n Selection.Characters.Text = \"\"" + "\n With Selection" +
                    "\n .Value = xlOff" + "\n .LinkedCell = \"=Calculation!B2\"" + "\n .Display3DShading = False" +
                    "\n End With" +
                    "\n End Sub";
                #endregion

                #region Week display
                //Week Selected
                dashboard.Range["D1"].Formula = "=Calculation!E2";
                dashboard.Range["D1"].CellStyle.Font.Bold = true;
                dashboard.Range["D1"].CellStyle.Font.Italic = true;
                dashboard.Range["D1"].CellStyle.Font.Size = 16;
                dashboard.Range["D1"].CellStyle.Font.RGBColor = Color.FromArgb(225, 225, 225);
                dashboard.Range["D1"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                dashboard.Range["D1"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                #endregion

                #region Call data overview for the week
                dashboard.Range["B2:D3"].Merge();
                dashboard.Range["B4:D5"].Merge();
                dashboard.Range["E2:G3"].Merge();
                dashboard.Range["E4:G5"].Merge();
                dashboard.Range["H2:M3"].Merge();
                dashboard.Range["H4:M5"].Merge();
                dashboard.Range["N2:R3"].Merge();
                dashboard.Range["N4:R5"].Merge();

                dashboard.Range["B2:N4"].CellStyle.Font.FontName = "Verdana";
                dashboard.Range["B2:N4"].CellStyle.Font.Bold = true;
                dashboard.Range["B2:N2"].CellStyle.Font.RGBColor = Color.FromArgb(0, 0, 0);
                dashboard.Range["B4:N4"].CellStyle.Font.RGBColor = Color.FromArgb(48, 13, 225);
                dashboard.Range["B2:N2"].CellStyle.Font.Size = 12;
                dashboard.Range["B4:N4"].CellStyle.Font.Size = 18;
                dashboard.Range["B2:N4"].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                dashboard.Range["B2:N4"].VerticalAlignment = ExcelVAlign.VAlignCenter;
                dashboard.Range["B2:N4"].CellStyle.Color = Color.FromArgb(217, 217, 217);

                dashboard.Range["B2"].Text = "Total Calls";
                dashboard.Range["E2"].Text = "Avg. Answer Speed (in sec)";

                //Create a rich text string
                IRichTextString richText = dashboard.Range["E2"].RichText;

                //Create fonts for rich text formatting
                IFont font1 = workbook.CreateFont();
                font1.FontName = "Verdana";
                font1.RGBColor = Color.FromArgb(0, 0, 0);
                font1.Bold = true;
                font1.Size = 12;
                richText.SetFont(0, 17, font1);

                IFont font2 = workbook.CreateFont();
                font2.FontName = "Verdana";
                font2.RGBColor = Color.FromArgb(0, 0, 0);
                font2.Bold = false;
                font2.Size = 10;
                richText.SetFont(18, 25, font2);

                dashboard.Range["H2"].Text = "Abandon rate";
                dashboard.Range["N2"].Text = "Avg Calls/Minute";

                dashboard.Range["B4"].Formula = "=Calculation!B4";
                dashboard.Range["E4"].NumberFormat = "0.0";
                dashboard.Range["E4"].Formula = "=Calculation!B6";
                dashboard.Range["H4"].NumberFormat = "0.0%";
                dashboard.Range["H4"].Formula = "=Calculation!B7";
                dashboard.Range["N4"].NumberFormat = "0.000";
                dashboard.Range["N4"].Formula = "=Calculation!B8";

                dashboard.Range["B2:D5"].BorderAround(ExcelLineStyle.Thin, Color.Black);
                dashboard.Range["E2:G5"].BorderAround(ExcelLineStyle.Thin, Color.Black);
                dashboard.Range["H2:M5"].BorderAround(ExcelLineStyle.Thin, Color.Black);
                dashboard.Range["N2:R5"].BorderAround(ExcelLineStyle.Thin, Color.Black);
                #endregion

                #region Table to display call data of each agent
                dashboard.Range["B8"].Text = "Agent Name";
                dashboard.Range["C8"].Text = "Total Calls";
                dashboard.Range["D8"].Text = "Calls Answered";
                dashboard.Range["E8"].Text = "Avg. Speed of Answer";
                dashboard.Range["F8"].Text = "Call Resolution (%)";
                dashboard.Range["H8"].Text = "CR Trend";

                dashboard.Range["B9:B16"].Formula = "=Calculation!L16";
                dashboard.Range["C9:C16"].Formula = "=Calculation!M16";
                dashboard.Range["D9:D16"].Formula = "=Calculation!N16";
                dashboard.Range["E9:E16"].NumberFormat = "0.0";
                dashboard.Range["E9:E16"].Formula = "=Calculation!O16";
                dashboard.Range["F9:F16"].NumberFormat = "0.0%";
                dashboard.Range["F9:F16"].Formula = "=Calculation!P16";
                dashboard.Range["G9:G16"].Formula = "=F9";

                #region Conditional formats
                //Create icon sets for the data in the specified range
                IConditionalFormats conditionalFormats = dashboard.Range["G9:G16"].ConditionalFormats;
                IConditionalFormat conditionalFormat = conditionalFormats.AddCondition();
                conditionalFormat.FormatType = ExcelCFType.IconSet;
                IIconSet iconSet = conditionalFormat.IconSet;
                iconSet.IconSet = ExcelIconSetType.ThreeSigns;

                //Apply three signs icon and hide the data in the specified range
                IIconConditionValue iconValue2 = iconSet.IconCriteria[1] as IIconConditionValue;
                iconValue2.IconSet = ExcelIconSetType.ThreeSigns;
                iconValue2.Index = 1;
                iconValue2.Type = ConditionValueType.Number;
                iconValue2.Value = "0.7";
                iconValue2.Operator = ConditionalFormatOperator.GreaterThan;

                IIconConditionValue iconValue3 = iconSet.IconCriteria[2] as IIconConditionValue;
                iconValue3.IconSet = ExcelIconSetType.ThreeSigns;
                iconValue3.Index = 2;
                iconValue3.Type = ConditionValueType.Number;
                iconValue3.Value = "0.8";
                iconValue3.Operator = ConditionalFormatOperator.GreaterThanorEqualTo;

                iconSet.ShowIconOnly = true;
                #endregion

                //Auto-fit columns
                dashboard.Range["B8:G16"].AutofitColumns();
                dashboard.Range["H8"].ColumnWidth = 11;

                #region Sparklines
                //Add sparkline groups
                ISparklineGroup sparklineGroup = dashboard.SparklineGroups.Add();

                sparklineGroup.SparklineType = SparklineType.Line;
                sparklineGroup.MarkersColor = Color.FromArgb(51, 102, 153);
                sparklineGroup.LowPointColor = Color.FromArgb(192, 0, 0);
                sparklineGroup.ShowHighPoint = false;
                sparklineGroup.ShowFirstPoint = false;
                sparklineGroup.ShowLastPoint = false;
                sparklineGroup.ShowMarkers = false;

                //Add sparklines
                ISparklines sparklines = sparklineGroup.Add();
                IRange dataRange = calculation.Range["B33:H40"];
                IRange referenceRange = dashboard.Range["H9:H16"];
                sparklines.Add(dataRange, referenceRange);
                #endregion

                //Apply range formatting using cellstyle properties
                dashboard.Range["B8:E16"].BorderAround(ExcelLineStyle.Thin, Color.Black);
                dashboard.Range["B8:E16"].BorderInside(ExcelLineStyle.Thin, Color.Black);
                dashboard.Range["F8:G8"].BorderAround(ExcelLineStyle.Thin, Color.Black);
                dashboard.Range["F9:G9"].BorderAround(ExcelLineStyle.Thin, Color.Black);
                dashboard.Range["F10:G10"].BorderAround(ExcelLineStyle.Thin, Color.Black);
                dashboard.Range["F11:G11"].BorderAround(ExcelLineStyle.Thin, Color.Black);
                dashboard.Range["F12:G12"].BorderAround(ExcelLineStyle.Thin, Color.Black);
                dashboard.Range["F13:G13"].BorderAround(ExcelLineStyle.Thin, Color.Black);
                dashboard.Range["F14:G14"].BorderAround(ExcelLineStyle.Thin, Color.Black);
                dashboard.Range["F15:G15"].BorderAround(ExcelLineStyle.Thin, Color.Black);
                dashboard.Range["F16:G16"].BorderAround(ExcelLineStyle.Thin, Color.Black);
                dashboard.Range["H8:H16"].BorderAround(ExcelLineStyle.Thin, Color.Black);
                dashboard.Range["B8:H8"].CellStyle.Font.Bold = true;
                dashboard.Range["B8:H8"].CellStyle.Font.Italic = true;
                dashboard.Range["B8:H8"].CellStyle.Color = Color.FromArgb(217, 217, 217);
                #endregion

                #region Column Chart - Call Abandon Rate By Department
                //Column Chart - Chart Title
                dashboard.Range["J8:R8"].Merge();
                dashboard.Range["J8"].CellStyle.Font.Italic = true;
                dashboard.Range["J8"].CellStyle.Font.Size = 12;
                dashboard.Range["J8"].CellStyle.Font.RGBColor = Color.FromArgb(127, 127, 127);

                dashboard.Range["J8"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                dashboard.Range["J8"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                dashboard.Range["J8"].Text = "Call Abandon Rate - By Department";

                //Column Chart - Call Abandon Rate - By Department
                IChartShape columnChart = dashboard.Charts.Add();
                IChartSerie columnserieOne = columnChart.Series.Add();
                columnserieOne.Values = calculation.Range["D55:D59"];
                columnserieOne.CategoryLabels = calculation.Range["A55:A59"];
                columnserieOne.SerieFormat.CommonSerieOptions.GapWidth = 150;
                columnserieOne.DataPoints.DefaultDataPoint.DataLabels.IsValue = true;

                columnChart.PrimaryValueAxis.MajorUnit = 0.1;
                columnChart.PrimaryValueAxis.NumberFormat = "0.0%";
                columnChart.PrimaryValueAxis.HasMajorGridLines = false;

                columnChart.HasLegend = false;
                columnChart.ChartArea.Border.LineColor = Color.White;

                columnChart.Left = 1;
                columnChart.TopRow = 9;
                columnChart.LeftColumn = 10;
                columnChart.BottomRow = 17;
                columnChart.RightColumn = 19;
                (columnChart as IChart).Height = (columnChart as IChart).Height - 10;
                (columnChart as IChart).Width = (columnChart as IChart).Width - 10;

                dashboard.Range["J8:R16"].BorderAround(ExcelLineStyle.Thin, Color.Black);
                #endregion

                #region SLA Limits
                dashboard.Range["J18:R18"].Merge();
                dashboard.Range["J21:O23"].Merge();
                dashboard.Range["J26:O28"].Merge();
                dashboard.Range["P21:R23"].Merge();
                dashboard.Range["P26:R28"].Merge();

                dashboard.Range["J18"].Text = "SLA LIMITS";
                dashboard.Range["J18"].CellStyle.Font.Bold = true;
                dashboard.Range["J18"].CellStyle.Font.Size = 16;
                dashboard.Range["J18"].CellStyle.Font.FontName = "Calibri (body)";
                dashboard.Range["J18"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                dashboard.Range["J18"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                dashboard.Range["J18"].CellStyle.Font.Color = ExcelKnownColors.Black;
                dashboard.Range["J18"].CellStyle.Color = Color.FromArgb(217, 217, 217);
                dashboard.Range["J18:R18"].BorderAround(ExcelLineStyle.Thin, Color.Black);

                dashboard.Range["J21"].Text = "Calls answered in less than 180 Seconds:";
                dashboard.Range["J21"].CellStyle.Font.Bold = true;
                dashboard.Range["J21"].CellStyle.Font.Size = 14;
                dashboard.Range["J21"].CellStyle.Font.FontName = "Verdana";
                dashboard.Range["J21"].CellStyle.WrapText = true;
                dashboard.Range["J21"].CellStyle.Font.Color = ExcelKnownColors.Black;
                dashboard.Range["J21"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;

                dashboard.Range["P21"].Formula = "=Calculation!B11";
                dashboard.Range["P21"].CellStyle.Font.Bold = true;
                dashboard.Range["P21"].CellStyle.Font.Size = 28;
                dashboard.Range["P21"].CellStyle.Font.FontName = "Verdana";
                dashboard.Range["P21"].NumberFormat = "0.0%";
                dashboard.Range["P21"].CellStyle.Font.RGBColor = Color.FromArgb(84, 130, 53);
                dashboard.Range["P21"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                dashboard.Range["P21"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignLeft;

                dashboard.Range["J26"].Text = "Calls with satisfaction score less than 3:";
                dashboard.Range["J26"].CellStyle.Font.Bold = true;
                dashboard.Range["J26"].CellStyle.Font.Size = 14;
                dashboard.Range["J26"].CellStyle.Font.FontName = "Verdana";
                dashboard.Range["J26"].CellStyle.WrapText = true;
                dashboard.Range["J26"].CellStyle.Font.Color = ExcelKnownColors.Black;
                dashboard.Range["J26"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;

                dashboard.Range["P26"].Formula = "=Calculation!B12";
                dashboard.Range["P26"].CellStyle.Font.Bold = true;
                dashboard.Range["P26"].CellStyle.Font.Size = 28;
                dashboard.Range["P26"].CellStyle.Font.FontName = "Verdana";
                dashboard.Range["P26"].CellStyle.Font.RGBColor = Color.FromArgb(192, 0, 0);
                dashboard.Range["P26"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                dashboard.Range["P26"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignLeft;
                dashboard.Range["J19:R30"].BorderAround(ExcelLineStyle.Thin, Color.Black);
                #endregion

                #region Bar Chart - Satisfaction Score By Agent
                //Bar Chart - Chart Title
                dashboard.Range["E18:H18"].Merge();
                dashboard.Range["E18"].CellStyle.Font.Italic = true;
                dashboard.Range["E18"].CellStyle.Font.Underline = ExcelUnderline.Single;
                dashboard.Range["E18"].CellStyle.Font.Size = 12;
                dashboard.Range["E18"].CellStyle.Font.RGBColor = Color.FromArgb(127, 127, 127);

                dashboard.Range["E18"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                dashboard.Range["E18"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                dashboard.Range["E18"].Text = "Satisfaction Score - By Agent";

                //Bar Chart - Satisfaction Score - By Agent
                IChartShape barChart = dashboard.Charts.Add();
                IChartSerie barSerieOne = barChart.Series.Add();
                barSerieOne.SerieType = ExcelChartType.Bar_Clustered;
                barSerieOne.CategoryLabels = calculation.Range["D44:D51"];
                barSerieOne.Values = calculation.Range["E44:E51"];

                barChart.PrimaryValueAxis.MinimumValue = 0;
                barChart.PrimaryValueAxis.MaximumValue = 5;
                barChart.PrimaryValueAxis.HasMajorGridLines = false;

                barChart.HasLegend = false;
                barChart.ChartArea.Border.LineColor = Color.White;

                barChart.Top = 1;
                barChart.TopRow = 20;
                barChart.LeftColumn = 5;
                barChart.BottomRow = 31;
                barChart.RightColumn = 9;
                (barChart as IChart).Height = (barChart as IChart).Height - 10;
                (barChart as IChart).Width = (barChart as IChart).Width - 10;
                #endregion

                #region Doughnut and Pie Chart - Overall Satisfaction Score
                //Doughnut Chart - Chart Title
                dashboard.Range["B18:D18"].Merge();
                dashboard.Range["B18"].CellStyle.Font.Italic = true;
                dashboard.Range["B18"].CellStyle.Font.Underline = ExcelUnderline.Single;
                dashboard.Range["B18"].CellStyle.Font.Size = 12;
                dashboard.Range["B18"].CellStyle.Font.RGBColor = Color.FromArgb(127, 127, 127);

                dashboard.Range["B18"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                dashboard.Range["B18"].CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;
                dashboard.Range["B18"].Text = "Overall Satisfaction Score";

                //Doughnut Chart - Overall Satisfaction Score
                IChartShape doughnutChart = dashboard.Charts.Add();
                IChartSerie doughnutSerie = doughnutChart.Series.Add();
                doughnutChart.ChartType = ExcelChartType.Doughnut;
                doughnutSerie.Values = calculation.Range["A26:A29"];
                doughnutSerie.SerieFormat.CommonSerieOptions.FirstSliceAngle = 270;

                doughnutSerie.DataPoints[0].DataFormat.Fill.ForeColor = Color.FromArgb(255, 0, 0);
                doughnutSerie.DataPoints[1].DataFormat.Fill.ForeColor = Color.FromArgb(255, 192, 0);
                doughnutSerie.DataPoints[2].DataFormat.Fill.ForeColor = Color.FromArgb(0, 176, 80);
                doughnutSerie.DataPoints[3].DataFormat.Fill.ForeColorIndex = ExcelKnownColors.White;
                doughnutSerie.DataPoints[3].DataFormat.Fill.Transparency = 1.0;

                doughnutChart.HasLegend = false;
                doughnutChart.ChartArea.Border.LineColor = Color.White;
                doughnutChart.ChartArea.Fill.Transparency = 1.0;
                doughnutChart.PlotArea.Fill.Transparency = 1.0;

                doughnutChart.Left = 1;
                doughnutChart.TopRow = 20;
                doughnutChart.LeftColumn = 2;
                doughnutChart.BottomRow = 32;
                doughnutChart.RightColumn = 5;

                //Pie Chart - Overall Satisfaction Score
                IChartShape pieChart = dashboard.Charts.Add();
                IChartSerie pieSerieOne = pieChart.Series.Add();
                pieSerieOne.SerieType = ExcelChartType.Pie;
                pieSerieOne.Values = calculation.Range["B26:B28"];
                pieSerieOne.SerieFormat.CommonSerieOptions.FirstSliceAngle = 270;

                pieSerieOne.DataPoints[0].DataFormat.Fill.ForeColorIndex = ExcelKnownColors.White;
                pieSerieOne.DataPoints[0].DataFormat.Fill.Transparency = 1.0;

                pieSerieOne.DataPoints[1].DataFormat.Fill.ForeColorIndex = ExcelKnownColors.Black;
                pieSerieOne.DataPoints[1].DataFormat.LineProperties.LineColor = Color.White;
                pieSerieOne.DataPoints[1].DataFormat.LineProperties.LineWeight = ExcelChartLineWeight.Narrow;

                pieSerieOne.DataPoints[2].DataFormat.Fill.ForeColorIndex = ExcelKnownColors.White;
                pieSerieOne.DataPoints[2].DataFormat.Fill.Transparency = 1.0;

                pieChart.HasLegend = false;
                pieChart.ChartArea.Border.LineColor = Color.White;
                pieChart.ChartArea.Fill.Transparency = 1.0;
                pieChart.PlotArea.Fill.Transparency = 1.0;

                pieChart.Top = 1;
                pieChart.Left = 1;
                pieChart.TopRow = 20;
                pieChart.LeftColumn = 2;
                pieChart.BottomRow = 33;
                pieChart.RightColumn = 5;

                dashboard.Range["B30:C30"].Merge();
                dashboard.Range["B30"].Text = "Satisafction Score:";
                dashboard.Range["B30"].HorizontalAlignment = ExcelHAlign.HAlignRight;
                dashboard.Range["B30"].VerticalAlignment = ExcelVAlign.VAlignCenter;

                dashboard.Range["D30"].NumberFormat = "0.00";
                dashboard.Range["D30"].Formula = "=Calculation!B9";
                dashboard.Range["D30"].CellStyle.Font.Size = 18;
                dashboard.Range["D30"].CellStyle.Font.Bold = true;
                dashboard.Range["D30"].CellStyle.Font.RGBColor = Color.FromArgb(0, 112, 192);
                dashboard.Range["D30"].HorizontalAlignment = ExcelHAlign.HAlignCenter;

                dashboard.Range["B18:H30"].BorderAround(ExcelLineStyle.Thin, Color.Black);
                #endregion

                //Disable the gridlines
                dashboard.IsGridLinesVisible = false;

                //Set the dashboard sheet as active sheet
                dashboard.Activate();
                #endregion

                #region Save the Workbook
                //Save the workbook to disk
                MemoryStream ms = new MemoryStream();
                try
                {
                    workbook.SaveAs(ms, ExcelSaveType.SaveAsMacro);
                    workbook.Close();
                    ms.Position = 0;
                }
                catch (Exception)
                {
                }
                return ms;
                #endregion
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