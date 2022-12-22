#region Copyright Syncfusion Inc. 2001 - 2022
// Copyright Syncfusion Inc. 2001 - 2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.IO;
using Syncfusion.Presentation;
using Microsoft.AspNetCore.Hosting;

namespace BlazorDemos.Data.DocumentProcessing.PowerPoint
{
    public class FindAndHighlightService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public FindAndHighlightService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        
        /// <summary>
        /// Create a Find and Hightlight Presentation document
        /// </summary>
        /// <returns>Return the created Presentation document as stream</returns>
        public MemoryStream FindAndHighlightPresentation(string button)
        {
            using (FileStream fileStreamInput = new FileStream(ResolveApplicationPath("Input Template.pptx"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                if (button == "View Input Template")
                {
                    MemoryStream ms = new MemoryStream();
                    fileStreamInput.Position = 0;
                    fileStreamInput.CopyTo(ms);
                    fileStreamInput.Dispose();
                    return ms;
                }

                //Open a existing PowerPoint presentation.
                IPresentation presentation = Syncfusion.Presentation.Presentation.Open(fileStreamInput);

                //Finds all the occurrences of a particular text
                ITextSelection[] textSelections = presentation.FindAll("product", true, true);
                foreach (ITextSelection textSelection in textSelections)
                {
                    //Gets the found text containing text parts
                    foreach (ITextPart textPart in textSelection.GetTextParts())
                    {
                        //Sets highlight color
                        textPart.Font.HighlightColor = ColorObject.Yellow;
                    }
                }

                //Save the document as a stream and return the stream
                using (MemoryStream stream = new MemoryStream())
                {
                    //Save the created PowerPoint document to MemoryStream
                    presentation.Save(stream);
                    return stream;
                }
            }
            
        }
        
        #region HelperMethod
        private string ResolveApplicationPath(string fileName)
        {
            return _hostingEnvironment.WebRootPath + "//data//powerpoint///" + fileName;
        }
        #endregion
    }
}