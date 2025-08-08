#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Office;
using Color = Syncfusion.Drawing.Color;

namespace Blazor_MAUI_Demos.Pages.DocumentProcessing.Word
{
    public class EditSmartArtService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public EditSmartArtService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }
        /// <summary>
        /// Edit SmartArt in the Word document
        /// </summary>
        /// <returns>Return the created Word document as stream</returns>
        public MemoryStream EditSmartArt(string button)
        {
            if (button == "View Template")
            {
                return fileDataValue["edit-smartart-input.docx"];
            }
            //Loads an existing Word document.
            WordDocument document = new WordDocument(fileDataValue["edit-smartart-input.docx"], FormatType.Docx);
            //Gets the last paragraph in the document.
            WParagraph paragraph = document.LastParagraph;
            //Retrieves the SmartArt object from the paragraph.
            WSmartArt smartArt = paragraph.ChildEntities[0] as WSmartArt;
            //Sets the background fill type of the SmartArt to solid.
            smartArt.Background.FillType = OfficeShapeFillType.Solid;
            //Sets the background color of the SmartArt.
            smartArt.Background.SolidFill.Color = Color.FromArgb(255, 242, 169, 132);
            //Gets the first node of the SmartArt.
            IOfficeSmartArtNode node = smartArt.Nodes[0];
            //Modifies the text content of the first node.
            node.TextBody.Text = "Goals";
            //Retrieves the first shape of the node.
            IOfficeSmartArtShape shape = node.Shapes[0];
            //Sets the fill color of the shape.
            shape.Fill.SolidFill.Color = Color.FromArgb(255, 160, 43, 147);
            //Sets the line format color of the shape.
            shape.LineFormat.Fill.SolidFill.Color = Color.FromArgb(255, 160, 43, 147);
            //Gets the first child node of the current node.
            IOfficeSmartArtNode childNode = node.ChildNodes[0];
            //Modifies the text content of the child node.
            childNode.TextBody.Text = "Set clear goals to the team.";
            //Sets the line format color of the first shape in the child node.
            childNode.Shapes[0].LineFormat.Fill.SolidFill.Color = Color.FromArgb(255, 160, 43, 147);

            //Retrieves the second node in the SmartArt and updates its text content.
            node = smartArt.Nodes[1];
            node.TextBody.Text = "Progress";

            //Retrieves the third node in the SmartArt and updates its text content.
            node = smartArt.Nodes[2];
            node.TextBody.Text = "Result";
            //Retrieves the first shape of the third node.
            shape = node.Shapes[0];
            //Sets the fill color of the shape.
            shape.Fill.SolidFill.Color = Color.FromArgb(255, 78, 167, 46);
            //Sets the line format color of the shape.
            shape.LineFormat.Fill.SolidFill.Color = Color.FromArgb(255, 78, 167, 46);
            //Sets the line format color of the first shape in the child node.
            node.ChildNodes[0].Shapes[0].LineFormat.Fill.SolidFill.Color = Color.FromArgb(255, 78, 167, 46);

            //Save the document as a stream and return the stream
            MemoryStream stream = new MemoryStream();
            //Save the created Word document to MemoryStream
            document.Save(stream, FormatType.Docx);
            document.Close();
            stream.Position = 0;
            return stream;
        }
        /// <summary>
        /// Dispose the Dictionary
        /// </summary>
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