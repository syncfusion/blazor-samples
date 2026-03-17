#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace blazor_flightbooking
{
    /// <summary>
    /// Represents the cabin class tier for a flight booking.
    /// </summary>
    public enum ClassOfTravel
    {
        /// <summary>
        /// Economy class with standard seating and amenities.
        /// </summary>
        Economy,

        /// <summary>
        /// Premium economy with enhanced comfort and services.
        /// </summary>
        [Display(Name = "Premium Economy")]
        PremiumEconomy,

        /// <summary>
        /// Business class with premium seating and catering.
        /// </summary>
        Business,

        /// <summary>
        /// First class with luxury seating and exclusive services.
        /// </summary>
        FirstClass
    }

    /// <summary>
    /// Represents the lifecycle state of a flight booking.
    /// </summary>
    public enum BookingStatus
    {
        /// <summary>
        /// Booking is confirmed and reservation is valid.
        /// </summary>
        Confirmed,

        /// <summary>
        /// Booking is pending confirmation or awaiting payment.
        /// </summary>
        Pending,

        /// <summary>
        /// Passenger has checked in for the flight.
        /// </summary>
        CheckedIn,

        /// <summary>
        /// Booking was cancelled by passenger or airline.
        /// </summary>
        Cancelled,

        /// <summary>
        /// Flight has been completed and passenger has arrived.
        /// </summary>
        Completed,

        /// <summary>
        /// Passenger did not show up for the flight.
        /// </summary>
        NoShow
    }

    /// <summary>
    /// Represents the payment method used for the booking.
    /// </summary>
    public enum PaymentMethodType
    {
        /// <summary>
        /// Payment made using credit card.
        /// </summary>
        [Display(Name = "Credit Card")]
        CreditCard,

        /// <summary>
        /// Payment made using debit card.
        /// </summary>
        [Display(Name = "Debit Card")]
        DebitCard,

        /// <summary>
        /// Payment via net banking facility
        /// </summary>
        NetBanking,

        /// <summary>
        /// Payment made using digital wallet.
        /// </summary>
        Wallet,

        /// <summary>
        /// Payment made using UPI (Unified Payments Interface)
        /// </summary>
        UPI
    }

    /// <summary>
    /// Represents the meal preference for a flight booking.
    /// </summary>
    public enum MealPreferenceType
    {
        /// <summary>
        /// Standard non-vegetarian meal.
        /// </summary>
        NonVegetarian,

        /// <summary>
        /// Vegetarian meal option.
        /// </summary>
        Vegetarian,

        /// <summary>
        /// Vegan meal option.
        /// </summary>
        Vegan,

        /// <summary>
        /// Gluten-free meal option.
        /// </summary>
        GlutenFree,

        /// <summary>
        /// Kosher meal option.
        /// </summary>
        Kosher,

        /// <summary>
        /// Halal meal option.
        /// </summary>
        Halal
    }

    /// <summary>
    /// Represents a flight booking containing passenger, flight, pricing, and booking details.
    /// </summary>
    public sealed class FlightBookingRecord
    {
        /// <summary>
        /// Unique booking identifier for the reservation.
        /// </summary>
        public string BookingId { get; set; } = string.Empty;

        /// <summary>
        /// Full name of the passenger as per travel document.
        /// </summary>
        public string PassengerName { get; set; } = string.Empty;

        /// <summary>
        /// Email address associated with the booking.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Flight number identifier.
        /// </summary>
        public string FlightNumber { get; set; } = string.Empty;

        /// <summary>
        /// International airline code (e.g., AA, BA, LH).
        /// </summary>
        public string AirlineCode { get; set; } = string.Empty;

        /// <summary>
        /// IATA code of the departure airport.
        /// </summary>
        public string DepartureAirport { get; set; } = string.Empty;

        /// <summary>
        /// IATA code of the arrival airport.
        /// </summary>
        public string ArrivalAirport { get; set; } = string.Empty;

        /// <summary>
        /// Scheduled departure date and time.
        /// </summary>
        public DateTime DepartureDate { get; set; }

        /// <summary>
        /// Scheduled arrival date and time at destination.
        /// </summary>
        public DateTime ArrivalDate { get; set; }

        /// <summary>
        /// Assigned seat number (e.g., 12A, 34F).
        /// </summary>
        public string SeatNumber { get; set; } = string.Empty;

        /// <summary>
        /// Class of travel for this booking.
        /// </summary>
        public ClassOfTravel ClassOfTravel { get; set; }

        /// <summary>
        /// Date and time when the booking was created.
        /// </summary>
        public DateTime BookingDate { get; set; }

        /// <summary>
        /// Base ticket price before taxes.
        /// </summary>
        public decimal BookingAmount { get; set; }

        /// <summary>
        /// Tax amount calculated on the booking amount.
        /// </summary>
        public decimal TaxAmount { get; set; }

        /// <summary>
        /// Total fare including booking amount and taxes.
        /// </summary>
        public decimal TotalFare { get; set; }

        /// <summary>
        /// Current status of the booking.
        /// </summary>
        public BookingStatus Status { get; set; }

        /// <summary>
        /// Payment method used for the booking.
        /// </summary>
        public PaymentMethodType PaymentMethod { get; set; }

        /// <summary>
        /// Passenger's meal preference for the flight.
        /// </summary>
        public MealPreferenceType MealPreference { get; set; }

        /// <summary>
        /// Number of checked baggage allowance for this booking.
        /// </summary>
        public int BaggageAllowance { get; set; }

        /// <summary>
        /// Indicates whether the passenger has checked in for the flight.
        /// </summary>
        public bool CheckedIn { get; set; }
    }

    /// <summary>
    /// Generates a collection of flight booking records with realistic, deterministic values for demonstration.
    /// </summary>
    public static class FlightBookingData
    {
        /// <summary>
        /// Returns a fixed set of 10,000 flight booking records with realistic data patterns.
        /// </summary>
        public static List<FlightBookingRecord> GetAllRecords()
        {
            // Generates a deterministic booking ID without repeating patterns.
            static string GenerateBookingId(int index)
            {
                const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ0123456789";
                int seed = index + 1;

                char[] tail = new char[5];
                int v = seed * 7919 + 104729;

                for (int i = 0; i < tail.Length; i++)
                {
                    v = (v * 1315423911) ^ (v >> 5);
                    int pos = Math.Abs(v % chars.Length);
                    tail[i] = chars[pos];
                }

                return "BK-2026-" + new string(tail);
            }

            // Passenger names list.
            string[] passengerNames =
            {
                "Aaron Blake", "Abigail Watts", "Adrian Cole", "Aiden Brooks", "Alex Turner", "Alice Cruz", "Allison Grant",
                "Alyssa Hayes", "Amelia Perry", "Andrew Stone", "Anna Fisher", "Anthony Ward", "Ariana Ross", "Ashley Cooper",
                "Audrey Jenkins", "Austin Rivera", "Ava Barnes", "Benjamin Ford", "Caleb Myers", "Cameron Price", "Caroline Bell",
                "Carter Howard", "Charlotte Scott", "Chloe Adams", "Christian Flores", "Christopher West", "Claire Morgan",
                "Colin Bryant", "Daniel Reed", "David Powell", "Declan Griffin", "Dylan Hughes", "Eleanor Russell", "Elena Foster",
                "Eli Parker", "Elijah Sanders", "Elizabeth Diaz", "Ella Coleman", "Elliot Pierce", "Emma Long", "Ethan Simmons",
                "Evan Bennett", "Evelyn Stewart", "Gabriel Patterson", "Gavin Murray", "Grace Phillips", "Grant Young",
                "Hannah Cook", "Harper Mitchell", "Henry Bailey", "Hudson Gomez", "Hunter Sullivan", "Ian Ramirez", "Isaac Ward",
                "Isabelle Sharp", "Jack Matthews", "Jackson Perry", "Jacob Ortiz", "James Henderson", "Jason Newman", "Jasper Boyd",
                "Jayden Elliott", "Jeremiah Fox", "Jocelyn Hart", "John Bishop", "Jonathan Payne", "Jordan Walters", "Joseph Cross",
                "Joshua Gordon", "Julia Wallace", "Katherine Warren", "Kayla Rhodes", "Kenneth Holmes", "Landon Weaver",
                "Lauren Barton", "Leah Chapman", "Leo Barrett", "Liam Carter", "Lillian Stephens", "Logan Reed", "Lucas Scott",
                "Lucy Andrews", "Mackenzie Walsh", "Madison Pierce", "Maria Caldwell", "Mason White", "Matthew Curtis", "Mia Turner",
                "Michael Stone", "Michelle Lowe", "Nathan Kim", "Nolan Pratt", "Noah Mitchell", "Nora Fleming", "Oliver Briggs",
                "Olivia Larson", "Owen Jacobs", "Paige Lawson", "Parker Fleming", "Patrick Lowe", "Penelope Harper", "Peyton Rice",
                "Quinn Abbott", "Rachel Grant", "Reagan Bishop", "Rebecca Steele", "Richard Lowe", "Riley Shaw", "Robert Pierce",
                "Ruby Hayes", "Ryan Foster", "Samantha Ortiz", "Samuel Banks", "Sarah Kelley", "Savannah Horton", "Scarlett Ray",
                "Sofia Greene", "Sophia Brown", "Stella Walsh", "Steven Cross", "Taylor Beck", "Thomas Watts", "Tyler Boone",
                "Valerie Blake", "Victoria Paul", "Violet Hart", "William Pratt", "Wyatt Briggs", "Xavier Lawson", "Zachary Neal",
                "Zoe Sherman", "Abram Fox", "Ace Howard", "Adam Murray", "Aeden Wallace", "Aidan Mitchell", "Ainsley Bennett",
                "Aisha Patel", "Ajay Kumar", "Akhil Singh", "Alana Rogers", "Alba Martinez", "Alec Johnson", "Alexa Thompson",
                "Alexander White", "Alexis Green", "Alfonso Brown", "Alfredo Sanchez"
            };

            // Airline codes and corresponding information.
            string[] airlineCodes = { "AA", "BA", "LH", "QF", "SQ", "AK", "EK", "AF", "KL", "UA" };
            string[] airlines = { "American", "British", "Lufthansa", "Qantas", "Singapore", "Alaska", "Emirates", "Air France", "KLM", "United" };

            // Airport codes (IATA).
            string[] airports = { "New York (JFK)", "Los Angeles (LAX)", "London (LHR)", "Paris (CDG)", "Tokyo Narita (NRT)", "Singapore (SIN)", "Dubai (DXB)", "Tokyo Haneda (HND)", "Chicago O'Hare (ORD)", "Atlanta (ATL)", "Dallas/Fort Worth (DFW)", "Denver (DEN)", "San Francisco (SFO)", "Miami (MIA)", "Boston (BOS)" };

            // Email domains.
            string[] emailDomains = { "@example.com" };

            // Seat letters (A-F for 6-seat wide aircraft).
            char[] seatLetters = { 'A', 'B', 'C', 'D', 'E', 'F' };

            DateTime refDate = new DateTime(2026, 3, 2);
            var list = new List<FlightBookingRecord>(capacity: 10000);

            for (int i = 0; i < 10000; i++)
            {
                string bookingId = GenerateBookingId(i);

                // Deterministic selections.
                string passengerName = passengerNames[(i * 11) % passengerNames.Length];
                string airlineCode = airlineCodes[(i * 3) % airlineCodes.Length];
                string airline = airlines[(i * 3) % airlines.Length];
                string departureAirport = airports[(i * 7) % airports.Length];
                string arrivalAirport = airports[((i * 13) + 5) % airports.Length];

                // Ensure departure and arrival are different.
                while (arrivalAirport == departureAirport)
                {
                    arrivalAirport = airports[((i * 13) + 7) % airports.Length];
                }

                // Generate email from passenger name and domain.
                string emailPrefix = passengerName.Replace(" ", ".").ToLower();
                string email = emailPrefix + emailDomains[(i * 5) % emailDomains.Length];

                // Flight number format (airline code + 4-digit number).
                string flightNumber = airlineCode + (1000 + (i % 9000)).ToString();

                // Seat number (row 1-100 + letter A-F).
                int row = (i % 100) + 1;
                char seatLetter = seatLetters[(i * 2) % seatLetters.Length];
                string seatNumber = row.ToString() + seatLetter;

                // Departure date: 0-60 days from today.
                int departureOffsetDays = i % 61;
                DateTime departureDate = refDate.AddDays(departureOffsetDays);
                // Add random time to departure (0-23 hours).
                departureDate = departureDate.AddHours((i % 24));

                // Arrival date: 4-24 hours after departure (realistic flight duration).
                int flightDurationHours = 4 + (i % 21); // 4-24 hours
                DateTime arrivalDate = departureDate.AddHours(flightDurationHours);

                // Booking date: bookings are typically made 1–6 months before departure.
                // Enforce a lead time of 30–180 days (30 days = 1 month, 180 days = ~6 months).
                int leadDays = 30 + (i % 151); // 30..180 days
                DateTime bookingDate = departureDate.AddDays(-leadDays);

                // Status logic based on dates.
                BookingStatus status;
                bool checkedIn = false;

                if (arrivalDate < refDate)
                {
                    // Flight already completed (arrived in past).
                    status = BookingStatus.Completed;
                }
                else if (departureDate < refDate)
                {
                    // Flight was supposed to depart but hasn't arrived yet - unlikely but possible.
                    // Or it's a no-show if booked.
                    status = (i % 10 == 0) ? BookingStatus.NoShow : BookingStatus.Completed;
                }
                else if (departureDate <= refDate.AddHours(24))
                {
                    // Flight within next 24 hours - mark as checked in for some.
                    if ((i % 4) == 0)
                    {
                        status = BookingStatus.CheckedIn;
                        checkedIn = true;
                    }
                    else
                    {
                        status = BookingStatus.Confirmed;
                    }
                }
                else if (bookingDate > refDate)
                {
                    // Very recent booking (made in the future - shouldn't happen, mark as Pending).
                    status = BookingStatus.Pending;
                }
                else if ((i % 20) == 0)
                {
                    // Random cancellations.
                    status = BookingStatus.Cancelled;
                }
                else
                {
                    // Standard confirmed booking.
                    status = BookingStatus.Confirmed;
                }

                // Class of travel with realistic distribution.
                // Economy ~60%, Premium ~20%, Business ~15%, First ~5%.
                ClassOfTravel classOfTravel;
                int classSelector = i % 100;
                if (classSelector < 60)
                    classOfTravel = ClassOfTravel.Economy;
                else if (classSelector < 80)
                    classOfTravel = ClassOfTravel.PremiumEconomy;
                else if (classSelector < 95)
                    classOfTravel = ClassOfTravel.Business;
                else
                    classOfTravel = ClassOfTravel.FirstClass;

                // Baggage allowance based on class.
                int baggageAllowance = classOfTravel switch
                {
                    ClassOfTravel.Economy => 1,
                    ClassOfTravel.PremiumEconomy => 2,
                    ClassOfTravel.Business => 2,
                    ClassOfTravel.FirstClass => 3,
                    _ => 1
                };

                // Pricing logic based on class.
                decimal basePrice = classOfTravel switch
                {
                    ClassOfTravel.Economy => 200 + ((i % 401) * 1.0m),
                    ClassOfTravel.PremiumEconomy => 600 + ((i % 801) * 1.0m),
                    ClassOfTravel.Business => 1500 + ((i % 1501) * 1.0m),
                    ClassOfTravel.FirstClass => 3000 + ((i % 2001) * 1.0m),
                    _ => 200
                };

                // Round to nearest 10 for realism.
                decimal bookingAmount = Math.Round(basePrice / 10) * 10;

                // Tax calculation: 12-15% of booking amount.
                decimal taxPercentage = 12 + ((i % 4) * 1.0m); // 12-15%
                decimal taxAmount = Math.Round(bookingAmount * taxPercentage / 100, 2);

                // Total fare.
                decimal totalFare = bookingAmount + taxAmount;

                // Payment method distribution.
                PaymentMethodType paymentMethod = (PaymentMethodType)((i * 3) % 5);

                // Meal preference.
                MealPreferenceType mealPreference = (MealPreferenceType)((i * 7) % 6);

                list.Add(new FlightBookingRecord
                {
                    BookingId = bookingId,
                    PassengerName = passengerName,
                    Email = email,
                    FlightNumber = flightNumber,
                    AirlineCode = airlineCode,
                    DepartureAirport = departureAirport,
                    ArrivalAirport = arrivalAirport,
                    DepartureDate = departureDate,
                    ArrivalDate = arrivalDate,
                    SeatNumber = seatNumber,
                    ClassOfTravel = classOfTravel,
                    BookingDate = bookingDate,
                    BookingAmount = bookingAmount,
                    TaxAmount = taxAmount,
                    TotalFare = totalFare,
                    Status = status,
                    PaymentMethod = paymentMethod,
                    MealPreference = mealPreference,
                    BaggageAllowance = baggageAllowance,
                    CheckedIn = checkedIn
                });
            }

            return list;
        }
    }
}