#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Overview.Pages;
using Syncfusion.Blazor.Buttons;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Syncfusion.Blazor.Grids;
using System.IO;
using System.Net;
using Syncfusion.PdfExport;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Linq;
namespace BlazorDemos.Pages.GanttChart.GanttChart
{
    public partial class Overview
    {
        public bool IsSidebarToggled { get; set; }
        public SfSwitch<bool?> SidebarSwitch { get; set; }
        public bool IsSideBar { get; set; } = false;
        public bool Settings { get; set; } = true;
        private int RowHeightValue { get; set; } = 45;
        private int TaskbarHeightValue { get; set; } = 24;
        private string TaskBarHeight { get; set; } = "24px";
        private string MarginValue { get; set; } = "0px";
        private string TopPosition { get; set; } = "4px";
        private string LabelHeight { get; set; } = "38px";
        private int DefaultUnitWidth { get; set; } = 75;
        private string MarginTop { get; set; } = "3px";
        private string ManualTaskbarWidth { get; set; } = "11px";
        private SfGantt<OverviewData.TaskData> GanttInstance { get; set; }
        public List<OverviewData.TaskData> TaskCollection { get; set; }
        private DateTime KickOffDate = new DateTime(2025, 2, 11);
        private DateTime DesignCompletionDate = new DateTime(2025, 5, 15);
        private DateTime DeploymentDate = new DateTime(2025, 11, 17);
        public Theme CurrentTheme { get; set; }
        public string CurrentUri { get; set; }
        public bool Checked { get; set; } = true;
        public bool ShowDependency { get; set; } = true;
        private List<OverviewData.ResourceInfoModel> ResourceCollection { get; set; }
        private List<string> Status { get; set; } = new List<string>() { "Open", "Inprogress", "On Hold", "Complete" };
        private List<string> Priority { get; set; } = new List<string>() { "Low", "Normal", "High", "Critical" };
        public string BorderRadius { get; set; } = "4px";
        public string TextColor { get; set; }
        public string BackgroundColor { get; set; }
        private List<Theme> AvailableThemes { get; set; } = new List<Theme>() { Theme.Fluent, Theme.Fabric, Theme.Bootstrap5, Theme.Bootstrap, Theme.Bootstrap4, Theme.Tailwind, Theme.Material, Theme.Tailwind3 };
        private string DropdownWidth { get; set; } = "80px";
        //***API properties
        public Syncfusion.Blazor.Gantt.GridLine gridlines = Syncfusion.Blazor.Gantt.GridLine.Both;
        private ViewType SelectedViewType { get; set; } = ViewType.ProjectView;
        public string SelectedViewTypes { get; set; } = "Project view";
        public string DurationUnitValue { get; set; } = "Day";
        public Syncfusion.Blazor.Gantt.DurationUnit DurationValue { get; set; } = DurationUnit.Day;
        private bool IsEventMarkerVisible { get; set; } = false;
        private bool IsTaskLabelsVisible { get; set; } = true;
        public int CurrentValue { get; set; }
        public int PreviousValue { get; set; } = 11;
        public int BindValue { get; set; } = 11;
        public string CurrentHeaderTitle { get; set; } = "Project Settings";
        public string[] WorkWeekDays { get; set; } = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        private string FilterHeaderFontSize { get; set; }
        private string FilterHeaderFontSizeTouch { get; set; }
        private string FilterHeaderHeight { get; set; }
        private string FilterHeaderHeightTouch { get; set; }
        private string FilterHeaderFontWeight { get; set; }
        private string FilterBackgroundColor { get; set; }
        private string LabelTextColor { get; set; }
        private bool IsDarkMode => CurrentUri.Contains("dark") || CurrentUri.Contains("highcontrast");
        private static List<OverviewData.AssignmentModel> AssignmentCollection { get; set; }
        private List<OverviewData.SegmentModel> SegmentCollection { get; set; }
        private bool IsCustomSchedulingEnabled { get; set; }
        private bool IsCriticalPathEnabled { get; set; }
        private DateTime? ProjectStartDate { get; set; }
        private DateTime? ProjectEndDate { get; set; }
        public List<Object> Toolbaritems { get; set; } = new List<Object>() { "ExpandAll", "CollapseAll", "ZoomIn", "ZoomOut", "ZoomToFit", "Indent", "Outdent", "ExcelExport", new ToolbarItem() { TooltipText = "PdfExport", Id = "PdfExport", PrefixIcon = "e-pdfexport" }, new ToolbarItem() { Text = "Settings", TooltipText = "Settings", Id = "Settings", PrefixIcon = "e-settings-icon", Align = ItemAlign.Right } };
        // Specifies the ListView datasource.
        public List<DataModel> ListViewData { get; set; } = new List<DataModel>();
        private Dictionary<string, string> pdfExportImage = new Dictionary<string, string>();
        // Specifies the model class for ListView datasource.

        public class DataModel
        {
            public string Id { get; set; }
            public string Text { get; set; }
            public string Category { get; set; }
            public int Order { get; set; }
            public List<DataModel> Child { get; set; }
        }

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
            Settings = true;
        }

        private void GridLines(ChangeEventArgs<bool> args)
        {
            if (args.Checked == true)
            {
                gridlines = Syncfusion.Blazor.Gantt.GridLine.Both;
                Checked = true;
            }
            else
            {
                gridlines = Syncfusion.Blazor.Gantt.GridLine.Vertical;
                Checked = false;
            }
            Settings = true;
        }

        private void EventMarkerEvent(ChangeEventArgs<bool?> args)
        {
            if (args.Checked == true)
            {
                IsEventMarkerVisible = true;
            }
            else
            {
                IsEventMarkerVisible = false;
            }
            Settings = true;
        }

        private void ShowDependencies(ChangeEventArgs<bool> args)
        {
            if (args.Checked == true)
            {
                ShowDependency = true;
            }
            else
            {
                ShowDependency = false;
            }
            Settings = true;
        }

        private void ShowTaskLabels(ChangeEventArgs<bool> args)
        {
            if (args.Checked == true)
            {
                IsTaskLabelsVisible = true;
            }
            else
            {
                IsTaskLabelsVisible = false;
            }
            Settings = true;
        }

        private async Task CriticalPathEnable(ChangeEventArgs<bool?> args)
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
            Settings = true;
            await Task.CompletedTask;
        }

        private async Task EnableCustomScheduling(ChangeEventArgs<bool?> args)
        {
            if (args.Checked == true)
            {
                IsCustomSchedulingEnabled = true;
            }
            else
            {
                IsCustomSchedulingEnabled = false;
            }
            Settings = true;
            await GanttInstance.RefreshAsync();
            await Task.CompletedTask;
        }

        public void OnChange(Syncfusion.Blazor.Inputs.ChangeEventArgs<int?> args)
        {
            DefaultUnitWidth = args.Value != null ? (int)args.Value : 33;
        }

        private void rowheightchange(int value)
        {
            RowHeightValue = value;
        }

        public void Close()
        {
            IsSidebarToggled = false;
            Settings = true;
        }

        public class WorkWeek
        {
            public string Week { get; set; }
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
            public string Unit { get; set; }
        }

        public List<Duration> Duration1 = new List<Duration>
        {
            new Duration() { Unit = "Hour"},
            new Duration() { Unit = "Minute"},
            new Duration() { Unit = "Day"}
        };

        public class ViewTypes
        {
            public string Type { get; set; }
        }

        public List<ViewTypes> Types = new List<ViewTypes>
        {
            new ViewTypes() { Type = "Resource view"},
            new ViewTypes() { Type = "Project view"}

        };

        private void ValueChangeHandler(MultiSelectChangeEventArgs<string[]> args)
        {
            if (args.Value == null)
            {
                WorkWeekDays = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            }
            else
            {
                WorkWeekDays = args.Value;
            }
        }

        private async void ValueChangeHandler2(ChangeEventArgs<string, Duration> args)
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
            public string ID { get; set; }
            public string Text { get; set; }
        }

        public List<SplitterView> SplitterViews = new List<SplitterView>
        {
            new SplitterView() { ID= "Default", Text= "Default" },
            new SplitterView() { ID= "Grid", Text= "Grid" },
            new SplitterView() { ID= "Chart", Text= "Chart" },
        };

        public async void OnChange(ChangeEventArgs<string, SplitterView> args)
        {
            if (args.Value == "Grid")
            {
                await this.GanttInstance.SetSplitterPositionAsync(Syncfusion.Blazor.Gantt.SplitterView.Grid);

            }
            else if (args.Value == "Chart")
            {
                await this.GanttInstance.SetSplitterPositionAsync(Syncfusion.Blazor.Gantt.SplitterView.Chart);
            }
            else
            {
                await this.GanttInstance.SetSplitterPositionAsync(Syncfusion.Blazor.Gantt.SplitterView.Default);
                DropdownWidth = "90px";
            }
            await GanttInstance.RefreshAsync();
        }
        public async Task RowSelectedHandler()
        {
            IsSidebarToggled = !IsSidebarToggled;
            IsSideBar = false;
            await Task.CompletedTask;
        }
        public async Task ToolbarClickHandler(ClickEventArgs args)
        {
            Syncfusion.Blazor.Grids.ExcelExportProperties ExportProperties = new Syncfusion.Blazor.Grids.ExcelExportProperties();
            Syncfusion.Blazor.Gantt.GanttPdfExportProperties PdfExportProperties = new Syncfusion.Blazor.Gantt.GanttPdfExportProperties();
            List<GridColumn> gridColumns = new List<GridColumn>() {
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
            };
            ExportProperties.Columns = gridColumns;
            ExportProperties.IncludeTemplateColumn = true;
            PdfExportProperties.PageSize = Syncfusion.Blazor.Grids.PdfPageSize.Legal;
            PdfExportProperties.Columns = ganttColumns;
            if (args.Item.Id == "Settings")
            {
                IsSidebarToggled = !IsSidebarToggled;
                IsSideBar = true;
                Settings = false;
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
                if (pdfExportImage.TryGetValue(resourceName, out string base64String))
                {
                    byte[] imageBytes = Convert.FromBase64String(base64String);
                    using MemoryStream imageStream = new MemoryStream(imageBytes);
                    PdfImage image = PdfImage.FromStream(imageStream);

                    args.LabelSettings.RightLabel = new PdfElementStyle { Image = image };
                }
            }
            await Task.CompletedTask;
        }
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
        private string GetContentStyles(string type, string status)
        {
            var tailwind3Colors = new Dictionary<string, (string BackgroundColor, string TextColor)>
            {
                ["In Progress"] = ("#ECFEFF", "#0E7490"),
                ["Open"] = ("#EF4444", "#FFFFFF"),
                ["On Hold"] = ("#F3F4F6", "#374151"),
                ["Completed"] = ("#F0FDF4", "#15803D"),
                ["High"] = ("#FEF2F2", "#DC2626"),
                ["Low"] = ("#FFF7ED", "#C2410C"),
                ["Normal"] = ("#E0E7FF", "#4F46E5"),
                ["Critical"] = ("#FEF2F2", "#DC2626")
            };

            bool isTailwind3 = CurrentUri.Contains("tailwind3") || CurrentUri.Contains("tailwind3-dark");
            bool themeAvailable = AvailableThemes.Contains(this.CurrentTheme);

            if (isTailwind3 && tailwind3Colors.TryGetValue(status, out var colors))
            {
                (BackgroundColor, TextColor) = colors;
            }
            else
            {
                (BackgroundColor, TextColor) = type switch
                {
                    "status" => status switch
                    {
                        "In Progress" => themeAvailable ? ("#DFECFF", "#006AA6") : ("#2D3E57", "#34B6FF"),
                        "Open" => ("red", "white"),
                        "On Hold" => themeAvailable ? ("#E4E4E7", "#766B7C") : ("#3C3B43", "#CDCBD7"),
                        "Completed" => themeAvailable ? ("#DFFFE2", "#00A653") : ("#16501C", "#92FFC8"),
                        "High" => themeAvailable ? ("#FFEBE9", "#FF3740") : ("#48211D", "#FFB5B8"),
                        _ => ("#FFFFF0", "#000000")
                    },
                    "priority" => status switch
                    {
                        "Low" => themeAvailable ? ("#FFF6D1", "#70722B") : ("#473F1E", "#FDFF88"),
                        "Normal" => themeAvailable ? ("#F5DFFF", "#7100A6") : ("#4D2F5A", "#E3A9FF"),
                        "Critical" => themeAvailable ? ("#FFEBE9", "#FF3740") : ("#48211D", "#FFB5B8"),
                        "High" => themeAvailable ? ("#FFEBE9", "#FF3740") : ("#48211D", "#FFB5B8"),
                        _ => ("#FFFFF0", "#000000")
                    },
                    _ => ("#FFFFF0", "#000000")
                };
            }

            return $"background:{BackgroundColor};color:{TextColor};padding: 5px 12px; border-radius: 24px";
        }

        private string GetStatusContentStyles(string status) => GetContentStyles("status", status);

        private string GetPriorityContentStyle(string status) => GetContentStyles("priority", status);

        private IGanttTaskModel<OverviewData.TaskData> GetTaskData(OverviewData.TaskData data)
        {
            return GanttInstance.GetRowTaskModel(data);
        }

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

        private void UpdateTheme(string currentUri)
        {
            if (currentUri.Contains("fluent-dark"))
            {
                CurrentTheme = Theme.FluentDark;
                FilterBackgroundColor = "#201f1e";
                FilterHeaderFontSize = "14px";
                FilterHeaderFontSizeTouch = "16px";
                FilterHeaderHeight = "50px";
                FilterHeaderHeightTouch = "56px";
                FilterHeaderFontWeight = "600";
            }
            else if (currentUri.Contains("fluent"))
            {
                CurrentTheme = Theme.Fluent;
                FilterBackgroundColor = "#faf9f8";
                LabelTextColor = "#201f1e";
                FilterHeaderFontSize = "14px";
                FilterHeaderFontSizeTouch = "16px";
                FilterHeaderHeight = "50px";
                FilterHeaderHeightTouch = "56px";
                FilterHeaderFontWeight = "600";
            }
            else if (currentUri.Contains("fabric-dark"))
            {
                CurrentTheme = Theme.FabricDark;
                FilterBackgroundColor = "#333232";
                LabelTextColor = "#f3f2f1";
            }
            else if (currentUri.Contains("fabric"))
            {
                CurrentTheme = Theme.Fabric;
                FilterBackgroundColor = "#f4f4f4";
            }
            else if (currentUri.Contains("bootstrap5-dark"))
            {
                CurrentTheme = Theme.Bootstrap5Dark;
                FilterBackgroundColor = "#282d31";
                LabelTextColor = "#fff";
                FilterHeaderFontSize = "14px";
                FilterHeaderFontSizeTouch = "14px";
                FilterHeaderHeight = "40px";
                FilterHeaderHeightTouch = "48px";
                FilterHeaderFontWeight = "400";
            }
            else if (currentUri.Contains("bootstrap-dark"))
            {
                CurrentTheme = Theme.BootstrapDark;
                FilterBackgroundColor = "#393939";
            }
            else if (currentUri.Contains("bootstrap5"))
            {
                CurrentTheme = Theme.Bootstrap5;
                FilterBackgroundColor = "#f8f9fa";
                LabelTextColor = "#212529";
                FilterHeaderFontSize = "14px";
                FilterHeaderFontSizeTouch = "14px";
                FilterHeaderHeight = "40px";
                FilterHeaderHeightTouch = "48px";
                FilterHeaderFontWeight = "400";
            }
            else if (currentUri.Contains("bootstrap4"))
            {
                CurrentTheme = Theme.Bootstrap4;
                FilterBackgroundColor = "#e9ecef";
            }
            else if (currentUri.Contains("bootstrap"))
            {
                CurrentTheme = Theme.Bootstrap;
                FilterBackgroundColor = "#eee";
            }
            else if (currentUri.Contains("highcontrast"))
            {
                CurrentTheme = Theme.HighContrast;
                FilterBackgroundColor = "#000";
                LabelTextColor = "#fff";
            }
            else if (currentUri.Contains("tailwind-dark"))
            {
                CurrentTheme = Theme.TailwindDark;
                FilterBackgroundColor = "#232e3e";
                LabelTextColor = "#fff";
                FilterHeaderFontSize = "14px";
                FilterHeaderFontSizeTouch = "16px";
                FilterHeaderHeight = "44px";
                FilterHeaderHeightTouch = "52px";
                FilterHeaderFontWeight = "400";
            }
            else if (currentUri.Contains("tailwind"))
            {
                CurrentTheme = Theme.Tailwind;
                FilterBackgroundColor = "#f9fafb";
                LabelTextColor = "rgb(17, 24, 39)";
                FilterHeaderFontSize = "14px";
                FilterHeaderFontSizeTouch = "16px";
                FilterHeaderHeight = "44px";
                FilterHeaderHeightTouch = "52px";
                FilterHeaderFontWeight = "400";
            }
            else if (currentUri.Contains("material-dark"))
            {
                CurrentTheme = Theme.MaterialDark;
                FilterHeaderFontSize = "16px";
                FilterHeaderFontSizeTouch = "18px";
                FilterHeaderHeight = "52px";
                FilterHeaderHeightTouch = "58px";
                FilterBackgroundColor = "linear-gradient(0deg, rgba(103, 80, 164, 0.05), rgba(103, 80, 164, 0.05)),rgba(28, 27, 31)";
                LabelTextColor = "rgba(230, 225, 229)";
                FilterHeaderFontWeight = "400";
            }
            else if (currentUri.Contains("material"))
            {
                CurrentTheme = Theme.Material;
                FilterHeaderFontSize = "16px";
                FilterHeaderFontSizeTouch = "18px";
                FilterHeaderHeight = "52px";
                FilterHeaderHeightTouch = "58px";
                FilterBackgroundColor = "linear-gradient(0deg, rgba(208, 188, 255, 0.05), rgba(208, 188, 255, 0.05)),rgba(255, 255, 255)";
                LabelTextColor = "#404042";
                FilterHeaderFontWeight = "400";
            }
        }

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
