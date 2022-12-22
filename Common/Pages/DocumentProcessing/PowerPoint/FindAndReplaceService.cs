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
    public class FindAndReplaceService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public FindAndReplaceService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        
        /// <summary>
        /// Create a Find and replace Presentation document
        /// </summary>
        /// <returns>Return the created Presentation document as stream</returns>
        public MemoryStream FindAndReplacePresentation(string button, bool matchCase, bool matchWholeWord, bool firstOccurrence)
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

                 //Replaces only the first occurrence of the text
                if (firstOccurrence)
                {
                    //Finds the first occurrence of a particular text
                    ITextSelection textSelection = presentation.Find("product", matchCase, matchWholeWord);
                    //Gets the found text containing text part.
                    ITextPart textPart = textSelection.GetAsOneTextPart();
                    //Replace the text
                    textPart.Text = "Service";
                }
                else
                {
                    //Finds all the occurrences of a particular text
                    ITextSelection[] textSelections = presentation.FindAll("product", matchCase, matchWholeWord);
                    foreach (ITextSelection textSelection in textSelections)
                    {
                        //Gets the found text as single text part
                        ITextPart textPart = textSelection.GetAsOneTextPart();
                        //Replace the text
                        textPart.Text = "Service";
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