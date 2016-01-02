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
    public partial class NodeValueString : NodeValue
    {
        public override ValueVector Value
        {
            get
            {
                return this._Value;
            }

            set
            {
                _Value = value;
                this.ValueString.Text = value.Value;
            }
        }
        public override bool HasValue
        {
            get
            {
                return ValueString.Visible;
            }
            set
            {
                ValueString.Visible = value;
            }
        }
        public NodeValueString()
        {
            InitializeComponent();
        }
        private void ValueString_TextChanged(object sender, EventArgs e)
        {
            this.Value.Value = ValueString.Text;
        }
    }
}
