using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.Buttons;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class WbsColumn
    {
        internal SfGantt<WbsColumnData.TaskData>? GanttInstance { get; set; }
        internal List<WbsColumnData.TaskData>? TaskCollection { get; set; } = new List<WbsColumnData.TaskData>();
        private List<object> _toolbarItems = new();
        public IReadOnlyList<object> ToolbarItems => _toolbarItems;
        public bool IsEnableAutoWbsCode { get; set; } = true;

        /// <summary>
        /// Initializes the component by setting up the task collection and toolbar items.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            this.TaskCollection = WbsColumnData.WbsColumnRecord();
            _toolbarItems = new List<Object>()
            {
                "Add",
                "Edit",
                "Update",
                "Delete",
                "Cancel",
                "ExpandAll",
                "CollapseAll",
                new ItemModel
                {
                    Id = "WbsCheckbox",
                    Align = ItemAlign.Left,
                    Template = (RenderFragment)(builder =>
                    {
                        builder.OpenComponent<SfCheckBox<bool>>(0);
                        builder.AddAttribute(1, "Label", "Auto Generate WBS");
                        builder.AddAttribute(2, "Checked", IsEnableAutoWbsCode);
                        builder.AddAttribute(3, "CheckedChanged", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, __value => IsEnableAutoWbsCode = __value));
                        builder.AddAttribute(4, "ValueChange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Buttons.ChangeEventArgs<bool>>(this, HandleAutoWbsChange));
                        builder.CloseComponent();
                    })
                },
            };
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Handles the checkbox change event to toggle auto-generation of WBS codes.
        /// </summary>
        public void HandleAutoWbsChange(Syncfusion.Blazor.Buttons.ChangeEventArgs<bool> args)
        {
            if (args != null)
            {
                IsEnableAutoWbsCode = args.Checked;
            }
        }
    }
}
