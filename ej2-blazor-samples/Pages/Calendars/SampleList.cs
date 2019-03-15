using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> Calendar { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New,
            },
             new Sample
            {
                Name = "Date Range",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/DateRange",
                FileName = "DateRange.cshtml",
                Type = SampleType.New,
            },
              new Sample
            {
                Name = "Multi Selection",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/MultiSelection",
                FileName = "MultiSelection.cshtml",
                Type = SampleType.New,
            }
        };

        public List<Sample> DatePicker { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Date Range",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/DateRange",
                FileName = "DateRange.cshtml",
                Type = SampleType.New,
            },
             new Sample
            {
                Name = "Format",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Format",
                FileName = "Format.cshtml",
                Type = SampleType.New,
            }
        };

        public List<Sample> DateTimePicker { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "DateTimePicker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTimePicker/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Date Time Range",
                Category = "DateTimePicker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTimePicker/DateTimeRange",
                FileName = "DateTimeRange.cshtml",
                Type = SampleType.New,
            },
             new Sample
            {
                Name = "Format",
                Category = "DateTimePicker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTimePicker/Format",
                FileName = "Format.cshtml",
                Type = SampleType.New,
            },
        };


        public List<Sample> TimePicker { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New,
            },
             new Sample
            {
                Name = "Time Format",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Format",
                FileName = "Format.cshtml",
                Type = SampleType.New,
            }
        };


        public List<Sample> DateRangePicker { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New,
            },
            new Sample
            {
                Name = "Date Range",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/DateRange",
                FileName = "DateRange.cshtml",
                Type = SampleType.New,
            },
             new Sample
            {
                Name = "Format",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Format",
                FileName = "Format.cshtml",
                Type = SampleType.New,
            }
        };
    }
}
