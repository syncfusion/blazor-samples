using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Sidebar { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "Sidebar/DefaultFunctionalities",
                FileName = "Default.razor"
            },
            new Sample
            {
                Name = "Dock",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "Sidebar/Dock",
                FileName = "SidebarDock.razor"
            },
            new Sample
            {
                Name = "API",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "Sidebar/API",
                FileName = "SidebarAPI.razor"
            },
            new Sample
            {
                Name = "Sidebar with ListView",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "Sidebar/SidebarWithListView",
                FileName = "SidebarList.razor"
            },
            new Sample
            {
                Name = "Sidebar Menu",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "Sidebar/SidebarWithMenu",
                FileName = "SidebarMenu.razor"
            },
            new Sample
            {
                Name = "Responsive Panel",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "Sidebar/PanelWithResponsive",
                FileName = "ResponsivePanel.razor"
            }

        };


        public List<Sample> ContextMenu { get; set; } = new List<Sample>
        {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "ContextMenu",
                Directory = "Navigations/ContextMenu",
                FileName = "DefaultFunctionalities.razor",
                Url = "ContextMenu/DefaultFunctionalities"
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
                Url = "MenuBar/DefaultFunctionalities"
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "DataBinding.razor",
                Url = "MenuBar/DataBinding"
            },
            new Sample
            {
                Name = "Scrollable",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Scrollable.razor",
                Url = "MenuBar/Scrollable"
            },
            new Sample
            {
                Name = "Template",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Templates.razor",
                Url = "MenuBar/Templates"
            },
            new Sample
            {
                Name = "Hamburger Mode",
                Category = "Menu Bar",
                Directory = "Navigations/Hamburger",
                FileName = "Hamburger.razor",
                Url = "MenuBar/Hamburger"
            },
            new Sample
            {
                Name = "API",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Api.razor",
                Url = "MenuBar/Api"
            },
            new Sample
            {
                Name = "Toolbar Integration",
                Category = "Use Case",
                Directory = "Navigations/MenuBar",
                FileName = "Toolbar.razor",
                Url = "MenuBar/Toolbar"
            }

        };

        public List<Sample> Accordion { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Accordion",
                Directory = "Navigations/Accordion",
                FileName = "DefaultFunctionalities.razor",
                Url = "Accordion/DefaultFunctionalities",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Template",
                Category = "Accordion",
                Directory = "Navigations/Accordion",
                Url = "Accordion/Template",
                Type = SampleType.New,
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
                 Url = "Accordion/Icons",
                Type = SampleType.New
            }
        };
		
		public List<Sample> Toolbar { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                Url = "Toolbar/DefaultFunctionalities"
            },
            new Sample
            {
                Name = "Popup",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "Popup.razor",
                Type = SampleType.New,
                Url = "Toolbar/Popup"
            },
            new Sample
            {
                Name = "Alignment",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "Alignment.razor",
                Type = SampleType.New,
                Url = "Toolbar/Alignment"
            }
        };

        public List<Sample> Tab { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Tab",
                Directory = "Navigations/Tab",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                Url = "Tab/DefaultFunctionalities"
            },
             new Sample
             {
                 Name = "Orientation",
                 Category = "Tab",
                 Directory = "Navigations/Tab",
                 FileName = "Orientation.razor",
                 Type = SampleType.New,
                 Url = "Tab/Orientation"
             },
            new Sample
            {
                Name = "Responsive Modes",
                Category = "Tab",
                Directory = "Navigations/Tab",
                FileName = "ResponsiveModes.razor",
                Type = SampleType.New,
                Url = "Tab/ResponsiveModes"
            },
            new Sample
            {
                Name = "Wizard",
                Category = "Tab",
                Directory = "Navigations/Tab",
                FileName = "Wizard.razor",
                Type = SampleType.New,
                Url = "Tab/Wizard"
            }
        };
        public List<Sample> TreeView { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default Functionalities",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "TreeView/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Icons and Images",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "TreeView/IconsandImages",
                FileName = "IconsandImages.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "CheckBox",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "TreeView/CheckBox",
                FileName = "CheckBox.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Node Editing",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "TreeView/NodeEditing",
                FileName = "NodeEditing.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Multiple Selection",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "TreeView/MultipleSelection",
                FileName = "MultipleSelection.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Template",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "TreeView/Template",
                FileName = "Template.razor",
                Type = SampleType.New
            },
              new Sample
            {
                Name = "LocalData",
                Category = "Data Binding",
                Directory = "Navigations/TreeView",
                Url = "TreeView/LocalData",
                FileName = "LocalData.razor",
                Type = SampleType.New
            },
               new Sample
            {
                Name = "RemoteData",
                Category = "Data Binding",
                Directory = "Navigations/TreeView",
                Url = "TreeView/RemoteData",
                FileName = "RemoteData.razor",
                Type = SampleType.New
            }

        };
        public List<Sample> FileManager { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "FileManager/Overview",
                FileName = "Overview.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Custom Thumbnails",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "FileManager/CustomThumbnail",
                FileName = "CustomThumbnail.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "API",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "FileManager/API",
                FileName = "API.razor"
            },
            new Sample
            {
                Name = "Drag and Drop",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "FileManager/DragAndDrop",
                FileName = "DragAndDrop.razor"
            },
            new Sample
            {
                Name = "Azure Blob Storage",
                Category = "Cloud Service Providers",
                Directory = "Navigations/FileManager",
                Url = "FileManager/Azure",
                FileName = "Azure.razor"
            }

        };

    }
}
