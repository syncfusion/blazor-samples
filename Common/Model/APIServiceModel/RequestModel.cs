#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;

namespace BlazorDemos.Model
{
    public class RequestModel
    {
        public string model { get; set; }
        public List<MessageModel> messages { get; set; }
        public int maxtoken { get; set; }
    }

    public class MessageModel
    {
        public string role { get; set; }
        public string content { get; set; }
    }
}
