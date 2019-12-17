using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Button { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default Functionalities",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
				TitleTag = "Button . DefaultFunctionalities . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the types (flat, toggle, outline, round), sizes and styles (primary, success) of the Syncfusion ASP.NET Core Blazor button.",
                ActionDescription = new string[] {
                    @" <p>
                        This sample demonstrates the default functionalities of the Button with different types and predefined styles.

                    </p>"
                },
               Description = new string[]{
                    @"<p>
                    Button is a graphical user interface element that triggers an event on click action. It contains the text, an image, or both.
                </p>
                <p>
                    In this sample, Play button is a toggle button and it can be enabled by using the <code><a target=""_blank"" class=""code""
                    href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Buttons.EjsButton~IsToggle.html"">IsToggle
                    </a></code> property. To change the text and icon you should handle click event.
                </p>
                <p>
                    More information about Button can be found in this
                    <a target=""_blank""
                    href=""https://ej2.syncfusion.com/aspnet-core-blazor/documentation/button/getting-started/"">
                    documentation section</a>.
                </p>"
                }
            },
           new Sample
            {
                Name = "Checkbox",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/CheckBox",
                FileName = "CheckBox.razor",
				TitleTag = "Button . Checkbox . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the three different states (checked, unchecked, indeterminate) of the Syncfusion ASP.NET Core Blazor CheckBox.",
                ActionDescription = new string[] {
                    @" <p>
                        This sample demonstrates the default functionalities of the CheckBox. Click the CheckBox element to toggle states between checked/unchecked.

                    </p>"
                },
                Description = new string[]{
                                @"<p>
                        CheckBox is a graphical user interface element that allows to select one or more options from the choices. It contains checked, unchecked, and indeterminate states.
                    </p>
                    <p>
                        In this sample, checked state is achieved by using the
                        <a target='_blank' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Buttons.EjsCheckBox~Checked.html'>
                            <code>
                                Checked
                            </code>
                        </a> property, indeterminate state is achieved by using the <a target = '_blank' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Buttons.EjsCheckBox~Indeterminate.html'>
                            <code>
                                Indeterminate
                            </code>
                        </a> property, and disabled state is achieved by using the <a target='_blank' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Buttons.EjsCheckBox~Disabled.html'>
                            <code>
                                Disabled
                            </code>
                        </a> property.
                    </p>
                    <p>
                        More information about CheckBox can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/aspnet-core-blazor/documentation/check-box/getting-started/"">
                            documentation section
                        </a>.
                    </p>"
                }
            },
           new Sample
            {
                Name = "Radio Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/RadioButton",
                FileName = "RadioButton.razor",
				TitleTag = "Button . Radio Button . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the group functionality of the Syncfusion ASP.NET Core Blazor RadioButton with checked and unchecked states.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default functionalities of the RadioButton. Select the payment mode by clicking the desired RadioButton element.</p>"
                },
                Description = new string[]{
                        @"<p>
                        RadioButton is a graphical user interface element that allows to select one option from the choices. It contains checked and unchecked state.
                    </p>
                    <p>
                        In this sample, Credit/Debit Card option is checked by default, and it can be achieved by using the <a target=""_blank"" class=""code""
                                                                                                                            href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Buttons.EjsRadioButton~Checked.html"">
                            <code>
                                Checked
                            </code>
                        </a> property.
                    </p>
                    <p>
                        More information about RadioButton can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/aspnet-core-blazor/documentation/radio-button/getting-started/"">
                            documentation section
                        </a>.
                    </p>"

                }
            },
           new Sample
            {
                Name = "Dropdown Menu",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/DropDownButton",
                FileName = "DropDownButton.razor",
				TitleTag = "Button . Dropdown Menu . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the usecases of the Syncfusion ASP.NET Core Blazor DropDownButton with icons, text and separator in popup action items.",
                ActionDescription = new string[] {
                   @"<p>This sample demonstrates the default functionalities of the DropDownButton. Clicking DropDownButton will display popup with list of action items.</p>"
                },
                Description = new string[]{
                            @"<p>
                    The DropDownButton component is used to toggle contextual overlays for displaying list of action items. It can contain both text and images.
                </p>
                <p>
                    In this sample, DropDownButton contains icon, content and list of action items, and can be added using
                    <code>
                        <a target=""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.SplitButtons.EjsDropDownButton~IconCss.html"">IconCss,
                        </a>
                    </code>
                    <code>
                        <a target=""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.SplitButtons.EjsDropDownButton~Content.html"">Content
                        </a>
                    </code> and
                    <code>
                        <a target = ""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.SplitButtons.EjsDropDownButton~Items.html"">Items
                        </a>
                    </code> property.
                </p>
                <p>
                    More information about DropDownButton can be found in this
                    <a target = ""_blank"" href=""https://ej2.syncfusion.com/aspnet-core-blazor/documentation/drop-down-button/getting-started/"">
                        documentation section</a>.
                </p>"
                }
            },
           new Sample
            {
                Name = "Split Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/SplitButton",
                FileName = "SplitButton.razor",
				TitleTag = "Button . Split Button . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the usecases of the Syncfusion ASP.NET Core Blazor SplitButton with icons and text in primary splitbutton.",
                ActionDescription = new string[] {
                   @"<p>This sample demonstrates the default functionalities of the SplitButton. By clicking primary button default action will be triggered and clicking secondary button will display popup with list of action items.</p>"
                },
                Description = new string[]{
                    @"<p>
                    The SplitButton component has primary and secondary buttons. Primary button is used to select default action and secondary button is used to toggle contextual overlays for displaying list of action items. It can contain both text and images.
                </p>
                <p>
                    In this sample, SplitButton contains icon, content and list of action items, and can be added using
                    <code><a target=""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.SplitButtons.EjsSplitButton~IconCss.html"">IconCss
                    </a></code>,
                    <code><a target=""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.SplitButtons.EjsSplitButton~Content.html"">Content
                    </a></code>and
                    <code><a target = ""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.SplitButtons.EjsSplitButton~Items.html"">Items
                    </a></code> property.
                </p>
                <p>
                    More information about SplitButton can be found in this
                    <a target = ""_blank"" href=""https://ej2.syncfusion.com/aspnet-core-blazor/documentation/split-button/getting-started/"">
                        documentation section</a>.
                </p>"
                }
            },
           new Sample
            {
                Name = "Switch",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/Switch",
                FileName = "Switch.razor",
				TitleTag = "Button . Switch . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the toggle states (checked, unchecked) of the Syncfusion ASP.NET Core Blazor Switch.",
                ActionDescription = new string[] {
                            @"<p>This sample demonstrates the default functionalities of a Switch. Click the Switch element to toggle between checked and
                unchecked states.</p>"
                },
               Description = new string[]{
                @"<p>
                        The Switch is a graphical user interface element that allows you to toggle between checked and unchecked states.
                    </p>
                    <p>
                        In this sample, checked state is achieved by using the
                        <a target=""_blank"" class=""code""
                        href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Buttons.EjsSwitch~Checked.html"">
                            <code>
                                Checked
                            </code>
                        </a> property, and disabled state is achieved by using the <a target = ""_blank"" class=""code""
                        href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Buttons.EjsSwitch~Disabled.html"">
                            <code>
                                Disabled
                            </code>
                        </a> property.
                    </p>
                    <p>
                        More information on Switch can be found in this
                        <a target = ""_blank"" href=""https://ej2.syncfusion.com/aspnet-core-blazor/documentation/switch/getting-started/"">
                            documentation section
                        </a>.
                    </p>"
                }
            },
           new Sample
            {
                Name = "Progress Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "Buttons/ProgressButton",
                FileName = "ProgressButton.razor",
				TitleTag = "Button . ProgressButton . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the different functionalities of the Syncfusion ASP.NET Core Blazor ProgressButton with spinner and progress indicator.",
                ActionDescription = new string[] {
                            @"<p>This sample demonstrates the default functionalities of a progress button. Clicking that button will display a spinner
                and a progress indicator.</p>"
                },
               Description = new string[]{
                    @"<p>
                    The progress button visualizes the progression of an operation to indicates the user that a process is happening in the background.
                    The progress can be shown with graphics accompanied by a textual representation.
                </p>
                <p>
                    In this sample, the progress button contains the content, spinner, progress indicator, and a list of related features that
                    can be achieved using
                    <code>
                                <a target=""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.SplitButtons.EjsProgressButton~Content.html"">Content,
                                </a>
                    </code>
                    <code>
                                <a target=""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.SplitButtons.EjsProgressButton~CssClass.htmll"">CssClass,
                                </a>
                    </code>and
                    <code>
                            <a target = ""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.SplitButtons.EjsProgressButton~EnableProgress.html"">EnableProgress
                            </a>
                    </code>property.
                </p>
                <p>
                    More information about progress button can be found in this
                    <a target = ""_blank"" href=""https://ej2.syncfusion.com/aspnet-core-blazor/documentation/progress-button/getting-started/"">
                        documentation section</a>.
                </p>"
                }
            },
        };
        public List<Sample> Chips { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Chips",
                Directory = "Buttons/Chips",
                Url = "Chips/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                            @"<p>
                    This sample demonstrates the default functionalities of Chips with different types and predefined styles. Click
                    and interact the chip, to select single or multiple options from chips collection.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Chip is a small block of essential information that triggers an event on click action. It contains the text, an
                    image, or both, mostly used in contacts, mails or filter tags.
                </p>
                <p>In this sample, default, input, filter and choice chips are demonstrated with their default functionalities.</p>
                <ol>
                    <li><b>Input chip</b>– Basic chip with delete icon, enables to remove chips from the chip list collection.</li>
                    <li><b>Choice chip</b> – Used to choose a choice from available options.</li>
                    <li><b>Filter chip</b> – Used to select multiple choices from available options.</li>
                </ol>"
                }
            },
            new Sample
            {
                Name = "API",
                Category = "Chips",
                Directory = "Buttons/Chips",
                Url = "Chips/API",
                FileName = "API.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                                @"<p>This sample demonstrates most commonly used API functionalities of chip control from the property pane. Select
                    any combination of properties from the property pane to customize the appearance of chip.</p>"
                },
                Description = new string[] {
                    @"<p>In this sample, default chip is rendered with minimal configuration.</p>
                    <p>
                    This sample can be customized further with the combination of Chip properties from the property pane. For
                    example,
                    </p>
                    <ul>
                        <li>Color variant can be changed by selecting the color dropdownlist from property pane.</li>
                        <li>Leading and Trailing icons can be enabled by selecting Leading or Trailing Icon checkbox from property
                            pane.</li>
                        <li>Leading icon can be customized with avatar initials, icons and images from property pane</li>
                        <li>Outline chip type can be enabled by checking outline checkbox from property pane.</li>
                    </ul>"
                }
            }

        };
    }
}
