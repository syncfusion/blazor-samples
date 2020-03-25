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
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        The following sample demonstrates the default functionalities of the Calendar. Today's date is always <code>highlighted</code> in the Calendar and it get <code>focused</code> if there is no selected date. Click the desired date from the Calendar.
                    </p>"
                },
                Description = new string[]{
                    @" <p>
                        The <code>Calendar</code> is a graphical user interface component which provides the multi-view representation to display and select a date. Also, provide options to navigate in different levels of views like Month, Year, Decade.
                    </p>
                    <p>
                        More information on the calendar instantiation can be found in this
                        <a href=""https://blazor.syncfusion.com/documentation/calendar/getting-started/#adding-calendar-component-to-the-application"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Date Range",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Date-Range",
                FileName = "DateRange.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        In the following sample, a specific date ranges from 5th to 27th of a month has been set to select from the Calendar. All the other dates are out of range, and <code>restricted</code> to set or select.
                    </p>"
                },
                Description = new string[]{
                @"<p>
                        Date Range sample illustrates the date selection within a specific range in a calendar by using <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.CalendarBase%601~Min.html"" target=""_blank""> Min</a> and <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.CalendarBase%601~Max.html"" target=""_blank""> Max</a> properties. Here, the date selection range was resricted within 5th to 27th.
                    </p>
                    <p>
                        More information on the date range restriction can be found in this
                        <a href=""https://blazor.syncfusion.com/documentation/calendar/date-range/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
              new Sample
            {
                Name = "Multi Selection",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Multi-Selection",
                FileName = "MultiSelection.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        The following sample demonstrates the multiple date selection functionalities of the Calendar. Click /Touch the desired date from the Calendar and the selected date will be added to the Values property of the calendar.
                    </p>"
                },
                Description = new string[]{
                    @"<p>
                        Multi selection sample demonstrates, how to enable and select the multiple date in a calendar by using <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.CalendarModel~IsMultiSelection.html"" target=""_blank""> IsMultiSelection</a> and <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.CalendarModel~Values.html"" target=""_blank""> Values</a> properties . Here 10, 15 and 25 date's are selected.
                    </p>
                    <p>
                        More information on the calendar multi selection can be found in this
                        <a href=""https://blazor.syncfusion.com/documentation/calendar/multi-select/#multi-selection"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
              new Sample
            {
                Name = "Month Picker",
                Category = "Calendar",
                Directory = "Calendars/Calendar",
                Url = "Calendar/Month-Picker",
                FileName = "MonthPicker.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        The following sample demonstrates the Calendar control acting as a month picker. It allows you to select values in terms of months.
                    </p>"
                },
                Description = new string[]{
                    @" <p>
                        The Calendar has the <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.CalendarBase%601~Start.html"" target=""_blank""> Start</a> and the <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.CalendarBase%601~Depth.html"" target=""_blank""> Depth</a> properties that provide options to restrict users from navigating to any Calendar view (year, month, or decade).
                    </p>
                    <p>
                        More information on the Calendar Start/Depth can be found in the
                        <a href=""https://blazor.syncfusion.com/documentation/calendar/calendar-views/#calendar-views"" target=""_blank""> documentation section</a>.
                    </p>"
                }
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
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        The following sample demonstrates the default functionalities of the DatePicker. Today's date is always <code>highlighted</code> in the popup calendar and it get focused if there's no selected date. Click the desired date from the popup calendar and the selected date will be displayed in the element.
                    </p>"
                },
                Description = new string[]{
                    @"<p>
                        The <code>DatePicker</code> is a graphical user interface component that allows the user to select, or to enter a date value.
                    </p>
                    <p>
                        More information on the DatePicker instantiation can be found in the
                        <a href=""https://blazor.syncfusion.com/documentation/datepicker/getting-started/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Date Range",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Date-Range",
                FileName = "DateRange.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                @"<p>
                        In the following sample, a specific date ranges from 5th to 27th of the current month has been set to select from the Calendar. All the other dates are out of range and <code>restricted</code> to set or select.
                    </p>"
                },
                Description = new string[]{
                    @"<p>
                        Date Range sample illustrates the date selection within the specific range in a calendar by using <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.CalendarBase%601~Min.html"" target=""_blank""> Min</a> and <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.CalendarBase%601~Max.html"" target=""_blank""> Max</a> properties.
                        Here, the date selection range was restricted within a range from 5th to 27th days in a month.
                    </p>
                    <p>
                        More information on the date range configuration can be found in the <a href=""https://blazor.syncfusion.com/documentation/datepicker/date-range/""
                        target=""_blank"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Format",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Format",
                FileName = "Format.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                @"<p>
                        In this sample, the DatePicker has been configured with the <code>dd-MMM-yy</code> date format.
                    </p>"
                },
                Description = new string[]{
                @"<p>
                        Date Formats sample illustrates the support of custom date format in the DatePicker component by
                        using the <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.DatePickerModel~Format.html"" target=""_blank""> Format</a> property.
                    </p>
                    <p>
                        More information on the date format configuration can be found in the <a href=""https://blazor.syncfusion.com/documentation/datepicker/date-format/""
                        target=""_blank"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Month Picker",
                Category = "DatePicker",
                Directory = "Calendars/DatePicker",
                Url = "DatePicker/Month-Picker",
                FileName = "MonthPicker.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                @"<p>
                        The following sample demonstrates the DatePicker component acting as a month picker. It allows you to select values in terms of months.
                    </p>"
                },
                Description = new string[]{
                @"<p>
                        DatePicker has the <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.CalendarBase%601~Start.html"" target=""_blank""> Start</a> and the <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.CalendarBase%601~Depth.html"" target=""_blank""> Depth</a> properties that provide options to restrict
                        users from navigating to any Calendar view (year, month, or decade).
                    </p>
                    <p>
                        More information on the DatePicker Start/Depth can be found in the <a href=""https://blazor.syncfusion.com/documentation/datepicker/view/#start-and-depth-view""
                        target=""_blank"">documentation section</a>.
                    </p>"
                }
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
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        The following sample demonstrates the default functionalities of the DateTimePicker. Today's date is always <code>highlighted</code> in the popup calendar and it get focused if there's no selected date. Select the desired date and time from the calendar & timepicker popup and the selected date & time will be displayed in the element.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        The <code>DateTimePicker</code> is a graphical user interface component that allows the user to select, or to enter a datetime value.
                    </p>
                    <p>
                        More information on the DateTimePicker instantiation can be found in the
                        <a href=""https://blazor.syncfusion.com/documentation/datetime-picker/getting-started/#getting-started"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "DateTime Range",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Date-Time-Range",
                FileName = "DateTimeRange.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        In the following sample, a specific datetime ranges from 7th 10:00 AM to 27th 10:30 PM of the current month has been set to select from the Calendar. All the other dates are out of range and <code>restricted</code> to set or select.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        Date Range sample illustrates the date selection within the specific range in a calendar and time popup list by using <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.DateTimePickerModel%601~Min.html"" target=""_blank""> Min</a> and <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.DateTimePickerModel%601~Max.html"" target=""_blank""> Max</a> properties.
                        Here, the date selection range was restricted within a range from 7th 10:00 AM to 27th 10:30 PM days in a month.
                    </p>
                    <p>
                        More information on the datetime range configuration can be found in the <a href=""https://blazor.syncfusion.com/documentation/datetime-picker/date-time-range/""
                                                                                                    target=""_blank"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Format",
                Category = "DateTime Picker",
                Directory = "Calendars/DateTimePicker",
                Url = "DateTime-Picker/Format",
                FileName = "Format.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                @"<p>
                        In this sample, the DateTimePicker has been configured with the <code>dd-MMM-yy hh:mm a</code> date format.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        Date Formats sample illustrates the support of custom date format in the DateTimePicker component by
                        using the <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.DateTimePickerModel%601~Format.html"" target=""_blank""> Format</a> property. By using the <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.DateTimePickerModel%601~TimeFormat.html"" target=""_blank""> TimeFormat</a> property to format the displayed time value in the popup list.
                    </p>"
                }
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
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        The following sample demonstrates the default functionalities of the TimePicker. Click the TimePicker icon to select a desired time and the selected time value will be displayed in the TimePicker element.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        A <code>TimePicker</code> is an interactive component that provides an option to select a value from popup list or
                        set a desired time value.
                    </p>
                    <p>
                        More information about the TimePicker and it's configuration can be found in the
                        <a href=""https://blazor.syncfusion.com/documentation/timepicker/getting-started/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Time Format",
                Category = "TimePicker",
                Directory = "Calendars/TimePicker",
                Url = "TimePicker/Time-Format",
                FileName = "Format.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        The TimePicker has been customized with 24-hour <code>format</code> with 60 minutes <code>interval</code>. Click the TimePicker icon to a select a time from 00:00 to 23:00 from the TimePicker popup.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        TimePicker provides an option to customize the display format of the time value using the
                        <a href=""https://blazor.syncfusion.com/documentation/timepicker/getting-started/#setting-the-time-format"" target=""_blank"">Format</a>        property. It accepts <a href=""https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings""
                                                                                                                                                                                            target=""_blank"">standard</a> &
                        <a href=""https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings"" target=""_blank""> custom date and time format strings</a>        as specified in MSDN.
                    </p>
                    <p>
                        Here, the time value displayed in 24-hour format with <code> 60 </code> minute step interval. To know more about custom time formatting, refer the
                        <a href=""https://ej2.syncfusion.com/aspnetcore/documentation/base/intl.html#custom-formats"" target=""_blank""> Parsing and formatting</a>        section. By default, TimePicker component is formatted with `en` (English) culture.
                    </p>
                    <p>
                        More information about the TimePicker and it's configuration can be found in the
                        <a href=""https://blazor.syncfusion.com/documentation/timepicker/getting-started/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
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
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        The following sample demonstrates the default functionalities of the DateRangePicker. Today's date is always highlighted in the popup calendar and it get focused if there's no selected date. Select a date range from the popup calendar and the selected <code>date range</code> will be displayed in the DateRangePicker element.
                    </p>"
                },
                Description = new string[]{
                    @"<p>
                        <code>DateRangePicker</code> is an interactive component that allows the user to select a range from the calendar, or to set a range value.
                    </p>
                    <p>
                        More information on the DateRangePicker instantiation can be found in the
                        <a href=""https://blazor.syncfusion.com/documentation/daterangepicker/getting-started/"" target=""_blank""> documentation section</a>.
                    </p>"
                }
            },
            new Sample
            {
                Name = "Date Range",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Date-Range",
                FileName = "DateRange.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        In this sample, the date ranges from <code>Jan 15, 2017 - Dec 20, 2017</code> have been set. All the other dates are out of range and restricted to set or select.
                    </p>"
                },
                Description = new string[]{
                    @"<p>
                        DateRangePicker has <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.DateRangePickerModel~Min.html"" target=""_blank""> Min</a> and <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.DateRangePickerModel~Max.html"" target=""_blank""> Max</a> supports to restrict the user to select a value from the given range.
                        Only the values in this range will be enabled.
                        In this sample, we have specified <code>Min</code> range as <code>Jan 15, 2017</code> and <code>Max</code> range as <code>Dec 20, 2017</code>. User will be able to select the values between this range only.
                    </p>
                    <p>
                        More information on the DateRangePicker min/max support can be found in the
                        <a href=""https://blazor.syncfusion.com/documentation/daterangepicker/range-restriction/#restrict-the-range-within-a-range""
                        target=""_blank"">documentation section</a>.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Day Span",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Day-Span",
                FileName = "DaySpan.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        In this sample, your date range selection is restricted to select <code>minimum</code> five days and <code>maximum</code> ten days.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        DateRangePicker has <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.DateRangePickerModel~MinDays.html"" target=""_blank""> MinDays</a> and <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.DateRangePickerModel~MaxDays.html"" target=""_blank""> MaxDays</a> supports to force the user to select the minimum and maximum number of days in the range. Only the values in this range will be enabled.
                    </p>
                    <p>
                        For example, in some hotel booking website, we need to book rooms that includes packages like minimum 3 days to maximum 5 days. For this scenario this feature can be used.
                    </p>
                    <p>
                        More information on the DateRangePicker MinDays/MaxDays support can be found in the <a href=""https://blazor.syncfusion.com/documentation/daterangepicker/range-restriction/#range-span""
                        target=""_blank"">documentation section</a>."
                }
            },
             new Sample
            {
                Name = "Format",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Format",
                FileName = "Format.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        In this sample, the DateRangePicker has been configured with the <code>dd-MMM-yy hh:mm a</code> date time format.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        Format sample illustrates the support of custom date time format in the DateRangePicker component by
                        using the <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.DateRangePickerModel~Format.html"" target=""_blank""> Format</a> property.
                    </p>"
                }
            },
             new Sample
            {
                Name = "Month Range Picker",
                Category = "DateRangePicker",
                Directory = "Calendars/DateRangePicker",
                Url = "DateRangePicker/Month-Range-Picker",
                FileName = "MonthRangePicker.razor",
                Type = SampleType.New,
                ActionDescription = new string[] {
                    @"<p>
                        The following sample demonstrates the DateRangePicker component acting as a month range picker. It allows you to select values within the range of months.
                    </p>"
                },
                Description = new string[] {
                    @"<p>
                        DatePicker has the <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.DateRangePickerModel~Start.html"" target=""_blank""> Start</a> and the <a href=""https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor~Syncfusion.Blazor.Calendars.DateRangePickerModel~Depth.html"" target=""_blank""> Depth</a> properties that provide options to restrict users from navigating to any Calendar view (year, month, or decade).
                    </p>"
                }
            }
        };
    }
}
