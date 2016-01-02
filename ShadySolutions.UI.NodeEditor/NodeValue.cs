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
    public partial class NodeValue : UserControl
    {
        private int _NodeValueIndex;
        private NodeValue _Input;
        private Node _Holder;
        private List<NodeValue> _Outputs;
        protected ValueVector _Value;
        public bool HasInput
        {
            get
            {
                return !(this.NodeInputConnector.BackgroundImage == null);
            }

            set
            {
                if (value) this.NodeInputConnector.BackgroundImage = global::ShadySolutions.UI.NodeEditor.Properties.Resources.join;
                else this.NodeInputConnector.BackgroundImage = null;
            }
        }
        public bool HasOutput
        {
            get
            {
                return this.NodeOutputConnector.Visible;
            }

            set
            {
                this.NodeOutputConnector.Visible = value;
            }
        }
        public virtual bool HasValue
        {
            get
            {
                return false;
            }
            set
            {
            }
        }      
        public int NodeValueIndex
        {
            get
            {
                return _NodeValueIndex;
            }

            set
            {
                _NodeValueIndex = value;
            }
        }
        public NodeValue Input
        {
            get
            {
                if (!this.HasInput) return null;
                return _Input;
            }

            set
            {
                _Input = value;
                if (_Input != null) this.HasValue = false;
                else this.HasValue = true;
            }
        }
        public Node Holder
        {
            get
            {
                return _Holder;
            }

            set
            {
                _Holder = value;
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
        public virtual ValueVector Value
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
        public NodeValue()
        {
            InitializeComponent();
            this._Value = new ValueVector();
            this.NodeInputConnector.Tag = this;
            this.NodeOutputConnector.Tag = this;
            this._Outputs = new List<NodeValue>();
        }
        public NodeValue(string Title)
        {
            InitializeComponent();
            this._Value = new ValueVector();
            this.TextLabel.Text = Title;
            this.NodeInputConnector.Tag = this;
            this.NodeOutputConnector.Tag = this;
            this._Outputs = new List<NodeValue>();
        }
        public void SetEvents(MouseEventHandler MouseDownEvent, MouseEventHandler MouseUpEvent, MouseEventHandler MouseMoveEvent)
        {
            this.MouseDown += MouseDownEvent;
            this.MouseUp += MouseUpEvent;
            this.MouseMove += MouseMoveEvent;
            this.TextLabel.MouseDown += MouseDownEvent;
            this.TextLabel.MouseUp += MouseUpEvent;
            this.TextLabel.MouseMove += MouseMoveEvent;
        }
        private void NodeOutputConnector_Paint(object sender, PaintEventArgs e)
        {
            if(this.Outputs.Count > 0)
            {
                Pen GrayPen = new Pen(Color.Gray, 3);
                Pen OrangePen = new Pen(Color.Silver, 1);
                SolidBrush Gray = new SolidBrush(Color.Gray);
                SolidBrush Orange = new SolidBrush(Color.Silver);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawLine(GrayPen, 10, 10, 20, 10);
                e.Graphics.DrawLine(OrangePen, 10, 10, 20, 10);
                e.Graphics.FillEllipse(Gray, 2, 2, 15, 15);
                e.Graphics.FillEllipse(Orange, 3, 3, 14, 14);
            }
        }
        private void NodeInputConnector_Paint(object sender, PaintEventArgs e)
        {
            if (this.Input != null)
            {
                Pen GrayPen = new Pen(Color.Gray, 3);
                Pen OrangePen = new Pen(Color.Silver, 1);
                SolidBrush Gray = new SolidBrush(Color.Gray);
                SolidBrush Orange = new SolidBrush(Color.Silver);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawLine(GrayPen, 10, 10, 0, 10);
                e.Graphics.DrawLine(OrangePen, 10, 10, 0, 10);
                e.Graphics.FillEllipse(Gray, 2, 2, 15, 15);
                e.Graphics.FillEllipse(Orange, 3, 3, 14, 14);
            }
        }
        public void SetInputClickEvent(EventHandler Event)
        {
            this.NodeInputConnector.Click += Event;
        }
        public void SetOutputClickEvent(EventHandler Event)
        {
            this.NodeOutputConnector.Click += Event;
        }
        public void InvalidateConnectors()
        {
            NodeInputConnector.Invalidate();
            NodeOutputConnector.Invalidate();
        }
        private void NodeOutputConnector_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                for(int i = 0; i < this._Outputs.Count; i++)
                {
                    this._Outputs[i]._Input = null;
                    this._Outputs[i].InvalidateConnectors();
                }
                this._Outputs.Clear();
                InvalidateConnectors();
                this._Holder.EditorHolder.Invalidate();
            }
        }
        private void NodeInputConnector_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (this._Input == null) return;
                if (!this._Input.Outputs.Contains(this)) return;
                this._Input._Outputs.Remove(this);
                this._Input.InvalidateConnectors();
                this._Input = null;
                InvalidateConnectors();
                this._Holder.EditorHolder.Invalidate();
            }
        }
    }
}
