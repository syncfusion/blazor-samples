#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
namespace FileManagerAI.Services
{
    public class TagService
    {
        public Dictionary<string, string[]> fileTags = new Dictionary<string, string[]>
        {
            { "EJ2 File Manager.docx", new[] { "document", "EJ2" } },
            { "EJ2 File Manager.pdf", new[] { "document", "EJ2" } },
            { "File Manager.txt", new[] { "text", "file manager" } },
            { "PDF_Succinctly.pdf", new[] { "document", "PDF" } },
            { "Albert.png", new[] { "image", "person" } },
            { "Nancy.png", new[] { "image", "person" } },
            { "Robert.png", new[] { "image", "person" } },
            { "Applepie.png", new[] { "image", "food" } },
            { "Bread.png", new[] { "image", "food" } },
            { "Doughnut.png", new[] { "image", "food" } },
            { "Nuggets.png", new[] { "image", "food" } },
            { "Sugarcookie.png", new[] { "image", "food" } },
            { "beach.jpg", new[] { "image", "nature" } },
            { "lily.jpg", new[] { "image", "flower" } },
            { "mountain.jpg", new[] { "image", "nature" } },
            { "bird.jpg", new[] { "image", "animal" } },
            { "Michael.png", new[] { "image", "person" } },
            { "Music.mp3", new[] { "audio", "music" } },
            { "Sample Music.mp3", new[] { "audio", "sample" } },
            { "sea.jpg", new[] { "image", "nature" } },
            { "seaview.jpg", new[] { "image", "nature" } },
            { "snow.jpg", new[] { "image", "nature" } },
            { "snowfall.jpg", new[] { "image", "nature" } },
            { "Demo Video.mp4", new[] { "video", "demo" } },
            { "Sample Video.mp4", new[] { "video", "sample" } }
        };

        public string[] GetTags(string fileName)
        {
            return fileTags[fileName];
        }
    }
}
