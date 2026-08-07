using BlazorDemos.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Syncfusion.Blazor.Diagram;
using System;
using System.Threading.Tasks;

namespace TextToSequenceDiagram
{
    public partial class SequenceDiagramToolbar
    {
#pragma warning disable CS8618
        public TextToSequence Parent { get; set; }
        public string ZoomItemDropdownContent { get; set; } = "100%";
        [Inject]
        protected IJSRuntime jsRuntime { get; set; }
#pragma warning restore CS8618
        private async Task ToolbarEditorClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
        {
            var value = args.Item.TooltipText;
            switch (value)
            {
                case "New Diagram":
                    Parent.Diagram!.Clear();
                    SetElements();
                    break;
                case "Open Diagram":
                    await LoadDiagram().ConfigureAwait(false);
                    break;
                case "Save Diagram":
                    string fileName = "Sequence Diagram";
                    await Download(fileName).ConfigureAwait(false);
                    break;
                case "Print Diagram":
                    DiagramPrintSettings print = new DiagramPrintSettings();
                    await Parent.Diagram!.PrintAsync(print).ConfigureAwait(false);
                    break;
                case "Pan":
                    Parent.DiagramTool = DiagramInteractions.ZoomPan;
                    break;
                case "Select":
                    Parent.DiagramTool = DiagramInteractions.SingleSelect | DiagramInteractions.MultipleSelect;
                    break;
            }
            Parent.StateChanged();
        }

        private async Task SelectedItem(Syncfusion.Blazor.SplitButtons.MenuEventArgs args)
        {
            var value = args.Item.Text;
            switch (value)
            {
                case "JPG":
                case "PNG":
                case "SVG":
                    await Export(value).ConfigureAwait(false);
                    break;
            }
        }

        private void SelectedZoomItem(Syncfusion.Blazor.SplitButtons.MenuEventArgs args)
        {
            var value = args.Item.Text;
            var currentZoom = Parent.Diagram!.ScrollSettings!.CurrentZoom;
            switch (value)
            {
                case "Zoom In":
                case "Zoom Out":
                    var ZoomFactor = 0.2;
                    ZoomFactor = value == "Zoom Out" ? 1 / (1 + ZoomFactor) : (1 + ZoomFactor);
                    Parent.Diagram.Zoom(ZoomFactor, null!);
                    break;
                case "Zoom to Fit":
                    FitOptions fitoption = new FitOptions()
                    {
                        Mode = FitMode.Both,
                        Region = DiagramRegion.Content,
                    };
                    Parent.Diagram.FitToPage(fitoption);
                    break;
                case "Zoom to 50%":
                    ZoomFactor = 0.5 / currentZoom;
                    Parent.Diagram.Zoom(ZoomFactor, null!);
                    break;
                case "Zoom to 100%":
                    ZoomFactor = 1 / currentZoom;
                    Parent.Diagram.Zoom(ZoomFactor, null!);
                    break;
                case "Zoom to 200%":
                    ZoomFactor = 2 / currentZoom;
                    Parent.Diagram.Zoom(ZoomFactor, null!);
                    break;
            }
            ZoomItemDropdownContent = FormattableString.Invariant($"{Math.Round(Parent.Diagram.ScrollSettings.CurrentZoom * 100)}") + "%";
        }

        public void RefreshToolbar()
        {
            InvokeAsync(StateHasChanged);
        }
        public void SetElements()
        {
            Parent.Diagram!.ClearHistory();
            Parent.Diagram.ResetZoom();
            InvokeAsync(StateHasChanged);
        }

        public async Task LoadDiagram()
        {
            Parent.Diagram!.BeginUpdate();
            Parent.ExtensionType = ".json";
            await FileUtil.Click(jsRuntime).ConfigureAwait(false);
            await Parent.Diagram.EndUpdateAsync().ConfigureAwait(false);
        }

        public async Task Download(string fileName)
        {
            string data = Parent.Diagram!.SaveDiagram();
            await FileUtil.SaveAs(jsRuntime, data, fileName).ConfigureAwait(false);
        }

        private async Task Export(string value)
        {
            DiagramExportSettings export = new DiagramExportSettings();
            export.FitToPage = true;
            if (value == "JPG")
                await Parent.Diagram!.ExportAsync("Diagram", DiagramExportFormat.JPEG, export).ConfigureAwait(false);
            else if (string.Equals(value, "PNG", StringComparison.Ordinal))
                await Parent.Diagram!.ExportAsync("Diagram", DiagramExportFormat.PNG, export).ConfigureAwait(false);
            else if (string.Equals(value, "SVG", StringComparison.Ordinal))
                await Parent.Diagram!.ExportAsync("Diagram", DiagramExportFormat.SVG, export).ConfigureAwait(false);
        }
    }
}
