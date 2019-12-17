using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Dialog { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "Dialog/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                TitleTag = "Dialog . Default Functionalities . Syncfusion Blazor Components",
                MetaDescription = "The example demonstrates the default rendering of the Blazor dialog, which supports modal and non-modal (modeless), built-in buttons, and more.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the default rendering of the dialog component with minimum configuration. Click close or press ESC to close the dialog. Click “open” to show the dialog again, if it is closed.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The dialog component is used to display information and get input from the user. The dialog component is classified as modal and non-modal dialog depend on its interaction with parent application.
                    </p>
                    <ul>
                        <li>
                            Modal - It creates overlay that disable interaction with the parent application, and user should respond with modal before continuing with other applications.
                        </li>
                        <li>
                            Non-modal - It does not prevent user interaction with parent application.
                        </li>
                    </ul>"
                }
            },
            new Sample
            {
                Name = "Custom Dialogs",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "Dialog/CustomDialogs",
                FileName = "CustomDialogs.razor",
                Type = SampleType.New,
                TitleTag = "Dialog . Custom Dialogs . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates how to create custom dialogs such as alert dialogs, confirmation dialogs, and prompt dialogs using the Blazor dialog control.",
                ActionDescription = new string[] {
                    @"<p>
                        This example demonstrates the different types of Dialog like alert, confirm, and prompt. The buttons 'Alert', 'Confirm', and 'Prompt' will be shown after closing the alert Dialog. These buttons are used to open the corresponding Dialogs.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The Dialog control is used to display messages such as supplementary content like images and text, and an interactive content like form components within a web page. The following are the two types of Dialogs:
                    </p>
                    <ul>
                        <li>
                            Alert - Used to show errors, warnings, and information that needs user awareness.
                        </li>
                        <li>
                            Prompt - Used to get input from the user.
                        </li>
                        <li>
                            Confirmation - Used to get approval from user that appears before any critical action.
                        </li>
                    </ul>
                    </p>"
                }
            },
            new Sample
            {
                Name = "Modal",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "Dialog/Modal",
                FileName = "Modal.razor",
                Type = SampleType.New,
                TitleTag = "Dialog . Modal . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the modal pop-up behavior of the Blazor dialog control, which helps display critical information such as errors and warnings.",
                ActionDescription = new string[] {
                @"<p>
                This example demonstrates that the modal behavior of Dialog control. Choose ""Close on overlay"" option from property panel to decide whether the Dialog will be closed on click on the overlay.
                Click on ""Open"" button to show the Dialog again if it is closed.</p>"
                },
                Description = new string[] {
                @"<p>    
                    A modal prevents the access to the parent application, so that the user should interact with the Dialog compulsory before continuing
                    the parent application.
                </p>
                <p>More information on the modal behavior of Dialog can be found in the
                <a target='_blank' href=""https://ej2.syncfusion.com/blazor/documentation/dialog/getting-started/""> documentation section</a>.
                </p>"
            }
            },
            new Sample
            {
                Name = "Template",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "Dialog/Template",
                FileName = "Template.razor",
                Type = SampleType.New,
                TitleTag = "Dialog . Template . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates how to customize user interface elements like the header, footer, and content of the Blazor dialog control using a template.",
                ActionDescription = new string[] {
                    @"<p>
                        This example demonstrates the template functionalities of the dialog component. The dialog Header and Footer is configured with HTML template. The typed content will be replaced every time when clicking the 'send' button.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The dialog component displays HTML template content on the Header and Footer. The user can set any HTML element as Header and Footer with the usage of content and FooterTemplate properties.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Draggable",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "Dialog/Draggable",
                FileName = "Draggable.razor",
                Type = SampleType.New,
                TitleTag = "Dialog . Draggable . Syncfusion Blazor Components",
                MetaDescription = "This example, shows how to enable drag-and-drop actions in the Blazor dialog control to help reposition the dialog efficiently.",
                ActionDescription = new string[] {
                    @"<p>
                        This example demonstrates the drag-and-drop operation of the dialog component. To begin drag-and-drop operation, select a dialog's header using mouse and dropping them in the desired location. The dialog can be draggable within the sample container. Enable the 'open dialog' button to reopen the dialog if it is closed.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        A drag-and-drop operation is enabled using the <code>AllowDragging</code> property. when you configure the <code>Target</code> property, he dialog can be draggable within its target container alone. The drag-and-drop feature is used to reposition the dialog dynamically.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Resizable",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "Dialog/Resizable",
                FileName = "Resizable.razor",
                Type = SampleType.New,
                TitleTag = "Dialog . Resizable . Syncfusion Blazor Components",
                MetaDescription = "This example shows how to create resizable modal in the Blazor dialog to change the size of a dialog efficiently and view its content more comfortably.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the resize operation of the dialog component. To resize the modal dialog, select and resize a dialog using its handle (grip) within the sample container.
                        The ""open dialog"" button is used to reopen the dialog if it is closed.
                    </p>"
                },
                Description = new string[] {
                    @" <p>
                        Users can create resizable modal dialog by setting the EnableResize property to true, which is used to change the size of a dialog dynamically and view its content with expanded mode.
                        When you configure the Target property along with EnableResize property, the dialog can be resized within its specified target container.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Positioning",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "Dialog/Positioning",
                FileName = "Positioning.razor",
                Type = SampleType.New,
                TitleTag = "Dialog . Positioning . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates how to display the Blazor dialog control at various built-in and custom positions.",
                ActionDescription = new string[] {
                    @"<p>
                        This example demonstrates how to position the dialog control. Select the appropriate radio button to position where the dialog is displayed. The current position of the dialog is at the bottom. Enable the 'open dialog' button to reopen the dialog if it is closed.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        By default, the dialog is displayed in the center of the target container. Use the Position property to set location where the dialog displays relative to the target. The property point-out the horizontal and vertical coordinates. You can set position with specific X and Y coordinates in pixel values.
                    </p>"
                }
            },
            // new Sample
            // {
            //     Name = "Animation",
            //     Category = "Dialog",
            //     Directory = "Popups/Dialog",
            //     Url = "Dialog/Animation",
            //     FileName = "Animation.razor",
            //     Type = SampleType.New,
            //     ActionDescription = new string[] {
            //         @"<p>
            //             This example demonstrates how to open or close the dialog with animation effects by clicking the appropriate button.
            //         </p>"
            //     },
            //     Description = new string[] {
            //         @"<p>
            //             The dialog can be opened or closed with animation effect using the <code>DialogAnimationSettings</code> property. You can also customize the duration of animation and delay to begin animation. Disables the dialog's animation by setting the animation effect as none.
            //         </p>"
            //     }
            // },
            new Sample
            {
                Name = "Multiple Dialogs",
                Category = "Dialog",
                Directory = "Popups/Dialog",
                Url = "Dialog/MultipleDialogs",
                FileName = "MultipleDialogs.razor",
                Type = SampleType.New,
                TitleTag = "Dialog . Multiple Dialogs . Syncfusion Blazor Components",
                MetaDescription = "This example shows how to display multiple dialogs sequentially and open multiple dialogs simultaneously for both modal and modeless Blazor dialogs.",
                ActionDescription = new string[] {
                    @"<p>
                        This example demonstrates how to display multiple dialogs one over the other. The second dialog is configured with draggable behavior to adjust its position. You can invoke the second dialog from first dialog's button. Enable the 'open dialog' button to reopen the dialog if the first dialog is closed.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        You can configure the dialog as a parent and child, and invoke the child dialog from its parent dialog. In addition, multiple dialogs can be shown at a time in a page. The Z- index order will be controlled automatically in the browser and manually using the <code>zIndex</code> property.
                    </p>"
                }
            }
        };
        public List<Sample> Tooltip { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "Tooltip/Default",
                FileName = "Default.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                This sample demonstrates the default functionalities of the Tooltip which will open
                by Hover or Touch-hold action on button and displayed in 12 different positions.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    This sample illustrates a tooltip, that gets opened on hovering the target labelled “Show Tooltip”. The tooltip can be shown
                    on 12 possible positions, by selecting the appropriate position values provided in the dropdown. The applicable tooltip
                    positions are as follows:
                </p>
                <ul>
                    <li><code>TopLeft</code></li>
                    <li><code>TopCenter</code></li>
                    <li><code>TopRight</code></li>
                    <li><code>BottomLeft</code></li>
                    <li><code>BottomCenter</code></li>
                    <li><code>BottomRight</code></li>
                    <li><code>LeftTop</code></li>
                    <li><code>LeftCenter</code></li>
                    <li><code>LeftBottom</code></li>
                    <li><code>RightTop</code></li>
                    <li><code>RightCenter</code></li>
                    <li><code>RightBottom</code></li>
                </ul>
                <p>In case, if the tooltip needs to be opened on mobile devices, tap hold on the target labelled “Show Tooltip” instead of hovering
                    and by default, it closes after 1.5 seconds on lift.</p>"
                }
            },
            new Sample
            {
                Name = "HtmlTemplate",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "Tooltip/HtmlTemplate",
                FileName = "HtmlTemplate.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates customizing tooltip content to display a HTML page.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                Tooltip content has been customized using HTML tags and CSS, i.e. the content can be loaded with HTML tags such
                    as &lt;img&gt;,
                    &lt;a&gt;,&lt;b&gt;, etc. Title can also be added to the content. Overall, the tooltip content can be
                    customized to appear like a web page.
                </p>"
                }
            },
            new Sample
            {
                Name = "API",
                Category = "Tooltip",
                Directory = "Popups/Tooltip",
                Url = "Tooltip/Api",
                FileName = "Api.razor",
                Type = SampleType.New,
                 ActionDescription = new string[] {},
                Description = new string[] {}
            }
        };   
    }
}
