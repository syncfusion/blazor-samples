#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Blazor.Buttons;
using Syncfusion.Blazor.Diagram;
using Syncfusion.Blazor.Popups;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TextToMindMapDiagram
{
    public partial class DiagramPrintDialog
    {
#pragma warning disable CS8618
        /// <summary>
        /// Object reference for menu bar.
        /// </summary>
        internal DiagramMenuBar Parent;
        /// <summary>
        /// SfDialog instance for the print dialog.
        /// </summary>
        public SfDialog PrintDialog;
        /// <summary>
        /// Indicates whether the print dialog is visible.
        /// </summary>
        private bool printDialogVisible = false;
        /// <summary>
        /// The paper size selected for printing.
        /// </summary>
        private string Papersize = "Letter";
        /// <summary>
        /// Indicates whether the paper orientation is in portrait mode.
        /// </summary>
        bool IsPortrait = true;
        /// <summary>
        /// Indicates whether the paper orientation is in landscape mode.
        /// </summary>
        bool IsLandscape = false;
        /// <summary>
        /// Indicates whether multiple pages are selected for printing.
        /// </summary>
        bool IsMultiplePage = false;
        /// <summary>
        /// The height of the printed page.
        /// </summary>
        double PageHeight = 816;
        /// <summary>
        /// The width of the printed page.
        /// </summary>
        double PageWidth = 1056;
        /// <summary>
        /// The value of the checked orientation option (portrait or landscape).
        /// </summary>
        string orientationCheckedValue = "portrait";
#pragma warning restore CS8618
        /// <summary>
        /// This method is used to set the page size.
        /// </summary>
        private PaperSize GetPaperSize(string paperName)
        {
            PaperSize Paper = new PaperSize();
            switch (paperName)
            {
                case "Letter":
                    Paper.PageWidth = 816;
                    Paper.PageHeight = 1056;
                    break;
                case "Legal":
                    Paper.PageWidth = 816;
                    Paper.PageHeight = 1344;
                    break;
                case "Tabloid":
                    Paper.PageWidth = 1056;
                    Paper.PageHeight = 1632;
                    break;
                case "A3":
                    Paper.PageWidth = 1122;
                    Paper.PageHeight = 1587;
                    break;
                case "A4":
                    Paper.PageWidth = 793;
                    Paper.PageHeight = 1122;
                    break;
                case "A5":
                    Paper.PageWidth = 559;
                    Paper.PageHeight = 793;
                    break;
                case "A6":
                    Paper.PageWidth = 396;
                    Paper.PageHeight = 559;
                    break;
            }
            return Paper;
        }
        /// <summary>
        /// This method is used to set the page width and height values.
        /// </summary>
        private void PaperChanged(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, PaperListFields> args)
        {
            PaperSize Size = this.GetPaperSize(args.Value);
            PageHeight = Size.PageHeight;
            PageWidth = Size.PageWidth;
        }
        /// <summary>
        /// This method is used to enable the multiple page options.
        /// </summary>
        private void MultiplePage(Syncfusion.Blazor.Buttons.ChangeEventArgs<bool> args)
        {
            IsMultiplePage = args.Checked;
        }
        /// <summary>
        /// Prints the diagram pages based on <see cref="DiagramPrintSettings"/>.
        /// </summary>
        private async Task PrintDialogHandler()
        {
            double pageWidth = PageWidth;
            double pageHeight = PageHeight;
            if (IsPortrait)
            {
                if (pageWidth > pageHeight)
                {
                    var temp = pageWidth;
                    pageWidth = pageHeight;
                    pageHeight = temp;
                }
            }
            if (IsLandscape)
            {
                if (pageHeight > pageWidth)
                {
                    var temp1 = pageHeight;
                    pageHeight = pageWidth;
                    pageWidth = temp1;
                }
            }

            DiagramPrintSettings options = new DiagramPrintSettings()
            {
                FitToPage = IsMultiplePage,
                Orientation = IsPortrait ? Syncfusion.Blazor.Diagram.PageOrientation.Portrait : Syncfusion.Blazor.Diagram.PageOrientation.Landscape,
                PageHeight = pageHeight,
                PageWidth = pageWidth,
                Margin = new DiagramThickness() { Bottom = 0, Left = 0, Right = 0, Top = 0 },
                Region = (DiagramPrintExportRegion)Enum.Parse(typeof(DiagramPrintExportRegion), CurrentRegionValue.ToString(), true),
            };

            await Parent.PrintDiagram(options);
            await PrintDialog.HideAsync();
        }
        /// <summary>
        /// This method is used to close the print dialog box.
        /// </summary>
        private async Task PrintDialogCloseHandler()
        {
            await PrintDialog.HideAsync();
        }
        /// <summary>
        /// this method is used to changes the orientation of the diagram page.
        /// </summary>
        private void OrientationChanged(ChangeArgs<string> args)
        {
            if (args.Value.ToString() == "portrait")
            {
                IsPortrait = true;
                IsLandscape = false;
                orientationCheckedValue = "portrait";
            }
            else if (args.Value.ToString() == "landscape")
            {
                IsLandscape = true;
                IsPortrait = false;
                orientationCheckedValue = "landscape";
            }
        }
        /// <summary>
        /// List of available paper sizes for printing.
        /// </summary>
        public List<PaperListFields> PaperList = new List<PaperListFields>()
    {
        new PaperListFields{ Text= "Letter (8.5 in x 11 in)", Value= "Letter" },
        new PaperListFields{ Text= "Legal (8.5 in x 14 in)", Value= "Legal" },
        new PaperListFields{ Text= "Tabloid (279 mm x 432 mm)", Value= "Tabloid" },
        new PaperListFields{ Text= "A3 (297 mm x 420 mm)", Value= "A3" },
        new PaperListFields{ Text= "A4 (210 mm x 297 mm)", Value= "A4" },
        new PaperListFields{ Text= "A5 (148 mm x 210 mm)", Value= "A5" },
        new PaperListFields{ Text= "A6 (105 mm x 148 mm)", Value= "A6" },
        new PaperListFields{ Text= "Custom", Value= "Custom" },
    };
        /// <summary>
        /// Array of region values obtained from the 'Regions' enum.
        /// </summary>
        private string[] RegionValues = Enum.GetNames(typeof(Regions));
        /// <summary>
        /// The currently selected region value.
        /// Default value is 'PageSettings'.
        /// </summary>
        private Regions CurrentRegionValue { get; set; } = Regions.PageSettings;
        /// <summary>
        /// Enum representing the regions.
        /// </summary>
        private enum Regions
        {
            PageSettings,
            Content,
        }
        /// <summary>
        /// Represents the paper size with its width and height.
        /// </summary>
        public class PaperSize
        {
            public double PageWidth { get; set; }
            public double PageHeight { get; set; }
        }
        /// <summary>
        /// Represents the fields for the list of paper sizes.
        /// </summary>
        #region
        public class PaperListFields
        {
            public string Value { get; set; } = "";
            public string Text { get; set; } = "";
        }
        #endregion
    }
}
