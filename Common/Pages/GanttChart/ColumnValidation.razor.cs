using BlazorDemos.Pages.GanttChart.Data;
using BlazorDemos.Shared;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Grids;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class ColumnValidation
    {

        internal static List<TaskModel> ProjectTasks { get; set; } = new();
        internal static SfGantt<TaskModel> GanttInstance = new();
        internal static TaskModel PreviousData = new();

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
        /// Initializes the ColumnValidation sample with Gantt task data.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            ProjectTasks = ProjectManagementModel.GetProjectManagementData();
            await Task.CompletedTask.ConfigureAwait(true);
        }

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
        private static async Task GanttDialogOpeningHandlerAsync(GanttDialogOpenEventArgs<TaskModel> args)
        {
            PreviousData = new TaskModel
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
            await Task.CompletedTask.ConfigureAwait(true);
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
        private static async Task GanttBeforeCellEditHandler(CellEditArgs<TaskModel> args)
        {
            if (args.Data is null) return;
            PreviousData = new TaskModel
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
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}