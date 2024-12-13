#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.Data;
using System.IO;

using Syncfusion.DocIORenderer;

namespace BlazorDemos.Data.DocumentProcessing.Word
{
    public class TableofContentService
    {
        /// <summary>
        /// Generate update table of contents functionality of Essential DocIO
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream TableofContent(string documentType, string button, bool UpdateTOC)
        {            
            WordDocument doc = new WordDocument();
            doc.EnsureMinimal();

            WParagraph para = doc.LastParagraph;
            para.AppendText("Essential DocIO - Table of Contents");
            para.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            para.ApplyStyle(BuiltinStyle.Heading4);

            para = doc.LastSection.AddParagraph() as WParagraph;
            para.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            para.ApplyStyle(BuiltinStyle.Heading4);

            if (!UpdateTOC)
                para.AppendText("Select TOC and press F9 to update the Table of Contents").CharacterFormat.HighlightColor =Syncfusion.Drawing.Color.Yellow;

            para = doc.LastSection.AddParagraph() as WParagraph;

            //Insert TOC
            TableOfContent toc = para.AppendTOC(1, 3);

            para.ApplyStyle(BuiltinStyle.Heading4);

            //Apply built-in paragraph formatting
            WSection section = doc.LastSection;
            #region Default Styles
            WParagraph newPara = section.AddParagraph() as WParagraph;
            newPara = section.AddParagraph() as WParagraph;
            newPara.AppendBreak(BreakType.PageBreak);
            WTextRange text = newPara.AppendText("Document with Default styles") as WTextRange;
            newPara.ApplyStyle(BuiltinStyle.Heading1);
            newPara = section.AddParagraph() as WParagraph;
            newPara.AppendText("This is the heading1 of built in style. This sample demonstrates the TOC insertion in a word document. Note that DocIO can only insert TOC field in a word document. It can not refresh or create TOC field. MS Word refreshes the TOC field after insertion. Please update the field or press F9 key to refresh the TOC.");

            section.AddParagraph();
            newPara = section.AddParagraph() as WParagraph;
            text = newPara.AppendText("Section1") as WTextRange;
            newPara.ApplyStyle(BuiltinStyle.Heading2);
            newPara = section.AddParagraph() as WParagraph;
            newPara.AppendText("This is the heading2 of built in style. A document can contain any number of sections. Sections are used to apply same formatting for a group of paragraphs. You can insert sections by inserting section breaks.");

            section.AddParagraph();
            newPara = section.AddParagraph() as WParagraph;
            text = newPara.AppendText("Paragraph1") as WTextRange;
            newPara.ApplyStyle(BuiltinStyle.Heading3);
            newPara = section.AddParagraph() as WParagraph;
            newPara.AppendText("This is the heading3 of built in style. Each section contains any number of paragraphs. A paragraph is a set of statements that gives a meaning for the text.");

            section.AddParagraph();
            newPara = section.AddParagraph() as WParagraph;
            text = newPara.AppendText("Paragraph2") as WTextRange;
            newPara.ApplyStyle(BuiltinStyle.Heading3);
            newPara = section.AddParagraph() as WParagraph;
            newPara.AppendText("This is the heading3 of built in style. This demonstrates the paragraphs at the same level and style as that of the previous one. A paragraph can have any number formatting. This can be attained by formatting each text range in the paragraph.");

            section.AddParagraph();
            section = doc.AddSection() as WSection;
            section.BreakCode = SectionBreakCode.NewPage;
            newPara = section.AddParagraph() as WParagraph;
            text = newPara.AppendText("Section2") as WTextRange;
            newPara.ApplyStyle(BuiltinStyle.Heading2);
            newPara = section.AddParagraph() as WParagraph;
            newPara.AppendText("This is the heading2 of built in style. A document can contain any number of sections. Sections are used to apply same formatting for a group of paragraphs. You can insert sections by inserting section breaks.");

            section.AddParagraph();
            newPara = section.AddParagraph() as WParagraph;
            text = newPara.AppendText("Paragraph1") as WTextRange;
            newPara.ApplyStyle(BuiltinStyle.Heading3);
            newPara = section.AddParagraph() as WParagraph;
            newPara.AppendText("This is the heading3 of built in style. Each section contains any number of paragraphs. A paragraph is a set of statements that gives a meaning for the text.");

            section.AddParagraph();
            newPara = section.AddParagraph() as WParagraph;
            text = newPara.AppendText("Paragraph2") as WTextRange;
            newPara.ApplyStyle(BuiltinStyle.Heading3);
            newPara = section.AddParagraph() as WParagraph;
            newPara.AppendText("This is the heading3 of built in style. This demonstrates the paragraphs at the same level and style as that of the previous one. A paragraph can have any number formatting. This can be attained by formatting each text range in the paragraph.");
            #endregion

            toc.IncludePageNumbers = true;
            toc.RightAlignPageNumbers = true;
            toc.UseHyperlinks = true;
            toc.LowerHeadingLevel = 1;
            toc.UpperHeadingLevel = 3;

            toc.UseOutlineLevels = true;

            //Updates the table of contents.
            if (UpdateTOC)
                doc.UpdateTableOfContents();

            FormatType formatType = FormatType.Docx;
            //Save as .doc format
            if (documentType == "WordDoc")            
                formatType = FormatType.Doc;                
            //Save as .xml format
            else if (documentType == "WordML")
                formatType = FormatType.WordML;            
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created Word document to MemoryStream
                doc.Save(stream, formatType);
                doc.Close();
                stream.Position = 0;
                return stream;
            }
        }     
    }  
}