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
    public partial class NodeValueColor : NodeValue
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
                this.ValueColorPicker.BackColor = Color.FromArgb((_Value.W == 0) ? 0 : (int)(_Value.W*256 - 1), (_Value.X == 0)?0:(int)(_Value.X*256 - 1), (_Value.Y == 0) ? 0 : (int)(_Value.Y*256 - 1), (_Value.Z == 0) ? 0 : (int)(_Value.Z * 256 - 1));
            }
        }
        public override bool HasValue
        {
            get
            {
                return ValueColorPicker.Visible;
            }
            set
            {
                ValueColorPicker.Visible = value;
            }
        }
        public NodeValueColor() : base()
        {
            InitializeComponent();
            this.HasOutput = false;
            this.Value.X = 1;
        }
        public NodeValueColor(string Title) : base(Title)
        {
            InitializeComponent();
            this.HasOutput = false;
        }
        private void ValueColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog Dialog = new ColorDialog();
            if(Dialog.ShowDialog() == DialogResult.OK)
            {
                ValueColorPicker.BackColor = Dialog.Color;
                this.Value.X = (Dialog.Color.R+1) * 1.0 / 256;
                this.Value.Y = (Dialog.Color.G+1) * 1.0 / 256;
                this.Value.Z = (Dialog.Color.B+1) * 1.0 / 256;
                this.Value.W = (Dialog.Color.A+1) * 1.0 / 256;
            }
        }
    }
}
