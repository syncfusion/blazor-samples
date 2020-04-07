using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace blazor_samples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    internal class SampleListType
    {
        public string UID { get; set; }
        public List<SampleListType> SourceData { get; set; }
        public string Name { get; set; }

        public string IconCss { get; set; }
        public bool Expanded { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public SampleType Type { get; set; }

        public List<Sample> Samples { get; set; } 
    }
    public class SampleList
    {

        public string Name { get; set; }
        public string Directory { get; set; }
        public string Category { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public SampleType Type { get; set; }
        public int Order { get; set; }
        public int UID { get; set; }

        public List<Sample> Samples { get; set; } = new List<Sample>();

        public String ControllerName { get; set; }
    }

    public class Sample
    {
        public string Name { get; set; }
        public string Directory { get; set; }
        public string Category { get; set; }
        public int Order { get; set; }
        public string FileName { get; set; }
        public string Url { get; set; }
        public string TitleTag { get; set; }
        public string MetaDescription { get; set; }

        public string MappingSampleName { get; set; }

        public string[] ActionDescription { get; set; }

        public string[] Description { get; set; }
        public List<SourceCollection> SourceFiles { get; set; } = new List<SourceCollection>();
        [JsonConverter(typeof(StringEnumConverter))]
        public SampleType Type { get; set; }
    }
    public class SourceCollection
    {
        public string FileName { get; set; }
        public string Id { get; set; }
    }

    internal static class SampleBrowser
    {
        public static List<SampleList> SampleList { get; set; } = new List<SampleList>();
        internal static SampleConfig Config { get; set; } = new SampleConfig();
        internal static string CurrentSampleName { get; set; }
        internal static string CurrentFileName { get; set; }
        internal static List<Sample> CurrentControl = new List<Sample>();
        internal static string CurrentControlName { get; set; }
        internal static string CurrentControlCategory { get; set; }
        internal static string CurrentFilePath { get; set; }
        internal static string CurrentUrl { get; set; }
        internal static string TitleTag { get; set; }
        internal static string MetaDescription { get; set; }
        internal static string[] ActionDescription { get; set; }
        internal static string[] Description { get; set; }
        internal static List<String> SampleUrls = new List<String>();
        //internal static List<SourceCollection> CurrentSourceFiles { get; set; } = new List<SourceCollection>();
        //internal static string CurrentSampleDirectory { get; set; }
        //internal static void UpdateSampleData(string url, string baseUrl)
        //{
        //    string updatedUrl = url.Replace(baseUrl, "").Trim();
        //    if (updatedUrl.IndexOf("?") >= 0)
        //    {
        //        updatedUrl = updatedUrl.Substring(0, updatedUrl.IndexOf("?"));
        //    }
        //    if (updatedUrl != "")
        //    {                
        //        if (updatedUrl.LastIndexOf("/") == updatedUrl.Length - 1)
        //        {
        //            updatedUrl = updatedUrl.Substring(0, updatedUrl.LastIndexOf("/"));
        //        }

        //        string[] splittedUrl = updatedUrl.Split("/");
        //        if (splittedUrl.Length >= 2)
        //        {
        //            string CategoryName = splittedUrl[splittedUrl.Length - 2];
        //            string SampleName = splittedUrl[splittedUrl.Length - 1];
        //            foreach (var Control in SampleBrowser.SampleList)
        //            {
        //                if (Control.ControllerName == CategoryName)
        //                {
        //                    SampleBrowser.CurrentControl = Control.Samples;
        //                    SampleBrowser.CurrentControlName = Control.Name;
        //                    SampleBrowser.CurrentControlCategory = Control.Category;                            
        //                    break;
        //                }
        //            }

        //            foreach (var sample in SampleBrowser.CurrentControl)
        //            {
        //                if (sample.Url.IndexOf(SampleName) >= 0)
        //                {
        //                    SampleBrowser.CurrentSampleName = sample.Name;
        //                    SampleBrowser.TitleTag = sample.TitleTag;
        //                    SampleBrowser.MetaDescription = sample.MetaDescription;
        //                    SampleBrowser.ActionDescription = sample.ActionDescription;
        //                    SampleBrowser.Description = sample.Description;
        //                    SampleBrowser.CurrentSourceFiles = sample.SourceFiles;
        //                    SampleBrowser.CurrentSampleDirectory = sample.Directory;
        //                    SampleBrowser.CurrentFileName = sample.FileName;
        //                    break;
        //                }
        //            }
        //        }
        //    }




        //}
        //internal static void Refresh()
        //{
        //    SampleBrowser.ActionDescription = null;
        //    SampleBrowser.CurrentControl = new List<Sample>(); ;
        //    SampleBrowser.CurrentControlCategory = null;
        //    SampleBrowser.CurrentControlName = null;
        //    SampleBrowser.CurrentSampleName = null;
        //    SampleBrowser.Description = null;
        //    SampleBrowser.TitleTag = null;
        //    SampleBrowser.MetaDescription = null;
        //    SampleBrowser.CurrentSourceFiles = new List<SourceCollection>();
        //    SampleBrowser.CurrentSampleDirectory = null;
        //    SampleBrowser.CurrentFileName = null;

        //}
    }

    internal class SampleData
    {
        public List<SampleList> SampleList { get; set; } = new List<SampleList>();
        //internal SampleConfig Config = SampleBrowser.SampleList
        internal string CurrentSampleName { get; set; }
        internal List<Sample> CurrentControl { get; set; }
        internal string CurrentControlName { get; set; }
        internal string CurrentControlCategory { get; set; }
        internal string CurrentFilePath { get; set; }
        internal string CurrentUrl { get; set; }
        internal string TitleTag { get; set; }
        internal string MetaDescription { get; set; }
        internal string[] ActionDescription { get; set; }
        internal string[] Description { get; set; }
        internal List<String> SampleUrls = new List<String>();
    }

    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SampleType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "new")]
        New,
        [EnumMember(Value = "updated")]
        Updated,
        [EnumMember(Value = "preview")]
        Preview
    }
}
