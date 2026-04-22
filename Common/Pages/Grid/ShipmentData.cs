#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;

namespace blazor_shipmentrecord
{
    /// <summary>
    /// Delivery lifecycle states for a shipment record.
    /// </summary>
    public enum DeliveryStatus
    {
        /// <summary>
        /// Shipment is prepared at origin and awaiting pickup.
        /// </summary>
        Pending,

        /// <summary>
        /// Shipment is moving between facilities.
        /// </summary>
        InTransit,

        /// <summary>
        /// Shipment is assigned to a delivery route.
        /// </summary>
        OutForDelivery,

        /// <summary>
        /// Shipment has reached the destination.
        /// </summary>
        Delivered,

        /// <summary>
        /// Delivery attempt was unsuccessful.
        /// </summary>
        DeliveryFailed,

        /// <summary>
        /// Shipment is being returned or has already returned.
        /// </summary>
        Returned,

        /// <summary>
        /// Shipment progress is delayed.
        /// </summary>
        Delayed,

        /// <summary>
        /// Shipment was canceled before dispatch or by request.
        /// </summary>
        Cancelled
    }

    /// <summary>
    /// Represents a shipment containing tracking, routing, weight, charges, and delivery details.
    /// </summary>
    public sealed class ShipmentRecord
    {
        /// <summary>
        /// Tracking number used to identify the shipment.
        /// </summary>
        public string TrackingID { get; set; } = string.Empty;

        /// <summary>
        /// Recipient name associated with the shipment.
        /// </summary>
        public string RecipientName { get; set; } = string.Empty;

        /// <summary>
        /// Current delivery state.
        /// </summary>
        public DeliveryStatus DeliveryStatus { get; set; }

        /// <summary>
        /// Delivery date or expected date related to the delivery state.
        /// </summary>
        public DateTime? DeliveryDate { get; set; }

        /// <summary>
        /// Weight of the shipment in kilograms.
        /// </summary>
        public double? Weight { get; set; }

        /// <summary>
        /// Total shipping cost.
        /// </summary>
        public double? Charges { get; set; }

        /// <summary>
        /// Origin facility identifier.
        /// </summary>
        public string OriginLocation { get; set; } = string.Empty;

        /// <summary>
        /// Region representing the destination route.
        /// </summary>
        public string DestinationRegion { get; set; } = string.Empty;
    }

    /// <summary>
    /// Generates a collection of shipment records with static, deterministic values for sample display.
    /// </summary>
    public static class ShipmentData
    {
        /// <summary>
        /// Returns a fixed set of 200 shipment records for demonstration scenarios.
        /// </summary>
        public static List<ShipmentRecord> GetAllRecords()
        {
            // Generates a deterministic tracking ID without repeating patterns.
            static string GenerateTrackingId(int index)
            {
                const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ0123456789";
                int seed = index + 1;

                char[] tail = new char[7];
                int v = seed * 7919 + 104729;

                for (int i = 0; i < tail.Length; i++)
                {
                    v = (v * 1315423911) ^ (v >> 5);
                    int pos = Math.Abs(v % chars.Length);
                    tail[i] = chars[pos];
                }

                return "SHP" + new string(tail);
            }

            // Recipient list.
            string[] recipients =
            {
                "Aaron Blake","Abigail Watts","Adrian Cole","Aiden Brooks","Alex Turner","Alice Cruz","Allison Grant",
                "Alyssa Hayes","Amelia Perry","Andrew Stone","Anna Fisher","Anthony Ward","Ariana Ross","Ashley Cooper",
                "Audrey Jenkins","Austin Rivera","Ava Barnes","Benjamin Ford","Caleb Myers","Cameron Price","Caroline Bell",
                "Carter Howard","Charlotte Scott","Chloe Adams","Christian Flores","Christopher West","Claire Morgan",
                "Colin Bryant","Daniel Reed","David Powell","Declan Griffin","Dylan Hughes","Eleanor Russell","Elena Foster",
                "Eli Parker","Elijah Sanders","Elizabeth Diaz","Ella Coleman","Elliot Pierce","Emma Long","Ethan Simmons",
                "Evan Bennett","Evelyn Stewart","Gabriel Patterson","Gavin Murray","Grace Phillips","Grant Young",
                "Hannah Cook","Harper Mitchell","Henry Bailey","Hudson Gomez","Hunter Sullivan","Ian Ramirez","Isaac Ward",
                "Isabelle Sharp","Jack Matthews","Jackson Perry","Jacob Ortiz","James Henderson","Jason Newman","Jasper Boyd",
                "Jayden Elliott","Jeremiah Fox","Jocelyn Hart","John Bishop","Jonathan Payne","Jordan Walters","Joseph Cross",
                "Joshua Gordon","Julia Wallace","Katherine Warren","Kayla Rhodes","Kenneth Holmes","Landon Weaver",
                "Lauren Barton","Leah Chapman","Leo Barrett","Liam Carter","Lillian Stephens","Logan Reed","Lucas Scott",
                "Lucy Andrews","Mackenzie Walsh","Madison Pierce","Maria Caldwell","Mason White","Matthew Curtis","Mia Turner",
                "Michael Stone","Michelle Lowe","Nathan Kim","Nolan Pratt","Noah Mitchell","Nora Fleming","Oliver Briggs",
                "Olivia Larson","Owen Jacobs","Paige Lawson","Parker Fleming","Patrick Lowe","Penelope Harper","Peyton Rice",
                "Quinn Abbott","Rachel Grant","Reagan Bishop","Rebecca Steele","Richard Lowe","Riley Shaw","Robert Pierce",
                "Ruby Hayes","Ryan Foster","Samantha Ortiz","Samuel Banks","Sarah Kelley","Savannah Horton","Scarlett Ray",
                "Sofia Greene","Sophia Brown","Stella Walsh","Steven Cross","Taylor Beck","Thomas Watts","Tyler Boone",
                "Valerie Blake","Victoria Paul","Violet Hart","William Pratt","Wyatt Briggs","Xavier Lawson","Zachary Neal",
                "Zoe Sherman"
            };

            // Origin hubs.
            string[] origins = { "HUB-NY1", "HUB-TX2", "HUB-IL3", "HUB-CA4", "HUB-GA5", "HUB-WA6" };

            // Destination regions.
            string[] regions =
            {
                "Northeast","Mid-Atlantic","Southeast","Midwest","Southwest","Mountain","Pacific","Territories"
            };

            DateTime refDate = new DateTime(2026, 3, 2);

            var list = new List<ShipmentRecord>(capacity: 200);

            for (int i = 0; i < 200; i++)
            {
                string trackingId = GenerateTrackingId(i);

                // Deterministic selections.
                string recipient = recipients[(i * 7) % recipients.Length];
                string region = regions[(i * 2) % regions.Length];
                string origin = origins[(i * 5) % origins.Length];

                // Status rotation with non-repetitive pattern.
                DeliveryStatus status = (DeliveryStatus)((i * 3) % 8);

                // Status-based date assignment.
                DateTime date = status switch
                {
                    DeliveryStatus.Pending => refDate.AddDays((i % 2 == 0) ? 0 : 1),
                    DeliveryStatus.InTransit => refDate.AddDays((i % 6) + 1),
                    DeliveryStatus.OutForDelivery => refDate.AddDays((i % 2 == 0) ? 0 : 1),
                    DeliveryStatus.Delivered => refDate.AddDays(-((i % 10) + 1)),
                    DeliveryStatus.DeliveryFailed => refDate.AddDays(-((i % 6) + 1)),
                    DeliveryStatus.Returned => refDate.AddDays(-((i % 12) + 2)),
                    DeliveryStatus.Delayed => refDate.AddDays((i % 8) + 2),
                    _ => refDate
                };

                // Weight pattern.
                double weight = Math.Round(0.6 + (i % 45) * 0.45, 2);

                // Tier classification using region length.
                int tier = (i + region.Length) % 3;

                double baseFee = tier == 0 ? 5.25 : (tier == 1 ? 7.40 : 9.85);
                double perKg = tier == 0 ? 0.90 : (tier == 1 ? 1.15 : 1.35);
                double handling = (i % 5) * 0.35;

                double rawCharge = baseFee + (perKg * weight) + handling;

                if ((i % 13) == 4) rawCharge += 1.20;
                if ((i % 19) == 7) rawCharge += 1.80;

                double charge = Math.Round(rawCharge, 2, MidpointRounding.AwayFromZero);

                list.Add(new ShipmentRecord
                {
                    TrackingID = trackingId,
                    RecipientName = recipient,
                    DeliveryStatus = status,
                    DeliveryDate = date,
                    Weight = weight,
                    Charges = charge,
                    OriginLocation = origin,
                    DestinationRegion = region
                });
            }
            return list;
        }
    }
}