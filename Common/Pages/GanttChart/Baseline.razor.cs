using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Buttons;
using Syncfusion.Blazor.Navigations;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class Baseline
    {
        internal SfGantt<BaseData.TaskData>? GanttInstance { get; set; }
        internal List<BaseData.TaskData> TaskCollection { get; set; } = new List<BaseData.TaskData>();

        private List<object> _toolbarItems = new();
        public IReadOnlyList<object> ToolbarItems => _toolbarItems;

        public bool IsBaselineVisible => isChecked;
        private bool isChecked = true;

        /// <summary>
        /// Initializes the sample by loading task data and configuring the baseline toggle toolbar.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = BaseData.GetTaskCollection();
            _toolbarItems = new List<Object>
            {
                new ItemModel
                {
                    Id = "ShowBaseline",
                    Template = (RenderFragment)(builder =>
                    {
                        builder.OpenComponent<SfCheckBox<bool>>(0);
                        builder.AddAttribute(1, "Label", "Show Baseline");
                        builder.AddAttribute(2, "Checked", BindConverter.FormatValue(isChecked));
                        builder.AddAttribute(3, "CheckedChanged", EventCallback.Factory.Create<bool>(this, __value => isChecked = __value));
                        builder.CloseComponent();
                    })
                }
            };
            await Task.CompletedTask.ConfigureAwait(true);
        }
    }
}
