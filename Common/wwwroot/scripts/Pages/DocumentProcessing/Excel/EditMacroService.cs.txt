#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using BlazorDemos.Pages.GanttChart;
using Syncfusion.Office;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.IO;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class EditMacroService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public EditMacroService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Create the Excel document with data validation
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream EditMacroXlsIO(string version)
        {
            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();
            //Step 2 : Instantiate the excel application object.
            IApplication application = excelEngine.Excel;

            // Opening workbook
            IWorkbook workbook = application.Workbooks.Open(fileDataValue["edit-macro-template.xltm"], ExcelParseOptions.Default);

            #region VbaProject
            IVbaProject vbaProject = workbook.VbaProject;
            IVbaModule vbaModule = vbaProject.Modules["Module1"];
            vbaModule.Code = vbaModule.Code.Replace("xlAreaStacked", "xlLine");
            #endregion

            MemoryStream ms = new MemoryStream();
            workbook.Version = ExcelVersion.Excel2013;
            if (version == "XLTM")
            {
                workbook.SaveAs(ms, ExcelSaveType.SaveAsMacroTemplate);
            }
            else if (version == "XLS")
            {
                workbook.Version = ExcelVersion.Excel97to2003;
                workbook.SaveAs(ms);
            }
            else
            {
                workbook.SaveAs(ms, ExcelSaveType.SaveAsMacro);
            }
            ms.Position = 0;

            return ms;
        }
    }
}