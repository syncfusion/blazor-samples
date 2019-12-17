using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> DropDownList { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "DropDownList",
                Directory = "DropDowns/DropDownList",
                Url = "DropDownList/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                TitleTag = "DropDownList . DefaultFunctionalities . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the default functionalities of the DropDownList in Blazor application. It contains a list of predefined values from that the user can choose a single value",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the default functionalities of the DropDownList in Blazor application. Click the DropDownList element and select an item from the <code>options</code> list.
                        The selected item's <code>Value</code> and <code>Text</code> property values will be shown the in property panel.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The <code>DropDownList</code> component contains a list of predefined values from that the user can choose a single
                        value.
                    </p>
                    <p>
                        The default sample illustrates the use of DropDownList that allows the end-users to select an item from the <code>options</code> list. The selected item's <code>Value</code> and <code>Text</code> property values will be displayed in the property
                        panel.
                    </p>
                    <p>
                        More information on the DropDownList instantiation can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/dropdownlist/getting-started/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "DropDownList",
                Directory = "DropDowns/DropDownList",
                Url = "DropDownList/DataBinding",
                FileName = "DataBinding.razor",
                Type = SampleType.New,
                TitleTag = "DropDownList . DataBinding . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates to loads the data either from local data sources or remote data services through the DataSource property.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the different data binding supports of the DropDownList. Click the DropDownList element and select an item from the suggestion list. At the very first time, when click on the remote data DropDownList,
                        the loader icon will be shown until the remote request get the data from the server and display it.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The DropDownList loads the data either from the local data sources, or remote data services that is is through the <code>DataSource</code> property. It supports the data type of <code>array</code> or <code>DataManager</code>.
                    </p>
                    <p>
                        The DataManager that act as an interface between service endpoint and DropDownList, will require the below minimal
                        information to interact with the service endpoint properly.
                    </p>
                    <ul>
                        <li><code>DataManager->url</code> - Defines the service endpoint to fetch data</li>
                        <li>
                            <code>DataManager->adaptor</code> - Defines the adaptor option. By default, <code>ODataAdaptor</code> is used for
                            remote binding.
                        </li>
                    </ul>
                    <p>
                        Adaptor is responsible for processing response and request from/to the service endpoint.
                        <code>syncfusion/ejs-data</code> package provides some predefined adaptors that are designed to interact with the particular
                        service endpoints. They are:
                    </p>
                    <ul>
                        <li><code>UrlAdaptor</code> - Use this to interact any remote services.</li>
                        <li><code>ODataAdaptor</code> - Use this to interact with OData endpoints.</li>
                        <li><code>ODataV4Adaptor</code> - Use this to interact with OData V4 endpoints.</li>
                        <li><code>WebApiAdaptor</code> - Use this to interact with Web API created under OData standards.</li>
                        <li><code>WebMethodAdaptor</code> - Use this to interact with web methods.</li>
                    </ul>
                    <p>
                        In this sample, the local data is bound to a collection of sports data, and the remote data is bound to a collection of
                        customer data as an instance of <code>DataManager</code>.
                    </p>
                    <p>
                        More information on the data binding feature configuration can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/dropdownlist/data-binding/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Filtering",
                Category = "DropDownList",
                Directory = "DropDowns/DropDownList",
                Url = "DropDownList/Filtering",
                FileName = "Filtering.razor",
                Type = SampleType.New,
                TitleTag = "DropDownList . Filtering . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the filtering functionalities of the DropDownList. Click the DropDownList element and then type a character in the search box. It will display the filtered list items based on the typed characters.",
                ActionDescription = new string[] {
                    @" <p>
                        This sample demonstrates the filtering functionalities of the DropDownList. Click the DropDownList element and then type a character in the search box. It will display the
                        filtered list items based on the typed characters.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The DropDownList has built-in support to filter the data source, when <code>AllowFiltering</code> is enabled. It performs
                        when characters are typed in the search box. In the <code>Filtering</code> event, you can filter down the data source and
                        return the resulted data to DropDownList via <code>UpdateData</code> method to display its list items.
                    </p>
                    <p>
                        More information on the filtering feature configuration can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/dropdownlist/filtering/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Cascading",
                Category = "DropDownList",
                Directory = "DropDowns/DropDownList",
                Url = "DropDownList/Cascading",
                FileName = "Cascading.razor",
                Type = SampleType.New,
                TitleTag = "DropDownList . Cascading . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the cascading functionalities of the DropDownList. Choose a country from the countries DropDownList, then respective states will be loaded in the second DropDownList.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the cascading functionalities of the DropDownList. Choose a country from
                        the countries DropDownList, then respective states will be loaded in the second DropDownList
                        and the same has to be done between states and cities DropDownList.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The <code>Cascading</code> DropDownList is the series of DropDownList, where the value of one DropDownList depends on
                        the another DropDownList value. This can be configured by using the <code>ValueChange</code> event of parent DropDownList.
                        Within that change event handler, you should load the data to child DropDownList based on the selected value of parent
                        DropDownList.
                    </p>
                    <p>
                        In this sample, if a country is selected from countries DropDownList, the respective states will be loaded in the second DropDownList
                        and the same has to be done between states and cities DropDownList.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Grouping and Icon",
                Category = "DropDownList",
                Directory = "DropDowns/DropDownList",
                Url = "DropDownList/GroupingIcon",
                FileName = "GroupingIcon.razor",
                Type = SampleType.New,
                TitleTag = "DropDownList . GroupingIcon . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates to Click the DropDownList element and select an item from the categorized list/icons list.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the grouping and icons supports of the DropDownList. Click the DropDownList element and select an item from the categorized list/icons list.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The DropDownList allows to group the relevant items under a corresponding category by mapping the <code>GroupBy</code> field, and allows to load the list items with icons.
                    </p>
                    <p>
                        The grouping sample illustrates how the vegetables are grouped based on its category.
                    </p>
                    <p>
                        The 2nd DropDownList is populated with icons that is rendered by mapping the <code>IconCss</code> field.
                    </p>
                    <p>
                        More information on the grouping feature configuration can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/dropdownlist/grouping/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Inline",
                Category = "DropDownList",
                Directory = "DropDowns/DropDownList",
                Url = "DropDownList/Inline",
                FileName = "Inline.razor",
                Type = SampleType.New,
                TitleTag = "DropDownList . Inline . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates DropDownList appearing in line with highlighted content",
                ActionDescription = new string[] {
                    @"<p>The DropDownList appearing in line with highlighted content. Click that DropDownList value content and select an item from the popup list.</p>"
                },
                Description = new string[] {
                @"<p>
                        The DropDownList component can be rendered in line with other content and you can override the styles of the dropdownlist component.
                    </p>
                    <p>
                        This sample illustrates using the user's data that has been used and customized DropDownList border.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Diacritics Filtering",
                Category = "DropDownList",
                Directory = "DropDowns/DropDownList",
                Url = "DropDownList/DiacriticsFiltering",
                FileName = "DiacriticsFiltering.razor",
                Type = SampleType.New,
                TitleTag = "DropDownList . DiacriticsFiltering . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates DropDownList filtering will ignore the diacritics which makes it easier to filter the results in international characters lists when the IgnoreAccent is enabled.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the diacritics filter functionality of the DropDownList. Type the characters ‘gul’ in the DropDownList filterbar and it displays the suggestion list ignoring the diacritics lists.</p>"
                },
                Description = new string[] {
                @"<p>
                        The DropDownList filtering will ignore the diacritics which makes it easier to filter the results in international characters lists when the <code>IgnoreAccent</code> is enabled.
                    </p>
                    <p>
                        This sample illustrates using the international characters data.
                    </p>
                    <p>
                        More information on the DropDownList diacritics filtering can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/dropdownlist/filtering/#diacritics-filtering"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Template",
                Category = "DropDownList",
                Directory = "DropDowns/DropDownList",
                Url = "DropDownList/Template",
                FileName = "Template.razor",
                Type = SampleType.New,
                TitleTag = "DropDownList . Template . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the template functionalities of the DropDownList. Type a character in the DropDownList element and choose an item from the customized list.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the template functionalities of the DropDownList. Type a character in the DropDownList element and choose an item from the customized list
                    </p>"
                },
                Description = new string[] {
                    @"<p>The DropDownList has been provided with several options to customize each list items, group title, header and footer elements.</p>
                    <p>
                        This sample uses the following list of templates in DropDownList
                    </p>
                    <ul>
                        <li><code>ItemTemplate </code> - To customize the list item's content.</li>
                        <li><code>HeaderTemplate </code> - To customize the header element.</li>
                        <li><code>ValueTemplate  </code> - To customize the value element content that holds the selected item's text.</li>
                    </ul>
                    <p>
                        More information on the template feature configuration can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/dropdownlist/templates/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            }
        };

        public List<Sample> ComboBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                TitleTag = "ComboBox . DefaultFunctionalities . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the default functionalities of the ComboBox in Blazor application. Type a character in the ComboBox element or click the drodown icon to choose an item from the options list.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the default functionalities of the ComboBox in Blazor application. Type a character in the ComboBox element or click the drodown icon to choose an item from the <code>options</code> list.
                    </p>"
                },
                Description = new string[] {
                        @"<p>The <code>ComboBox</code> component allows the user to type a value, or choose an option from the list of predefined options.</p>
                    <p>
                        More information on the ComboBox instantiation can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/combobox/getting-started/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
              new Sample
            {
                Name = "Data Binding",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/DataBinding",
                FileName = "DataBinding.razor",
                Type = SampleType.New,
                TitleTag = "ComboBox . DataBinding . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates to loads the data either from local data sources or remote data services through the DataSource property.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the different data binding supports of the ComboBox. Type a character(s) in the ComboBox element and the remaining characters are automatically filled based on the first matched item.
                    </p>"
                },
                Description = new string[] {
                    @"<p>The ComboBox loads the data either from local data sources or remote data services through the <code>DataSource</code> property. It supports the data type of <code>array</code> or <code>DataManager</code>.</p>
                    <p>
                        The DataManager, that act as an interface between service endpoint and ComboBox will require the following minimal
                        information to interact with the service endpoint properly.
                    </p>
                    <ul>
                        <li><code>DataManager->url</code> - Defines the service endpoint to fetch data.</li>
                        <li>
                            <code>DataManager->adaptor</code> - Defines the adaptor option. By default, <code>ODataAdaptor</code> is used for
                            remote binding.
                        </li>
                    </ul>
                    <p>
                        The adaptor is responsible for processing response and request from/to the service endpoint.
                        <code>syncfusion/ejs-data</code> package provides some predefined adaptors which are designed to interact with particular
                        service endpoints. They are:
                    </p>
                    <ul>
                        <li><code>UrlAdaptor</code> - Use this to interact any remote services.</li>
                        <li><code>ODataAdaptor</code> - Use this to interact with OData endpoints.</li>
                        <li><code>ODataV4Adaptor</code> - Use this to interact with OData V4 endpoints.</li>
                        <li><code>WebApiAdaptor</code> - Use this to interact with Web API created under OData standards.</li>
                        <li><code>WebMethodAdaptor</code> - Use this to interact with web methods.</li>
                    </ul>
                    <p>
                        In this sample, the local data is bound to a collection of sports data and the remote data is bound to a collection of
                        customer data as an instance of <code>DataManager</code>.
                    </p>
                    <p>
                        More information on the data binding feature configuration can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/combobox/data-binding/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
           new Sample
            {
                Name = "Cascading",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Cascading",
                FileName = "Cascading.razor",
                Type = SampleType.New,
                TitleTag = "ComboBox . Cascading . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the cascading functionalities of the ComboBox. Choose a country from countries ComboBox, then respective states will be loaded in the second ComboBox.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the cascading functionalities of the ComboBox. Choose a country from countries ComboBox, then respective states will be loaded in the second ComboBox
                        and the same has to done between states and cities ComboBox.
                    </p>"
                },
                Description = new string[] {
                        @"<p>The <code>Cascading</code> ComboBox is the series of ComboBox, where the value of one ComboBox depends on the another
                        ComboBox value. This can be configured by using the <code>ValueChange</code> event of parent ComboBox. Within
                        that change event handler, you should load the data to child ComboBox based on the selected value of parent ComboBox.</p>"
                }
            },
             new Sample
            {
                Name = "Filtering",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Filtering",
                FileName = "Filtering.razor",
                Type = SampleType.New,
                TitleTag = "ComboBox . Filtering . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the filtering functionalities of the ComboBox. Type a character in ComboBox element and choose an item from the filtered list based on the typed characters.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the filtering functionalities of the ComboBox. Type a character in ComboBox
                        element and choose an item from the filtered list based on the typed characters.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The ComboBox has built-in support to filter the data source when <code>AllowFiltering</code> is enabled. It performs
                        when characters are typed in the search box. In <code>Filtering</code> event, you can filter down the data source and
                        return the resulted data to ComboBox via <code>UpdateData</code> method to display its list items.
                    </p>
                    <p>
                        More information on the filtering feature configuration can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/combobox/filtering/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Grouping and Icon",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/GroupingIcon",
                FileName = "GroupingIcon.razor",
                Type = SampleType.New,
                TitleTag = "ComboBox . GroupingIcon . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates to Click the ComboBox element and select an item from the categorized list/icons list.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the grouping and icons supports of the ComboBox. Type a character in the ComboBox element or click on the drodown icon to choose an item from the categorized list/icons list.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The ComboBox allows to group the relevant items under a corresponding category by mapping the <code>GroupBy</code> field, and allows to load the list items with icons.
                    </p>
                    <p>
                        The grouping sample illustrates how the vegetables are grouped based on its category.
                    </p>
                    <p>
                        The 2nd ComboBox is populated with icons that is rendered by mapping the <code>IconCss</code> field.
                    </p>
                    <p>
                        More information on the grouping feature configuration can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/combobox/grouping/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Diacritics Filtering",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/DiacriticsFiltering",
                FileName = "DiacriticsFiltering.razor",
                Type = SampleType.New,
                TitleTag = "ComboBox . DiacriticsFiltering . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates ComboBox filtering will ignore the diacritics which makes it easier to filter the results in international characters lists when the IgnoreAccent is enabled.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the diacritics filter functionality of the ComboBox. Type the characters ‘gul’ in the ComboBox element and it displays the suggestion list ignoring the diacritics lists.</p>"
                },
                Description = new string[] {
                @" <p>
                        The ComboBox filtering will ignore the diacritics which makies it easier to filter the results in international characters lists when the <code>IgnoreAccent</code> is enabled.
                    </p>
                    <p>
                        This sample illustrates the international characters data.
                    </p>
                    <p>
                        More information on the ComboBox diacritics filtering can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/combobox/filtering/#diacritics-filtering"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Template",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/Template",
                FileName = "Template.razor",
                Type = SampleType.New,
                TitleTag = "ComboBox . Template . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the template functionalities of the ComboBox.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the template functionalities of the ComboBox. Type a character in the ComboBox element and choose an item from the customized list
                    </p>"
                },
                Description = new string[] {
                    @"<p>The ComboBox has been provided with several options to customize each list items, group title, header and footer elements.</p>
                    <p>
                        This sample uses the following list of templates in ComboBox
                    </p>
                    <ul>
                        <li><code>ItemTemplate </code> - To customize the list item's content.</li>
                        <li><code>HeaderTemplate </code> - To customize the header element.</li>
                    </ul>
                    <p>
                        More information on the template feature configuration can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/combobox/templates/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Multi Column",
                Category = "ComboBox",
                Directory = "DropDowns/ComboBox",
                Url = "ComboBox/MultiColumn",
                FileName = "MultiColumn.razor",
                Type = SampleType.New,
                TitleTag = "ComboBox . MultiColumn . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the Multicolumn ComboBox. Click/focus and type the character in the ComboBox to select an item from the multicolumn data.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the Multicolumn ComboBox. Click/focus and type the character in the ComboBox to select an item from the multicolumn data.
                    </p>"
                },
                Description = new string[] {
                    @"<p>The ComboBox has an option to display the data in a multicolumn layout using the following templates.</p>
                    <p>
                    <ul>
                        <li><code>Header Template </code> - Displays the column names in the grid layout header.</li>
                        <li><code>Item Template </code> - Binds the data value by row wise.</li>
                    </ul>
                    </p>"
                }
            }
        };

        public List<Sample> AutoComplete { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                TitleTag = "AutoComplete . DefaultFunctionalities . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the default functionalities of the AutoComplete in Blazor application. Type a character in the AutoComplete element and choose an item from the suggestion list.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default functionalities of the AutoComplete in Blazor application. Type a character in the AutoComplete element and choose an item from the suggestion list.</p>"
                },
                Description = new string[] {
                @"<p>
                        The <code>AutoComplete</code> component provides the matched suggestion list when a character is typed in the input, from that the
                        user can select one.
                    </p> By default, the filter type value is <code>Contains</code>.
                    <p>
                        The default sample illustrates the use of AutoComplete that allows the end-users to select an item from the suggestion list.
                    </p>
                    <p>
                        More information on the AutoComplete instantiation can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/autocomplete/getting-started/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/DataBinding",
                FileName = "DataBinding.razor",
                Type = SampleType.New,
                TitleTag = "AutoComplete . DataBinding . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the different data binding supports of the AutoComplete. Type a character(s) in the AutoComplete element and the remaining characters are automatically filled based on the first matched item.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the different data binding supports of the AutoComplete. Type a character(s) in the AutoComplete element and the remaining characters are automatically filled based on the first matched item.
                    </p>"
                },
                Description = new string[] {
                    @"<p>The AutoComplete loads the data either from local data sources or remote data services through the <code>DataSource</code> property. It supports the data type of <code>array</code> or <code>DataManager</code>.</p>
                    <p>
                        The DataManager, that act as an interface between service endpoint and AutoComplete, will require the follwoing minimal
                        information to interact with the service endpoint properly.
                    </p>
                    <ul>
                        <li><code>DataManager->url</code> - Defines the service endpoint to fetch data.</li>
                        <li>
                            <code>DataManager->adaptor</code> - Defines the adaptor option. By default, <code>ODataAdaptor</code> is used for
                            remote binding.
                        </li>
                    </ul>
                    <p>
                        The adaptor is responsible for processing response and request from/to the service endpoint.
                        <code>syncfusion/ejs-data</code> package provides some predefined adaptors that are designed to interact with particular
                        service endpoints. They are:
                    </p>
                    <ul>
                        <li><code>UrlAdaptor</code> - Use this to interact any remote services.</li>
                        <li><code>ODataAdaptor</code> - Use this to interact with OData endpoints.</li>
                        <li><code>ODataV4Adaptor</code> - Use this to interact with OData V4 endpoints.</li>
                        <li><code>WebApiAdaptor</code> - Use this to interact with Web API created under OData standards.</li>
                        <li><code>WebMethodAdaptor</code> - Use this to interact with web methods.</li>
                    </ul>
                    <p>
                        In this sample, the local data is bound to a collection of sports data and the remote data is bound to a collection of
                        customer data as an instance of <code>DataManager</code>.
                    </p>
                    <p>
                        More information on the data binding feature configuration can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/autocomplete/data-binding/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Grouping and Icon",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/GroupingIcon",
                FileName = "GroupingIcon.razor",
                Type = SampleType.New,
                TitleTag = "AutoComplete . GroupingIcon . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates to Click the AutoComplete element and select an item from the categorized list/icons list.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the grouping and icons supports to the AutoComplete. Type a character in the AutoComplete element and choose an item from the categorized list/icons list.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The AutoComplete allows to group the relevant items under a corresponding category by mapping the <code>GroupBy</code> field, and allows to
                        load the list items with icons. And also enabled the <code>ShowPopupButton</code> property to show the all suggestion items while clicking on popup button.
                    </p>
                    <p>
                        The grouping sample illustrates how the vegetables are grouped based on its category.
                    </p>
                    <p>
                        The 2nd AutoComplete is populated with icons which is rendered by mapping the <code>IconCss</code> field.
                    </p>
                    <p>
                        More information on the grouping feature configuration can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/autocomplete/grouping/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Diacritics Filtering",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/DiacriticsFiltering",
                FileName = "DiacriticsFiltering.razor",
                Type = SampleType.New,
                TitleTag = "AutoComplete . DiacriticsFiltering . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates AutoComplete filtering will ignore the diacritics which makes it easier to filter the results in international characters lists when the IgnoreAccent is enabled",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the diacritics filter functionality of the AutoComplete. Type the characters ‘gul’ in the AutoComplete element and it displays the suggestion list ignoring the diacritics lists.</p>"
                },
                Description = new string[] {
                @"<p>
                        The AutoComplete filtering will ignore the diacritics which makes it easier to filter the results in international characters lists when the <code>IgnoreAccent</code> is enabled.
                    </p>
                    <p>
                        This sample illustrates using the international characters data
                    </p>
                    <p>
                        More information on the AutoComplete diacritics filtering can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/autocomplete/filtering/#diacritics-filtering"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Template",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Template",
                FileName = "Template.razor",
                Type = SampleType.New,
                TitleTag = "AutoComplete . Template . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the template functionalities of the AutoComplete.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the template functionalities of the AutoComplete. Type a character in the AutoComplete element and choose an item from the customized list
                    </p>"
                },
                Description = new string[] {
                    @"<p>The AutoComplete has been provided with several options to customize each list items, group title, header and footer elements.</p>
                    <p>
                        This sample uses the following list of templates in AutoComplete
                    </p>
                    <ul>
                        <li><code>ItemTemplate </code> - To customize the list item's content.</li>
                        <li><code>HeaderTemplate </code> - To customize the header element.</li>
                    </ul>
                    <p>
                        More information on the template feature configuration can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/autocomplete/templates/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Highlight",
                Category = "AutoComplete",
                Directory = "DropDowns/AutoComplete",
                Url = "AutoComplete/Highlight",
                FileName = "Highlight.razor",
                Type = SampleType.New,
                TitleTag = "AutoComplete . Highlight . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates an AutoComplete has built-in support to highlight the searched characters on the suggested list items when Highlight is enabled.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the highlight functionalities of the AutoComplete. Type a character(s) in the AutoComplete element and the typed characters are highlighted in the suggestion list. By default, <code>Contains</code> filter type is set in this sample and provided with the options to choose different filter type in the property panel.</p>"
                },
                Description = new string[] {
                    @" <p>
                        The AutoComplete has built-in support to highlight the searched characters on the suggested list items when <code>Highlight</code> is enabled.
                    </p>
                    <p>This sample illustrates that, the searched characters on the country suggestion list items are highlighted.</p>"
                }
            }
        };

        public List<Sample> MultiSelect { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "MultiSelect",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
                TitleTag = "MultiSelect . DefaultFunctionalities . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the default functionalities of the MultiSelect in Blazor application. Type a character in the MultiSelect element or click on this element to choose one or more items from the suggestion list.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default functionalities of the MultiSelect in Blazor application. Type a character in the MultiSelect element or click on this element to choose one or more items from the suggestion list.</p>"
                },
                Description = new string[] {
                    @" <p>
                        The <code>MultiSelect</code> component contains a list of predefined values, from that the user can choose a multiple
                        values.
                    </p>
                    <p>In this sample, the selected items are shown with three different UI modes in three different MultiSelect elements. That three UI modes are listed here below,</p>
                    <ul>
                        <li><b>Default</b> - on focus-in, the component will act in <code>Box mode</code> and on blur, the component will act in <code>Delimiter mode</code>.</li>
                        <li><b>Box</b> - selected items will be visualized in chip.</li>
                        <li><b>Delimiter</b> - selected items will be visualized in text content.</li>
                    </ul>
                    <p>
                        More information on the MultiSelect instantiation can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/multiselect/getting-started/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Data Binding",
                Category = "MultiSelect",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect/DataBinding",
                FileName = "DataBinding.razor",
                Type = SampleType.New,
                TitleTag = "MultiSelect . DataBinding . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates to loads the data either from local data sources or remote data services through the DataSource property.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the different data binding supports of the MultiSelect. Click the MultiSelect element and choose
                        one or more items from the suggestion list. At the very first time, when clicked on the remote data MultiSelect,
                        the loader icon will be shown until the remote request get the data from server and display it.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The MultiSelect loads the data either from local data sources or remote data services through the
                        <code>DataSource</code> property. It supports the data type of
                        <code>array</code> or
                        <code>DataManager</code>.
                    </p>
                    <p>
                        The DataManager, that act as an interface between service endpoint and MultiSelect, will require the following minimal
                        information to interact with service endpoint properly.
                    </p>
                    <ul>
                        <li>
                            <code>DataManager->url</code> - Defines the service endpoint to fetch data.
                        </li>
                        <li>
                            <code>DataManager->adaptor</code> - Defines the adaptor option. By default,
                            <code>ODataAdaptor</code> is used for remote binding.
                        </li>
                    </ul>
                    <p>
                        Adaptor is responsible for processing response and request from/to the service endpoint.
                        <code>syncfusion/ejs-data</code> package provides some predefined adaptors that are designed to interact with particular service endpoints. They
                        are:
                    </p>
                    <ul>
                        <li>
                            <code>UrlAdaptor</code> - Use this to interact any remote services.
                        </li>
                        <li>
                            <code>ODataAdaptor</code> - Use this to interact with OData endpoints.
                        </li>
                        <li>
                            <code>ODataV4Adaptor</code> - Use this to interact with OData V4 endpoints.
                        </li>
                        <li>
                            <code>WebApiAdaptor</code> - Use this to interact with Web API created under OData standards.
                        </li>
                        <li>
                            <code>WebMethodAdaptor</code> - Use this to interact with web methods.
                        </li>
                    </ul>
                    <p>
                        In this sample, the local data is bound to a collection of sports data and the remote data is bound to a collection of
                        customer data as an instance of
                        <code>DataManager</code>.
                    </p>
                    <p>
                        More information on the data binding feature configuration can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/multiselect/data-binding/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Filtering",
                Category = "MultiSelect",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect/Filtering",
                FileName = "Filtering.razor",
                Type = SampleType.New,
                TitleTag = "MultiSelect . Filtering . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the filtering functionalities of the MultiSelect. Type a character in the MultiSelect element and choose one or more items from the filtered list.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the filtering functionalities of the MultiSelect. Type a character in the MultiSelect element
                        and choose one or more items from the
                        <code>filtered</code> list.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The MultiSelect has built-in support to filter the data source when
                        <code>AllowFiltering</code> is enabled. It performs when characters are typed in the component. In
                        <code>Filtering</code> event, you can filter down the data source and return the resulted data to MultiSelect via
                        <code>UpdateData</code> method to display its list items.
                    </p>
                    <p>
                        More information on the filtering feature configuration can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/multiselect/filtering/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "CheckBox",
                Category = "MultiSelect",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect/CheckBox",
                FileName = "CheckBox.razor",
                Type = SampleType.New,
                TitleTag = "MultiSelect . CheckBox . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates to select the multiple values through the checkbox.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the checkbox functionalities of the MultiSelect.Click the MultiSelect element and then type a character in the search box. It will display the filtered list items based on the typed characters and then select the multiple values through the checkbox.</p>"
                },
                Description = new string[] {
                    @" <p>
                        The MultiSelect has built-in support to select the multiple values through checkbox, when the <code>Mode</code> property is set as <code>CheckBox</code>.
                    </p>
                    <p>In this sample, the local data is bound to a collection of countries data. Also, provided options for the following:
                    <p> To enable/disable the <code>Select All</code> feature in the property panel.</p>
                    <p> To enable/disable the <code>DropDown Button</code>feature in the property panel.</p>
                    <p> To enable/disable the <code>Selection Reorder</code>feature in the property panel.</p>
                    </p>
                    <p>The checkbox sample illustrates  using the countries data. </p>
                    <p>
                        More information on the MultiSelect checkbox can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/multiselect/checkbox/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Custom Value",
                Category = "MultiSelect",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect/CustomValue",
                FileName = "CustomValue.razor",
                Type = SampleType.New,
                TitleTag = "MultiSelect . CustomValue . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates Type a character(s) in the MultiSelect element that are not present in the dataSource, you can select and tag that custom typed characters as new item from the suggestion list.",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the custom value functionalities of the MultiSelect. Type a character(s) in the MultiSelect element that are
                        not present in the dataSource, you can select and tag that custom typed characters as new item from the suggestion list.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The MultiSelect allows the user to add a non-present option to the component value when the <code>AllowCustomValue</code> is enabled. While selecting
                        new custom value the <code>CustomValueSelection</code> event will be triggered.
                    </p>
                    <p>
                        More information on the custom value feature can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/multiselect/custom-value/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Diacritics Filtering",
                Category = "MultiSelect",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect/DiacriticsFiltering",
                FileName = "DiacriticsFiltering.razor",
                Type = SampleType.New,
                TitleTag = "MultiSelect . DiacriticsFiltering . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates DropDownList filtering will ignore the diacritics which makes it easier to filter the results in international characters lists when the IgnoreAccent is enabled.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the diacritics filter functionality of the MultiSelect. Type the characters ‘gul’ in the MultiSelect element and it displays the suggestion list ignoring the diacritics lists.</p>"
                },
                Description = new string[] {
                @"<p>
                        The MultiSelect filtering will ignore the diacritics which makes it easier to filter the results in international characters lists when the ignoreAccent is enabled.
                    </p>
                    <p>
                        This sample illustrates using the international characters data.
                    </p>
                    <p>
                        More information on the MultiSelect diacritics filtering can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/multiselect/filtering/#diacritics-filtering"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Grouping",
                Category = "MultiSelect",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect/Grouping",
                FileName = "Grouping.razor",
                Type = SampleType.New,
                TitleTag = "MultiSelect . Grouping . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the grouping supports of the MultiSelect. Type a character in the MultiSelect element or click on this element to choose one or more items from the categorized list.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the grouping supports of the MultiSelect. Type a character in the MultiSelect element or click on this element to choose one or more items from the categorized list.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The MultiSelect allows to group the relevant items under a corresponding category by mapping the <code>GroupBy</code> field, and allows to load the list items.
                    </p>
                    <p>
                        The grouping sample illustrates how the vegetables are grouped based on its category.
                    </p>
                    <p>
                        More information on the grouping feature configuration can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/multiselect/grouping/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Grouping With CheckBox",
                Category = "MultiSelect",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect/GroupingWithCheckBox",
                FileName = "GroupingWithCheckBox.razor",
                Type = SampleType.New,
                TitleTag = "MultiSelect . GroupingWithCheckBox . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the grouping functionalities of the MultiSelect in checkbox mode.",
                ActionDescription = new string[] {
                    @"<p>
                    This sample demonstrates the grouping functionalities of the MultiSelect in checkbox mode. Clicking the checkbox in group will select all
                    the items grouped under it. Click the MultiSelect element and then type the character in the search box. It will display the filtered list
                    items based on the typed characters and then select the multiple values through the checkbox.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The MultiSelect has built-in support to select the multiple values through the checkbox, when the <code>Mode</code> property is set to
                        <code>CheckBox</code>. To perform the checkbox feature in MultiSelect, the <code>CheckBoxSelection</code> module should be injected in the
                        application end.
                    </p>
                    <p>
                        The grouping sample illustrates how the vegetables are grouped based on its category.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Selection Limit",
                Category = "MultiSelect",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect/SelectionLimit",
                FileName = "SelectionLimit.razor",
                Type = SampleType.New,
                TitleTag = "MultiSelect . SelectionLimit . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the maximum selection limit functionalities with checkbox of the MultiSelect. MultiSelect value can set restrictions based on the maximum selection length that can be selected.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the maximum selection limit functionalities with checkbox of the MultiSelect. MultiSelect value can set restrictions based on the maximum selection length that can be selected.</p>"
                },
                Description = new string[] {
                    @" <p>
                        The MultiSelect has built-in support to limit the value selected in Multiselect component, when the <code>MaximumSelectionLength</code> property is set as 3, maximum of only 3 value will be  selected in the MultiSelect.
                    </p>
                    <p>The selection limit sample illustrates  using the countries data. </p>"
                }
            },
            new Sample
            {
                Name = "Template",
                Category = "MultiSelect",
                Directory = "DropDowns/MultiSelect",
                Url = "MultiSelect/Template",
                FileName = "Template.razor",
                Type = SampleType.New,
                TitleTag = "MultiSelect . Template . Syncfusion Blazor Components",
                MetaDescription = "This sample demonstrates the template functionalities of the MultiSelect. Type a character in the MultiSelect element and choose an item from the customized list",
                ActionDescription = new string[] {
                    @"<p>
                        This sample demonstrates the template functionalities of the MultiSelect. Type a character in the MultiSelect element and choose an item from the customized list
                    </p>"
                },
                Description = new string[] {
                    @"<p>The MultiSelect has been provided with several options to customize each list items, group title, header and footer elements.</p>
                    <p>
                        This sample uses the following list of templates in MultiSelect.
                    </p>
                    <ul>
                        <li><code>ItemTemplate </code> - To customize the list item's content.</li>
                        <li><code>HeaderTemplate </code> - To customize the header element.</li>
                        <li><code>ValueTemplate  </code> - To customize the value element content that holds the selected item's text.</li>
                    </ul>
                    <p>
                        More information on the template feature configuration can be found in the
                        <a href=""https://ej2.syncfusion.com/blazor/documentation/multiselect/templates/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            }
        };

        public List<Sample> ListBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "ListBox/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor",
                Type = SampleType.New,
				TitleTag = "ListBox . DefaultFunctionalities . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates the default functionalities of Syncfusion ASP.NET Core Blazor ListBox component with minimum configuration.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the default functionalities of a ListBox. Click any item to select a single item and Ctrl +  click to select multiple items.</p>"
                },
                Description = new string[] {
                    @"<p>The <code>ListBox</code> is a graphical user interface component used to display a list of items. Users can select one or more items in the list using a checkbox or by keyboard selection.
                    It supports sorting, grouping, reordering, and drag and drop of items.</p>
                <p>In this sample, data is bound to the ListBox using the <code>DataSource</code> property. You can select your favorite cars from the ListBox.</p>
                <p> More information about the ListBox can be found in the
                    <a href=""https://ej2.syncfusion.com/aspnet-core-razor-components/documentation/listbox/getting-started/"" target=""_blank""> documentation section</a>.
                </p>"
                }
            },
            new Sample
            {
                Name = "Dual ListBox",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "ListBox/DualListBox",
                FileName = "DualListBox.razor",
                Type = SampleType.New,
				TitleTag = "ListBox . DualListBox . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates how to move items between the two list boxes using dual list box functionality.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the functionalities of the dual list box. Select an item from <code>Group A</code> and click the <code>moveTo</code> button to move item from <code>Group A</code> to <code>Group B.</code></p>"
                },
                Description = new string[] {
                    @"<p>The dual list box allows the user to move items between two list boxes. Dual list box can be created by listing items in the <a target='_blank' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.DropDowns.ListBoxToolbarSettings.html'><code>ListBoxToolbarSettings</code></a> property along with
                    <a target='_blank' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.DropDowns.EjsListBox~Scope.html'><code>Scope</code></a> property. The supported operations are,</p>
                <ul>
                    <li><code>moveUp</code> -  Moves the selected item in the upward direction.</li>
                    <li><code>moveDown</code> -  Moves the selected item in the downward direction.</li>
                    <li><code>moveTo</code> -  Moves the selected item to the Group B list box.</li>
                    <li><code>moveFrom</code> -  Moves the selected item from Group B list box to Group A.</li>
                    <li><code>moveAllTo</code> -  Moves all the items to the Group B list box.</li>
                    <li><code>moveAllFrom</code> -  Moves all the items from Group B list box to Group A.</li>
                </ul>"
                }
            },
            new Sample
            {
                Name = "Drag And Drop",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "ListBox/DragDrop",
                FileName = "DragDrop.razor",
                Type = SampleType.New,
				TitleTag = "ListBox . DragDrop . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates how to drag and drop within the Syncfusion ASP.NET Core Blazor ListBox and between two list boxes.",
                ActionDescription = new string[] {
                    @"<p>This example demonstrates how to drag and drop within the Syncfusion ASP.NET Core ListBox and between two list boxes.</p>"
                },
                Description = new string[] {
                    
                }
            },
            new Sample
            {
                Name = "Checkbox",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "ListBox/Checkbox",
                FileName = "Checkbox.razor",
                Type = SampleType.New,
				TitleTag = "ListBox . CheckBox . Syncfusion Blazor Components",
                MetaDescription = "This example demonstrates how to select multiple items from the Syncfusion ASP.NET Core Blazor ListBox using checkbox functionality.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the checkbox functionalities of the ListBox. Click one or more items from the list of items in the ListBox.</p>"
                },
                Description = new string[] {
                    @"<p>
                        The <code>ListBox</code> component has built-in support to select multiple items from the list. The Checkbox selection can be enabled by setting the
                        <a target='_blank' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.DropDowns.ListBoxSelectionSettings~ShowCheckbox.html'><code>ShowCheckbox</code></a> as
                        <code>true</code> in the <a target='_blank' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.DropDowns.ListBoxSelectionSettings.html'><code>SelectionSettings</code></a> property.
                    </p>
                    <p>To perform the checkbox feature in the ListBox, the <code>CheckBoxSelection</code> module has to be injected at the application level.</p>"
                }
            },
            new Sample
            {
                Name = "API",
                Category = "ListBox",
                Directory = "DropDowns/ListBox",
                Url = "ListBox/Api",
                FileName = "Api.razor",
                Type = SampleType.New,
				TitleTag = "ListBox . Api . Syncfusion Blazor Components",
                MetaDescription = "This example how to customize the Syncfusion ASP.NET Core Blazor ListBox component using the available set of APIs.",
                ActionDescription = new string[] {
                    @"<p>This sample demonstrates the API functionalities of the ListBox component by using its properties from the property pane. Select any combination of properties from the property pane to achieve desired functionalities in ListBox.</p>"
                },
                Description = new string[] {
                    @"<p>
                        In this demo, a ListBox is rendered with grouping feature by setting the <a target='_blank' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.DropDowns.ListBoxFieldSettings~GroupBy.html'><code>GroupBy</code></a> property
                        in <a target='_blank' href='https://help.syncfusion.com/cr/aspnetcore-blazor/Syncfusion.EJ2.Blazor~Syncfusion.EJ2.Blazor.DropDowns.EjsListBox~Fields.html'><code>ListBoxFieldSettings</code></a> property. This sample has been showcased with following set of properties,
                    </p>
            <ul>
                        <li>You can switch to <code>Single</code> or <code>Multiple</code> selection mode by selecting the mode from the selection mode dropdown list.</li>
                        <li>You can switch to <code>None</code>, <code>Ascending</code>, or <code>Descending</code> sort orders by selecting the sort order from the sort order dropdown list.</li>
                    </ul>
                    <p>In this sample, by default, grouping is enabled and vegetableData is grouped based on its category. The user can change the sort order and selection type using dropdownlist.</p>"
                }
            }
        };
    }
}
