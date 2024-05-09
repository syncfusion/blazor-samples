#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.Presentation;
using System;
using System.Collections.Generic;
using System.IO;

namespace BlazorDemos.Pages.DocumentProcessing.PowerPoint
{
    public class EncryptAndDecryptService
    {
            private readonly Dictionary<string, MemoryStream> fileDataValue;
            public EncryptAndDecryptService(Dictionary<string, MemoryStream> fileData)
            {
                fileDataValue = fileData;
            }
        /// <summary>
        /// Create an encrypt Presentation document
        /// </summary>
        /// <returns>Return the created Presentation document as stream</returns>
        public MemoryStream CreateEncryptPresentation()
        {
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(fileDataValue["syncfusion-presentation.pptx"]);
            presentation.Encrypt("syncfusion");
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created PowerPoint document to MemoryStream
                presentation.Save(stream);
                return stream;
            }
        }

        /// <summary>
        /// Create a decrypt Presentation document
        /// </summary>
        /// <returns>Return the created Presentation document as stream</returns>
        public MemoryStream CreateDecryptPresentation()
        {
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(fileDataValue["syncfusion-presentation.pptx"]);
            presentation.RemoveEncryption();
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
