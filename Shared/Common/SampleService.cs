using System.Linq;
using Microsoft.AspNetCore.Components;

namespace blazor_samples.Shared
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
                        var controlInfo = SampleBrowser.SampleList.First<SampleList>(control => control.ControllerName.ToLower().Equals(categoryName));
                        this.ComponentName = controlInfo.Name;
                        var sampleInfo = controlInfo.Samples.Where(control => control.Url.ToLower() == updatedUrl).ToList();
                        if (sampleInfo.Count > 0)
                        {
                            this.SampleInfo = sampleInfo.First();
                        }
                        else
                        {
                            var sampleName = splittedUrl[splittedUrl.Length-1].Replace("-", string.Empty);
                            this.SampleInfo = controlInfo.Samples.Where(control => control.FileName.ToLower() == (sampleName + ".razor")).First();
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}
