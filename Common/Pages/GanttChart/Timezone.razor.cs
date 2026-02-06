#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using Syncfusion.Blazor.Buttons;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Navigations;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class Timezone
    {
        public List<TimezoneData.TaskData>? TaskCollection { get; set; } = new List<TimezoneData.TaskData>();
        public SfGantt<TimezoneData.TaskData>? GanttInstance { get; set; }
        public List<Object>? ToolbarItems { get; set; }
        public string TimeZone { get; set; } = TimeZoneValues[21].Id!;
        public TimelineViewMode TimelineViewMode = TimelineViewMode.Day;
        public string TopFormat { get; set; } = "MMM dd, yyyy";
        public string BottomFormat { get; set; } = "hh tt";
        private string selectedTimeZone = TimeZoneValues[21].Id!;
        private static readonly List<string> timelineModeValues = new List<string> { "Day", "Week", "Month" };
        private string selectedTimelineMode = timelineModeValues[0];

        /// <summary>
        /// Represents a timezone option for the dropdown.
        /// </summary>
        public class TimeZoneFields
        {
            public string? Id { get; set; }
            public string? Text { get; set; }
        }

        /// <summary>
        /// A static list of predefined timezone options used in the timezone dropdown.
        /// </summary>
        private static List<TimeZoneFields> TimeZoneValues = new List<TimeZoneFields>()
        {
            new TimeZoneFields { Id = "Etc/GMT+12", Text = "(UTC-12:00) International Date Line West" },
            new TimeZoneFields { Id = "Etc/GMT+11", Text = "(UTC-11:00) Coordinated Universal Time-11" },
            new TimeZoneFields { Id = "America/Adak", Text = "(UTC-10:00) Aleutian Islands" },
            new TimeZoneFields { Id = "Pacific/Honolulu", Text = "(UTC-10:00) Hawaii" },
            new TimeZoneFields { Id = "Pacific/Marquesas", Text = "(UTC-09:30) Marquesas Islands" },
            new TimeZoneFields { Id = "America/Anchorage", Text = "(UTC-09:00) Alaska" },
            new TimeZoneFields { Id = "Etc/GMT+9", Text = "(UTC-09:00) Coordinated Universal Time-09" },
            new TimeZoneFields { Id = "America/Tijuana", Text = "(UTC-08:00) Baja California" },
            new TimeZoneFields { Id = "Etc/GMT+8", Text = "(UTC-08:00) Coordinated Universal Time-08" },
            new TimeZoneFields { Id = "America/Los_Angeles", Text = "(UTC-08:00) Pacific Time (US & Canada)" },
            new TimeZoneFields { Id = "America/Phoenix", Text = "(UTC-07:00) Arizona" },
            new TimeZoneFields { Id = "America/Chihuahua", Text = "(UTC-07:00) Chihuahua, La Paz, Mazatlan" },
            new TimeZoneFields { Id = "America/Denver", Text = "(UTC-07:00) Mountain Time (US & Canada)" },
            new TimeZoneFields { Id = "America/Whitehorse", Text = "(UTC-07:00) Yukon" },
            new TimeZoneFields { Id = "America/Guatemala", Text = "(UTC-06:00) Central America" },
            new TimeZoneFields { Id = "America/Chicago", Text = "(UTC-06:00) Central Time (US & Canada)" },
            new TimeZoneFields { Id = "Pacific/Easter", Text = "(UTC-06:00) Easter Island" },
            new TimeZoneFields { Id = "America/Mexico_City", Text = "(UTC-06:00) Guadalajara, Mexico City, Monterrey" },
            new TimeZoneFields { Id = "America/Regina", Text = "(UTC-06:00) Saskatchewan" },
            new TimeZoneFields { Id = "America/Bogota", Text = "(UTC-05:00) Bogota, Lima, Quito, Rio Branco" },
            new TimeZoneFields { Id = "America/Cancun", Text = "(UTC-05:00) Chetumal" },
            new TimeZoneFields { Id = "America/New_York", Text = "(UTC-05:00) Eastern Time (US & Canada)" },
            new TimeZoneFields { Id = "America/Port-au-Prince", Text = "(UTC-05:00) Haiti" },
            new TimeZoneFields { Id = "America/Havana", Text = "(UTC-05:00) Havana" },
            new TimeZoneFields { Id = "America/Indiana/Indianapolis", Text = "(UTC-05:00) Indiana (East)" },
            new TimeZoneFields { Id = "America/Grand_Turk", Text = "(UTC-04:00) Turks and Caicos" },
            new TimeZoneFields { Id = "America/Asuncion", Text = "(UTC-04:00) Asuncion" },
            new TimeZoneFields { Id = "America/Halifax", Text = "(UTC-04:00) Atlantic Time (Canada)" },
            new TimeZoneFields { Id = "America/Caracas", Text = "(UTC-04:00) Caracas" },
            new TimeZoneFields { Id = "America/Cuiaba", Text = "(UTC-04:00) Cuiaba" },
            new TimeZoneFields { Id = "America/La_Paz", Text = "(UTC-04:00) Georgetown, La Paz, Manaus, San Juan" },
            new TimeZoneFields { Id = "America/Santiago", Text = "(UTC-04:00) Santiago" },
            new TimeZoneFields { Id = "America/St_Johns", Text = "(UTC-03:30) Newfoundland" },
            new TimeZoneFields { Id = "America/Araguaina", Text = "(UTC-03:00) Araguaina" },
            new TimeZoneFields { Id = "America/Sao_Paulo", Text = "(UTC-03:00) Brasilia" },
            new TimeZoneFields { Id = "America/Cayenne", Text = "(UTC-03:00) Cayenne, Fortaleza" },
            new TimeZoneFields { Id = "America/Argentina/Buenos_Aires", Text = "(UTC-03:00) City of Buenos Aires" },
            new TimeZoneFields { Id = "America/Godthab", Text = "(UTC-03:00) Greenland" },
            new TimeZoneFields { Id = "America/Montevideo", Text = "(UTC-03:00) Montevideo" },
            new TimeZoneFields { Id = "America/Punta_Arenas", Text = "(UTC-03:00) Punta Arenas" },
            new TimeZoneFields { Id = "America/Miquelon", Text = "(UTC-03:00) Saint Pierre and Miquelon" },
            new TimeZoneFields { Id = "America/Bahia", Text = "(UTC-03:00) Salvador" },
            new TimeZoneFields { Id = "Etc/GMT+2", Text = "(UTC-02:00) Coordinated Universal Time-02" },
            new TimeZoneFields { Id = "Atlantic/Azores", Text = "(UTC-01:00) Azores" },
            new TimeZoneFields { Id = "Atlantic/Cape_Verde", Text = "(UTC-01:00) Cabo Verde Is." },
            new TimeZoneFields { Id = "Etc/UTC", Text = "(UTC) Coordinated Universal Time" },
            new TimeZoneFields { Id = "Europe/London", Text = "(UTC+00:00) Dublin, Edinburgh, Lisbon, London" },
            new TimeZoneFields { Id = "Atlantic/Reykjavik", Text = "(UTC+00:00) Monrovia, Reykjavik" },
            new TimeZoneFields { Id = "Africa/Sao_Tome", Text = "(UTC+00:00) Sao Tome" },
            new TimeZoneFields { Id = "Europe/Berlin", Text = "(UTC+01:00) Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna" },
            new TimeZoneFields { Id = "Europe/Budapest", Text = "(UTC+01:00) Belgrade, Bratislava, Budapest, Ljubljana, Prague" },
            new TimeZoneFields { Id = "Europe/Paris", Text = "(UTC+01:00) Brussels, Copenhagen, Madrid, Paris" },
            new TimeZoneFields { Id = "Europe/Warsaw", Text = "(UTC+01:00) Sarajevo, Skopje, Warsaw, Zagreb" },
            new TimeZoneFields { Id = "Africa/Lagos", Text = "(UTC+01:00) West Central Africa" },
            new TimeZoneFields { Id = "Asia/Amman", Text = "(UTC+02:00) Amman" },
            new TimeZoneFields { Id = "Europe/Bucharest", Text = "(UTC+02:00) Athens, Bucharest" },
            new TimeZoneFields { Id = "Asia/Beirut", Text = "(UTC+02:00) Beirut" },
            new TimeZoneFields { Id = "Africa/Cairo", Text = "(UTC+02:00) Cairo" },
            new TimeZoneFields { Id = "Europe/Chisinau", Text = "(UTC+02:00) Chisinau" },
            new TimeZoneFields { Id = "Asia/Damascus", Text = "(UTC+02:00) Damascus" },
            new TimeZoneFields { Id = "Asia/Hebron", Text = "(UTC+02:00) Gaza, Hebron" },
            new TimeZoneFields { Id = "Africa/Harare", Text = "(UTC+02:00) Harare, Pretoria" },
            new TimeZoneFields { Id = "Europe/Kiev", Text = "(UTC+02:00) Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius" },
            new TimeZoneFields { Id = "Asia/Jerusalem", Text = "(UTC+02:00) Jerusalem" },
            new TimeZoneFields { Id = "Europe/Kaliningrad", Text = "(UTC+02:00) Kaliningrad" },
            new TimeZoneFields { Id = "Africa/Khartoum", Text = "(UTC+02:00) Khartoum" },
            new TimeZoneFields { Id = "Africa/Tripoli", Text = "(UTC+02:00) Tripoli" },
            new TimeZoneFields { Id = "Africa/Windhoek", Text = "(UTC+02:00) Windhoek" },
            new TimeZoneFields { Id = "Asia/Baghdad", Text = "(UTC+03:00) Baghdad" },
            new TimeZoneFields { Id = "Europe/Istanbul", Text = "(UTC+03:00) Istanbul" },
            new TimeZoneFields { Id = "Asia/Riyadh", Text = "(UTC+03:00) Kuwait, Riyadh" },
            new TimeZoneFields { Id = "Europe/Minsk", Text = "(UTC+03:00) Minsk" },
            new TimeZoneFields { Id = "Europe/Moscow", Text = "(UTC+03:00) Moscow, St. Petersburg" },
            new TimeZoneFields { Id = "Africa/Nairobi", Text = "(UTC+03:00) Nairobi" },
            new TimeZoneFields { Id = "Europe/Volgograd", Text = "(UTC+03:00) Volgograd" },
            new TimeZoneFields { Id = "Asia/Tehran", Text = "(UTC+03:30) Tehran" },
            new TimeZoneFields { Id = "Asia/Dubai", Text = "(UTC+04:00) Abu Dhabi, Muscat" },
            new TimeZoneFields { Id = "Europe/Astrakhan", Text = "(UTC+04:00) Astrakhan, Ulyanovsk" },
            new TimeZoneFields { Id = "Asia/Baku", Text = "(UTC+04:00) Baku" },
            new TimeZoneFields { Id = "Europe/Samara", Text = "(UTC+04:00) Izhevsk, Samara" },
            new TimeZoneFields { Id = "Indian/Mauritius", Text = "(UTC+04:00) Port Louis" },
            new TimeZoneFields { Id = "Europe/Saratov", Text = "(UTC+04:00) Saratov" },
            new TimeZoneFields { Id = "Asia/Tbilisi", Text = "(UTC+04:00) Tbilisi" },
            new TimeZoneFields { Id = "Asia/Yerevan", Text = "(UTC+04:00) Yerevan" },
            new TimeZoneFields { Id = "Asia/Kabul", Text = "(UTC+04:30) Kabul" },
            new TimeZoneFields { Id = "Asia/Tashkent", Text = "(UTC+05:00) Ashgabat, Tashkent" },
            new TimeZoneFields { Id = "Asia/Yekaterinburg", Text = "(UTC+05:00) Ekaterinburg" },
            new TimeZoneFields { Id = "Asia/Karachi", Text = "(UTC+05:00) Islamabad, Karachi" },
            new TimeZoneFields { Id = "Asia/Qyzylorda", Text = "(UTC+05:00) Qyzylorda" },
            new TimeZoneFields { Id = "Asia/Kolkata", Text = "(UTC+05:30) Chennai, Kolkata, Mumbai, New Delhi" },
            new TimeZoneFields { Id = "Asia/Colombo", Text = "(UTC+05:30) Sri Jayawardenepura" },
            new TimeZoneFields { Id = "Asia/Kathmandu", Text = "(UTC+05:45) Kathmandu" },
            new TimeZoneFields { Id = "Asia/Almaty", Text = "(UTC+06:00) Astana" },
            new TimeZoneFields { Id = "Asia/Dhaka", Text = "(UTC+06:00) Dhaka" },
            new TimeZoneFields { Id = "Asia/Omsk", Text = "(UTC+06:00) Omsk" },
            new TimeZoneFields { Id = "Asia/Yangon", Text = "(UTC+06:30) Yangon (Rangoon)" },
            new TimeZoneFields { Id = "Asia/Bangkok", Text = "(UTC+07:00) Bangkok, Hanoi, Jakarta" },
            new TimeZoneFields { Id = "Asia/Barnaul", Text = "(UTC+07:00) Barnaul, Gorno-Altaysk" },
            new TimeZoneFields { Id = "Asia/Hovd", Text = "(UTC+07:00) Hovd" },
            new TimeZoneFields { Id = "Asia/Krasnoyarsk", Text = "(UTC+07:00) Krasnoyarsk" },
            new TimeZoneFields { Id = "Asia/Novosibirsk", Text = "(UTC+07:00) Novosibirsk" },
            new TimeZoneFields { Id = "Asia/Tomsk", Text = "(UTC+07:00) Tomsk" },
            new TimeZoneFields { Id = "Asia/Shanghai", Text = "(UTC+08:00) Beijing, Chongqing, Hong Kong, Urumqi" },
            new TimeZoneFields { Id = "Asia/Irkutsk", Text = "(UTC+08:00) Irkutsk" },
            new TimeZoneFields { Id = "Asia/Singapore", Text = "(UTC+08:00) Kuala Lumpur, Singapore" },
            new TimeZoneFields { Id = "Australia/Perth", Text = "(UTC+08:00) Perth" },
            new TimeZoneFields { Id = "Asia/Taipei", Text = "(UTC+08:00) Taipei" },
            new TimeZoneFields { Id = "Asia/Ulaanbaatar", Text = "(UTC+08:00) Ulaanbaatar" },
            new TimeZoneFields { Id = "Australia/Eucla", Text = "(UTC+08:45) Eucla" },
            new TimeZoneFields { Id = "Asia/Chita", Text = "(UTC+09:00) Chita" },
            new TimeZoneFields { Id = "Asia/Tokyo", Text = "(UTC+09:00) Osaka, Sapporo, Tokyo" },
            new TimeZoneFields { Id = "Asia/Pyongyang", Text = "(UTC+09:00) Pyongyang" },
            new TimeZoneFields { Id = "Asia/Seoul", Text = "(UTC+09:00) Seoul" },
            new TimeZoneFields { Id = "Asia/Yakutsk", Text = "(UTC+09:00) Yakutsk" },
            new TimeZoneFields { Id = "Australia/Adelaide", Text = "(UTC+09:30) Adelaide" },
            new TimeZoneFields { Id = "Australia/Darwin", Text = "(UTC+09:30) Darwin" },
            new TimeZoneFields { Id = "Australia/Brisbane", Text = "(UTC+10:00) Brisbane" },
            new TimeZoneFields { Id = "Australia/Sydney", Text = "(UTC+10:00) Canberra, Melbourne, Sydney" },
            new TimeZoneFields { Id = "Pacific/Port_Moresby", Text = "(UTC+10:00) Guam, Port Moresby" },
            new TimeZoneFields { Id = "Australia/Hobart", Text = "(UTC+10:00) Hobart" },
            new TimeZoneFields { Id = "Asia/Vladivostok", Text = "(UTC+10:00) Vladivostok" },
            new TimeZoneFields { Id = "Australia/Lord_Howe", Text = "(UTC+10:30) Lord Howe Island" },
            new TimeZoneFields { Id = "Pacific/Bougainville", Text = "(UTC+11:00) Bougainville Island" },
            new TimeZoneFields { Id = "Asia/Srednekolymsk", Text = "(UTC+11:00) Chokurdakh" },
            new TimeZoneFields { Id = "Asia/Magadan", Text = "(UTC+11:00) Magadan" },
            new TimeZoneFields { Id = "Pacific/Norfolk", Text = "(UTC+11:00) Norfolk Island" },
            new TimeZoneFields { Id = "Asia/Sakhalin", Text = "(UTC+11:00) Sakhalin" },
            new TimeZoneFields { Id = "Pacific/Guadalcanal", Text = "(UTC+11:00) Solomon Is., New Caledonia" },
            new TimeZoneFields { Id = "Asia/Kamchatka", Text = "(UTC+12:00) Anadyr, Petropavlovsk-Kamchatsky" },
            new TimeZoneFields { Id = "Pacific/Auckland", Text = "(UTC+12:00) Auckland, Wellington" },
            new TimeZoneFields { Id = "Etc/GMT-12", Text = "(UTC+12:00) Coordinated Universal Time+12" },
            new TimeZoneFields { Id = "Pacific/Fiji", Text = "(UTC+12:00) Fiji" },
            new TimeZoneFields { Id = "Pacific/Chatham", Text = "(UTC+12:45) Chatham Islands" },
            new TimeZoneFields { Id = "Etc/GMT-13", Text = "(UTC+13:00) Coordinated Universal Time+13" },
            new TimeZoneFields { Id = "Pacific/Tongatapu", Text = "(UTC+13:00) Nuku'alofa" },
            new TimeZoneFields { Id = "Pacific/Apia", Text = "(UTC+13:00) Samoa" },
            new TimeZoneFields { Id = "Pacific/Kiritimati", Text = "(UTC+14:00) Kiritimati Island" }
        };        

        /// <summary>
        /// Handles the toolbar button click to navigate the Gantt chart timeline.
        /// </summary>
        public async Task ButtonClickHandler(string timeSpan)
        {
            if (timeSpan == "PreviousTimeSpan")
            {
                await JsInterop.InvokeVoidAsync("removeFocus", "previous-btn");
                GanttInstance?.PreviousTimeSpan();
            }
            else if (timeSpan == "NextTimeSpan")
            {
                await JsInterop.InvokeVoidAsync("removeFocus", "next-btn");
                GanttInstance?.NextTimeSpan();
            }
        }

        /// <summary>
        /// Handles timezone dropdown value change.
        /// </summary>
        public async Task OnTimeZoneChanged(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, TimeZoneFields> args)
        {
            if (!string.IsNullOrEmpty(args.Value))
            {
                selectedTimeZone = args.Value;
                TimeZone = args.Value;
            }
            await Task.CompletedTask;
        }

        /// <summary>
        /// Handles timeline mode dropdown value change.
        /// </summary>
        public async Task OnTimeLineModeChanged(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, string> args)
        {
            if (args.Value == "Day")
            {
                TimelineViewMode = TimelineViewMode.Day;
                TopFormat = "MMM dd, yyyy";
                BottomFormat = "hh tt";
            }
            else if (args.Value == "Week")
            {
                TimelineViewMode = TimelineViewMode.Week;
                TopFormat = "ddd MMM dd";
                BottomFormat = "ddd";
            }
            else if (args.Value == "Month")
            {
                TimelineViewMode = TimelineViewMode.Month;
                TopFormat = "MMM dd, yyyy";
                BottomFormat = "MMM dd";
            }
            await Task.CompletedTask;
        }
    }
}
