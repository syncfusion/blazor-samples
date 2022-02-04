#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using Syncfusion.Presentation;
using Syncfusion.PresentationRenderer;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace BlazorDemos.Data.FileFormats.Presentation
{
    public class PPTXToImageService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public PPTXToImageService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// Create a simple Presentation document
        /// </summary>
        /// <returns>Return the converted Presentation image as stream</returns>
        public MemoryStream ImageConversion()
        {
            //Open the existing presentation
            FileStream fileStreamInput = new FileStream(ResolveApplicationPath("template.pptx"), FileMode.Open, FileAccess.Read);
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(fileStreamInput);           
            
            //Initialize PresentationRenderer to perform image conversion.
            presentation.PresentationRenderer = new PresentationRenderer();
            Stream stream = presentation.Slides[0].ConvertToImage(ExportImageFormat.Jpeg);
            stream.Position = 0;

            //Save the document as a stream and retrun the stream
            using (MemoryStream stream1 = new MemoryStream())
            {
                stream.CopyTo(stream1);                
                return stream1;
            }
        }
		
		/// <summary>
        /// Open a Presentation template document
        /// </summary>
        /// <returns>Return the input Presentation template document as stream</returns>
        public MemoryStream ImageInput()
        {
            //Open the existing presentation
            FileStream fileStreamInput = new FileStream(ResolveApplicationPath("template.pptx"), FileMode.Open, FileAccess.Read);
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(fileStreamInput);      
            
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