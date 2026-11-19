using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos.Pages.GanttChart.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Calendars;
using Syncfusion.Blazor.Gantt;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.Popups;
using Syncfusion.PdfExport;
namespace BlazorDemos.Pages.GanttChart
{
    public sealed partial class AdvancedExporting
    {
        //Critical path themes
        private static readonly string[] CriticalDarkClasses = { "taskbar-critical-dark progress-critical-dark" };
        private static readonly string[] CriticalClasses = { "taskbar-critical progress-critical" };

        // Start of Code for dialog
        internal bool OpenDialog { get; set; }
        internal bool IsSaveButtonClicked { get; set; }
        private bool IsVisible { get; set; }
        private SfDialog DialogObj { get; set; } = null!;
        private string height { get; set; } = "auto";
        private string dialogPosition { get; set; } = "center";

        // Columns
        internal List<string> ColumnOptions { get; } = new List<string>() { "TaskName", "StartDate", "EndDate", "Duration", "Progress", "Predecessor" };
        internal List<string> SelectedColumns { get; set; } = new List<string>() { "TaskName", "StartDate", "EndDate", "Duration"};

        // Rows
        public string RowExport { get; set; } = "All";
        public int ExportedRows { get; set; } = 24;

        // Timeline range
        public string TimelineSelection { get; set; } = "Default";
        private List<string> TimelineOptions = new List<string> { "Default", "Range" };
        public DateTime? TimelineStart { get; set; } = new DateTime(2025, 3, 25);
        public DateTime? TimelineEnd { get; set; } = new DateTime(2025, 5, 17);

        // Orientation
        public PageOrientation SelectedOrientation { get; set; } = PageOrientation.Portrait;
        internal List<PageOrientation> OrientationOptions { get; } = Enum.GetValues<PageOrientation>().ToList();

        // Paper size
        public Syncfusion.Blazor.Grids.PdfPageSize SelectedPaperSize { get; set; } = Syncfusion.Blazor.Grids.PdfPageSize.A4;
        internal List<Syncfusion.Blazor.Grids.PdfPageSize> PaperSizeOptions { get; } = Enum.GetValues<Syncfusion.Blazor.Grids.PdfPageSize>().ToList();

        // Scaling and export type
        private List<string> ExportTypeOptions = new List<string>
        {
            "Single Page",
            "Multiple Page"
        };

        public string SelectedExportType { get; set; } = "Multiple Page";
        public int ScalePercentage { get; set; } = 100;

        // End of Code for dialog
        internal SfGantt<AdvancedExportingData.TaskData> GanttChartRef { get; set; } = null!;
        internal List<AdvancedExportingData.TaskData> TaskCollection { get; set; } = new List<AdvancedExportingData.TaskData>();
#pragma warning disable BL0005 // Component parameter should not be set outside of its component.
        List<ToolbarItem> ToolbarItems { get; } = new List<ToolbarItem>()
        {
            new ToolbarItem() { Text = "PDF Export",TooltipText = "PDF Export", Id = "PdfExport", PrefixIcon= "e-pdfexport" }
        };
#pragma warning restore BL0005 // Component parameter should not be set outside of its component.
        private string headerText = "Product Development Lifecycle\nGantt Chart Report\nMarch 2025 - May 2025";
        private string footerText = $"© {DateTime.Now:yyyy} Syncfusion Inc. All Rights Reserved.";
        private Dictionary<string, string> pdfExportImage = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        private DateTime ProjectStartDate { get; set; } = new DateTime(2025, 3, 25);
        private DateTime ProjectEndDate { get; set; } = new DateTime(2025, 5, 17);

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
        /// Initializes the Gantt chart with task data and loads resource images for PDF export.
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            TaskCollection = AdvancedExportingData.GetTaskCollection();
            var resourceNames = TaskCollection
            .Where(task => !string.IsNullOrEmpty(task.ResourceName))  // Exclude empty/null values
            .Select(task => task.ResourceName.Trim().Replace(" ", "", StringComparison.CurrentCulture).ToLower(CultureInfo.CurrentCulture))  // Normalize names
            .Distinct() // Ensure uniqueness
            .ToList();

            foreach (var resourceName in resourceNames)
            {
                var filePath = NavigationManager.ToAbsoluteUri($"{SampleService?.WebAssetsPath}images/gantt/{resourceName}.png").ToString();

                try
                {
                    var base64String = await JSRuntime.InvokeAsync<string>("convertGanttImageBaseUrl", filePath).ConfigureAwait(true);
                    if (!string.IsNullOrEmpty(base64String))
                    {
                        pdfExportImage[resourceName] = base64String;
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"IO error loading image {resourceName}: {ex.Message}");
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine($"Access error loading image {resourceName}: {ex.Message}");
                }
            }

            await Task.CompletedTask.ConfigureAwait(true);
        }

      

        /// <summary>
        /// Updates the selected export timeline range when the user changes the date picker values.
        /// </summary>
        /// <param name="args">The range picker arguments containing the new start and end dates.</param>
        private void OnTimelineRangeChanged(RangePickerEventArgs<DateTime?> args)
        {
            TimelineStart = args.StartDate;
            TimelineEnd = args.EndDate;
        }

        /// <summary>
        /// Saves the current export settings and starts the PDF export operation.
        /// </summary>
        /// <param name="args">The mouse event arguments for the save button click.</param>
        private async Task OnSaveClick(MouseEventArgs args)
        {
            await ExportPdf().ConfigureAwait(true);
            OpenDialog = false;
            IsVisible = false;
        }

        /// <summary>
        /// Cancels the export dialog and closes the settings panel without exporting.
        /// </summary>
        /// <param name="args">The mouse event arguments for the cancel button click.</param>
        private async Task OnCancelClick(MouseEventArgs args)
        {
            OpenDialog = false;
            IsVisible = false;
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Handles toolbar click events for exporting.
        /// </summary>
        /// <param name="args">The toolbar click event arguments.</param>
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
            await Task.CompletedTask.ConfigureAwait(true);
        }

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
                        using (GanttColumn column = new GanttColumn())
                        {
                            ReflectionHelper prop = new ReflectionHelper();
                            prop.SetValue(column, nameof(column.Field), field);
                            prop.SetValue(column, nameof(column.HeaderText), meta.HeaderText);
                            prop.SetValue(column, nameof(column.Width), meta.Width);
                            prop.Dispose();
                            columns.Add(column);
                        };
                    }
                }
            }
            pdfExport.FileName = $"Product Development Report {DateTime.Now:MMMM_dd_yyyy}.pdf";
            pdfExport.Columns = columns;
            pdfExport.PageOrientation = SelectedOrientation;
            pdfExport.PageSize = SelectedPaperSize;
            await GanttChartRef.ExportToPdfAsync(pdfExport, SelectedExportType != "Single Page").ConfigureAwait(true);
        }
        /// <summary>
        /// Applies the selected timeline range and scaling options before PDF export begins.
        /// </summary>
        /// <param name="args">The PDF export event arguments.</param>
        public void PdfExportingHandler(PdfExportEventArgs args)
        {
            if (args == null)
            {
                return;
            }
            args.RangeStart = TimelineStart;
            args.RangeEnd = TimelineEnd;

            if (SelectedExportType == "Multiple Page")
            {
                if (args.MultiPageSettings != null)
                {
                    args.MultiPageSettings.ScaleMode = GanttPdfExportScaleMode.Percentage;
                    args.MultiPageSettings.ScalePercentage = ScalePercentage;
                }
            }
        }
        /// <summary>
        /// Customizes chart rows appearance based on critical path and theme.
        /// </summary>
        private async Task QueryChartRowInfo(QueryChartRowInfoEventArgs<AdvancedExportingData.TaskData> args)
        {
            if (args.GanttTaskModel.IsCritical && !args.GanttTaskModel.HasChildRecords)
            {
                if (NavigationManager.Uri.Contains("dark", StringComparison.OrdinalIgnoreCase) || NavigationManager.Uri.Contains("highcontrast", StringComparison.OrdinalIgnoreCase))
                {
                    args.Row.AddClass(CriticalDarkClasses);
                }
                else
                {
                    args.Row.AddClass(CriticalClasses);
                }
            }
            await Task.CompletedTask.ConfigureAwait(true);
        }

        /// <summary>
        /// Customizes taskbar appearance and labels in PDF export.
        /// </summary>
        /// <param name="args">The PdfQueryTaskbarInfoEventArgs arguments.</param>
        private void PdfQueryTaskbarInfoHandler(PdfQueryTaskbarInfoEventArgs<AdvancedExportingData.TaskData> args)
        {
            args.TaskbarStyle.Color = new PdfTaskbarColor();
            if (NavigationManager.Uri.Contains("dark", StringComparison.OrdinalIgnoreCase) || NavigationManager.Uri.Contains("highcontrast", StringComparison.OrdinalIgnoreCase))
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
                var resourceName = args.Data.ResourceName.Trim().Replace(" ", "", StringComparison.Ordinal);
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
