#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> Sidebar { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None,
                MappingSampleName = "With Default Functionalities"
            },
            new Sample
            {
                Name = "Dock",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/dock",
                FileName = "Dock.razor",
                Type = SampleType.None,
                MappingSampleName = "With Dock"
            },
            new Sample
            {
                Name = "API",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/api",
                FileName = "API.razor",
                MappingSampleName = "With API"
            },
            new Sample
            {
                Name = "Sidebar with ListView",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/sidebar-with-listview",
                FileName = "SidebarWithListView.razor",
                Type = SampleType.None,
                MappingSampleName = "With ListView"
            },
            new Sample
            {
                Name = "Sidebar Menu",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/sidebar-with-menu",
                FileName = "SidebarWithMenu.razor",
                MappingSampleName = "With Menu"
            },
            new Sample
            {
                Name = "Responsive Panel",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/panel-with-responsive",
                FileName = "PanelWithResponsive.razor",
                MappingSampleName = "With Responsive"
            }

        };


        public List<Sample> ContextMenu { get; set; } = new List<Sample>
        {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Context Menu",
                Directory = "Navigations/ContextMenu",
                FileName = "DefaultFunctionalities.razor",
                Url = "context-menu/default-functionalities"
            }
        };
        public List<Sample> MenuBar { get; set; } = new List<Sample>
        {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "DefaultFunctionalities.razor",
                Url = "menu-bar/default-functionalities"
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "DataBinding.razor",
                Url = "menu-bar/data-binding"
            },
            new Sample
            {
                Name = "Scrollable",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Scrollable.razor",
                Url = "menu-bar/scrollable"
            },
            new Sample
            {
                Name = "Template",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Templates.razor",
                Url = "menu-bar/templates"
            },
            new Sample
            {
                Name = "Hamburger Mode",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Hamburger.razor",
                Url = "menu-bar/hamburger-menu"
            },
            new Sample
            {
                Name = "API",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Api.razor",
                Url = "menu-bar/api"
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "KeyboardNavigation.razor",
                Url = "menu-bar/keyboard-navigation"             
            },
            new Sample
            {
                Name = "Toolbar Integration",
                Category = "Use Case",
                Directory = "Navigations/MenuBar",
                FileName = "Toolbar.razor",
                Url = "menu-bar/toolbar-integration",
                Type = SampleType.None
            }
        };

        public List<Sample> Pager { get; set; } = new List<Sample>
        {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Pager",
                Directory = "Navigations/Pager",
                FileName = "DefaultFunctionalities.razor",
                Url = "pager/default-functionalities",
                NotificationDescription = new string[]{ @"Introduce the Pager component in Blazor and it’s commonly used to display the data into page segments." },
                Type = SampleType.None
            },
			new Sample
			{
				Name = "Paging API",
				Category = "Pager",
				Directory = "Navigations/Pager",
				FileName = "PagingAPI.razor",
				Url = "pager/paging-api",
                NotificationDescription = new string[]{ @" Added the demo to show the properties available in Pager component Such as PageSize, CurrentPage, PageCount and TotalItemsCount." },
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Pager Dropdown",
                Category = "Pager",
                Directory = "Navigations/Pager",
                FileName = "PagerDropdown.razor",
                Url = "pager/pager-dropdown",
                NotificationDescription = new string[]{ @" Added the demo to show Pager Dropdown used to dynamically change the number of records displayed in the current page." },
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Pager",
                Directory = "Navigations/Pager",
                FileName = "PagerKeyboardNavigation.razor",
                Url = "pager/keyboard-navigation",
                NotificationDescription = new string[]{ @" Added the demo to show Keyboard shortcut keys can be used to interact with Pager functionality." },
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Pager Template",
                Category = "Pager",
                Directory = "Navigations/Pager",
                FileName = "PagerIntegrateWithGrid.razor",
                Url = "pager/pager-template",
                NotificationDescription = new string[]{ @" Added the demo to show how to customize the pager UI using Template support." },
                Type = SampleType.None
            }
        };

        public List<Sample> Accordion { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Accordion",
                Directory = "Navigations/Accordion",
                FileName = "DefaultFunctionalities.razor",
                Url = "accordion/default-functionalities"
            },
            new Sample
            {
                Name = "Template",
                Category = "Accordion",
                Directory = "Navigations/Accordion",
                Url = "accordion/template",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "Template",
                        FileName = "Template.razor"
                    },
                    new SourceCollection
                    {
                        Id = "NetworkData",
                        FileName = "NetworkData.razor"
                    }
                }
            },
            new Sample
            {
                Name = "Icons",
                Category = "Accordion",
                Directory = "Navigations/Accordion",
                FileName = "Icons.razor",
                Url = "accordion/icons"
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Accordion",
                Directory = "Navigations/Accordion",
                FileName = "KeyboardInteraction.razor",
                Url = "accordion/keyboard-interaction",
                IsHideInMobile = true
            }
        };

        public List<Sample> Toolbar { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "DefaultFunctionalities.razor",
                Url = "toolbar/default-functionalities"
            },
            new Sample
            {
                Name = "Overflow Modes",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "OverflowModes.razor",
                Url = "toolbar/overflow-modes"
            },
            new Sample
            {
                Name = "Alignment",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "Alignment.razor",
                Url = "toolbar/alignment"
            },
            new Sample
            {
                Name = "Template",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "Template.razor",
                Url = "toolbar/template"
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "KeyboardInteraction.razor",
                Url = "toolbar/keyboard-interaction",
                IsHideInMobile = true
            }
        };

        public List<Sample> Tabs { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "DefaultFunctionalities.razor",
                Url = "tabs/default-functionalities"
            },
            new Sample
            {
                Name = "Orientation",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "Orientation.razor",
                Url = "tabs/orientation"
            },
            new Sample
            {
                Name = "Header Icons",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "HeaderIcons.razor",
                Url = "tabs/header-icons"
            },
            new Sample
            {
                Name = "Responsive Modes",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "ResponsiveModes.razor",
                Url = "tabs/responsive-modes"
            },
            new Sample
            {
                Name = "Dynamic Tabs",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "DynamicTabs.razor",
                Url = "tabs/dynamic-tabs"
            },
            new Sample
            {
                Name = "Nested Tabs",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "NestedTabs.razor",
                Url = "tabs/nested-tabs"
            },
            new Sample
            {
                Name = "Wizard",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "Wizard.razor",
                Url = "tabs/wizard"
            },
            new Sample
            {
                Name = "Drag and Drop",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "DragAndDrop.razor",
                Url = "tabs/drag-and-drop"
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "KeyboardInteraction.razor",
                Url = "tabs/keyboard-interaction",
                IsHideInMobile = true
            }
        };
        public List<Sample> TreeView { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default Functionalities",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Treeview Example - Syncfusion Demos",
                HeaderText = "Blazor TreeView Example",
                MetaDescription = "This Blazor TreeView example demonstrates the Default Functionalities in the Blazor TreeView Component. Explore here for more details."
            },
            new Sample
            {
                Name = "Icons and Images",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/icons-and-images",
                FileName = "IconsandImages.razor"
            },
            new Sample
            {
                Name = "Lazy Loading",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/lazy-loading",
                Type = SampleType.None,
                FileName = "LazyLoading.razor"
            },
            new Sample
            {
                Name = "Checkbox",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/checkbox",
                Type = SampleType.None,
                FileName = "CheckBox.razor"
            },
             new Sample
            {
                Name = "Node Editing",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/node-editing",
                FileName = "NodeEditing.razor"
            },
             new Sample
            {
                Name = "Multiple Selection",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/multiple-selection",
                Type = SampleType.None,
                FileName = "MultipleSelection.razor"
            },
            new Sample
            {
                Name = "Drag and Drop",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/drag-and-drop",
                Type = SampleType.None,
                FileName = "DragAndDrop.razor"
            },
            new Sample
            {
                Name = "Template",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/template",
                FileName = "Template.razor"
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/keyboard-navigation",
                Type = SampleType.None,
                FileName = "KeyboardNavigation.razor"
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/ui-virtualization",
                Type = SampleType.New,
                FileName = "UIVirtualization.razor",
                 NotificationDescription = new string[]{ @" Added the Virtualization support for the TreeView" }
            },
              new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Navigations/TreeView",
                Url = "treeview/local-data",
                FileName = "LocalData.razor"
            },
               new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Navigations/TreeView",
                Url = "treeview/remote-data",
                FileName = "RemoteData.razor"
            }
        };
        public List<Sample> FileManager { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/overview",
                FileName = "Overview.razor"
            },
            new Sample
            {
                Name = "Flat Data",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/flat-data",
                FileName = "FlatData.razor",
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "FlatData",
                        FileName = "FlatData.razor"
                    },
                    new SourceCollection
                    {
                        Id = "FileManagerService",
                        FileName = "FileManagerService.cs"
                    },
                },
            },
             new Sample
            {
                Name = "Custom Thumbnails",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/custom-thumbnail",
                FileName = "CustomThumbnail.razor"
            },
             new Sample
            {
                Name = "API",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/api",
                FileName = "API.razor"
            },
            new Sample
            {
                Name = "Drag and Drop",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/drag-and-drop",
                FileName = "DragAndDrop.razor"
            },
            new Sample
            {
                Name = "Directory Upload",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/directory-upload",
                FileName = "DirectoryUpload.razor"
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/virtualization",
                FileName = "Virtualization.razor",
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/keyboard-navigation",
                Type = SampleType.None,
                FileName = "KeyboardNavigation.razor"
            },
            //new Sample
            //{
            //    Name = "File Upload",
            //    Category = "Use Case",
            //    Directory = "Navigations/FileManager",
            //    Url = "file-manager/file-upload",
            //    Type = SampleType.New,
            //    FileName = "FileUpload.razor"
            //},
		new Sample
            {
                Name = "Access Control",
                Category = "Use Case",
                Directory = "Navigations/FileManager",
                Url = "file-manager/access-control",
                FileName = "AccessControl.razor",
                NotificationDescription = new string[]{ @"Showcases the access control permissions enabled for specific folders in File Manager based on user role." }
            },
            new Sample
            {
                Name = "Azure Blob Storage",
                Category = "Cloud Service Providers",
                Directory = "Navigations/FileManager",
                Url = "file-manager/azure",
                FileName = "Azure.razor"
            },
            //new Sample
            //{
            //    Name = "SQL Database Provider",
            //    Category = "Cloud Service Providers",
            //    Directory = "Navigations/FileManager",
            //    Url = "file-manager/sql-server-provider",
            //    Type = SampleType.None,
            //    FileName = "SQL.razor"
            //},
            // new Sample
            // {
            //     Name = "NodeJS File Provider",
            //     Category = "Cloud Service Providers",
            //     Directory = "Navigations/FileManager",
            //     Url = "file-manager/nodejs-file-provider",
            //     Type = SampleType.New,
            //     FileName = "NodeJS.razor",
            //     NotificationDescription = new string[]
            //     {
            //         @"Added the NodeJS file provider sample for the File Manager component."
            //     }
            // },
            new Sample
            {
                Name = "AmazonS3 File Provider",
                Category = "Cloud Service Providers",
                Directory = "Navigations/FileManager",
                Url = "file-manager/amazon-s3-provider",
                Type = SampleType.None,
                FileName = "AmazonS3.razor"
            },
            //new Sample
            //{
            //    Name = "Firebase File Provider",
            //    Category = "Cloud Service Providers",
            //    Directory = "Navigations/FileManager",
            //    Url = "file-manager/firebase",
            //    Type = SampleType.New,
            //    FileName = "Firebase.razor"
            //},
            // new Sample
            // {
            //     Name = "FTP File Provider",
            //     Category = "Cloud Service Providers",
            //     Directory = "Navigations/FileManager",
            //     Url = "file-manager/ftp-file-provider",
            //     Type = SampleType.None,
            //     FileName = "FTP.razor"
            // },
            new Sample
            {
                Name = "IBM Cloud File Provider",
                Category = "Cloud Service Providers",
                Directory = "Navigations/FileManager",
                Url = "file-manager/ibm-cos-node-file-provider",
                Type = SampleType.None,
                FileName = "IBM.razor"
            }
        };
         public List<Sample> BreadCrumb { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/default-functionalities",
                FileName = "DefaultFunctionalities.razor"
            },
             new Sample
            {
                Name = "Bind to Location",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/bind-to-location",
                FileName = "BindToLocation.razor"
            },
            new Sample
            {
                Name = "Template and Customization",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/template-and-customization",
                FileName = "TemplateAndCustomization.razor"
            },
            new Sample
            {
                Name = "Overflow Modes",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/overflow-modes",
                FileName = "OverflowModes.razor"
            },
            new Sample
            {
                Name = "Events",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/events",
                FileName = "Events.razor"
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/keyboard-navigation",
                FileName = "KeyboardNavigation.razor"
            },
            new Sample
            {
                Name = "Address Bar",
                Category = "Use Case",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/address-bar",
                FileName = "AddressBar.razor"
            }
        };
        public List<Sample> Carousel { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Carousel",
                Directory = "Navigations/Carousel",
                Url = "carousel/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MappingSampleName = "With Default Functionalities",
            },
            new Sample
            {
                Name = "Templates",
                Category = "Carousel",
                Directory = "Navigations/Carousel",
                Url = "carousel/templates",
                FileName = "Templates.razor",
                MappingSampleName = "With Templates",
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "Carousel",
                Directory = "Navigations/Carousel",
                Url = "carousel/data-binding",
                FileName = "DataBinding.razor",
                Type = SampleType.None,
                MappingSampleName = "With Data Binding",
            },
            new Sample
            {
                Name = "Keyboard Interactions",
                Category = "Carousel",
                Directory = "Navigations/Carousel",
                Url = "carousel/keyboard-interactions",
                FileName = "KeyboardInteractions.razor",
                MappingSampleName = "With Keyboard Interactions",
                IsHideInMobile = true
            },
            new Sample
            {
                Name = "Partial Visible",
                Category = "Carousel",
                Directory = "Navigations/Carousel",
                Url = "carousel/partial-visible",
                FileName = "PartialVisible.razor",
                MappingSampleName = "With partial visible",
            },
            new Sample
            {
                Name = "Indicator Type",
                Category = "Carousel",
                Directory = "Navigations/Carousel",
                Url = "carousel/indicator-type",
                FileName = "IndicatorType.razor",
                MappingSampleName = "With Indicator Types",
                NotificationDescription = new string[]{ @"Added a demo to showcase the indicator types feature in Carousel." }
            },
            new Sample
            {
                Name = "API",
                Category = "Carousel",
                Directory = "Navigations/Carousel",
                Url = "carousel/api",
                FileName = "API.razor",
                MappingSampleName = "With API",
            }
        };

        public List<Sample> AppBar { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "AppBar",
                Directory = "Navigations/AppBar",
                Url = "appbar/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MappingSampleName = "With Default Functionalities"
            },
            new Sample
            {
                Name = "Color",
                Category = "AppBar",
                Directory = "Navigations/AppBar",
                Url = "appbar/color",
                FileName = "Color.razor",
                MappingSampleName = "With Color"
            }
        };

	    public List<Sample> Stepper { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Stepper",
                Directory = "Navigations/Stepper",
                Url = "stepper/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Orientation",
                Category = "Stepper",
                Directory = "Navigations/Stepper",
                Url = "stepper/orientation",
                FileName = "Orientation.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Linear Flow",
                Category = "Stepper",
                Directory = "Navigations/Stepper",
                Url = "stepper/linear-flow",
                FileName = "Linear.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Validation",
                Category = "Stepper",
                Directory = "Navigations/Stepper",
                Url = "stepper/validation",
                FileName = "Validation.razor",
                Type = SampleType.None
            }
        };
    }
}
