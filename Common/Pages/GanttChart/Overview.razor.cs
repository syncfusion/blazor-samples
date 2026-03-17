#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using BlazorDemos.Pages.GanttChart.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Buttons;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Navigations;
using Syncfusion.PdfExport;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class Overview
    {
        public SfGantt<OverviewData.TaskData>? GanttInstance { get; set; }
        public List<OverviewData.TaskData> TaskCollection { get; set; } = new List<OverviewData.TaskData>();
        public List<OverviewData.ResourceInfoModel> ResourceCollection { get; set; } = new List<OverviewData.ResourceInfoModel>();
        public static List<OverviewData.AssignmentModel> AssignmentCollection { get; set; } = new List<OverviewData.AssignmentModel>();
        public List<OverviewData.SegmentModel> SegmentCollection { get; set; } = new List<OverviewData.SegmentModel>();
        public bool IsSideBar { get; set; } = false;
        public bool IsSidebarToggled { get; set; }
        private bool settings = true;
        public int RowHeightValue { get; set; } = 45;
        public int DefaultUnitWidth { get; set; } = 75;
        public DateTime KickOffDate { get; set; } = new DateTime(2025, 2, 11);
        public DateTime DesignCompletionDate { get; set; } = new DateTime(2025, 5, 15);
        public DateTime DeploymentDate { get; set; } = new DateTime(2025, 11, 17);
        public ViewType SelectedViewType { get; set; } = ViewType.ProjectView;
        public string SelectedViewTypes { get; set; } = "Project view";
        public string SelectedViewMode { get; set; } = "Default";
        public string DurationUnitValue { get; set; } = "Day";
        public DurationUnit DurationValue { get; set; } = DurationUnit.Day;
        public bool IsEventMarkerVisible { get; set; } = false;
        public bool IsTaskLabelsVisible { get; set; } = true;
        public bool IsDarkMode => CurrentUri.Contains("dark") || CurrentUri.Contains("highcontrast");
        public bool IsCustomSchedulingEnabled { get; set; }
        public bool IsCriticalPathEnabled { get; set; }
        public DateTime? ProjectStartDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public bool IsChecked { get; set; } = true;
        public bool ShowDependency { get; set; } = true;
        private Dictionary<string, string> pdfExportImage = new Dictionary<string, string>();
        public Theme CurrentTheme { get; set; }
        public string CurrentUri { get; set; } = string.Empty;
        public List<Theme> AvailableThemes { get; set; } = new List<Theme>() { Theme.Fluent, Theme.Fabric, Theme.Bootstrap5, Theme.Bootstrap, Theme.Bootstrap4, Theme.Tailwind, Theme.Material, Theme.Tailwind3 };
        //***API properties
        public Syncfusion.Blazor.Gantt.GridLine Gridlines { get; set; } = Syncfusion.Blazor.Gantt.GridLine.Both;
        public string CurrentHeaderTitle { get; set; } = "Project Settings";
        public string[] WorkWeekDays { get; set; } = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        public string[]? Selectweek { get; set; }
#pragma warning disable BL0005 // Component parameter should not be set outside of its component.
        public List<object> Toolbaritems { get; set; } = new List<object>() { "ExpandAll", "CollapseAll", "ZoomIn", "ZoomOut", "ZoomToFit", "Indent", "Outdent", "ExcelExport", new ToolbarItem() { TooltipText = "PdfExport", Id = "PdfExport", PrefixIcon = "e-pdfexport" }, new ToolbarItem() { Text = "Settings", TooltipText = "Settings", Id = "Settings", PrefixIcon = "e-settings-icon", Align = ItemAlign.Right } };
#pragma warning restore BL0005 // Component parameter should not be set outside of its component.
        // Specifies the ListView datasource.
        public List<DataModel> ListViewData { get; set; } = new List<DataModel>();

        private string marginTop = "3px";
        private string dropdownWidth = "80px";
        private string manualTaskbarWidth = "11px";
        private string filterHeaderFontSize = string.Empty;
        private string filterHeaderFontSizeTouch = string.Empty;
        private string filterHeaderHeight = string.Empty;
        private string filterHeaderHeightTouch = string.Empty;
        private string filterHeaderFontWeight = string.Empty;
        private string filterBackgroundColor = string.Empty;
        private string labelTextColor = string.Empty;
        private string textColor = string.Empty;
        private string backgroundColor = string.Empty;

        // Specifies the model class for ListView datasource.
        public class DataModel
        {
            public string Id { get; set; } = string.Empty;
            public string Text { get; set; } = string.Empty;
            public string Category { get; set; } = string.Empty;
            public int Order { get; set; }
            public List<DataModel>? Child { get; set; }
        }

        /// <summary>
        /// Switches between Project and Resource view and updates related UI state.
        /// </summary>
        private void GanttViewTypes(ChangeEventArgs<string, ViewTypes> args)
        {
            if (args.Value.Contains("Resource view"))
            {
                SelectedViewType = ViewType.ResourceView;
                SelectedViewTypes = args.Value;
            }
            else
            {
                SelectedViewType = ViewType.ProjectView;
                SelectedViewTypes = args.Value;
            }
            StateHasChanged();
            settings = true;
        }

        /// <summary>
        /// Toggles grid line visibility between both and vertical-only modes.
        /// </summary>
        private void GridLines(ChangeEventArgs<bool> args)
        {
            IsChecked = args.Checked;
            Gridlines = IsChecked ? Syncfusion.Blazor.Gantt.GridLine.Both : Syncfusion.Blazor.Gantt.GridLine.Vertical;
        }

        /// <summary>
        /// Shows or hides event markers on the Gantt chart.
        /// </summary>
        private void EventMarkerEvent(ChangeEventArgs<bool> args)
        {
            IsEventMarkerVisible = args.Checked;
        }

        /// <summary>
        /// Shows or hides task dependencies on the Gantt chart.
        /// </summary>
        private void ShowDependencies(ChangeEventArgs<bool> args)
        {
            ShowDependency = args.Checked;
        }

        /// <summary>
        /// Shows or hides task labels on Gantt bars.
        /// </summary>
        private void ShowTaskLabels(ChangeEventArgs<bool> args)
        {
            IsTaskLabelsVisible = args.Checked;
        }

        /// <summary>
        /// Enables or disables critical path and adjusts project dates accordingly.
        /// </summary>
        private void CriticalPathEnable(ChangeEventArgs<bool> args)
        {
            if (args.Checked == true)
            {
                ProjectStartDate = null;
                ProjectEndDate = null;
                IsCriticalPathEnabled = true;
            }
            else
            {
                ProjectStartDate = new DateTime(2025, 01, 25);
                ProjectEndDate = new DateTime(2025, 11, 25);
                IsCriticalPathEnabled = false;
            }
        }

        /// <summary>
        /// Enables or disables custom scheduling and refreshes the Gantt instance.
        /// </summary>
        private async Task EnableCustomScheduling(ChangeEventArgs<bool> args)
        {
            IsCustomSchedulingEnabled = args.Checked;
            await GanttInstance.RefreshAsync();
            await Task.CompletedTask;
        }

        /// <summary>
        /// Updates the timeline cell unit width based on numeric input.
        /// </summary>
        public void OnChange(Syncfusion.Blazor.Inputs.ChangeEventArgs<int?> args)
        {
            DefaultUnitWidth = args.Value != null ? (int)args.Value : 33;
        }

        /// <summary>
        /// Changes the Gantt row height.
        /// </summary>
        private void RowHeightchange(int value)
        {
            RowHeightValue = value;
        }

        /// <summary>
        /// Closes the settings sidebar and resets visibility flags.
        /// </summary>
        public void Close()
        {
            IsSidebarToggled = false;
            settings = true;
        }

        public class WorkWeek
        {
            public string Week { get; set; } = string.Empty;
        }

        public List<WorkWeek> Weeks = new List<WorkWeek>
        {
            new WorkWeek() { Week = "Monday"},
            new WorkWeek() { Week = "Tuesday"},
            new WorkWeek() { Week = "Wednesday"},
            new WorkWeek() { Week = "Thursday"},
            new WorkWeek() { Week = "Friday"},
            new WorkWeek() { Week = "Saturday"}
        };

        public class Duration
        {
            public string Unit { get; set; } = string.Empty;
        }

        public List<Duration> Duration1 = new List<Duration>
        {
            new Duration() { Unit = "Hour"},
            new Duration() { Unit = "Minute"},
            new Duration() { Unit = "Day"}
        };

        public class ViewTypes
        {
            public string Type { get; set; } = string.Empty;
        }

        public List<ViewTypes> Types = new List<ViewTypes>
        {
            new ViewTypes() { Type = "Resource view"},
            new ViewTypes() { Type = "Project view"}
        };


        /// <summary>
        /// Updates the working weekdays selection or defaults to Monday�Friday.
        /// </summary>
        private void ValueChangedHandler(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                WorkWeekDays = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            }
            else
            {
                WorkWeekDays = args;
                Selectweek = WorkWeekDays;
            }
        }

        /// <summary>
        /// Sets the task duration unit (Hour, Day, or Minute) based on selection.
        /// </summary>
        private void ValueChangeHandler2(ChangeEventArgs<string, Duration> args)
        {
            if (args.Value.Contains("Hour"))
            {
                DurationValue = DurationUnit.Hour;
                DurationUnitValue = DurationValue.ToString();
            }
            else if (args.Value.Contains("Day"))
            {
                DurationValue = DurationUnit.Day;
                DurationUnitValue = DurationValue.ToString();
            }
            else if (args.Value.Contains("Minute"))
            {
                DurationValue = DurationUnit.Minute;
                DurationUnitValue = DurationValue.ToString();
            }
        }

        public class SplitterView
        {
            public string ID { get; set; } = string.Empty;
            public string Text { get; set; } = string.Empty;
        }

        public List<SplitterView> SplitterViews = new List<SplitterView>
        {
            new SplitterView() { ID= "Default", Text= "Default" },
            new SplitterView() { ID= "Grid", Text= "Grid" },
            new SplitterView() { ID= "Chart", Text= "Chart" },
        };

        /// <summary>
        /// Sets the splitter position (Default, Grid, or Chart) and refreshes the view.
        /// </summary>
        public async void OnChange(ChangeEventArgs<string, SplitterView> args)
        {
            if (args.Value == "Grid")
            {
                await GanttInstance.SetSplitterPositionAsync(Syncfusion.Blazor.Gantt.SplitterView.Grid);

            }
            else if (args.Value == "Chart")
            {
                await GanttInstance.SetSplitterPositionAsync(Syncfusion.Blazor.Gantt.SplitterView.Chart);
            }
            else
            {
                await GanttInstance.SetSplitterPositionAsync(Syncfusion.Blazor.Gantt.SplitterView.Default);
                dropdownWidth = "90px";
            }
            await GanttInstance.RefreshAsync();
        }

        /// <summary>
        /// Toggles the settings sidebar when a row is selected.
        /// </summary>
        public async Task RowSelectedHandler()
        {
            IsSidebarToggled = !IsSidebarToggled;
            IsSideBar = false;
            await Task.CompletedTask;
        }

        /// <summary>
        /// Handles toolbar actions for settings and exports (Excel, CSV, PDF).
        /// </summary>
        public async Task ToolbarClickHandler(ClickEventArgs args)
        {
            ExcelExportProperties ExportProperties = new ExcelExportProperties();
            GanttPdfExportProperties PdfExportProperties = new GanttPdfExportProperties();
            List<GridColumn> gridColumns = new List<GridColumn>() {
                #pragma warning disable BL0005 // Component parameter should not be set outside of its component.
                new GridColumn() { Field = "Task", HeaderText = "Task Name", Width = "300" },
                new GridColumn() { Field = "Assignee", HeaderText = "Assigned Person", Width= "180" }, // Template logic not directly transferable
                new GridColumn() { Field = "StartDate", HeaderText = "Start Date", Width = "130", TextAlign = TextAlign.Right, Format = "M/d/yyyy"},
                new GridColumn() { Field = "EndDate", HeaderText = "End Date", Width = "130",TextAlign = TextAlign.Right, Format = "M/d/yyyy" },
                new GridColumn() { Field = "Priority", HeaderText = "Task Priority",Width = "130" }, // Template logic not directly transferable
                new GridColumn() { Field = "Budget", HeaderText = $"Allocated Budget ({System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol})", Width= "150", Format = "C2", TextAlign = TextAlign.Right },
                new GridColumn() { Field = "ActualCost", HeaderText = $"Spent Budget ({System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol})", Width= "150", Format = "C2", TextAlign = TextAlign.Right },
                new GridColumn() { Field = "Progress", HeaderText = "Completion (%)", Width= "130" },
                new GridColumn() { Field = "Status", HeaderText = "Status", Width = "130" },
                new GridColumn() { Field = "Dependencies", HeaderText = "Related Tasks", Width = "130" },
                new GridColumn() { Field = "Risks", HeaderText = "Risk Level", Width = "150" }, // Template logic not directly transferable
                new GridColumn() { Field = "Category", HeaderText = "Task Category", Width= "150" },
                new GridColumn() { Field = "Location", HeaderText = "Work Location", Width= "130" },
                new GridColumn() { Field = "TechStack", HeaderText = "Technology Stack", Width = "230" },
                new GridColumn() { Field = "Initiative", HeaderText = "Initiative",Width= "230" },
                new GridColumn() { Field = "EstimatedStoryPoints", HeaderText = "Story Points", Width="130" },
                new GridColumn() { Field = "PriorityLevel", HeaderText = "Strategic Priority", Width = "180" }
            };
            List<GanttColumn> ganttColumns = new List<GanttColumn>()
            {
                new GanttColumn() { Field = "Task", HeaderText = "Task Name", Width = "500" },
                new GanttColumn() { Field = "Assignee", HeaderText = "Assigned Person", Width = "200" }, // Template logic not directly transferable
                new GanttColumn() { Field = "StartDate", HeaderText = "Start Date", Width = "150", TextAlign = TextAlign.Right },
                new GanttColumn() { Field = "EndDate", HeaderText = "End Date", Width = "150",TextAlign = TextAlign.Right },
                new GanttColumn() { Field = "Priority", HeaderText = "Task Priority" }, // Template logic not directly transferable
                new GanttColumn() { Field = "Budget", HeaderText = $"Allocated Budget ({System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol})", Width = "230", Format = "C2", TextAlign = TextAlign.Right },
                new GanttColumn() { Field = "ActualCost", HeaderText = $"Spent Budget ({System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol})", Width = "230", Format = "C2", TextAlign = TextAlign.Right },
                new GanttColumn() { Field = "Progress", HeaderText = "Completion (%)", Width = "200" },
                new GanttColumn() { Field = "Status", HeaderText = "Status", Width = "180" },
                new GanttColumn() { Field = "Dependencies", HeaderText = "Related Tasks", Width = "200" },
                new GanttColumn() { Field = "Risks", HeaderText = "Risk Level" }, // Template logic not directly transferable
                new GanttColumn() { Field = "Category", HeaderText = "Task Category/Work Location", Width = "320" },
                new GanttColumn() { Field = "TechStack", HeaderText = "Technology Stack", Width = "350" },
                new GanttColumn() { Field = "Initiative", HeaderText = "Initiative/Story Points",Width = "300" },
                new GanttColumn() { Field = "PriorityLevel", HeaderText = "Strategic Priority", Width = "230" }
                #pragma warning restore BL0005 // Component parameter should not be set outside of its component.
            };
            ExportProperties.Columns = gridColumns;
            ExportProperties.IncludeTemplateColumn = true;
            PdfExportProperties.PageSize = Syncfusion.Blazor.Grids.PdfPageSize.Legal;
            PdfExportProperties.Columns = ganttColumns;
            if (args.Item.Id == "Settings")
            {
                IsSidebarToggled = !IsSidebarToggled;
                IsSideBar = true;
                settings = false;
            }
            if (args.Item.Id == "GanttOverview_excelexport")
            {
                await GanttInstance.ExportToExcelAsync(ExportProperties);
            }
            if (args.Item.Id == "GanttOverview_csvexport")
            {
                await GanttInstance.ExportToCsvAsync(ExportProperties);
            }
            if (args.Item.Id == "PdfExport")
            {
                await GanttInstance.ExportToPdfAsync(PdfExportProperties);
            }
            await Task.CompletedTask;
        }

        /// <summary>
        /// Customizes PDF taskbar labels and injects assignee images during export.
        /// </summary>
        private async void PdfQueryTaskbarInfoHandler(PdfQueryTaskbarInfoEventArgs<OverviewData.TaskData> args)
        {
            args.LabelSettings.TaskbarLabelValue = $"{args.Data.Progress}%";
            if (args.Data.Assignee != null)
            {
                int randomIndex = 0;
                if (args.Data.Id % 2 == 0)
                {
                    randomIndex = 0;
                }
                else if (args.Data.Id % 3 == 0)
                {
                    randomIndex = 1;
                }
                else if (args.Data.Id % 2 != 0)
                {
                    randomIndex = 2;
                }
                else if (args.Data.Id % 3 != 0)
                {
                    randomIndex = 3;
                }
                var randomItem = OverviewData.GetResources[randomIndex];

                string resourceName = randomItem.Name.Trim().Replace(" ", "").ToLower();
                if (pdfExportImage.TryGetValue(resourceName, out string? base64String))
                {
                    byte[] imageBytes = Convert.FromBase64String(base64String);
                    using MemoryStream imageStream = new MemoryStream(imageBytes);
                    PdfImage image = PdfImage.FromStream(imageStream);

                    args.LabelSettings.RightLabel = new PdfElementStyle { Image = image };
                }
            }
            await Task.CompletedTask;
        }

        /// <summary>
        /// Customizes PDF grid cell content and styles for specific columns.
        /// </summary>
        private async void PdfQueryCellInforHandler(Syncfusion.Blazor.Gantt.PdfQueryCellInfoEventArgs<OverviewData.TaskData> args)
        {
            var stringFormat = new PdfStringFormat()
            {
                Alignment = PdfTextAlignment.Left,
                LineAlignment = PdfVerticalAlignment.Top
            };

            var defaultFont = new PdfGridFont() { FontSize = 1.32, TextColor = "#242424" };

            switch (args.Column.Field)
            {
                case "Assignee":
                    args.Cell = new PdfGanttCell()
                    {
                        Value = $"{args.Data.Assignee}\n{args.Data.Department}",
                        CellStyle = new PdfElementStyle()
                        {
                            Font = new PdfGridFont() { FontSize = 1.32, TextColor = "Black" },
                            StringFormat = stringFormat
                        }
                    };
                    break;

                case "Budget":
                    args.Cell = new PdfGanttCell()
                    {
                        Value = args.Data.Budget?.ToString("C", System.Globalization.CultureInfo.CurrentCulture),
                        CellStyle = new PdfElementStyle() { Font = new PdfGridFont() { TextColor = "#107C10", FontSize = 1.32 } }
                    };
                    break;

                case "ActualCost":
                    args.Cell = new PdfGanttCell()
                    {
                        Value = args.Data.ActualCost?.ToString("C", System.Globalization.CultureInfo.CurrentCulture),
                        CellStyle = new PdfElementStyle() { Font = new PdfGridFont() { TextColor = "#C50F1F", FontSize = 1.32 } }
                    };
                    break;

                case "Progress":
                    args.Cell = new PdfGanttCell()
                    {
                        Value = args.Data.Progress.ToString() + "%"
                    };
                    break;

                case "Status":
                    string statusTextColor = args.Data.Status switch
                    {
                        "Completed" => "#107C10",
                        "In Progress" => "#31AFCC",
                        "On Track" => "#F7630C",
                        _ => "#C50F1F"
                    };
                    args.Cell = new PdfGanttCell()
                    {
                        CellStyle = new PdfElementStyle() { Font = new PdfGridFont() { TextColor = statusTextColor, FontSize = 1.32 } }
                    };
                    break;

                case "Risks":
                    string textColor = args.Data.Risks switch
                    {
                        "Low" => "#31AFCC",
                        "Medium" => "#F7630C",
                        _ => "#C50F1F"
                    };
                    args.Cell = new PdfGanttCell()
                    {
                        CellStyle = new PdfElementStyle() { Font = new PdfGridFont() { TextColor = textColor, FontSize = 1.32 } }
                    };
                    break;

                case "TechStack":
                    string value = args.Data.TechStack != null && args.Data.TechStack != "N/A" ? args.Data.TechStack.ToString().Replace(",", "  ") : string.Empty;
                    args.Cell = new PdfGanttCell()
                    {
                        Value = value
                    };
                    break;

                case "Category":
                    args.Cell = new PdfGanttCell()
                    {
                        Value = $"{args.Data.Category}  {args.Data.Location}",
                    };
                    break;

                case "Initiative":
                    args.Cell = new PdfGanttCell()
                    {
                        Value = $"{args.Data.Initiative}  {args.Data.EstimatedStoryPoints}"
                    };
                    break;
            }
            await Task.CompletedTask;
        }

        /// <summary>
        /// Populates the settings ListView data items for the sidebar.
        /// </summary>
        private void UpdateDataModel()
        {
            ListViewData.Add(new DataModel
            {
                Id = "01",
                Text = "RowHeight",
                Order = 1,
            });
            ListViewData.Add(new DataModel
            {
                Id = "02",
                Text = "Show grid Lines",
                Order = 1,
            });
            ListViewData.Add(new DataModel
            {
                Id = "02",
                Text = "Event markers",
                Order = 1,
            });
            ListViewData.Add(new DataModel
            {
                Id = "02",
                Text = "Show dependencies",
                Order = 1,
            });
            ListViewData.Add(new DataModel
            {
                Id = "02",
                Text = "Show task labels",
                Order = 1,
            });
            ListViewData.Add(new DataModel
            {
                Id = "03",
                Text = "Work Week",
                Category = "Scheduling Settings",
                Order = 1,
            });
            ListViewData.Add(new DataModel
            {
                Id = "03",
                Text = "Work Time Range",
                Category = "Scheduling Settings",
                Order = 1,
            });
            ListViewData.Add(new DataModel
            {
                Id = "02",
                Text = "TimeLine Cell Unit",
                Category = "Scheduling Settings",
                Order = 1,
            });
            ListViewData.Add(new DataModel
            {
                Id = "04",
                Text = "View Type",
                Category = "View settings",
                Order = 2,
            });
            ListViewData.Add(new DataModel
            {
                Id = "04",
                Text = "View Mode",
                Category = "View settings",
                Order = 2,
            });
            ListViewData.Add(new DataModel
            {
                Id = "02",
                Text = "Enable critical path",
                Order = 1,
            });
            ListViewData.Add(new DataModel
            {
                Id = "02",
                Text = "Custom scheduling",
                Order = 1,
            });
        }

        /// <summary>
        /// Applies theme-specific settings based on the current URI.
        /// </summary>
        private void UpdateTheme(string currentUri)
        {
            if (currentUri.Contains("fluent-dark"))
            {
                CurrentTheme = Theme.FluentDark;
                filterBackgroundColor = "#201f1e";
                filterHeaderFontSize = "14px";
                filterHeaderFontSizeTouch = "16px";
                filterHeaderHeight = "50px";
                filterHeaderHeightTouch = "56px";
                filterHeaderFontWeight = "600";
            }
            else if (currentUri.Contains("fluent"))
            {
                CurrentTheme = Theme.Fluent;
                filterBackgroundColor = "#faf9f8";
                labelTextColor = "#201f1e";
                filterHeaderFontSize = "14px";
                filterHeaderFontSizeTouch = "16px";
                filterHeaderHeight = "50px";
                filterHeaderHeightTouch = "56px";
                filterHeaderFontWeight = "600";
            }
            else if (currentUri.Contains("fabric-dark"))
            {
                CurrentTheme = Theme.FabricDark;
                filterBackgroundColor = "#333232";
                labelTextColor = "#f3f2f1";
            }
            else if (currentUri.Contains("fabric"))
            {
                CurrentTheme = Theme.Fabric;
                filterBackgroundColor = "#f4f4f4";
            }
            else if (currentUri.Contains("bootstrap5-dark"))
            {
                CurrentTheme = Theme.Bootstrap5Dark;
                filterBackgroundColor = "#282d31";
                labelTextColor = "#fff";
                filterHeaderFontSize = "14px";
                filterHeaderFontSizeTouch = "14px";
                filterHeaderHeight = "40px";
                filterHeaderHeightTouch = "48px";
                filterHeaderFontWeight = "400";
            }
            else if (currentUri.Contains("bootstrap-dark"))
            {
                CurrentTheme = Theme.BootstrapDark;
                filterBackgroundColor = "#393939";
            }
            else if (currentUri.Contains("bootstrap5"))
            {
                CurrentTheme = Theme.Bootstrap5;
                filterBackgroundColor = "#f8f9fa";
                labelTextColor = "#212529";
                filterHeaderFontSize = "14px";
                filterHeaderFontSizeTouch = "14px";
                filterHeaderHeight = "40px";
                filterHeaderHeightTouch = "48px";
                filterHeaderFontWeight = "400";
            }
            else if (currentUri.Contains("bootstrap4"))
            {
                CurrentTheme = Theme.Bootstrap4;
                filterBackgroundColor = "#e9ecef";
            }
            else if (currentUri.Contains("bootstrap"))
            {
                CurrentTheme = Theme.Bootstrap;
                filterBackgroundColor = "#eee";
            }
            else if (currentUri.Contains("highcontrast"))
            {
                CurrentTheme = Theme.HighContrast;
                filterBackgroundColor = "#000";
                labelTextColor = "#fff";
            }
            else if (currentUri.Contains("tailwind-dark"))
            {
                CurrentTheme = Theme.TailwindDark;
                filterBackgroundColor = "#232e3e";
                labelTextColor = "#fff";
                filterHeaderFontSize = "14px";
                filterHeaderFontSizeTouch = "16px";
                filterHeaderHeight = "44px";
                filterHeaderHeightTouch = "52px";
                filterHeaderFontWeight = "400";
            }
            else if (currentUri.Contains("tailwind"))
            {
                CurrentTheme = Theme.Tailwind;
                filterBackgroundColor = "#f9fafb";
                labelTextColor = "rgb(17, 24, 39)";
                filterHeaderFontSize = "14px";
                filterHeaderFontSizeTouch = "16px";
                filterHeaderHeight = "44px";
                filterHeaderHeightTouch = "52px";
                filterHeaderFontWeight = "400";
            }
            else if (currentUri.Contains("material-dark"))
            {
                CurrentTheme = Theme.MaterialDark;
                filterHeaderFontSize = "16px";
                filterHeaderFontSizeTouch = "18px";
                filterHeaderHeight = "52px";
                filterHeaderHeightTouch = "58px";
                filterBackgroundColor = "linear-gradient(0deg, rgba(103, 80, 164, 0.05), rgba(103, 80, 164, 0.05)),rgba(28, 27, 31)";
                labelTextColor = "rgba(230, 225, 229)";
                filterHeaderFontWeight = "400";
            }
            else if (currentUri.Contains("material"))
            {
                CurrentTheme = Theme.Material;
                filterHeaderFontSize = "16px";
                filterHeaderFontSizeTouch = "18px";
                filterHeaderHeight = "52px";
                filterHeaderHeightTouch = "58px";
                filterBackgroundColor = "linear-gradient(0deg, rgba(208, 188, 255, 0.05), rgba(208, 188, 255, 0.05)),rgba(255, 255, 255)";
                labelTextColor = "#404042";
                filterHeaderFontWeight = "400";
            }
        }

        /// <summary>
        /// Converts resource images to Base64 via JS interop and caches them for PDF export.
        /// </summary>
        private async void ConvertImageToBase64(NavigationManager navigationManager, IJSRuntime jSRuntime)
        {
            var resourceNames = ResourceCollection
        .Where(task => !string.IsNullOrEmpty(task.Name))
        .Select(task => task.Name.Trim().Replace(" ", "").ToLower())
        .Distinct() // Ensure uniqueness
        .ToList();

            foreach (var resourceName in resourceNames)
            {
                var filePath = navigationManager.ToAbsoluteUri($"{SampleService.WebAssetsPath}images/gantt/{resourceName}.png").ToString();

                try
                {
                    var base64String = await jSRuntime.InvokeAsync<string>("convertGanttImageBaseUrl", filePath);
                    if (!string.IsNullOrEmpty(base64String))
                    {
                        pdfExportImage[resourceName] = base64String;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading image {resourceName}: {ex.Message}");
                }
            }
        }
    }
}
