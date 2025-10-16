#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

namespace blazor_gantt_airline_data
{
    public class AirlineTrackerData
    {
        internal class AirlineInfoModel
        {
            public int Id { get; set; }
            public int? ParentId { get; set; }
            public int Progress { get; set; }
            public string FlightId { get; set; } = string.Empty;
            public string Airline { get; set; } = string.Empty;
            public DateOnly? FlightDate { get; set; }
            public DateTime? Departure { get; set; }
            public DateTime? Arrival { get; set; }
            public DateTime? LandingTime { get; set; }
            public string? Duration { get; set; }
            public string Status { get; set; } = string.Empty;
            public string Destination { get; set; } = string.Empty;
            public string Origin { get; set; } = string.Empty;
            public string Aircraft { get; set; } = string.Empty;
            public string DepartureGate { get; set; } = string.Empty;
            public string ArrivalGate { get; set; } = string.Empty;
        }

        internal static List<AirlineInfoModel> FlightProcessCollection => new List<AirlineInfoModel>()
        {
            new AirlineInfoModel { Id = 1, Airline = "Delta Airlines" },
            new AirlineInfoModel { Id = 2, ParentId = 1, FlightId = "DL100", Airline = "Delta Airlines", Departure = new DateTime(2024, 06, 10, 02, 00, 00), Arrival = new DateTime(2024, 06, 10, 05, 00, 00), Destination = "ATL", Origin = "JFK", Aircraft = "Boeing 737", DepartureGate = "A1", ArrivalGate = "B2", Status = "LANDED", Progress = 100, LandingTime = new DateTime(2024, 06, 10, 05, 05, 00) },
            new AirlineInfoModel { Id = 3, ParentId = 1, FlightId = "DL101", Airline = "Delta Airlines", Departure = new DateTime(2024, 06, 10, 09, 00, 00), Arrival = new DateTime(2024, 06, 10, 11, 00, 00), Destination = "JFK", Origin = "ATL", Aircraft = "Boeing 737", DepartureGate = "A2", ArrivalGate = "B3", Status = "SCHEDULED", Progress = 0 },
            new AirlineInfoModel { Id = 4, ParentId = 1, FlightId = "DL102", Airline = "Delta Airlines", Departure = new DateTime(2024, 06, 10, 05, 00, 00), Arrival = new DateTime(2024, 06, 10, 08, 00, 00), Destination = "MIA", Origin = "JFK", Aircraft = "Boeing 737", DepartureGate = "A3", ArrivalGate = "B4", Status = "CANCELLED", Progress = 0 },
            new AirlineInfoModel { Id = 5, Airline = "United Airlines" },
            new AirlineInfoModel { Id = 6, ParentId = 5, FlightId = "UA100", Airline = "United Airlines", Departure = new DateTime(2024, 06, 10, 08, 00, 00), Arrival = new DateTime(2024, 06, 10, 11, 00, 00), Destination = "ORD", Origin = "JFK", Aircraft = "Boeing 777", DepartureGate = "C1", ArrivalGate = "D2", Status = "SCHEDULED", Progress = 0 },
            new AirlineInfoModel { Id = 7, ParentId = 5, FlightId = "UA101", Airline = "United Airlines", Departure = new DateTime(2024, 06, 10, 04, 00, 00), Arrival = new DateTime(2024, 06, 10, 07, 00, 00), Destination = "JFK", Origin = "ORD", Aircraft = "Boeing 777", DepartureGate = "C2", ArrivalGate = "D3", Status = "DELAYED", Progress = 0, LandingTime = new DateTime(2024, 06, 10, 07, 10, 00) }, // Delayed by 10 minutes
            new AirlineInfoModel { Id = 8, ParentId = 5, FlightId = "UA102", Airline = "United Airlines", Departure = new DateTime(2024, 06, 10, 20, 00, 00), Arrival = new DateTime(2024, 06, 10, 23, 00, 00), Destination = "LAX", Origin = "JFK", Aircraft = "Boeing 777", DepartureGate = "C3", ArrivalGate = "D4", Status = "ON TIME", Progress = 100 }, // Arrived 10 minutes earlier
            new AirlineInfoModel { Id = 9, Airline = "American Airlines" },
            new AirlineInfoModel { Id = 10, ParentId = 9, FlightId = "AA100", Airline = "American Airlines", Departure = new DateTime(2024, 06, 10, 09, 00, 00), Arrival = new DateTime(2024, 06, 10, 12, 00, 00), Destination = "DFW", Origin = "JFK", Aircraft = "Airbus A320", DepartureGate = "D1", ArrivalGate = "E2", Status = "SCHEDULED", Progress = 0 },
            new AirlineInfoModel { Id = 11, ParentId = 9, FlightId = "AA101", Airline = "American Airlines", Departure = new DateTime(2024, 06, 10, 14, 00, 00), Arrival = new DateTime(2024, 06, 10, 17, 00, 00), Destination = "JFK", Origin = "DFW", Aircraft = "Airbus A320", DepartureGate = "D2", ArrivalGate = "E3", Status = "DELAYED", Progress = 0, LandingTime = new DateTime(2024, 06, 10, 17, 10, 00) }, // Delayed by 10 minutes
            new AirlineInfoModel { Id = 12, ParentId = 9, FlightId = "AA102", Airline = "American Airlines", Departure = new DateTime(2024, 06, 10, 16, 00, 00), Arrival = new DateTime(2024, 06, 10, 19, 00, 00), Destination = "ORD", Origin = "JFK", Aircraft = "Airbus A320", DepartureGate = "D3", ArrivalGate = "E4", Status = "ON TIME", Progress = 100 }, // Arrived 10 minutes earlier
            new AirlineInfoModel { Id = 13, Airline = "Southwest Airlines" },
            new AirlineInfoModel { Id = 14, ParentId = 13, FlightId = "SW100", Airline = "Southwest Airlines", Departure = new DateTime(2024, 06, 10, 10, 00, 00), Arrival = new DateTime(2024, 06, 10, 13, 00, 00), Destination = "LAS", Origin = "JFK", Aircraft = "Boeing 737", DepartureGate = "E1", ArrivalGate = "F2", Status = "SCHEDULED", Progress = 0 },
            new AirlineInfoModel { Id = 15, ParentId = 13, FlightId = "SW101", Airline = "Southwest Airlines", Departure = new DateTime(2024, 06, 10, 15, 00, 00), Arrival = new DateTime(2024, 06, 10, 18, 00, 00), Destination = "JFK", Origin = "LAS", Aircraft = "Boeing 737", DepartureGate = "E2", ArrivalGate = "F3", Status = "CANCELLED", Progress = 0 },
            new AirlineInfoModel { Id = 16, ParentId = 13, FlightId = "SW102", Airline = "Southwest Airlines", Departure = new DateTime(2024, 06, 10, 20, 00, 00), Arrival = new DateTime(2024, 06, 10, 23, 00, 00), Destination = "BWI", Origin = "JFK", Aircraft = "Boeing 737", DepartureGate = "E3", ArrivalGate = "F4", Status = "ON TIME", Progress = 100 }, // Arrived 10 minutes earlier
            new AirlineInfoModel { Id = 17, Airline = "JetBlue Airways" },
            new AirlineInfoModel { Id = 18, ParentId = 17, FlightId = "JB100", Airline = "JetBlue Airways", Departure = new DateTime(2024, 06, 10, 11, 00, 00), Arrival = new DateTime(2024, 06, 10, 14, 00, 00), Destination = "MCO", Origin = "JFK", Aircraft = "Airbus A321", DepartureGate = "F1", ArrivalGate = "G2", Status = "SCHEDULED", Progress = 0 },
            new AirlineInfoModel { Id = 19, ParentId = 17, FlightId = "JB101", Airline = "JetBlue Airways", Departure = new DateTime(2024, 06, 10, 12, 00, 00), Arrival = new DateTime(2024, 06, 10, 15, 00, 00), Destination = "JFK", Origin = "MCO", Aircraft = "Airbus A321", DepartureGate = "F2", ArrivalGate = "G3", Status = "DELAYED", Progress = 0, LandingTime = new DateTime(2024, 06, 10, 15, 10, 00) }, // Delayed by 10 minutes
            new AirlineInfoModel { Id = 20, ParentId = 17, FlightId = "JB102", Airline = "JetBlue Airways", Departure = new DateTime(2024, 06, 10, 16, 00, 00), Arrival = new DateTime(2024, 06, 10, 19, 00, 00), Destination = "JFK", Origin = "MCO", Aircraft = "Airbus A321", DepartureGate = "F3", ArrivalGate = "G4", Status = "ON TIME", Progress = 100 }, // Arrived 10 minutes earlier
            new AirlineInfoModel { Id = 21, Airline = "Alaska Airlines" },
            new AirlineInfoModel { Id = 22, ParentId = 21, FlightId = "AS100", Airline = "Alaska Airlines", Departure = new DateTime(2024, 06, 10, 09, 00, 00), Arrival = new DateTime(2024, 06, 10, 12, 00, 00), Destination = "SFO", Origin = "SEA", Aircraft = "Boeing 737", DepartureGate = "G1", ArrivalGate = "H2", Status = "SCHEDULED", Progress = 0 },
            new AirlineInfoModel { Id = 23, ParentId = 21, FlightId = "AS101", Airline = "Alaska Airlines", Departure = new DateTime(2024, 06, 10, 11, 00, 00), Arrival = new DateTime(2024, 06, 10, 14, 00, 00), Destination = "JFK", Origin = "SEA", Aircraft = "Boeing 737", DepartureGate = "G2", ArrivalGate = "H3", Status = "CANCELLED", Progress = 0 },
            new AirlineInfoModel { Id = 24, ParentId = 21, FlightId = "AS102", Airline = "Alaska Airlines", Departure = new DateTime(2024, 06, 10, 19, 00, 00), Arrival = new DateTime(2024, 06, 10, 22, 00, 00), Destination = "SFO", Origin = "JFK", Aircraft = "Boeing 737", DepartureGate = "G3", ArrivalGate = "H4", Status = "ON TIME", Progress = 100 }, // Arrived 10 minutes earlier
            new AirlineInfoModel { Id = 25, Airline = "British Airways" },
            new AirlineInfoModel { Id = 26, ParentId = 25, FlightId = "BA100", Airline = "British Airways", Departure = new DateTime(2024, 06, 10, 07, 00, 00), Arrival = new DateTime(2024, 06, 10, 14, 00, 00), Destination = "LHR", Origin = "JFK", Aircraft = "Boeing 787", DepartureGate = "H1", ArrivalGate = "I2", Status = "SCHEDULED", Progress = 0 },
            new AirlineInfoModel { Id = 27, ParentId = 25, FlightId = "BA101", Airline = "British Airways", Departure = new DateTime(2024, 06, 10, 16, 00, 00), Arrival = new DateTime(2024, 06, 10, 23, 00, 00), Destination = "JFK", Origin = "LHR", Aircraft = "Boeing 787", DepartureGate = "H2", ArrivalGate = "I3", Status = "ON TIME", Progress = 100 }, // Arrived 10 minutes earlier
            new AirlineInfoModel { Id = 28, ParentId = 25, FlightId = "BA102", Airline = "British Airways", Departure = new DateTime(2024, 06, 10, 20, 00, 00), Arrival = new DateTime(2024, 06, 11, 05, 00, 00), Destination = "JFK", Origin = "LHR", Aircraft = "Boeing 787", DepartureGate = "H3", ArrivalGate = "I4", Status = "ON TIME", Progress = 100 }, // Arrived 10 minutes earlier
            new AirlineInfoModel { Id = 29, Airline = "Lufthansa" },
            new AirlineInfoModel { Id = 30, ParentId = 29, FlightId = "LH100", Airline = "Lufthansa", Departure = new DateTime(2024, 06, 10, 10, 00, 00), Arrival = new DateTime(2024, 06, 10, 17, 00, 00), Destination = "FRA", Origin = "JFK", Aircraft = "Airbus A340", DepartureGate = "I1", ArrivalGate = "J2", Status = "SCHEDULED", Progress = 0 },
            new AirlineInfoModel { Id = 31, ParentId = 29, FlightId = "LH101", Airline = "Lufthansa", Departure = new DateTime(2024, 06, 10, 12, 00, 00), Arrival = new DateTime(2024, 06, 10, 19, 00, 00), Destination = "JFK", Origin = "FRA", Aircraft = "Airbus A340", DepartureGate = "I2", ArrivalGate = "J3", Status = "ON TIME", Progress = 100 }, // Arrived 5 minutes earlier
            new AirlineInfoModel { Id = 32, ParentId = 29, FlightId = "LH102", Airline = "Lufthansa", Departure = new DateTime(2024, 06, 10, 15, 00, 00), Arrival = new DateTime(2024, 06, 10, 22, 00, 00), Destination = "JFK", Origin = "FRA", Aircraft = "Airbus A340", DepartureGate = "I3", ArrivalGate = "J4", Status = "ON TIME", Progress = 100 }, // Arrived 10 minutes earlier
            new AirlineInfoModel { Id = 33, Airline = "Qatar Airways" },
            new AirlineInfoModel { Id = 34, ParentId = 33, FlightId = "QR100", Airline = "Qatar Airways", Departure = new DateTime(2024, 06, 10, 09, 00, 00), Arrival = new DateTime(2024, 06, 10, 16, 00, 00), Destination = "JFK", Origin = "DOH", Aircraft = "Airbus A350", DepartureGate = "V1", ArrivalGate = "25", Status = "ON TIME", Progress = 100 }, // Arrived 5 minutes earlier
            new AirlineInfoModel { Id = 35, ParentId = 33, FlightId = "QR101", Airline = "Qatar Airways", Departure = new DateTime(2024, 06, 10, 12, 00, 00), Arrival = new DateTime(2024, 06, 10, 14, 30, 00), Destination = "JFK", Origin = "DOH", Aircraft = "Airbus A350", DepartureGate = "V1", ArrivalGate = "26", LandingTime = new DateTime(2024, 06, 10, 14, 25, 00), Progress = 100, Status = "LANDED" }, // Arrived 5 minutes earlier
            new AirlineInfoModel { Id = 36, ParentId = 33, FlightId = "QR102", Airline = "Qatar Airways", Departure = new DateTime(2024, 06, 10, 15, 00, 00), Arrival = new DateTime(2024, 06, 10, 17, 30, 00), Destination = "JFK", Origin = "DOH", Aircraft = "Airbus A350", DepartureGate = "W1", ArrivalGate = "27", LandingTime = new DateTime(2024, 06, 10, 17, 35, 00), Progress = 100, Status = "LANDED" }, // Arrived on time
            new AirlineInfoModel { Id = 37, ParentId = 33, FlightId = "QR103", Airline = "Qatar Airways", Departure = new DateTime(2024, 06, 10, 18, 00, 00), Arrival = new DateTime(2024, 06, 10, 20, 30, 00), Destination = "DOH", Origin = "JFK", Aircraft = "Airbus A350", DepartureGate = "W2", ArrivalGate = "28", LandingTime = new DateTime(2024, 06, 10, 20, 25, 00), Progress = 100, Status = "LANDED" } // Arrived 5 minutes earlier
        }; 
    }
}
