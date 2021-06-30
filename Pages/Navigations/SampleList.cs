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
                FileName = "SidebarDefaultFunctionalities.razor",
                MappingSampleName = "With Default Functionalities"
            },
            new Sample
            {
                Name = "Dock",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/dock",
                FileName = "SidebarDock.razor",
                MappingSampleName = "With Dock"
            },
            new Sample
            {
                Name = "API",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/api",
                FileName = "SidebarAPI.razor",
                MappingSampleName = "With API"
            },
            new Sample
            {
                Name = "Sidebar with ListView",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/sidebar-with-listview",
                FileName = "SidebarList.razor",
                MappingSampleName = "With ListView"
            },
            new Sample
            {
                Name = "Sidebar Menu",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/sidebar-with-menu",
                FileName = "SidebarMenu.razor",
                MappingSampleName = "With Menu"
            },
            new Sample
            {
                Name = "Responsive Panel",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/panel-with-responsive",
                FileName = "ResponsivePanel.razor",
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
                Name = "Toolbar Integration",
                Category = "Use Case",
                Directory = "Navigations/MenuBar",
                FileName = "Toolbar.razor",
                Url = "menu-bar/toolbar-integration"
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
                MetaDescription = "This Blazor TreeView example demonstrates the Default Functionalities in Blazor TreeView Component.Explore here for more details."
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
                Name = "Checkbox",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/checkbox",
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
                FileName = "MultipleSelection.razor"
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
                Name = "Azure Blob Storage",
                Category = "Cloud Service Providers",
                Directory = "Navigations/FileManager",
                Url = "file-manager/azure",
                FileName = "Azure.razor"
            }

        };

    }
}
