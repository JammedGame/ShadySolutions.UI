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
    public partial class Node : UserControl
    {
        private bool _MouseIsDown;
        private Point _LastMousePoint;
        private List<NodeValue> _Values;
        private List<NodeValue> _Inputs;
        private List<NodeValue> _Outputs;
        public List<NodeValue> Values
        {
            get
            {
                return _Values;
            }

            set
            {
                _Values = value;
            }
        }
        public List<NodeValue> Inputs
        {
            get
            {
                return _Inputs;
            }

            set
            {
                _Inputs = value;
            }
        }
        public List<NodeValue> Outputs
        {
            get
            {
                return _Outputs;
            }

            set
            {
                _Outputs = value;
            }
        }
        public Node()
        {
            InitializeComponent();
            this._MouseIsDown = false;
            this._Values = new List<NodeValue>();
            this._Inputs = new List<NodeValue>();
            this._Outputs = new List<NodeValue>();
        }
        public Node(string Title)
        {
            InitializeComponent();
            this._MouseIsDown = false;
            this.TitleLabel.Text = Title;
            this._Values = new List<NodeValue>();
            this._Inputs = new List<NodeValue>();
            this._Outputs = new List<NodeValue>();
        }
        private void Node_MouseMove(object sender, MouseEventArgs e)
        {
            if (this._MouseIsDown)
            {
                this.Location = new Point(this.Location.X - _LastMousePoint.X + e.X, this.Location.Y - _LastMousePoint.Y + e.Y);
            }
        }
        private void Node_MouseDown(object sender, MouseEventArgs e)
        {
            this._MouseIsDown = true;
            this._LastMousePoint = new Point(e.X, e.Y);
        }
        private void Node_MouseUp(object sender, MouseEventArgs e)
        {
            this._MouseIsDown = false;
        }
        public void AddNodeValue(NodeValue NewNodeValue)
        {
            NewNodeValue.Dock = DockStyle.Top;
            NewNodeValue.SetEvents(Node_MouseDown, Node_MouseUp, Node_MouseMove);
            if (NewNodeValue.HasInput) this._Inputs.Add(NewNodeValue);
            else if (NewNodeValue.HasOutput) this._Outputs.Add(NewNodeValue);
            NewNodeValue.NodeValueIndex = this._Values.Count;
            NewNodeValue.Holder = this;
            this._Values.Add(NewNodeValue);
            this.Size = new Size(this.Width, this.Height + 20);
            this.Controls.Add(NewNodeValue);
            NewNodeValue.BringToFront();
        }
    }
}
