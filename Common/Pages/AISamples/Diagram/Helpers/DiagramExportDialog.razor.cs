using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Diagram;
using Syncfusion.Blazor.Popups;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TextToMindMapDiagram
{
    public partial class DiagramExportDialog
    {
#pragma warning disable CS8618
        /// <summary>
        /// Object reference for menubar items.
        /// </summary>
        internal DiagramMenuBar Parent { get; set; }
        /// <summary>
        /// Gets or sets the diagram file name when export the diagram.
        /// </summary>
        private string diagramfileName = "Text to Mindmap";
        /// <summary>
        /// Object reference for dialog box.
        /// </summary>
        public SfDialog ExportDialog { get; set; }
        /// <summary>
        /// Gets or sets the export dialog box visibility setting.
        /// </summary>
        private bool exportDialogVisible;
        //// <summary>
        /// Gets a value indicating whether the diagram spans multiple pages when exported.
        /// </summary>
        bool IsMultiplePageExport;
#pragma warning restore CS8618
        /// <summary>
        /// This method is used to change the file name when exporting a diagram.
        /// </summary>
        private void FileNameChangeHandler(ChangeEventArgs args)
        {
            if (args.Value != null)
                diagramfileName = args.Value.ToString()!;
        }
        /// <summary>
        /// This method is used to enable the multiple page options.
        /// </summary>
        private void MultiplePageExport(Syncfusion.Blazor.Buttons.ChangeEventArgs<bool> args)
        {
            IsMultiplePageExport = args.Checked;
        }
        /// <summary>
        /// Gets or sets the event callback that will be invoked when the suggestions popup before it opens
        /// </summary>
        private static void OnDialogOpening(Syncfusion.Blazor.Popups.BeforeOpenEventArgs args)
        {
        }
        /// <summary>
        /// This method is used Exports the diagram to an PNG/SVG/PDF/JPEG/ file.
        /// </summary>
        private async Task ExportHandler()
        {
            DiagramRect pageBounds = Parent.Parent.Diagram!.GetPageBounds();
            SfDiagramComponent diagram = Parent.Parent.Diagram;
            DiagramExportSettings options = new DiagramExportSettings()
            {
                FitToPage = IsMultiplePageExport,
                Margin = new DiagramThickness() { Bottom = 0, Left = 0, Right = 0, Top = 0 },
                Region = Enum.Parse<DiagramPrintExportRegion>(CurrentRegionValue.ToString(), true),
                PageHeight = diagram.PageSettings?.Height != null ? diagram.PageSettings.Height.Value : pageBounds.Height,
                PageWidth = diagram.PageSettings?.Width != null ? diagram.PageSettings.Width.Value : pageBounds.Width,
            };
            await ExportDialog.HideAsync().ConfigureAwait(false);
            await Parent.ExportDiagram(options, CurrentFormatValue.ToString(), diagramfileName).ConfigureAwait(false);
        }
        /// <summary>
        /// This method is used close the export diaglog box.
        /// </summary>
        private async Task CloseDialogHandler()
        {
            await ExportDialog.HideAsync().ConfigureAwait(false);
        }
        /// <summary>
        /// Private collection of format values obtained from the 'Formats' enum.
        /// </summary>
        private IEnumerable<string> formatValues = Enum.GetNames<Formats>();
        /// <summary>
        /// Represents the currently selected format value for image and document files.
        /// </summary>
        private Formats CurrentFormatValue { get; set; } = Formats.JPEG;
        /// <summary>
        /// Represents the supported formats for image and document files.
        /// </summary>
        private enum Formats
        {
            JPEG,
            PNG,
            SVG,
            PDF
        }
        /// <summary>
        /// Collection of region values obtained from the 'Regions' enum.
        /// </summary>
        private IEnumerable<string> RegionValues = Enum.GetNames<Regions>();
        /// <summary>
        /// Gets or sets the currently selected region value.
        /// Default value is 'PageSettings'.
        /// </summary>
        private Regions CurrentRegionValue { get; set; } = Regions.PageSettings;
        /// <summary>
        /// Represents the different regions used in image and document files.
        /// </summary>
        private enum Regions
        {
            PageSettings,
            Content,
        }
    }
}
