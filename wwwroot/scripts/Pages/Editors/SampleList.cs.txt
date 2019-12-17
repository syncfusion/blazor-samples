using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> InPlaceEditor { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Overview",
                Category = "In-place Editor",
                Directory = "Editors/InPlaceEditor",
                Url = "Editors/Overview",
                FileName = "Overview.razor",
                Type = SampleType.New,
                TitleTag = "InPlaceEditor . Overview . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the default behavior of the In-place Editor control, which works by editing the values in inline and popup in Blazor platform.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the default functionalities of the In-place Editor component. Click on the dotted input element to switch to the editable state and save or cancel it by clicking the actions buttons.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    The <code>In-place Editor</code> component is used to edit values in place and update them to the server.
                </p>
                <p>
                    <code>In-place Editor</code> modes can be switched by selecting the appropriate values provided in a drop-down. The applicable editor positions are as follows:
                </p>
                <p>
                    <ul>
                        <li>
                            Inline
                        </li>
                        <li>
                            Pop-up
                        </li>
                    </ul>
                </p>
                <p>
                    The edit on modes of In-place editor can be switched by selecting the appropriate values provided in a drop-down. The applicable modes are as follows:
                    <ul>
                        <li>Click - Editor opens the edit input with single click of textbox.</li>
                        <li>DblClick - Editor opens the edit input with double click of textbox.</li>
                        <li>EditIconClick - Edit mode can be open with the use of edit icon only which is visible on hover of textbox.</li>
                    </ul>
                </p>
                <p>
                    The Save and Cancel buttons of the <code>In-place Editor</code> component can be shown or hidden by switching the Show Button check box state. If the action buttons are hidden, then you can save the data by clicking outside the target or by pressing the Enter key. You can cancel the edit request by pressing the Esc key.
                </p>
                <p>
                    More information on the <code>In-place Editor</code> instantiation can be found in the<a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/in-place-editor/getting-started/""> documentation section </a>.
                </p>"
                }
            },
            new Sample
            {
                Name = "DropDown Components",
                Category = "In-place Editor",
                Directory = "Editors/InPlaceEditor",
                Url = "Editors/DropDown",
                FileName = "DropDown.razor",
                Type = SampleType.New,
                TitleTag = "InPlaceEditor . DropDown Components . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the usage of dropdown controls such as Autocomplete, ComboBox, DropDownList, and MultiSelect in Blazor platform.",
                ActionDescription = new string[] {
                @"<p>
                    This sample demonstrates the usage of drop-down components such as AutoComplete, ComboBox, DropDownList, and MultiSelect. Click on the dotted input element to switch to the editable state of the corresponding integrated component.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    This sample illustrates the way to integrate drop-down components with <code>In-place Editor</code>. The applicable types of components are:
                </p>
                <p>
                    <ul>
                        <li>
                            <code>DropDownList</code>
                        </li>
                        <li>
                            <code>AutoComplete</code>
                        </li>
                        <li>
                            <code>ComboBox</code>
                        </li>
                        <li>
                            <code>MultiSelect</code>
                        </li>
                    </ul>
                </p>
                <p>
                    The above components and their features are editable in place and can be customized with the model properties of the specific component.
                </p>"
                }
            },
            new Sample
            {
                Name = "Date Components",
                Category = "In-place Editor",
                Directory = "Editors/InPlaceEditor",
                Url = "Editors/DatePickers",
                FileName = "DatePickers.razor",
                Type = SampleType.New,
                TitleTag = "InPlaceEditor . Date Components . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the usage of picker controls such as Date, Time, DateTime, and DateRange in Blazor platform.",
                ActionDescription = new string[] {
                @"<p>
                    This sample demonstrates the usage of picker components such as Date, Time, DateTime, and DateRange. Click on the dotted input element to switch to the editable state of the corresponding integrated component.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    This sample illustrates the way to integrate picker components with the <code>In-place Editor</code> component. The applicable types of components are:
                </p>
                <p>
                    <ul>
                        <li>
                            <code>DatePicker</code>
                        </li>
                        <li>
                            <code>TimePicker</code>
                        </li>
                        <li>
                            <code>DateTimePicker</code>
                        </li>
                        <li>
                            <code>DateRangePicker</code>
                        </li>
                    </ul>
                </p>
                <p>
                    The above components and their features are editable in place and can be customized with the model properties of the specific component.
                </p>"
                }
            },
            new Sample
            {
                Name = "Edit Post",
                Category = "Use Case",
                Directory = "Editors/InPlaceEditor",
                Url = "Editors/EditPost",
                FileName = "EditPost.razor",
                Type = SampleType.New,
                TitleTag = "InPlaceEditor . Edit Post . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the usage of In-place Editor control with a form element in Blazor platform. Edit the values in place to update to the post.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the default functionalities of the In-place Editor component. Click on the dotted input element to switch to the editable state and save or cancel it by clicking the actions buttons.
                </p>"
                },
                Description = new string[] {
                    @"<p>
                    The <code>In-place Editor</code> component is used to edit values in place and update them to the server.
                </p>
                <p>
                    <code>In-place Editor</code> modes can be switched by selecting the appropriate values provided in a drop-down. The applicable editor positions are as follows:
                </p>
                <p>
                    <ul>
                        <li>
                            Inline
                        </li>
                        <li>
                            Pop-up
                        </li>
                    </ul>
                </p>
                <p>
                    The edit on modes of In-place editor can be switched by selecting the appropriate values provided in a drop-down. The applicable modes are as follows:
                    <ul>
                        <li>Click - Editor opens the edit input with single click of textbox.</li>
                        <li>DblClick - Editor opens the edit input with double click of textbox.</li>
                        <li>EditIconClick - Edit mode can be open with the use of edit icon only which is visible on hover of textbox.</li>
                    </ul>
                </p>
                <p>
                    The Save and Cancel buttons of the <code>In-place Editor</code> component can be shown or hidden by switching the Show Button check box state. If the action buttons are hidden, then you can save the data by clicking outside the target or by pressing the Enter key. You can cancel the edit request by pressing the Esc key.
                </p>
                <p>
                    More information on the <code>In-place Editor</code> instantiation can be found in the <a target=""_blank"" href=""https://ej2.syncfusion.com/blazor/documentation/in-place-editor/getting-started/"">documentation section</a>.
                </p>"
                }
            }
        };
    }
}
