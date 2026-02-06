#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using Syncfusion.Blazor.Calendars;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.Popups;
using Syncfusion.PdfExport;

namespace BlazorDemos.Pages.GanttChart
{
    public partial class AdvancedExporting
    {
        private async Task OnSaveClick(MouseEventArgs args)
        {
            await ExportPdf();
            OpenDialog = false;
            IsVisible = false;
        }
        private async Task OnCancelClick(MouseEventArgs args)
        {
            OpenDialog = false;
            IsVisible = false;
            await Task.CompletedTask;
        }
        // Start of Code for dialog
        internal bool OpenDialog { get; set; }
        private bool IsSaveButtonClicked = false;
        private bool IsVisible { get; set; } = false;
        private SfDialog DialogObj { get; set; } = null!;
        private string height { get; set; } = "auto";
        private string dialogPosition { get; set; } = "center";


        // Columns
        public List<string> ColumnOptions { get; set; } = new() { "TaskName", "StartDate", "EndDate", "Duration", "Progress", "Predecessor" };
        public List<string> SelectedColumns = new() { "TaskName", "StartDate", "EndDate", "Duration"};

        // Rows
        public string RowExport = "All";

        public int ExportedRows = 24;
        // Timeline range
        public string TimelineSelection = "Default";
        private List<string> TimelineOptions = new List<string> { "Default", "Range" };
        public DateTime? TimelineStart = new DateTime(2025, 3, 25);
        public DateTime? TimelineEnd = new DateTime(2025, 5, 17);
        private void OnTimelineRangeChanged(RangePickerEventArgs<DateTime?> args)
        {
            TimelineStart = args.StartDate;
            TimelineEnd = args.EndDate;
        }

        // Orientation
        public PageOrientation SelectedOrientation = PageOrientation.Portrait;
        public List<PageOrientation> OrientationOptions =
            Enum.GetValues(typeof(PageOrientation)).Cast<PageOrientation>().ToList();
        // Paper size
        public Syncfusion.Blazor.Grids.PdfPageSize SelectedPaperSize = Syncfusion.Blazor.Grids.PdfPageSize.A4;

        public List<Syncfusion.Blazor.Grids.PdfPageSize> PaperSizeOptions =
            Enum.GetValues(typeof(Syncfusion.Blazor.Grids.PdfPageSize)).Cast<Syncfusion.Blazor.Grids.PdfPageSize>().ToList();

        // Scaling and export type
        private List<string> ExportTypeOptions = new List<string>
        {
            "Single Page",
            "Multiple Page"
        };

        public string SelectedExportType = "Multiple Page";
        public int ScalePercentage = 100;


        // End of Code for dialog
        public SfGantt<AdvancedExportingData.TaskData> GanttChartRef { get; set; }
        public List<AdvancedExportingData.TaskData> TaskCollection { get; set; } = new List<AdvancedExportingData.TaskData>();
#pragma warning disable BL0005 // Component parameter should not be set outside of its component.
        public List<ToolbarItem> ToolbarItems = new List<ToolbarItem>()
        {
            new ToolbarItem() { Text = "PDF Export",TooltipText = "PDF Export", Id = "PdfExport", PrefixIcon= "e-pdfexport" }         
        };
#pragma warning restore BL0005 // Component parameter should not be set outside of its component.
        private string headerText = "Product Development Lifecycle\nGantt Chart Report\nApril 2021 - May 2021";
        private string footerText = $"© 2024 Syncfusion Inc. All Rights Reserved.\nGenerated on: {DateTime.Now:MMMM dd, yyyy h:mm tt}";
        private Dictionary<string, string> pdfExportImage = new Dictionary<string, string>();

        private DateTime ProjectStartDate { get; set; } = new DateTime(2025, 3, 25);
        private DateTime ProjectEndDate { get; set; } = new DateTime(2025, 5, 17);
        /// <summary>
        /// Handles toolbar click events for exporting.
        /// </summary>
        private async void ToolbarClickHandler(Syncfusion.Blazor.Navigations.ClickEventArgs args)
        {
            if (args.Item.Id == "PdfExport")
            {
                OpenDialog = true;
                IsVisible = true;
                SelectedColumns = new() { "TaskName", "StartDate", "EndDate", "Duration" };
                TimelineSelection = "Default";
                TimelineStart = new DateTime(2025, 3, 25);
                TimelineEnd = new DateTime(2025, 5, 17);
                SelectedOrientation = PageOrientation.Portrait;
                SelectedPaperSize = Syncfusion.Blazor.Grids.PdfPageSize.A4;
                SelectedExportType = "Multiple Page";
                ScalePercentage = 100;
                StateHasChanged();
            }
        }
        Dictionary<string, (string HeaderText, string Width)> columnValues = new Dictionary<string, (string HeaderText, string Width)>
        {
            ["TaskName"] = ("Name", "250"),
            ["StartDate"] = ("Start Date", "100"),
            ["EndDate"] = ("End Date", "90px"),
            ["Duration"] = ("Duration", "100"),
            ["Progress"] = ("Progress", "100"),
            ["Predecessor"] = ("Dependency", "105")
        };
        /// <summary>
        /// Exports the Gantt chart to PDF with custom header and footer.
        /// </summary>
        private async Task ExportPdf()
        {
            List<PdfHeaderFooterContent> HeaderContent = new List<PdfHeaderFooterContent>()
            {
                new PdfHeaderFooterContent()
                {
                    Type = ContentType.Text,
                    Value = headerText,
                    Position = new PdfPosition(){ X = 20, Y = 20 },
                    Style = new PdfContentStyle()
                    {
                        Font = new PdfGridFont()
                        {
                            FontFamily = new PdfStandardFont(PdfFontFamily.Helvetica, 13, PdfFontStyle.Bold),
                            FontSize = 14,
                            IsTrueType = false,
                            FontStyle = PdfFontStyle.Underline,
                            TextColor = "DarkBlue"
                        },
                        Border = new PdfBorder()
                        {
                            Color = "Blue",
                            Width = 1,
                            DashStyle = Syncfusion.Blazor.Grids.PdfDashStyle.DashDot,
                            LineStyle = Syncfusion.Blazor.Grids.BorderLineStyle.Thick
                        }
                    }
                },
            };

            List<PdfHeaderFooterContent> FooterContents = new List<PdfHeaderFooterContent>()
            {
                new PdfHeaderFooterContent()
                {
                    Type = ContentType.Text,
                    Value = footerText,
                    Position = new PdfPosition() { X = 300, Y = 670 },
                    Style = new PdfContentStyle()
                    {
                        Font = new PdfGridFont()
                        {
                            FontFamily = new PdfStandardFont(PdfFontFamily.Helvetica, 13, PdfFontStyle.Bold),
                            FontSize = 10,
                            IsTrueType = false,
                            FontStyle = PdfFontStyle.Regular,
                            TextColor = "#3a435e",
                        },
                        Border = new PdfBorder()
                        {
                            Color = "Blue",
                            Width = 1,
                            DashStyle = Syncfusion.Blazor.Grids.PdfDashStyle.DashDot,
                            LineStyle = Syncfusion.Blazor.Grids.BorderLineStyle.Thick
                        },
                    }
                },

            };

            GanttPdfExportProperties pdfExport = new GanttPdfExportProperties();
            PdfHeader Header = new PdfHeader()
            {
                FromTop = 0,
                Left = 0,
                Height = 100,
                Contents = HeaderContent
            };
            PdfFooter Footer = new PdfFooter()
            {
                FromBottom = 0,
                Left = 0,
                Height = 100,
                Contents = FooterContents
            };
            pdfExport.Header = Header;
            pdfExport.Footer = Footer;
            List<GanttColumn> columns = new List<GanttColumn>();
            if (SelectedColumns != null)
            {
                foreach (var field in SelectedColumns)
                {
                    if (columnValues.TryGetValue(field, out var meta))
                    {
                        columns.Add(new GanttColumn
                        {
                            Field = field,
                            HeaderText = meta.HeaderText,
                            Width = meta.Width
                        });
                    }
                }
            }
            pdfExport.FileName = "Product Development Report.pdf";
            pdfExport.Columns = columns;
            pdfExport.PageOrientation = SelectedOrientation;
            pdfExport.PageSize = SelectedPaperSize;
            await GanttChartRef.ExportToPdfAsync(pdfExport, SelectedExportType != "Single Page");
        }
        public void PdfExportingHandler(PdfExportEventArgs args)
        {
            args.RangeStart = TimelineStart;
            args.RangeEnd = TimelineEnd;
            if (SelectedExportType == "Multiple Page")
            {
                args.MultiPageSettings.ScaleMode = GanttPdfExportScaleMode.Percentage;
                args.MultiPageSettings.ScalePercentage = ScalePercentage;
            }
        }
        /// <summary>
        /// Customizes chart rows appearance based on critical path and theme.
        /// </summary>
        private async Task QueryChartRowInfo(QueryChartRowInfoEventArgs<AdvancedExportingData.TaskData> args)
        {
            if (args.GanttTaskModel.IsCritical && !args.GanttTaskModel.HasChildRecords)
            {
                if (NavigationManager.Uri.Contains("dark") || NavigationManager.Uri.Contains("highcontrast"))
                {
                    args.Row.AddClass(new string[] { "taskbar-critical-dark progress-critical-dark" });
                }
                else
                {
                    args.Row.AddClass(new string[] { "taskbar-critical progress-critical" });
                }
            }
            await Task.CompletedTask;
        }

        /// <summary>
        /// Customizes taskbar appearance and labels in PDF export.
        /// </summary>
        private void PdfQueryTaskbarInfoHandler(PdfQueryTaskbarInfoEventArgs<AdvancedExportingData.TaskData> args)
        {
            args.TaskbarStyle.Color = new PdfTaskbarColor();
            if (NavigationManager.Uri.Contains("dark") || NavigationManager.Uri.Contains("highcontrast"))
            {
                args.TaskbarStyle.Color.CriticalPathProgressColor = new Syncfusion.PdfExport.PdfColor(172, 6, 136);
                args.TaskbarStyle.Color.CriticalPathTaskbarColor = new Syncfusion.PdfExport.PdfColor(73, 4, 58);
            }
            else
            {
                args.TaskbarStyle.Color.CriticalPathProgressColor = new Syncfusion.PdfExport.PdfColor(176, 0, 138);
                args.TaskbarStyle.Color.CriticalPathTaskbarColor = new Syncfusion.PdfExport.PdfColor(255, 206, 244);
            }
            if (args.Data.TaskId == 7)
            {
                args.LabelSettings.LeftLabelValue = "Custom Label";
                args.LabelSettings.LeftLabel = new PdfElementStyle { Font = new PdfGridFont { FontSize = 3.5, TextColor = "#8E2440" } }; // Deep burgundy
            }
            else
            {
                args.LabelSettings.LeftLabelValue = args.Data.TaskName;
                args.LabelSettings.LeftLabel = new PdfElementStyle { Font = new PdfGridFont { FontSize = 3.5, TextColor = "#1A3A5E" } }; // Dark navy blue
            }
            if (!string.IsNullOrEmpty(args.Data.ResourceName))
            {
                var resourceName = args.Data.ResourceName.Trim().Replace(" ", "").ToLower();

                if (pdfExportImage.TryGetValue(resourceName, out string? base64String))
                {
                    byte[] imageBytes = Convert.FromBase64String(base64String);
                    using MemoryStream imageStream = new MemoryStream(imageBytes);
                    PdfImage image = PdfImage.FromStream(imageStream);

                    args.LabelSettings.RightLabel = new PdfElementStyle { Image = image };
                }
            }
        }
    }
}
