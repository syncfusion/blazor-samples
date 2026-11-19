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
                MetaTitle = "Blazor Sidebar Example - Default Functionalities Demos | Syncfusion",
                HeaderText = "Blazor Sidebar Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Sidebar renders collapsible panels with navigation menus, responsive behavior, and smooth animations for modern layouts.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-sidebar"
            },
            new Sample
            {
                Name = "Dock",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/dock",
                FileName = "Dock.razor",
                MetaTitle = "Blazor Sidebar Examples - Dock | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Sidebar Example - Dock Mode",
                MetaDescription = "See how the Syncfusion Blazor Sidebar docks to minimal icon width when collapsed with smooth animations to save screen space and keep navigation visible.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "API",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/api",
                FileName = "API.razor",
                MetaTitle = "Blazor Sidebar Examples - API | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Sidebar Example - API Configuration",
                MetaDescription = "See how the Syncfusion Blazor Sidebar opens, closes, and toggles visibility through its API to support dynamic layout control and interactions in applications.",
            },
            new Sample
            {
                Name = "Sidebar with ListView",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/sidebar-with-listview",
                FileName = "SidebarWithListView.razor",
                MetaTitle = "Blazor Sidebar Demos - Sidebar with ListView Examples| Syncfusion",
                HeaderText = "Blazor Sidebar Example - Integration with ListView",
                MetaDescription = "See how the Syncfusion Blazor Sidebar integrates ListView to create navigation menus with icons and hierarchical content for structured display and navigation.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Sidebar Menu",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/sidebar-with-menu",
                FileName = "SidebarWithMenu.razor",
                MetaTitle = "Blazor Sidebar - Sidebar Menu | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Sidebar Example - Integration with Menu",
                MetaDescription = "See how the Syncfusion Blazor Sidebar renders interactive menus with hierarchical items in collapsible panels to provide intuitive navigation and organization.",
            },
            new Sample
            {
                Name = "Responsive Panel",
                Category = "Sidebar",
                Directory = "Navigations/Sidebar",
                Url = "sidebar/panel-with-responsive",
                FileName = "PanelWithResponsive.razor",
                MetaTitle = "Blazor Sidebar - Responsive Panel | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Sidebar Example - Responsive Panel",
                MetaDescription = "See how the Syncfusion Blazor Sidebar adapts to different screen sizes with responsive behavior changes for optimal layout across devices and viewports.",
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
                MetaTitle = "Blazor Context Menu Examples - Default | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Context Menu Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Context Menu displays right-click menus with nested items and icons for quick access to navigation and contextual actions.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-context-menu"
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
                MetaTitle = "Blazor MenuBar - Default Functionalities | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Menu Bar Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Menu Bar creates horizontal navigation with dropdown submenus to organize commands and links efficiently in applications.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-menu-bar"
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "DataBinding.razor",
                Url = "menu-bar/data-binding",
                MetaTitle = "Blazor MenuBar - Data Binding | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Menu Bar Example - Data Binding",
                MetaDescription = "See how the Syncfusion Blazor Menu Bar binds to arrays and remote data sources to generate dynamic menus with hierarchical structure for modern applications."
            },
            new Sample
            {
                Name = "Scrollable",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Scrollable.razor",
                Url = "menu-bar/scrollable",
                MetaTitle = "Blazor MenuBar - Scrollable | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Menu Bar Example - Scrollable Menu",
                MetaDescription = "See how the Syncfusion Blazor Menu Bar handles large item collections with scrollable dropdowns to keep navigation clean and tidy in feature-rich applications."
            },
            new Sample
            {
                Name = "Template",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Templates.razor",
                Url = "menu-bar/templates",
                MetaTitle = "Blazor MenuBar Examples - Template | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Menu Bar Example - Item Templates",
                MetaDescription = "See how the Syncfusion Blazor Menu Bar customizes items with icons, images, and HTML content using templates to create visually rich navigation menus easily."
            },
            new Sample
            {
                Name = "Hamburger Mode",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Hamburger.razor",
                Url = "menu-bar/hamburger-menu",
                MetaTitle = "Blazor MenuBar - Hamburger Mode | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Menu Bar Example - Hamburger Menu",
                MetaDescription = "See how the Syncfusion Blazor Menu Bar transforms into hamburger style on small screens with responsive menu collapse for mobile-friendly user experiences."
            },
            new Sample
            {
                Name = "API",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "Api.razor",
                Url = "menu-bar/api",
                MetaTitle = "Blazor Menu Bar Examples - API | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Menu Bar Example - API Configuration",
                MetaDescription = "See how the Syncfusion Blazor Menu Bar enables, disables, and manages menu items with API methods to support dynamic navigation control in applications."
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Menu Bar",
                Directory = "Navigations/MenuBar",
                FileName = "KeyboardNavigation.razor",
                Url = "menu-bar/keyboard-navigation",
                MetaTitle = "Blazor MenuBar - Keyboard Navigation | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Menu Bar Example - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor Menu Bar navigates items using arrow keys and keyboard shortcuts for accessible dropdown menus without mouse interaction."             
            },
            new Sample
            {
                Name = "Toolbar Integration",
                Category = "Use Case",
                Directory = "Navigations/MenuBar",
                FileName = "Toolbar.razor",
                Url = "menu-bar/toolbar-integration",
                MetaTitle = "Blazor MenuBar Demos - Toolbar Integration Examples| Syncfusion",
                HeaderText = "Blazor Menu Bar Example - Toolbar Integration",
                MetaDescription = "See how the Syncfusion Blazor Menu Bar integrates with Toolbar to build Office style navigation bars with commands, controls, and grouped items efficiently.",
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
                MetaTitle = "Blazor Pager - Default Functionalities | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Pager Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Pager implements pagination with configurable page sizes, navigation buttons, and page info for efficient data browsing.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-pager"
            },
			new Sample
			{
				Name = "Paging API",
				Category = "Pager",
				Directory = "Navigations/Pager",
				FileName = "PagingAPI.razor",
				Url = "pager/paging-api",
                MetaTitle = "Blazor Pager Examples - Paging API | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Pager Example - API Configuration",
                MetaDescription = "See how the Syncfusion Blazor Pager controls page navigation, page sizes, and customizes behavior through its API to support dynamic pagination in applications.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Pager Dropdown",
                Category = "Pager",
                Directory = "Navigations/Pager",
                FileName = "PagerDropdown.razor",
                Url = "pager/pager-dropdown",
                MetaTitle = "Blazor Pager - Pager Dropdown | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Pager Example - Dropdown Integration",
                MetaDescription = "See how the Syncfusion Blazor Pager lets users select page sizes from a dropdown to change items displayed per page for flexible data viewing and control.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Pager",
                Directory = "Navigations/Pager",
                FileName = "PagerKeyboardNavigation.razor",
                Url = "pager/keyboard-navigation",
                MetaTitle = "Blazor Pager - Keyboard Navigation | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Pager Example - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor Pager navigates pages using keyboard shortcuts for accessible pagination without requiring mouse interaction in applications.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Pager Template",
                Category = "Pager",
                Directory = "Navigations/Pager",
                FileName = "PagerIntegrateWithGrid.razor",
                Url = "pager/pager-template",
                MetaTitle = "Blazor Pager - Pager Template | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Pager Example - Custom Templates",
                MetaDescription = "See how the Syncfusion Blazor Pager creates custom templates integrating with DataGrid and other components to personalize pagination UI and appearance.",
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
                MetaTitle = "Blazor Accordion Examples - Default | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Accordion Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Accordion creates collapsible panels with expandable headers to organize information and save screen space efficiently easily.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-accordion"
            },
            new Sample
            {
                Name = "Template",
                Category = "Accordion",
                Directory = "Navigations/Accordion",
                Url = "accordion/template",
                MetaTitle = "Blazor Accordion - Template | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Accordion Example - Custom Templates",
                MetaDescription = "See how the Syncfusion Blazor Accordion customizes headers and panels with HTML, icons, and data using templates to create unique and flexible designs.",
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
                MetaTitle = "Blazor Accordion Examples - Icons | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Accordion Example - Icon Integration",
                MetaDescription = "See how the Syncfusion Blazor Accordion adds icons to item headers to enhance visual appearance and communicate content meaning and context at a glance."
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Accordion",
                Directory = "Navigations/Accordion",
                FileName = "KeyboardInteraction.razor",
                Url = "accordion/keyboard-interaction",
                MetaTitle = "Blazor Accordion Demos - Keyboard Interaction Examples | Syncfusion",
                HeaderText = "Blazor Accordion Example - Keyboard Interaction",
                MetaDescription = "See how the Syncfusion Blazor Accordion supports keyboard navigation for expanding, collapsing, and selecting items without mouse interaction for accessibility.",
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
                MetaTitle = "Blazor Toolbar - Default Functionalities | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Toolbar Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Toolbar organizes commands, buttons, and controls in a compact layout to provide quick and easy access in applications easily.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-toolbar"
            },
            new Sample
            {
                Name = "Overflow Modes",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "OverflowModes.razor",
                Url = "toolbar/overflow-modes",
                MetaTitle = "Blazor Toolbar - Overflow Modes | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Toolbar Example - Overflow Handling",
                MetaDescription = "See how the Syncfusion Blazor Toolbar handles excess items with popup, multi-row, and scrollable overflow modes to prevent crowding and maintain usability."
            },
            new Sample
            {
                Name = "Alignment",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "Alignment.razor",
                Url = "toolbar/alignment",
                MetaTitle = "Blazor Toolbar Examples - Alignment | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Toolbar Example - Item Alignment",
                MetaDescription = "See how the Syncfusion Blazor Toolbar aligns items to the left, center, or right within layouts to create balanced designs and improve visual hierarchy clearly."
            },
            new Sample
            {
                Name = "Template",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "Template.razor",
                Url = "toolbar/template",
                MetaTitle = "Blazor Toolbar Examples - Template | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Toolbar Example - Custom Templates",
                MetaDescription = "See how the Syncfusion Blazor Toolbar customizes items with HTML content, images, and UI components using templates to create branded toolbar designs easily."
            },
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Toolbar",
                Directory = "Navigations/Toolbar",
                FileName = "KeyboardInteraction.razor",
                Url = "toolbar/keyboard-interaction",
                MetaTitle = "Blazor Toolbar Demos - Keyboard Interaction Examples | Syncfusion",
                HeaderText = "Blazor Toolbar Example - Keyboard Interaction",
                MetaDescription = "See how the Syncfusion Blazor Toolbar supports keyboard navigation to move between items and select commands efficiently for improved accessibility easily.",
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
                MetaTitle = "Blazor Tabs Examples - Default | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Tabs Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Tabs organizes content into tabbed sections with headers and panels for better space utilization and improved navigation in apps",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-tabs"
            },
            new Sample
            {
                Name = "Orientation",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "Orientation.razor",
                Url = "tabs/orientation",
                MetaTitle = "Blazor Tabs Examples - Orientation | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Tabs Example - Orientation Options",
                MetaDescription = "See how the Syncfusion Blazor Tabs switches between horizontal and vertical layouts to suit different app designs, screen constraints, and space requirements"
            },
            new Sample
            {
                Name = "Header Icons",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "HeaderIcons.razor",
                Url = "tabs/header-icons",
                MetaTitle = "Blazor Tabs Examples - Header Icons | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Tabs Example - Header Icons",
                MetaDescription = "See how the Syncfusion Blazor Tabs adds icons alongside tab headers and text to improve visual identification and enhance tabbed navigation clarity and appeal"
            },
            new Sample
            {
                Name = "Responsive Modes",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "ResponsiveModes.razor",
                Url = "tabs/responsive-modes",
                MetaTitle = "Blazor Tabs - Responsive Modes | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Tabs Example - Responsive Modes",
                MetaDescription = "See how the Syncfusion Blazor Tabs adapts to screen sizes with scroll, popup, and accordion modes to provide responsive and mobile-friendly tab interfaces."
            },
            new Sample
            {
                Name = "Dynamic Tabs",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "DynamicTabs.razor",
                Url = "tabs/dynamic-tabs",
                MetaTitle = "Blazor Tabs Examples - Dynamic Tabs | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Tabs Example - Dynamic Tab Creation",
                MetaDescription = "See how the Syncfusion Blazor Tabs adds and removes tabs at runtime to support flexible content organization and dynamic tab management in applications."
            },
            new Sample
            {
                Name = "Nested Tabs",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "NestedTabs.razor",
                Url = "tabs/nested-tabs",
                MetaTitle = "Blazor Tabs Examples - Nested Tabs | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Tabs Example - Nested Tab Implementation",
                MetaDescription = "See how the Syncfusion Blazor Tabs renders nested tab structures within tabs to support complex layouts and multi level content navigation in applications."
            },
            new Sample
            {
                Name = "Wizard",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "Wizard.razor",
                Url = "tabs/wizard",
                MetaTitle = "Blazor Tabs Examples - Wizard | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Tabs Example - Wizard Implementation",
                MetaDescription = "See how the Syncfusion Blazor Tabs enables wizard interfaces to guide users through multi step processes with sequential navigation and controlled flow."
            },
            // Ignore: From Build
            new Sample
            {
                Name = "Drag and Drop",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "DragAndDrop.razor",
                Url = "tabs/drag-and-drop",
                MetaTitle = "Blazor Tabs - Drag and Drop | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Tabs Example - Drag and Drop Functionality",
                MetaDescription = "See how the Syncfusion Blazor Tabs supports drag and drop to reorder tabs for customizable layouts and improved user interface flexibility in applications."
            },
            // End: Ignore
            new Sample
            {
                Name = "Keyboard Interaction",
                Category = "Tabs",
                Directory = "Navigations/Tabs",
                FileName = "KeyboardInteraction.razor",
                Url = "tabs/keyboard-interaction",
                MetaTitle = "Blazor Tabs - Keyboard Interaction | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Tabs Example - Keyboard Interaction",
                MetaDescription = "See how the Syncfusion Blazor Tabs supports keyboard navigation to switch tabs using shortcuts for improved accessibility and efficient tab interaction.",
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
                MetaTitle = "Blazor TreeView Demos - Default Functionalities Examples | Syncfusion",
                HeaderText = "Blazor TreeView Example",
                MetaDescription = "See how the Syncfusion Blazor TreeView renders hierarchical data with expandable nodes and selection to provide structured navigation in applications.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-treeview"
            },
            new Sample
            {
                Name = "Icons and Images",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/icons-and-images",
                FileName = "IconsandImages.razor",
                MetaTitle = "Blazor TreeView - Icons and Images | Navigations Demos | Syncfusion",
                HeaderText = "Blazor TreeView Example - Icons and Images",
                MetaDescription = "See how the Syncfusion Blazor TreeView adds icons and images to nodes to enhance visual hierarchy and clearly represent node types and states in applications."
            },
            new Sample
            {
                Name = "Lazy Loading",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/lazy-loading",
                Type = SampleType.None,
                FileName = "LazyLoading.razor",
                MetaTitle = "Blazor TreeView - Lazy Loading | Navigations Demos | Syncfusion",
                HeaderText = "Blazor TreeView Example - Lazy Loading",
                MetaDescription = "See how the Syncfusion Blazor TreeView loads child nodes on demand when parent nodes are expanded for better performance with large hierarchical datasets"
            },
            new Sample
            {
                Name = "Checkbox",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/checkbox",
                Type = SampleType.None,
                FileName = "CheckBox.razor",
                MetaTitle = "Blazor TreeView Demos - Checkbox | Navigations Demos | Syncfusion",
                HeaderText = "Blazor TreeView Example - Checkbox Selection",
                MetaDescription = "See how the Syncfusion Blazor TreeView supports cascading checkboxes for multi selection with parent child synchronization to manage hierarchical data clearly."
            },
             new Sample
            {
                Name = "Node Editing",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/node-editing",
                FileName = "NodeEditing.razor",
                MetaTitle = "Blazor TreeView - Node Editing | Navigations Demos | Syncfusion",
                HeaderText = "Blazor TreeView Example - Node Editing",
                MetaDescription = "See how the Syncfusion Blazor TreeView enables adding, renaming, and deleting nodes to support inline editing of hierarchical data structures in applications."
            },
             new Sample
            {
                Name = "Multiple Selection",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/multiple-selection",
                Type = SampleType.None,
                FileName = "MultipleSelection.razor",
                MetaTitle = "Blazor TreeView - Multiple Selection | Navigations Demos | Syncfusion",
                HeaderText = "Blazor TreeView Example - Multiple Selection",
                MetaDescription = "See how the Syncfusion Blazor TreeView selects multiple non-contiguous nodes with Ctrl+Click and contiguous ranges with Shift+Click for efficient operations"
            },
            new Sample
            {
                Name = "Drag and Drop",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/drag-and-drop",
                Type = SampleType.None,
                FileName = "DragAndDrop.razor",
                MetaTitle = "Blazor TreeView - Drag and Drop | Navigations Demos | Syncfusion",
                HeaderText = "Blazor TreeView Example - Drag and Drop",
                MetaDescription = "See how the Syncfusion Blazor TreeView moves nodes within or between trees with visual drag feedback for intuitive content reorganization and restructuring"
            },
            new Sample
            {
                Name = "Template",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor TreeView Demos - Template | Navigations Demos | Syncfusion",
                HeaderText = "Blazor TreeView Example - Custom Templates",
                MetaDescription = "See how the Syncfusion Blazor TreeView customizes nodes with rich HTML, images, and UI components using templates for branded and visually rich tree designs"
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/keyboard-navigation",
                Type = SampleType.None,
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor TreeView - Keyboard Navigation | Layouts Demos | Syncfusion",
                HeaderText = "Blazor TreeView Example - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor TreeView supports keyboard navigation to expand, collapse, and select nodes efficiently for improved accessibility and usability."
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "TreeView",
                Directory = "Navigations/TreeView",
                Url = "treeview/ui-virtualization",
                FileName = "UIVirtualization.razor",
                MetaTitle = "Blazor TreeView - Virtualization | Navigations Demos | Syncfusion",
                HeaderText = "Blazor TreeView Example - UI Virtualization",
                MetaDescription = "See how the Syncfusion Blazor TreeView renders visible nodes using data virtualization to improve performance and handle large hierarchical data efficiently."
            },
              new Sample
            {
                Name = "Local Data",
                Category = "Data Binding",
                Directory = "Navigations/TreeView",
                Url = "treeview/local-data",
                FileName = "LocalData.razor",
                MetaTitle = "Blazor TreeView - Local Data | Navigations Demos | Syncfusion",
                HeaderText = "Blazor TreeView Example - Local Data Binding",
                MetaDescription = "See how the Syncfusion Blazor TreeView binds to local collections for hierarchical data display with smooth rendering and responsive interaction easily."
            },
               new Sample
            {
                Name = "Remote Data",
                Category = "Data Binding",
                Directory = "Navigations/TreeView",
                Url = "treeview/remote-data",
                FileName = "RemoteData.razor",
                MetaTitle = "Blazor TreeView - Remote Data | Navigations Demos | Syncfusion",
                HeaderText = "Blazor TreeView Example - Remote Data Binding",
                MetaDescription = "See how the Syncfusion Blazor TreeView fetches hierarchical data from server sources asynchronously to populate nodes from remote APIs efficiently and reliably."
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
                MetaTitle = "Blazor FileManager - Overview | Navigations Demos | Syncfusion",
                HeaderText = "Blazor File Manager Example - Overview",
                MetaDescription = "See how the Syncfusion Blazor File Manager browses, uploads, downloads, and manages files with an intuitive UI for efficient and reliable file operations.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-manager"
            },
            new Sample
            {
                Name = "Flat Data",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/flat-data",
                FileName = "FlatData.razor",
                MetaTitle = "Blazor FileManager - Flat Data | Navigations Demos | Syncfusion",
                HeaderText = "Blazor File Manager Example - Flat Data Binding",
                MetaDescription = "See how the Syncfusion Blazor File Manager supports flat data binding to display and manage files from non hierarchical structures with flexible views.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-manager",
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
                MetaTitle = "Blazor FileManager Demos - Custom Thumbnails Examples | Syncfusion",
                HeaderText = "Blazor File Manager Example - Custom Thumbnails",
                MetaDescription = "See how the Syncfusion Blazor File Manager enables custom thumbnails to create personalized previews for files and folders based on file types or conditions.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-manager"
            },
             new Sample
            {
                Name = "Pagination",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/pagination",
                FileName = "Pagination.razor",
                MetaTitle = "Blazor FileManager - Pagination | Navigations Demos | Syncfusion",
                HeaderText = "Blazor File Manager Example - Pagination",
                MetaDescription = "See how the Syncfusion Blazor File Manager navigates large file lists using paging controls to enable organized browsing and improve overall performances.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-manager"
            },
             new Sample
            {
                Name = "API",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/api",
                FileName = "API.razor",
                MetaTitle = "Blazor File Manager Examples - API | Navigations Demos | Syncfusion",
                HeaderText = "Blazor File Manager Example - API Configuration",
                MetaDescription = "See how the Syncfusion Blazor File Manager uses API methods to control file operations programmatically and customize component behavior for better control.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-manager"
            },
            new Sample
            {
                Name = "Drag and Drop",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/drag-and-drop",
                FileName = "DragAndDrop.razor",
                MetaTitle = "Blazor File Manager - Drag and Drop | Navigations Demos | Syncfusion",
                HeaderText = "Blazor File Manager Example - Drag and Drop",
                MetaDescription = "See how the Syncfusion Blazor File Manager enables drag and drop to move files between folders for intuitive organization and efficient file management.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-manager"
            },
            new Sample
            {
                Name = "Directory Upload",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/directory-upload",
                FileName = "DirectoryUpload.razor",
                MetaTitle = "Blazor FileManager Demos - Directory Upload Examples | Syncfusion",
                HeaderText = "Blazor File Manager Example - Directory Upload",
                MetaDescription = "See how the Syncfusion Blazor File Manager supports directory upload to transfer entire folders while preserving structure for efficient bulk file management.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-manager"
            },
            new Sample
            {
                Name = "Sequential Upload",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/sequential-upload",
                FileName = "SequentialUpload.razor",
                MetaTitle = "Blazor FileManager Demos - Sequential Upload Examples | Syncfusion",
                HeaderText = "Blazor File Manager Example - Sequential Upload",
                MetaDescription = "See how the Syncfusion Blazor File Manager performs sequential uploads by sending files in queue order with progress tracking for reliable transfers easily.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-manager"
            },
            new Sample
            {
                Name = "Virtualization",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/virtualization",
                FileName = "Virtualization.razor",
                MetaTitle = "Blazor FileManager - Virtualization | Navigations Demos | Syncfusion",
                HeaderText = "Blazor File Manager Example - Virtualization",
                MetaDescription = "See how the Syncfusion Blazor File Manager renders only visible items with UI virtualization for smooth performance when handling large file collections",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-manager"
            },
            new Sample
            {
                Name = "Template",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor FileManager - Template | Navigations Demos | Syncfusion",
                HeaderText = "Blazor File Manager Example - Custom Templates",
                MetaDescription = "See how the Syncfusion Blazor File Manager uses templates to customize navigation nodes and layout items with icons, images, and rich content for file browsing.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-manager"
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "File Manager",
                Directory = "Navigations/FileManager",
                Url = "file-manager/keyboard-navigation",
                Type = SampleType.None,
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor FileManager Demos - Keyboard Navigation Examples | Syncfusion",
                HeaderText = "Blazor File Manager Example - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor File Manager navigates files and folders using keyboard shortcuts for accessible file management without mouse interaction",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-manager"
            },
            //new Sample
            //{
            //    Name = "Performance",
            //    Category = "Benchmark",
            //    Directory = "Navigations/FileManager",
            //    Url = "file-manager/flatdata-performance",
            //    Type = SampleType.New,
            //    FileName = "Performance.razor",
            //    MetaTitle = "Blazor FileManager - Performance | Navigations Demos | Syncfusion",
            //    HeaderText = "Blazor File Manager Example - Performance",
            //    MetaDescription = "See how the Syncfusion Blazor File Manager Performance demo handles large datasets with virtualization, efficient processing, and responsive UI rendering.",
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
                MetaTitle = "Blazor FileManager - Tag Search | Navigations Demos | Syncfusion",
                HeaderText = "Blazor FileManager - AI Powered Tag Search Example",
                MetaDescription = "See how the Syncfusion Blazor File Manager supports AI-driven tag search and tagging to enhance file discovery and improve overall user experience efficiently.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-manager",
                Type = SampleType.AI,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "FileManagerTagSearch",
                        FileName = "FileManagerTagSearch.razor"
                    },
                    new SourceCollection
                    {
                        Id = "FileManagerTagSearchCodeBehind",
                        FileName = "FileManagerTagSearch.razor.cs"
                    }
                }
            },
            // Ignore: From Build
            new Sample
            {
                Name = "Smart File Operations",
                Category = "Smart AI Solutions",
                Directory = "AISamples/FileManager",
                Url = "file-manager/ai-smart-filemanager",
                FileName = "SmartFileManager.razor",
                MetaTitle = "Blazor AI Demos - Smart File Operations Examples | Syncfusion",
                HeaderText = "Blazor FileManager - AI Powered File Operations Example",
                MetaDescription = "See how the Syncfusion Blazor File Manager uses AI-driven operations to improve file retrieval and management for seamless performance in applications.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-manager",
                Type = SampleType.AI,
                SourceFiles = new List<SourceCollection>()
                {
                    new SourceCollection
                    {
                        Id = "SmartFileManager",
                        FileName = "SmartFileManager.razor"
                    },
                    new SourceCollection
                    {
                        Id = "SmartFileManagerCodeBehind",
                        FileName = "SmartFileManager.razor.cs"
                    }
                }
            },
            // End: Ignore
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
                MetaTitle = "Blazor FileManager - Access Control | Navigations Demos | Syncfusion",
                HeaderText = "Blazor File Manager Example - Access Control",
                MetaDescription = "See how the Syncfusion Blazor File Manager enforces access control based on user permissions to ensure secure file handling and controlled operations.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-manager"
            },
            new Sample
            {
                Name = "File Upload",
                Category = "Use Case",
                Directory = "Navigations/FileManager",
                Url = "file-manager/file-upload",
                FileName = "FileUpload.razor",
                MetaTitle = "Blazor FileManager - File Upload | Navigations Demos | Syncfusion",
                HeaderText = "Blazor File Manager Example - File Upload",
                MetaDescription = "See how the Syncfusion Blazor File Manager supports file uploads with progress tracking and validation for secure and efficient file transfer operations.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-manager"
            },
            new Sample
            {
                Name = "Azure Blob Storage",
                Category = "Cloud Service Providers",
                Directory = "Navigations/FileManager",
                Url = "file-manager/azure",
                FileName = "Azure.razor",
                MetaTitle = "Blazor FileManager Demos - Azure Blob Storage Examples | Syncfusion",
                HeaderText = "Blazor File Manager Example - Azure Blob Storage Integration",
                MetaDescription = "See how the Syncfusion Blazor File Manager integrates Azure Blob Storage to browse and manage files stored securely in cloud environments for application use.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-manager"
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
                MetaTitle = "Blazor FileManager Demos - AmazonS3 File Provider | Syncfusion",
                HeaderText = "Blazor File Manager Example - Amazon S3 Integration",
                MetaDescription = "See how the Syncfusion Blazor File Manager integrates with Amazon S3 to browse and manage files stored in scalable AWS cloud storage services for applications.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-manager"
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
                MetaTitle = "Blazor FileManager Demos - IBM Cloud File Provider | Syncfusion",
                HeaderText = "Blazor File Manager Example - IBM Cloud Object Storage Integration",
                MetaDescription = "See how the Syncfusion Blazor File Manager integrates with IBM Cloud Object Storage to browse and manage files stored in secure cloud environments efficiently.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-file-manager"
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
                MetaTitle = "Blazor BreadCrumb Exxamples - Default | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Breadcrumb Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Breadcrumb creates hierarchical navigation paths showing user location within an application for easy backtracking and wayfinding",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-breadcrumb"
            },
             new Sample
            {
                Name = "Bind to Location",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/bind-to-location",
                FileName = "BindToLocation.razor",
                MetaTitle = "Blazor BreadCrumb - Bind to Location | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Breadcrumb Example - Location Binding",
                MetaDescription = "See how the Syncfusion Blazor Breadcrumb auto-generates navigation items from the current URL for dynamic breadcrumb trails reflecting application routes"
            },
            new Sample
            {
                Name = "Template and Customization",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/template-and-customization",
                MetaTitle = "Blazor BreadCrumb Demos - Template and Customization | Syncfusion",
                FileName = "TemplateAndCustomization.razor",
                HeaderText = "Blazor Breadcrumb Example - Custom Templates",
                MetaDescription = "See how the Syncfusion Blazor Breadcrumb customizes items with styles, icons, and dynamic content to create personalized navigation trails and waymarks"
            },
            new Sample
            {
                Name = "Overflow Modes",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/overflow-modes",
                FileName = "OverflowModes.razor",
                MetaTitle = "Blazor Breadcrumb - Overflow Modes | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Breadcrumb Example - Overflow Modes",
                MetaDescription = "See how the Syncfusion Blazor Breadcrumb manages long paths with wrap and scroll modes to support responsive navigation across different screen sizes."
            },
            new Sample
            {
                Name = "Events",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/events",
                FileName = "Events.razor",
                MetaTitle = "Blazor Breadcrumb Examples - Events | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Breadcrumb Example - Event Handling",
                MetaDescription = "See how the Syncfusion Blazor Breadcrumb handles item click events for custom navigation logic, routing, and interactive breadcrumb behavior and interactions"
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Breadcrumb",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/keyboard-navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor Breadcrumb - Keyboard Navigation | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Breadcrumb Example - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor Breadcrumb supports keyboard navigation using shortcuts to improve accessibility and enable efficient breadcrumb interaction."
            },
            new Sample
            {
                Name = "Address Bar",
                Category = "Use Case",
                Directory = "Navigations/Breadcrumb",
                Url = "breadcrumb/address-bar",
                FileName = "AddressBar.razor",
                MetaTitle = "Blazor BreadCrumb - Address Bar | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Breadcrumb Example - Address Bar Implementation",
                MetaDescription = "See how the Syncfusion Blazor Breadcrumb creates an editable address bar like file explorer for direct path navigation, editing, and location access easily."
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
                MetaTitle = "Blazor Carousel Demos - Default Functionalities Examples | Syncfusion",
                HeaderText = "Blazor Carousel Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Carousel shows multiple slides with preview of upcoming items to improve content discovery and smooth navigation in applications.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-carousel"

            },
            new Sample
            {
                Name = "Templates",
                Category = "Carousel",
                Directory = "Navigations/Carousel",
                Url = "carousel/templates",
                FileName = "Templates.razor",
                MetaTitle = "Blazor Carousel - Templates | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Carousel Example - Custom Templates",
                MetaDescription = "See how the Syncfusion Blazor Carousel customizes slides with HTML content, images, and interactive elements using templates for rich and branded presentations"
              
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "Carousel",
                Directory = "Navigations/Carousel",
                Url = "carousel/data-binding",
                FileName = "DataBinding.razor",
                MetaTitle = "Blazor Carousel - Data Binding | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Carousel Example - Data Binding",
                MetaDescription = "See how the Syncfusion Blazor Carousel binds to local and remote data sources to populate slides dynamically for flexible content presentation and management",
                Type = SampleType.None
             
            },
            new Sample
            {
                Name = "Keyboard Interactions",
                Category = "Carousel",
                Directory = "Navigations/Carousel",
                Url = "carousel/keyboard-interactions",
                FileName = "KeyboardInteractions.razor",
                MetaTitle = "Blazor Carousel Demos - Keyboard Interactions Examples| Syncfusion",
                HeaderText = "Blazor Carousel Example - Keyboard Interactions",
                MetaDescription = "See how the Syncfusion Blazor Carousel navigates slides using arrow keys and keyboard shortcuts for accessible slideshow control without mouse interaction",
                IsHideInMobile = true
            },
            new Sample
            {
                Name = "Partial Visible",
                Category = "Carousel",
                Directory = "Navigations/Carousel",
                Url = "carousel/partial-visible",
                FileName = "PartialVisible.razor",
                MetaTitle = "Blazor Carousel - Partial Visible | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Carousel Example - Partial Visible Items",
                MetaDescription = "See how the Syncfusion Blazor Carousel shows multiple slides with preview of upcoming slides to improve content discovery and smooth navigation in applications."
            },
            new Sample
            {
                Name = "Indicator Type",
                Category = "Carousel",
                Directory = "Navigations/Carousel",
                Url = "carousel/indicator-type",
                FileName = "IndicatorType.razor",
                MetaTitle = "Blazor Carousel - Indicator Type | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Carousel Example - Indicator Types",
                MetaDescription = "See how the Syncfusion Blazor Carousel customizes indicators as dots, numbers, or thumbnails to match app design for enhanced navigation visibility and appeal"
            },
            new Sample
            {
                Name = "API",
                Category = "Carousel",
                Directory = "Navigations/Carousel",
                Url = "carousel/api",
                FileName = "API.razor",
                MetaTitle = "Blazor Carousel Examples - API | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Carousel Example - API Configuration",
                MetaDescription = "See how the Syncfusion Blazor Carousel controls slide transitions, animations, and auto-play programmatically through its API for dynamic slideshow control"
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
                MetaTitle = "Blazor AppBar - Default Functionalities | Layouts Demos | Syncfusion",
                HeaderText = "Blazor AppBar Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor AppBar creates customizable top navigation bars with branding, menus, icons, and action buttons for modern application headers",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-appbar"
            },
            new Sample
            {
                Name = "Color",
                Category = "AppBar",
                Directory = "Navigations/AppBar",
                Url = "appbar/color",
                FileName = "Color.razor",
                MetaTitle = "Blazor AppBar Demos - Color Examples | Navigations Demos | Syncfusion",
                HeaderText = "Blazor AppBar Example - Color Variants",
                MetaDescription = "See how the Syncfusion Blazor AppBar supports color customization with themes and styling options to match branding and maintain visual design consistency."
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
                MetaTitle = "Blazor Stepper - Default Functionalities | Layouts Demos | Syncfusion",
                HeaderText = "Blazor Stepper Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Stepper creates step-by-step interfaces to guide users through sequential processes with numbered indicators and progress tracking",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-stepper"
            },
            new Sample
            {
                Name = "Orientation",
                Category = "Stepper",
                Directory = "Navigations/Stepper",
                Url = "stepper/orientation",
                FileName = "Orientation.razor",
                MetaTitle = "Blazor Stepper - Orientation | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Stepper Example - Orientation Options",
                MetaDescription = "See how the Syncfusion Blazor Stepper switches between horizontal and vertical layouts to suit different app designs, space constraints, and workflows",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Linear Flow",
                Category = "Stepper",
                Directory = "Navigations/Stepper",
                Url = "stepper/linear-flow",
                FileName = "Linear.razor",
                MetaTitle = "Blazor Stepper - Linear Flow | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Stepper Example - Linear Flow Navigation",
                MetaDescription = "See how the Syncfusion Blazor Stepper enforces sequential progress where users must complete each step before proceeding to the next for guided workflows",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Validation",
                Category = "Stepper",
                Directory = "Navigations/Stepper",
                Url = "stepper/validation",
                FileName = "Validation.razor",
                MetaTitle = "Blazor Stepper - Validation | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Stepper Example - Step Validation",
                MetaDescription = "See how the Syncfusion Blazor Stepper validates form data within each step before allowing users to advance for error-free data collection and accurate inputs",
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
                MetaTitle = "Blazor Ribbon Examples - Default | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Ribbon Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Ribbon creates Microsoft Office-style interfaces with tabs, groups, and commands for comprehensive application command layouts",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-ribbon",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "DefaultFunctionalities.razor",
                        Id="DefaultFunctionalities",
                    },
                    new SourceCollection
                    {
                        FileName = "DefaultFunctionalities.razor.css",
                        Id="DefaultFunctionalitiesStyle"
                    }
                }
            },
            new Sample
            {
                Name = "Simplified",
                Category = "Ribbon",
                Directory = "Navigations/Ribbon",
                Url = "ribbon/simplified",
                FileName = "Simplified.razor",
                MetaTitle = "Blazor Ribbon Examples - Simplified | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Ribbon Example - Simplified Mode",
                MetaDescription = "See how the Syncfusion Blazor Ribbon provides a compact simplified mode with minimized tabs and commands to support space efficient layouts and usage.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "Simplified.razor",
                        Id="SimplifiedMode",
                    },
                    new SourceCollection
                    {
                        FileName = "Simplified.razor.css",
                        Id="SimplifiedModeStyle"
                    }
                }
            },
            new Sample
            {
                Name = "Backstage",
                Category = "Ribbon",
                Directory = "Navigations/Ribbon",
                Url = "ribbon/backstage",
                FileName = "Backstage.razor",
                MetaTitle = "Blazor Ribbon Examples - Backstage | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Ribbon Example - Backstage Implementation",
                MetaDescription = "See how the Syncfusion Blazor Ribbon displays a full-screen backstage menu for file operations like open, save, and print similar to MS Office applications",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "Backstage.razor",
                        Id="Backstage",
                    },
                    new SourceCollection
                    {
                        FileName = "Backstage.razor.css",
                        Id="BackstageStyle"
                    }
                }
            },
            new Sample
            {
                Name = "Contextual Tabs",
                Category = "Ribbon",
                Directory = "Navigations/Ribbon",
                Url = "ribbon/contextual",
                FileName = "ContextualTabs.razor",
                MetaTitle = "Blazor Ribbon - Contextual Tabs | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Ribbon Example - Contextual Tabs",
                MetaDescription = "See how the Syncfusion Blazor Ribbon dynamically shows specialized contextual tabs based on selection context to streamline and organize app command visibility",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "ContextualTabs.razor",
                        Id="ContextualTabs",
                    },
                    new SourceCollection
                    {
                        FileName = "ContextualTabs.razor.css",
                        Id="ContextualTabsStyle"
                    }
                }
            },
            new Sample
            {
                Name = "Ribbon Resizing",
                Category = "Ribbon",
                Directory = "Navigations/Ribbon",
                Url = "ribbon/resize",
                FileName = "Resize.razor",
                MetaTitle = "Blazor Ribbon - Ribbon Resizing | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Ribbon Example - Responsive Resizing",
                MetaDescription = "See how the Syncfusion Blazor Ribbon automatically adapts its layout to different screen sizes for optimal usability and consistent appearance across devices",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "Resize.razor",
                        Id="Resize",
                    },
                    new SourceCollection
                    {
                        FileName = "Resize.razor.css",
                        Id="ResizeStyle"
                    }
                }
            },
            new Sample
            {
                Name = "Ribbon KeyTips",
                Category = "Ribbon",
                Directory = "Navigations/Ribbon",
                Url = "ribbon/keytip",
                FileName = "KeyTips.razor",
                MetaTitle = "Blazor Ribbon - Ribbon KeyTips | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Ribbon Example - KeyTips Implementation",
                MetaDescription = "See how the Syncfusion Blazor Ribbon displays keyboard shortcut hints over commands to enable quick mouse free access to ribbon functionality and features.",
                Type = SampleType.None,
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "KeyTips.razor",
                        Id="KeyTips",
                    },
                    new SourceCollection
                    {
                        FileName = "KeyTips.razor.css",
                        Id="KeyTipsStyle"
                    }
                }
            },
            new Sample
            {
                Name = "Ribbon Gallery",
                Category = "Ribbon",
                Directory = "Navigations/Ribbon",
                Url = "ribbon/gallery",
                FileName = "Gallery.razor",
                MetaTitle = "Blazor Ribbon - Ribbon Gallery | Navigations Demos | Syncfusion",
                HeaderText = "Blazor Ribbon Example - Gallery Implementation",
                MetaDescription = "See how the Syncfusion Blazor Ribbon creates visual galleries with previews to help select styles and options similar to Microsoft Office applications.",
                SourceFiles = new List<SourceCollection>
                {
                    new SourceCollection
                    {
                        FileName = "Gallery.razor",
                        Id="Gallery",
                    },
                    new SourceCollection
                    {
                        FileName = "Gallery.razor.css",
                        Id="GalleryStyle"
                    }
                }
            }
        };

    }
}