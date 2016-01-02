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
    public partial class NodeValueVector : NodeValue
    {
        public NodeValueVector() : base()
        {
            InitializeComponent();
            this.HasOutput = false;
        }
        public NodeValueVector(string Title) : base(Title)
        {
            InitializeComponent();
            this.HasOutput = false;
        }
    }
}
