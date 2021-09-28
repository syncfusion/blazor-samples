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
                Type = SampleType.Updated,
                MappingSampleName = "With Default Functionalities",
                NotificationDescription = new string[]
                {
                    @"Updated the default functionalities sample for Sidebar in which the Sidebar is populated like webmail with folder structure."
                }
            },
            new Sample
            {
                Name = "Dock",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/dock",
                FileName = "Dock.razor",
                Type = SampleType.Updated,
                MappingSampleName = "With Dock",
                NotificationDescription = new string[]
                {
                    @"Updated the demo with dock state, which shown while clicking on the hamburger menu icon."
                }
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
                Type = SampleType.Updated,
                MappingSampleName = "With ListView",
                NotificationDescription = new string[]
                {
                    @"Updated the demo with template of the ListView component"
                }
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
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Context Menu",
                Directory = "Navigations/ContextMenu",
                FileName = "KeyboardNavigation.razor",
                Url = "context-menu/keyboard-navigation",
                Type = SampleType.New
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
                Url = "menu-bar/keyboard-navigation",
                Type = SampleType.New
             
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
                Type = SampleType.New,
                NotificationDescription = new string[]
                {
                    @"Added a demo for the keyboard accessibility of the Accordion component."
                }
            }
        };

        public List<Sample> Toolbar { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "DefaultFunctionalities.razor",
                Url = "toolbar/default-functionalities",
                Type = SampleType.Updated
            },
            new Sample
            {
                Name = "Popup",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "Popup.razor",
                Url = "toolbar/popup"
            },
            new Sample
            {
                Name = "Alignment",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "Alignment.razor",
                Url = "toolbar/alignment",
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "KeyboardInteraction.razor",
                Url = "toolbar/keyboard-interaction",
                Type = SampleType.New,
                NotificationDescription = new string[]
                {
                    @"Added a demo for keyboard accessibility of the Toolbar component."
                }
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
                Name = "Responsive Modes",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "ResponsiveModes.razor",
                Url = "tabs/responsive-modes"
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
                Type = SampleType.New,
                NotificationDescription = new string[]
                {
                    @"Added a demo for keyboard accessibility of the Tabs component."
                }
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
                Type = SampleType.New,
                FileName = "LazyLoading.razor",
                NotificationDescription = new string[]
                {
                    @"Added a demo to showcase lazy loading feature of the TreeView component."
                }
            },
            new Sample
            {
                Name = "Checkbox",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/checkbox",
                Type = SampleType.Updated,
                FileName = "CheckBox.razor",
                NotificationDescription = new string[]
                {
                    @"Updated the demo by including option to display the checked item`s id and text."
                }
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
                Type = SampleType.Updated,
                FileName = "MultipleSelection.razor",
                NotificationDescription = new string[]
                {
                    @"Updated the demo that displays the selected item’s id and text of the TreeView node."
                }
            },
            new Sample
            {
                Name = "Drag and Drop",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/drag-and-drop",
                Type = SampleType.New,
                FileName = "DragAndDrop.razor",
                NotificationDescription = new string[]
                {
                    @"Added a demo to demonstrates the drag-and-drop behavior of the TreeView component."
                }
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
                Type = SampleType.New,
                FileName = "KeyboardNavigation.razor",
                NotificationDescription = new string[]
                {
                    @"Added a demo for keyboard accessibility of the TreeView component."
                }
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
                Name = "Keyboard Navigation",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/keyboard-navigation",
                Type = SampleType.New,
                FileName = "KeyboardNavigation.razor",
                NotificationDescription = new string[]
                {
                    @"Added a demo for keyboard accessibility of the File Manager component."
                }
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
                Name = "Azure Blob Storage",
                Category = "Cloud Service Providers",
                Directory = "Navigations/FileManager",
                Url = "file-manager/azure",
                FileName = "Azure.razor"
            },
            new Sample
            {
                Name = "SQL Database Provider",
                Category = "Cloud Service Providers",
                Directory = "Navigations/FileManager",
                Url = "file-manager/sql-server-provider",
                Type = SampleType.New,
                FileName = "SQL.razor",
                NotificationDescription = new string[]
                {
                    @"Added a demo to showcase the SQL file provider of the File Manager component."
                }
            },
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
                Type = SampleType.New,
                FileName = "AmazonS3.razor",
                NotificationDescription = new string[]
                {
                    @"Added a demo to showcase the Amazon S3 file provider of the File Manager component."
                }
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
            new Sample
            {
                Name = "FTP File Provider",
                Category = "Cloud Service Providers",
                Directory = "Navigations/FileManager",
                Url = "file-manager/ftp-file-provider",
                Type = SampleType.New,
                FileName = "FTP.razor",
                NotificationDescription = new string[]
                {
                    @"Added a demo to showcase the FTP file provider of the File Manager component."
                }
            },
            new Sample
            {
                Name = "IBM Cloud File Provider",
                Category = "Cloud Service Providers",
                Directory = "Navigations/FileManager",
                Url = "file-manager/ibm-cos-node-file-provider",
                Type = SampleType.New,
                FileName = "IBM.razor",
                NotificationDescription = new string[]
                {
                    @"Added a demo to showcase the IBM file provider of the File Manager component."
                }
            }
        };
         public List<Sample> BreadCrumb { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                NotificationDescription = new string[] {
                    @"Introduced Breadcrumb component in Blazor which is a graphical user interface (UI) that helps to identify or highlight the current location within a hierarchical structure of websites."
                }
            },
             new Sample
            {
                Name = "Bind to Location",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/bind-to-location",
                FileName = "BindToLocation.razor",
                NotificationDescription = new string[] {
                    @"Added a demo to demonstrates items rendering based on current URL location and also using static URL in the Breadcrumb component."
                }
            },
            new Sample
            {
                Name = "Template and Customization",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/template-and-customization",
                FileName = "TemplateAndCustomization.razor",
                NotificationDescription = new string[] {
                    @"Added a demo to demonstrates customization of the Breadcrumb items."
                }
            },
            new Sample
            {
                Name = "Events",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/events",
                FileName = "Events.razor",
                NotificationDescription = new string[] {
                    @"Added a demo to know more about Breadcrumb component's events."
                }
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/keyboard-navigation",
                FileName = "KeyboardNavigation.razor",
                NotificationDescription = new string[] {
                    @"Added a demo for keyboard accessibility of the Breadcrumb component."
                }
            },
            new Sample
            {
                Name = "Address Bar",
                Category = "Use Case",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/address-bar",
                FileName = "AddressBar.razor",
                NotificationDescription = new string[] {
                    @"Added a demo to design address bar using the Menu and Breadcrumb component."
                }
            }
        };
    }
}
