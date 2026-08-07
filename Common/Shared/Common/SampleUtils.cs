using System;
using System.Collections.Generic;
using System.Web;
using Syncfusion.Blazor.Navigations;
using Microsoft.AspNetCore.Components;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlazorDemos.Shared
{
    /// <summary>
    /// A util class to perform common functionalities.
    /// </summary>
    public static class SampleUtils
    {
        #region common
        public const string Space = " ";
        public const string Content = "sf-content";
        public const string Visible = "sf-visible";
        public const string Hidden = "sf-hidden";
        public const string DisplayNone = "sb-hide";
        public const string ComponentsHide = "sb-components-hide";
        public const string ActiveClass = "active";
        public const string ListText  = "sf-list-text";
        public const string TextContent  = "sf-text-content";

        #endregion

        #region SideBarComponent
        public const string SidebarClass = "sf-sidebar";
        public const string LeftClass = "sf-sidebar-left";
        public const string RightClass = "sf-sidebar-right";
        public const string RightPane = "sf-sidebar-right-pane";
        public const string RightPaneCollapse = "sf-sidebar-right-pane-collapse";
        public const string RightPaneExpand = "sf-sidebar-right-pane-expand";
        #endregion

        #region ListComponent
        public const string ListClass = "sf-list";
        public const string ListUlClass = "sf-list-ul";
        public const string ListLiClass = "sf-list-li";
        public const string ListLiGroupClass = "sf-list-group-li";
        public const string ListActive = "sf-list-li-active";
        #endregion

        #region Spinner
        public const string ModalClass = "sf-modal";
        #endregion

        #region TreeComponent
        public const string TreeClass = "sf-tree";
        public const string TreeFullRow = "sf-tree-full-row";
        public const string TreeTextContent = "sf-tree-text-content";
        public const string TreeParent = "sf-tree-parent";
        public const string TreeParentLi = "sf-tree-parent-li";
        public const string TreeExpandIcon = "sf-tree-expand-icon";
        public const string TreeCollapseIcon = "sf-tree-collapse-icon";
        public const string TreeText = "sf-tree-text";
        public const string TreeActive = "sf-tree-active";
        public const string TreeHide = "sf-tree-hide";
        #endregion

        #region CarouselComponent
        public const string Carousel = "sf-carousel";
        public const string CarouselContainer = "sf-carousel-container";
         public const string CarouselTransition = "sf-carousel-transition";
        public const string CarouselItem = "sf-carousel-item";
        public const string CarouselSelected = "sf-carousel-selected";
        public const string CarouselPreviousButton = "sf-carousel-prev-button sb-icons";
        public const string CarouselNextButton = "sf-carousel-next-button sb-icons";
        public const string CarouselImage = "sf-carousel-image";
        public const string CarouselHeader = "sf-carousel-header";
        public const string CarouselContent = "sf-carousel-content";
        public const string CarouselClone = "sf-carousel-clone";
        public const string CarouselContentArea = "sf-carousel-content-area";
        public const string CarouselProgress = "sf-carousel-progress";
        #endregion

        #region SearchComponent
        public const string SearchContainer = "sf-search-container";
        public const string SearchPopup = "sf-search-popup";
        public const string SearchInput = "sf-search-input";
        public const string SearchNoData = "sf-search-no-data";
        public const string ClearIcon = "sb-icons sf-clear-icon";
        public const string SearchIcon = "sb-icons sf-search-icon";
        public const string SearchOverlay = "sb-search-overlay";
        public const string SearchKeyNav = "sf-key-nav";
        #endregion

        #region AdStripComponent
        public const string AdContainer = "sb-ad-container";
        public const string AdContent = "sb-ad-content-area";
        public const string AdHeader = "sb-ad-header";
        public const string AdPointsDiv = "sb-ad-points-div";
        public const string AdPointDiv = "sb-ad-point-div";
        public const string AdPointTick = "sb-ad-img-div sb-icons sb-ad-tick";
        public const string AdPointText = "sb-ad-point-text";
        public const string AdLink = "sb-ad-link";
        public const string AdTry = "sb-ad-try-area";
        #endregion

        #region HomePage
        public const string HeaderLogo = "header-logo";
        public const string SyncfusionLogo = "sf-header-logo";
        public const string MobileSearchContainer = "mobile-search-container";
        #endregion

        #region Preferences
        public const string DefaultMode = "mouse";
        public const string PreferencesPopupClass = "sf-preferences-popup";
        public const string PreferencesTouch = "sf-preference-btn sf-preference-touch-btn";
        public const string PreferencesMouse = "sf-preference-btn sf-preference-mouse-btn";
        #endregion

        #region HeaderComponent
        public const string HeaderSearchClass = "sb-search-btn";
        public const string HeaderPreferencesClass = "sf-preferences-button";
        #endregion

        #region DropdownComponent
        public const string DropDownPopup = "sf-dropdown-popup";
        #endregion

        #region NotificationComponent
        public const string NotificationPopupClass = "sb-notification-popup";
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
            finalClass = finalClass.Contains(className, StringComparison.Ordinal) ? finalClass : finalClass + SampleUtils.Space + className;
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
            finalClass = finalClass.Contains(className,StringComparison.Ordinal) ? prevClass.Replace(className, string.Empty, StringComparison.Ordinal) : finalClass;
            return finalClass;
        }

        public static bool IsLocalSample(string path)
        {
            ArgumentNullException.ThrowIfNull(path);
            return path.Contains("localhost",StringComparison.Ordinal) ? true : false;
        }

        public static bool IsHomePage(NavigationManager uriHelper)
        {
            ArgumentNullException.ThrowIfNull(uriHelper);
            var currentUri = uriHelper.Uri.Split("?")[0];
            return uriHelper.BaseUri == currentUri;
        }

        /// <summary>
        /// List data for Demos Landing page switching button
        /// </summary>

        public static IReadOnlyList<ListData> BlazorPlatform { get; } = new List<ListData> {
            #if !SERVER
                        new ListData { ID = "server", Text = "Web App Server" },
            #endif
            #if !WASM
                        new ListData { ID = "wasm", Text = "Web App WASM" }
            #endif
        };

        /// <summary>
        /// Returns the url with current selected theme query string.
        /// </summary>
        /// <param name="url">Current url need to be validated.</param>
        /// <param name="themeName">Selected theme name to be added in the query string.</param>
        /// <returns>Returns class string.</returns>
        public static string GetThemePath(NavigationManager UriHelper, string themeName)
        {
            ArgumentNullException.ThrowIfNull(UriHelper);
            string url = UriHelper.Uri.TrimEnd('/');
#if !STAGING || DEBUG
            themeName = string.Equals(themeName, "bootstrap5.3", StringComparison.Ordinal) ? "bootstrap5" : themeName;
#endif
            if (url.Contains("?theme=", StringComparison.Ordinal))
            {
                string[] splittedUrl = url.Split("?theme=");
                url = splittedUrl[0];
            }
            url = UriHelper.GetUriWithQueryParameters(url, new Dictionary<string, object?>
            {
                ["theme"] = themeName
            });
            return url;
        }

        /// <summary>
        /// Returns the current theme name from the url.
        /// </summary>
        /// <param name="url">Current url need to be parsed for getting the theme name.</param>
        public static string GetThemeName(string path)
        {
            var uri = new Uri(path);
            string? themeName = HttpUtility.ParseQueryString(uri.Query).Get("theme");
            themeName = themeName != null ? themeName : "fluent2";
#if !STAGING || DEBUG
            themeName = themeName.Equals("bootstrap5", StringComparison.Ordinal) ? "bootstrap5.3" : themeName.Equals("bootstrap5-dark", StringComparison.Ordinal) ? "bootstrap5.3-dark" : themeName;
#endif
            return themeName;
        }

        public static IReadOnlyList<DropDownData> ThemeData { get; } = new List<DropDownData>
        {
#if RELEASE && STAGING
            new DropDownData { ID = "material", Text = "Material" },
#endif
            new DropDownData { ID = "material3", Text = "Material 3" },
#if RELEASE && STAGING
            new DropDownData { ID = "fluent", Text = "Fluent" },
            new DropDownData { ID = "fluent2", Text = "Fluent 2" },
            new DropDownData { ID = "bootstrap4", Text = "Bootstrap v4" },
            new DropDownData { ID = "bootstrap5", Text = "Bootstrap v5" },
            new DropDownData { ID = "bootstrap5.3", Text = "Bootstrap v5.3" },
#else
            new DropDownData { ID = "fluent2", Text = "Fluent 2" },
            new DropDownData { ID = "bootstrap5.3", Text = "Bootstrap 5" },
#endif
#if RELEASE && STAGING
            new DropDownData { ID = "tailwind", Text = "Tailwind CSS" },
            new DropDownData { ID = "tailwind3", Text = "Tailwind3 CSS" },
#else
            new DropDownData { ID = "tailwind3", Text = "Tailwind CSS" },
#endif
#if RELEASE && STAGING
           new DropDownData { ID = "fabric", Text = "Fabric" },
           new DropDownData { ID = "highcontrast", Text = "High Contrast" },
#endif
            new DropDownData { ID = "fluent2-highcontrast", Text = "Fluent 2 High Contrast" },
        };

        /// <summary>
        /// Returns the current theme mode from the url.
        /// </summary>
        /// <param name="path">Current url need to be parsed for getting the theme mode.</param>
        public static string GetThemeMode(string path)
        {
            var uri = new Uri(path);
            string? themeMode = HttpUtility.ParseQueryString(uri.Query).Get("theme");
            themeMode = themeMode == null ? "Light Mode" : !themeMode.Contains("-dark", StringComparison.Ordinal) ? "Light Mode" : "Dark Mode";
            return themeMode;
        }

        public static IReadOnlyList<DropDownData> ThemeModeOption { get; } = new List<DropDownData> {
            new DropDownData { ID = "dark", Text = "Dark Mode" },
            new DropDownData { ID = "light", Text = "Light Mode" }
        };
    }

    /// <summary>
    /// Culture switcher datasource model class.
    /// </summary>
    public class DropDownData
    {
        public string? ID { get; set; }
        public string? Text { get; set; }
    }

    /// <summary>
    /// SplitButton datasource model class.
    /// </summary>
    public class ListData
    {
        public string? ID { get; set; }
        public string? Text { get; set; }
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

        public async Task<List<SearchList>> GetSearchListAsync()
        {
            bool isButtonsAdded = false;
            var searchlist = new List<SearchList>();
            var sampleList = SampleBrowser.SampleList;
            await Task.Run(() => { 
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
            });
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
        public async Task<List<NotificationList>> GetNotificationDataAsync()
        {
            var notificationlist = new List<NotificationList>();
            var sampleList = SampleBrowser.SampleList;
            await Task.Run(() => { 
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
            });
            return notificationlist;
        }

        public async Task<List<NotificationList>> GetComponentNotificationDataAsync()
        {
            var listcomponentnotification = new List<NotificationList>();
            var notificationResultData = new List<NotificationData>();
            var sampleList = SampleBrowser.SampleList;
            await Task.Run(() => { 
            for (int i = 0; i < sampleList.Count; i++)
                {
                    if (sampleList[i].NotificationDescription != null)
                    {
                        listcomponentnotification.Add(new NotificationList { Name = sampleList[i].Name, DefaultSamplePath = sampleList[i].DemoPath, NotificationContent = sampleList[i].NotificationDescription });
                    }
                }
            });
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
        public ShowCaseItem(string header, string content, string imagePath, string demourl, string gitHubLink, string bgColor, bool isServer, bool isWasm)
        {
            this.Header = header;
            this.Content = content;
            this.ImagePath = imagePath;
            this.DemoUrl = demourl;
            this.GitHubLink = gitHubLink;
            this.BgColor = bgColor;
            this.isServer = isServer;
            this.isWasm = isWasm;
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
        public string DemoUrl { get; set; }
        /// <summary>
        /// Specifies the GitHub link of the item.
        /// </summary>
        public string GitHubLink { get; set; }
        /// <summary>
        /// Specifies the Background color of the item.
        /// </summary>
        public string BgColor { get; set; }
        /// <summary>
        /// Specifies the server mode.
        /// </summary>
        public bool isServer { get; set; }
        /// <summary>
        /// Specifies the wasm mode.
        /// </summary>
        public bool isWasm { get; set; }
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
                components.Add(new PopularComponents("Diagram", "diagram", "diagram/flowchart"));
                components.Add(new PopularComponents("Rich Text Editor", "rich-text-editor", "rich-text-editor/overview"));
                components.Add(new PopularComponents("Tree Grid", "tree-grid", "tree-grid/overview"));
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