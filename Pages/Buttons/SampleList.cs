using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Button { get; set; } = new List<Sample>{
           new Sample
            {
                Name = "Default Functionalities",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
				TitleTag = "Button . DefaultFunctionalities . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the types (flat, toggle, outline, round), sizes and styles (primary, success) of the Syncfusion Blazor button.",
                ActionDescription = new string[] {
                    @" <p>
                        This sample demonstrates the default functionalities of the Button component with different types and predefined styles.

                    </p>"
                },
               Description = new string[]{
                    @"<p>
                    Button is a graphical user interface element that triggers an event on click action. It contains the text, an image, or both.
                </p>
                <p>
                    In this sample, Play button is a toggle button and it can be enabled by using the <code><a target=""_blank"" class=""code""
                    href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Buttons.SfButton~IsToggle.html"">IsToggle
                    </a></code> property. To change the text and icon you should handle click event.
                </p>
                <p>
                    More information about Blazor Button component can be found in this
                    <a target=""_blank""
                    href=""https://ej2.syncfusion.com/blazor/documentation/button/getting-started/"">
                    documentation section</a>.
                </p>"
                }
            },
           new Sample
            {
                Name = "Checkbox",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/checkbox",
                FileName = "CheckBox.razor",
				TitleTag = "Button . Checkbox . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the three different states (checked, unchecked, indeterminate) of the Syncfusion ASP.NET Core Blazor CheckBox.",
                ActionDescription = new string[] {
                    @" <p>
                        This sample demonstrates the default functionalities of the CheckBox component. Click the CheckBox element to toggle states between checked/unchecked.

                    </p>"
                },
                Description = new string[]{
                                @"<p>
                        CheckBox is a graphical user interface element that allows to select one or more options from the choices. It contains checked, unchecked, and indeterminate states.
                    </p>
                    <p>
                        In this sample, checked state is achieved by using the
                        <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Buttons.SfCheckBox~Checked.html'>
                            <code>
                                Checked
                            </code>
                        </a> property, indeterminate state is achieved by using the <a target = '_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Buttons.SfCheckBox~Indeterminate.html'>
                            <code>
                                Indeterminate
                            </code>
                        </a> property, and disabled state is achieved by using the <a target='_blank' href='https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Buttons.SfCheckBox~Disabled.html'>
                            <code>
                                Disabled
                            </code>
                        </a> property.
                    </p>
                    <p>
                        More information about Blazor CheckBox component can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/check-box/getting-started/"">
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
                Url = "buttons/radio-button",
                FileName = "RadioButton.razor",
				TitleTag = "Button . Radio Button . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the group functionality of the Syncfusion Blazor RadioButton with checked and unchecked states.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default functionalities of the RadioButton component. Select the payment mode by clicking the desired RadioButton element.</p>"
                },
                Description = new string[]{
                        @"<p>
                        RadioButton is a graphical user interface element that allows to select one option from the choices. It contains checked and unchecked state.
                    </p>
                    <p>
                        In this sample, Credit/Debit Card option is checked by default, and it can be achieved by using the <a target=""_blank"" class=""code""
                                                                                                                            href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Buttons.SfRadioButton~Checked.html"">
                            <code>
                                Checked
                            </code>
                        </a> property.
                    </p>
                    <p>
                        More information about Blazor RadioButton component can be found in this
                        <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/radio-button/getting-started/"">
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
                Url = "buttons/dropdown-menu",
                FileName = "DropDownButton.razor",
				TitleTag = "Button . Dropdown Menu . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the usecases of the Syncfusion Blazor DropDownMenu with icons, text and separator in popup action items.",
                ActionDescription = new string[] {
                   @"<p>This sample demonstrates the default functionalities of the DropDownMenu component. Clicking DropDownMenu component will display popup with list of action items.</p>"
                },
                Description = new string[]{
                            @"<p>
                    The DropDownMenu component is used to toggle contextual overlays for displaying list of action items. It can contain both text and images.
                </p>
                <p>
                    In this sample, DropDownMenu contains icon, content and list of action items, and can be added using
                    <code>
                        <a target=""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.SplitButtons.SfDropDownButton~IconCss.html"">IconCss
                        </a>
                    </code>,
                    <code>
                        <a target=""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.SplitButtons.SfDropDownButton~Content.html"">Content
                        </a>
                    </code> and
                    <code>
                        <a target = ""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.SplitButtons.SfDropDownButton~Items.html"">Items
                        </a>
                    </code> property.
                </p>
                <p>
                    More information about Blazor DropDownMenu component can be found in this
                    <a target = ""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/drop-down-button/getting-started/"">
                        documentation section</a>.
                </p>"
                }
            },
           new Sample
            {
                Name = "Split Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/split-button",
                FileName = "SplitButton.razor",
				TitleTag = "Button . Split Button . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the usecases of the Syncfusion Blazor SplitButton with icons and text in primary splitbutton.",
                ActionDescription = new string[] {
                   @"<p>This sample demonstrates the default functionalities of the SplitButton component. By clicking primary button default action will be triggered and clicking secondary button will display popup with list of action items.</p>"
                },
                Description = new string[]{
                    @"<p>
                    The SplitButton component has primary and secondary buttons. Primary button is used to select default action and secondary button is used to toggle contextual overlays for displaying list of action items. It can contain both text and images.
                </p>
                <p>
                    In this sample, SplitButton contains icon, content and list of action items, and can be added using
                    <code><a target=""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.SplitButtons.SfSplitButton~IconCss.html"">IconCss
                    </a></code>,
                    <code><a target=""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.SplitButtons.SfSplitButton~Content.html"">Content
                    </a></code>and
                    <code><a target = ""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.SplitButtons.SfSplitButton~Items.html"">Items
                    </a></code> property.
                </p>
                <p>
                    More information about Blazor SplitButton component can be found in this
                    <a target = ""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/split-button/getting-started/"">
                        documentation section</a>.
                </p>"
                }
            },
           new Sample
            {
                Name = "Toggle Switch Button",
                Category = "Button",
                Directory = "Buttons/Button",
                Url = "buttons/toggle-switch-button",
                FileName = "Switch.razor",
				TitleTag = "Button . Switch . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the toggle states (checked, unchecked) of the Syncfusion Blazor Switch.",
                ActionDescription = new string[] {
                            @"<p>This sample demonstrates the default functionalities of a Switch component. Click the Switch element to toggle between checked and
                unchecked states.</p>"
                },
               Description = new string[]{
                @"<p>
                        The Switch is a graphical user interface element that allows you to toggle between checked and unchecked states.
                    </p>
                    <p>
                        In this sample, checked state is achieved by using the
                        <a target=""_blank"" class=""code""
                        href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Buttons.SfSwitch~Checked.html"">
                            <code>
                                Checked
                            </code>
                        </a> property, and disabled state is achieved by using the <a target = ""_blank"" class=""code""
                        href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Buttons.SfSwitch~Disabled.html"">
                            <code>
                                Disabled
                            </code>
                        </a> property.
                    </p>
                    <p>
                        More information about Blazor Switch component can be found in this
                        <a target = ""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/switch/getting-started/"">
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
                Url = "buttons/progress-button",
                FileName = "ProgressButton.razor",
				TitleTag = "Button . ProgressButton . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the different functionalities of the Syncfusion Blazor ProgressButton with spinner and progress indicator.",
                ActionDescription = new string[] {
                            @"<p>This sample demonstrates the default functionalities of a progress button component. Clicking that button will display a spinner
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
                                <a target=""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.SplitButtons.SfProgressButton~Content.html"">Content,
                                </a>
                    </code>
                    <code>
                                <a target=""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.SplitButtons.SfProgressButton~CssClass.html"">CssClass,
                                </a>
                    </code>and
                    <code>
                            <a target = ""_blank"" class=""code"" href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.SplitButtons.SfProgressButton~EnableProgress.html"">EnableProgress
                            </a>
                    </code>property.
                </p>
                <p>
                    More information about Blazor progress button component can be found in this
                    <a target = ""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/progress-button/getting-started/"">
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
                Url = "chips/default-functionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                            @"<p>
                    This sample demonstrates the default functionalities of Chips with different types and predefined styles. Click
                    and interact the Chip, to select single or multiple options from Chips collection.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    Chip is a small block of essential information that triggers an event on click action. It contains the text, an
                    image, or both, mostly used in contacts, mails or filter tags.
                </p>
                <p>In this sample, Default, Input, Filter and Choice Chips are demonstrated with their default functionalities.</p>
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
                Url = "chips/api",
                FileName = "API.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                                @"<p>This sample demonstrates most commonly used API functionalities of Chip control from the property pane. Select
                    any combination of properties from the property pane to customize the appearance of Chip.</p>"
                },
                Description = new string[] {
                    @"<p>In this sample, Default Chip is rendered with minimal configuration.</p>
                    <p>
                    This sample can be customized further with the combination of Chip properties from the property pane. For
                    example,
                    </p>
                    <ul>
                        <li>Color variant can be changed by selecting the color DropdownList from property pane.</li>
                        <li>Leading and Trailing icons can be enabled by selecting Leading or Trailing Icon checkbox from property
                            pane.</li>
                        <li>Leading icon can be customized with avatar initials, icons and images from property pane</li>
                        <li>Outline Chip type can be enabled by checking outline checkbox from property pane.</li>
                    </ul>"
                }
            }

        };
    }
}
