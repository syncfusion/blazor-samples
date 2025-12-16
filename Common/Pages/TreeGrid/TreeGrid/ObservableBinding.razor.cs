#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using ObservableCollection;
using ObservableCollectionProperties;
using Syncfusion.Blazor.Buttons;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Popups;
using Syncfusion.Blazor.TreeGrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.TreeGrid.TreeGrid
{
    public partial class ObservableBinding
    {
        private SfTreeGrid<SupportTicketData> TreeGridRef;
        private ObservableCollection<SupportTicketData> TicketData = new ObservableCollection<SupportTicketData>();

        // Properties for Add Ticket Dialog
        private int? SelectedParentTicketId = null;
        private string CustomTicketTitle = string.Empty;
        private string SelectedPriority = "Medium";
        private string ValidationMessage = string.Empty;
        private List<SupportTicketData> RootParentTickets = new List<SupportTicketData>();
        private List<string> PriorityOptions = new List<string> { "Critical", "High", "Medium", "Low" };

        // Button References - New addition
        private SfButton ResolveTicketButtonRef;
        private SfButton EscalateTicketButtonRef;
        private SfButton RemoveResolvedTicketButtonRef;
        private SfDialog AddDialogRef;

        // Disabled state flags for buttons (bind in markup)
        private bool ResolveDisabled = true;
        private bool EscalateDisabled = true;
        private bool RemoveResolvedDisabled = true;

        private SupportTicketData SelectedRecord = null;

        protected override void OnInitialized()
        {
            TicketData = SupportTicketService.GetSupportTickets();
            LoadRootParentTickets();
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                // Ensure dialog is hidden initially
                if (AddDialogRef != null)
                {
                    AddDialogRef.Visible = false;
                }

                // Buttons are disabled by default via bound flags; trigger re-render
                StateHasChanged();
            }
        }

        private void LoadRootParentTickets()
        {
            // Get all root parent tickets (tickets with ParentTicketID = null)
            RootParentTickets = TicketData.Where(t => t.ParentTicketID == null).ToList();
        }

        private async void ResolveRandomTicket()
        {
            if (SelectedRecord == null) return;

            var selectedTicket = await TreeGridRef.GetSelectedRecordsAsync();
            if (selectedTicket != null && selectedTicket.Count > 0)
            {
                var ticket = selectedTicket[0] as SupportTicketData;
                if (ticket != null)
                {
                    ticket.Status = "Resolved";

                    // Update button states based on new status
                    if (SelectedRecord?.TicketID == ticket.TicketID)
                    {
                        SelectedRecord = ticket; // Update the reference
                        UpdateButtonStates();
                    }
                    // Trigger state change to update button states
                    StateHasChanged();
                }
            }
        }

        private async void EscalateTicket()
        {
            if (SelectedRecord == null) return;

            var selectedTicket = await TreeGridRef.GetSelectedRecordsAsync();
            if (selectedTicket != null && selectedTicket.Count > 0)
            {
                var ticket = selectedTicket[0] as SupportTicketData;
                if (ticket != null)
                {
                    ticket.Status = "Escalated";
                    ticket.Priority = "Critical";

                    // Update button states based on new status
                    if (SelectedRecord?.TicketID == ticket.TicketID)
                    {
                        SelectedRecord = ticket; // Update the reference
                        UpdateButtonStates();
                    }
                    // Trigger state change to update button states
                    StateHasChanged();
                }
            }
        }

        private void OnRowSelected(RowSelectEventArgs<SupportTicketData> args)
        {
            SelectedRecord = args.Data;
            UpdateButtonStates();
            StateHasChanged();
        }

        private void OnRowDeselected(RowDeselectEventArgs<SupportTicketData> args)
        {
            SelectedRecord = null;
            UpdateButtonStates();
            StateHasChanged();
        }

        private void UpdateButtonStates()
        {
            bool hasSelection = SelectedRecord != null;
            bool hasResolvedSelection = SelectedRecord?.Status == "Resolved";

            // Update bound disabled flags (reliable across .NET versions)
            ResolveDisabled = !hasSelection;
            EscalateDisabled = !hasSelection;
            RemoveResolvedDisabled = !hasResolvedSelection;
        }

        private void RemoveSelectedResolvedTicket()
        {
            if (SelectedRecord != null && SelectedRecord.Status == "Resolved")
            {
                TicketData.Remove(SelectedRecord);
                LoadRootParentTickets();

                // Reset selection state
                SelectedRecord = null;
                UpdateButtonStates();
                StateHasChanged();
            }
        }

        private void ShowAddTicketModal()
        {
            // Refresh root parent tickets before showing dialog
            LoadRootParentTickets();
            AddDialogRef.Visible = true;
        }

        private void CloseAddTicketDialog()
        {
            AddDialogRef.Visible = false;
            SelectedParentTicketId = null;
            CustomTicketTitle = string.Empty;
            SelectedPriority = "Medium";
            ValidationMessage = string.Empty;
        }

        private bool IsAddTicketFormValid()
        {
            return SelectedParentTicketId.HasValue && !string.IsNullOrWhiteSpace(CustomTicketTitle);
        }

        private void ValidateForm()
        {
            var errors = new List<string>();

            if (!SelectedParentTicketId.HasValue)
                errors.Add("Please select a parent ticket.");

            if (string.IsNullOrWhiteSpace(CustomTicketTitle))
                errors.Add("Please enter a ticket title.");

            ValidationMessage = string.Join(" ", errors);
            StateHasChanged();
        }

        private void AddTicketWithParent()
        {
            // Validate parent selection before proceeding
            if (!IsAddTicketFormValid())
            {
                //ValidateParentSelection();
                return;
            }

            Random random = new Random();
            string[] randomTitles = { "Critical System Issue - Urgent", "Server Down", "Database Crash", "Network Failure", "Application Bug", "Security Breach", "Configuration Issue", "Performance Problem", "User Access Issue", "Data Sync Problem", "Memory Leak Investigation", "API Timeout Issues", "Load Balancing Problem", "Cache Invalidation", "Session Management Bug", "File Upload Error", "Authentication Failure", "Data Corruption Issue", "Integration Problem", "UI Responsiveness Issue" };
            string[] customers = { "Acme Corp", "Tech Solutions", "Global Industries", "StartUp Inc", "Enterprise Co" };
            string[] agents = { "John Smith", "Sarah Johnson", "Mike Wilson", "Lisa Brown", "Tom Davis" };
            string[] priorities = { "Critical", "High", "Medium", "Low" };
            string[] categories = { "Technical", "Software", "Network", "Hardware", "Security", "Support" };

            // Generate 5-digit ticket ID following 57333 pattern
            int maxId = TicketData.Max(t => t.TicketID);
            int newId = GenerateFiveDigitTicketId(maxId);

            // Determine parent ticket category and customer if a parent is selected
            string selectedCategory = "Technical";
            string selectedCustomer = customers[random.Next(customers.Length)];

            if (SelectedParentTicketId.HasValue)
            {
                var parentTicket = TicketData.FirstOrDefault(t => t.TicketID == SelectedParentTicketId.Value);
                if (parentTicket != null)
                {
                    selectedCategory = parentTicket.Category;
                    selectedCustomer = parentTicket.CustomerName;
                }
            }

            var newTicket = new SupportTicketData(
                newId,
                CustomTicketTitle.Trim(), // Use user-provided title (now required)
                SelectedParentTicketId, // Use selected parent ID (now required)
                selectedCategory,
                SelectedPriority, // Use user-selected priority
                "Open",
                agents[random.Next(agents.Length)],
                selectedCustomer,
                DateTime.Now,
                DateTime.Now.AddHours(random.Next(4, 48)), // Random SLA between 4-48 hours
                random.Next(2, 16)
            );

            TicketData.Add(newTicket);

            // Refresh root parent tickets list after adding
            LoadRootParentTickets();

            // Store the selected parent ID before closing dialog (to prevent reset)
            int? parentIdForNavigation = SelectedParentTicketId;

            // Close dialog
            CloseAddTicketDialog();

            // Navigate to the page containing the parent ticket if one was selected
            if (parentIdForNavigation.HasValue)
            {
                NavigateToParentTicketPage(parentIdForNavigation.Value, newId);
            }
        }

        private async void NavigateToParentTicketPage(int parentTicketId, int addedId)
        {
            await Task.Yield();

            //selection
            var currentViewData = TreeGridRef.GetCurrentViewRecords();
            var selectInd = currentViewData?.FindIndex(rec => addedId.Equals(rec.TicketID));
            if (selectInd > -1)
            {
                await TreeGridRef.ScrollIntoViewAsync((int)selectInd);
                await TreeGridRef.SelectRowAsync((int)selectInd);
            }
        }

        private int GenerateFiveDigitTicketId(int currentMaxId)
        {
            // Follow 57333 pattern - starts with 573, followed by incremental last 2 digits
            const int basePattern = 57300; // Base pattern 573XX

            // Extract the last 2 digits from current max ID
            int lastTwoDigits = currentMaxId % 100;

            // Increment the last 2 digits
            int newLastTwoDigits = lastTwoDigits + 1;

            // If we exceed 99, wrap around and continue with next hundred sequence
            if (newLastTwoDigits > 99)
            {
                // Move to next hundred sequence (57400, 57500, etc.)
                int currentHundreds = (currentMaxId / 100) * 100;
                return currentHundreds + 100 + 1; // Start next sequence
            }

            // For first-time generation or if current max is less than base pattern
            if (currentMaxId < basePattern)
            {
                return basePattern + 31; // Start with 57331 (next after 57330)
            }

            // Generate new ID following the pattern
            int currentPrefix = (currentMaxId / 100) * 100; // Extract 573XX part
            return currentPrefix + newLastTwoDigits;
        }

        // Keep the original method for backward compatibility
        private void AddHighPriorityTicket()
        {
            ShowAddTicketModal();
        }
    }
}
