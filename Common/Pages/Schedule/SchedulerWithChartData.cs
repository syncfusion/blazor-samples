using System;using System.Collections.Generic;
namespace SchedulerWithChartApp.Data
{
    public class TruckDriver
    {
        public int Id { get; set; }
        public string Driver { get; set; } = string.Empty;
        public string Color { get; set; } = "#000000";
        public string Truck { get; set; } = string.Empty;
        public string Capacity { get; set; } = string.Empty;
    }
    
public class AnalyticsMode
    {
        public string Text { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }


    public class TruckEvent
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public string? Subject { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Nullable<bool> IsAllDay { get; set; }
        public string? RecurrenceRule { get; set; }
        public Nullable<int> RecurrenceID { get; set; }
        public string? RecurrenceException { get; set; }
        public string? StartTimezone { get; set; }
        public string? EndTimezone { get; set; }

    }

    public class ChartDataPoint
    {
        public string Driver { get; set; } = string.Empty;
        public double Value { get; set; }
    }

    public static class SchedulerWithChartData
    {
        public static IReadOnlyCollection<TruckDriver> GetDriversMaster()
        {
            return new List<TruckDriver>
            {
                new TruckDriver { Id = 1, Driver = "Ben Smith", Color = "#ea7a57", Truck = "Volvo FH16", Capacity = "325 t" },
                new TruckDriver { Id = 2, Driver = "Sarah Johnson", Color = "#7fa900", Truck = "Scania R730", Capacity = "310 t" },
                new TruckDriver { Id = 3, Driver = "Mike Chen", Color = "#5978ee", Truck = "Mercedes Actros", Capacity = "290 t" },
                new TruckDriver { Id = 4, Driver = "Emma Davis", Color = "#fec200", Truck = "MAN TGX", Capacity = "280 t" },
                new TruckDriver { Id = 5, Driver = "Carlos Rodriguez", Color = "#df5286", Truck = "DAF XF", Capacity = "300 t" },
                new TruckDriver { Id = 6, Driver = "Olivia Wilson", Color = "#00bdae", Truck = "Kenworth T680", Capacity = "315 t" },
                new TruckDriver { Id = 7, Driver = "James Taylor", Color = "#865fcf", Truck = "Peterbilt 579", Capacity = "305 t" },
                new TruckDriver { Id = 8, Driver = "Sophia Martinez", Color = "#1aaa55", Truck = "Freightliner Cascadia", Capacity = "295 t" },
                new TruckDriver { Id = 9, Driver = "Daniel Lee", Color = "#df5286", Truck = "Mack Anthem", Capacity = "285 t" },
                new TruckDriver { Id = 10, Driver = "Ava Thompson", Color = "#710193", Truck = "International LT", Capacity = "275 t" }
            };
        }

        public static IReadOnlyCollection<TruckEvent> GetTruckData()
        {
            return new List<TruckEvent>
            {
                new TruckEvent
                {
                    Id = 1,
                    DriverId = 1,
                    Subject = "Long haul trip",
                    StartTime = new DateTime(2026, 1, 14, 2, 30, 0),
                    EndTime = new DateTime(2026, 1, 14, 7, 30, 0)
                },
                new TruckEvent
                {
                    Id = 2,
                    DriverId = 2,
                    Subject = "Delivery to New York",
                    StartTime = new DateTime(2026, 1, 13, 18, 30, 0),
                    EndTime = new DateTime(2026, 1, 14, 6, 30, 0)
                },
                new TruckEvent
                {
                    Id = 3,
                    DriverId = 3,
                    Subject = "Cross-country route",
                    StartTime = new DateTime(2026, 1, 13, 12, 40, 0),
                    EndTime = new DateTime(2026, 1, 13, 16, 30, 0)
                },
                new TruckEvent
                {
                    Id = 4,
                    DriverId = 4,
                    Subject = "Refrigerated goods",
                    StartTime = new DateTime(2026, 1, 13, 9, 30, 0),
                    EndTime = new DateTime(2026, 1, 13, 19, 30, 0)
                },
                new TruckEvent
                {
                    Id = 6,
                    DriverId = 5,
                    Subject = "Furniture Transport",
                    StartTime = new DateTime(2026, 1, 12, 20, 30, 0),
                    EndTime = new DateTime(2026, 1, 13, 4, 30, 0)
                },
                new TruckEvent
                {
                    Id = 7,
                    DriverId = 6,
                    Subject = "Furniture",
                    StartTime = new DateTime(2026, 1, 13, 13, 30, 0),
                    EndTime = new DateTime(2026, 1, 13, 15, 30, 0)
                },
                new TruckEvent
                {
                    Id = 8,
                    DriverId = 7,
                    Subject = "Food products",
                    StartTime = new DateTime(2026, 1, 13, 12, 30, 0),
                    EndTime = new DateTime(2026, 1, 13, 21, 30, 0)
                },
                new TruckEvent
                {
                    Id = 9,
                    DriverId = 8,
                    Subject = "Construction materials",
                    StartTime = new DateTime(2026, 1, 15, 16, 30, 0),
                    EndTime = new DateTime(2026, 1, 16, 1, 30, 0)
                },
                new TruckEvent
                {
                    Id = 10,
                    DriverId = 9,
                    Subject = "Medical supplies",
                    StartTime = new DateTime(2026, 1, 13, 13, 30, 0),
                    EndTime = new DateTime(2026, 1, 13, 19, 30, 0)
                },
                new TruckEvent
                {
                    Id = 11,
                    DriverId = 2,
                    Subject = "Delivery to Chicago",
                    StartTime = new DateTime(2026, 1, 16, 13, 30, 0),
                    EndTime = new DateTime(2026, 1, 16, 19, 30, 0)
                },
                new TruckEvent
                {
                    Id = 12,
                    DriverId = 4,
                    Subject = "Delivery to Miami",
                    StartTime = new DateTime(2026, 1, 15, 9, 30, 0),
                    EndTime = new DateTime(2026, 1, 15, 19, 30, 0)
                },
                new TruckEvent
                {
                    Id = 13,
                    DriverId = 4,
                    Subject = "Delivery to Indianapolis",
                    StartTime = new DateTime(2026, 1, 17, 9, 30, 0),
                    EndTime = new DateTime(2026, 1, 17, 19, 30, 0)
                },
                new TruckEvent
                {
                    Id = 14,
                    DriverId = 6,
                    Subject = "Delivery to Dallas",
                    StartTime = new DateTime(2026, 1, 15, 13, 30, 0),
                    EndTime = new DateTime(2026, 1, 15, 15, 30, 0)
                },
                new TruckEvent
                {
                    Id = 15,
                    DriverId = 8,
                    Subject = "Delivery to Seattle",
                    StartTime = new DateTime(2026, 1, 13, 16, 30, 0),
                    EndTime = new DateTime(2026, 1, 14, 1, 30, 0)
                },
                new TruckEvent
                {
                    Id = 16,
                    DriverId = 8,
                    Subject = "Delivery to San Francisco",
                    StartTime = new DateTime(2026, 1, 18, 16, 30, 0),
                    EndTime = new DateTime(2026, 1, 19, 1, 30, 0)
                },
            };
        }
    }
}