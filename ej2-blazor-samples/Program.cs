using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ej2_blazor_samples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            new HubConnectionBuilder()
               .WithUrl("/chatHub")
               .AddNewtonsoftJsonProtocol()
               .Build();

        }

        public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                .UseBlazorStartup<Startup>();
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

        [JsonConverter(typeof(StringEnumConverter))]
        public SampleType Type { get; set; }
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
        internal static List<String>  SampleUrls = new List<String>();
    }

    enum SampleType
    {
        None,
        New,
        Updated,
        Preview
    }


    
}
