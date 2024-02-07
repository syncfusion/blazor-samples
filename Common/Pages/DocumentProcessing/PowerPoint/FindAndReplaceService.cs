#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.IO;
using Syncfusion.Presentation;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BlazorDemos.Data.DocumentProcessing.PowerPoint
{
    public class FindAndReplaceService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public FindAndReplaceService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a Find and replace Presentation document
        /// </summary>
        /// <returns>Return the created Presentation document as stream</returns>
        public MemoryStream FindAndReplacePresentation(string button, bool replaceUsingText, bool matchCase, bool matchWholeWord, bool firstOccurrence)
        {
            if (button == "View Input Template")
            {
                return fileDataValue["input-template.pptx"];
            }

            //Open a existing PowerPoint presentation.
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(fileDataValue["input-template.pptx"]);

            //Replaces only the first occurrence of the text
            if (firstOccurrence)
            {
                ITextSelection textSelection = null;
                if (replaceUsingText)
                {
                    //Finds the first occurrence of a particular text
                    textSelection = presentation.Find("{product}", matchCase, matchWholeWord);
                }
                else
                {
                    //Finds the first occurrence of a pattern
                    textSelection = presentation.Find(new Regex("{[A-Za-z]+}"));
                }
                if (textSelection != null)
                {
                    //Gets the found text containing text part.
                    ITextPart textPart = textSelection.GetAsOneTextPart();
                    //Replace the text
                    textPart.Text = "Service";
                }
            }
            else
            {
                ITextSelection[] textSelections = null;
                if (replaceUsingText)
                {
                    //Finds all the occurrences of a particular text
                    textSelections = presentation.FindAll("{product}", matchCase, matchWholeWord);
                }
                else
                {
                    //Finds all the occurrences of a pattern
                    textSelections = presentation.FindAll(new Regex("{[A-Za-z]+}"));
                }
                if(textSelections != null)
                {
                    foreach (ITextSelection textSelection in textSelections)
                    {
                        //Gets the found text as single text part
                        ITextPart textPart = textSelection.GetAsOneTextPart();
                        //Replace the text
                        textPart.Text = "Service";
                    }
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