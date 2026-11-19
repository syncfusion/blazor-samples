using System;
using System.ComponentModel;

namespace ObservableCollectionProperties
{
    public class SupportTicketData : INotifyPropertyChanged
    {
        public SupportTicketData() { }
        // Properties for support ticket data
        public int TicketID { get; set; }
        public string Title { get; set; } = string.Empty;
        public int? ParentTicketID { get; set; }
        public string Category { get; set; } = string.Empty;

        private string priority = string.Empty;
        public string Priority
        {
            get { return priority; }
            set { priority = value; NotifyPropertyChanged(nameof(Priority)); }
        }
        private string status = string.Empty;
        public string Status
        {
            get { return status; }
            set { status = value; NotifyPropertyChanged(nameof(Status)); }
        }
        public string AssignedAgent { get; set; } = string.Empty;

        public string CustomerName { get; set; } = string.Empty;

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
