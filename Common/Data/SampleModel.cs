#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BlazorDemos
{
    public class SampleListType
    {
        public List<SampleListType> SourceData { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SampleType Type { get; set; }
        public List<Sample> Samples { get; set; }
        public string DemoPath { get; set; }
        public string Category { get; set; }
        public string InfoTooltip { get; set; }
        public bool IsHide { get; set; }
    }

    public class SampleList
    {
        public string Name { get; set; }
        public string Directory { get; set; }
        public string Category { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SampleType Type { get; set; }
        public List<Sample> Samples { get; set; } = new List<Sample>();
        public string ControllerName { get; set; }
        public string DemoPath { get; set; }
        public bool IsPreview { get; set; }
        public string CustomDocLink { get; set; }
        public bool IsHideFromHomePageList { get; set; }
        public bool IsHide { get; set; }
        public string InfoTooltip { get; set; }
        public string ComponentIconName { get; set; }
        public string[] NotificationDescription { get; set; }
    }

    public class Sample
    {
        public string Name { get; set; }
        public string Directory { get; set; }
        public string Category { get; set; }
        public string FileName { get; set; }
        public string Url { get; set; }
        public string MappingSampleName { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string HeaderText { get; set; }
        public List<SourceCollection> SourceFiles { get; set; } = new List<SourceCollection>();
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SampleType Type { get; set; }
        public string[] NotificationDescription { get; set; }
        public bool IsHideInMobile { get; set; }
        public bool IsHideFromSamplePageList { get; set; }
    }

    public class SourceCollection
    {
        public string FileName { get; set; }
        public string Id { get; set; }
    }

    internal static class SampleBrowser
    {
        public static List<SampleList> SampleList { get; set; } = new List<SampleList>();
        internal static List<string> SampleUrls = new List<string>();
        internal static SampleConfig Config { get; set; } = new SampleConfig();
        internal static List<string> PreLoadFiles = new List<string>()
        {

#if WASM
    #if NET6_0
            "_content/Blazor_WASM_Common_NET6/styles/common/fonts/open-sans-700.woff2",
            "_content/Blazor_WASM_Common_NET6/styles/common/fonts/open-sans-regular.woff2"
    #else
            "_content/Blazor_WASM_Common_NET8/styles/common/fonts/open-sans-700.woff2",
            "_content/Blazor_WASM_Common_NET8/styles/common/fonts/open-sans-regular.woff2"
    #endif  
#elif WEBAPP
    #if NET8_0
            "_content/Blazor_WebApp_Common_NET8/styles/common/fonts/open-sans-700.woff2",
            "_content/Blazor_WebApp_Common_NET8/styles/common/fonts/open-sans-regular.woff2"
    #endif
#else
    #if NET6_0
            "_content/Blazor_Server_Common_NET6/styles/common/fonts/open-sans-700.woff2",
            "_content/Blazor_Server_Common_NET6/styles/common/fonts/open-sans-regular.woff2",
    #else
            "_content/Blazor_Server_Common_NET8/styles/common/fonts/open-sans-700.woff2",
            "_content/Blazor_Server_Common_NET8/styles/common/fonts/open-sans-regular.woff2",
    #endif
#endif
        };
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
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