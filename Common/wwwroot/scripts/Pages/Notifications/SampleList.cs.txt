using System.Collections.Generic;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> Toast { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Toast Examples - Default | Notifications Demos | Syncfusion",
                HeaderText = "Blazor Toast Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Toast displays notifications with customizable duration, position, and appearance for non-intrusive user feedback and alerts.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-toast"
            },
            new Sample
            {
                Name = "Types",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/types",
                FileName = "Types.razor",
                MetaTitle = "Blazor Toast Examples - Toast Types | Notifications Demos | Syncfusion",
                HeaderText = "Blazor Toast Example - Notification Types",
                MetaDescription = "See how the Syncfusion Blazor Toast renders success, error, warning, and info notifications with color-coded alerts to convey importance and context clearly."
            },
            new Sample
            {
                Name = "Template",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/template",
                FileName = "Template.razor",
                MetaTitle = "Blazor Toast Demos - Template | Notifications Demos | Syncfusion",
                HeaderText = "Blazor Toast Example - Custom Templates",
                MetaDescription = "See how the Syncfusion Blazor Toast creates notifications using custom templates with images, formatted text, and interactive elements for rich content display."
            },
            new Sample
            {
                Name = "Position",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/position",
                FileName = "Position.razor",
                MetaTitle = "Blazor Toast Examples - Position | Notifications Demos | Syncfusion",
                HeaderText = "Blazor Toast Example - Notification Positioning",
                MetaDescription = "See how the Syncfusion Blazor Toast positions notifications at various screen locations like corners and edges to optimize visibility and user experience."
            },
            new Sample
            {
                Name = "API",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/api",
                FileName = "API.razor",
                MetaTitle = "Blazor Toast Examples- API | Notifications Demos | Syncfusion",
                HeaderText = "Blazor Toast Example - API Functionality",
                MetaDescription = "See how the Syncfusion Blazor Toast controls notifications programmatically to show, hide, and customize messages dynamically based on application events."
            }
        };
        public List<Sample> Spinner { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "Spinner",
                Directory = "Notifications/Spinner",
                Type = SampleType.None,
                Url = "spinner/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor Spinner - Overview | Notifications Demos | Syncfusion",
                HeaderText = "Blazor Spinner Example - Overview",
                MetaDescription = "See how the Syncfusion Blazor Spinner displays visual feedback during data loading, processing, and page transitions with customizable spinner styles and sizes.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-spinner"
            }
        };
        public List<Sample> Message { get; set; } = new List<Sample>
        {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Message",
                Directory = "Notifications/Message",
                Url = "message/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Message Examples - Default | Notifications Demos | Syncfusion",
                HeaderText = "Blazor Message Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Message displays contextual information, warnings, errors, and success messages within content to improve user communication.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-message"
            },
            new Sample
            {
                Name = "Variants",
                Category = "Message",
                Directory = "Notifications/Message",
                Url = "message/variants",
                FileName = "Variants.razor",
                MetaTitle = "Blazor Message - Variants | Notifications Demos | Syncfusion",
                HeaderText = "Blazor Message Example - Style Variants",
                MetaDescription = "See how the Syncfusion Blazor Message offers filled, outlined, and text visual styles to match your application design and enhance message presentation."
            },
            new Sample
            {
                Name = "Icons",
                Category = "Message",
                Directory = "Notifications/Message",
                Url = "message/icons",
                FileName = "Icons.razor",
                MetaTitle = "Blazor Message Examples - Icons | Notifications Demos | Syncfusion",
                HeaderText = "Blazor Message Example - Custom Icons",
                MetaDescription = "See how the Syncfusion Blazor Message uses custom icons to reinforce message context and improve user understanding through enhanced visual communication."
            },
            new Sample
            {
                Name = "Customization",
                Category = "Message",
                Directory = "Notifications/Message",
                Url = "message/Customization",
                FileName = "Customization.razor",
                MetaTitle = "Blazor Message - Customization | Notifications Demos | Syncfusion",
                HeaderText = "Blazor Message Example - Advanced Customization",
                MetaDescription = "See how the Syncfusion Blazor Message customizes styling with colors, borders, backgrounds, and dimensions to match your app theme and personalize appearance."
            },
            new Sample
            {
                Name = "Template",
                Category = "Message",
                Directory = "Notifications/Message",
                Url = "message/Template",
                FileName = "Template.razor",
                MetaTitle = "Blazor Message - Template | Notifications Demos | Syncfusion",
                HeaderText = "Blazor Message Example - Custom Templates",
                MetaDescription = "See how the Syncfusion Blazor Message creates rich notifications with structured layouts, interactive elements, and multimedia content using custom templates."
            }
        };
        public List<Sample> Skeleton { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Skeleton",
                Directory = "Notifications/Skeleton",
                Url = "skeleton/defaultfunctionalities",
                FileName = "Default.razor",
                MetaTitle = "Blazor Skeleton - Default | Notifications Demos | Syncfusion",
                HeaderText = "Blazor Skeleton Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Skeleton displays content placeholders during data loading to mimic layout and improve perceived performance in applications.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-skeleton"
            },
            new Sample
            {
                Name = "Animation",
                Category = "Skeleton",
                Directory = "Notifications/Skeleton",
                Url = "skeleton/animation",
                FileName = "Animation.razor",
                MetaTitle = "Blazor Skeleton - Animation | Notifications Demos | Syncfusion",
                HeaderText = "Blazor Skeleton Example - Animation Effects",
                MetaDescription = "See how the Syncfusion Blazor Skeleton applies pulse, wave, or fade animations to skeleton elements for enhanced visual indication of loading processes.",
                Type = SampleType.None
            }
        };
        public List<Sample> Badge { get; set; } = new List<Sample>{
            new Sample 
            {
                Name = "Default",
                Category = "Badge",
                Directory = "Notifications/Badge",
                Url = "badge/defaultfunctionalities",
                FileName = "Default.razor",
                MetaTitle = "Blazor Badge Examples - Default | Notifications Demos | Syncfusion",
                HeaderText = "Example of Default Functionalities in Blazor CSS Badge Component",
                MetaDescription = "See how the Syncfusion Blazor Badge displays counters and status indicators to highlight information with customizable styles attached to UI elements.",
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-badge"
            },
            new Sample
            {
                Name = "Types",
                Category = "Badge",
                Directory = "Notifications/Badge",
                Url = "badge/types",
                FileName = "Types.razor",
                MetaTitle = "Blazor Toast Demos - Badge Types | Notifications Demos | Syncfusion",
                HeaderText = "Example of Types in Blazor CSS Badge Component",
                MetaDescription = "See how the Syncfusion Blazor Badge renders primary, success, warning, danger, and info variants for context-appropriate visual communication and status."
            },
            new Sample
            {
                Name = "Notification",
                Category = "Badge",
                Directory = "Notifications/Badge",
                Url = "badge/notification",
                FileName = "Notification.razor",
                MetaTitle = "Blazor Badge - Notification | Notifications Demos | Syncfusion",
                HeaderText = "Example of Blazor CSS Badge Component as Notification",
                MetaDescription = "See how the Syncfusion Blazor Badge shows notification counters on icons and buttons with positioned badges to display unread counts and numeric indicators."
            },
            new Sample
            {
                Name = "ListView",
                Category = "Integration",
                Directory = "Notifications/Badge",
                Url = "badge/listview",
                FileName = "ListView.razor",
                MetaTitle = "Blazor Badge Examples - ListView | Notifications Demos | Syncfusion",
                HeaderText = "Example of Blazor CSS Badge Component in ListView",
                MetaDescription = "See how the Syncfusion Blazor Badge integrates with ListView to display counts and status indicators alongside items for better visual information display."
            },
            new Sample
            {
                Name = "Accordion",
                Category = "Integration",
                Directory = "Notifications/Badge",
                Url = "badge/accordion",
                FileName = "Accordion.razor",
                MetaTitle = "Blazor Badge Examples - Accordion | Notifications Demos | Syncfusion",
                HeaderText = "Example of Blazor CSS Badge Component in Accordion",
                MetaDescription = "See how the Syncfusion Blazor Badge adds status indicators or counters to accordion headers to show content state or quantity information for better navigation."
            },
            new Sample
            {
                Name = "Toolbar",
                Category = "Integration",
                Directory = "Notifications/Badge",
                Url = "badge/toolbar",
                FileName = "Toolbar.razor",
                MetaTitle = "Blazor Badge Examples - Toolbar | Notifications Demos | Syncfusion",
                HeaderText = "Example of Blazor CSS Badge Component in Toolbar",
                MetaDescription = "See how the Syncfusion Blazor Badge in Toolbar displays counters and indicators with API, styling, and events for quick access and improved navigation"
            }
        };
    }
}