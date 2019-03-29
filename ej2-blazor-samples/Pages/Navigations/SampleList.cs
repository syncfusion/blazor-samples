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
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New
            },                      
            new Sample
            {
                Name = "Dock",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "Sidebar/Dock",
                FileName = "Dock.cshtml",
                Type = SampleType.New
            },          
            new Sample
            {
                Name = "Sidebar with ListView",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "Sidebar/SidebarWithListView",
                FileName = "SidebarWithListView.cshtml",
                Type = SampleType.New
            },         
            new Sample
            {
                Name = "Sidebar Menu",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "Sidebar/SidebarWithMenu",
                FileName = "SidebarWithMenu.cshtml",
                Type = SampleType.New
            },           
            new Sample
            {
                Name = "Responsive Panel",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "Sidebar/PanelWithResponsive",
                FileName = "PanelWithResponsive.cshtml",
                Type = SampleType.New
            }           
        };

        public List<Sample> ContextMenu { get; set; } = new List<Sample>
        {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "ContextMenu",
                Directory = "Navigations/ContextMenu",
                FileName = "DefaultFunctionalities.cshtml",
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
                FileName = "DefaultFunctionalities.cshtml",
                Url = "MenuBar/DefaultFunctionalities"
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "DataBinding.cshtml",
                Url = "MenuBar/DataBinding"
            }
        };

        public List<Sample> Accordion { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Accordion",
                Directory = "Navigations/Accordion",
                FileName = "DefaultFunctionalities.cshtml",
                 Url = "Accordion/DefaultFunctionalities",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Icons",
                Category = "Accordion",
                Directory = "Navigations/Accordion",
                FileName = "Icons.cshtml",
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
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New,
                Url = "Toolbar/DefaultFunctionalities"
            },
            new Sample
            {
                Name = "Popup",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "Popup.cshtml",
                Type = SampleType.New,
                Url = "Toolbar/Popup"
            }
        };

        public List<Sample> Tab { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Tab",
                Directory = "Navigations/Tab",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New,
                 Url = "Tab/DefaultFunctionalities"
            }
        };
        public List<Sample> TreeView { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "TreeView/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "CheckBox",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "TreeView/CheckBox",
                FileName = "CheckBox.cshtml",
                Type = SampleType.New
            }
        };
         public List<Sample> FileManager { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "FileManager",
                Directory = "Navigations/FileManager",
                Url = "FileManager/Overview",
                FileName = "Overview.cshtml",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "CustomThumbnail",
                Category = "FileManager",
                Directory = "Navigations/FileManager",
                Url = "FileManager/CustomThumbnail",
                FileName = "CustomThumbnail.cshtml",
                Type = SampleType.New
            }
        };
    }
}
