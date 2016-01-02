using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadySolutions.UI.NodeEditor
{
    public partial class VectorDialog : Form
    {
        private ValueVector _Value;
        public ValueVector Value
        {
            get
            {
                return _Value;
            }

            set
            {
                _Value = value;
            }
        }
        public VectorDialog()
        {
            InitializeComponent();
        }
        public VectorDialog(ValueVector Value)
        {
            InitializeComponent();
            X.Value = (decimal)Value.X;
            Y.Value = (decimal)Value.Y;
            Z.Value = (decimal)Value.Z;
            W.Value = (decimal)Value.W;
        }
        private void OK_Click(object sender, EventArgs e)
        {
            this._Value = new ValueVector();
            this._Value.X = (double)X.Value;
            this._Value.Y = (double)Y.Value;
            this._Value.Z = (double)Z.Value;
            this._Value.W = (double)W.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
