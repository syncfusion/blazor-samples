#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
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
                MetaTitle = "Blazor Sidebar Component | Default Functionalities | Syncfusion",
                HeaderText = "Blazor Sidebar Example - Default Functionalities",
                MetaDescription = "Blazor Sidebar demo shows the default functionalities of the sidebar component. Explore the collapsible side content panel with various configuration options.",
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
                MetaTitle = "Blazor Sidebar with Dock Mode | Auto-Collapse | Syncfusion",
                HeaderText = "Blazor Sidebar Example - Dock Mode",
                MetaDescription = "This Blazor Sidebar example shows the dock mode functionality. Learn how to configure a sidebar that collapses to a minimal width with icons when not in use.",
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
                MetaTitle = "Blazor Sidebar API Usage | Methods & Properties | Syncfusion",
                HeaderText = "Blazor Sidebar Example - API Configuration",
                MetaDescription = "Blazor Sidebar demo shows various API methods and properties. Explore how to programmatically control sidebar behavior, including open, close, toggle operation.",
                MappingSampleName = "With API"
            },
            new Sample
            {
                Name = "Sidebar with ListView",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/sidebar-with-listview",
                FileName = "SidebarWithListView.razor",
                MetaTitle = "Blazor Sidebar with ListView | Navigation Menu | Syncfusion",
                HeaderText = "Blazor Sidebar Example - Integration with ListView",
                MetaDescription = "Blazor Sidebar demo shows the integration of ListView component within a sidebar. Learn how to create a navigation menu with collapsible sidebar functionality.",
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
                MetaTitle = "Blazor Sidebar with Menu | Navigation Panel | Syncfusion",
                HeaderText = "Blazor Sidebar Example - Integration with Menu",
                MetaDescription = "Blazor Sidebar demo shows how to integrate a menu control within a sidebar. Create interactive navigation panel with hierarchical menu item in collapse sidebar.",
                MappingSampleName = "With Menu"
            },
            new Sample
            {
                Name = "Responsive Panel",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/panel-with-responsive",
                FileName = "PanelWithResponsive.razor",
                MetaTitle = "Blazor Sidebar Responsive Panel | Adaptive Layout | Syncfusion",
                HeaderText = "Blazor Sidebar Example - Responsive Panel",
                MetaDescription = "This demo shows how to create responsive panels that adapt to different screen sizes. It implement a sidebar that changes behavior based on viewport dimensions.",
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
                Url = "context-menu/default-functionalities",
                MetaTitle = "Blazor Context Menu Component | Default Features | Syncfusion",
                HeaderText = "Blazor Context Menu Example - Default Functionalities",
                MetaDescription = "This Blazor Context Menu example demonstrates how to implement the right-click context menus with the nested navigation options in your web application."
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
                Url = "menu-bar/default-functionalities",
                MetaTitle = "Blazor Menu Bar Component | Default Features | Syncfusion",
                HeaderText = "Blazor Menu Bar Example - Default Functionalities",
                MetaDescription = "Blazor Menu Bar demo shows the default functionality of the control. How to create horizontal navigation menus with dropdown options for your web applications."
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "DataBinding.razor",
                Url = "menu-bar/data-binding",
                MetaTitle = "Blazor Menu Bar with Data Binding | Dynamic Menus | Syncfusion",
                HeaderText = "Blazor Menu Bar Example - Data Binding",
                MetaDescription = "This Blazor Menu Bar demo shows how to bind data to the menu component. Learn to create dynamic menus from various data source including arrays and remote data."
            },
            new Sample
            {
                Name = "Scrollable",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Scrollable.razor",
                Url = "menu-bar/scrollable",
                MetaTitle = "Blazor Menu Bar with Scrolling | Overflow Items | Syncfusion",
                HeaderText = "Blazor Menu Bar Example - Scrollable Menu",
                MetaDescription = "This demo shows how to implement scrollable menus. Learn to handle large numbers of menu items with scrolling functionality for improved user experience."
            },
            new Sample
            {
                Name = "Template",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Templates.razor",
                Url = "menu-bar/templates",
                MetaTitle = "Blazor Menu Bar Templates | Customized Items | Syncfusion",
                HeaderText = "Blazor Menu Bar Example - Item Templates",
                MetaDescription = "This demo shows how to customize menu items using templates. Learn to add icons, images, and custom HTML content to create visually appealing navigation menus."
            },
            new Sample
            {
                Name = "Hamburger Mode",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Hamburger.razor",
                Url = "menu-bar/hamburger-menu",
                MetaTitle = "Blazor Menu Bar with Hamburger Mode | Mobile View | Syncfusion",
                HeaderText = "Blazor Menu Bar Example - Hamburger Menu",
                MetaDescription = "This Blazor Menu Bar example demonstrates how to implement a hamburger menu and create responsive menus that transform into hamburger style on smaller screens."
            },
            new Sample
            {
                Name = "API",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Api.razor",
                Url = "menu-bar/api",
                MetaTitle = "Blazor Menu Bar API Usage | Methods & Properties | Syncfusion",
                HeaderText = "Blazor Menu Bar Example - API Configuration",
                MetaDescription = "This demo shows the usage of various APIs to control menu behavior. Learn to programmatically manipulate menu items, enable/disable options, and handle events."
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "KeyboardNavigation.razor",
                Url = "menu-bar/keyboard-navigation",
                MetaTitle = "Blazor Menu Bar Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor Menu Bar Example - Keyboard Navigation",
                MetaDescription = "This Blazor Menu Bar example shows how to improve accessibility by implementing keyboard shortcuts for navigating through menu items without mouse interaction."             
            },
            new Sample
            {
                Name = "Toolbar Integration",
                Category = "Use Case",
                Directory = "Navigations/MenuBar",
                FileName = "Toolbar.razor",
                Url = "menu-bar/toolbar-integration",
                MetaTitle = "Blazor Menu Bar with Toolbar Integration | Combined UI | Syncfusion",
                HeaderText = "Blazor Menu Bar Example - Toolbar Integration",
                MetaDescription = "This demo shows how to integrate with Toolbar component. Create a comprehensive navigation and action interface similar to modern applications like MS Office.",
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
                MetaTitle = "Blazor Pager Component | Default Functionalities | Syncfusion",
                HeaderText = "Blazor Pager Example - Default Functionalities",
                MetaDescription = "This Blazor Pager demo shows the default functionality of the component. Learn how to implement pagination with configurable page size and navigation controls.",
                Type = SampleType.None
            },
			new Sample
			{
				Name = "Paging API",
				Category = "Pager",
				Directory = "Navigations/Pager",
				FileName = "PagingAPI.razor",
				Url = "pager/paging-api",
                MetaTitle = "Blazor Pager API Usage | Pagination Methods | Syncfusion",
                HeaderText = "Blazor Pager Example - API Configuration",
                MetaDescription = "This demo shows how to use various API methods and properties for pagination. Learn to programmatically control page navigation and customize pager behavior.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Pager Dropdown",
                Category = "Pager",
                Directory = "Navigations/Pager",
                FileName = "PagerDropdown.razor",
                Url = "pager/pager-dropdown",
                MetaTitle = "Blazor Pager with Dropdown | Page Size Selection | Syncfusion",
                HeaderText = "Blazor Pager Example - Dropdown Integration",
                MetaDescription = "This Blazor Pager demo shows how to implement a dropdown for page size selection. Provide users with options to change the number of items displayed per page.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Pager",
                Directory = "Navigations/Pager",
                FileName = "PagerKeyboardNavigation.razor",
                Url = "pager/keyboard-navigation",
                MetaTitle = "Blazor Pager Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor Pager Example - Keyboard Navigation",
                MetaDescription = "This Blazor Pager example demonstrates how to improve accessibility by implementing keyboard shortcuts to navigate via pages without using mouse interactions.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Pager Template",
                Category = "Pager",
                Directory = "Navigations/Pager",
                FileName = "PagerIntegrateWithGrid.razor",
                Url = "pager/pager-template",
                MetaTitle = "Blazor Pager Template Customization | Grid Integration | Syncfusion",
                HeaderText = "Blazor Pager Example - Custom Templates",
                MetaDescription = "This Blazor Pager demo shows how to create custom templates for pagination. Learn to integrate pager with data grid and customize its appearance with templates.",
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
                Url = "accordion/default-functionalities",
                MetaTitle = "Blazor Accordion Component | Default Functionalities | Syncfusion",
                HeaderText = "Blazor Accordion Example - Default Functionalities",
                MetaDescription = "This demo shows the default functionality of the component. Learn how to create collapsible content panels for organizing information in a limited space."
            },
            new Sample
            {
                Name = "Template",
                Category = "Accordion",
                Directory = "Navigations/Accordion",
                Url = "accordion/template",
                MetaTitle = "Blazor Accordion with Custom Templates | Content Styling | Syncfusion",
                HeaderText = "Blazor Accordion Example - Custom Templates",
                MetaDescription = "This Blazor Accordion demo shows how to use custom templates. Learn to personalize header and content sections with rich HTML content, icons, and dynamic data.",
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
                Url = "accordion/icons",
                MetaTitle = "Blazor Accordion with Icons | Visual Indicators | Syncfusion",
                HeaderText = "Blazor Accordion Example - Icon Integration",
                MetaDescription = "This demo shows how to add icons to accordion items. Learn to enhance visual appearance by adding custom icons in headers for improved user experience."
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Accordion",
                Directory = "Navigations/Accordion",
                FileName = "KeyboardInteraction.razor",
                Url = "accordion/keyboard-interaction",
                MetaTitle = "Blazor Accordion Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor Accordion Example - Keyboard Interaction",
                MetaDescription = "This example shows keyboard interaction support. Learn to implement keyboard shortcuts to navigate and operate accordion items for better accessibility.",
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
                Url = "toolbar/default-functionalities",
                MetaTitle = "Blazor Toolbar Component | Default Functionalities | Syncfusion",
                HeaderText = "Blazor Toolbar Example - Default Functionalities",
                MetaDescription = "This Blazor Toolbar demo shows the default functionality of the component. Learn how to organize commands and controls in a compact horizontal/vertical layout."
            },
            new Sample
            {
                Name = "Overflow Modes",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "OverflowModes.razor",
                Url = "toolbar/overflow-modes",
                MetaTitle = "Blazor Toolbar Overflow Modes | Responsive Design | Syncfusion",
                HeaderText = "Blazor Toolbar Example - Overflow Handling",
                MetaDescription = "Blazor Toolbar demo shows different overflow modes. Learn how to handle toolbar items when they exceed available space with popup, multirow, and extended modes."
            },
            new Sample
            {
                Name = "Alignment",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "Alignment.razor",
                Url = "toolbar/alignment",
                MetaTitle = "Blazor Toolbar Item Alignment | Layout Options | Syncfusion",
                HeaderText = "Blazor Toolbar Example - Item Alignment",
                MetaDescription = "This demo shows alignment options for toolbar items. Learn how to position items to the left, center, or right within the toolbar for better organization."
            },
            new Sample
            {
                Name = "Template",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "Template.razor",
                Url = "toolbar/template",
                MetaTitle = "Blazor Toolbar with Custom Templates | Item Styling | Syncfusion",
                HeaderText = "Blazor Toolbar Example - Custom Templates",
                MetaDescription = "This Blazor Toolbar example shows how to use custom templates. Learn to create personalized toolbar items with HTML content, images, and other UI components."
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "KeyboardInteraction.razor",
                Url = "toolbar/keyboard-interaction",
                MetaTitle = "Blazor Toolbar Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor Toolbar Example - Keyboard Interaction",
                MetaDescription = "This Blazor Toolbar demo shows keyboard navigation support. Learn to implement keyboard shortcuts to navigate between toolbar items for improved accessibility.",
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
                Url = "tabs/default-functionalities",
                MetaTitle = "Blazor Tabs Component | Default Functionalities | Syncfusion",
                HeaderText = "Blazor Tabs Example - Default Functionalities",
                MetaDescription = "This Blazor Tab demo shows the default functionality of the component. Learn how to organize content into multiple tabbed sections for better space utilization."
            },
            new Sample
            {
                Name = "Orientation",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "Orientation.razor",
                Url = "tabs/orientation",
                MetaTitle = "Blazor Tabs Orientation Options | Horizontal & Vertical | Syncfusion",
                HeaderText = "Blazor Tabs Example - Orientation Options",
                MetaDescription = "This Blazor Tab demo shows horizontal and vertical orientation options. Learn how to change tab layout direction to suit your application's design requirements."
            },
            new Sample
            {
                Name = "Header Icons",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "HeaderIcons.razor",
                Url = "tabs/header-icons",
                MetaTitle = "Blazor Tabs with Header Icons | Visual Indicators | Syncfusion",
                HeaderText = "Blazor Tabs Example - Header Icons",
                MetaDescription = "Blazor Tab demo shows how to add icon to tab headers and enhance visual appearance by incorporating icon elements alongside tab text for better user experience."
            },
            new Sample
            {
                Name = "Responsive Modes",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "ResponsiveModes.razor",
                Url = "tabs/responsive-modes",
                MetaTitle = "Blazor Tabs Responsive Design | Adaptive Layout | Syncfusion",
                HeaderText = "Blazor Tabs Example - Responsive Modes",
                MetaDescription = "This Blazor Tabs example shows how tabs adapt to different screen sizes with various modes like scroll, popup, and accordion for mobile-friendly interfaces."
            },
            new Sample
            {
                Name = "Dynamic Tabs",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "DynamicTabs.razor",
                Url = "tabs/dynamic-tabs",
                MetaTitle = "Blazor Dynamic Tabs | Add & Remove Tabs | Syncfusion",
                HeaderText = "Blazor Tabs Example - Dynamic Tab Creation",
                MetaDescription = "Blazor Tabs demo shows how to add and remove tabs dynamically. Learn to implement user-managed tabs with runtime manipulation for flexible content organization."
            },
            new Sample
            {
                Name = "Nested Tabs",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "NestedTabs.razor",
                Url = "tabs/nested-tabs",
                MetaTitle = "Blazor Nested Tabs | Hierarchical Content | Syncfusion",
                HeaderText = "Blazor Tabs Example - Nested Tab Implementation",
                MetaDescription = "This demo shows how to create nested tabs and organize content in a hierarchical structure by placing tabs within tabs for complex information architecture."
            },
            new Sample
            {
                Name = "Wizard",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "Wizard.razor",
                Url = "tabs/wizard",
                MetaTitle = "Blazor Tabs Wizard | Step-by-Step Interface | Syncfusion",
                HeaderText = "Blazor Tabs Example - Wizard Implementation",
                MetaDescription = "This Blazor Tabs example shows how to create a wizard interface. Learn to guide users through a multi-step process with sequential tabs and navigation controls."
            },
            new Sample
            {
                Name = "Drag and Drop",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "DragAndDrop.razor",
                Url = "tabs/drag-and-drop",
                MetaTitle = "Blazor Tabs Drag and Drop | Tab Reordering | Syncfusion",
                HeaderText = "Blazor Tabs Example - Drag and Drop Functionality",
                MetaDescription = "This Blazor Tabs example demonstrates tab reordering with drag and drop. Learn to implement interactive tab rearrangement for customizable user experiences."
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "KeyboardInteraction.razor",
                Url = "tabs/keyboard-interaction",
                MetaTitle = "Blazor Tabs Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor Tabs Example - Keyboard Interaction",
                MetaDescription = "Blazor Tabs demo shows keyboard navigation support. Learn to implement keyboard shortcuts for accessing tabs without mouse interaction for better accessibility.",
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
                MetaTitle = "Blazor Treeview Example | Default Functionalities | Syncfusion Demos",
                HeaderText = "Blazor TreeView Example",
                MetaDescription = "This Blazor TreeView example demonstrates the default functionalities including hierarchical data display, node expansion/collapse, selection, and navigation."
            },
            new Sample
            {
                Name = "Icons and Images",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/icons-and-images",
                FileName = "IconsandImages.razor",
                MetaTitle = "Blazor TreeView with Icons and Images | Visual Nodes | Syncfusion",
                HeaderText = "Blazor TreeView Example - Icons and Images",
                MetaDescription = "This Blazor TreeView example shows how to add icons and images to tree nodes. Learn to enhance visual hierarchy with custom icons for different node types."
            },
            new Sample
            {
                Name = "Lazy Loading",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/lazy-loading",
                Type = SampleType.None,
                FileName = "LazyLoading.razor",
                MetaTitle = "Blazor TreeView with Lazy Loading | On-demand Data | Syncfusion",
                HeaderText = "Blazor TreeView Example - Lazy Loading",
                MetaDescription = "This Blazor TreeView example demonstrates how to load child nodes on-demand when parent nodes are expanded for better performance with large datasets."
            },
            new Sample
            {
                Name = "Checkbox",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/checkbox",
                Type = SampleType.None,
                FileName = "CheckBox.razor",
                MetaTitle = "Blazor TreeView with Checkboxes | Multi-selection | Syncfusion",
                HeaderText = "Blazor TreeView Example - Checkbox Selection",
                MetaDescription = "This Blazor TreeView example shows how to implement multi-selection in hierarchical data with cascading selection behavior between parent and child nodes."
            },
             new Sample
            {
                Name = "Node Editing",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/node-editing",
                FileName = "NodeEditing.razor",
                MetaTitle = "Blazor TreeView Node Editing | Rename Nodes | Syncfusion",
                HeaderText = "Blazor TreeView Example - Node Editing",
                MetaDescription = "Blazor TreeView demo shows node editing capabilities. Learn how to implement functionality for adding, renaming, deleting node in a hierarchical tree structure."
            },
             new Sample
            {
                Name = "Multiple Selection",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/multiple-selection",
                Type = SampleType.None,
                FileName = "MultipleSelection.razor",
                MetaTitle = "Blazor TreeView Multiple Selection | Multi-Node Select | Syncfusion",
                HeaderText = "Blazor TreeView Example - Multiple Selection",
                MetaDescription = "This Blazor TreeView demo shows multiple node selection. Learn to select multiple non-contiguous nodes using Ctrl+Click and contiguous nodes using Shift+Click."
            },
            new Sample
            {
                Name = "Drag and Drop",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/drag-and-drop",
                Type = SampleType.None,
                FileName = "DragAndDrop.razor",
                MetaTitle = "Blazor TreeView Drag and Drop | Node Reordering | Syncfusion",
                HeaderText = "Blazor TreeView Example - Drag and Drop",
                MetaDescription = "This example shows drag and drop functionality. Learn to rearrange nodes within the tree or between different trees with visual feedback during dragging."
            },
            new Sample
            {
                Name = "Template",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor TreeView Templates | Custom Node Rendering | Syncfusion",
                HeaderText = "Blazor TreeView Example - Custom Templates",
                MetaDescription = "This Blazor TreeView example shows custom node templates. Learn to create personalized tree nodes with complex HTML content, images, and other UI components."
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/keyboard-navigation",
                Type = SampleType.None,
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor TreeView Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor TreeView Example - Keyboard Navigation",
                MetaDescription = "This Blazor TreeView example demonstrates how to implement keyboard shortcuts for expanding, collapsing, and selecting nodes without mouse interaction."
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/ui-virtualization",
                FileName = "UIVirtualization.razor",
                MetaTitle = "Blazor TreeView Virtualization | Performance Optimization | Syncfusion",
                HeaderText = "Blazor TreeView Example - UI Virtualization",
                MetaDescription = "This Blazor TreeView example demonstrates how to render only visible nodes to improve performance when dealing with large datasets in a hierarchical structure."
            },
              new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Navigations/TreeView",
                Url = "treeview/local-data",
                FileName = "LocalData.razor",
                MetaTitle = "Blazor TreeView with Local Data Binding | Client Data | Syncfusion",
                HeaderText = "Blazor TreeView Example - Local Data Binding",
                MetaDescription = "Blazor TreeView demo shows local data binding. Learn to bind hierarchical data from client-side collections to populate tree nodes with various data adapters."
            },
               new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Navigations/TreeView",
                Url = "treeview/remote-data",
                FileName = "RemoteData.razor",
                MetaTitle = "Blazor TreeView with Remote Data | Server Binding | Syncfusion",
                HeaderText = "Blazor TreeView Example - Remote Data Binding",
                MetaDescription = "This Blazor TreeView example demonstrates remote data binding. Learn to populate tree nodes from server-side data sources using asynchronous data fetching."
            }
        };
        public List<Sample> FileManager { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor File Manager Component | Features Overview | Syncfusion",
                HeaderText = "Blazor File Manager Example - Overview",
                MetaDescription = "This Blazor File Manager demo shows key features and capabilities of the component. Explore file browsing, uploading, downloading, and management operations."
            },
            new Sample
            {
                Name = "Flat Data",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/flat-data",
                FileName = "FlatData.razor",
                MetaTitle = "Blazor File Manager Example | Flat Data | Syncfusion",
                HeaderText = "Blazor File Manager Example - Flat Data Binding",
                MetaDescription = "This Blazor File Manager example shows flat data binding. Learn to display and manage files from a non-hierarchical data structure with customizable views.",
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
                FileName = "CustomThumbnail.razor",
                MetaTitle = "Blazor File Manager Custom Thumbnails | File Previews | Syncfusion",
                HeaderText = "Blazor File Manager Example - Custom Thumbnails",
                MetaDescription = "Blazor File Manager demo shows how to implement custom thumbnails. Learn to create personalized file and folder previews based on file type or other criteria."
            },
             new Sample
            {
                Name = "Pagination",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/pagination",
                FileName = "Pagination.razor",
                MetaTitle = "Blazor File Manager with Pagination | Page Navigation | Syncfusion",
                HeaderText = "Blazor File Manager Example - Pagination",
                MetaDescription = "This Blazor File Manager demo shows pagination functionality. Learn to navigate large file lists with page controls for improved organization and performance."
            },
             new Sample
            {
                Name = "API",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/api",
                FileName = "API.razor",
                MetaTitle = "Blazor File Manager API Usage | Methods & Properties | Syncfusion",
                HeaderText = "Blazor File Manager Example - API Configuration",
                MetaDescription = "This Blazor File Manager example shows various API methods and properties. Learn to programmatically control file operations and customize component behavior."
            },
            new Sample
            {
                Name = "Drag and Drop",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/drag-and-drop",
                FileName = "DragAndDrop.razor",
                MetaTitle = "Blazor File Manager Drag and Drop | File Organization | Syncfusion",
                HeaderText = "Blazor File Manager Example - Drag and Drop",
                MetaDescription = "Blazor File Manager demo shows drag and drop functionality. Learn to move files between folders with intuitive drag gestures for efficient file organization."
            },
            new Sample
            {
                Name = "Directory Upload",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/directory-upload",
                FileName = "DirectoryUpload.razor",
                MetaTitle = "Blazor File Manager Directory Upload | Folder Upload | Syncfusion",
                HeaderText = "Blazor File Manager Example - Directory Upload",
                MetaDescription = "Blazor FileManager demo shows directory upload functionality.Learn to upload entire folders while preserving their structure for efficient bulk file management.",
                Type = SampleType.Updated,
                NotificationDescription = new string[] {
                    @"Adds context menu upload options, enabling users to upload either individual files or entire folders directly from the File Manager for faster, streamlined additions."
                }
            },
            new Sample
            {
                Name = "Sequential Upload",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/sequential-upload",
                FileName = "SequentialUpload.razor",
                MetaTitle = "Blazor File Manager Sequential Upload | Ordered Uploads | Syncfusion",
                HeaderText = "Blazor File Manager Example - Sequential Upload",
                MetaDescription = "This Blazor File Manager example demonstrates sequential uploads, sending files one by one in queue order for predictable, controlled transfers with progress.",
                Type = SampleType.New,
                NotificationDescription = new string[] {
                    @"Demonstrates sequential file uploads in the File Manager, ensuring files are uploaded one-by-one in the exact queue order for predictable and controlled transfers."
                }
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/virtualization",
                FileName = "Virtualization.razor",
                MetaTitle = "Blazor File Manager Virtualization | Performance Boost | Syncfusion",
                HeaderText = "Blazor File Manager Example - Virtualization",
                MetaDescription = "This Blazor File Manager demo shows UI virtualization. Learn how to improve performance by rendering only visible items when handling large file collections."
            },
            new Sample
            {
                Name = "Template",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor File Manager Templates | Custom Items and Nodes",
                HeaderText = "Blazor File Manager Example - Custom Templates",
                MetaDescription = "Customize Blazor File Manager with templates for navigation tree nodes and layout items, adding icons, images, and rich content for accessible file browsing.",
                Type = SampleType.New,
                NotificationDescription = new string[]{
                    @"Demonstrates the customization of the Blazor File Manager using templates for both the navigation pane nodes and layout items."
                }
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/keyboard-navigation",
                Type = SampleType.None,
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor File Manager Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor File Manager Example - Keyboard Navigation",
                MetaDescription = "Blazor File Manager demo shows keyboard navigation support. Learn to implement keyboard shortcuts for file operations and navigation without mouse interaction."
            },
            //new Sample
            //{
            //    Name = "Performance",
            //    Category = "Benchmark",
            //    Directory = "Navigations/FileManager",
            //    Url = "file-manager/flatdata-performance",
            //    Type = SampleType.New,
            //    FileName = "Performance.razor",
            //    MetaTitle = "Blazor File Manager Performance | Large Data | Syncfusion",
            //    HeaderText = "Blazor File Manager Example - Performance",
            //    MetaDescription = "This Blazor File Manager Performance demo showcases high-performance data processing and rendering for large datasets, with virtualization and responsive UI.",
            //    SourceFiles = new List<SourceCollection>()
            //    {
            //        new SourceCollection
            //        {
            //            Id = "Performance",
            //            FileName = "Performance.razor"
            //        },
            //        new SourceCollection
            //        {
            //            Id = "FileManagerLargeDataGenerator",
            //            FileName = "FileManagerLargeDataGenerator.cs"
            //        },
            //    },
            //},
            #if SERVER
            new Sample
            {
                Name = "Tag Search",
                Category = "Smart AI Solutions",
                Directory = "AISamples/FileManager",
                Url = "file-manager/ai-tagsearch",
                FileName = "FileManagerTagSearch.razor",
                MetaTitle = "File Manager Tag Search - Syncfusion AI Demos",
                HeaderText = "Blazor FileManager Example - AI-driven Tag Search",
                MetaDescription = "Demonstrates AI tag search and tagging capabilities in Blazor FileManager.",
                Type = SampleType.AI,
            },
            new Sample
            {
                Name = "Smart File Operations",
                Category = "Smart AI Solutions",
                Directory = "AISamples/FileManager",
                Url = "file-manager/ai-smart-filemanager",
                FileName = "SmartFileManager.razor",
                MetaTitle = "AI Operations with File Manager - Syncfusion AI Demos",
                HeaderText = "Blazor FileManager Example - Smart AI Operations",
                MetaDescription = "Use AI-driven operations for file retrieval and management in Blazor FileManager.",
                Type = SampleType.AI,
            },
#endif
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
                MetaTitle = "Blazor File Manager Access Control | Permissions | Syncfusion",
                HeaderText = "Blazor File Manager Example - Access Control",
                MetaDescription = "This Blazor File Manager example shows how to implement access control. Learn to restrict file operations based on user permissions for secure file management.",
                Type = SampleType.Updated,
                NotificationDescription = new string[] {
                    @"Introduces fine-grained upload permissions for the Music folder where individual file uploads are permitted, while folder uploads are prevented using the UploadContentFilter property"
                }
            },
            new Sample
            {
                Name = "File Upload",
                Category = "Use Case",
                Directory = "Navigations/FileManager",
                Url = "file-manager/file-upload",
                FileName = "FileUpload.razor",
                MetaTitle = "Blazor File Manager Upload | File Uploading | Syncfusion",
                HeaderText = "Blazor File Manager Example - File Upload",
                MetaDescription = "This Blazor File Manager example shows file upload functionality. Learn to implement single and multiple file uploading with progress tracking and validation."
            },
            new Sample
            {
                Name = "Azure Blob Storage",
                Category = "Cloud Service Providers",
                Directory = "Navigations/FileManager",
                Url = "file-manager/azure",
                FileName = "Azure.razor",
                MetaTitle = "Blazor File Manager with Azure Blob Storage | Cloud Files | Syncfusion",
                HeaderText = "Blazor File Manager Example - Azure Blob Storage Integration",
                MetaDescription = "This Blazor File Manager demo shows integration with Azure Blob Storage. Learn to browse, manage, and manipulate files stored in MS cloud storage service."
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
                FileName = "AmazonS3.razor",
                MetaTitle = "Blazor File Manager with Amazon S3 | AWS Integration | Syncfusion",
                HeaderText = "Blazor File Manager Example - Amazon S3 Integration",
                MetaDescription = "This Blazor File Manager example shows integration with Amazon S3 storage. Learn to browse, manage, and manipulate files stored in AWS Simple Storage Service."
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
                FileName = "IBM.razor",
                MetaTitle = "Blazor File Manager with IBM Cloud Storage | Integration | Syncfusion",
                HeaderText = "Blazor File Manager Example - IBM Cloud Object Storage Integration",
                MetaDescription = "This Blazor File Manager demo shows integration with IBM Cloud Object Storage. Learn to browse, manage, manipulate files stored in IBM's cloud storage service."
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
                MetaTitle = "Blazor Breadcrumb Component | Default Functionalities | Syncfusion",
                HeaderText = "Blazor Breadcrumb Example - Default Functionalities",
                MetaDescription = "This demo shows default functionality of the component. Learn to implement hierarchical navigation paths that show the current location within an application."
            },
             new Sample
            {
                Name = "Bind to Location",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/bind-to-location",
                FileName = "BindToLocation.razor",
                MetaTitle = "Blazor Breadcrumb URL Binding | Location Binding | Syncfusion",
                HeaderText = "Blazor Breadcrumb Example - Location Binding",
                MetaDescription = "This Blazor Breadcrumb example demonstrates how to automatically generate breadcrumb items from the current application URL for dynamic navigation paths."
            },
            new Sample
            {
                Name = "Template and Customization",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/template-and-customization",
                MetaTitle = "Breadcrumb Template and Customization - Syncfusion Demos",
                FileName = "TemplateAndCustomization.razor",
                HeaderText = "Blazor Breadcrumb Example - Custom Templates",
                MetaDescription = "This Blazor Breadcrumb example shows how to create personalized breadcrumb items with custom styles, icons, and dynamic content for unique navigation trails."
            },
            new Sample
            {
                Name = "Overflow Modes",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/overflow-modes",
                FileName = "OverflowModes.razor",
                MetaTitle = "Blazor Breadcrumb Overflow Handling | Responsive Design | Syncfusion",
                HeaderText = "Blazor Breadcrumb Example - Overflow Modes",
                MetaDescription = "This Blazor Breadcrumb example demonstrates how to manage long navigation paths with various modes like wrap, scroll, and hidden for responsive designs."
            },
            new Sample
            {
                Name = "Events",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/events",
                FileName = "Events.razor",
                MetaTitle = "Blazor Breadcrumb Events | User Interaction | Syncfusion",
                HeaderText = "Blazor Breadcrumb Example - Event Handling",
                MetaDescription = "This Breadcrumb demo shows event handling capabilities. Learn to capture and respond to user interactions like item clicks to implement custom navigation logic."
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/keyboard-navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor Breadcrumb Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor Breadcrumb Example - Keyboard Navigation",
                MetaDescription = "This Blazor Breadcrumb example shows how to implement keyboard shortcuts for navigating breadcrumb items without mouse interaction for better accessibility."
            },
            new Sample
            {
                Name = "Address Bar",
                Category = "Use Case",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/address-bar",
                FileName = "AddressBar.razor",
                MetaTitle = "Blazor Breadcrumb Address Bar | File Explorer | Syncfusion",
                HeaderText = "Blazor Breadcrumb Example - Address Bar Implementation",
                MetaDescription = "This Blazor Breadcrumb demo shows how to create an address bar. Learn to implement a file explorer-like path navigation with editable breadcrumb functionality."
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
                MetaTitle = "Blazor Carousel Component | Default Functionalities | Syncfusion",
                HeaderText = "Blazor Carousel Example - Default Functionalities",
                MetaDescription = "Blazor Carousel demo shows default functionality of the component. Learn to create a slideshow for cycling through images or content with navigation controls.",
                MappingSampleName = "With Default Functionalities",
            },
            new Sample
            {
                Name = "Templates",
                Category = "Carousel",
                Directory = "Navigations/Carousel",
                Url = "carousel/templates",
                FileName = "Templates.razor",
                MetaTitle = "Blazor Carousel Templates | Custom Slides | Syncfusion",
                HeaderText = "Blazor Carousel Example - Custom Templates",
                MetaDescription = "This Blazor Carousel demo shows template customization. Learn to create personalized carousel items with custom HTML content, images, and interactive elements.",
                MappingSampleName = "With Templates",
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "Carousel",
                Directory = "Navigations/Carousel",
                Url = "carousel/data-binding",
                FileName = "DataBinding.razor",
                MetaTitle = "Blazor Carousel Data Binding | Dynamic Content | Syncfusion",
                HeaderText = "Blazor Carousel Example - Data Binding",
                MetaDescription = "This Blazor Carousel example demonstrates how to populate carousel slides dynamically from local or remote data sources for flexible content presentation.",
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
                MetaTitle = "Blazor Carousel Keyboard Controls | Accessibility | Syncfusion",
                HeaderText = "Blazor Carousel Example - Keyboard Interactions",
                MetaDescription = "Blazor Carousel demo shows keyboard interaction support. Learn to navigate carousel slides using keyboard shortcuts like arrow keys for improved accessibility.",
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
                MetaTitle = "Blazor Carousel Partial Visible Slides | Multi-View | Syncfusion",
                HeaderText = "Blazor Carousel Example - Partial Visible Items",
                MetaDescription = "This demo shows partial visible slide functionality. Learn to show multiple slides simultaneously with a peek at upcoming slides for improved content preview.",
                MappingSampleName = "With partial visible",
            },
            new Sample
            {
                Name = "Indicator Type",
                Category = "Carousel",
                Directory = "Navigations/Carousel",
                Url = "carousel/indicator-type",
                FileName = "IndicatorType.razor",
                MetaTitle = "Blazor Carousel Indicator Types | Navigation Options | Syncfusion",
                HeaderText = "Blazor Carousel Example - Indicator Types",
                MetaDescription = "This Blazor Carousel example demonstrates how to customize slide indicators as dots, numbers, or thumbnails to enhance navigation and visual presentation.",
                MappingSampleName = "With Indicator Types"
            },
            new Sample
            {
                Name = "API",
                Category = "Carousel",
                Directory = "Navigations/Carousel",
                Url = "carousel/api",
                FileName = "API.razor",
                MetaTitle = "Blazor Carousel API Usage | Methods & Properties | Syncfusion",
                HeaderText = "Blazor Carousel Example - API Configuration",
                MetaDescription = "Blazor Carousel demo shows API methods and properties. Learn to programmatically control slide transitions, animation, customize automatic playback behavior.",
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
                MetaTitle = "Blazor AppBar Component | Default Functionalities | Syncfusion",
                HeaderText = "Blazor AppBar Example - Default Functionalities",
                MetaDescription = "Blazor AppBar demo shows the default functionality of the component. Learn to create a customizable top navigation bar with branding, menus, and action items.",
                MappingSampleName = "With Default Functionalities"
            },
            new Sample
            {
                Name = "Color",
                Category = "AppBar",
                Directory = "Navigations/AppBar",
                Url = "appbar/color",
                FileName = "Color.razor",
                MetaTitle = "Blazor AppBar Color Customization | Theme Options | Syncfusion",
                HeaderText = "Blazor AppBar Example - Color Variants",
                MetaDescription = "This Blazor AppBar example shows color customization options. Learn to apply different color schemes and themes to match your application's design requirements.",
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
                MetaTitle = "Blazor Stepper Component | Default Functionalities | Syncfusion",
                HeaderText = "Blazor Stepper Example - Default Functionalities",
                MetaDescription = "This Blazor Stepper demo shows the default functionality of the component. Learn to create a step-by-step interface to guide users through a sequential process.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Orientation",
                Category = "Stepper",
                Directory = "Navigations/Stepper",
                Url = "stepper/orientation",
                FileName = "Orientation.razor",
                MetaTitle = "Blazor Stepper Orientation | Horizontal & Vertical | Syncfusion",
                HeaderText = "Blazor Stepper Example - Orientation Options",
                MetaDescription = "Blazor Stepper demo shows horizontal and vertical orientation options. Learn to change stepper layout direction to suit your application's design requirements.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Linear Flow",
                Category = "Stepper",
                Directory = "Navigations/Stepper",
                Url = "stepper/linear-flow",
                FileName = "Linear.razor",
                MetaTitle = "Blazor Stepper Linear Flow | Sequential Steps | Syncfusion",
                HeaderText = "Blazor Stepper Example - Linear Flow Navigation",
                MetaDescription = "This demo shows linear flow implementation. Learn to create a strictly sequential process where users must complete each step before proceeding to the next.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Validation",
                Category = "Stepper",
                Directory = "Navigations/Stepper",
                Url = "stepper/validation",
                FileName = "Validation.razor",
                MetaTitle = "Blazor Stepper Validation | Form Verification | Syncfusion",
                HeaderText = "Blazor Stepper Example - Step Validation",
                MetaDescription = "Blazor Stepper demo shows validation integration. Learn to implement form validation within each step to ensure data quality before allowing users to advance.",
                Type = SampleType.None
            }
        };

        public List<Sample> Ribbon { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Ribbon",
                Directory = "Navigations/Ribbon",
                Url = "ribbon/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Ribbon Component | Default Functionalities | Syncfusion",
                HeaderText = "Blazor Ribbon Example - Default Functionalities",
                MetaDescription = "Blazor Ribbon demo shows the default functionality of the component. Learn to create a Microsoft Office-like command interface with tabs, groups, and commands."
            },
            new Sample
            {
                Name = "Simplified",
                Category = "Ribbon",
                Directory = "Navigations/Ribbon",
                Url = "ribbon/simplified",
                FileName = "Simplified.razor",
                MetaTitle = "Blazor Ribbon Simplified Mode | Compact Layout | Syncfusion",
                HeaderText = "Blazor Ribbon Example - Simplified Mode",
                MetaDescription = "This Blazor Ribbon demo shows simplified mode. Learn to implement a compact ribbon interface with minimized tabs and commands for space-efficient applications."
            },
            new Sample
            {
                Name = "Backstage",
                Category = "Ribbon",
                Directory = "Navigations/Ribbon",
                Url = "ribbon/backstage",
                FileName = "Backstage.razor",
                MetaTitle = "Blazor Ribbon Backstage View | File Menu | Syncfusion",
                HeaderText = "Blazor Ribbon Example - Backstage Implementation",
                MetaDescription = "This Blazor Ribbon demo shows backstage view functionality. Learn to create a full-screen menu for file operations like open, save, print similar to MS Office."
            },
            new Sample
            {
                Name = "Contextual Tabs",
                Category = "Ribbon",
                Directory = "Navigations/Ribbon",
                Url = "ribbon/contextual",
                FileName = "ContextualTabs.razor",
                MetaTitle = "Blazor Ribbon Contextual Tabs | Dynamic Tabs | Syncfusion",
                HeaderText = "Blazor Ribbon Example - Contextual Tabs",
                MetaDescription = "This Blazor Ribbon example shows how to dynamically show specialized tabs based on context, similar to how MS Office shows format tabs for selected elements.",
                Type = SampleType.None,
                NotificationDescription = new string[] {
                    @"Highlights the contextual tab of the Ribbon, showcasing the dynamic rendering of tabs."
                }
            },
            new Sample
            {
                Name = "Ribbon Resizing",
                Category = "Ribbon",
                Directory = "Navigations/Ribbon",
                Url = "ribbon/resize",
                FileName = "Resize.razor",
                MetaTitle = "Blazor Ribbon Resizing | Responsive Design | Syncfusion",
                HeaderText = "Blazor Ribbon Example - Responsive Resizing",
                MetaDescription = "This demo shows resizing functionality. Learn how the ribbon automatically adapts its layout to different screen sizes for optimal usability on all devices."
            },
            new Sample
            {
                Name = "Ribbon KeyTips",
                Category = "Ribbon",
                Directory = "Navigations/Ribbon",
                Url = "ribbon/keytip",
                FileName = "KeyTips.razor",
                MetaTitle = "Blazor Ribbon KeyTips | Keyboard Shortcut Hints | Syncfusion",
                HeaderText = "Blazor Ribbon Example - KeyTips Implementation",
                MetaDescription = "Blazor Ribbon demo shows KeyTips functionality. Learn to provide visual keyboard shortcut hints for quick access to ribbon commands without using the mouse.",
                Type = SampleType.None,
                NotificationDescription = new string[] {
                    @"Demonstrates the KeyTips functionality in the Ribbon, allowing users to quick access ribbon items using keyboard actions."
                }
            },
            new Sample
            {
                Name = "Ribbon Gallery",
                Category = "Ribbon",
                Directory = "Navigations/Ribbon",
                Url = "ribbon/gallery",
                FileName = "Gallery.razor",
                MetaTitle = "Blazor Ribbon Gallery | Visual Options Menu | Syncfusion",
                HeaderText = "Blazor Ribbon Example - Gallery Implementation",
                MetaDescription = "This Blazor Ribbon demo shows gallery functionality. Learn to create visual option menus with previews, similar to style galleries in MS Office applications."
            }
        };
    }
}