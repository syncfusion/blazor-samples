#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
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
using System.Linq;
using System.Text;
using Syncfusion.PdfExport;
using System.Threading.Tasks;
using Syncfusion.Blazor.Grids;

namespace BlazorDemos.Pages.GanttChart.GanttChart
{
    public partial class Overview
    {
        public bool SidebarToggle;
        SfSwitch<bool?> SwitchObj;
        public bool IsSideBar = false;
        public bool Settings = true;
        private int RowHeightValue { get; set; } = 40;
        private int TaskbarHeightValue { get; set; } = 24;
        private string TaskBarHeight = "24px";
        private string MarginValue = "0px";
        private string TopPosition = "4px";
        private int DefaultUnitWidth = 75;
        private SfGantt<OverviewData.TaskData> Gantt;
        public List<OverviewData.TaskData> TaskCollection { get; set; }
        private DateTime VolumeOneRelease = new DateTime(2022, 04, 04);
        private DateTime VolumeTwoRelease = new DateTime(2022, 06, 30);
        private DateTime VolumeThreeRelease = new DateTime(2022, 09, 29);
        private DateTime Holiday1 = new DateTime(2021, 12, 25);
        private DateTime Holiday2 = new DateTime(2021, 12, 26);
        private DateTime Holiday3 = new DateTime(2022, 01, 01);
        private DateTime Holiday4 = new DateTime(2022, 01, 01);
        public Theme CurrentTheme { get; set; }
        public string currentUri;
        public bool ShowDependency { get; set; } = true;
        private List<OverviewData.ResourceInfoModel> ResourceCollection { get; set; }
        private List<string> Status = new List<string>() { "Open", "Inprogress", "On Hold", "Complete" };
        private List<string> Priority = new List<string>() { "Low", "Normal", "High", "Critical" };
        public string borderRadius = "4px";
        public string statusStyleColor;
        public string statusContentstyleColor;
        public string priorityContentStyle;
        public string priorityStyle;
        private List<Theme> ThemeCollection = new List<Theme>() { Theme.Fluent, Theme.Fabric, Theme.Bootstrap5, Theme.Bootstrap, Theme.Bootstrap4, Theme.Tailwind, Theme.Material };
        public string progressLeft = "0px";
        private string dropDownWidth { get; set; } = "80px";
        //***API properties
        public Syncfusion.Blazor.Gantt.GridLine gridlines { get; set; } = Syncfusion.Blazor.Gantt.GridLine.Vertical;
        private ViewType viewType { get; set; } = ViewType.ProjectView;
        public string viewTypes { get; set; } = "Project view";
        public string DurationUnitValue { get; set; } = "Day";
        public Syncfusion.Blazor.Gantt.DurationUnit DurationValue { get; set; } = DurationUnit.Day;
        private bool EventMarker { get; set; } = false;
        private bool TaskLabels { get; set; } = false;
        public int CurrentValue { get; set; }
        public int PreviousValue { get; set; } = 11;
        public int BindValue { get; set; } = 11;
        string CurrentHeaderTitle = "Project Settings";
        public string[] week = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        private string filterHeaderFontSize { get; set; }
        private string filterHeaderFontSizeTouch { get; set; }
        private string filteraHeaderHeight { get; set; }
        private string filteraHeaderHeightTouch { get; set; }
        private string filterHeaderFontWeight { get; set; }
        private string filterBackground { get; set; }
        private string labelTextColor { get; set; }
        private static List<OverviewData.AssignmentModel> AssignmentCollection { get; set; }
        private List<OverviewData.SegmentModel> SegmentCollection { get; set; }
        private bool CustomScheduling { get; set; }
        private bool EnableCriticalPath { get; set; }
        private DateTime? ProjectStartDate { get; set; }
        private DateTime? ProjectEndDate { get; set; }
        public List<Object> Toolbaritems = new List<Object>() { "ExpandAll", "CollapseAll", "ZoomIn", "ZoomOut", "ZoomToFit", "Indent", "Outdent", "ExcelExport", new ToolbarItem() { TooltipText="PdfExport", Id = "PdfExport", PrefixIcon = "e-pdfexport" }, new ToolbarItem() { Text = "Settings", TooltipText = "Settings", Id = "Settings", PrefixIcon = "e-settings-icon", Align = ItemAlign.Right } };
        // Specifies the ListView datasource.
        List<DataModel> ListData = new List<DataModel>();
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
                viewType = ViewType.ResourceView;
                viewTypes = viewType.ToString();
            }
            else
            {
                viewType = ViewType.ProjectView;
                viewTypes = viewType.ToString();
            }
            StateHasChanged();
            Settings = true;
        }

        private void GridLines(ChangeEventArgs<bool?> args)
        {
            if (args.Checked == true)
            {
                gridlines = Syncfusion.Blazor.Gantt.GridLine.Both;
            }
            else
            {
                gridlines = Syncfusion.Blazor.Gantt.GridLine.Vertical;
            }
            Settings = true;
            Gantt.RefreshAsync();
        }

        private void EventMarkerEvent(ChangeEventArgs<bool?> args)
        {
            if (args.Checked == true)
            {
                EventMarker = true;
            }
            else
            {
                EventMarker = false;
            }
            Settings = true;
            Gantt.RefreshAsync();
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
            Gantt.RefreshAsync();
        }

        private void ShowTaskLabels(ChangeEventArgs<bool?> args)
        {
            if (args.Checked == true)
            {
                TaskLabels = true;
            }
            else
            {
                TaskLabels = false;
            }
            Settings = true;
            Gantt.RefreshAsync();
        }

        private async Task CriticalPathEnable(ChangeEventArgs<bool?> args)
        {
            if (args.Checked == true)
            {
                ProjectStartDate = null;
                ProjectEndDate = null;
                EnableCriticalPath = true;
            }
            else
            {
                ProjectStartDate = new DateTime(2021, 12, 19);
                ProjectEndDate = new DateTime(2022, 07, 8);
                EnableCriticalPath = false;
            }
            Settings = true;
            
            await Gantt.RefreshAsync();
            await Task.CompletedTask;
        }

        private async Task EnableCustomScheduling(ChangeEventArgs<bool?> args)
        {
            if (args.Checked == true)
            {
                CustomScheduling = true;
            }
            else
            {
                CustomScheduling = false;
            }
            Settings = true;
            await Gantt.RefreshAsync();
            await Task.CompletedTask;
        }

        public void OnChange(Syncfusion.Blazor.Inputs.ChangeEventArgs<int?> args)
        {
            DefaultUnitWidth = (int)args.Value;
        }

        private void rowheightchange(int value)
        {
            RowHeightValue = value;
            if (value == 40)
            {
                TaskbarHeightValue = 24;
                TaskBarHeight = "24px";
                MarginValue = "0px";
                TopPosition = "4px";
            }
            else if (value == 50)
            {
                TaskbarHeightValue = 32;
                TaskBarHeight = "32px";
                MarginValue = "0px";
                TopPosition = "7px";
            }
            else if (value == 60)
            {
                TaskbarHeightValue = 40;
                TaskBarHeight = "40px";
                MarginValue = "4px";
                TopPosition = "10px";
            }
        }

        public void Close()
        {
            SidebarToggle = false;
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
                week = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            }
            else
            {
                week = args.Value;
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
            await Gantt.RefreshAsync();
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
                await this.Gantt.SetSplitterPositionAsync(Syncfusion.Blazor.Gantt.SplitterView.Grid);

            }
            else if (args.Value == "Chart")
            {
                await this.Gantt.SetSplitterPositionAsync(Syncfusion.Blazor.Gantt.SplitterView.Chart);
            }
            else
            {
                await this.Gantt.SetSplitterPositionAsync(Syncfusion.Blazor.Gantt.SplitterView.Default);
                dropDownWidth = "90px";
            }
            await Gantt.RefreshAsync();
        }

        public async Task ToolbarClickHandler(ClickEventArgs args)
        {
            Syncfusion.Blazor.Grids.ExcelExportProperties ExportProperties = new Syncfusion.Blazor.Grids.ExcelExportProperties();
            Syncfusion.Blazor.Gantt.GanttPdfExportProperties PdfExportProperties = new Syncfusion.Blazor.Gantt.GanttPdfExportProperties();
            List<GridColumn> gridColumns = new List<GridColumn>() { 
            new GridColumn(){ Field = "TaskId", HeaderText = "Id" },
            new GridColumn(){Field = "TaskName", HeaderText="Product Release"},
            new GridColumn(){ Field = "Work", HeaderText = "Planned Hours" },
            new GridColumn(){Field = "TimeLog", HeaderText="Work Log"}
            };
            ExportProperties.Columns = gridColumns;
            PdfExportProperties.PageSize = Syncfusion.Blazor.Grids.PdfPageSize.Legal;
            PdfExportProperties.Columns = Gantt.Columns;
            if (args.Item.Id == "Settings")
            {
                SidebarToggle = !SidebarToggle;
                IsSideBar = true;
                Settings = false;
            }
            if (args.Item.Id == "GanttOverview_excelexport")
            {
                await Gantt.ExportToExcelAsync(ExportProperties);
            }
            if (args.Item.Id == "GanttOverview_csvexport")
            {
                await Gantt.ExportToCsvAsync(ExportProperties);
            }
            if(args.Item.Id == "PdfExport")
            {
                await Gantt.ExportToPdfAsync(PdfExportProperties);
            }
            await Task.CompletedTask;
        }

        private string GetStatusContentStyles(string status)
        {
            switch (status)
            {
                case "In Progress":
                    statusStyleColor = ThemeCollection.Contains(this.CurrentTheme) ? "#DFECFF" : "#2D3E57";
                    statusContentstyleColor = ThemeCollection.Contains(this.CurrentTheme) ? "#006AA6" : "#34B6FF";

                    break;
                case "Open":
                    statusStyleColor = "red";
                    statusContentstyleColor = "white";
                    break;
                case "On Hold":
                    statusStyleColor = ThemeCollection.Contains(this.CurrentTheme) ? "#E4E4E7" : "#3C3B43";
                    statusContentstyleColor = ThemeCollection.Contains(this.CurrentTheme) ? "#766B7C" : "#CDCBD7";
                    break;
                case "Completed":
                    statusStyleColor = ThemeCollection.Contains(this.CurrentTheme) ? "#DFFFE2" : "#16501C";
                    statusContentstyleColor = ThemeCollection.Contains(this.CurrentTheme) ? "#00A653" : "#92FFC8";
                    break;
                case "High":
                    statusStyleColor = ThemeCollection.Contains(this.CurrentTheme) ? "#FFEBE9" : "#48211D";
                    statusContentstyleColor = ThemeCollection.Contains(this.CurrentTheme) ? "#FF3740" : "#FFB5B8";
                    break;
            }
            return $"background:{statusStyleColor};color:{statusContentstyleColor};padding: 5px 12px; border-radius: 24px";
        }

        private string GetPriorityContentStyle(string status)
        {
            switch (status)
            {
                case "Low":
                    priorityStyle = ThemeCollection.Contains(this.CurrentTheme) ? "#FFF6D1" : "#473F1E";
                    priorityContentStyle = ThemeCollection.Contains(this.CurrentTheme) ? "#70722B" : "#FDFF88";
                    break;
                case "Normal":
                    priorityStyle = ThemeCollection.Contains(this.CurrentTheme) ? "#F5DFFF" : "#4D2F5A";
                    priorityContentStyle = ThemeCollection.Contains(this.CurrentTheme) ? "#7100A6" : "#E3A9FF";
                    break;
                case "Critical":
                    priorityStyle = ThemeCollection.Contains(this.CurrentTheme) ? "#FFEBE9" : "#48211D";
                    priorityContentStyle = ThemeCollection.Contains(this.CurrentTheme) ? "#FF3740" : "#FFB5B8";
                    break;
                case "High":
                    priorityStyle = ThemeCollection.Contains(this.CurrentTheme) ? "#FFEBE9" : "#48211D";
                    priorityContentStyle = ThemeCollection.Contains(this.CurrentTheme) ? "#FF3740" : "#FFB5B8";
                    break;
            }
            return $"background:{priorityStyle};color:{priorityContentStyle};padding: 5px 12px; border-radius: 24px";
        }

        private IGanttTaskModel<OverviewData.TaskData> GetTaskData(OverviewData.TaskData data)
        {
            return Gantt.GetRowTaskModel(data);
        }

        private void UpdateDataModel()
        {
            ListData.Add(new DataModel
            {
                Id = "01",
                Text = "RowHeight",
                Order = 1,
            });
            ListData.Add(new DataModel
            {
                Id = "02",
                Text = "Show grid Lines",
                Order = 1,
            });
            ListData.Add(new DataModel
            {
                Id = "02",
                Text = "Event markers",
                Order = 1,
            });
            ListData.Add(new DataModel
            {
                Id = "02",
                Text = "Show dependencies",
                Order = 1,
            });
            ListData.Add(new DataModel
            {
                Id = "02",
                Text = "Show task labels",
                Order = 1,
            });
            ListData.Add(new DataModel
            {
                Id = "03",
                Text = "Work Week",
                Category = "Scheduling Settings",
                Order = 1,
            });
            ListData.Add(new DataModel
            {
                Id = "03",
                Text = "Work Time Range",
                Category = "Scheduling Settings",
                Order = 1,
            });
            ListData.Add(new DataModel
            {
                Id = "02",
                Text = "TimeLine Cell Unit",
                Category = "Scheduling Settings",
                Order = 1,
            });
            ListData.Add(new DataModel
            {
                Id = "04",
                Text = "View Type",
                Category = "View settings",
                Order = 2,
            });
            ListData.Add(new DataModel
            {
                Id = "04",
                Text = "View Mode",
                Category = "View settings",
                Order = 2,
            });
            ListData.Add(new DataModel
            {
                Id = "02",
                Text = "Enable critical path",
                Order = 1,
            });
            ListData.Add(new DataModel
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
                filterBackground = "#201f1e";
                filterHeaderFontSize = "14px";
                filterHeaderFontSizeTouch = "16px";
                filteraHeaderHeight = "50px";
                filteraHeaderHeightTouch = "56px";
                filterHeaderFontWeight = "600";
            }
            else if (currentUri.Contains("fluent"))
            {
                CurrentTheme = Theme.Fluent;
                filterBackground = "#faf9f8";
                labelTextColor = "#201f1e";
                filterHeaderFontSize = "14px";
                filterHeaderFontSizeTouch = "16px";
                filteraHeaderHeight = "50px";
                filteraHeaderHeightTouch = "56px";
                filterHeaderFontWeight = "600";
            }
            else if (currentUri.Contains("fabric-dark"))
            {
                CurrentTheme = Theme.FabricDark;
                filterBackground = "#333232";
                labelTextColor = "#f3f2f1";
            }
            else if (currentUri.Contains("fabric"))
            {
                CurrentTheme = Theme.Fabric;
                filterBackground = "#f4f4f4";
            }
            else if (currentUri.Contains("bootstrap5-dark"))
            {
                CurrentTheme = Theme.Bootstrap5Dark;
                filterBackground = "#282d31";
                labelTextColor = "#fff";
                filterHeaderFontSize = "14px";
                filterHeaderFontSizeTouch = "14px";
                filteraHeaderHeight = "40px";
                filteraHeaderHeightTouch = "48px";
                filterHeaderFontWeight = "400";
            }
            else if (currentUri.Contains("bootstrap-dark"))
            {
                CurrentTheme = Theme.BootstrapDark;
                filterBackground = "#393939";
            }
            else if (currentUri.Contains("bootstrap5"))
            {
                CurrentTheme = Theme.Bootstrap5;
                filterBackground = "#f8f9fa";
                labelTextColor = "#212529";
                filterHeaderFontSize = "14px";
                filterHeaderFontSizeTouch = "14px";
                filteraHeaderHeight = "40px";
                filteraHeaderHeightTouch = "48px";
                filterHeaderFontWeight = "400";
            }
            else if (currentUri.Contains("bootstrap4"))
            {
                CurrentTheme = Theme.Bootstrap4;
                filterBackground = "#e9ecef";
            }
            else if (currentUri.Contains("bootstrap"))
            {
                CurrentTheme = Theme.Bootstrap;
                filterBackground = "#eee";
            }
            else if (currentUri.Contains("highcontrast"))
            {
                CurrentTheme = Theme.HighContrast;
                filterBackground = "#000";
                labelTextColor = "#fff";
            }
            else if (currentUri.Contains("tailwind-dark"))
            {
                CurrentTheme = Theme.TailwindDark;
                filterBackground = "#232e3e";
                labelTextColor = "#fff";
                filterHeaderFontSize = "14px";
                filterHeaderFontSizeTouch = "16px";
                filteraHeaderHeight = "44px";
                filteraHeaderHeightTouch = "52px";
                filterHeaderFontWeight = "400";
            }
            else if (currentUri.Contains("tailwind"))
            {
                CurrentTheme = Theme.Tailwind;
                filterBackground = "#f9fafb";
                labelTextColor = "rgb(17, 24, 39)";
                filterHeaderFontSize = "14px";
                filterHeaderFontSizeTouch = "16px";
                filteraHeaderHeight = "44px";
                filteraHeaderHeightTouch = "52px";
                filterHeaderFontWeight = "400";
            }
            else if (currentUri.Contains("material-dark"))
            {
                CurrentTheme = Theme.MaterialDark;
                filterHeaderFontSize = "16px";
                filterHeaderFontSizeTouch = "18px";
                filteraHeaderHeight = "52px";
                filteraHeaderHeightTouch = "58px";
                filterBackground = "linear-gradient(0deg, rgba(103, 80, 164, 0.05), rgba(103, 80, 164, 0.05)),rgba(28, 27, 31)";
                labelTextColor = "rgba(230, 225, 229)";
                filterHeaderFontWeight = "400";
            }
            else if (currentUri.Contains("material"))
            {
                CurrentTheme = Theme.Material;
                filterHeaderFontSize = "16px";
                filterHeaderFontSizeTouch = "18px";
                filteraHeaderHeight = "52px";
                filteraHeaderHeightTouch = "58px";
                filterBackground = "linear-gradient(0deg, rgba(208, 188, 255, 0.05), rgba(208, 188, 255, 0.05)),rgba(255, 255, 255)";
                labelTextColor = "#404042";
                filterHeaderFontWeight = "400";
            }
        }
    }
}
