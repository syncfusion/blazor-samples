#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.ComponentModel;

namespace ObservableCollectionProperties
{
    public class SupportTicketData : INotifyPropertyChanged
    {
        public SupportTicketData() { }
        // Properties for support ticket data
        public int TicketID { get; set; }
        public string Title { get; set; }
        public int? ParentTicketID { get; set; }
        public string Category { get; set; }

        private string priority = string.Empty;
        public string Priority
        {
            get { return priority; }
            set { priority = value; NotifyPropertyChanged("Priority"); }
        }
        private string status = string.Empty;
        public string Status
        {
            get { return status; }
            set { status = value; NotifyPropertyChanged("Status"); }
        }
        public string AssignedAgent { get; set; }

        public string CustomerName { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal EstimatedHours { get; set; }
        public SupportTicketData(int ticketID, string title, int? parentTicketID, string category,
            string priority, string status, string assignedAgent, string customerName,
            DateTime createdDate, DateTime dueDate, decimal estimatedHours)
        {
            this.TicketID = ticketID;
            this.Title = title;
            this.ParentTicketID = parentTicketID;
            this.Category = category;
            this.Priority = priority;
            this.Status = status;
            this.AssignedAgent = assignedAgent;
            this.CustomerName = customerName;
            this.CreatedDate = createdDate;
            this.DueDate = dueDate;
            this.EstimatedHours = estimatedHours;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
