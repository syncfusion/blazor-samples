using System.Collections.Generic;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> Calendar { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor Calendars Examples - Default | Calendars Demos | Syncfusion",
                HeaderText = "Blazor Calendar Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Calendar enables date selection, navigation, and styling with events and keyboard support to simplify scheduling and usage.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-calendar"
            },
            new Sample
            {
                Name = "Disabled Dates",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Disabled-Dates",
                FileName = "DisabledDates.razor",
                MetaTitle = "Blazor Calendars - Disabled Dates| Calendars Demos | Syncfusion",
                HeaderText = "Blazor Calendar Example - Disabled Dates",
                MetaDescription = "See how the Syncfusion Blazor Calendar enforces date restrictions with custom ranges and validation, providing clear feedback to prevent invalid selections.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Special Dates",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Special-Dates",
                FileName = "SpecialDates.razor",
                MetaTitle = "Blazor Calendars - Special Dates | Calendars Demos | Syncfusion",
                HeaderText = "Blazor Calendar Example - Special Dates",
                MetaDescription = "See how the Syncfusion Blazor Special Dates calendar highlights holidays and events with custom styling and tooltips to improve visibility and event planning",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Date Range",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Date-Range",
                FileName = "DateRange.razor",
                MetaTitle = "Blazor Calendar - Date Range | Calendars Demos | Syncfusion",
                HeaderText = "Blazor Calendar Example - Date Range",
                MetaDescription = "See how the Syncfusion Blazor Date Range calendar enables multi-day selection, min/max limits, and quick presets to streamline booking and range input UX",
                Type = SampleType.None
            },
              new Sample
            {
                Name = "Multi Selection",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Multi-Selection",
                FileName = "MultiSelection.razor",
                MetaTitle = "Blazor Calendars - Multi Selection | Calendars Demos | Syncfusion",
                HeaderText = "Blazor Calendar Example - Multi Selection",
                MetaDescription = "See how the Syncfusion Blazor Multi Selection calendar supports multiple date picks, batch actions, and keyboard navigation to speed multi-date workflows",
                Type = SampleType.None
            },
              new Sample
            {
                Name = "Month Picker",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Month-Picker",
                FileName = "MonthPicker.razor",
                MetaTitle = "Blazor Calendars - Month Picker | Calendars Demos | Syncfusion",
                HeaderText = "Blazor Calendar Example - Month Picker",
                MetaDescription = "See how the Syncfusion Blazor Month Picker enables month-level selection, year navigation, and localization support to simplify month-based scheduling and input",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Week Number",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Week-Number",
                FileName = "WeekNumber.razor",
                MetaTitle = "Blazor Calendar - Week Number | Calendars Demos | Syncfusion",
                HeaderText = "Blazor Calendar Example - Week Number",
                MetaDescription = "See how the Syncfusion Blazor Week Number calendar displays ISO week numbers, enhances navigation, and supports week-based planning for team schedules",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor Calendars - Keyboard Navigation | Calendars Demos | Syncfusion",
                HeaderText = "Blazor Calendar Example - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor Calendar enables keyboard navigation with shortcuts and focus control to improve accessibility and speed in interactions.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Islamic Calendar",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Islamic-Calendar",
                FileName = "IslamicCalendar.razor",
                MetaTitle = "Blazor Calendars - Islamic Calendar | Calendars Demos | Syncfusion",
                HeaderText = "Blazor Calendar Example - Islamic Calendar",
                MetaDescription = "See how the Syncfusion Blazor Islamic Calendar supports Hijri dates, localization, and custom formatting to enable culturally accurate date entry and display",
                Type = SampleType.None
            }
        };

        public List<Sample> DatePicker { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor DatePicker Examples - Default | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Default DatePicker offers popup calendar, input formatting, and validation with clear UX and localization to simplify date entry",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-datepicker"
            },
              new Sample
            {
                Name = "Disabled Dates",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Disabled-Dates",
                FileName = "DisabledDates.razor",
                MetaTitle = "Blazor DatePicker - Disabled Dates| Calendars Demos | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Disabled Dates",
                MetaDescription = "See how the Syncfusion Blazor Disabled Dates DatePicker enforces blocked ranges, custom rules, and validation messages to avoid invalid date input in forms",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Special Dates",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Special-Dates",
                FileName = "SpecialDates.razor",
                MetaTitle = "Blazor DatePicker - Special Dates | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Special Dates",
                MetaDescription = "See how the Syncfusion Blazor Special Dates DatePicker highlights holidays and events, supports custom styling and tooltips to guide user selection and planning",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Date Range",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Date-Range",
                FileName = "DateRange.razor",
                MetaTitle = "Blazor DatePicker - Date Range | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Date Range",
                MetaDescription = "See how the Syncfusion Blazor Date Range DatePicker enables start/end selection, range validation, and presets to streamline booking and form input workflows",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Format",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Format",
                FileName = "Format.razor",
                MetaTitle = "Blazor DatePicker - Format | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Format",
                MetaDescription = "See how the Syncfusion Blazor Format DatePicker supports custom date patterns, localization, and parse validation to ensure consistent display and user input",
                Type = SampleType.None,
            },
             new Sample
            {
                Name = "Mask Support",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/MaskSupport",
                FileName = "MaskSupport.razor",
                MetaTitle = "Blazor DatePicker - Mask Support | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Mask Support",
                MetaDescription = "See how the Syncfusion Blazor Mask Support DatePicker adds input masks, guided typing, and validation to reduce errors and speed accurate date entry in forms",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Month Picker",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Month-Picker",
                FileName = "MonthPicker.razor",
                MetaTitle = "Blazor DatePicker - Month Picker | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Month Picker",
                MetaDescription = "See how the Syncfusion Blazor DatePicker supports month selection with year navigation and localization to simplify month based input and scheduling easily.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Week Number",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Week-Number",
                FileName = "WeekNumber.razor",
                MetaTitle = "Blazor DatePicker - Week Number | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Week Number",
                MetaDescription = "See how the Syncfusion Blazor Week Number DatePicker shows week numbers, supports week-based selection, and eases planning for week-oriented workflows",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Validation",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor DatePicker - Validation | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Validation",
                MetaDescription = "See how the Syncfusion Blazor Validation DatePicker enforces format rules, shows helpful error messages, and integrates with forms to ensure reliable date input",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor DatePicker Demos - Keyboard Navigation Examples | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor Keyboard Navigation DatePicker enables accessible keyboard control, focus management, and shortcuts for faster date entry",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Islamic DatePicker",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Islamic-DatePicker",
                FileName = "IslamicDatePicker.razor",
                MetaTitle = "Blazor DatePicker - Islamic DatePicker | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Islamic DatePicker",
                MetaDescription = "See how the Syncfusion Blazor DatePicker supports Hijri calendar input with formatting and localization to handle cultural date requirements easily now.",
                Type = SampleType.None
            }
        };

        public List<Sample> DateTimePicker { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor DateTimePicker Demos - Default | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor Default DateTimePicker combines date and time pickers, formatting, and validation to streamline datetime input in forms and apps",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-datetime-picker"
            },
            new Sample
            {
                Name = "Disabled Dates",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Disabled-Dates",
                FileName = "DisabledDates.razor",
                MetaTitle = "Blazor DateTimePicker - Disabled Dates| Calendars Demos | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - Disabled Dates",
                MetaDescription = "See how the Syncfusion Blazor Disabled Dates DateTimePicker restricts date/time ranges, provides validation, and prevents invalid scheduling in workflows",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Special Dates",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Special-Dates",
                FileName = "SpecialDates.razor",
                MetaTitle = "Blazor DateTimePicker - Special Dates | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - Special Dates",
                MetaDescription = "See how the Syncfusion Blazor Special Dates DateTimePicker highlights events and holidays, supports tooltips and custom styling to aid scheduling decisions",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "DateTime Range",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Date-Time-Range",
                FileName = "DateTimeRange.razor",
                MetaTitle = "Blazor DateTimePicker - DateTime Range | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - DateTime Range",
                MetaDescription = "See how the Syncfusion Blazor DateTime Range picker enables start/end datetime selection, validation, and presets to simplify booking and scheduling workflows",
                Type = SampleType.None,
            },
             new Sample
            {
                Name = "Format",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Format",
                FileName = "Format.razor",
                MetaTitle = "Blazor DateTimePicker - Format | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - Format",
                MetaDescription = "See how the Syncfusion Blazor DateTimePicker supports custom date and time formats with localization and parsing to ensure consistent input and display.",
                Type = SampleType.None,
            },
              new Sample
            {
                Name = "Mask Support",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/MaskSupport",
                FileName = "MaskSupport.razor",
                MetaTitle = "Blazor DateTimePicker - Mask Support | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - Mask Support",
                MetaDescription = "See how the Syncfusion Blazor Mask Support DateTimePicker adds input masks, guided typing, and validation to reduce datetime entry errors and speed forms",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Week Number",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Week-Number",
                FileName = "WeekNumber.razor",
                MetaTitle = "Blazor DateTimePicker - Week Number | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - Week Number",
                MetaDescription = "See how the Syncfusion Blazor Week Number DateTimePicker displays week numbers with datetime selection and improves week-oriented scheduling and navigation",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Validation",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor DateTimePicker - Validation | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - Validation",
                MetaDescription = "See how the Syncfusion Blazor DateTimePicker enforces rules with clear error messages and form integration to ensure reliable and accurate datetime input.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor DateTimePicker Demos - Keyboard Navigation | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor Keyboard Navigation DateTimePicker supports keyboard shortcuts, focus handling, and accessibility for faster datetime entry",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Islamic DateTimePicker",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Islamic-DateTimePicker",
                FileName = "IslamicDateTimePicker.razor",
                MetaTitle = "Blazor DateTimePicker Demos - Islamic DateTimePicker | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - Islamic DateTimePicker",
                MetaDescription = "See how the Syncfusion Blazor Islamic DateTimePicker supports Hijri datetime input, localized formats, and validation to meet cultural scheduling needs",
                Type = SampleType.None
            },
        };


        public List<Sample> TimePicker { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor TimePicker Demos - Default | Calendars Demos | Syncfusion",
                HeaderText = "Blazor TimePicker Example - Default Functionalities",
                MetaDescription = "See how the Syncfusion Blazor TimePicker enables time selection with formatting options and keyboard support to improve accuracy and input efficiency.",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-timepicker"
            },
            new Sample
            {
                Name = "Time Range",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Time-Range",
                FileName = "TimeRange.razor",
                MetaTitle = "Blazor TimePicker Demos - Time Range Examples | Syncfusion",
                HeaderText = "Blazor TimePicker Example - Time Range",
                MetaDescription = "See how the Syncfusion Blazor Time Range picker enforces min/max limits, step intervals, and validation to prevent invalid time selections in scheduling",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Time Format",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Time-Format",
                FileName = "Format.razor",
                MetaTitle = "Blazor TimePicker - Time Format | Calendars Demos | Syncfusion",
                HeaderText = "Blazor TimePicker Example - Time Format",
                MetaDescription = "See how the Syncfusion Blazor Time Format picker supports 12/24 hour formats, custom patterns, and localization to ensure consistent time display and input",
                Type = SampleType.None,
            },
              new Sample
            {
                Name = "Mask Support",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/MaskSupport",
                FileName = "MaskSupport.razor",
                MetaTitle = "Blazor TimePicker - Mask Support | Calendars Demos | Syncfusion",
                HeaderText = "Blazor TimePicker Example - Mask Support",
                MetaDescription = "See how the Syncfusion Blazor Mask Support TimePicker adds input masks, guided typing, and validation to reduce entry errors and speed accurate time input",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Time Duration",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Time-Duration",
                FileName = "TimeDuration.razor",
                MetaTitle = "Blazor TimePicker - Time Duration | Calendars Demos | Syncfusion",
                HeaderText = "Blazor TimePicker Example - Time Duration",
                MetaDescription = "See how the Syncfusion Blazor TimePicker supports duration selection with interval settings and validation to simplify scheduling and time entry tasks.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Validation",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor TimePicker - Validation | Calendars Demos | Syncfusion",
                HeaderText = "Blazor TimePicker Example - Validation",
                MetaDescription = "See how the Syncfusion Blazor Validation TimePicker enforces time rules, shows clear feedback, and integrates with forms to ensure correct time entries",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor TimePicker Demos - Keyboard Navigation Examples | Syncfusion",
                HeaderText = "Blazor TimePicker Example - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor TimePicker supports keyboard navigation with shortcuts and focus control to enable faster and accessible time entry easily.",
                Type = SampleType.None
            }
        };


        public List<Sample> DateRangePicker { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Default-Functionalities",
                FileName = "DefaultFunctionalities.razor",
                MetaTitle = "Blazor DateRangePicker - Default | Calendars Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Default DateRangePicker provides calendar popup, presets, and validation with formatting to simplify selecting date ranges",
                HeaderText = "Blazor Date Range Picker Example - Default Functionalities",
                Type = SampleType.None,
                CustomCanonicalUrl = "https://www.syncfusion.com/blazor-components/blazor-daterangepicker"
            },
            new Sample
            {
                Name = "Date Range",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Date-Range",
                FileName = "DateRange.razor",
                MetaTitle = "Blazor DateRangePicker - Date Range | Calendars Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Date Range DateRangePicker enables flexible start/end selection, range validation, and quick presets to streamline bookings",
                HeaderText = "Blazor Date Range Picker Example - Date Range",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Day Span",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Day-Span",
                FileName = "DaySpan.razor",
                MetaTitle = "Blazor DateRangePicker - Day Span | Calendars Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Day Span DateRangePicker sets min/max day spans, validation, and presets to enforce business rules and simplify selection",
                HeaderText = "Blazor Date Range Picker Example - Day Span",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Preset Ranges",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Preset-Ranges",
                FileName = "PresetRanges.razor",
                MetaTitle = "Blazor DateRangePicker - Preset Ranges | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DateRangePicker Example - Preset Ranges",
                MetaDescription = "See how the Syncfusion Blazor DateRangePicker offers preset ranges with quick selection, customizable options and instant apply to speed common date selections.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Format",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Format",
                FileName = "Format.razor",
                MetaTitle = "Blazor DateRangePicker - Format | Calendars Demos | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Format DateRangePicker supports custom date patterns, localization, and parse validation for consistent range input and display",
                HeaderText = "Example of Formatting in Blazor Date Range Picker Component",
                Type = SampleType.None,
            },
             new Sample
            {
                Name = "Month Range Picker",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Month-Range-Picker",
                FileName = "MonthRangePicker.razor",
                MetaTitle = "Blazor DateRangePicker Demos - Month Range Picker | Syncfusion",
                MetaDescription = "See how the Syncfusion Blazor Month Range Picker enables month-to-month range selection, year navigation, and localization for efficient period selection",
                HeaderText = "Blazor Month Range Picker Example",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Week Number",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Week-Number",
                FileName = "WeekNumber.razor",
                MetaTitle = "Blazor DateRangePicker - Week Number | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DateRangePicker Example - Week Number",
                MetaDescription = "See how the Syncfusion Blazor Week Number DateRangePicker shows week numbers, supports week-range selection, and eases planning for week-oriented schedules",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Validation",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor DateRangePicker - Validation | Calendars Demos | Syncfusion",
                HeaderText = "Blazor DateRangePicker Example - Validation",
                MetaDescription = "See how the Syncfusion Blazor Validation DateRangePicker enforces range rules, shows helpful errors, and integrates with forms to ensure valid range input",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor DateRangePicker Demos - Keyboard Navigation | Syncfusion",
                HeaderText = "Blazor DateRangePicker Example - Keyboard Navigation",
                MetaDescription = "See how the Syncfusion Blazor DateRangePicker supports keyboard navigation with shortcuts and focus control to enable faster and accessible range selection.",
                Type = SampleType.None
            }
        };
    }
}