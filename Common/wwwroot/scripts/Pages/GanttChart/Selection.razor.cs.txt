using BlazorDemos.Pages.GanttChart.Data;
using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Buttons;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Navigations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class Selection
    {
        internal SfGantt<SelectionData.TaskData>? GanttInstance { get; set; }
        internal List<SelectionData.TaskData> TaskCollection { get; set; } = new List<SelectionData.TaskData>();
        List<Object>? ToolbarItems { get; set; }
        public bool IsToggleEnabled { get; set; }
        internal SfDropDownList<string, DropDownOption>? ModeDropdown { get; set; }
        internal SfDropDownList<string, DropDownOption>? TypeDropdown { get; set; }
        public bool IsAutoScrollEnabled { get; set; }
        public bool IsRowHoverEnabled { get; set; }
        public int SelectedRowIndex { get; set; } = -1;
        public Syncfusion.Blazor.Grids.SelectionMode GanttSelectionMode { get; set; } = Syncfusion.Blazor.Grids.SelectionMode.Row;
        public Syncfusion.Blazor.Grids.SelectionType GanttSelectionType { get; set; } = Syncfusion.Blazor.Grids.SelectionType.Single;
        public bool IsSelectionEnabled { get; set; } = true;
        private string? selectedType;
        private string? selectedMode;

        /// <summary>
        /// Represents the available selection modes in the Gantt chart.
        /// </summary>
        private List<DropDownOption> SelectionModes { get; set; } = new List<DropDownOption>
        {
            new DropDownOption { ID = "Row", Mode = "Row" },
            new DropDownOption { ID = "Cell", Mode = "Cell" }
        };

        /// <summary>
        /// Represents the available selection types in the Gantt chart.
        /// </summary>
        private List<DropDownOption> SelectionTypes { get; set; } = new List<DropDownOption>
        {
            new DropDownOption { ID = "Single", Mode = "Single" },
            new DropDownOption { ID = "Multiple", Mode = "Multiple" }
        };

        /// <summary>
        /// Initializes the Gantt Selection sample by loading task data, setting default selection mode and type, and configuring toolbar items for user interaction.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = SelectionData.GetTaskCollection();
            selectedMode = GanttSelectionMode.ToString();
            selectedType = GanttSelectionType.ToString();
            ToolbarItems = new List<Object>
            {
                new ItemModel
                {
                    Id = "ModeLabel",
                    Template = (RenderFragment)(builder =>
                    {
                        builder.OpenElement(0, "label");
                        builder.AddAttribute(1, "class", "showhide");
                        builder.AddAttribute(2, "style", "padding: 10px 15px 10px 10px");
                        builder.AddContent(3, "Mode");
                        builder.CloseElement();
                    })
                },
                new ItemModel
                {
                    Id = "ModeDropdown",
                    Template = (RenderFragment)(builder =>
                    {
                        builder.OpenComponent<SfDropDownList<string, DropDownOption>>(0);
                        builder.AddAttribute(1, "Width", "90px");
                        builder.AddAttribute(2, "DataSource", SelectionModes);
                        builder.AddAttribute(3, "Value", selectedMode);
                        builder.AddAttribute(4, "Placeholder", "e.g. Cell");
                        builder.AddAttribute(5, "CssClass", "e-selection-mode");
                        builder.AddAttribute(6, "ValueChanged", EventCallback.Factory.Create<string>(this, v => selectedMode = v));
                        builder.AddAttribute(7, "ChildContent", (RenderFragment)(childBuilder =>
                        {
                            childBuilder.OpenComponent<DropDownListEvents<string, DropDownOption>>(0);
                            childBuilder.AddAttribute(1, "ValueChange", EventCallback.Factory.Create<ChangeEventArgs<string, DropDownOption>>(this, OnModeChange));
                            childBuilder.CloseComponent();

                            childBuilder.OpenComponent<DropDownListFieldSettings>(2);
                            childBuilder.AddAttribute(3, "Text", "Mode");
                            childBuilder.AddAttribute(4, "Value", "ID");
                            childBuilder.CloseComponent();
                        }));
                        builder.CloseComponent();
                    })
                },
                new ItemModel
                {
                    Id = "TypeLabel",
                    Template = (RenderFragment)(builder =>
                    {
                        builder.OpenElement(0, "label");
                        builder.AddAttribute(1, "class", "showhide");
                        builder.AddAttribute(2, "style", "padding: 10px 15px 10px 25px");
                        builder.AddContent(3, "Type");
                        builder.CloseElement();
                    })
                },
                new ItemModel
                {
                    Id = "TypeDropdown",
                    Template = (RenderFragment)(builder =>
                    {
                        builder.OpenComponent<SfDropDownList<string, DropDownOption>>(0);
                        builder.AddAttribute(1, "Width", "110px");
                        builder.AddAttribute(2, "DataSource", SelectionTypes);
                        builder.AddAttribute(3, "Value", selectedType);
                        builder.AddAttribute(4, "Placeholder", "e.g. Multiple");
                        builder.AddAttribute(5, "CssClass", "e-selection-type");
                        builder.AddAttribute(6, "ValueChanged", EventCallback.Factory.Create<string>(this, v => selectedType = v));
                        builder.AddAttribute(7, "ChildContent", (RenderFragment)(childBuilder =>
                        {
                            childBuilder.OpenComponent<DropDownListEvents<string, DropDownOption>>(0);
                            childBuilder.AddAttribute(1, "ValueChange", EventCallback.Factory.Create<ChangeEventArgs<string, DropDownOption>>(this, OnTypeChange));
                            childBuilder.CloseComponent();

                            childBuilder.OpenComponent<DropDownListFieldSettings>(2);
                            childBuilder.AddAttribute(3, "Text", "Mode");
                            childBuilder.AddAttribute(4, "Value", "ID");
                            childBuilder.CloseComponent();
                        }));
                        builder.CloseComponent();
                    })
                },
                new ItemModel
                {
                    Id = "ToggleLabel",
                    Template = (RenderFragment)(builder =>
                    {
                        builder.OpenElement(0, "label");
                        builder.AddAttribute(1, "class", "showhide");
                        builder.AddAttribute(2, "style", "padding: 10px 10px 10px 25px");
                        builder.AddContent(3, "Toggle");
                        builder.CloseElement();
                    })
                },
                new ItemModel
                {
                    Id = "ToggleSwitch",
                    Template = (RenderFragment)(builder =>
                    {
                        builder.OpenComponent<SfSwitch<bool>>(0);
                        builder.AddAttribute(1, "Checked", IsToggleEnabled);
                        builder.AddAttribute(2, "ValueChanged", EventCallback.Factory.Create<bool>(this, v => IsToggleEnabled = v));
                        builder.AddAttribute(3, "ValueChange", EventCallback.Factory.Create<ChangeEventArgs<bool>>(this, HandleToggleChange));
                        builder.CloseComponent();
                    })
                },
                new ItemModel
                {
                    Id = "AutoScrollLabel",
                    Template = (RenderFragment)(builder =>
                    {
                        builder.OpenElement(0, "label");
                        builder.AddAttribute(1, "class", "showhide");
                        builder.AddAttribute(2, "style", "padding: 10px 10px 10px 25px");
                        builder.AddContent(3, "Autoscroll to taskbar");
                        builder.CloseElement();
                    })
                },
                new ItemModel
                {
                    Id = "AutoScrollSwitch",
                    Template = (RenderFragment)(builder =>
                    {
                        builder.OpenComponent<SfSwitch<bool>>(0);
                        builder.AddAttribute(1, "Checked", IsAutoScrollEnabled);
                        builder.AddAttribute(2, "ValueChanged", EventCallback.Factory.Create<bool>(this, v => IsAutoScrollEnabled = v));
                        builder.AddAttribute(3, "ValueChange", EventCallback.Factory.Create<ChangeEventArgs<bool>>(this, HandleAutoScrollChange));
                        builder.CloseComponent();
                    })
                },
                new ItemModel
                {
                    Id = "RowHoverLabel",
                    Template = (RenderFragment)(builder =>
                    {
                        builder.OpenElement(0, "label");
                        builder.AddAttribute(1, "class", "showhide");
                        builder.AddAttribute(2, "style", "padding: 10px 10px 10px 25px");
                        builder.AddContent(3, "Enable row hover");
                        builder.CloseElement();
                    })
                },
                new ItemModel
                {
                    Id = "RowHoverSwitch",
                    Template = (RenderFragment)(builder =>
                    {
                        builder.OpenComponent<SfSwitch<bool>>(0);
                        builder.AddAttribute(1, "Checked", IsRowHoverEnabled);
                        builder.AddAttribute(2, "ValueChanged", EventCallback.Factory.Create<bool>(this, v => IsRowHoverEnabled = v));
                        builder.AddAttribute(3, "ValueChange", EventCallback.Factory.Create<ChangeEventArgs<bool>>(this, HandleRowHoverChange));
                        builder.CloseComponent();
                    })
                }
            };
            await Task.CompletedTask.ConfigureAwait(true);
        }
        
        /// <summary>
        /// Handles the toggle switch change event to enable or disable selection toggle.
        /// </summary>
        /// <param name="args">The toggle event arguments.</param>
        public void HandleToggleChange(Syncfusion.Blazor.Buttons.ChangeEventArgs<bool> args)
        {
            if (args is null)
            {
                return;
            }
            IsToggleEnabled = args.Checked;
        }

        /// <summary>
        /// Handles the auto-scroll switch change event to enable or disable scrolling to taskbar on row selection.
        /// </summary>
        /// <param name="args">The auto-scroll toggle event arguments.</param>
        public void HandleAutoScrollChange(Syncfusion.Blazor.Buttons.ChangeEventArgs<bool> args)
        {
            if (args is null)
            {
                return;
            }
            IsAutoScrollEnabled = args.Checked;
        }

        /// <summary>
        /// Handles the row hover switch change event to enable or disable row highlighting on hover.
        /// </summary>
        /// <param name="args">The row hover toggle event arguments.</param>
        public void HandleRowHoverChange(Syncfusion.Blazor.Buttons.ChangeEventArgs<bool> args)
        {
            if (args is null)
            {
                return;
            }
            IsRowHoverEnabled = args.Checked;
        }

        /// <summary>
        /// Updates the Gantt selection mode based on dropdown selection.
        /// </summary>
        /// <param name="args">The selection mode dropdown event arguments.</param>
        private void OnModeChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, DropDownOption> args)
        {
            GanttSelectionMode = args.Value == "Cell" ? Syncfusion.Blazor.Grids.SelectionMode.Cell : Syncfusion.Blazor.Grids.SelectionMode.Row;
        }

        /// <summary>
        /// Updates the Gantt selection type based on dropdown selection.
        /// </summary>
        /// <param name="args">The selection type dropdown event arguments.</param>
        private void OnTypeChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, DropDownOption> args)
        {
            GanttSelectionType = args.Value == "Single" ? Syncfusion.Blazor.Grids.SelectionType.Single : Syncfusion.Blazor.Grids.SelectionType.Multiple;
        }

        /// <summary>
        /// Represents a dropdown option used for selection mode and type configuration.
        /// </summary>
        internal sealed class DropDownOption
        {
            public string ID { get; set; } = string.Empty;
            public string Mode { get; set; } = string.Empty;
        }
    }
}
