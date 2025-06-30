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
using System.Collections.Generic;
using System.IO;

namespace BlazorDemos.Data.FileFormats.XlsIO
{
    public class FormControlsService
    {
        private Color color1;
        private string[] onlinePayments;
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public FormControlsService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create the Excel document with form controls
        /// </summary>
        /// <returns>Return the created excel document as stream</returns>
        public MemoryStream FormControlsXlsIO(string version)
        {
            onlinePayments = new string[] { "Credit Card", "Net Banking" };
            //New instance of XlsIO is created.[Equivalent to launching Microsoft Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Step 1 : Instantiate the spreadsheet creation engine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Step 2 : Instantiate the excel application object
                IApplication application = excelEngine.Excel;

                //Check if user opts for XLSX
                if (version == "XLSX")
                {
                    application.DefaultVersion = ExcelVersion.Excel2016;
                    color1 = Color.FromArgb(255, 255, 230);
                }
                //Check if user opts for XLS
                else
                    color1 = Color.FromArgb(255, 255, 204);

                //A new workbook is created.[Equivalent to creating a new workbook in Microsoft Excel]
                //Workbook created with two worksheets
                IWorkbook workbook = application.Workbooks.Create(2);

                //The first worksheet object in the worksheets collection is accessed.
                //(0 based index)
                IWorksheet sheet2 = workbook.Worksheets[1];

                //Assigning the array content to cells
                //by passing row and column position 
                for (int i = 0; i < onlinePayments.Length; i++)
                    sheet2.SetValue(i + 1, 1, onlinePayments[i]);

                //The first worksheet object in the worksheets collection is accessed.
                IWorksheet sheet = workbook.Worksheets[0];

                sheet.Pictures.AddPicture(2, 3, fileDataValue["contact-sales.gif"]);

                sheet[4, 3].Text = "Phone";
                sheet[4, 3].CellStyle.Font.Bold = true;
                sheet[5, 3].Text = "Toll Free";
                sheet[5, 5].Text = "1-888-9DOTNET";
                sheet[6, 5].Text = "1-888-936-8638";
                sheet[7, 5].Text = "1-919-481-1974";
                sheet[8, 3].Text = "Fax";
                sheet[8, 5].Text = "1-919-573-0306";
                sheet[9, 3].Text = "Email";
                sheet[10, 3].Text = "Sales";

                //Creating the hyperlink in the 10th column and 
                //5th row of the sheet 
                IHyperLink link = sheet.HyperLinks.Add(sheet[10, 5]);
                link.Type = ExcelHyperLinkType.Url;
                link.Address = "mailto:sales@syncfusion.com";

                sheet[12, 3].Text = "Please fill out all required fields.";
                sheet[14, 5].Text = "First Name*";
                sheet[14, 5].CellStyle.Font.Bold = true;
                sheet[14, 8].Text = "Last Name*";
                sheet[14, 8].CellStyle.Font.Bold = true;

                //Create textbox for respective field
                //textbox to get First Name
                ITextBoxShape textBoxShape = sheet.TextBoxes.AddTextBox(15, 5, 23, 190);
                textBoxShape.Fill.FillType = ExcelFillType.SolidColor;
                textBoxShape.Fill.ForeColor = color1;

                //textbox to get Last Name
                textBoxShape = sheet.TextBoxes.AddTextBox(15, 8, 23, 195);
                textBoxShape.Fill.FillType = ExcelFillType.SolidColor;
                textBoxShape.Fill.ForeColor = color1;

                sheet[17, 3].Text = "Company*";
                textBoxShape = sheet.TextBoxes.AddTextBox(17, 5, 23, 385);
                textBoxShape.Fill.FillType = ExcelFillType.SolidColor;
                textBoxShape.Fill.ForeColor = color1;
                sheet[19, 3].Text = "Phone*";
                textBoxShape = sheet.TextBoxes.AddTextBox(19, 5, 23, 385);
                textBoxShape.Fill.FillType = ExcelFillType.SolidColor;
                textBoxShape.Fill.ForeColor = color1;
                sheet[21, 3].Text = "Email*";
                textBoxShape = sheet.TextBoxes.AddTextBox(21, 5, 23, 385);
                textBoxShape.Fill.FillType = ExcelFillType.SolidColor;
                textBoxShape.Fill.ForeColor = color1;
                sheet[23, 3].Text = "Website";
                textBoxShape = sheet.TextBoxes.AddTextBox(23, 5, 23, 385);

                ICheckBoxShape chkBoxProducts = sheet.CheckBoxes.AddCheckBox(25, 5, 20, 75);
                chkBoxProducts.Text = "";

                sheet[25, 3].Text = "Multiple products?";

                sheet[27, 3, 28, 3].Merge();
                sheet[27, 3].Text = "Product(s)*";
                sheet[27, 3].MergeArea.CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter;

                //Create a checkbox for each product
                ICheckBoxShape chkBoxProduct;
                chkBoxProduct = sheet.CheckBoxes.AddCheckBox(27, 5, 20, 75);
                chkBoxProduct.Text = "Studio";
                chkBoxProduct = sheet.CheckBoxes.AddCheckBox(27, 6, 20, 75);
                chkBoxProduct.Text = "Calculate";
                chkBoxProduct.IsSizeWithCell = true;
                chkBoxProduct = sheet.CheckBoxes.AddCheckBox(27, 7, 20, 75);
                chkBoxProduct.Text = "Chart";
                chkBoxProduct = sheet.CheckBoxes.AddCheckBox(27, 8, 20, 75);
                chkBoxProduct.Text = "Diagram";
                chkBoxProduct.IsSizeWithCell = true;
                chkBoxProduct = sheet.CheckBoxes.AddCheckBox(27, 9, 20, 75);
                chkBoxProduct.Text = "Edit";
                chkBoxProduct = sheet.CheckBoxes.AddCheckBox(27, 10, 20, 75);
                chkBoxProduct.Text = "XlsIO";
                chkBoxProduct = sheet.CheckBoxes.AddCheckBox(28, 5, 20, 75);
                chkBoxProduct.Text = "Grid";
                chkBoxProduct = sheet.CheckBoxes.AddCheckBox(28, 6, 20, 75);
                chkBoxProduct.Text = "Grouping";
                chkBoxProduct = sheet.CheckBoxes.AddCheckBox(28, 7, 20, 75);
                chkBoxProduct.Text = "HTMLUI";
                chkBoxProduct = sheet.CheckBoxes.AddCheckBox(28, 8, 20, 75);
                chkBoxProduct.Text = "PDF";
                chkBoxProduct = sheet.CheckBoxes.AddCheckBox(28, 9, 20, 75);
                chkBoxProduct.Text = "Tools";
                chkBoxProduct = sheet.CheckBoxes.AddCheckBox(28, 10, 20, 75);
                chkBoxProduct.Text = "DocIO";
                chkBoxProducts.CheckState = ExcelCheckState.Mixed;

                //generate the link to linked cell property and formula
                GenerateFormula(excelEngine);

                sheet[30, 3].Text = "Selected Products Count";

                //counts the selected product
                sheet[30, 5].Formula = "Sum(AA2:AA13)";

                //align the cell content
                sheet[30, 5].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignLeft;

                //create the textbox for additional information
                sheet[35, 3].Text = "Additional Information";
                textBoxShape = sheet.TextBoxes.AddTextBox(32, 5, 150, 385);

                if (!(version == "XLS"))
                {
                    sheet[43, 3].Text = "Online Payment";

                    //Create combobox
                    IComboBoxShape comboBox1 = sheet.ComboBoxes.AddComboBox(43, 5, 20, 100);

                    //Assign range to display in dropdown list
                    comboBox1.ListFillRange = sheet2["A1:A2"];

                    //select 1st item from the list
                    comboBox1.SelectedIndex = 1;

                    sheet[46, 3].Text = "Card Type";
                    IOptionButtonShape optionButton1 = sheet.OptionButtons.AddOptionButton(46, 5);
                    optionButton1.Text = "American Express";
                    optionButton1.CheckState = ExcelCheckState.Checked;

                    optionButton1 = sheet.OptionButtons.AddOptionButton(46, 7);
                    optionButton1.Text = "Master Card";

                    optionButton1 = sheet.OptionButtons.AddOptionButton(46, 9);
                    optionButton1.Text = "Visa";
                }

                //column alignment
                sheet.Columns[0].AutofitColumns();
                sheet.Columns[3].ColumnWidth = 12;
                sheet.Columns[4].ColumnWidth = 10;
                sheet.Columns[5].ColumnWidth = 10;
                sheet.IsGridLinesVisible = false;

                sheet.DeleteRow(40);
                sheet.DeleteRow(41);
                sheet.DeleteRow(42);
                sheet.DeleteRow(45);

                //Save the document as a stream and return the stream
                using (MemoryStream stream = new MemoryStream())
                {
                    //Save the created Excel document to MemoryStream
                    workbook.SaveAs(stream);
                    return stream;
                }
            }
        }
        #region Helper Methods
        /// <summary>
        /// Generates the formula and linkedcell 
        /// </summary>
        /// <param name="excelEngine">excel application engine</param>
        private void GenerateFormula(ExcelEngine excelEngine)
        {
            //gets the address of the 1st sheet
            IWorksheet worksheet = excelEngine.Excel.Workbooks[0].Worksheets[0];
            ICheckBoxes checkBoxes = worksheet.CheckBoxes;
            string formula;

            //loop through each checkbox and assing the link
            for (int i = 1; i < checkBoxes.Count; i++)
            {
                // range for linkedcell
                IRange range = worksheet["Z" + (i + 1)];
                checkBoxes[i].LinkedCell = range;
                //formula to check whether the checkbox checked
                formula = "IF(" + range.AddressLocal + ",1,0)";
                worksheet["AA" + (i + 1)].Formula = formula;
            }
        }
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