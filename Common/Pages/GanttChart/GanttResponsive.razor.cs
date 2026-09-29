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
    public sealed partial class GanttResponsive
    {
        internal SfGantt<WorkData.TaskData>? GanttInstance { get; set; }
        internal List<WorkData.TaskData> TaskCollection { get; set; } = new List<WorkData.TaskData>();
        internal List<Object>? ToolbarItems;
        public string Width { get; set; } = "100%";
        private string selectedDropDownValue = "None";

        /// <summary>
        /// Gets the list of predefined dropdown options used to control the responsive width of the Gantt Chart.
        /// </summary>
        private List<DropDownValueModel> DropDownNames { get; } = new List<DropDownValueModel>
        {
            new DropDownValueModel { Name = "Small" },
            new DropDownValueModel { Name = "Medium" },
            new DropDownValueModel { Name = "Large" },
            new DropDownValueModel { Name = "None" }
        };

        /// <summary>
        /// Initializes the Gantt Responsive sample with task data and toolbar configuration.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = WorkData.GetTaskCollection();
            ToolbarItems = new List<Object>
        {
            new ItemModel
            {
                Id = "Responsive",
                Template = (RenderFragment)(builder =>
                {
                    builder.OpenElement(0, "label");
                    builder.AddAttribute(1, "class", "responsive-label");
                    builder.AddContent(2, "Responsive");
                    builder.CloseElement();
                })
            },
            new ItemModel
            {
                Id = "Responsive",
                Template = (RenderFragment)(builder =>
                {
                    builder.OpenComponent<SfDropDownList<string, DropDownValueModel>>(0);
                    builder.AddAttribute(1, "Width", "118px");
                    builder.AddAttribute(2, "PopupHeight", "230px");
                    builder.AddAttribute(3, "DataSource", DropDownNames);
                    builder.AddAttribute(4, "Value", selectedDropDownValue);
                    builder.AddAttribute(5, "ValueChanged", EventCallback.Factory.Create<string>(this, v => selectedDropDownValue = v));
                    builder.AddAttribute(6, "ChildContent", (RenderFragment)(childBuilder =>
                    {
                        childBuilder.OpenComponent<DropDownListEvents<string, DropDownValueModel>>(0);
                        childBuilder.AddAttribute(1, "ValueChange", EventCallback.Factory.Create<ChangeEventArgs<string, DropDownValueModel>>(this, OnDropDownValueChange));
                        childBuilder.CloseComponent();

                        childBuilder.OpenComponent<DropDownListFieldSettings>(2);
                        childBuilder.AddAttribute(3, "Text", "Name");
                        childBuilder.AddAttribute(4, "Value", "Name");
                        childBuilder.CloseComponent();
                    }));
                    builder.CloseComponent();
                })
            }
        };
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Handles the dropdown value change event to update the Gantt Chart's width responsively.
        /// </summary>
        /// <param name="args">The dropdown change event arguments containing the selected option.</param>
        private void OnDropDownValueChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, DropDownValueModel> args)
        {
            Width = args.ItemData.Name switch
            {
                "Small" => "40%",
                "Medium" => "60%",
                "Large" => "80%",
                "None" => "100%",
                _ => Width // Default to current width
            };
        }

        /// <summary>
        /// Represents a dropdown option used to control the responsive width of the Gantt Chart.
        /// </summary>
        internal sealed class DropDownValueModel
        {
            public string Name { get; set; } = string.Empty;
        }
    }
}
