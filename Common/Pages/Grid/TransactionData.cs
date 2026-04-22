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

namespace blazor_transactiondata
{
    /// <summary>
    /// Strongly typed payment method types for transactions.
    /// </summary>
    public enum PaymentMethodType
    {
        /// <summary>Payment via credit or debit card.</summary>
        [Display(Name = "Credit Card")]
        CreditCard,

        /// <summary>Payment via debit card.</summary>
        [Display(Name = "Debit Card")]
        DebitCard,

        /// <summary>Payment via PayPal digital wallet.</summary>
        PayPal,

        /// <summary>Payment via cheque instrument.</summary>
        Cheque,

        /// <summary>Payment via UPI (Unified Payments Interface).</summary>
        UPI,

        /// <summary>Payment via net banking facility.</summary>
        NetBanking,

        /// <summary>Payment in physical cash.</summary>
        Cash
    }

    /// <summary>
    /// Strongly typed transaction states used across the model and generator.
    /// </summary>
    public enum TransactionStatus
    {
        /// <summary>Transaction completed successfully.</summary>
        Completed,

        /// <summary>Transaction is pending approval or processing.</summary>
        Pending,

        /// <summary>Transaction failed due to error or rejection.</summary>
        Failed,

        /// <summary>Transaction is currently being processed.</summary>
        Processing,

        /// <summary>Transaction has been refunded.</summary>
        Refunded
    }

    /// <summary>
    /// Represents a transaction entry that appears in the Blazor DataGrid.
    /// </summary>
    public class TransactionRecord
    {
        /// <summary>Unique identifier for the transaction (pattern: TRX-YYYYMMDD-####).</summary>
        public string TransactionId { get; set; } = string.Empty;

        /// <summary>buyer or business name associated with the transaction.</summary>
        public string BuyerName { get; set; } = string.Empty;

        /// <summary>Invoice identifier related to the transaction.</summary>
        public string InvoiceNumber { get; set; } = string.Empty;

        /// <summary>Brief description of the transaction purpose or category.</summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>Total monetary amount for the transaction.</summary>
        public double? TotalAmount { get; set; }

        /// <summary>Payment method used for the transaction.</summary>
        public PaymentMethodType PaymentOptions { get; set; }

        /// <summary>Timestamp when the transaction was initiated or created.</summary>
        public DateTime? CreatedOn { get; set; }

        /// <summary>Timestamp when the transaction reached a terminal state. Null for pending transactions.</summary>
        public DateTime? CompletedOn { get; set; }

        /// <summary>Current state of the transaction (Completed, Pending, Failed, Processing, Refunded).</summary>
        public TransactionStatus Status { get; set; } = TransactionStatus.Pending;
    }

    /// <summary>
    /// Provides deterministic, realistic transaction data for demos and samples.
    /// </summary>
    public static class TransactionData
    {
        /// <summary>Synthetic buyer names for data seeding.</summary>
        private static readonly string[] BuyerNames = new[]
        {
            "Acme Industries", "Brightline Retail", "Cedar Consulting", "Delta Logistics", "Evergreen Health",
            "Fountain Media", "Grove Construction", "Harbor Finance", "Iris Technologies", "Juniper Foods",
            "Keaton Manufacturing", "Lumen Energy", "Marlin Services", "Nimbus Travel", "Orchid Education",
            "Pioneer Real Estate", "Quarry Supplies", "Ridge Automotive", "Summit Insurance", "Trinity Apparel",
            "Union Hardware", "Valley Farms", "Westbridge Labs", "Yellowstone Hospitality", "Zenith Electronics",
            "Alpha Solutions", "Beta Networks", "Gamma Consulting", "Delta Systems", "Epsilon Trading"
        };

        /// <summary>Representative descriptions for transaction types.</summary>
        private static readonly string[] TransactionDescriptions = new[]
        {
            "Invoice Payment - Services", "Monthly Subscription Renewal", "One-time Setup Fee", "Software License Purchase",
            "Hardware Purchase", "Refund - Order Processed", "Chargeback Reversal", "Tax Adjustment", "Consulting Fee",
            "Maintenance Contract", "Training Session", "Advertising Campaign", "Event Sponsorship", "Deposit Received",
            "Final Settlement", "Invoice Correction", "Reimbursement - Travel", "Commission Payout", "Interest Charge",
            "Bank Fees", "Currency Conversion", "Retention Payment", "Warranty Claim", "Professional Services",
            "Equipment Rental", "Utility Bills", "Insurance Premium", "License Renewal", "Support Plan"
        };

        /// <summary>Available payment methods.</summary>
        private static readonly string[] PaymentMethods = new[]
        {
            "Credit Card", "Debit Card", "PayPal", "Cheque", "UPI", "NetBanking", "Cash"
        };

        /// <summary>Supported transaction statuses.</summary>
        private static readonly TransactionStatus[] TransactionStatuses = new[]
        {
            TransactionStatus.Completed,
            TransactionStatus.Pending,
            TransactionStatus.Failed,
            TransactionStatus.Processing,
            TransactionStatus.Refunded
        };

        /// <summary>Generates a deterministic list of 500 transaction records with realistic data.</summary>
        /// <returns>List of populated TransactionRecord instances.</returns>
        public static List<TransactionRecord> GetAllRecords()
        {
            var records = new List<TransactionRecord>(500);
            var baseDate = new DateTime(2025, 12, 01, 08, 00, 00);
            TransactionStatus? previousStatus = null;
            PaymentMethodType? previousPayment = null;

            for (int i = 0; i < 500; i++)
            {
                int row = i + 1;
                
                // Calculate deterministic indices for data selection
                int buyerIndex = (i * 17 + 5) % BuyerNames.Length;
                int descriptionIndex = (i * 7) % TransactionDescriptions.Length;
                int paymentIndex = (i * 3) % PaymentMethods.Length;
                int statusIndex = (i * 5 + i / 7 + 2) % TransactionStatuses.Length;

                // Select buyer, description, and payment method from arrays
                string buyerName = BuyerNames[buyerIndex];
                string description = TransactionDescriptions[descriptionIndex];
                PaymentMethodType paymentMethod = (PaymentMethodType)paymentIndex;

                // Avoid consecutive identical payment methods
                if (previousPayment.HasValue && paymentMethod == previousPayment.Value)
                {
                    paymentMethod = (PaymentMethodType)((paymentIndex + 1) % PaymentMethods.Length);
                }
                previousPayment = paymentMethod;

                // Select transaction status
                TransactionStatus status = TransactionStatuses[statusIndex];
                
                // Cash payments always complete immediately
                if (paymentMethod == PaymentMethodType.Cash)
                {
                    status = TransactionStatus.Completed;
                }
                // Avoid consecutive identical statuses
                else if (previousStatus.HasValue && status == previousStatus.Value)
                {
                    status = TransactionStatuses[(statusIndex + 1) % TransactionStatuses.Length];
                }
                previousStatus = status;

                // Calculate amount based on transaction description category
                double totalAmount = GetTransactionAmount(description, i);

                // Distribute dates across 88 days with time variation
                int daysOffset = (i * 3) % 88;
                DateTime createdOn = baseDate.AddDays(daysOffset).AddMinutes((i * 5) % 1440);

                // Set completion date based on status
                DateTime? completedOn = null;
                if (status == TransactionStatus.Completed || status == TransactionStatus.Failed)
                {
                    // Completed/Failed transactions finish within 5-10 minutes
                    int timeDelta = (i * 3 % 6) + 5;
                    completedOn = createdOn.AddMinutes(timeDelta);
                }
                else if (status == TransactionStatus.Refunded)
                {
                    // Refunded transactions complete after 24 hours
                    completedOn = createdOn.AddHours(24);
                }

                records.Add(new TransactionRecord
                {
                    TransactionId = $"TRX-{createdOn:yyyyMMdd}-{row:D4}",
                    BuyerName = buyerName,
                    InvoiceNumber = $"INV-{createdOn:yyyy}-{row:D4}",
                    Description = description,
                    TotalAmount = totalAmount,
                    PaymentOptions = paymentMethod,
                    CreatedOn = createdOn,
                    CompletedOn = completedOn,
                    Status = status
                });
            }

            return records;
        }

        /// <summary>Returns a realistic transaction amount based on description and seed index.</summary>
        /// <param name="description">Transaction description for category-based logic.</param>
        /// <param name="seed">Deterministic seed value (row index).</param>
        /// <returns>Rounded monetary amount.</returns>
        private static double GetTransactionAmount(string description, int seed)
        {
            // Default amount when no category matches
            double baseAmount = 1200.0 + ((seed * 23) % 9000);

            // Return category-specific amount based on description keywords
            return description switch
            {
                // Low recurring fees (~$300-800)
                string s when s.Contains("Subscription") || s.Contains("Monthly")
                    => Math.Round(299.99d + (seed % 500), 2),

                // High-value hardware purchases (~$2,500-10,000)
                string s when s.Contains("Hardware") || s.Contains("Equipment")
                    => Math.Round(2500.0d + (seed % 7500), 2),

                // Professional service fees (~$1,500-10,000)
                string s when s.Contains("Consulting") || s.Contains("Professional")
                    => Math.Round(1500.0d + (seed % 8500), 2),

                // Refund amounts (~$100-5,100)
                string s when s.Contains("Refund")
                    => Math.Round(100.0d + (seed % 5000), 2),

                // Tax adjustments (~$500-3,500)
                string s when s.Contains("Tax")
                    => Math.Round(500.0d + (seed % 3000), 2),

                // Insurance premiums (~$750-4,750)
                string s when s.Contains("Insurance") || s.Contains("Premium")
                    => Math.Round(750.0d + (seed % 4000), 2),

                // License renewal fees (~$400-3,400)
                string s when s.Contains("License")
                    => Math.Round(400.0d + (seed % 3000), 2),

                // Training/workshop fees (~$800-3,300)
                string s when s.Contains("Training")
                    => Math.Round(800.0d + (seed % 2500), 2),

                // Cloud and support services (~$250-1,750)
                string s when s.Contains("Cloud") || s.Contains("Support")
                    => Math.Round(250.0d + (seed % 1500), 2),

                // Default: use base amount
                _ => Math.Round(baseAmount, 2)
            };
        }
    }
}