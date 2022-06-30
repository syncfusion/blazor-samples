#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.Presentation;
using System;
using System.Collections.Generic;
using System.IO;

namespace BlazorDemos.Pages.DocumentProcessing.PowerPoint
{
    public class EncryptAndDecryptService
    {
            private readonly IWebHostEnvironment _hostingEnvironment;
            public EncryptAndDecryptService(IWebHostEnvironment hostingEnvironment)
            {
                _hostingEnvironment = hostingEnvironment;
            }
        /// <summary>
        /// Create an encrypt Presentation document
        /// </summary>
        /// <returns>Return the created Presentation document as stream</returns>
        public MemoryStream CreateEncryptPresentation()
        {
            FileStream fileStreamInput = new FileStream(ResolveApplicationPath(@"syncfusion-presentation.pptx"), FileMode.Open, FileAccess.Read);
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(fileStreamInput);
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
            FileStream fileStreamInput = new FileStream(ResolveApplicationPath(@"syncfusion-presentation.pptx"), FileMode.Open, FileAccess.Read);
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(fileStreamInput);
            presentation.RemoveEncryption();
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created PowerPoint document to MemoryStream
                presentation.Save(stream);
                return stream;
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
