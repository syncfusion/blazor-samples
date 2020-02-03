using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Components;

namespace ej2_blazor_samples.Shared
{

    public class SampleService
    {
        // Can be called from anywhere
        public void Update(NotifyProperties prop)
        {
            if (Notify != null)
            {
                this.Prop = prop;
                Notify.Invoke(prop);
            }
        }

        public NotifyProperties Prop
        {
            get; set;
        } = new NotifyProperties();

        public CurrentSampleData Data { get; set; } = new CurrentSampleData();
        public event Func<NotifyProperties, Task> Notify;
    }

    public class NotifyProperties
    {
        public bool HideSpinner { get; set; }

        public bool RestricMouseEvents { get; set; }
    }

    public class CurrentSampleData
    {
        public CurrentSampleData (NavigationManager uriHelper)
        {
            this.UriHelper = uriHelper;
        }

        public CurrentSampleData()
        {
           
        }
        public NavigationManager UriHelper { get; set; }
        internal SampleList CurrentControl { get; set; }

        internal Sample CurrentSample { get; set; }
      
        internal void Update(NavigationManager urlHelper)
        {
            this.UriHelper = urlHelper;
            string updatedUrl = UriHelper.Uri.Replace(UriHelper.BaseUri, "").Trim();
            if (updatedUrl.IndexOf("?") >= 0)
            {
                updatedUrl = updatedUrl.Substring(0, updatedUrl.IndexOf("?"));
            }
            if (updatedUrl != "")
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
                        string CategoryName = splittedUrl[splittedUrl.Length - 2];
                        string SampleName = splittedUrl[splittedUrl.Length - 1];
                        this.CurrentControl = SampleBrowser.SampleList.First<SampleList>(control => control.ControllerName.Equals(CategoryName));
                        this.CurrentSample = this.CurrentControl.Samples.First<Sample>(sample => sample.Url.Equals(updatedUrl));
                    }
                    catch (Exception e)
                    {

                    }
                }
            }

        }      
    }

}
