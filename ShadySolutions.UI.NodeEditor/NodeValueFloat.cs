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
    public partial class NodeValueFloat : NodeValue
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
                this.ValueFloat.Value = (decimal)_Value.X;
                if (_Value.Y != 0) this.ValueFloat.Minimum = (decimal)_Value.Y;
                if (_Value.Z != 0) this.ValueFloat.Maximum = (decimal)_Value.Z;
            }
        }
        public override bool HasValue
        {
            get
            {
                return ValueFloat.Visible;
            }
            set
            {
                ValueFloat.Visible = value;
            }
        }
        public NodeValueFloat() : base()
        {
            InitializeComponent();
            this.HasOutput = false;
        }
        public NodeValueFloat(string Title) : base(Title)
        {
            InitializeComponent();
            this.HasOutput = false;
        }
        private void ValueFloat_ValueChanged(object sender, EventArgs e)
        {
            this.Value.X = (double)ValueFloat.Value;
        }
    }
}
