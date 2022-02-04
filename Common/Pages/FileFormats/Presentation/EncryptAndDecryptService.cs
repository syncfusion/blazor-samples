using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.Presentation;
using System;
using System.Collections.Generic;
using System.IO;

namespace BlazorDemos.Pages.FileFormats.Presentation
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
            //Save the document as a stream and retrun the stream
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
            //Save the document as a stream and retrun the stream
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
            return _hostingEnvironment.WebRootPath + "//data//presentation//" + fileName;
        }
        #endregion
    }
}
