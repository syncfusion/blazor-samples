#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;
using System.IO;
using Syncfusion.Pdf.Xfa;
using System;

namespace BlazorDemos.Data.FileFormats.PDF
{ 
    public class XFAFormCreationService
    {
        
        public XFAFormCreationService()
        {           
        }
      
        /// <summary>
        /// Create a simple PDF document
        /// </summary>
        /// <returns>Return the created PDF document as stream</returns>
        public MemoryStream CreatePdfDocument()
        {
            PdfXfaDocument doc = new PdfXfaDocument();

            PdfXfaPage page = doc.Pages.Add();

            PdfFont font0 = new PdfStandardFont(PdfFontFamily.Helvetica, 14, PdfFontStyle.Bold);
            PdfFont font1 = new PdfStandardFont(PdfFontFamily.TimesRoman, 11, PdfFontStyle.Italic);
            PdfFont font2 = new PdfStandardFont(PdfFontFamily.TimesRoman, 9, PdfFontStyle.Italic);
            PdfFont font3 = new PdfStandardFont(PdfFontFamily.TimesRoman, 11, PdfFontStyle.Regular);

            PdfXfaForm mainForm = new PdfXfaForm(PdfXfaFlowDirection.Vertical, page.GetClientSize().Width);
            PdfXfaForm subForm1 = new PdfXfaForm(PdfXfaFlowDirection.Horizontal, page.GetClientSize().Width - 40);

            PdfXfaForm headerForm = new PdfXfaForm(page.GetClientSize().Width);
            headerForm.Width = page.GetClientSize().Width;
            headerForm.Border = new PdfXfaBorder() { Width = 0 };
            headerForm.Border.FillColor = new PdfXfaSolidBrush(new PdfColor(Color.OrangeRed));

            PdfXfaTextElement cr = new PdfXfaTextElement("CONFERENCE REGISTRATION") { HorizontalAlignment = PdfXfaHorizontalAlignment.Center, VerticalAlignment = PdfXfaVerticalAlignment.Middle, Width = page.GetClientSize().Width, Height = 60 };
            cr.Font = new PdfStandardFont(PdfFontFamily.TimesRoman, 26, PdfFontStyle.Bold);
            cr.ForeColor = new PdfColor(Color.White);
            headerForm.Fields.Add(cr);

            mainForm.Fields.Add(headerForm);

            subForm1.Margins.Left = 40;
            subForm1.Margins.Bottom = 40;

            PdfXfaTextElement name = new PdfXfaTextElement("Name", font0);
            name.Width = 500;
            name.Height = 70;
            name.VerticalAlignment = PdfXfaVerticalAlignment.Bottom;
            name.Margins.Top = 20;
            subForm1.Fields.Add(name);

            PdfXfaLine line1 = new PdfXfaLine(new PointF(0, 0), new PointF(450, 0), 1.2f);
            line1.Color = new PdfColor(Color.LightGray);
            subForm1.Fields.Add(line1);

            PdfXfaRectangleField rectangle = new PdfXfaRectangleField("rect", new SizeF(60, 1.2f)) { Visibility = PdfXfaVisibility.Invisible };
            subForm1.Fields.Add(rectangle);

            PdfXfaCaption caption1 = new PdfXfaCaption();
            caption1.VerticalAlignment = PdfXfaVerticalAlignment.Bottom;
            caption1.HorizontalAlignment = PdfXfaHorizontalAlignment.Center;
            caption1.Position = PdfXfaPosition.Bottom;
            caption1.Font = font2;
            caption1.Width = caption1.Font.MeasureString("first Name").Height + 3;

            PdfXfaComboBoxField title = new PdfXfaComboBoxField("title", new SizeF(40, 40)) { Width = 34, Height = 40 };
            title.Caption = caption1.Clone() as PdfXfaCaption;
            title.Caption.Text = "Title";
            title.Border.Style = PdfXfaBorderStyle.Lowered;
            title.HorizontalAlignment = PdfXfaHorizontalAlignment.JustifyAll;
            title.Items.Add("Mr");
            title.Items.Add("Mrs");
            title.Items.Add("Miss");
            subForm1.Fields.Add(title);
            title.Margins.Top = 7;

            PdfXfaTextBoxField fn = new PdfXfaTextBoxField("fn", new SizeF(207, 40)) { Width = 208, Height = 40 };
            fn.Caption = caption1.Clone() as PdfXfaCaption;
            fn.Caption.Text = "First Name";
            fn.Margins.Left = 5;
            fn.Margins.Top = 7;
            fn.Border.Style = PdfXfaBorderStyle.Lowered;
            subForm1.Fields.Add(fn);

            PdfXfaTextBoxField ln = new PdfXfaTextBoxField("ln", new SizeF(214, 50)) { Width = 208, Height = 40 };
            ln.Caption = caption1.Clone() as PdfXfaCaption;
            ln.Caption.Text = "Last Name";
            ln.Border.Style = PdfXfaBorderStyle.Lowered;
            ln.Margins.Left = 5;
            ln.Margins.Top = 7;
            subForm1.Fields.Add(ln);

            caption1.HorizontalAlignment = PdfXfaHorizontalAlignment.Left;
            caption1.VerticalAlignment = PdfXfaVerticalAlignment.Top;
            caption1.Position = PdfXfaPosition.Top;
            caption1.Font = font3;


            PdfXfaDateTimeField dob = new PdfXfaDateTimeField("dob", new SizeF(450, 40));
            dob.Caption = caption1.Clone() as PdfXfaCaption;
            dob.Caption.Text = "Date of Birth";
            dob.Margins.Top = 7;
            dob.HorizontalAlignment = PdfXfaHorizontalAlignment.Left;
            dob.Border.Style = PdfXfaBorderStyle.Lowered;
            subForm1.Fields.Add(dob);


            PdfXfaTextBoxField company = new PdfXfaTextBoxField("company", new SizeF(450, 40)) { Width = 450, Height = 40 };
            company.Caption = caption1.Clone() as PdfXfaCaption;
            company.Caption.Text = "Company";
            company.Margins.Top = 7;
            company.Border.Style = PdfXfaBorderStyle.Lowered;
            subForm1.Fields.Add(company);

            PdfXfaTextBoxField jt = new PdfXfaTextBoxField("jt", new SizeF(500, 50)) { Width = 450, Height = 40 };
            jt.Caption = caption1.Clone() as PdfXfaCaption;
            jt.Caption.Text = "Job Title";
            jt.Border.Style = PdfXfaBorderStyle.Lowered;
            jt.Margins.Top = 7;
            subForm1.Fields.Add(jt);

            PdfXfaTextBoxField jd = new PdfXfaTextBoxField("jd", new SizeF(500, 120)) { Width = 450 };
            jd.Caption = caption1.Clone() as PdfXfaCaption;
            jd.Caption.Text = "Job Description";
            jd.Type = PdfXfaTextBoxType.Multiline;
            jd.Border.Style = PdfXfaBorderStyle.Lowered;
            jd.Margins.Top = 7;
            subForm1.Fields.Add(jd);

            PdfXfaTextElement address = new PdfXfaTextElement("Address", font0);
            address.Width = 500;
            address.Height = 40;
            address.VerticalAlignment = PdfXfaVerticalAlignment.Bottom;
            address.Margins.Top = 10;
            subForm1.Fields.Add(address);
            subForm1.Fields.Add(line1);

            caption1.VerticalAlignment = PdfXfaVerticalAlignment.Bottom;
            caption1.Position = PdfXfaPosition.Bottom;
            caption1.Font = font2;

            PdfXfaTextBoxField st = new PdfXfaTextBoxField("st", new SizeF(450, 30)) { Width = 450, Height = 40 };
            st.Caption = caption1.Clone() as PdfXfaCaption;
            st.Caption.Text = "Street Address";
            st.Border.Style = PdfXfaBorderStyle.Lowered;
            st.Margins.Top = 7;
            subForm1.Fields.Add(st);

            PdfXfaTextBoxField addLine1 = new PdfXfaTextBoxField("ad1", new SizeF(500, 30)) { Width = 450, Height = 40 };
            addLine1.Caption = caption1.Clone() as PdfXfaCaption;
            addLine1.Caption.Text = "Address Line1";
            addLine1.Border.Style = PdfXfaBorderStyle.Lowered;
            addLine1.Margins.Top = 7;
            subForm1.Fields.Add(addLine1);

            PdfXfaTextBoxField city = new PdfXfaTextBoxField("city", new SizeF(280, 30)) { Width = 220, Height = 40 };
            city.Caption = caption1.Clone() as PdfXfaCaption;
            city.Caption.Text = "City";
            city.Border.Style = PdfXfaBorderStyle.Lowered;
            city.Margins.Top = 7;
            subForm1.Fields.Add(city);

            PdfXfaComboBoxField state = new PdfXfaComboBoxField("state", new SizeF(230, 40));
            state.Items.Add("Colorado");
            state.Items.Add("Florida");
            state.Items.Add("Georgia");
            state.Items.Add("Hawaii");
            state.Items.Add("Nevada");
            state.Items.Add("New Mexico");
            state.Items.Add("New York");
            state.Items.Add("North Carolina");
            state.Items.Add("Oregon");
            state.Items.Add("Texas");
            state.Caption = caption1.Clone() as PdfXfaCaption;
            state.Caption.Text = "State";
            state.Border.Style = PdfXfaBorderStyle.Lowered;
            state.Margins.Left = 5;
            state.Margins.Top = 7;
            subForm1.Fields.Add(state);


            PdfXfaNumericField zip = new PdfXfaNumericField("zip", new SizeF(220, 40));
            zip.Caption = caption1.Clone() as PdfXfaCaption;
            zip.CombLength = 5;
            zip.Caption.Text = "Postal / Zip Code";
            zip.PatternString = "zzzz9";
            zip.FieldType = PdfXfaNumericType.Integer;
            zip.Border.Style = PdfXfaBorderStyle.Lowered;
            zip.Margins.Top = 7;
            subForm1.Fields.Add(zip);

            PdfXfaTextBoxField country = new PdfXfaTextBoxField("country", new SizeF(500, 30)) { Width = 230, Height = 40 };
            country.Caption = caption1.Clone() as PdfXfaCaption;
            country.Caption.Text = "Country";
            country.Border.Style = PdfXfaBorderStyle.Lowered;
            country.Margins.Left = 5;
            country.Margins.Top = 7;
            subForm1.Fields.Add(country);


            PdfXfaTextBoxField email = new PdfXfaTextBoxField("em", new SizeF(500, 30)) { Width = 220, Height = 40 };
            email.Caption = caption1.Clone() as PdfXfaCaption;
            email.Caption.Text = "Email";
            email.Margins.Top = 7;
            email.Border.Style = PdfXfaBorderStyle.Lowered;
            subForm1.Fields.Add(email);

            PdfXfaNumericField phone = new PdfXfaNumericField("phone", new SizeF(230, 40));
            phone.Caption = caption1.Clone() as PdfXfaCaption;
            phone.Caption.Text = "Phone Number";
            phone.FieldType = PdfXfaNumericType.Decimal;
            phone.Margins.Left = 5;
            phone.PatternString = "zzzzzzzzz9";
            phone.Margins.Top = 7;
            phone.Border.Style = PdfXfaBorderStyle.Lowered;
            subForm1.Fields.Add(phone);



            PdfXfaTextElement specialDN = new PdfXfaTextElement("Special Dietary Needs");
            specialDN.Font = font0;
            specialDN.Margins.Top = 25;
            specialDN.Height = 42;
            specialDN.Width = 450;
            subForm1.Fields.Add(specialDN);
            subForm1.Fields.Add(line1);

            PdfXfaListBoxField sdn = new PdfXfaListBoxField("sdn", new SizeF(450, 80));
            sdn.Items.Add("Vegan");
            sdn.Items.Add("Gluten Free");
            sdn.Items.Add("Nut Free");
            sdn.Items.Add("Diary Free");
            sdn.Items.Add("Vegetables");
            sdn.SelectionMode = PdfXfaSelectionMode.Multiple;
            sdn.HorizontalAlignment = PdfXfaHorizontalAlignment.Left;
            sdn.Border.Style = PdfXfaBorderStyle.Lowered;
            sdn.Margins.Top = 7;
            subForm1.Fields.Add(sdn);


            PdfXfaTextElement specialAN = new PdfXfaTextElement("Special Assistance Needs");
            specialAN.Font = font0;
            specialAN.Margins.Top = 25;
            specialAN.Height = 42;
            specialAN.Width = 450;
            subForm1.Fields.Add(specialAN);
            subForm1.Fields.Add(line1);

            PdfXfaListBoxField san = new PdfXfaListBoxField("san", new SizeF(450, 40));
            san.Items.Add("Wheel chair");
            san.Items.Add("Ambulatory lift services");
            san.HorizontalAlignment = PdfXfaHorizontalAlignment.Left;
            san.Margins.Top = 7;
            san.Border.Style = PdfXfaBorderStyle.Lowered;
            subForm1.Fields.Add(san);

            PdfXfaTextElement pcm = new PdfXfaTextElement("Preferred Contact Method");
            pcm.Font = font0;
            pcm.Margins.Top = 25;
            pcm.Height = 42;
            pcm.Width = 500;
            subForm1.Fields.Add(pcm);
            subForm1.Fields.Add(line1);

            PdfXfaCaption caption = new PdfXfaCaption();
            caption.Font = font1;
            caption.Width = 370;
            caption.VerticalAlignment = PdfXfaVerticalAlignment.Middle;
            caption.Position = PdfXfaPosition.Right;

            PdfXfaCheckBoxField c_email = new PdfXfaCheckBoxField("email", new SizeF(400, 22));
            c_email.HorizontalAlignment = PdfXfaHorizontalAlignment.Left;
            c_email.Caption = caption.Clone() as PdfXfaCaption;
            c_email.Caption.Text = "E-Mail";
            c_email.CheckedStyle = PdfXfaCheckedStyle.Check;
            c_email.Border.Style = PdfXfaBorderStyle.Lowered;
            c_email.Margins.Top = 7;
            subForm1.Fields.Add(c_email);


            PdfXfaCheckBoxField c_phone = new PdfXfaCheckBoxField("phone", new SizeF(400, 20));
            c_phone.HorizontalAlignment = PdfXfaHorizontalAlignment.Left;
            c_phone.Caption = caption.Clone() as PdfXfaCaption;
            c_phone.Caption.Text = "Phone";
            c_phone.Margins.Top = 7;
            c_phone.Border.Style = PdfXfaBorderStyle.Lowered;
            c_phone.CheckedStyle = PdfXfaCheckedStyle.Check;
            subForm1.Fields.Add(c_phone);

            PdfXfaCheckBoxField c_mail = new PdfXfaCheckBoxField("mail", new SizeF(400, 20));
            c_mail.HorizontalAlignment = PdfXfaHorizontalAlignment.Left;
            c_mail.Caption = caption.Clone() as PdfXfaCaption;
            c_mail.Caption.Text = "Mail";
            c_mail.Border.Style = PdfXfaBorderStyle.Lowered;
            c_mail.Margins.Top = 7;
            c_mail.CheckedStyle = PdfXfaCheckedStyle.Check;
            subForm1.Fields.Add(c_mail);

            PdfXfaCheckBoxField c_nocontact = new PdfXfaCheckBoxField("nc", new SizeF(400, 20));
            c_nocontact.HorizontalAlignment = PdfXfaHorizontalAlignment.Left;
            c_nocontact.Caption = caption.Clone() as PdfXfaCaption;
            c_nocontact.Caption.Text = "No Contact";
            c_nocontact.Margins.Top = 5;
            c_nocontact.Border.Style = PdfXfaBorderStyle.Lowered;
            c_nocontact.CheckedStyle = PdfXfaCheckedStyle.Check;
            subForm1.Fields.Add(c_nocontact);

            PdfXfaTextElement MS = new PdfXfaTextElement("Membership status");
            MS.Font = font0;
            MS.Margins.Top = 25;
            MS.Height = 42;
            MS.Width = 400;
            subForm1.Fields.Add(MS);
            subForm1.Fields.Add(line1);

            PdfXfaRadioButtonGroup msg = new PdfXfaRadioButtonGroup("group1");
            msg.Margins.Top = 7;
            subForm1.Fields.Add(msg);

            PdfXfaRadioButtonField r_nonMember = new PdfXfaRadioButtonField("r1", new SizeF(120, 15));
            r_nonMember.Caption = caption.Clone() as PdfXfaCaption;
            r_nonMember.Caption.Text = "Non-Member";
            r_nonMember.VerticalAlignment = PdfXfaVerticalAlignment.Middle;
            r_nonMember.Border.Style = PdfXfaBorderStyle.Lowered;
            r_nonMember.Caption.Width = 100;
            msg.Items.Add(r_nonMember);

            PdfXfaRadioButtonField r_member = new PdfXfaRadioButtonField("r2", new SizeF(100, 15));
            r_member.Caption = caption.Clone() as PdfXfaCaption;
            r_member.Caption.Text = "Member";
            r_member.Border.Style = PdfXfaBorderStyle.Lowered;
            r_member.VerticalAlignment = PdfXfaVerticalAlignment.Middle;
            r_member.Caption.Width = 80;
            msg.Items.Add(r_member);

            PdfXfaRadioButtonField r_exhibition = new PdfXfaRadioButtonField("r3", new SizeF(100, 15));
            r_exhibition.Caption = caption.Clone() as PdfXfaCaption;
            r_exhibition.Caption.Text = "Exhibition";
            r_exhibition.VerticalAlignment = PdfXfaVerticalAlignment.Middle;
            r_exhibition.Caption.Width = 80;
            r_exhibition.Border.Style = PdfXfaBorderStyle.Lowered;
            msg.Items.Add(r_exhibition);

            PdfXfaRadioButtonField r_student = new PdfXfaRadioButtonField("r4", new SizeF(100, 15));
            r_student.Caption = caption.Clone() as PdfXfaCaption;
            r_student.Caption.Text = "Student";
            r_student.VerticalAlignment = PdfXfaVerticalAlignment.Middle;
            r_student.Border.Style = PdfXfaBorderStyle.Lowered;
            r_student.Caption.Width = 80;
            msg.Items.Add(r_student);

            mainForm.Fields.Add(subForm1);
            doc.XfaForm = mainForm;

            //Saving the XFA document to the MemoryStream
            MemoryStream ms = new MemoryStream();
            doc.Save(ms, PdfXfaType.Static);

            //If the position is not set to '0' then the PDF will be empty.
            ms.Position = 0;

            //Close the document
            doc.Close();
			
            return ms;
        }
 
    }
}
