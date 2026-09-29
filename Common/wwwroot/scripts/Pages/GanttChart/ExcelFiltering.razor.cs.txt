using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using BlazorDemos.Shared;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Navigations;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class ExcelFiltering
    {
        internal SfGantt<FilterData.TaskData>? GanttInstance { get; set; }
        internal List<FilterData.TaskData> TaskCollection = new List<FilterData.TaskData>();
        internal List<Object>? ToolbarItems { get; set; }
        internal FilterHierarchyMode CurrentHierarchyMode = FilterHierarchyMode.Both;
        private string selectedHierarchyMode = "Both";

        /// <summary>
        /// Represents a filtering hierarchy mode option with an ID and display text.
        /// </summary>
        private sealed class HierarchyModeFields
        {
            public string? Id { get; set; }
            public string? Text { get; set; }
        }

        /// <summary>
        /// Defines the available hierarchy mode options for filtering in the Gantt Chart.
        /// </summary>
        private static List<HierarchyModeFields> HierarchyModes = new List<HierarchyModeFields>
        {
            new HierarchyModeFields { Id = "Parent", Text = "Parent" },
            new HierarchyModeFields { Id = "Child", Text = "Child" },
            new HierarchyModeFields { Id = "Both", Text = "Both" },
            new HierarchyModeFields { Id = "None", Text = "None" }
        };

        /// <summary>
        /// Initializes the Excel Filtering sample with task data and toolbar configuration.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = FilterData.GetTaskCollection();
            ToolbarItems = new List<Object>
            {
                new ItemModel
                {
                    Id = "HierarchyLabel",
                    Template = (RenderFragment)(builder =>
                    {
                        builder.OpenElement(0, "label");
                        builder.AddAttribute(1, "class", "showhide");
                        builder.AddAttribute(2, "style", "margin-right: 10px;");
                        builder.AddContent(3, "Hierarchy Mode:");
                        builder.CloseElement();
                    })
                },
                new ItemModel
                {
                    Id = "HierarchyDropDown",
                    Align = ItemAlign.Left,
                    Template = (RenderFragment)(builder =>
                    {
                        builder.OpenComponent<SfDropDownList<string, HierarchyModeFields>>(0);
                        builder.AddAttribute(1, "Width", "150px");
                        builder.AddAttribute(2, "DataSource", HierarchyModes);
                        builder.AddAttribute(3, "Placeholder", "Select Mode");
                        builder.AddAttribute(4, "Value", selectedHierarchyMode);
                        builder.AddAttribute(5, "ValueChanged", EventCallback.Factory.Create<string>(this, v => selectedHierarchyMode = v));
                        builder.AddAttribute(6, "Text", "Text");
                        builder.AddAttribute(7, "ValueField", "Id");
                        builder.AddAttribute(8, "TItem", typeof(HierarchyModeFields));
                        builder.AddAttribute(9, "ChildContent", (RenderFragment)(childBuilder =>
                        {
                            childBuilder.OpenComponent<DropDownListFieldSettings>(0);
                            childBuilder.AddAttribute(1, "Text", "Text");
                            childBuilder.AddAttribute(2, "Value", "Id");
                            childBuilder.CloseComponent();
                            childBuilder.OpenComponent<DropDownListEvents<string, HierarchyModeFields>>(3);
                            childBuilder.AddAttribute(4, "ValueChange", EventCallback.Factory.Create<ChangeEventArgs<string, HierarchyModeFields>>(this, OnHierarchyModeChanged));
                            childBuilder.CloseComponent();
                        }));
                        builder.CloseComponent();
                    })
                }
            };
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Handles the change event for hierarchy mode dropdown.
        /// Updates the Gantt filter settings based on selected mode.
        /// </summary>
        private async Task OnHierarchyModeChanged(ChangeEventArgs<string, HierarchyModeFields> args)
        {
            if (!string.IsNullOrEmpty(args.Value))
            {
                selectedHierarchyMode = args.Value;
                CurrentHierarchyMode = args.Value == "Parent" ? FilterHierarchyMode.Parent :
                                                args.Value == "Child" ? FilterHierarchyMode.Child :
                                                args.Value == "None" ? FilterHierarchyMode.None :
                                                FilterHierarchyMode.Both;
            }
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}
