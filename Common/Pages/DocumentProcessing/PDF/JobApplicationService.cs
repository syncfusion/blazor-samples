#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Drawing;
using System.IO;
using System.Collections.Generic;

namespace BlazorDemos.Data.FileFormats.PDF
{
    public class JobApplicationService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public JobApplicationService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream JobApplicationPDF()
        {
			//Create a new PDF document
            PdfDocument pdfDoc = new PdfDocument();
            pdfDoc.ViewerPreferences.HideMenubar = true;
            pdfDoc.ViewerPreferences.HideWindowUI = true;
            pdfDoc.ViewerPreferences.HideToolbar = true;
            pdfDoc.ViewerPreferences.FitWindow = true;

            pdfDoc.ViewerPreferences.PageLayout = PdfPageLayout.SinglePage;
            pdfDoc.PageSettings.Orientation = PdfPageOrientation.Portrait;
            pdfDoc.PageSettings.Margins.All = 0;

            //To set coordinates to draw form fields
            RectangleF bounds = new RectangleF(180, 65, 156, 15);
            PdfUnitConverter con = new PdfUnitConverter();


            PdfImage img = new PdfBitmap(fileDataValue["careers.png"]);

            //Set the page size
            SizeF pageSize = new SizeF(500, 310);
            pdfDoc.PageSettings.Height = pageSize.Height;
            pdfDoc.PageSettings.Width = pageSize.Width;

            PdfFont pdfFont = new PdfStandardFont(PdfFontFamily.Helvetica, 12, PdfFontStyle.Bold);

            #region First Page
            pdfDoc.Pages.Add();

            PdfPage firstPage = pdfDoc.Pages[0];
            pdfDoc.Pages[0].Graphics.DrawImage(img, 0, 0, pageSize.Width, pageSize.Height);
            pdfDoc.Pages[0].Graphics.DrawString("General Information", pdfFont, new PdfSolidBrush(new PdfColor(213, 123, 19)), 25, 40);
            pdfDoc.Pages[0].Graphics.DrawString("Education Grade", pdfFont, new PdfSolidBrush(new PdfColor(213, 123, 19)), 25, 190);

            pdfFont = new PdfStandardFont(PdfFontFamily.Helvetica, 10);
            //Create fields in first page.
            pdfDoc.Pages[0].Graphics.DrawString("First Name:", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), 25, 65);

            //Create text box for firstname.
            PdfTextBoxField textBoxField1 = new PdfTextBoxField(pdfDoc.Pages[0], "FirstName");
            textBoxField1.ToolTip = "First Name";
            PdfStandardFont font1 = new PdfStandardFont(PdfFontFamily.Helvetica, 10);
            textBoxField1.Font = font1;
            textBoxField1.BorderColor = new PdfColor(Color.Gray);
            textBoxField1.BorderStyle = PdfBorderStyle.Beveled;
            textBoxField1.Bounds = bounds;
            pdfDoc.Form.Fields.Add(textBoxField1);

            pdfDoc.Pages[0].Graphics.DrawString("Last Name:", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), 25, 83);

            //Set position to draw form fields
            bounds.Y = bounds.Y + 18;
            //Create text box for lastname.
            PdfTextBoxField textBoxField2 = new PdfTextBoxField(pdfDoc.Pages[0], "LastName");
            textBoxField2.ToolTip = "Last Name";
            textBoxField2.Font = font1;
            textBoxField2.BorderColor = new PdfColor(Color.Gray);
            textBoxField2.BorderStyle = PdfBorderStyle.Beveled;
            textBoxField2.Bounds = bounds;
            pdfDoc.Form.Fields.Add(textBoxField2);

            pdfDoc.Pages[0].Graphics.DrawString("Email:", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), 25, 103);

            //Set position to draw form fields
            bounds.Y = bounds.Y + 18;

            //Create text box for Email.
            PdfTextBoxField textBoxField3 = new PdfTextBoxField(pdfDoc.Pages[0], "Email");
            textBoxField3.ToolTip = "Email id";
            textBoxField3.Font = font1;
            textBoxField3.BorderColor = new PdfColor(Color.Gray);
            textBoxField3.BorderStyle = PdfBorderStyle.Beveled;
            textBoxField3.Bounds = bounds;
            pdfDoc.Form.Fields.Add(textBoxField3);

            pdfDoc.Pages[0].Graphics.DrawString("Business Phone:", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), 25, 123);

            //Set position to draw form fields
            bounds.Y = bounds.Y + 18;

            //Create text box for Business phone.
            PdfTextBoxField textBoxField4 = new PdfTextBoxField(pdfDoc.Pages[0], "Business");
            textBoxField4.ToolTip = "Business phone";
            textBoxField4.Font = font1;
            textBoxField4.BorderColor = new PdfColor(Color.Gray);
            textBoxField4.BorderStyle = PdfBorderStyle.Beveled;
            textBoxField4.Bounds = bounds;
            pdfDoc.Form.Fields.Add(textBoxField4);

            pdfDoc.Pages[0].Graphics.DrawString("Which position are\nyou applying for?", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), 25, 143);

            //Create combo box for Position.
            #region Create ComboBox
            //Set position to draw Combo Box
            bounds.Y = bounds.Y + 24;

            PdfComboBoxField comboBox = new PdfComboBoxField(pdfDoc.Pages[0], "JobTitle");
            comboBox.Bounds = bounds;
            comboBox.BorderWidth = 1;
            comboBox.BorderColor = new PdfColor(Color.Gray);
            comboBox.Font = pdfFont;
            comboBox.ToolTip = "Job Title";


            comboBox.Items.Add(new PdfListFieldItem("Development", "accounts"));
            comboBox.Items.Add(new PdfListFieldItem("Support", "advertise"));
            comboBox.Items.Add(new PdfListFieldItem("Documentation", "agri"));

            pdfDoc.Form.Fields.Add(comboBox);
            #endregion

            pdfDoc.Pages[0].Graphics.DrawString("Highest qualification", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), 25, 217);

            //Create Checkbox box.
            #region Create CheckBox            
            pdfFont = new PdfStandardFont(PdfFontFamily.Helvetica, 8);
            //Set position to draw Checkbox
            bounds.Y = 239;
            bounds.X = 25;
            bounds.Width = 10;

            bounds.Height = 10;

            // Create a Check Box
            PdfCheckBoxField chb = new PdfCheckBoxField(pdfDoc.Pages[0], "Adegree");

            chb.Font = pdfFont;
            chb.ToolTip = "degree";
            chb.Bounds = bounds;
            chb.BorderColor = new PdfColor(Color.Gray);
            bounds.X += chb.Bounds.Height + 10;

            pdfDoc.Pages[0].Graphics.DrawString("Associate degree", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), bounds.X, bounds.Y);
            bounds.X += 90;
            pdfDoc.Form.Fields.Add(chb);
            //Create a Checkbox
            chb = new PdfCheckBoxField(pdfDoc.Pages[0], "Bdegree");
            chb.Font = pdfFont;
            chb.Bounds = bounds;
            chb.BorderColor = new PdfColor(Color.Gray);
            bounds.X += chb.Bounds.Height + 10;

            pdfDoc.Pages[0].Graphics.DrawString("Bachelor degree", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), bounds.X, bounds.Y);

            bounds.X += 90;
            pdfDoc.Form.Fields.Add(chb);
            //Create a Checkbox
            chb = new PdfCheckBoxField(pdfDoc.Pages[0], "college");

            chb.Font = pdfFont;
            chb.ToolTip = "college";
            chb.Bounds = bounds;
            chb.BorderColor = new PdfColor(Color.Gray);

            bounds.X += chb.Bounds.Height + 10;

            pdfDoc.Pages[0].Graphics.DrawString("College", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), bounds.X, bounds.Y);

            bounds.Y += 20;
            bounds.X = 25;
            pdfDoc.Form.Fields.Add(chb);
            //Create a Checkbox
            chb = new PdfCheckBoxField(pdfDoc.Pages[0], "pg");

            chb.Font = pdfFont;
            chb.Bounds = bounds;
            chb.BorderColor = new PdfColor(Color.Gray);
            bounds.X += chb.Bounds.Height + 10;

            pdfDoc.Pages[0].Graphics.DrawString("Post Graduate", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), bounds.X, bounds.Y);

            bounds.X += 90;
            pdfDoc.Form.Fields.Add(chb);
            //Create a Checkbox
            chb = new PdfCheckBoxField(pdfDoc.Pages[0], "mba");

            chb.Font = pdfFont;
            chb.Bounds = bounds;
            chb.BorderColor = new PdfColor(Color.Gray);

            bounds.X += chb.Bounds.Height + 10;

            pdfDoc.Pages[0].Graphics.DrawString("MBA", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), bounds.X, bounds.Y);

            pdfDoc.Form.Fields.Add(chb);
            #endregion

            # region Create Button
            PdfButtonField submitButton = new PdfButtonField(pdfDoc.Pages[0], "Next");
            submitButton.Bounds = new RectangleF(pdfDoc.Pages[0].GetClientSize().Width - 20, pdfDoc.Pages[0].GetClientSize().Height - 25, 20, 20);
            submitButton.Font = pdfFont;
            submitButton.ToolTip = "Next";

            PdfPage page = pdfDoc.Pages.Add();
            PdfDestination dest = new PdfDestination(page, new PointF(0, 100));
            PdfGoToAction goToAction = new PdfGoToAction(page);
            goToAction.Destination = dest;
            submitButton.Actions.GotFocus = goToAction;
            # endregion

            # endregion

            # region Second Page
            //Create second page.        
            pdfDoc.Pages.Add();

            //img = new PdfBitmap(file);
            pdfDoc.Pages[1].Graphics.DrawImage(img, new PointF(0, 0), new SizeF(pageSize.Width, pageSize.Height));

            pdfDoc.Pages[1].Graphics.DrawString("Current position", new PdfStandardFont(PdfFontFamily.TimesRoman, 10, PdfFontStyle.Bold), new PdfSolidBrush(new PdfColor(213, 123, 19)), 25, 40);

            bounds.X = 25; bounds.Y = 65;
            chb = new PdfCheckBoxField(pdfDoc.Pages[1], "Cemp");
            chb.Font = pdfFont;
            chb.Bounds = bounds;
            chb.BorderWidth = 1;
            chb.BorderColor = new PdfColor(Color.Gray);
            bounds.X += chb.Bounds.Height + 10;

            pdfDoc.Pages[1].Graphics.DrawString("I am not currently employed", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), bounds.X, bounds.Y);

            bounds.X += 90;
            pdfDoc.Form.Fields.Add(chb);

            //Add fields in second page
            pdfDoc.Pages[1].Graphics.DrawString("Job Title", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), 25, 85);

            bounds.X = 175;
            bounds.Y = 85;
            bounds.Width = 150;
            bounds.Height = 16;

            PdfTextBoxField textBoxField5 = new PdfTextBoxField(pdfDoc.Pages[1], "Jtitle");
            textBoxField5.ToolTip = "Job title";
            textBoxField5.Font = font1;
            textBoxField5.BorderColor = new PdfColor(Color.Gray);
            textBoxField5.BorderStyle = PdfBorderStyle.Beveled;
            textBoxField5.Bounds = bounds;
            pdfDoc.Form.Fields.Add(textBoxField5);

            pdfDoc.Pages[1].Graphics.DrawString("Employer:", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), 25, 103);

            //Set position to draw form fields
            bounds.Y = bounds.Y + 18;

            PdfTextBoxField textBoxField6 = new PdfTextBoxField(pdfDoc.Pages[1], "Employer");
            textBoxField6.ToolTip = "Employer";
            textBoxField6.Font = font1;
            textBoxField6.BorderColor = new PdfColor(Color.Gray);
            textBoxField6.BorderStyle = PdfBorderStyle.Beveled;
            textBoxField6.Bounds = bounds;
            pdfDoc.Form.Fields.Add(textBoxField6);

            pdfDoc.Pages[1].Graphics.DrawString("Reason for leaving:", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), 25, 123);

            //Set position to draw form fields
            bounds.Y = bounds.Y + 18;
            PdfTextBoxField textBoxField7 = new PdfTextBoxField(pdfDoc.Pages[1], "Reason");
            textBoxField7.ToolTip = "Reason for leaving";
            textBoxField7.Font = font1;
            textBoxField7.BorderColor = new PdfColor(Color.Gray);
            textBoxField7.BorderStyle = PdfBorderStyle.Beveled;
            textBoxField7.Bounds = bounds;
            pdfDoc.Form.Fields.Add(textBoxField7);

            pdfDoc.Pages[1].Graphics.DrawString("Total Annual salary:", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), 25, 143);

            //Set position to draw form fields
            bounds.Y = bounds.Y + 18;
            PdfTextBoxField textBoxField8 = new PdfTextBoxField(pdfDoc.Pages[1], "Asalary");
            textBoxField8.ToolTip = "Annual salary";
            textBoxField8.Font = font1;
            textBoxField8.BorderColor = new PdfColor(Color.Gray);
            textBoxField8.BorderStyle = PdfBorderStyle.Beveled;
            textBoxField8.Bounds = bounds;
            pdfDoc.Form.Fields.Add(textBoxField8);

            pdfDoc.Pages[1].Graphics.DrawString("Duties:", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), 25, 168);
            bounds.Y = bounds.Y + 50;
            bounds.X = 25;
            bounds.Height = bounds.Height * 4;

            PdfTextBoxField textBoxField9 = new PdfTextBoxField(pdfDoc.Pages[1], "Duties");
            //Set properties to the textbox
            textBoxField9.ToolTip = "Duties";
            textBoxField9.Font = font1;
            textBoxField9.BorderColor = new PdfColor(Color.Gray);
            textBoxField9.BorderStyle = PdfBorderStyle.Beveled;
            textBoxField9.Bounds = bounds;
            pdfDoc.Form.Fields.Add(textBoxField9);

            pdfDoc.Pages[1].Graphics.DrawString("Employment type:", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), 25, 268);

            #region Create ComboBox

            //Set position to draw Combo Box
            bounds.Y = bounds.Y + 74;
            bounds.Height = 20;
            bounds.X = 175;

            //Create a combo Box
            comboBox = new PdfComboBoxField(pdfDoc.Pages[1], "EmpType");
            comboBox.Bounds = bounds;

            comboBox.BorderColor = new PdfColor(Color.Gray);
            comboBox.Font = pdfFont;
            comboBox.ToolTip = "Employment type";

            comboBox.Items.Add(new PdfListFieldItem("Full time", "ft"));
            comboBox.Items.Add(new PdfListFieldItem("Part time", "pt"));

            pdfDoc.Form.Fields.Add(comboBox);
            #endregion

            # endregion

            # region Third Page
            //Create submit button for next page navigation.
            submitButton = new PdfButtonField(pdfDoc.Pages[1], "Apply");
            submitButton.Bounds = new RectangleF(pdfDoc.Pages[1].GetClientSize().Width - 20, pdfDoc.Pages[1].GetClientSize().Height - 25, 20, 20);
            submitButton.Font = pdfFont;
            submitButton.BorderStyle = PdfBorderStyle.Beveled;

            page = pdfDoc.Pages[2];
            dest = new PdfDestination(page, new PointF(0, 100));
            goToAction = new PdfGoToAction(page);
            goToAction.Destination = dest;
            submitButton.Actions.GotFocus = goToAction;

            
            pdfDoc.Pages[2].Graphics.DrawImage(img, 0, 0, pageSize.Width, pageSize.Height);

            pdfFont = new PdfStandardFont(PdfFontFamily.Helvetica, 12, PdfFontStyle.Bold);
            pdfDoc.Pages[2].Graphics.DrawString("Thank You", pdfFont, new PdfSolidBrush(new PdfColor(213, 123, 19)), 25, 80);

            pdfFont = new PdfStandardFont(PdfFontFamily.Helvetica, 10, PdfFontStyle.Regular);
            pdfDoc.Pages[2].Graphics.DrawString("Thanks for taking the time to complete this form.\nWe will contact you shortly.", pdfFont, new PdfSolidBrush(new PdfColor(124, 143, 166)), 25, 110);

            
            PdfButtonField submitButton1 = new PdfButtonField(pdfDoc.Pages[2], "submitButton1");
            submitButton1.Bounds = new RectangleF(25, 160, 100, 20);
            submitButton1.Font = pdfFont;
            submitButton1.Text = "Apply";
            submitButton1.BorderStyle = PdfBorderStyle.Beveled;
            submitButton1.BackColor = new PdfColor(181, 191, 203);

            PdfJavaScriptAction javaAction = new PdfJavaScriptAction("address = app.response(\"Enter an e-mail address.\",\"SEND E-MAIL\",\"\");"
                + "if (address)" +

                "{ " +
                "cmdLine = \"mailto:\" + address;" +

                "this.submitForm(cmdLine,true,false,\"Remarks\");" +

                "}");

            submitButton1.Actions.GotFocus = javaAction;
            pdfDoc.Form.Fields.Add(submitButton1);
            pdfDoc.Form.SetDefaultAppearance(false);
            #endregion

            MemoryStream stream = new MemoryStream();

            //Save the PDF document
            pdfDoc.Save(stream);

            stream.Position = 0;

            //Close the PDF document
            pdfDoc.Close(true);

            return stream;          
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
