using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ej2_blazor_samples.Shared
{
    public class TreeViewEventModel
    {
        public string name { get; set; }
        public string action { get; set; }
        public bool cancel { get; set; }
        public bool isInteracted { get; set; }
        public object node { get; set; }
        
        public TreeviewNode nodeData { get; set; }

    }

    public class TreeviewNode
    {
        public string id { get; set; }
        public string text { get; set; }
        public string parentID { get; set; }
        public bool selected { get; set; }

        public bool expanded { get; set; }
        public bool isChecked { get; set; }

    }
}
