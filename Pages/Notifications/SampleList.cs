using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
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
                Type = SampleType.New,
                TitleTag = "Toast . Default Functionalities . Syncfusion Blazor Components",
                MetaDescription = "The sample demonstrates about default functionalities of a Toast control and helps to design reminder like an alert in Blazor platform.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the basic layout of a Toast to show simple notification and hide them.</p>"
                },
                Description = new string[] {
                    @"<p>The <code>Toast</code> is a notification pop-up used to display on the desired position with required message and header icons.</p>
                <ul>
                    <li>The header text is set using <code>Title</code> property.</li>
                    <li>Information to be displayed is set using <code>Content</code> property.</li>
                </ul>
                <p>
                    More information about Toast can be found in this
                    <a href=""https://blazor.syncfusion.com/documentation/toast/getting-started/"" target=""_blank""> documentation section</a>.
                </p>"
                }
            },
            new Sample
            {
                Name = "Types",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/types",
                FileName = "Types.razor",
                Type = SampleType.New,
                TitleTag = "Toast . Types . Syncfusion Blazor Components",
                MetaDescription = "The sample demonstrates how to design success, warning, information, and error messages using Toast control based on CSS classes in Blazor platform.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates 4-predefined toast colors for various scenarios which can be using CSS class.</p>"
                },
                Description = new string[] {
                    @"<p>The Toast supports the following 4 different essential colors for various situations. Here we have achieved success, danger, warning, info notifications with corresponding icon and text message. All the classes should be added with .e-toast class.</p>
            <ul>
                <li><code>Information</code> - The <b>e-toast-info</b> class applies the color and background for showing toast information.</li>
                <li><code>Success</code> - The <b>e-toast-success</b> class applies the color and background for notifying success action.</li>
                <li><code>Warning</code> - The <b>e-toast-warning</b> class applies the color and background for showing warning message.</li>
                <li><code>Danger</code> - The <b>e-toast-danger</b> class applies the color and background for showing error/failure toast.</li>
            </ul>
            <p>
                More information on the Blazor Toast Types can be found in this
                <a href=""https://blazor.syncfusion.com/documentation//toast/how-to/show-different-types-of-toast/"" target=""_blank""> documentation section</a>.
            </p>"
                }
            },
            new Sample
            {
                Name = "Template",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/template",
                FileName = "Template.razor",
                Type = SampleType.New,
                TitleTag = "Toast . Template . Syncfusion Blazor Components - Preview",
                MetaDescription = "The example demonstrates how to render Blazor toast notification using Templates whether it may be an HTML as string or HTML elements.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the Template rendering of the Toast. Static HTML toast to display an alarm notification which can be snoozed or dismissed and Dynamic template rendered using template engine to display mail remainders."
                },
                Description = new string[] {
                    @"<p>This sample illustrates the way to display the template content on the Toast. With the usage of Template, the user can format and structure the HTML content to be displayed on the toast as per their application needs.
                </p>
                <p>
                    <ul>
                        <li>Alarm Toast is integrated with button and drop-down list that allows to set timeOut for toast and close it.</li>
                        <li>Dynamic Toast opened based on the data source given to add mail reminder notifications and it can be hidden using the close button available</li>
                    </ul>
                </p>
                <p>
                    More information on the Blazor Toast Template can be found in this
                    <a href=""https://blazor.syncfusion.com/documentation//toast/template/"" target=""_blank""> documentation section</a>.
                </p>"
                }
            },
            new Sample
            {
                Name = "Position",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/position",
                FileName = "Position.razor",
                Type = SampleType.New,
                TitleTag = "Toast . Position . Syncfusion Blazor Components",
                MetaDescription = "The sample demonstrates how to display the toast notification with various built-in or custom position based on target or page in Blazor platform.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the different positioning of the Toast based on the target given.</p>"
                },
                Description = new string[] {
                    @"<p>Based on the use case toast can take the body element or any specific element as target. In this sample, with help of custom inputs toast can be positioned based on the target.</p>
            <ul>
                <li>Toast can be positioned in the 8 pre-defined places.</li>
                <li>Custom option will enable to give X and Y values to align the toast based on the given inputs.</li>
            </ul>
            <p>
                More information on the Blazor Toast Position can be found in this
                <a href=""https://blazor.syncfusion.com/documentation//toast/position/"" target=""_blank""> documentation section</a>.
            </p>"
                }
            },
            new Sample
            {
                Name = "API",
                Category = "Toast",
                Directory = "Notifications/Toast",
                Url = "toast/api",
                FileName = "API.razor",
                Type = SampleType.New,
                TitleTag = "Toast . API . Syncfusion Blazor Components",
                MetaDescription = "The sample exposes the available properties, methods, and events of Toast control which helps to create flexible toast in Blazor platform.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates all the API functionalities available in Toast.</p>"
                },
                Description = new string[] {
                    @"<p>In this sample, with help of text inputs toast header title and content text can be provided.</p>
            <ul>
                <li><code>Action Buttons</code> – Provide support to add a button inside toast to interact with it.</li>
                <li><code>Prevent Duplicates</code> – Disable the user to create same toast message multiple times.</li>
                <li><code>TimeOut</code> – Allows to set time in millisecond to close toast.</li>
                <li><code>Progress Bar</code> – Visualizes the time out of toast as an indicator.</li>
                <li><code>Animation</code> – Enables to define the toast show and hide animation.</li>
                <li><code>Close button</code> – Show close button to hide toast irrespective of time out.</li>
            </ul>
            <p>
                More information about Toast can be found in this
                <a href=""https://blazor.syncfusion.com/documentation//toast/getting-started/"" target=""_blank""> documentation section</a>.
            </p>"
                }
            }
        };
        public List<Sample> Spinner { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Spinner",
                Directory = "Notifications/Spinner",
                Url = "spinner/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                TitleTag = "Spinner . Default Functionalities . Syncfusion Blazor Components",
                MetaDescription = "The demo example explains how to render, show and hide the Blazor Spinner (loading indicator) through public utility functions with different types.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates how to create Spinner over tab component using utility functions.  Passed the tab container element as target to create the Spinner.  Show or hide the Spinner by clicking the corresponding buttons. You can see different types of spinner by choosing corresponding type from dropdown list.
                </p>"
                },
                Description = new string[] {
                    @"<p>The Spinner is also known loading indicator and waiting popup. It displayed over a target area and used to prevent the user interactions while loading. Provided public utility functions to create, show, and hide the Spinner.</p>
                    <p>In the above sample, the Spinner target property is set to tab container. The Spinner is shown based on specified target property and prevented on user interaction with target area.<p>
                    <p>In addition, provided option to pass type of Spinner to render it based on application theme. The available Spinner types are as follows:</p>
                    <ul>
                    <li>Material</li>
                    <li>Fabric</li>
                    <li>Bootstrap</li>
                    <li>HighContrast</li>
                    <li>Bootstrap4</li>
                    </ul>"
                }
            }
        };
    }
}
