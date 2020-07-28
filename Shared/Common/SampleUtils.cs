using System;
using System.Collections.Generic;
using System.Web;
using Syncfusion.Blazor.Navigations;

namespace blazor_samples.Shared
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

        /// <summary>
        /// Returns the url with current selected theme query string.
        /// </summary>
        /// <param name="url">Current url need to be validated.</param>
        /// <param name="themeName">Selected theme name to be added in the query string.</param>
        /// <returns>Returns class string.</returns>
        public static string GetThemeUrl(string url, string themeName)
        {
            if (url.Contains("?theme="))
            {
                string[] splittedUrl = url.Split("?theme=");
                url = splittedUrl[0];
            }
            url += "?theme=" + themeName;
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
            themeName = themeName != null ? themeName : "bootstrap4";
            return themeName;
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
    /// Theme switcher datasource model class.
    /// </summary>
    public class ThemeSwitcher
    {
        /// <summary>
        /// Returns the list of themes.
        /// </summary>
        public List<MenuItem> GetThemeList()
        {
            return new List<MenuItem>
            {
                new MenuItem { Id = "material", Text = "Material" },
                new MenuItem { Id = "fabric", Text = "Fabric" },
                new MenuItem { Id = "bootstrap", Text = "Bootstrap" },
                new MenuItem { Id = "bootstrap4", Text = "Bootstrap v4" },
                new MenuItem { Id = "highcontrast", Text = "High Contrast" }
            };
        }
        /// <summary>
        /// Returns the list of themes for mobile theme switcher.
        /// </summary>
        public List<DropDownData> GetThemeData()
        {
            var data = GetThemeList();
            var themeData = new List<DropDownData>();
            foreach(var themeItem in data)
            {
                themeData.Add(new DropDownData() { ID = themeItem.Id, Text = themeItem.Text });
            }
            return themeData;
        }
    }

    /// <summary>
    /// Carousel component's data model class.
    /// </summary>
    public class CarouselItem
    {
        /// <summary>
        /// Constructor for updating properties.
        /// </summary>
        public CarouselItem(string Header, string Content, string ImagePath, string HyperLink)
        {
            this.Header = Header;
            this.Content = Content;
            this.ImagePath = ImagePath;
            this.HyperLink = HyperLink;
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
        public string HyperLink { get; set; }
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