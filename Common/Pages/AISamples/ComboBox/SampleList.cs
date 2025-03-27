#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;

namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> AIComboBox { get; set; } = new List<Sample>{

            new Sample
            {
                Name = "Semantic Searching (Embedding)",
                Category = "ComboBox",
                Directory = "AISamples/ComboBox",
                Url = "ai-combobox/embeddings",
                FileName = "ComboBoxEmbeddings.razor",
                NotificationDescription = new string[]{ @" This demo shows the semantic search AI feature in Combo Box." }
            }
        };
    }
}