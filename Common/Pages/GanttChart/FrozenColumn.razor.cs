using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using BlazorDemos.Shared;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Navigations;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class FrozenColumn
    {
        internal SfGantt<GanttData.TaskData>? Gantt { get; set; }
        internal List<GanttData.TaskData> TaskCollection { get; set; } = new List<GanttData.TaskData>();
        List<Object>? ToolbarItems { get; set; }
        public int FrozenColumnCount { get; set; } = 1;

        public bool IsTaskNameFrozen { get; set; } = true;
        public FreezeDirection TaskNameFreezeDirection { get; set; } = FreezeDirection.Left;

        public bool IsStartDateFrozen { get; set; }
        public FreezeDirection StartDateFreezeDirection { get; set; }

        public bool IsDurationFrozen { get; set; }
        public FreezeDirection DurationFreezeDirection { get; set; }

        public bool IsProgressFrozen { get; set; } = true;
        public FreezeDirection ProgressFreezeDirection { get; set; } = FreezeDirection.Right;

        public bool IsDependencyFrozen { get; set; } = true;
        public FreezeDirection DependencyFreezeDirection { get; set; } = FreezeDirection.Right;

        private static readonly List<string> rightFrozenColumns = new List<string> { "Duration", "Progress", "Dependency" };
        private static readonly List<string> leftFrozenColumns = new List<string> { "Job Name", "Start Date" };

        private string selectedLeftColumn = leftFrozenColumns[0];
        private string selectedRightColumn = rightFrozenColumns[1];

        /// <summary>
        /// Initializes the sample by loading task data and configuring toolbar items for frozen column selection.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = GanttData.EditingData().ToList();
            ToolbarItems = new List<Object>
        {
            new ItemModel
            {
                Id = "LeftFrozenLabel",
                Template = (RenderFragment)(builder =>
                {
                    builder.OpenElement(0, "label");
                    builder.AddAttribute(1, "class", "frozen-toolbar-label");
                    builder.AddContent(2, "Left Frozen Column");
                    builder.CloseElement();
                })
            },
            new ItemModel
            {
                Id = "LeftFrozenDropdown",
                Template = (RenderFragment)(builder =>
                {
                    builder.OpenComponent<SfDropDownList<string, string>>(0);
                    builder.AddAttribute(1, "Width", "125px");
                    builder.AddAttribute(2, "DataSource", leftFrozenColumns);
                    builder.AddAttribute(3, "Value", selectedLeftColumn);
                    builder.AddAttribute(4, "ValueChanged", EventCallback.Factory.Create<string>(this, v => selectedLeftColumn = v));
                    builder.AddAttribute(5, "ChildContent", (RenderFragment)(childBuilder =>
                    {
                        childBuilder.OpenComponent<DropDownListEvents<string, string>>(0);
                        childBuilder.AddAttribute(1, "ValueChange", EventCallback.Factory.Create<ChangeEventArgs<string, string>>(this, OnLeftFreezeChange));
                        childBuilder.CloseComponent();
                    }));
                    builder.CloseComponent();
                })
            },
            new ItemModel
            {
                Id = "RightFrozenLabel",
                Template = (RenderFragment)(builder =>
                {
                    builder.OpenElement(0, "label");
                    builder.AddAttribute(1, "class", "frozen-toolbar-label");
                    builder.AddContent(2, "Right Frozen Column");
                    builder.CloseElement();
                })
            },
            new ItemModel
            {
                Id = "RightFrozenDropdown",
                Template = (RenderFragment)(builder =>
                {
                    builder.OpenComponent<SfDropDownList<string, string>>(0);
                    builder.AddAttribute(1, "Width", "142px");
                    builder.AddAttribute(2, "DataSource", rightFrozenColumns);
                    builder.AddAttribute(3, "Value", selectedRightColumn);
                    builder.AddAttribute(4, "ValueChanged", EventCallback.Factory.Create<string>(this, v => selectedRightColumn = v));
                    builder.AddAttribute(5, "ChildContent", (RenderFragment)(childBuilder =>
                    {
                        childBuilder.OpenComponent<DropDownListEvents<string, string>>(0);
                        childBuilder.AddAttribute(1, "ValueChange", EventCallback.Factory.Create<ChangeEventArgs<string, string>>(this, OnRightFreezeChange));
                        childBuilder.CloseComponent();
                    }));
                    builder.CloseComponent();
                })
            }
        };
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Handles the dropdown value change event for right frozen column selection.
        /// </summary>
        public async void OnRightFreezeChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, string> args)
        {
            if (args is null || Gantt is null)
            {
                return;
            }
            switch (args.Value)
            {
                case "Dependency":
                    IsDependencyFrozen = true;
                    IsProgressFrozen = false;
                    IsDurationFrozen = false;
                    break;
                case "Progress":
                    IsDependencyFrozen = true;
                    IsProgressFrozen = true;
                    IsDurationFrozen = false;
                    break;
                default:
                    IsDependencyFrozen = true;
                    IsProgressFrozen = true;
                    IsDurationFrozen = true;
                    DurationFreezeDirection = FreezeDirection.Right;
                    break;
            }
            await Gantt.RefreshAsync().ConfigureAwait(true);
			StateHasChanged();
        }

        /// <summary>
        /// Handles the dropdown value change event for left frozen column selection.
        /// </summary>
        public async void OnLeftFreezeChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, string> args)
        {
            if (args is null || Gantt is null)
            {
                return;
            }
            if (args.Value == "Job Name")
            {
                IsTaskNameFrozen = true;
                IsStartDateFrozen = false;
            }
            else
            {
                IsTaskNameFrozen = true;
                IsStartDateFrozen = true;
                StartDateFreezeDirection = FreezeDirection.Left;
            }
            await Gantt.RefreshAsync().ConfigureAwait(true);
			StateHasChanged();
        }
    }
}
