using Microsoft.JSInterop;
using Syncfusion.Blazor.Popups;
using System.Threading.Tasks;

namespace TextToMindMapDiagram
{
    public partial class DiagramSaveDialog
    {
#pragma warning disable CS8618
        /// <summary>
        /// Represents the DiagramMenuBar instance that serves as the parent.
        /// </summary>
        internal DiagramMenuBar Parent { get; set; }

        /// <summary>
        /// The name of the saved diagram file.
        /// </summary>
        public string diagramfileName { get; set; } = "Diagram1";
        /// <summary>
        /// Represents the SfDialog instance for the save dialog.
        /// </summary>
        public SfDialog SaveDialog { get; set; }
        /// <summary>
        /// Indicates whether the save dialog is currently visible.
        /// </summary>
        public bool SaveDialogVisible { get; set; }
#pragma warning restore CS8618
        /// <summary>
        /// This method is used to save the diagram.
        /// </summary>
        private async Task BtnSave()
        {
            string fileName = await jsRuntime.InvokeAsync<string>("getDiagramFileName", "save").ConfigureAwait(false);
            await Parent.Download(fileName).ConfigureAwait(false);
            await SaveDialog.HideAsync().ConfigureAwait(false);
        }
        /// <summary>
        /// This method is used to close the diaglog box.
        /// </summary>
        private async Task btnCancelClick()
        {
            await SaveDialog.HideAsync().ConfigureAwait(false);
        }
    }
}
