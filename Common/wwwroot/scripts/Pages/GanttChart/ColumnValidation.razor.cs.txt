#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Pages.GanttChart.Data;
using BlazorDemos.Shared;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Grids;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class ColumnValidation
    {

        public static List<ProjectManagementModel.TaskModel> ProjectTasks { get; set; } = new();
        public static SfGantt<ProjectManagementModel.TaskModel> GanttInstance = new();
        public static ProjectManagementModel.TaskModel PreviousData = new();

        private readonly List<string> StatusOptions = new()
        {
            "Not Started",
            "In Progress",
            "Testing",
            "Completed"
        };

        private readonly List<string> PriorityOptions = new()
        {
            "Low",
            "Medium",
            "High",
            "Critical"
        };
        /// <summary>
        /// Handles the Gantt dialog opening event asynchronously.
        /// </summary>
        /// <param name="args">
        /// The event arguments containing the task data for the Gantt dialog.
        /// </param>
        /// <remarks>
        /// This method stores the current task data in <c>PreviousData</c> for later comparison or processing.
        /// It initializes a new instance of <see cref="ProjectManagementModel.TaskModel"/> with the values from <paramref name="args"/>.
        /// </remarks>
        /// <returns>
        /// A completed <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        private async Task GanttDialogOpeningHandlerAsync(GanttDialogOpenEventArgs<ProjectManagementModel.TaskModel> args)
        {
            PreviousData = new ProjectManagementModel.TaskModel
            {
                Id = args.Data.Id,
                TaskName = args.Data.TaskName,
                StartDate = args.Data.StartDate,
                EndDate = args.Data.EndDate,
                Duration = args.Data.Duration,
                Progress = args.Data.Progress,
                ParentId = args.Data.ParentId,
                Predecessor = args.Data.Predecessor,
                Description = args.Data.Description,
                OwnerEmail = args.Data.OwnerEmail,
                TaskCode = args.Data.TaskCode,
                TeamSize = args.Data.TeamSize,
                Tags = args.Data.Tags,
                ContactPhone = args.Data.ContactPhone,
                Budget = args.Data.Budget,
                ActualCost = args.Data.ActualCost,
                Status = args.Data.Status,
                Priority = args.Data.Priority
            };
            await Task.CompletedTask;
        }

        /// <summary>
        /// Handles the Gantt cell edit event asynchronously before the edit operation begins.
        /// </summary>
        /// <param name="args">
        /// The event arguments containing the task data for the cell being edited.
        /// </param>
        /// <remarks>
        /// This method stores the current task data in <c>PreviousData</c> for later comparison or processing.
        /// It initializes a new instance of <see cref="ProjectManagementModel.TaskModel"/> with the values from <paramref name="args"/>.
        /// </remarks>
        /// <returns>
        /// A completed <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        private async Task GanttBeforeCellEditHandler(CellEditArgs<ProjectManagementModel.TaskModel> args)
        {
            PreviousData = new ProjectManagementModel.TaskModel
            {
                Id = args.Data.Id,
                TaskName = args.Data.TaskName,
                StartDate = args.Data.StartDate,
                EndDate = args.Data.EndDate,
                Duration = args.Data.Duration,
                Progress = args.Data.Progress,
                ParentId = args.Data.ParentId,
                Predecessor = args.Data.Predecessor,
                Description = args.Data.Description,
                OwnerEmail = args.Data.OwnerEmail,
                TaskCode = args.Data.TaskCode,
                TeamSize = args.Data.TeamSize,
                Tags = args.Data.Tags,
                ContactPhone = args.Data.ContactPhone,
                Budget = args.Data.Budget,
                ActualCost = args.Data.ActualCost,
                Status = args.Data.Status,
                Priority = args.Data.Priority
            };
            await Task.CompletedTask;
        }      
    }
}