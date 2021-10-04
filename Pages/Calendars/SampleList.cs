using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
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
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Disabled Dates",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Disabled-Dates",
                FileName = "DisabledDates.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Special Dates",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Special-Dates",
                FileName = "SpecialDates.razor",
                Type = SampleType.New
            },
             new Sample
            {
                Name = "Date Range",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Date-Range",
                FileName = "DateRange.razor",
                Type = SampleType.None
            },
              new Sample
            {
                Name = "Multi Selection",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Multi-Selection",
                FileName = "MultiSelection.razor",
                Type = SampleType.None
            },
              new Sample
            {
                Name = "Month Picker",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Month-Picker",
                FileName = "MonthPicker.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Week Number",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Week-Number",
                FileName = "WeekNumber.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.New
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
                Type = SampleType.None
            },
              new Sample
            {
                Name = "Disabled Dates",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Disabled-Dates",
                FileName = "DisabledDates.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Special Dates",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Special-Dates",
                FileName = "SpecialDates.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Date Range",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Date-Range",
                FileName = "DateRange.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Format",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Format",
                FileName = "Format.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Month Picker",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Month-Picker",
                FileName = "MonthPicker.razor",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Week Number",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Week-Number",
                FileName = "WeekNumber.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Validation",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Forms-Validation",
                FileName = "FormsValidation.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.New
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
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Disabled Dates",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Disabled-Dates",
                FileName = "DisabledDates.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Special Dates",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Special-Dates",
                FileName = "SpecialDates.razor",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "DateTime Range",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Date-Time-Range",
                FileName = "DateTimeRange.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Format",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Format",
                FileName = "Format.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Week Number",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Week-Number",
                FileName = "WeekNumber.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Validation",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Forms-Validation",
                FileName = "FormsValidation.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.New
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
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Time Range",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Time-Range",
                FileName = "TimeRange.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Time Format",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Time-Format",
                FileName = "Format.razor",
                Type = SampleType.Updated,
                NotificationDescription = new string[] {
                    @"Updated the demo by including an option to change the display format of the TimePicker."
                }
            },
            new Sample
            {
                Name = "Time Duration",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Time-Duration",
                FileName = "TimeDuration.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Validation",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Forms-Validation",
                FileName = "FormsValidation.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.New
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
                MetaTitle = "Blazor DateRangePicker Example - Syncfusion Demos",
                MetaDescription = "This Blazor DataRangePicker example demonstrates the Default Functionalities. Explore here for more details.",
                HeaderText = "Blazor Date Range Picker Example",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Date Range",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Date-Range",
                FileName = "DateRange.razor",
                MetaTitle = "Blazor DateRangePicker Example - Syncfusion Demos",
                MetaDescription = "This Blazor DataRangePicker example demonstrates the Date Range. Explore here for more details.",
                HeaderText = "Blazor Date Range Picker Example",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Day Span",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Day-Span",
                FileName = "DaySpan.razor",
                MetaTitle = "Blazor DateRangePicker Example - Syncfusion Demos",
                MetaDescription = "This Blazor DataRangePicker example demonstrates the Day Span. Explore here for more details.",
                HeaderText = "Blazor Date Range Picker Example",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Preset Ranges",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Preset-Ranges",
                FileName = "PresetRanges.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Format",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Format",
                FileName = "Format.razor",
                MetaTitle = "Blazor DateRangePicker Example - Syncfusion Demos",
                MetaDescription = "This Blazor DataRangePicker example demonstrates the Format. Explore here for more details.",
                HeaderText = "Blazor Date Range Picker Example",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Month Range Picker",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Month-Range-Picker",
                FileName = "MonthRangePicker.razor",
                MetaTitle = "Blazor DateRangePicker Example - Syncfusion Demos",
                MetaDescription = "This Blazor DataRangePicker example demonstrates the Month Range Picker. Explore here for more details.",
                HeaderText = "Blazor Date Range Picker Example",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Week Number",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Week-Number",
                FileName = "WeekNumber.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Validation",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Forms-Validation",
                FileName = "FormsValidation.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                Type = SampleType.New
            }
        };
    }
}
