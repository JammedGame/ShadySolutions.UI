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
    public partial class NodeValueBoolean : NodeValue
    {
        public override bool HasValue
        {
            get
            {
                return ValueBoolean.Visible;
            }
            set
            {
                ValueBoolean.Visible = value;
            }
        }
        public NodeValueBoolean() : base()
        {
            InitializeComponent();
            this.HasOutput = false;
        }
        public NodeValueBoolean(string Title) : base(Title)
        {
            InitializeComponent();
            this.HasOutput = false;
        }
        private void ValueCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ValueBoolean.Checked) this.Value.X = 1;
            else this.Value.X = 0;
        }
    }
}
