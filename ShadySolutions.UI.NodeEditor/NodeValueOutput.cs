using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadySolutions.UI.NodeEditor
{
    public partial class NodeValueOutput : NodeValue
    {
        public NodeValueOutput() : base()
        {
            this.HasInput = false;
            this.HasValue = false;
        }
        public NodeValueOutput(string Title) : base(Title)
        {
            this.HasInput = false;
            this.HasValue = false;
        }
    }
}
