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

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class GroupShapesService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public GroupShapesService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Group or Ungroup the shapes in Excel document
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream GroupShapesXlsIO(string button, string option)
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
                    IWorkbook workbook = application.Workbooks.Open(fileDataValue["group-shapes.xlsx"], ExcelParseOptions.Default, true, "PASSWORD");

                    //Save the document as a stream and return the stream
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
                //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
                //The instantiation process consists of two steps.

                //Step 1 : Instantiate the spreadsheet creation engine
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    //Step 2 : Instantiate the excel application object
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Excel2016;

                    //Opening the encrypted Workbook                    
                    IWorkbook workbook = application.Workbooks.Open(fileDataValue["group-shapes.xlsx"], ExcelParseOptions.Default, true, "PASSWORD");

                    IWorksheet worksheet;

                    if (option == "Group")
                    {
                        //The first worksheet object in the worksheets collection is accessed
                        worksheet = workbook.Worksheets[0];
                        IShapes shapes = worksheet.Shapes;

                        IShape[] groupItems;
                        for (int i = 0; i < shapes.Count; i++)
                        {
                            if (shapes[i].Name == "Development" || shapes[i].Name == "Production" || shapes[i].Name == "Sales")
                            {
                                groupItems = new IShape[] { shapes[i], shapes[i + 1], shapes[i + 2], shapes[i + 3], shapes[i + 4], shapes[i + 5] };
                                shapes.Group(groupItems);
                                i = -1;
                            }
                        }

                        groupItems = new IShape[] { shapes[0], shapes[1], shapes[2], shapes[3], shapes[4], shapes[5], shapes[6] };

                        //Group the selected shapes
                        shapes.Group(groupItems);
                    }
                    else if (option == "Ungroup All")
                    {
                        //The second worksheet object in the worksheets collection is accessed
                        worksheet = workbook.Worksheets[1];
                        IShapes shapes = worksheet.Shapes;

                        //Ungroup group shape and its all the inner shapes
                        shapes.Ungroup(shapes[0] as IGroupShape, true);
                        worksheet.Activate();
                    }
                    else if (option == "Ungroup")
                    {
                        //The second worksheet object in the worksheets collection is accessed
                        worksheet = workbook.Worksheets[1];
                        IShapes shapes = worksheet.Shapes;

                        //Ungroup group shape
                        shapes.Ungroup(shapes[0] as IGroupShape);
                        worksheet.Activate();
                    }
                    //Save the document as a stream and return the stream
                    using (MemoryStream stream = new MemoryStream())
                    {
                        //Save the created Excel document to MemoryStream
                        workbook.SaveAs(stream);
                        return stream;
                    }
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