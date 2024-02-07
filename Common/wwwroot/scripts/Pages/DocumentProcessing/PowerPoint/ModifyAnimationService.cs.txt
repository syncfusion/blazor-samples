#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System.IO;
using System.Collections.Generic;
using Syncfusion.Presentation;

namespace BlazorDemos.Data.DocumentProcessing.PowerPoint
{
    public class ModifyAnimationService
    {
        private readonly Dictionary<string, MemoryStream> fileDataValue;
        public ModifyAnimationService(Dictionary<string, MemoryStream> fileData)
        {
            fileDataValue = fileData;
        }

        /// <summary>
        /// Create a simple Presentation document
        /// </summary>
        /// <returns>Return the created Presentation document as stream</returns>
        public MemoryStream ModifyAnimationPresentation()
        {
            //Opens the presentation document as stream
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(fileDataValue["shape-with-animation.pptx"]);
            //New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].

            //Modify the existing animation
            ModifyAnimation(presentation);            
			
            //Save the document as a stream and return the stream
            using (MemoryStream stream = new MemoryStream())
            {
                //Save the created PowerPoint document to MemoryStream
                presentation.Save(stream);
                return stream;
            }
        }
		
		/// <summary>
        /// View Animation Presentation document
        /// </summary>
        /// <returns>Return the template Presentation document as stream</returns>
        public MemoryStream ModifyAnimationTemplate()
        {
            //Opens the presentation document as stream
            IPresentation presentation = Syncfusion.Presentation.Presentation.Open(fileDataValue["shape-with-animation.pptx"]);
            //New Instance of PowerPoint is Created.[Equivalent to launching MS PowerPoint with no slides].          
			
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

        #region Modify Animation

        private void ModifyAnimation(IPresentation presentation)
        {
            //Retrieves the slide instance
            ISlide slide = presentation.Slides[0];
            //Retrieves the slide main sequence
            ISequence sequence = slide.Timeline.MainSequence;
            //Retrieves the existing animation effect from the main sequence
            IEffect loopEffect = sequence[0];
            //Change the type of the existing animation effect
            loopEffect.Type = EffectType.Bounce;
        }
        #endregion
    }
}