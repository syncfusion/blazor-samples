using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> TextBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "TextBox",
                Directory = "Inputs/TextBox",
                Url = "TextBox/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                TitleTag = "TextBox . DefaultFunctionalities . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the default functionalities of the TextBox component. Type a character in the TextBox element or focus-in to the TextBox for floating the label text. The label will be positioned back to TextBox on focus-out without value.",
                ActionDescription = new string[]
                {
                            @"<p>
                        This sample demonstrates the default functionalities of the <code>TextBox</code> component. Type a character in the TextBox element or focus-in to the TextBox for floating the label text. The label will be positioned back to TextBox on focus-out without value.
                    </p>"
                },
                Description = new string[]
                {
                            @"<p>
                        A TextBoxes are an input element that allows to get input from the user. It allows the user either to edit or display the input values.
                    </p>
                    <br>
                    <table style=""width:100%"">
                        <tr>
                            <th>Types</th>
                            <th>Description</th>
                        </tr>
                        <tr>
                            <td>Outlined & Filled Textbox</td>
                            <td>
                                You can render the following two types of text fields in the material theme by adding <b>e-outline</b> and <b>e-filled</b> class to cssClass API
                                <ul>
                                    <li>Filled text fields</li>
                                    <li>Outlined text fields</li>
                                </ul>
                            </td>
                        </tr>
                        <tr>
                            <td>Floating Label</td>
                            <td>
                                You can render floating textbox with <b>e-float-input</b> class added and need to maintain the following structure
                                of elements.
                                <ul>
                                    <li>Create group element with<b>e-float-input</b> class added.</li>
                                    <li>Input element with<b> required</b> attribute.</li>
                                    <li>Span element with<b> e-float-line</b> class.</li>
                                    <li>Label element with<b> e-float-text</b> class.</li>
                                </ul>
                            </td>
                        </tr>
                        <tr>
                            <td>Floating Label & Elements</td>
                            <td>
                                You can render floating textbox with icons added with in group element<b>e-input-group</b> and need to maintain
                                the following structure of elements.
                                <ul>
                                    <li>Create group element with <b>e-float-input</b> class added.</li>
                                    <li>Input element with<b> required</b> attribute.</li>
                                    <li>Span element with<b> e-float-line</b> class.</li>
                                    <li>Label element with<b> e-float-text</b> class.</li>
                                    <li>Append or prepend the span element with class <b>e-input-group-icon</b> added.</li>
                                </ul>
                            </td>
                        </tr>
                        <tr>
                            <td>Default TextBox</td>
                            <td>
                                <div style = ""padding-bottom: 10px"" >
                                    You can render textbox by adding class as <b>e-input</b>.You can also render textbox as group by adding
                                    parent element with<b>e-input-group</b> class added.
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>RTL TextBox</td>
                            <td>
                                <div style = ""padding-bottom: 10px"" >
                                    Set <b>e - input</b> and <b>e - rtl</b> classes to render textbox in right to left direction. For rendering
                                    group in RTL mode, class list will be like<b> e-input-group e-rtl</b>.
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>Disabled TextBox</td>
                            <td>
                                <div style = ""padding-bottom: 10px"" > You set html disabled attribute to textbox. For parent group element, you can disable it by adding <b>e-disabled</b>                    class.</div>
                            </td>
                        </tr>
                        <tr>
                            <td>Readonly TextBox</td>
                            <td>
                                <div style = ""padding-bottom: 10px"" > You set html readonly attribute to textbox.</div>
                            </td>
                        </tr>
                        <tr>
                            <td>Validation states</td>
                            <td>
                                <div style = ""padding-bottom: 10px"" >
                                    You can apply validation states success, warning, error to the textbox with the corresponding classes added
                                    to the input element such as <b>e-success</b>, <b>e-warning</b>, <b>e-error</b>.
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>Sizing</td>
                            <td>
                                <div style = ""padding-bottom: 10px"" >
                                    You can render small sizing textbox by adding<b> e-small</b> class to the input element.By default normal
                                size considered.
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>Input & elements</td>
                            <td>
                                You can render textbox with icons in the below format,
                                <ul>
                                    <li>Create group element with<b>e-input-group</b> class added.</li>
                                    <li>
                                        Add input element with<b>e-input</b> and span element with<b> e-input-group-icon</b> inside the input
                                        group element.
                                    </li>
                                    <li>
                                        You can add the icon either before or after the textbox by placing<b> e-input-group-icon</b> class named
                                        element in specific place.
                                    </li>
                                </ul>
                            </td>
                        </tr>
                    </table>
                    <br>"
                }
            },
            new Sample
            {
                Name = "Multiline TextBox",
                Category = "TextBox",
                Directory = "Inputs/TextBox",
                Url = "TextBox/Multiline",
                FileName = "Multiline.razor",
                TitleTag = "TextBox . Multiline . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the multiline functionalities of the Textbox component. Enter or fill the textbox with multiple rows of text. Choose the corresponding option from the property panel to update the multiline textbox.",
                ActionDescription = new string[] {
                    @"<p>This example demonstrates the multiline functionalities of the <code>Textbox</code> component. Enter or fill the textbox with multiple rows of text. Choose the corresponding option from the property panel to update the multiline textbox.</p>"
                },
                Description = new string[] {
                    @" <p>
                        The Multiline Textbox is used to edit or display multiple lines of text that helps you to accept address, description, comments, feedbacks, and more in a form. In this sample, rendered multiline textbox from <b>textarea</b> tag and the following options are available to customize it:
                    </p>
                    <p>
                        <ul>
                        <li>Choose float label types either 'Never', 'Always', or 'Auto' to float the placeholder text.</li>
                        <li>To make a read-only multiline textbox, check the 'read-only' option.</li>
                        <li>Disable the textbox by unchecking an 'enabled' option.</li>
                        <li>Change the number of rows count to restrict the length of the input..</li>
                        </ul>
                    </p>
                    <p>
                        More information on the multiline feature can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/textbox/multiline/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            }
        };

        public List<Sample> ColorPicker { get; set; } = new List<Sample>
        {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "ColorPicker",
                Directory = "Inputs/ColorPicker",
                Url = "ColorPicker/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
				TitleTag = "ColorPicker . DefaultFunctionalities . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the default functionalities of the Syncfusion ASP.NET Core Blazor ColorPicker with RGB, HSV and Hex codes(three, six and eight digit).",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default functionalities of the color picker/palette with default colors and predefined styles.</p>"
                },
                Description = new string[]{
                    @" <p>
                    The ColorPicker is a user interface to select and adjust color values. This supports various color specifications like RGB
                    (Red Green Blue), HSV (Hue Saturation Value), and Hex codes.
                </p>
                <p>
                    In this sample, the ColorPicker popup contains picker area, slider to adjust hue and opacity value, input textarea, and control
                    buttons.
                </p>
                <ul>
                    <li>Drag the handle in the Picker area to select your favorite color.</li>
                    <li>You can manually set the color by typing the color values in the input text boxes</li>
                    <li>By clicking the format switching icon at the right side of the input text area, switch between rgb and hsv color
                        value format.</li>
                    <li>By clicking the mode switching icon at the left bottom of the popup, switch between picker and palette type.</li>
                    <li>Using the
                        <code>
                            <a target=""_blank"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Inputs.EjsColorPicker~Value.html"">Value</a>
                        </code> property, set the color value to picker and palette initially.</li>
                </ul>
                <p>
                    In mobile mode, the popup opens at the center of the viewport.
                <p>
                <p>
                    More information about ColorPicker can be found in this
                    <a target=""_blank"" href=""https://ej2.syncfusion.com/aspnet-core-blazor/documentation/color-picker/getting-started/"">
                        documentation section</a>.
                </p>"
                }
            },
            new Sample
            {
                Name = "Inline Mode",
                Category = "ColorPicker",
                Directory = "Inputs/ColorPicker",
                Url = "ColorPicker/Inline",
                FileName = "Inline.razor",
				TitleTag = "ColorPicker . Inline . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the inline / flat mode rendering of the Syncfusion ASP.NET Core Blazor ColorPicker with hue and opacity color options.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default functionalities of the color picker/palette with default colors and predefined styles.</p>"
                },
                Description = new string[]{
                    @" <p>
                    The ColorPicker component is a user interface to select and adjust color values. This supports various color specifications
                    like RGB (Red Green Blue), HSV (Hue Saturation Value), and Hex codes.
                </p>
                <p>
                    In this sample,
                </p>
                <ul>
                    <li>Color picker/palette is rendered inline by using the inline
                        <code>
                            <a target=""_blank"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Inputs.EjsColorPicker~Inline.html"">Inline</a>
                        </code> property set to
                        <i>true</i>.</li>
                    <li>Using the
                        <code>
                            <a target=""_blank"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Inputs.EjsColorPicker~Mode.html"">Mode</a>
                        </code> property, you can specify the mode
                        <i>(Picker/ Palette)</i> of the ColorPicker.</li>
                    <li>Using the
                        <code>
                            <a target=""_blank"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Inputs.EjsColorPicker~ShowButtons.html"">ShowButtons</a>
                        </code> property, you can enable or disable the control
                        <i>(apply/cancel)</i> buttons.</li>
                </ul>
                <p>
                    More information about ColorPicker can be found in this
                    <a target=""_blank"" href=""https://ej2.syncfusion.com/aspnet-core-blazor/documentation/color-picker/getting-started/"">
                        documentation section</a>.
                </p>"

                }
            },
            new Sample
            {
                Name = "Custom Palettes",
                Category = "ColorPicker",
                Directory = "Inputs/ColorPicker",
                Url = "ColorPicker/Custom",
                FileName = "Custom.razor",
				TitleTag = "ColorPicker . Custom . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the Syncfusion ASP.NET Core Blazor ColorPicker, custom UI of the color palette with different structures and its state.",
                ActionDescription = new string[] {
                @"<p>This sample demonstrates how to customize the color palettes with different types and styles.</p>"
                },
                Description = new string[]{
                    @" <p>
                    The ColorPicker component is a user interface to select and adjust color values. This supports various color specifications
                    like RGB (Red Green Blue), HSV (Hue Saturation Value), and Hex codes.
                </p>
                <p>
                    In this sample,
                </p>
                <ul>
                    <li>
                        Select the shirt color from different customized palettes. It contains circle, square, rounded edge, and multiple
                        scroll palettes.
                    </li>
                    <li>Using the
                        <code>
                            <a target=""_blank"" href=""https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Inputs.EjsColorPicker~Value.html"">Value</a>
                        </code> property, set the color value to picker and palette initially.</li>
                </ul>
                <p>
                    More information about ColorPicker can be found in this
                    <a target=""_blank"" href=""https://ej2.syncfusion.com/aspnet-core-blazor/documentation/color-picker/getting-started/"">
                        documentation section</a>.
                </p>"

                }
            },
            new Sample
            {
                Name = "API",
                Category = "ColorPicker",
                Directory = "Inputs/ColorPicker",
                Url = "ColorPicker/Api",
                FileName = "Api.razor",
				TitleTag = "ColorPicker . Api . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the supported API's and its functionalities of the Syncfusion ASP.NET Core Blazor ColorPicker.",
                ActionDescription = new string[] {
                @"<p>This sample demonstrates customization of the ColorPicker component by using its properties from the property pane. Select
                    any combination of properties from the property pane to customize the ColorPicker component.</p>"
                },
                Description = new string[]{
                    @" <p>
                    The ColorPicker is a user interface to select and adjust color values. This supports various color specifications like RGB
                    (Red Green Blue), HSV (Hue Saturation Value), and Hex codes.
                </p>
                <p>
                    In this sample, ColorPicker is rendered with default configuration.
                </p>
                <p>
                    This sample can be customized further with the combination of ColorPicker properties from the property pane. For example,
                </p>
                <ul>
                    <li>Control (apply/cancel) buttons can be enabled or disabled using
                        <i>Show Buttons</i> checkbox from the property pane.</li>
                    <li>You can select the color by entering the color value in the property pane
                        <i>Value</i> textbox.</li>
                    <li>You can switch to ""Picker"" and ""Palette"" modes by clicking and selecting the mode from
                        <i>Select Mode</i> dropdownlist.</li>
                    <li>you can enable or disable the ColorPicker using
                        <i>Disabled</i> checkbox from property pane.</li>
                    <li>you can enable or disable the mode switcher using
                        <i>Mode Switcher</i> checkbox from property pane.</li>
                </ul>
                <p>
                    More information about ColorPicker can be found in this
                    <a target=""_blank"" href=""https://ej2.syncfusion.com/aspnet-core-blazor/documentation/color-picker/getting-started/"">
                        documentation section</a>.
                </p>"
                }
            }
        };

        public List<Sample> MaskedTextBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "MaskedTextBox",
                Directory = "Inputs/MaskedTextBox",
                Url = "MaskedTextBox/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                TitleTag = "MaskedTextBox . DefaultFunctionalities . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates that the default functionalities of MaskedTextBox component. Enter numeric value for “Mobile Number” textbox then press tab key and then enter “Country ISO Code” in alphabetic format, then type “D.O.B” in numeric format. Finally enter the “Product Key” in alpha numeric format.",
                ActionDescription = new string[]
                {
                    @"<p>This sample demonstrates that the default functionalities of MaskedTextBox component. Enter numeric value for “Mobile Number” textbox then press tab key and then enter “Country ISO Code” in alphabetic format, then type “D.O.B” in numeric format. Finally enter the “Product Key” in alpha numeric format.</p>"
                        },
                Description = new string[]
                {
                    @" <p>
                        The <b>MaskedTextBox</b> is a textbox extended component that allows the user to enter only the valid input based on the provided mask. It is used to get the input with specific formats like Phone number, Date, Time, IP, Social security number, etc.
                    </p>
                    <p>
                        MaskedTextBox supports the list of mask elements based on the standard MSDN mask elements.
                        </p>
                    <p>
                        More information about MaskedTextBox can be found in this
                        <a target=""_blank""
                        href=""https://ej2.syncfusion.com/blazor/documentation/maskedtextbox/getting-started/"">
                            documentation section
                        </a>.
                    </p>"
                        }
            },
             new Sample
            {
                Name = "Custom Mask",
                Category = "MaskedTextBox",
                Directory = "Inputs/MaskedTextBox",
                Url = "MaskedTextBox/CustomMask",
                FileName = "CustomMask.razor",
                TitleTag = "MaskedTextBox . CustomMask . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates that the custom mask functionalities of MaskedTextBox component. Enter time value in meridiem format, and enter IP value in numeric format.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates that the custom mask functionalities of MaskedTextBox component. Enter time value in meridiem format, and enter IP value in numeric format.</p>"
                },
                Description = new string[]{
                    @"<p>
                        The custom mask is achieved by the following ways:
                    </p>
                    <p>
                        <b>Custom characters:</b>
                    </p>
                    <p>
                        You can form the mask with any non-mask elements (literals), and you can configure the behavior of that non-mask element as mask element through the customCharacters property.
                    </p>
                    <p>
                        In this demo, the “Time” mask '99 : 99 >PM' contains the literals P and M, where it is configured to allow the inputs as 'P', 'A', 'p', 'a', and 'M', 'm'.
                    </p>
                    <p>
                        <b>Regular expression:</b>
                    </p>
                    <p>
                    <p>
                        Alternatively, you can use the regular expressions as mask element to validate the input of the particular input place.
                    </p>
                    <p>
                        Here, in the “IP Address” example, each character is masked by an regular expression to allow a particular range of values.
                    </p>
                        More information about MaskedTextBox can be found in this
                        <a target=""_blank""
                        href=""https://ej2.syncfusion.com/blazor/documentation/maskedtextbox/mask-configuration/#custom-mask-elements"">
                            documentation section
                        </a>.
                    </p>"
                }
            }
        };

        public List<Sample> NumericTextBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "NumericTextBox",
                Directory = "Inputs/NumericTextBox",
                Url = "NumericTextBox/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                TitleTag = "NumericTextBox . DefaultFunctionalities . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the default functionalities of the Numeric TextBox. Type a value in the input element to change the value dynamically.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default functionalities of the Numeric TextBox. Type a value in the input element to change the value dynamically, or press up/down arrow button to increase/decrease the value with a predefined step value.</p>"
                },
                Description = new string[] {
                    @" <p>
                        The NumericTextBox provides an option to customize the display format of the numeric value using the format property. It accepts the standard numeric format string and custom numeric format string as specified in
                        <a target=""_blank""href=""https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings"">MSDN</a>. The formatted value displays when the component is not focused.
                    </p>
                    <p>
                        The NumericTextBox component is used to get the number inputs from the user. The input values can be increased or decreased with a predefined step value.
                    </p>
                    <p>
                        In this demo, the default NumericTextBox is rendered with the percent and currency formats as specified in <a target=""_blank""href=""https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings"">MSDN</a>.
                    </p>
                    <p>
                        More information about NumericTextBox can be found in this
                        <a target=""_blank""
                        href=""https://ej2.syncfusion.com/blazor/documentation/numerictextbox/getting-started/"">
                            documentation section
                        </a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Custom Format",
                Category = "NumericTextBox",
                Directory = "Inputs/NumericTextBox",
                Url = "NumericTextBox/CustomFormat",
                FileName = "CustomFormat.razor",
                TitleTag = "NumericTextBox . CustomFormat . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the custom format functionalities of the Numeric TextBox. The value of Numeric TextBox will be displayed with defined custom format while type a value or change a value using up/down buttons in the input boxes.",
                ActionDescription = new string[]
                {
                    @"<p>This sample demonstrates the custom format functionalities of the Numeric TextBox. The value of Numeric TextBox will be displayed with defined custom format while type a value or change a value using up/down buttons in the input boxes.</p>"
                                },
                Description = new string[] {
                    @"<p>
                        The NumericTextBox provides an option to customize the display format of the numeric value using the format property. It accepts the standard numeric format string and custom numeric format string as specified in MSDN. The formatted value displays when the component is not focused.
                    </p>
                    <p>
                        In this demo, NumericTextBox control renders with the custom format ###.## km.
                    </p>
                    <p>
                        More information about NumericTextBox can be found in this
                        <a target=""_blank""
                        href=""https://ej2.syncfusion.com/blazor/documentation/numerictextbox/formats/#custom-formats"">
                            documentation section
                        </a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Restrict Decimals",
                Category = "NumericTextBox",
                Directory = "Inputs/NumericTextBox",
                Url = "NumericTextBox/RestrictDecimals",
                FileName = "RestrictDecimals.razor",
                TitleTag = "NumericTextBox . RestrictDecimals . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the decimal functionalities of the Numeric TextBox. Type a value in the input element to change dynamically, and it allows maximum of 3 decimal digits.",
                ActionDescription = new string[]
                {
                    @"<p>This sample demonstrates the decimal functionalities of the Numeric TextBox. Type a value in the input element to change dynamically, and it allows maximum of 3 decimal digits.</p>"
                        },
                        Description = new string[]
                {
                    @" <p>
                        The NumericTextBox provides an option to restrict the number of decimal values, by using the decimals property. To restrict the number of decimal values on typing, use the decimals and validateDecimalOnType properties.
                    </p>
                    <p>
                        More information about NumericTextBox can be found in this
                        <a target=""_blank""
                        href=""https://ej2.syncfusion.com/blazor/documentation/numerictextbox/getting-started/#precision-of-numbers"">
                            documentation section
                        </a>.
                    </p>"
                        }
            },
            new Sample
            {
                Name = "Range Validation",
                Category = "NumericTextBox",
                Directory = "Inputs/NumericTextBox",
                Url = "NumericTextBox/RangeValidation",
                FileName = "RangeValidation.razor",
                TitleTag = "NumericTextBox . RangeValidation . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the range validation functionalities of the Numeric TextBox. Change the min, max and step values and click on apply button to change the property values in Numeric TextBox.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the range validation functionalities of the Numeric TextBox. Change the min, max and step values and click on apply button to change the property values in Numeric TextBox.</p>"
                },
                Description = new string[] {
                    @" <p>
                        The NumericTextBox has the options to restrict the input value between a specific range using the min, max, and strictMode properties.
                    </p>
                    <p>
                        When you enable the strictMode property, the value will automatically change within a range on passing the out-of-range values. When you disable the strictMode property, the NumericTextBox component allows
                        the out-of-range value with the highlighted textbox to indicate the given value is wrong.
                    </p>
                    <p>
                        In this demo, numeric textbox is restricted between 10 to 100 through the min and max properties. So you can enter only the value between this range.
                    </p>
                    <p>
                        More information about NumericTextBox can be found in this
                        <a target=""_blank""
                        href=""https://ej2.syncfusion.com/blazor/documentation/numerictextbox/getting-started/#range-validation"">
                            documentation section
                        </a>.
                    </p>"
                }
            }
        };
        public List<Sample> FileUpload { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "FileUpload",
                Directory = "Inputs/Uploader",
                Url = "Uploader/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                TitleTag = "FileUpload . DefaultFunctionalities . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the default functionalities of the Uploader component. Browse the files which you want to upload to the server. The selected files are submitted to server on upload button click. If you click on the clear button, the selected / uploaded files are cleared from list.",
                ActionDescription = new string[]
                {
                    @"<p>
                        This sample demonstrates the default functionalities of the Uploader component. Browse the files which you want to upload to the server.
                        The selected files are submitted to server on upload button click. If you click on the clear button, the selected / uploaded files are cleared from list.
                    </p>"
                        },
                        Description = new string[]
                {
                    @"<p>
                        The Uploader component is useful to upload images, documents, and other files. By default, the component allows to upload multiple files to browse and upload it to server.
                        The selected files append to the file list that contains file details such as name, type, and size.
                    </p>
                    <p>
                        You can manage the files in server after received the uploaded files. When the files are successfully uploaded to server, the remove button will be change to bin button.
                        The uploaded files can be removed by click on the bin button.
                    </p>
                    <p>
                        The progress bar displays for each file upload to denote its upload progress.
                        Once the file upload gets success, the progress bar disappear and corresponding upload status message will be displayed in same place.
                    </p>
                    <p>More information on the Uploader instantiation can be found in this
                    <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/uploader/getting-started/""> documentation section</a>.</p>"
                        }
            },
             new Sample
            {
                Name = "Chunk Upload",
                Category = "FileUpload",
                Directory = "Inputs/Uploader",
                Url = "Uploader/ChunkUpload",
                FileName = "ChunkUpload.razor",
                TitleTag = "FileUpload . ChunkUpload . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the chunk upload functionalities of the Uploader control. Browse or drag-and-drop a large file to upload with pause, resume, and retry options.",
                ActionDescription = new string[] {
                    @"<p>This example demonstrates the chunk upload functionalities of the Uploader control. Browse or drag-and-drop a large file to upload with pause, resume, and retry options. </p>"
                },
                Description = new string[] {
                    @"<p>When the file size is large or transfer the file with slow network connection, the chunk upload feature slices the files and upload the sliced chunks to server in sequential order
                using the <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.Inputs.AsyncSettingsModel~ChunkSize.html""
                    target=""_blank"">chunkSize</a> API.</p>
                    <p>The sample is configured with the following options:</p>
                    <ul>
                    <li>While uploading, you can pause the upload and resume it later.</li>
                    <li> If the upload fails, retry option will be enabled.</li>
                    <li> The sample is configured with maximum file size as `100 MB` to upload.</li>
                </ul>
                    <p>More information on the Uploader instantiation can be found in this <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/uploader/chunk-upload/"">documentation section</a>.</p>"
                }
            },
               new Sample
            {
                Name = "Preload Files",
                Category = "FileUpload",
                Directory = "Inputs/Uploader",
                Url = "Uploader/PreloadFiles",
                FileName = "PreloadFiles.razor",
                TitleTag = "FileUpload . PreloadFiles . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates how to pre-load the files of the Uploader. The already uploaded files are configured in file list to view and remove them.",
                ActionDescription = new string[]
                {
                    @"<p>This sample demonstrates how to pre-load the files of the Uploader. The already uploaded files are configured in file list to view and remove them.</p>"
                                        },
                                        Description = new string[]
                {
                    @"<p>The Uploader component allows to load initial list of files which are already uploaded in server. The preload files are useful to view and remove from server. Also, you can achieve state persistence on page refresh. </p>
                    <p>For more information, you can refer to the Preload Files section from this
                    <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/uploader/async/#preload-files""> documentation section</a>.</p>"
                                        }
            },
               new Sample
            {
                Name = "File Validation",
                Category = "FileUpload",
                Directory = "Inputs/Uploader",
                Url = "Uploader/FileValidation",
                FileName = "FileValidation.razor",
                TitleTag = "FileUpload . FileValidation . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates how to validate the files before uploading it to server. Only document files (DOC, DOCX, XLS, XLSX), and the files should contain minimum 10 KB and maximum 4 MB sizes to upload it into server.This sample limits maximum files count as 5 to upload.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates how to validate the files before uploading it to server. Only document files (DOC, DOCX, XLS, XLSX),
                        and the files should contain minimum 10 KB and maximum 4 MB sizes to upload it into server.This sample limits maximum files count as 5 to upload.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The Uploader component allows to validate the file’s type, and limit the file size using AllowedExtensions, MinFileSize, and MaxFileSize properties.
                        You can also achieve limit the files count before uploading it using select event.
                    </p>

                    <p>For more information, you can refer to the Validation section from this
                    <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/uploader/validation/""> documentation section</a>.</p>"
                }
            }
        };
        public List<Sample> Slider { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/Default",
                FileName = "Default.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the default rendering of Slider component. Drag the thumb over the bar for selecting the values
                    between min and max.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    The Slider component allows to select a value or range of values in-between a min and max range, by dragging the thumb
                    over the slider bar. Three types of sliders are:</p>
                <ul>
                    <li>Default - allows to select a single value</li>
                    <li>MinRange – allows to select a single value, but highlights with a range selection from the min value to the current
                        handle value</li>
                    <li>Range – allows to select a range of values with two handles, where the handles are connected with a range selection</li>
                    <p>
                        In this demo, the default, MinRange and range slider types can be seen.
                    </p>
                </ul>"
                }
            },
            new Sample
            {
                Name = "Ticks",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/Ticks",
                FileName = "Ticks.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the rendering of Slider component with ticks placement. Drag the thumb over the bar for selecting
                    the values between min and max.
                </p>"
                },
                Description = new string[] {
                    @"<p>The ticks are the visual representation of the Slider values. The ticks are differentiated as small and large ticks based
                    on its size. The ticks position can be defined by the
                    smallStep and largeStep properties.</p>
                <p> In this demo, ticks position with default and range Slider is demonstrated.</p>
                <ul>
                    <li>Default Slider – In this sample, the small and large ticks are rendered with the frequency of 0.05 and 0.20.</li>
                    <li>Range Slider – In this sample, the small and large ticks are rendered with the frequency of 5 and 20.</li>
                </ul>
                <p> The ticks placement of Slider and disable Slider component from the property pane can also be changed.</p>
                <p>The following properties are used to restrict the value range for the slider:</p>
                <ul>
                    <li>
                        step - defines incremental or decremental step value for slider</li>
                    <li>
                        min – specifies minimum value of the slider</li>
                    <li>
                        max – to specifies maximum value of the slider</li>
                </ul>"
                }
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/Tooltip",
                FileName = "Tooltip.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the rendering of Slider component with tooltip. Drag the thumb over the bar for selecting the values between min and max to enable the tooltip.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    <p>Slider component displays the tooltip to indicate the current value to the user.</p>

                    <p>In this demo, we have demonstrated Tooltip with Default and Range Slider.</p>

                    <p>Buttons can be used to increment or decrement the slider value. Buttons can be enabled in Slider using showButtons property</p>

                    <p>Tooltip position and opening behavior can be customized through the placement and showOn properties from property pane.</p>

                    <p>The dragInterval is used to drag both handles using the range bar which is also applicable only to the range slider.</p>
                    </p>"
                }
            },
            new Sample
            {
                Name = "Vertical Orientation",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/VerticalOrientation",
                FileName = "VerticalOrientation.razor",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the rendering of Slider component in Vertical orientation. Drag the thumb over the bar for selecting the values between min and max.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    The Slider component allows to select a value or range of values in-between a min and max range, by dragging the thumb over the slider bar in vertical orientation. Three types of sliders in vertical orientation are:
                <ul>
                    <li>Default - allows to select a single value</li>
                    <li>MinRange – allows to select a single value, but highlights with a range selection from the min value to the current
                        handle value</li>
                    <li>Range – allows to select a range of values with two handles, where the handles are connected with a range selection</li>
                </ul>
                    <p>The dragInterval is used to drag both handles using the range bar which is also applicable only to the range slider.</p>

                    <p>In this demo, the default, MinRange, and range slider types can be seen.</p>
                </p>"
                }
            },
            new Sample
            {
                Name = "Limits",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/Limits",
                FileName = "Limits.razor",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the rendering of Slider component with limits. Drag the thumb over the bar for selecting the values between assigned limit values.</p>"
                },
                Description = new string[] {
                    @"<p>
                    The limits are used to limit between certain range. When the limits are assigned, draggable limited area will be in the dark shadow color of the current theme. The limits APIs are explained below.</p>
                <ul>
                    <li><a target='_blank' href='https://ej2.syncfusion.com/documentation/api/slider/limitData/#minstart'>minStart</a>	-   Used to set minimum limit value for first handle.</li>
                    <li><a target='_blank' href='https://ej2.syncfusion.com/documentation/api/slider/limitData/#minend'>minEnd</a>	-   Used to set maximum limit value for first handle.</li>
                    <li><a target='_blank' href='https://ej2.syncfusion.com/documentation/api/slider/limitData/#maxstart'>maxStart</a>	-   Used to set minimum limit value for second handle.</li>
                    <li><a target='_blank' href='https://ej2.syncfusion.com/documentation/api/slider/limitData/#maxend'>maxEnd</a>	-   Used to set maximum limit value for first handle.</li>
                    <li><a target='_blank' href='https://ej2.syncfusion.com/documentation/api/slider/limitData/#starthandlefixed'>startHandleFixed</a>	-   Used to lock the first handle in the current position.</li>
                    <li><a target='_blank' href='https://ej2.syncfusion.com/documentation/api/slider/limitData/#endhandlefixed'>endHandleFixed</a>	-   Used to lock the second handle in the current position.</li>
                </ul>
                    In this demo, Limits with MinRange and range Slider is demonstrated.
                <ul>
                    <li>MinRange Slider – In this sample, the minimum and maximum limit of the slider is set to 10 and 40 respectively.</li>
                    <li>Range Slider – In this sample, the minimum and maximum limit of the first handle is set to 10 and 40 respectively and the minimum and maximum limit of the second handle is set to 60 and 90 respectively.</li>
                </ul>
                </p>"
                }
            },
            new Sample
            {
                Name = "API",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/API",
                FileName = "API.razor",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the customization of Slider component by using its properties from property pane. Select any
                    combination of properties from property pane to customize Slider component.</p>"
                },
                Description = new string[] {
                    @"<p>In this demo, default slider is rendered with minimal configuration.</p>
                    <p>This sample can be customized further with the combination of Slider properties from the property pane. For example,</p>
                    <ul>
                        <li>Min, max, value and Steps can be changed from the property pane.</li>
                        <li>Ticks can be enabled by selecting the ticks placement from the property pane.</li>
                        <li>Tooltip can be enabled by checking Show tooltip checkbox from property pane.</li>
                        <li>Vertical orientation can be enabled by checking vertical orientation from property pane and so on.</li>
                    </ul>"
                }
            },
            new Sample
            {
                Name = "Events",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/Events",
                FileName = "Events.razor",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the events that have been triggered on the Slider operations with the help of event trace panel.
                    Drag the thumb over the bar between min and max to know the event details.
                </p>"
                },
                Description = new string[] {
                    @"<p>Slider component triggers the event based on its actions. The events can be used as an extension point to perform custom
                    operations.
                </p>
            <p>In this demo, Slider performs following actions which can be traced by event trace panel: </p>
            <ul>
                    <li>Created - Triggers when Slider is created.</li>
                    <li>ValueChange - Triggers when the Slider value is changing.</li>
                    <li>OnChange - Triggers when the Slider action is completed with change in Slider value.</li>
                </ul>"
                }
            },
            new Sample
            {
                Name = "Thumb",
                Category = "Customization",
                Directory = "Inputs/Slider",
                Url = "Slider/CustomThumb",
                FileName = "CustomThumb.razor",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the customization of Slider's thumb. Drag the thumb over the bar for selecting the values between
                    min and max.
                </p>"
                },
                Description = new string[] {
                    @"<p>In this demo, customization of thumb by changing CSS is demonstrated.</p>
                    <ul>
                    <li>Square - In this sample, thumb has been customized to square shape.</li>
                    <li>Circle - In this sample, thumb has been customized to circle shape. </li>
                    <li>Oval - In this sample, thumb has been customized to oval shape. </li>
                    <li>Custom image - In this sample, thumb has been replaced with custom image. </li>
                </ul>"
                }
            },
            new Sample
            {
                Name = "Bar",
                Category = "Customization",
                Directory = "Inputs/Slider",
                Url = "Slider/CustomBar",
                FileName = "CustomBar.razor",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the customization of Slider's selection bar. Drag the thumb over the bar for selecting the values between min and max.</p>"
                },
                Description = new string[] {
                    @"<p>In this demo, customization of track using CSS is demonstrated.</p>
            <ul>
                    <li>Height - In this sample, track has been customized to custom height. Here, thumb has to be adjusted based on the track height.</li>
                    <li>Gradient color - In this sample, track has been customized with gradient color. </li>
                    <li>Dynamic thumb and selection bar color - In this sample, track and thumb has been customized to different colors for different intervals by using created and change event. </li>
                </ul>"
                }
            },
        };
    }

   


}
