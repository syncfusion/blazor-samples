#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Blazor.DropDowns;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemos
{
    public class DataPreset
    {
        public int ID { get; set; }
        public string Text { get; set; }
    }

    public class BugReportModel
    {
        [Display(Name = "Bug Name")]
        public string BugName { get; set; }

        [Display(Name = "Reporter")]
        public string Reporter { get; set; }

        [Display(Name = "Submitted Date")]
        public string SubmittedDate { get; set; }

        [Display(Name = "Bug Description")]
        public string BugDescription { get; set; }

        [Display(Name = "Repro Steps")]
        public string ReproSteps { get; set; }

        [Display(Name = "Browser")]
        public SfDropDownList<string, string> Browser { get; set; }

        [Display(Name = "Bug Priority")]
        public string BugPriority { get; set; }
    }

    public static class CommonData
    {
        public static List<DataPreset> BugPresets { get; } = new List<DataPreset>
        {
            new DataPreset { ID = 0, Text = "Issue with the dropdown menu" },
            new DataPreset { ID = 1, Text = "Trouble logging into the website" },
            new DataPreset { ID = 2, Text = "Search functionality not working" },
            new DataPreset { ID = 3, Text = "Images missing on the product page" }
        };

        public static List<string> BugReports { get; } = new List<string>
    {
        "Hi, this is Alice. On July 3rd, I encountered a bug in Chrome where the dropdown menu in the navigation bar fails to close after selecting an item. While this might not be a major issue, I kindly request that you investigate and resolve it. Regards, J Alice Abraham.",
        "On May 2nd, K John Doe reported a critical bug where the login page unexpectedly refreshes instead of logging in when the login button is clicked, impacting all major browsers. This prevents users from accessing their accounts. To reproduce: open any browser, navigate to the login page, enter valid credentials, and click 'Login'.",
    };
    }
}
