using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ej2_blazor_samples.Pages.RichTextEditor.RichTextEditor
{
    public class ToolbarProperties 
    {
        public object[] items { get; set; }
        public object format { get; set; }
        public object fontFamily { get; set; }
    }
    public class InlineMode
    {
        public bool enable { get; set; }
        public bool onSelection { get; set; }
    }

    public class IframeProperties
    {
        public bool enable { get; set; }
    }


}
