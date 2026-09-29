using System;
using System.Collections.Generic;

namespace BlazorDemos.Pages.Grid
{
    public class Invoice
    {
        public Invoice()
        {
        }

        public Invoice(string invoiceId, string customer, decimal amount, decimal costPrice, decimal profit, string internalNotes, DateTime date, string status)
        {
            InvoiceID = invoiceId;
            Customer = customer;
            Amount = amount;
            CostPrice = costPrice;
            Profit = profit;
            InternalNotes = internalNotes;
            Date = date;
            Status = status;
        }

        public static IReadOnlyList<Invoice> GetAllRecords()
        {
            string[] customers =
            {
                "Northwind Traders",
                "BluePeak Retail",
                "Harbor Logistics",
                "Summit Health Systems",
                "Silverline Manufacturing",
                "Redwood Energy",
                "Valley Electronics",
                "Cedar Grove Foods",
                "Maple & Co. Holdings",
                "Horizon Technologies"
            };

            string[] notes =
            {
                "Priority account - 5% seasonal discount applied",
                "Repeat customer - Payment due in 12 days",
                "Bulk shipment - Customs cleared",
                "Follow up required - Contract renewal review",
                "Large order - Production schedule approved",
                "Late payment history - Net 15 terms",
                "High-value order - Warranty included",
                "Seasonal order - Delivery window confirmed",
                "Executive account - Invoice sent to finance",
                "Strategic partner - Add to preferred vendor list"
            };

            string[] statuses = { "Paid", "Pending", "Overdue" };
            List<Invoice> invoices = new();

            for (int index = 0; index < 50; index++)
            {
                string customer = customers[index % customers.Length];
                decimal amount = 4200m + (index * 285m) + ((index % 6) * 190m);
                decimal costPrice = Math.Round(amount * 0.72m, 2);
                decimal profit = Math.Round(amount - costPrice, 2);
                string status = statuses[index % statuses.Length];
                string internalNotes = notes[index % notes.Length];
                DateTime date = new DateTime(2025, 1, 10).AddDays(index * 5);

                if (index % 7 == 0)
                {
                    status = "Overdue";
                    internalNotes = "Past due - Follow up with account manager";
                }
                else if (index % 5 == 0)
                {
                    status = "Pending";
                    internalNotes = "Awaiting approval from finance department";
                }

                invoices.Add(new Invoice($"INV-{10001 + index}", customer, amount, costPrice, profit, internalNotes, date, status));
            }

            return invoices;
        }

        public string? InvoiceID { get; set; }

        public string? Customer { get; set; }

        public decimal Amount { get; set; }

        public decimal CostPrice { get; set; }

        public decimal Profit { get; set; }

        public string? InternalNotes { get; set; }

        public DateTime Date { get; set; }

        public string? Status { get; set; }
    }
}