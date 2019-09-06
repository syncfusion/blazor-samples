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

namespace ej2_blazor_samples
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

    internal class SampleList
    {

        public string Name { get; set; }
        public string Directory { get; set; }
        public string Category { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public SampleType Type { get; set; }
        public int Order { get; set; }
        public int UID { get; set; }

        public List<Sample> Samples { get; set; } = new List<Sample>();
    }

    internal class Sample
    {
        public string Name { get; set; }
        public string Directory { get; set; }
        public string Category { get; set; }
        public int Order { get; set; }
        public string FileName { get; set; }
        public string Url { get; set; }
        public List<SourceCollection> SourceFiles { get; set; } = new List<SourceCollection>();

        [JsonConverter(typeof(StringEnumConverter))]
        public SampleType Type { get; set; }
    }
    internal class SourceCollection
    {
        public string FileName { get; set; }
        public string Id { get; set; }
    }

    internal static class SampleBrowser
    {
        public static List<SampleList> SampleList { get; set; } = new List<SampleList>();
        internal static SampleConfig Config = new SampleConfig();
        internal static string CurrentSampleName;
        internal static List<Sample> CurrentControl;
        internal static string CurrentControlName;
        internal static string CurrentControlCategory;
        internal static string CurrentFilePath;
        internal static string CurrentUrl;
        internal static string[] ActionDescription;
        internal static string[] Description;
        internal static List<String> SampleUrls = new List<String>();
    }

    enum SampleType
    {
        None,
        New,
        Updated,
        Preview
    }
}
