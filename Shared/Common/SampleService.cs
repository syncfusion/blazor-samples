using System.Linq;
using Microsoft.AspNetCore.Components;

namespace BlazorDemos.Shared
{
    /// <summary>
    /// The injectable service class used to handle common functionalities all over the application.
    /// </summary>
    public class SampleService
    {
        /// <summary>
        /// Specifies the app is rendering in device or not.
        /// </summary>
        public bool IsDevice { get; set; }
        /// <summary>
        /// Specifies spinner component reference.
        /// </summary>
        public SpinnerComponent Spinner { get; set; }
        /// <summary>
        /// Specifies the current component name.
        /// </summary>
        public string ComponentName { get; set; }
        /// <summary>
        /// Specifies the current sample details.
        /// </summary>
        public Sample SampleInfo { get; set; }
        /// <summary>
        /// Specifies the meta data component reference.
        /// </summary>
        public SampleMetaData MetaData { get; set; }
        /// <summary>
        /// Specifies the very first sample url.
        /// </summary>
        public string FirstSampleUrl { get; set; }
        /// <summary>
        /// Specifies the last sample url.
        /// </summary>
        public string LastSampleUrl { get; set; }

        /// <summary>
        /// Specifies the image url starts path.
        /// </summary>
        public string ImagePath { get; set; }
        /// <summary>
        /// Specifies the showcase image url starts path.
        /// </summary>
        public string ShowCaseImagePath { get; set; }
        /// <summary>
        /// Specifies the home page loaded or not.
        /// </summary>
        public bool IsHomeLoaded { get; set; }
        /// <summary>
        /// Specifies the demo page loaded or not.
        /// </summary>
        public bool IsDemoLoaded { get; set; }

        public SampleService()
        {
#if DEBUG
            ImagePath = "./images/common/";
            ShowCaseImagePath = "./images/showcase/";
#else
            ImagePath = "https://cdn.syncfusion.com/blazor/images/demos/";
            ShowCaseImagePath = "https://cdn.syncfusion.com/blazor/images/showcase/";
#endif
        }

        // Updates the SampleInfo and ComponentName based on current loaded uri.
        internal void Update(NavigationManager urlHelper)
        {
            string updatedUrl = urlHelper.ToBaseRelativePath(urlHelper.Uri);
            if (updatedUrl.Contains("?"))
            {
                updatedUrl = updatedUrl.Substring(0, updatedUrl.IndexOf("?"));
            }
            if (updatedUrl != string.Empty)
            {
                if (updatedUrl.LastIndexOf("/") == updatedUrl.Length - 1)
                {
                    updatedUrl = updatedUrl.Substring(0, updatedUrl.LastIndexOf("/"));
                }
                updatedUrl = updatedUrl.Replace("//", "/");
                string[] splittedUrl = updatedUrl.Split("/");
                if (splittedUrl.Length >= 2)
                {
                    try
                    {
                        string categoryName = splittedUrl[splittedUrl.Length - 2];
                        categoryName = categoryName.Replace("-", string.Empty);
                        SampleList controlInfo;
                        var sampleName = splittedUrl[splittedUrl.Length - 1];
                        if (categoryName == "buttons" && sampleName != "default-functionalities")
                        {
                            controlInfo = SampleBrowser.SampleList.First<SampleList>(control => control.DemoPath.ToLower().Contains(sampleName));
                        }
                        else
                        {
                            controlInfo = SampleBrowser.SampleList.First<SampleList>(control => control.ControllerName.ToLower().Equals(categoryName));
                        }
                        this.ComponentName = controlInfo.Name;
                        var sampleInfo = controlInfo.Samples.Where(control => control.Url.ToLower() == updatedUrl).ToList();
                        if (sampleInfo.Count > 0)
                        {
                            this.SampleInfo = sampleInfo.First();
                        }
                        else
                        {
                            sampleName = sampleName.Replace("-", string.Empty);
                            this.SampleInfo = controlInfo.Samples.Where(control => control.FileName.ToLower() == (sampleName + ".razor")).First();
                        }
                    }
                    catch
                    {

                    }
                }
                // Navigate a Sample using Component Name
                else if (splittedUrl.Length < 2 && splittedUrl.Length > 0)
                {
                    string categoryName = splittedUrl[splittedUrl.Length - 1];
                    categoryName = categoryName.Replace("-", string.Empty);
                    var controlInfo = SampleBrowser.SampleList.First<SampleList>(control => control.ControllerName.ToLower().Equals(categoryName));
                    if (controlInfo.Samples.Count > 0)
                    {
                        this.SampleInfo = controlInfo.Samples.First();
                    }
                    this.ComponentName = controlInfo.Name;
                    urlHelper.NavigateTo(SampleInfo.Url.ToLower() + "?theme=bootstrap5");
                }
            }
        }
    }
}
