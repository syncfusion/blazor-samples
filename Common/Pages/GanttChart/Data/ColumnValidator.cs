#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Syncfusion.Blazor.Grids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static BlazorDemos.Pages.GanttChart.Data.ProjectManagementModel;

namespace BlazorDemos.Pages.GanttChart.Data
{
    public class ColumnValidator : ComponentBase, IDisposable
    {
        [Parameter]
        public ValidatorTemplateContext? Context { get; set; }

        [CascadingParameter]
        private EditContext? CurrentEditContext { get; set; }

        private DateTime MeetingDate = new DateTime(2025, 1, 6);
        private DateTime DevelopmentStartDate = new DateTime(2025, 1, 27);
        private DateTime GoLiveDate = new DateTime(2025, 3, 21);

        private IReadOnlyList<DateTime> Holidays = new List<DateTime>
        {
            new DateTime(2025, 1, 20),
            new DateTime(2025, 2, 17)
        };
        private ValidationMessageStore? _messageStore;
        private static readonly Regex EmailRegex = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        private static readonly Regex PhoneRegex = new(@"^(?:\+1\s?)?(?:\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4})$", RegexOptions.Compiled);
        private static readonly Regex TagsRegex = new(@"^#\w+(?:,\s*#\w+)*$", RegexOptions.Compiled);
        private static readonly HashSet<string> RelatedFields = new()
        {
            nameof(TaskModel.StartDate), nameof(TaskModel.EndDate), nameof(TaskModel.Duration), nameof(TaskModel.Progress), nameof(TaskModel.Predecessor), 
            nameof(TaskModel.TeamSize), nameof(TaskModel.Tags), nameof(TaskModel.ActualCost), nameof(TaskModel.Status), nameof(TaskModel.Priority),
        };
        /// <summary>
        /// Initializes the component and sets up validation event handlers.
        /// </summary>
        protected override void OnInitialized()
        {
            if (CurrentEditContext is null)
                throw new InvalidOperationException($"{nameof(ColumnValidator)} requires a cascading {nameof(EditContext)}.");
            _messageStore = new ValidationMessageStore(CurrentEditContext);
            CurrentEditContext.OnValidationRequested += OnValidationRequested!;
            CurrentEditContext.OnFieldChanged += OnFieldChanged!;
        }

        /// <summary>
        /// Handles the field change event by validating the updated field and notifying the EditContext that the validation state has changed.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Provides data for the field change event, including the FieldIdentifier.</param>
        private void OnFieldChanged(object sender, FieldChangedEventArgs e)
        {
            if (RelatedFields.Contains(e.FieldIdentifier.FieldName))
            {
                ValidateFieldWithRelatedFields();
            }
            else
            {
                ValidateField(e.FieldIdentifier);
            }
            CurrentEditContext?.NotifyValidationStateChanged();
        }

        /// <summary>
        /// Validates all related TaskModel fields to keep cross-field validation consistent.
        /// </summary>
        /// <remarks>
        /// Invoke when any related field changes. This triggers validation (no value changes) for:
        /// StartDate, EndDate, Duration, Progress, Predecessor, TeamSize, Tags, ActualCost, Status, and Priority.
        /// </remarks>
        private void ValidateFieldWithRelatedFields()
        {
            ValidateField(CurrentEditContext!.Field(nameof(TaskModel.StartDate)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.EndDate)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.Duration)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.Progress)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.Predecessor)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.TeamSize)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.Tags)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.ActualCost)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.Status)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.Priority)));
        }
        /// <summary>
        /// Handles the validation request event by performing validation on all fields and updating the validation state in the EditContext.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Provides data for the validation request eve
        private void OnValidationRequested(object sender, ValidationRequestedEventArgs e)
        {
            ValidateField(CurrentEditContext!.Field(nameof(TaskModel.TaskName)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.StartDate)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.EndDate)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.Duration)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.Progress)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.Predecessor)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.Description)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.OwnerEmail)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.TaskCode)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.TeamSize)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.Tags)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.ContactPhone)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.Budget)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.ActualCost)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.Status)));
            ValidateField(CurrentEditContext.Field(nameof(TaskModel.Priority)));
            CurrentEditContext.NotifyValidationStateChanged();
        }

        /// <summary>
        /// Validates a specific field within the current EditContext based on its FieldIdentifier.
        /// Adds or clears validation messages for the field depending on the validation result.
        /// </summary>
        /// <param name="id">The FieldIdentifier representing the field to validate.</param>
        private void ValidateField(FieldIdentifier id)
        {
            _messageStore?.Clear(id);
            if (CurrentEditContext?.Model is not TaskModel task) return;
            if (id.FieldName != nameof(TaskModel.TaskName) && task.Id is 1 or 2 or 5 or 9 or 14 or 18)
            {
                return;
            }
            void AddError(string field, string message)
            {
                _messageStore?.Add(id, message);
                Context?.ShowValidationMessage(field, false, message);
            }
            void Clear(string field) => Context?.ShowValidationMessage(field, true, string.Empty);

            switch (id.FieldName)
            {
                case nameof(TaskModel.TaskName):
                    {
                        var field = nameof(TaskModel.TaskName);
                        if (string.IsNullOrWhiteSpace(task.TaskName))
                            AddError(field, "Task Name is required.");
                        else if (task.TaskName.Length < 5)
                            AddError(field, "Minimum 5 characters required.");
                        else if (task.TaskName.Length > 50)
                            AddError(field, "Maximum 50 characters required.");
                        else
                            Clear(field);
                        break;
                    }

                case nameof(TaskModel.StartDate):
                    {
                        string fieldName = nameof(TaskModel.StartDate);
                        DateTime startDate = task.StartDate.Date;
                        DateTime endDate = task.EndDate.Date;

                        // Validation: Completed Task
                        if (ColumnValidation.PreviousData.StartDate != task.StartDate &&
                            task.Status?.Equals("Completed", StringComparison.OrdinalIgnoreCase) == true)
                        {
                            AddError(fieldName, "Start Date cannot be changed for a completed task.");
                            break;
                        }
                        // Validation: Holiday Check
                        bool isHoliday = Holidays.Any(holiday => holiday.Date == startDate);
                        if (isHoliday)
                        {
                            AddError(fieldName, "Start Date falls on a holiday.");
                            break;
                        }
                        // Validation: meeting and Go-Live Dates
                        if (startDate < MeetingDate.Date)
                        {
                            AddError(fieldName, $"Start Date cannot be earlier than Initial Meeting Date ({MeetingDate.Date}).");
                            break;
                        }
                        if (startDate > GoLiveDate.Date)
                        {
                            AddError(fieldName, $"Start Date cannot be later than Go-Live Date ({GoLiveDate.Date}).");
                            break;
                        }
                        bool isDevelopmentTask = IsDevelopmentTask(task);
                        if (isDevelopmentTask && startDate < DevelopmentStartDate.Date)
                        {
                            AddError(fieldName, $"Start Date cannot be earlier than Development start date ({DevelopmentStartDate.Date}) for this task.");
                            break;
                        }
                        if (task.Priority?.Equals("Low", StringComparison.OrdinalIgnoreCase) == true &&
                            startDate > DevelopmentStartDate.Date)
                        {
                            AddError(fieldName, $"Low-priority tasks should begin before Development start date ({DevelopmentStartDate.Date}).");
                            break;
                        }
                        if (task.Priority?.Equals("Critical", StringComparison.OrdinalIgnoreCase) == true &&
                            startDate < GoLiveDate.AddDays(-21).Date)
                        {
                            AddError(fieldName, $"Critical tasks should start closer to the Go-Live date ({GoLiveDate}).");
                            break;
                        }
                        Clear(fieldName);
                        break;
                    }

                case nameof(TaskModel.EndDate):
                    {
                        string fieldName = nameof(TaskModel.EndDate);
                        DateTime endDate = task.EndDate.Date;
                        // Validation: Completed Task
                        if (ColumnValidation.PreviousData.EndDate != task.EndDate &&
                            task.Status?.Equals("Completed", StringComparison.OrdinalIgnoreCase) == true)
                        {
                            AddError(fieldName, "End Date cannot be changed for a completed task.");
                            break;
                        }
                        // Validation: Holiday Check
                        bool isHoliday = Holidays.Any(holiday => holiday.Date == endDate);
                        if (isHoliday)
                        {
                            AddError(fieldName, "End Date falls on a holiday.");
                            break;
                        }
                        // Validation: Go-Live Date
                        if (endDate > GoLiveDate.Date)
                        {
                            AddError(fieldName, $"End Date cannot be later than Go-Live Date ({GoLiveDate.Date}).");
                            break;
                        }
                        DateTime midPoint = DevelopmentStartDate.Date.AddDays((GoLiveDate.Date - DevelopmentStartDate.Date).TotalDays / 2.0);
                        // Low Priority Rule
                        if (task.Priority?.Equals("Low", StringComparison.OrdinalIgnoreCase) == true &&
                            endDate > DevelopmentStartDate.Date)
                        {
                            AddError(fieldName, $"Low-priority tasks should finish on or before Development start date ({DevelopmentStartDate.Date}).");
                            break;
                        }
                        // High Priority Rule
                        if (task.Priority?.Equals("High", StringComparison.OrdinalIgnoreCase) == true &&
                            endDate < GoLiveDate.AddDays(-14).Date)
                        {
                            AddError(fieldName, $"High-priority tasks should complete near the Go-Live date ({GoLiveDate.Date}).");
                            break;
                        }
                        // Critical Priority Rule
                        if (task.Priority?.Equals("Critical", StringComparison.OrdinalIgnoreCase) == true &&
                            (endDate < GoLiveDate.AddDays(-14).Date || endDate > GoLiveDate.Date))
                        {
                            AddError(fieldName, $"Critical tasks must finish within the final Go-Live date ({GoLiveDate.Date}).");
                            break;
                        }
                        // Over Budget Rule
                        bool isOverBudget = task.Budget.HasValue && task.ActualCost.HasValue &&
                                            task.ActualCost.Value > task.Budget.Value;
                        if (ColumnValidation.PreviousData.EndDate < task.EndDate && isOverBudget)
                        {
                            AddError(fieldName, "End Date cannot be extended while the task is over budget.");
                            break;
                        }
                        Clear(fieldName);
                        break;
                    }

                case nameof(TaskModel.Duration):
                    {
                        string fieldName = nameof(TaskModel.Duration);
                        DateTime startDate = task.StartDate.Date;
                        DateTime endDate = task.EndDate.Date;
                        // Prevent duration change for completed tasks
                        if (ColumnValidation.PreviousData.Duration != task.Duration &&
                            task.Status?.Equals("Completed", StringComparison.OrdinalIgnoreCase) == true)
                        {
                            AddError(fieldName, "Duration cannot be changed for a completed task.");
                            break;
                        }
                        // Validate minimum and maximum duration
                        if (task.Duration < 1)
                        {
                            AddError(fieldName, "Minimum duration is 1 day.");
                            break;
                        }
                        if (task.Duration > 365)
                        {
                            AddError(fieldName, "Maximum duration is 365 days.");
                            break;
                        }

                        if (task.Priority?.Equals("Critical", StringComparison.OrdinalIgnoreCase) == true && task.Duration > 14)
                        {
                            AddError(fieldName, "Critical tasks should be limited to 14 working days or less.");
                            break;
                        }
                        if (task.Priority?.Equals("High", StringComparison.OrdinalIgnoreCase) == true && task.Duration > 20)
                        {
                            AddError(fieldName, "High-priority tasks should not exceed 20 working days.");
                            break;
                        }
                        if (task.Priority?.Equals("Low", StringComparison.OrdinalIgnoreCase) == true && task.Duration < 1)
                        {
                            AddError(fieldName, "Low-priority tasks should be at least 1 working day.");
                            break;
                        }
                        if (task.Priority?.Equals("High", StringComparison.OrdinalIgnoreCase) == true &&
                            task.TeamSize == 3 && task.Duration > 10)
                        {
                            AddError(fieldName, "High priority: team size is 3, maximum duration is 10 days.");
                            break;
                        }
                        if (task.Priority?.Equals("Critical", StringComparison.OrdinalIgnoreCase) == true &&
                            task.TeamSize == 4 && task.Duration > 10)
                        {
                            AddError(fieldName, "Critical priority: team size is 4, maximum duration is 10 days.");
                            break;
                        }

                        Clear(fieldName);
                        break;
                    }

                case nameof(TaskModel.Progress):
                    {
                        string fieldName = nameof(TaskModel.Progress);
                        int progress = task.Progress;
                        string? status = task.Status?.Trim();
                        string? predecessor = task.Predecessor?.Trim();
                        // Validate Status before Progress
                        if (string.IsNullOrWhiteSpace(status))
                        {
                            AddError(fieldName, "Set Status before updating Progress.");
                            break;
                        }
                        // Validate Progress based on Status
                        bool isInvalidProgress = (status.Equals("Completed", StringComparison.OrdinalIgnoreCase) && progress != 100) ||
                                                    (status.Equals("Not Started", StringComparison.OrdinalIgnoreCase) && progress != 0) ||
                                                    (status.Equals("In Progress", StringComparison.OrdinalIgnoreCase) && (progress <= 0 || progress >= 100)) ||
                                                    (status.Equals("Testing", StringComparison.OrdinalIgnoreCase) && (progress <= 75 || progress >= 100));

                        if (isInvalidProgress)
                        {
                            string errorMessage = status switch
                            {
                                "Completed" => "Completed tasks must have 100% progress.",
                                "Not Started" => "Not Started tasks must have 0% progress.",
                                "In Progress" => "In Progress tasks must have progress between 1% and 75%.",
                                "Testing" => "Testing tasks must have progress between 76% and 99%.",
                                _ => "Invalid progress for the given status."
                            };
                            AddError(fieldName, errorMessage);
                            break;
                        }
                        // Parse predecessor IDs
                        var predecessorIds = ParsePredecessorIds(predecessor).ToList();

                        if (predecessorIds.Any())
                        {
                            var unfinishedPredecessors = predecessorIds
                                .Where(pid =>
                                {
                                    var parentTask = ColumnValidation.GanttInstance.GetTaskByID(pid.ToString());
                                    var parentProgress = parentTask?.Progress ?? 0;
                                    return parentTask == null || parentProgress < 100;
                                })
                                .ToList();

                            if (unfinishedPredecessors.Any())
                            {
                                if (progress != 0)
                                {
                                    AddError(fieldName, $"Progress must be 0% until predecessor(s) complete: {string.Join(",", unfinishedPredecessors)}.");
                                    break;
                                }
                                else
                                {
                                    Clear(fieldName);
                                    ValidateField(CurrentEditContext.Field(nameof(TaskModel.Status)));
                                    break;
                                }
                            }
                        }
                        Clear(fieldName);
                        break;
                    }


                case nameof(TaskModel.Status):
                    {
                        string fieldName = nameof(TaskModel.Status);
                        // Check if Status is empty
                        if (string.IsNullOrWhiteSpace(task.Status))
                        {
                            AddError(fieldName, "Status is required.");
                            break;
                        }
                        string status = task.Status.Trim();
                        // Validate Progress based on Status
                        bool isInvalidStatusProgress =
                            (status.Equals("Completed", StringComparison.OrdinalIgnoreCase) && task.Progress != 100) ||
                            (status.Equals("Not Started", StringComparison.OrdinalIgnoreCase) && task.Progress != 0) ||
                            (status.Equals("In Progress", StringComparison.OrdinalIgnoreCase) && (task.Progress <= 0 || task.Progress >= 100)) ||
                            (status.Equals("Testing", StringComparison.OrdinalIgnoreCase) && (task.Progress <= 75 || task.Progress >= 100));
                        if (isInvalidStatusProgress)
                        {
                            string errorMessage = task.Progress switch
                            {
                                100 => "Status must be 'Completed' for 100% progress.",
                                0 => "Status must be 'Not Started' for 0% progress.",
                                >= 76 and <= 99 => "Status must be 'Testing' for 76–99% progress.",
                                >= 1 and <= 75 => "Status must be 'In Progress' for 1–75% progress.",
                                _ => "Invalid status for progress."
                            };
                            AddError(fieldName, errorMessage);
                            break;
                        }
                        // Clear errors and validate Progress field
                        Clear(fieldName);
                        ValidateField(CurrentEditContext.Field(nameof(TaskModel.Progress)));
                        break;
                    }

                case nameof(TaskModel.Description):
                    {
                        var field = nameof(TaskModel.Description);
                        if (string.IsNullOrWhiteSpace(task.Description))
                        {
                            AddError(field, "Description is required.");
                            break;
                        }
                        var len = string.IsNullOrEmpty(task.Description) ? 0 : task.Description.Trim().Length;
                        if (len < 10 || len > 500)
                            AddError(field, "Notes must be between 10 and 500 characters.");
                        else
                            Clear(field);
                        break;
                    }

                case nameof(TaskModel.OwnerEmail):
                    {
                        var field = nameof(TaskModel.OwnerEmail);
                        var email = task.OwnerEmail?.Trim() ?? string.Empty;
                        if (string.IsNullOrEmpty(email))
                            AddError(field, "Owner email is required.");
                        else if (!EmailRegex.IsMatch(email))
                            AddError(field, "Enter a valid email address.");
                        else
                            Clear(field);
                        break;
                    }

                case nameof(TaskModel.TaskCode):
                    {
                        var field = nameof(TaskModel.TaskCode);
                        var code = task.TaskCode?.Trim() ?? string.Empty;
                        if (string.IsNullOrEmpty(code))
                        {
                            AddError(field, "Task Code is required.");
                            break;
                        }
                        var taskCodeRegex = new Regex(@"^PRJ-[A-Z]{2,5}-\d{3}$", RegexOptions.Compiled);
                        if (!taskCodeRegex.IsMatch(code))
                        {
                            AddError(field, "Use format PRJ-XXX-000 (e.g., PRJ-MST-001).");
                            break;
                        }
                        Clear(field);
                        break;
                    }

                case nameof(TaskModel.TeamSize):
                    {
                        var field = nameof(TaskModel.TeamSize);
                        if (task.TeamSize < 1)
                        {
                            AddError(field, "Team Size must be greater than 1.");
                            break;
                        }
                        var (min, max) = task.Priority?.Trim().ToLowerInvariant() switch
                        {
                            "low" => (1, 6),
                            "medium" => (2, 10),
                            "high" => (3, 12),
                            "critical" => (4, 15),
                            _ => (1, 15)
                        };
                        if (task.TeamSize < min)
                            AddError(field, $"Team Size too small for {task.Priority}. Minimum is {min}.");
                        else if (task.TeamSize > max)
                            AddError(field, $"Team Size too large for {task.Priority}. Maximum is {max}.");
                        else
                            Clear(field);
                        break;
                    }

                case nameof(TaskModel.Tags):
                    {
                        var field = nameof(TaskModel.Tags);
                        if (string.IsNullOrWhiteSpace(task.Tags))
                        {
                            AddError(field, "Tags is required.");
                            break;
                        }
                        var tags = task.Tags?.Trim();
                        if (tags?.Length > 50)
                            AddError(field, "Maximum 50 characters allowed.");
                        else if (!TagsRegex.IsMatch(tags!))
                            AddError(field, "Enter hashtags starting with # and separated by commas.");
                        else
                            Clear(field);
                        break;
                    }

                case nameof(TaskModel.ContactPhone):
                    {
                        var field = nameof(TaskModel.ContactPhone);
                        var phone = task.ContactPhone?.Trim() ?? string.Empty;
                        if (string.IsNullOrEmpty(phone))
                            AddError(field, "Contact phone is required.");
                        else if (!PhoneRegex.IsMatch(phone))
                            AddError(field, "Enter a valid US number");
                        else
                            Clear(field);
                        break;
                    }

                case nameof(TaskModel.Budget):
                    {
                        var field = nameof(TaskModel.Budget);
                        if (!task.Budget.HasValue)
                            AddError(field, "Budget is required.");
                        else if (task.Budget.Value < 100m)
                            AddError(field, "Minimum budget is 100.");
                        else if (task.Budget.Value > 50000m)
                            AddError(field, "Maximum budget is 50000.");
                        else
                            Clear(field);
                        break;
                    }

                case nameof(TaskModel.ActualCost):
                    {
                        var field = nameof(TaskModel.ActualCost);
                        if (!task.ActualCost.HasValue)
                        {
                            Clear(field);
                            break;
                        }
                        if (task.Status == "Not Started" && task.ActualCost.HasValue && task.ActualCost.Value > 0m)
                        {
                            AddError(field, "Actual cost must be 0 before a task has started.");
                            break;
                        }
                        if (task.ActualCost.Value < 0m)
                            AddError(field, "Actual cost cannot be negative.");
                        else if (task.ActualCost.Value > 50000m)
                            AddError(field, "Actual cost cannot exceed 50,000.");
                        else
                            Clear(field);
                        break;
                    }

                case nameof(TaskModel.Priority):
                    {
                        var field = nameof(TaskModel.Priority);
                        if (string.IsNullOrWhiteSpace(task.Priority))
                        {
                            AddError(field, "Priority is required.");
                            break;
                        }
                        var expected = GetPriorityValidationMessage(task);
                        if (!string.Equals(task.Priority!.Trim(), expected.Trim(), StringComparison.OrdinalIgnoreCase))
                            AddError(field, $"Priority should be '{expected}' based on project timeline.");
                        else
                            Clear(field);
                        break;
                    }

                case nameof(TaskModel.Predecessor):
                    {
                        string fieldName = nameof(TaskModel.Predecessor);
                        // If no predecessor, clear and exit
                        if (string.IsNullOrWhiteSpace(task.Predecessor))
                        {
                            Clear(fieldName);
                            break;
                        }
                        // Parse predecessor IDs
                        var predecessorIds = ParsePredecessorIds(task.Predecessor!).ToList();
                        if (!predecessorIds.Any())
                        {
                            Clear(fieldName);
                            break;
                        }
                        // Fetch predecessor tasks
                        var predecessors = predecessorIds
                            .Select(pid => ColumnValidation.GanttInstance.GetTaskByID(pid.ToString()))
                            .Where(dep => dep != null)
                            .ToList();
                        if (!predecessors.Any())
                        {
                            Clear(fieldName);
                            break;
                        }
                        // Categorize validation conditions
                        var notAtHundred = predecessors.Where(p => p.Progress < 100).Select(p => p.Id).ToList();
                        var notCompletedStatus = predecessors.Where(p => !string.Equals(p.Status, "Completed", StringComparison.OrdinalIgnoreCase)).Select(p => p.Id).ToList();
                        var overBudget = predecessors.Where(p => p.Budget.HasValue && p.ActualCost.HasValue && p.ActualCost.Value > p.Budget.Value).Select(p => p.Id).ToList();
                        var inReview = predecessors.Where(p => string.Equals(p.Status, "Review", StringComparison.OrdinalIgnoreCase)).Select(p => p.Id).ToList();
                        // Validation Rules
                        if (notAtHundred.Any() && task.Progress > 0)
                        {
                            AddError(fieldName, $"Progress must be 0% until predecessor(s) complete: {string.Join(",", notAtHundred)}.");
                            break;
                        }
                        if (string.Equals(task.Status, "Completed", StringComparison.OrdinalIgnoreCase) && notCompletedStatus.Any())
                        {
                            AddError(fieldName, $"All predecessors must be Completed before completing this task: {string.Join(",", notCompletedStatus)}.");
                            break;
                        }
                        if ((string.Equals(task.Status, "In Progress", StringComparison.OrdinalIgnoreCase) ||
                             string.Equals(task.Status, "Review", StringComparison.OrdinalIgnoreCase)) && notAtHundred.Any())
                        {
                            AddError(fieldName, $"Cannot proceed until predecessor(s) reach 100%: {string.Join(",", notAtHundred)}.");
                            break;
                        }
                        if (string.Equals(task.Priority, "Critical", StringComparison.OrdinalIgnoreCase) && notCompletedStatus.Any())
                        {
                            AddError(fieldName, $"Critical tasks require all predecessors to be Completed: {string.Join(",", notCompletedStatus)}.");
                            break;
                        }
                        if ((string.Equals(task.Priority, "High", StringComparison.OrdinalIgnoreCase) ||
                             string.Equals(task.Priority, "Critical", StringComparison.OrdinalIgnoreCase)) && overBudget.Any() && task.Progress > 0)
                        {
                            AddError(fieldName, $"Cannot progress while predecessor(s) are over budget: {string.Join(",", overBudget)}.");
                            break;
                        }
                        if (inReview.Any() &&
                            (string.Equals(task.Status, "In Progress", StringComparison.OrdinalIgnoreCase) ||
                             string.Equals(task.Status, "Review", StringComparison.OrdinalIgnoreCase)) &&
                            string.Equals(task.Priority, "Critical", StringComparison.OrdinalIgnoreCase))
                        {
                            AddError(fieldName, $"Critical tasks should wait until predecessor review is completed: {string.Join(",", inReview)}.");
                            break;
                        }
                        Clear(fieldName);
                        break;
                    }
            }
        }

        /// <summary>
        /// Parses a predecessor string and extracts all valid task IDs.
        /// </summary>
        /// <param name="predecessorString">
        /// A comma-separated string representing predecessor tasks in the format:
        /// <c>"ID FS [+/- Offset] [Unit]"</c>. 
        /// Example: <c>"101 FS+2d, 102 FS-1 day"</c>.
        /// </param>
        /// <returns>
        /// An <see cref="IEnumerable{Int32}"/> containing all valid predecessor task IDs.
        /// If the input string is null, empty, or contains no valid IDs, returns an empty sequence.
        /// </returns>
        /// <remarks>
        /// The method uses a regular expression to validate and extract numeric IDs from the predecessor string.
        /// Supported units: <c>day</c>, <c>days</c>, <c>d</c>.
        /// </remarks>
        /// <example>
        /// <code>
        /// var ids = ParsePredecessorIds("101 FS+2d, 102 FS-1 day");
        /// // ids = [101, 102]
        /// </code>
        /// </example>
        private static IEnumerable<int> ParsePredecessorIds(string? predecessorString)
        {
            if (string.IsNullOrWhiteSpace(predecessorString))
                return Enumerable.Empty<int>();

            const string pattern = @"^(?<id>\d+)\s*FS(?:\s*(?<sign>[+-])\s*(?<num>\d+)\s*(?<unit>days?|d))?$";

            return predecessorString
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .Select(s =>
                {
                    var match = Regex.Match(s, pattern, RegexOptions.IgnoreCase);
                    return match.Success ? match.Groups["id"].Value : null;
                })
                .Where(id => id is not null && int.TryParse(id, out _))
                .Select(id => int.Parse(id!));
        }

        /// <summary>
        /// Determines whether the specified task is classified as a development-related task.
        /// The check is based on multiple conditions such as parent ID, tags, task code, and keywords in the task name.
        /// </summary>
        /// <param name="task">The TaskModel instance containing details of the task to evaluate.</param>
        /// <returns>
        /// True if the task meets any of the development-related criteria; otherwise, false.
        /// </returns>
        private bool IsDevelopmentTask(TaskModel task)
        {
            return (task.ParentId == 9) ||
                   (task.Tags?.Contains("#development", StringComparison.OrdinalIgnoreCase) == true) ||
                   (task.TaskCode?.StartsWith("PRJ-DEV", StringComparison.OrdinalIgnoreCase) == true) ||
                   (task.TaskName?.Contains("Integration", StringComparison.OrdinalIgnoreCase) == true) ||
                   (task.TaskName?.Contains("Quality", StringComparison.OrdinalIgnoreCase) == true) ||
                   (task.TaskName?.Contains("Testing", StringComparison.OrdinalIgnoreCase) == true) ||
                   (task.TaskName?.Contains("Release", StringComparison.OrdinalIgnoreCase) == true);
        }

        /// <summary>
        /// Generates a validation message for the Priority field based on the specified task details.
        /// This method checks whether the task's priority aligns with defined business rules or constraints.
        /// </summary>
        /// <param name="task">The TaskModel instance containing task details used for validation.</param>
        /// <returns>
        /// A string containing the validation message if the priority is invalid; otherwise, an empty string.
        /// </returns>
        private string GetPriorityValidationMessage(TaskModel task)
        {
            DateTime startDate = task.StartDate.Date;
            DateTime endDate = task.EndDate.Date;
            bool HasTag(TaskModel currentTask, string tagHash)
            {
                if (string.IsNullOrWhiteSpace(currentTask.Tags))
                    return false;

                string[] tags = currentTask.Tags.Split(',', StringSplitOptions.RemoveEmptyEntries);
                return tags.Select(tag => tag.Trim())
                           .Any(tag => tag.Equals(tagHash, StringComparison.OrdinalIgnoreCase));
            }
            bool isReleaseRelated =
                task.ParentId == 18 ||
                HasTag(task, "#golive") ||
                HasTag(task, "#release") ||
                (task.TaskName?.Contains("Release", StringComparison.OrdinalIgnoreCase) ?? false) ||
                (task.TaskName?.Contains("Deployment", StringComparison.OrdinalIgnoreCase) ?? false) ||
                (task.TaskName?.Contains("Hypercare", StringComparison.OrdinalIgnoreCase) ?? false);
            bool isDevelopmentRelated =
                task.ParentId == 9 ||
                HasTag(task, "#development") ||
                (task.TaskCode?.StartsWith("PRJ-DEV", StringComparison.OrdinalIgnoreCase) ?? false) ||
                (task.TaskName?.Contains("Integration", StringComparison.OrdinalIgnoreCase) ?? false);
            bool isQualityRelated =
                task.ParentId == 14 ||
                HasTag(task, "#qa") ||
                (task.TaskName?.Contains("Quality", StringComparison.OrdinalIgnoreCase) ?? false) ||
                (task.TaskName?.Contains("Testing", StringComparison.OrdinalIgnoreCase) ?? false);
            bool isDocumentationOrTraining =
                HasTag(task, "#docs") ||
                (task.TaskName?.Contains("Documentation", StringComparison.OrdinalIgnoreCase) ?? false) ||
                (task.TaskName?.Contains("Training", StringComparison.OrdinalIgnoreCase) ?? false);
            // Budget checks
            bool isOverBudget = task.Budget.HasValue && task.ActualCost.HasValue &&
                                task.ActualCost.Value > task.Budget.Value;

            bool isTightBudget = task.Budget.HasValue && task.ActualCost.HasValue &&
                                 task.Budget.Value > 0 &&
                                 (task.ActualCost.Value / task.Budget.Value) >= 0.8m; // ≥80%
            // Timeline calculations
            DateTime last14DaysStart = GoLiveDate.Date.AddDays(-14);
            DateTime last7DaysStart = GoLiveDate.Date.AddDays(-7);
            DateTime midPoint = DevelopmentStartDate.Date.AddDays((GoLiveDate.Date - DevelopmentStartDate.Date).TotalDays / 2.0);
            // Priority rules
            if (endDate >= GoLiveDate.Date)
                return "Critical"; // Anything ending on/after Go-Live is critical
            if (isReleaseRelated)
            {
                if (endDate >= last7DaysStart) return "Critical";
                if (endDate >= last14DaysStart) return "High";
            }
            if (isDevelopmentRelated || isQualityRelated)
            {
                if (endDate >= last7DaysStart) return "Critical";
                if (endDate >= last14DaysStart) return "High";
            }
            if (isDocumentationOrTraining)
            {
                if (endDate >= last7DaysStart) return "High";
                if (endDate >= DevelopmentStartDate.Date && endDate <= midPoint.Date) return "Medium";
                if (endDate <= DevelopmentStartDate.Date) return "Low";
            }
            if (isOverBudget && endDate >= last14DaysStart)
                return "Critical";
            if (isTightBudget && endDate >= DevelopmentStartDate.Date)
                return "High";
            if (task.TeamSize <= 2 && endDate >= last14DaysStart)
                return "High";
            // Generic timeline mapping
            if (endDate <= DevelopmentStartDate.Date)
                return "Low";
            if (endDate > DevelopmentStartDate.Date && endDate <= midPoint.Date)
                return "Medium";
            if (endDate > midPoint.Date && endDate < GoLiveDate.Date)
                return "High";
            return "Medium";
        }


        /// <summary>
        /// Releases resources and unsubscribes from EditContext events to prevent memory leaks.
        /// This method is called when the component is disposed.
        /// </summary>
        public void Dispose()
        {
            ColumnValidation.PreviousData = new TaskModel();
            if (CurrentEditContext is not null)
            {
                CurrentEditContext.OnValidationRequested -= OnValidationRequested!;
                CurrentEditContext.OnFieldChanged -= OnFieldChanged!;
            }
        }
    }
}
