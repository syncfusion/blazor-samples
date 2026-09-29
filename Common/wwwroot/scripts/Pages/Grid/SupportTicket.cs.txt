using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorDemos.Pages.Grid
{
    public class SupportTicket
    {
        public SupportTicket()
        {
        }
        public static IReadOnlyList<SupportTicket> GetAllRecords()
        {
            List<SupportTicket> tickets = new();

            var customers = new[]
            {
                new
                {
                    Name = "John Smith",
                    Email = "john.smith@email.com",
                    ContactNumber = "+1-202-555-0101"
                },
                new
                {
                    Name = "Emma Wilson",
                    Email = "emma.wilson@email.com",
                    ContactNumber = "+44-20-7946-1002"
                },
                new
                {
                    Name = "Michael Davis",
                    Email = "michael.davis@email.com",
                    ContactNumber = "+1-416-555-1003"
                },
                new
                {
                    Name = "Sophia Brown",
                    Email = "sophia.brown@email.com",
                    ContactNumber = "+61-2-5550-1004"
                },
                new
                {
                    Name = "Raj Kumar",
                    Email = "raj.kumar@email.com",
                    ContactNumber = "+91-98765-10005"
                },
                new
                {
                    Name = "Lisa Taylor",
                    Email = "lisa.taylor@email.com",
                    ContactNumber = "+49-30-5555-1006"
                },
                new
                {
                    Name = "Alex Johnson",
                    Email = "alex.johnson@email.com",
                    ContactNumber = "+33-1-5550-1007"
                },
                new
                {
                    Name = "Priya Sharma",
                    Email = "priya.sharma@email.com",
                    ContactNumber = "+65-6555-1008"
                },
                new
                {
                    Name = "Daniel Moore",
                    Email = "daniel.moore@email.com",
                    ContactNumber = "+971-4-555-1009"
                },
                new
                {
                    Name = "Olivia Martin",
                    Email = "olivia.martin@email.com",
                    ContactNumber = "+81-3-5555-1010"
                }
            };

            string[] assignedTo =
            {
                "Sarah Johnson",
                "David Clark",
                "Alex Brown"
            };

            var templates = new[]
            {
                new
                {
                    Subject = "Payment not processed",
                    Description = "My recent payment for order was deducted but the order shows pending status. Please resolve urgently.",
                    Category = "Billing",
                    Priority = "High",
                    Status = "Open"
                },
                new
                {
                    Subject = "Login failed after password reset",
                    Description = "Customer is unable to login after resetting password. Authentication validation failed.",
                    Category = "Authentication",
                    Priority = "Medium",
                    Status = "In Progress"
                },
                new
                {
                    Subject = "Refund payment pending",
                    Description = "Refund payment has not been processed and customer is waiting for an update.",
                    Category = "Billing",
                    Priority = "High",
                    Status = "Open"
                },
                new
                {
                    Subject = "Order tracking unavailable",
                    Description = "Customer cannot track the order. Order tracking page displays an error.",
                    Category = "Order",
                    Priority = "Low",
                    Status = "Resolved"
                },
                new
                {
                    Subject = "Payment gateway timeout",
                    Description = "Payment gateway timeout occurred during checkout for multiple customers.",
                    Category = "Billing",
                    Priority = "Critical",
                    Status = "Open"
                }
            };

            for (int i = 1; i <= 100; i++)
            {
                var template = templates[(i - 1) % templates.Length];
                var customer = customers[(i - 1) % customers.Length];
                tickets.Add(new SupportTicket(
                    $"TKT-{10000 + i}",
                    customer.Name,
                    customer.ContactNumber,
                    customer.Email,
                    template.Subject,
                    template.Description,
                    template.Category,
                    template.Priority,
                    template.Status,
                    assignedTo[(i - 1) % assignedTo.Length],
                    new DateTime(2026, ((i - 1) % 12) + 1, ((i - 1) % 28) + 1),
                    new DateTime(2026, ((i - 1) % 12) + 1, ((i + 2) % 28) + 1)
                ));
            }

            return tickets;
        }
        public SupportTicket(
            string ticketId,
            string customerName,
            string contactNumber,
            string email,
            string subject,
            string description,
            string category,
            string priority,
            string status,
            string assignedTo,
            DateTime createdDate,
            DateTime lastUpdated)
        {
            TicketId = ticketId;
            CustomerName = customerName;
            ContactNumber = contactNumber;
            Email = email;
            Subject = subject;
            Description = description;
            Category = category;
            Priority = priority;
            Status = status;
            AssignedTo = assignedTo;
            CreatedDate = createdDate;
            LastUpdated = lastUpdated;
        }

        public string? TicketId { get; set; }
        public string? CustomerName { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? Priority { get; set; }
        public string? Status { get; set; }
        public string? AssignedTo { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
