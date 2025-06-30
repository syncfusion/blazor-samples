#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
                MetaTitle = "Blazor Calendar Default | Date Selection Component | Syncfusion",
                HeaderText = "Blazor Calendar Example - Default Functionalities",
                MetaDescription = "This Blazor Calendar default example demonstrates date selection with navigation, customizable styling, and event handling for calendar-based applications.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Disabled Dates",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Disabled-Dates",
                FileName = "DisabledDates.razor",
                MetaTitle = "Blazor Calendar Disabled Dates | Date Restriction | Syncfusion",
                HeaderText = "Blazor Calendar Example - Disabled Dates",
                MetaDescription = "This Blazor Calendar disabled dates example demonstrates date restriction functionality with customizable disabled date ranges for controlled date selection.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Special Dates",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Special-Dates",
                FileName = "SpecialDates.razor",
                MetaTitle = "Blazor Calendar Special Dates | Date Highlighting | Syncfusion",
                HeaderText = "Blazor Calendar Example - Special Dates",
                MetaDescription = "This Blazor Calendar special dates example demonstrates date highlighting with custom styling for holidays, events, and important dates visualization.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Date Range",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Date-Range",
                FileName = "DateRange.razor",
                MetaTitle = "Blazor Calendar Date Range | Min Max Date Selection | Syncfusion",
                HeaderText = "Blazor Calendar Example - Date Range",
                MetaDescription = "This Blazor Calendar date range example demonstrates minimum and maximum date restrictions for controlled date selection within specified boundaries.",
                Type = SampleType.None
            },
              new Sample
            {
                Name = "Multi Selection",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Multi-Selection",
                FileName = "MultiSelection.razor",
                MetaTitle = "Blazor Calendar Multi Selection | Multiple Dates | Syncfusion",
                HeaderText = "Blazor Calendar Example - Multi Selection",
                MetaDescription = "This Blazor Calendar multi selection example demonstrates multiple date selection functionality for selecting multiple dates simultaneously in calendar applications.",
                Type = SampleType.None
            },
              new Sample
            {
                Name = "Month Picker",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Month-Picker",
                FileName = "MonthPicker.razor",
                MetaTitle = "Blazor Calendar Month Picker | Month Selection | Syncfusion",
                HeaderText = "Blazor Calendar Example - Month Picker",
                MetaDescription = "This Blazor Calendar month picker example demonstrates month-level selection with year navigation for month-based date selection scenarios.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Week Number",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Week-Number",
                FileName = "WeekNumber.razor",
                MetaTitle = "Blazor Calendar Week Number | Week Display | Syncfusion",
                HeaderText = "Blazor Calendar Example - Week Number",
                MetaDescription = "This Blazor Calendar week number example demonstrates week number display functionality for enhanced calendar navigation and week-based planning.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Keyboard Navigation",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor Calendar Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor Calendar Example - Keyboard Navigation",
                MetaDescription = "This Blazor Calendar keyboard navigation example demonstrates accessibility features with keyboard shortcuts and focus management for enhanced usability.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Islamic Calendar",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Islamic-Calendar",
                FileName = "IslamicCalendar.razor",
                MetaTitle = "DateTime Picker Islamic DateTimePicker - Syncfusion Demos",
                HeaderText = "Blazor Calendar Example - Islamic Calendar",
                MetaDescription = "This Blazor Islamic Calendar example demonstrates Hijri calendar support with Islamic date system for culturally appropriate date selection and display.",
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
                MetaTitle = "Blazor DatePicker Default | Date Input Component | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Default Functionalities",
                MetaDescription = "This Blazor DatePicker default example demonstrates date input with calendar popup, formatting options, and validation for form-based date selection.",
                Type = SampleType.None,
            },
              new Sample
            {
                Name = "Disabled Dates",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Disabled-Dates",
                FileName = "DisabledDates.razor",
                MetaTitle = "Blazor DatePicker Disabled Dates | Date Restriction | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Disabled Dates",
                MetaDescription = "This Blazor DatePicker disabled dates example demonstrates date restriction functionality with customizable disabled date ranges for controlled input.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Special Dates",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Special-Dates",
                FileName = "SpecialDates.razor",
                MetaTitle = "Blazor DatePicker Special Dates | Date Highlighting | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Special Dates",
                MetaDescription = "This Blazor DatePicker special dates example demonstrates date highlighting with custom styling for holidays and important dates in date picker popup.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Date Range",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Date-Range",
                FileName = "DateRange.razor",
                MetaTitle = "Blazor DatePicker Date Range | Min Max Date Input | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Date Range",
                MetaDescription = "This Blazor DatePicker date range example demonstrates minimum and maximum date restrictions for controlled date input within specified boundaries.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Format",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Format",
                FileName = "Format.razor",
                MetaTitle = "Blazor DatePicker Format | Date Display Formatting | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Format",
                MetaDescription = "This Blazor DatePicker format example demonstrates date display formatting with customizable date patterns and localization support for global applications.",
                Type = SampleType.None,
            },
             new Sample
            {
                Name = "Mask Support",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/MaskSupport",
                FileName = "MaskSupport.razor",
                MetaTitle = "Blazor DatePicker Mask Support | Input Masking | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Mask Support",
                MetaDescription = "This Blazor DatePicker mask support example demonstrates input masking functionality with guided date entry and format validation for improved user experience.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Month Picker",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Month-Picker",
                FileName = "MonthPicker.razor",
                MetaTitle = "Blazor DatePicker Month Picker | Month Selection Input | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Month Picker",
                MetaDescription = "This Blazor DatePicker month picker example demonstrates month-level selection input with year navigation for month-based date entry scenarios.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Week Number",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Week-Number",
                FileName = "WeekNumber.razor",
                MetaTitle = "Blazor DatePicker Week Number | Week Display Input | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Week Number",
                MetaDescription = "This Blazor DatePicker week number example demonstrates week number display in calendar popup for enhanced date navigation and week-based selection.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Validation",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor DatePicker Validation | Form Validation | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Validation",
                MetaDescription = "This Blazor DatePicker validation example demonstrates form validation with error handling and validation messages for robust date input forms.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor DatePicker Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Keyboard Navigation",
                MetaDescription = "This Blazor DatePicker keyboard navigation example demonstrates accessibility features with keyboard shortcuts and focus management for enhanced usability.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Islamic DatePicker",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Islamic-DatePicker",
                FileName = "IslamicDatePicker.razor",
                MetaTitle = "Blazor Islamic DatePicker | Hijri Calendar Input | Syncfusion",
                HeaderText = "Blazor DatePicker Example - Islamic DatePicker",
                MetaDescription = "This Blazor Islamic DatePicker example demonstrates Hijri calendar input support with Islamic date system for culturally appropriate date entry.",
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
                MetaTitle = "DateTime Picker Default Functionalities - Syncfusion Demos",
                HeaderText = "Blazor DateTimePicker Example - Default Functionalities",
                MetaDescription = "This Blazor DateTimePicker default example demonstrates date and time input with calendar and time picker popups for comprehensive datetime selection.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Disabled Dates",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Disabled-Dates",
                FileName = "DisabledDates.razor",
                MetaTitle = "Blazor DateTimePicker Disabled Dates | DateTime Restriction | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - Disabled Dates",
                MetaDescription = "This Blazor DateTimePicker disabled dates example demonstrates date restriction functionality with customizable disabled date ranges for controlled datetime input.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Special Dates",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Special-Dates",
                FileName = "SpecialDates.razor",
                MetaTitle = "Blazor DateTimePicker Special Dates | DateTime Highlighting | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - Special Dates",
                MetaDescription = "This Blazor DateTimePicker special dates example demonstrates date highlighting with custom styling for holidays and important dates in datetime picker.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "DateTime Range",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Date-Time-Range",
                FileName = "DateTimeRange.razor",
                MetaTitle = "Blazor DateTimePicker Range | Min Max DateTime Input | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - DateTime Range",
                MetaDescription = "This Blazor DateTimePicker range example demonstrates minimum and maximum datetime restrictions for controlled datetime input within specified boundaries.",
                Type = SampleType.None,
            },
             new Sample
            {
                Name = "Format",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Format",
                FileName = "Format.razor",
                MetaTitle = "Blazor DateTimePicker Format | DateTime Display Format | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - Format",
                MetaDescription = "This Blazor DateTimePicker format example demonstrates datetime display formatting with customizable patterns and localization support for global applications.",
                Type = SampleType.None,
            },
              new Sample
            {
                Name = "Mask Support",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/MaskSupport",
                FileName = "MaskSupport.razor",
                MetaTitle = "Blazor DateTimePicker Mask | DateTime Input Masking | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - Mask Support",
                MetaDescription = "This Blazor DateTimePicker mask support example demonstrates input masking functionality with guided datetime entry and format validation for improved UX.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Week Number",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Week-Number",
                FileName = "WeekNumber.razor",
                MetaTitle = "Blazor DateTimePicker Week Number | Week Display | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - Week Number",
                MetaDescription = "This Blazor DateTimePicker week number example demonstrates week number display in calendar popup for enhanced datetime navigation and week-based selection.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Validation",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor DateTimePicker Validation | Form Validation | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - Validation",
                MetaDescription = "This Blazor DateTimePicker validation example demonstrates form validation with error handling and validation messages for robust datetime input forms.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor DateTimePicker Keyboard | Accessibility | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - Keyboard Navigation",
                MetaDescription = "This Blazor DateTimePicker keyboard navigation example demonstrates accessibility features with keyboard shortcuts and focus management for enhanced usability.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Islamic DateTimePicker",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Islamic-DateTimePicker",
                FileName = "IslamicDateTimePicker.razor",
                MetaTitle = "Blazor Islamic DateTimePicker | Hijri DateTime Input | Syncfusion",
                HeaderText = "Blazor DateTimePicker Example - Islamic DateTimePicker",
                MetaDescription = "This Blazor Islamic DateTimePicker example demonstrates Hijri calendar datetime input support with Islamic date system for culturally appropriate datetime entry.",
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
                MetaTitle = "Blazor TimePicker Default | Time Input Component | Syncfusion",
                HeaderText = "Blazor TimePicker Example - Default Functionalities",
                MetaDescription = "This Blazor TimePicker default example demonstrates time input with time picker popup, formatting options, and validation for form-based time selection.",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Time Range",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Time-Range",
                FileName = "TimeRange.razor",
                MetaTitle = "Blazor TimePicker Time Range | Min Max Time Input | Syncfusion",
                HeaderText = "Blazor TimePicker Example - Time Range",
                MetaDescription = "This Blazor TimePicker time range example demonstrates minimum and maximum time restrictions for controlled time input within specified time boundaries.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Time Format",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Time-Format",
                FileName = "Format.razor",
                MetaTitle = "Blazor TimePicker Format | Time Display Formatting | Syncfusion",
                HeaderText = "Blazor TimePicker Example - Time Format",
                MetaDescription = "This Blazor TimePicker format example demonstrates time display formatting with customizable time patterns and 12/24 hour format support for global applications.",
                Type = SampleType.None,
            },
              new Sample
            {
                Name = "Mask Support",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/MaskSupport",
                FileName = "MaskSupport.razor",
                MetaTitle = "Blazor TimePicker Mask Support | Time Input Masking | Syncfusion",
                HeaderText = "Blazor TimePicker Example - Mask Support",
                MetaDescription = "This Blazor TimePicker mask support example demonstrates input masking functionality with guided time entry and format validation for improved user experience.",
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Time Duration",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Time-Duration",
                FileName = "TimeDuration.razor",
                MetaTitle = "Blazor TimePicker Duration | Time Interval Selection | Syncfusion",
                HeaderText = "Blazor TimePicker Example - Time Duration",
                MetaDescription = "This Blazor TimePicker duration example demonstrates time interval selection with customizable step values for precise time duration input and selection.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Validation",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor TimePicker Validation | Form Validation | Syncfusion",
                HeaderText = "Blazor TimePicker Example - Validation",
                MetaDescription = "This Blazor TimePicker validation example demonstrates form validation with error handling and validation messages for robust time input forms.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor TimePicker Keyboard Navigation | Accessibility | Syncfusion",
                HeaderText = "Blazor TimePicker Example - Keyboard Navigation",
                MetaDescription = "This Blazor TimePicker keyboard navigation example demonstrates accessibility features with keyboard shortcuts and focus management for enhanced usability.",
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
                MetaTitle = "Blazor DateRangePicker Example - Syncfusion Demos",
                MetaDescription = "This Blazor DataRangePicker example demonstrates the default functionalities. Explore here for more details.",
                HeaderText = "Blazor Date Range Picker Example",
                Type = SampleType.None,
            },
            new Sample
            {
                Name = "Date Range",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Date-Range",
                FileName = "DateRange.razor",
                MetaTitle = "Blazor DateRangePicker Example - Syncfusion Demos",
                MetaDescription = "This example demonstrates the setting minimum and maximum date range in Blazor DataRangePicker. Explore here for more details.",
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
                MetaDescription = "This example demonstrates the minimum and maximum day span in Blazor DataRangePicker. Explore here for more details.",
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
                MetaTitle = "Blazor DateRangePicker Preset Ranges | Quick Selection | Syncfusion",
                HeaderText = "Blazor DateRangePicker Example - Preset Ranges",
                MetaDescription = "This Blazor DateRangePicker preset ranges example demonstrates quick date range selection with predefined ranges like Today, Last Week, Last Month for efficient selection.",
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
                MetaDescription = "This example demonstrates the formatting in Blazor DataRangePicker. Explore here for more details.",
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
                MetaTitle = "Blazor DateRangePicker Example - Syncfusion Demos",
                MetaDescription = "This example demonstrates creating Month Range Picker using Blazor DataRangePicker. Explore here for more details.",
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
                MetaTitle = "Blazor DateRangePicker Week Number | Week Display | Syncfusion",
                HeaderText = "Blazor DateRangePicker Example - Week Number",
                MetaDescription = "This Blazor DateRangePicker week number example demonstrates week number display in calendar popup for enhanced date range navigation and week-based selection.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Validation",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Forms-Validation",
                FileName = "FormsValidation.razor",
                MetaTitle = "Blazor DateRangePicker Validation | Form Validation | Syncfusion",
                HeaderText = "Blazor DateRangePicker Example - Validation",
                MetaDescription = "This Blazor DateRangePicker validation example demonstrates form validation with error handling and validation messages for robust date range input forms.",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Keyboard Navigation",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Keyboard-Navigation",
                FileName = "KeyboardNavigation.razor",
                MetaTitle = "Blazor DateRangePicker Keyboard | Accessibility | Syncfusion",
                HeaderText = "Blazor DateRangePicker Example - Keyboard Navigation",
                MetaDescription = "This Blazor DateRangePicker keyboard navigation example demonstrates accessibility features with keyboard shortcuts and focus management for enhanced usability.",
                Type = SampleType.None
            }
        };
    }
}