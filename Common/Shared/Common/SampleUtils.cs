#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Web;
using Syncfusion.Blazor.Navigations;
using Microsoft.AspNetCore.Components;
using System.Text.RegularExpressions;

namespace BlazorDemos.Shared
{
    /// <summary>
    /// A util class to perform common functionalities.
    /// </summary>
    public static class SampleUtils
    {
        #region common
        public const string SPACE = " ";
        public const string CONTENT = "sf-content";
        public const string VISIBLE = "sf-visible";
        public const string HIDDEN = "sf-hidden";
        public const string DISPLAY_NONE = "sb-hide";
        public const string COMPONENTS_HIDE = "sb-components-hide";
        public const string ACTIVE_CLASS = "active";

        #endregion

        #region SideBarComponent
        public const string SIDEBAR_CLASS = "sf-sidebar";
        public const string LEFT_CLASS = "sf-sidebar-left";
        public const string RIGHT_CLASS = "sf-sidebar-right";
        public const string RIGHT_PANE = "sf-sidebar-right-pane";
        public const string RIGHT_PANE_COLLAPSE = "sf-sidebar-right-pane-collapse";
        public const string RIGHT_PANE_EXPAND = "sf-sidebar-right-pane-expand";
        #endregion

        #region ListComponent
        public const string LIST_CLASS = "sf-list";
        public const string LIST_UL_CLASS = "sf-list-ul";
        public const string LIST_LI_CLASS = "sf-list-li";
        public const string LIST_LI_GROUP_CLASS = "sf-list-group-li";
        public const string LIST_ACTIVE = "sf-list-li-active";
        #endregion

        #region Spinner
        public const string MODAL_CLASS = "sf-modal";
        #endregion

        #region TreeComponent
        public const string TREE_CLASS = "sf-tree";
        public const string TREE_FULL_ROW = "sf-tree-full-row";
        public const string TREE_TEXT_CONTENT = "sf-tree-text-content";
        public const string TREE_PARENT = "sf-tree-parent";
        public const string TREE_PARENT_LI = "sf-tree-parent-li";
        public const string TREE_EXPAND_ICON = "sf-tree-expand-icon";
        public const string TREE_COLLAPSE_ICON = "sf-tree-collapse-icon";
        public const string TREE_TEXT = "sf-tree-text";
        public const string TREE_ACTIVE = "sf-tree-active";
        public const string TREE_HIDE = "sf-tree-hide";
        #endregion

        #region CarouselComponent
        public const string CAROUSEL = "sf-carousel";
        public const string CAROUSEL_CONTAINER = "sf-carousel-container";
         public const string CAROUSEL_TRANSITION = "sf-carousel-transition";
        public const string CAROUSEL_ITEM = "sf-carousel-item";
        public const string CAROUSEL_SELECTED = "sf-carousel-selected";
        public const string CAROUSEL_PREVIOUS_BUTTON = "sf-carousel-prev-button sb-icons";
        public const string CAROUSEL_NEXT_BUTTON = "sf-carousel-next-button sb-icons";
        public const string CAROUSEL_IMAGE = "sf-carousel-image";
        public const string CAROUSEL_HEADER = "sf-carousel-header";
        public const string CAROUSEL_CONTENT = "sf-carousel-content";
        public const string CAROUSEL_CLONE = "sf-carousel-clone";
        public const string CAROUSEL_CONTENT_AREA = "sf-carousel-content-area";
        public const string CAROUSEL_PROGRESS = "sf-carousel-progress";
        #endregion

        #region SearchComponent
        public const string SEARCH_CONTAINER = "sf-search-container";
        public const string SEARCH_POPUP = "sf-search-popup";
        public const string SEARCH_INPUT = "sf-search-input";
        public const string SEARCH_NO_DATA = "sf-search-no-data";
        public const string CLEAR_ICON = "sb-icons sf-clear-icon";
        public const string SEARCH_ICON = "sb-icons sf-search-icon";
        public const string SEARCH_OVERLAY = "sb-search-overlay";
        public const string SEARCH_KEY_NAV = "sf-key-nav";
        #endregion

        #region AdStripComponent
        public const string AD_CONTAINER = "sb-ad-container";
        public const string AD_CONTENT = "sb-ad-content-area";
        public const string AD_HEADER = "sb-ad-header";
        public const string AD_POINTS_DIV = "sb-ad-points-div";
        public const string AD_POINT_DIV = "sb-ad-point-div";
        public const string AD_POINT_TICK = "sb-ad-img-div sb-icons sb-ad-tick";
        public const string AD_POINT_TEXT = "sb-ad-point-text";
        public const string AD_LINK = "sb-ad-link";
        public const string AD_TRY = "sb-ad-try-area";
        #endregion

        #region HomePage
        public const string HEADER_LOGO = "header-logo";
        public const string SYNCFUSION_LOGO = "sf-header-logo";
        public const string MOBILE_SEARCH_CONTAINER = "mobile-search-container";
        #endregion

        #region Preferences
        public const string DEFAULT_MODE = "mouse";
        public const string PREFERENCES_POPUP_CLASS = "sf-preferences-popup";
        public const string PREFERENCES_TOUCH = "sf-preference-btn sf-preference-touch-btn";
        public const string PREFERENCES_MOUSE = "sf-preference-btn sf-preference-mouse-btn";
        #endregion

        #region HeaderComponent
        public const string HEADER_SEARCH_CLASS = "sb-search-btn";
        public const string HEADER_PREFERENCES_CLASS = "sf-preferences-button";
        #endregion

        #region DropdownComponent
        public const string DROPDOWN_POPUP = "sf-dropdown-popup";
        #endregion

        #region NotificationComponent
        public const string NOTIFICATION_POPUP_CLASS = "sb-notification-popup";
        #endregion

        /// <summary>
        /// Add a class to the existing string content.
        /// </summary>
        /// <param name="prevClass">Previous class list in string format.</param>
        /// <param name="className">Class name needs to be added in the string content.</param>
        /// <returns>Returns class string.</returns>
        internal static string AddClass(string prevClass, string className)
        {
            var finalClass = string.IsNullOrEmpty(prevClass) ? string.Empty : prevClass.Trim();
            finalClass = finalClass.Contains(className) ? finalClass : finalClass + SampleUtils.SPACE + className;
            return finalClass;
        }

        /// <summary>
        /// Remove a class from the existing string content.
        /// </summary>
        /// <param name="prevClass">Previous class list in string format.</param>
        /// <param name="className">Class name needs to be removed in the string content.</param>
        /// <returns>Returns class string.</returns>
        public static string RemoveClass(string prevClass, string className)
        {
            var finalClass = string.IsNullOrEmpty(prevClass) ? string.Empty : prevClass.Trim();
            finalClass = finalClass.Contains(className) ? prevClass.Replace(className, string.Empty) : finalClass;
            return finalClass;
        }

        public static bool IsHomePage(NavigationManager uriHelper)
        {
            var currentUri = uriHelper.Uri.Split("?")[0];
            return uriHelper.BaseUri == currentUri;
        }

        /// <summary>
        /// Returns the url with current selected theme query string.
        /// </summary>
        /// <param name="url">Current url need to be validated.</param>
        /// <param name="themeName">Selected theme name to be added in the query string.</param>
        /// <returns>Returns class string.</returns>
        public static string GetThemeUrl(NavigationManager UriHelper, string themeName)
        {
            string url = UriHelper.Uri.TrimEnd('/');
            if (url.Contains("?theme="))
            {
                string[] splittedUrl = url.Split("?theme=");
                url = splittedUrl[0];
            }
            url = UriHelper.GetUriWithQueryParameters(url, new Dictionary<string, object>
            {
                ["theme"] = themeName
            });
            return url;
        }

        /// <summary>
        /// Returns the current theme name from the url.
        /// </summary>
        /// <param name="url">Current url need to be parsed for getting the theme name.</param>
        public static string GetThemeName(string url)
        {
            var uri = new Uri(url);
            string themeName = HttpUtility.ParseQueryString(uri.Query).Get("theme");
            themeName = themeName != null ? themeName : "fluent2";
            return themeName;
        }

        public static List<DropDownData> ThemeData = new List<DropDownData>
        {
            new DropDownData { ID = "material3", Text = "Material 3" },
            new DropDownData { ID = "fluent", Text = "Fluent" },
            new DropDownData { ID = "fluent2", Text = "Fluent2" },
            new DropDownData { ID = "bootstrap5", Text = "Bootstrap v5" },
            new DropDownData { ID = "tailwind", Text = "Tailwind CSS" },
#if DEBUG || STAGING
      //      new DropDownData { ID = "material-dark", Text = "Material Dark" },
#endif
          //  new DropDownData { ID = "bootstrap4", Text = "Bootstrap v4" },
#if DEBUG || STAGING
           // new DropDownData { ID = "fabric", Text = "Fabric" },
#endif
            new DropDownData { ID = "highcontrast", Text = "High Contrast" },
            //new DropDownData { ID = "fluent2-highcontrast", Text = "Fluent2 High Contrast" },
        };

        /// <summary>
        /// Returns the current theme mode from the url.
        /// </summary>
        /// <param name="url">Current url need to be parsed for getting the theme mode.</param>
        public static string GetThemeMode(string url)
        {
            var uri = new Uri(url);
            string themeMode = HttpUtility.ParseQueryString(uri.Query).Get("theme");
            themeMode = themeMode == null ? "Light Mode" : !themeMode.Contains("-dark") ? "Light Mode" : "Dark Mode";
            return themeMode;
        }

        public static List<DropDownData> ThemeMode = new List<DropDownData> {
        new DropDownData { ID = "dark", Text = "Dark Mode" },
        new DropDownData { ID = "light", Text = "Light Mode" }
    };
        /// <summary>
        /// Returns list of JS resources need to be loaded.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetDynamicJSResources(NavigationManager uriHelper, SampleService sampleService)
        {
            var resourceList = new List<string>();
            if (sampleService.SampleJSLoaded)
            {
                sampleService.SampleJSLoaded = false;
                resourceList = new List<string>
                {
                   $"{sampleService.CommonScriptPath}/syncfusion-blazor.min.js",
                   $"{sampleService.SBScriptPath}"
                };
                if (sampleService.ComponentName != null)
                {
                    if (sampleService.ComponentName.Equals("PDF Viewer") && !sampleService.IsPdfScriptLoaded)
                    {
                        sampleService.IsPdfScriptLoaded = true;
                        resourceList.Add(sampleService.ViewerScriptPath);
                        resourceList.Add(sampleService.PdfScriptPath + "/syncfusion-blazor-pdfviewer.min.js");
                    }
                    if (sampleService.ComponentName.Equals("PDF Viewer (NextGen)") && !sampleService.IsPdfScript2Loaded)
                    {
                        sampleService.IsPdfScript2Loaded = true;
                        resourceList.Add(sampleService.ViewerScriptPath);
                        resourceList.Add(sampleService.PdfScriptPath2 + "/syncfusion-blazor-sfpdfviewer.min.js");
                    }
                    if (sampleService.ComponentName.Equals("Word Processor") && !sampleService.IsDocScriptLoaded)
                    {
                        sampleService.IsDocScriptLoaded = true;
                        resourceList.Add(sampleService.DocScriptPath + "/syncfusion-blazor-documenteditor.min.js");
                    }
                    if (sampleService.ComponentName.Equals("Diagram") && !sampleService.IsDiagramScriptLoaded)
                    {
                        sampleService.IsDiagramScriptLoaded = true;
                        resourceList.Add($"{sampleService.DiagramScriptPath}");
                    }
                }
            }
            return resourceList;
        }

        /// <summary>
        /// Returns list of resources need to be loaded.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetDynamicResources(NavigationManager uriHelper, SampleService sampleService)
        {
            var resourceList = new List<string>();
            if (!sampleService.IsHomeLoaded && SampleUtils.IsHomePage(uriHelper))
            {
                sampleService.IsHomeLoaded = true;
#if DEBUG || STAGING
                resourceList = new List<string> { $"{sampleService.WebAssetsPath}styles/common/home.css" };
#else
                resourceList = new List<string> { $"{sampleService.WebAssetsPath}styles/common/home.min.css" };
#endif
            }
            else if (!sampleService.IsDemoLoaded)
            {
                sampleService.IsDemoLoaded = true;
#if DEBUG || STAGING
                resourceList = new List<string>
                {
                    $"{sampleService.WebAssetsPath}styles/common/roboto.css",
                    $"{sampleService.WebAssetsPath}styles/common/highlight.css",
                    $"{sampleService.WebAssetsPath}styles/common/demos.css",
                };
                if (uriHelper.Uri.Contains("theme=highcontrast"))
                {
                    resourceList.Add($"{sampleService.WebAssetsPath}styles/common/highcontrast.css");
                }
                if (new Regex(@"theme=.*-dark").IsMatch(uriHelper.Uri))
                {
                    resourceList.Add($"{sampleService.WebAssetsPath}styles/common/dark-theme.css");
                }
#else
                resourceList = new List<string>
                {
                    $"{sampleService.WebAssetsPath}styles/common/demos.min.css",
                };
                if (uriHelper.Uri.Contains("theme=highcontrast") || new Regex(@"theme=.*-dark").IsMatch(uriHelper.Uri))
                {
                    resourceList.Add($"{sampleService.WebAssetsPath}styles/common/dark-theme.min.css");
                }
#endif
            }
            return resourceList;
        }
    }

    /// <summary>
    /// Culture switcher datasource model class.
    /// </summary>
    public class DropDownData
    {
        public string ID { get; set; }
        public string Text { get; set; }
    }

#pragma warning disable
    
    /// <summary>
    /// Search Component datasource model class.
    /// </summary>

    public class SearchList
    {
        public string Category { get; set; }
        public List<SearchResult> SampleList { get; set; }
        public bool IsMultiSearch { get; set; }
        public List<SearchList> GetSearchList()
        {
            bool isButtonsAdded = false;
            var searchlist = new List<SearchList>();
            var sampleList = SampleBrowser.SampleList;
            for (int i = 0; i < sampleList.Count; i++)
            {
                if ((sampleList[i].Category == "Buttons" || sampleList[i].Category == "Inputs") && sampleList[i].ControllerName == "Buttons")
                {
                    if (!isButtonsAdded)
                    {
                        isButtonsAdded = !isButtonsAdded;
                    }
                    else
                    {
                        continue;
                    }
                }
                var samples = sampleList[i].Samples;
                var searchResult = new List<SearchResult>();
                for (int j = 0; j < samples.Count; j++)
                {
                    var sample = samples[j];
                    searchResult.Add(new SearchResult { SampleName = sample.Name, SamplePath = sample.Url });
                }
                searchlist.Add(new SearchList { Category = sampleList[i].ControllerName, SampleList = searchResult });
            }
            return searchlist;
        }
    }

    public class SearchResult
    {
        public string SampleName { get; set; }
        public string SamplePath { get; set; }
    }
    /// <summary>
    /// Notification component's data model class.
    /// </summary
    public class NotificationList
    {
        public string Name { get; set; }
        public string DefaultSamplePath { get; set; }
        public List<NotificationData> SampleList { get; set; }
        public string[] NotificationContent { get; set; }
        public List<NotificationList> GetNotificationData()
        {
            var notificationlist = new List<NotificationList>();
            var sampleList = SampleBrowser.SampleList;
            for (int i = 0; i < sampleList.Count; i++)
            {
                var samples = sampleList[i].Samples;
                var notificationResultData = new List<NotificationData>();
                for (int j = 0; j < samples.Count; j++)
                {
                    var sample = samples[j];
                    if (sample.Type.ToString() == "New" || sample.Type.ToString() == "Updated" || sampleList[i].IsPreview)
                    {
                        if (sample.NotificationDescription != null)
                        {
                            notificationResultData.Add(new NotificationData { SampleName = sample.Name, SampleUrl = sample.Url, NotificationContent = sample.NotificationDescription });
                        }
                    }
                }
                if (notificationResultData.Count != 0)
                {
                    notificationlist.Add(new NotificationList { Name = sampleList[i].Name, DefaultSamplePath = sampleList[i].DemoPath, SampleList = notificationResultData });
                }
            }
            return notificationlist;
        }

        public List<NotificationList> GetComponentNotificationData()
        {
            var listcomponentnotification = new List<NotificationList>();
            var notificationResultData = new List<NotificationData>();
            var sampleList = SampleBrowser.SampleList;
            for (int i = 0; i < sampleList.Count; i++)
            {
                if (sampleList[i].NotificationDescription != null)
                {
                    listcomponentnotification.Add(new NotificationList { Name = sampleList[i].Name, DefaultSamplePath = sampleList[i].DemoPath, NotificationContent = sampleList[i].NotificationDescription });
                }
            }
            return listcomponentnotification;
        }

    }

    public class NotificationData
    {
        public string SampleName { get; set; }
        public string SampleUrl { get; set; }
        public string[] NotificationContent { get; set; }
    }

    /// <summary>
    /// Carousel component's data model class.
    /// </summary>
    public class ShowCaseItem
    {
        /// <summary>
        /// Constructor for updating properties.
        /// </summary>
        public ShowCaseItem(string header, string content, string imagePath, string demoLink, string gitHubLink)
        {
            this.Header = header;
            this.Content = content;
            this.ImagePath = imagePath;
            this.DemoLink = demoLink;
            this.GitHubLink = gitHubLink;
        }
        /// <summary>
        /// Specifies the header content of the item.
        /// </summary>
        public string Header { get; set; }
        /// <summary>
        /// Specifies the description of the item.
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// Specifies the image path of the item.
        /// </summary>
        public string ImagePath { get; set; }
        /// <summary>
        /// Specifies the hyper link of the item.
        /// </summary>
        public string DemoLink { get; set; }
        /// <summary>
        /// Specifies the GitHub link of the item.
        /// </summary>
        public string GitHubLink { get; set; }
    }

    public class CarouselModel
    {
        public int XValue { get; set; }
        public int LeftValue { get; set; }
        public bool IsDevice { get; set; }
    }

    /// <summary>
    /// AdStrip component's data model class.
    /// </summary>
    public class AdPoint
    {
        /// <summary>
        /// Constructor for updating property.
        /// </summary>
        public AdPoint(string Text)
        {
            this.AdPointText = Text;
        }
        /// <summary>
        /// Specifies the Ad point text content.
        /// </summary>
        public string AdPointText { get; set; }
    }

    /// <summary>
    /// Popular components model class.
    /// </summary>
    public class PopularComponents
    {
        public PopularComponents()
        {

        }

        public PopularComponents(string componentName, string imageName, string demoPath)
        {
            this.ComponentName = componentName;
            this.ImageName = imageName;
            this.DemoPath = demoPath;
        }
        /// <summary>
        /// Specifies the component name.
        /// </summary>
        public string ComponentName { get; set; }
        /// <summary>
        /// Specifies the component image path.
        /// </summary>
        public string ImageName { get; set; }
        /// <summary>
        /// Specifies the demo path.
        /// </summary>
        public string DemoPath { get; set; }

        public List<PopularComponents> GetComponents()
        {
            List<PopularComponents> components = new List<PopularComponents>();
            {
                components.Add(new PopularComponents("Data Grid", "data-grid", "datagrid/overview"));
                components.Add(new PopularComponents("Charts", "charts", "chart/overview"));
                components.Add(new PopularComponents("Scheduler", "scheduler", "scheduler/overview"));
                components.Add(new PopularComponents("Diagram", "diagram", "diagramcomponent/flowchart"));
                components.Add(new PopularComponents("Document Editor", "document-editor", "document-editor/default-functionalities"));
                components.Add(new PopularComponents("PDF Viewer", "pdf-viewer", "pdf-viewer-2/default-functionalities"));
            }
            return components;
        }
    }
    
#pragma warning restore

    /// <summary>
    /// Specifies the position of the SideBar component.
    /// </summary>
    public enum SidebarPlacement
    {   
        /// <summary>
        /// Renders the sidebar at left side.
        /// </summary>
        Left,
        /// <summary>
        /// Renders the sidebar at right side.
        /// </summary>
        Right
    }
}
