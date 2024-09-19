#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
