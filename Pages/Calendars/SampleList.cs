using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor_samples;
namespace blazor_samples
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
            }
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
                Name = "Time Format",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Time-Format",
                FileName = "Format.razor",
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
                Type = SampleType.None
            },
            new Sample
            {
                Name = "Date Range",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Date-Range",
                FileName = "DateRange.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Day Span",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Day-Span",
                FileName = "DaySpan.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Format",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Format",
                FileName = "Format.razor",
                Type = SampleType.None
            },
             new Sample
            {
                Name = "Month Range Picker",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Month-Range-Picker",
                FileName = "MonthRangePicker.razor",
                Type = SampleType.None
            }
        };
    }
}
