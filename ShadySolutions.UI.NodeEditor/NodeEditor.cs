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
    public partial class NodeEditor : UserControl
    {
        private bool _ConnectionInProgress;
        private int _SeekType;
        private Point _LastMouseLocation;
        private NodeValue _ConnectionSeeker;
        private List<Node> _Nodes;
        public NodeEditor()
        {
            InitializeComponent();
            this._Nodes = new List<Node>();
        }
        public void AddNode(Node NewNode)
        {
            for(int i = 0; i < NewNode.Inputs.Count; i++)
            {
                NewNode.Inputs[i].SetInputClickEvent(Connect_Input_Click);
            }
            for (int i = 0; i < NewNode.Outputs.Count; i++)
            {
                NewNode.Outputs[i].SetOutputClickEvent(Connect_Output_Click);
            }
            this._Nodes.Add(NewNode);
            this.Controls.Add(NewNode);
        }
        private List<Point> GenerateCurve(Point P0, Point P1)
        {
            List<Point> Points = new List<Point>();
            Point M = new Point(), R = new Point(), M0 = new Point(), M1 = new Point(), M0S = new Point(), M1S = new Point();
            M.X = (P0.X + P1.X) / 2;
            M.Y = (P0.Y + P0.Y) / 2;
            R.X = Math.Abs(P1.X - P0.X);
            R.Y = Math.Abs(P1.Y - P0.Y);
            if (P0.X < P1.X)
            {
                M0.X = P0.X + R.X / 3;
                M1.X = P1.X - R.X / 3;
                M0S.X = P0.X + R.X / 10;
                M1S.X = P1.X - R.X / 10;
            }
            else
            {
                M0.X = P0.X - R.X / 3;
                M1.X = P1.X + R.X / 3;
                M0S.X = P0.X - R.X / 10;
                M1S.X = P1.X + R.X / 10;
            }
            if (P0.Y < P1.Y)
            {
                M0.Y = P0.Y + R.Y / 7;
                M1.Y = P1.Y - R.Y / 7;
            }
            else
            {
                M0.Y = P0.Y - R.Y / 7;
                M1.Y = P1.Y + R.Y / 7;
            }
            M0S.Y = P0.Y;
            M1S.Y = P1.Y;
            for (float i = 0.2f; i <= 1; i += 0.2f)
            {
                Points.Add(PointOnCurve(P0, M0S, M0, M1, i));
            }
            for (float i = 0.2f; i <= 1; i += 0.2f)
            {
                Points.Add(PointOnCurve(M0S, M0, M1, M1S, i));
            }
            for (float i = 0.2f; i <= 1; i += 0.2f)
            {
                Points.Add(PointOnCurve(M0, M1, M1S, P1, i));
            }
            return Points;
        }
        private Point PointOnCurve(Point p0, Point p1, Point p2, Point p3, float Factor)
        {
            Point Result = new Point();
            float Factor2 = Factor * Factor;
            float Factor3 = Factor2 * Factor;
            Result.X = (int)(0.5f * ((2.0f * p1.X) + (-p0.X + p2.X) * Factor + (2.0f * p0.X - 5.0f * p1.X + 4 * p2.X - p3.X) * Factor2 + (-p0.X + 3.0f * p1.X - 3.0f * p2.X + p3.X) * Factor3));
            Result.Y = (int)(0.5f * ((2.0f * p1.Y) + (-p0.Y + p2.Y) * Factor + (2.0f * p0.Y - 5.0f * p1.Y + 4 * p2.Y - p3.Y) * Factor2 + (-p0.Y + 3.0f * p1.Y - 3.0f * p2.Y + p3.Y) * Factor3));
            return Result;
        }
        private void DrawConnection(Point P0, Point P1)
        {
            List<Point> Points = GenerateCurve(P0, P1);
            Bitmap Buffer = new Bitmap(this.Width, this.Height);
            Graphics Draw = this.CreateGraphics();
            Graphics DrawBuffer = Graphics.FromImage(Buffer);
            DrawBuffer.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            DrawBuffer.Clear(Color.FromArgb(0, 0, 0, 0));
            Pen OrangePen = new Pen(Color.Silver, 1);
            Pen BlackPen = new Pen(Color.Gray, 3);
            Points.Insert(0, P0);
            Points.Add(P1);
            for (int i = 0; i < Points.Count - 1; i++)
            {
                DrawBuffer.DrawLine(BlackPen, Points[i], Points[i + 1]);
            }
            for (int i = 0; i < Points.Count - 1; i++)
            {
                DrawBuffer.DrawLine(OrangePen, Points[i], Points[i + 1]);
            }
            Draw.Clear(Color.FromArgb(255, 40, 40, 40));
            Draw.DrawImage(Buffer, 0, 0);
            DrawBuffer.Dispose();
            Draw.Dispose();
            Buffer.Dispose();
        }
        private void DrawConnections()
        {
            for(int i = 0; i < this._Nodes.Count; i++)
            {
                for(int j = 0; j < this._Nodes[i].Outputs.Count; j++)
                {
                    if(this._Nodes[i].Outputs[j].Output != null)
                    {
                        Point P0 = this._Nodes[i].Outputs[j].Holder.Location;
                        Point P1 = this._Nodes[i].Outputs[j].Output.Holder.Location;
                        P0.Y += this._Nodes[i].Outputs[j].NodeValueIndex * 20 + 31;
                        P0.X += this._Nodes[i].Outputs[j].Holder.Width;
                        P1.Y += this._Nodes[i].Outputs[j].Output.NodeValueIndex * 20 + 31;
                        DrawConnection(P0, P1);
                    }
                }
            }
            if(this._ConnectionInProgress)
            {
                Point P0 = this._ConnectionSeeker.Holder.Location;
                P0.Y += this._ConnectionSeeker.NodeValueIndex * 20 + 31;
                if(this._SeekType == 0)
                {
                    DrawConnection(this._LastMouseLocation, P0);
                }
                else
                {
                    P0.X += this._ConnectionSeeker.Holder.Width;
                    DrawConnection(P0, this._LastMouseLocation);
                }
            }
        }
        private void NodeEditor_Paint(object sender, PaintEventArgs e)
        {
            DrawConnections();
        }
        private void Connect_Input_Click(object sender, EventArgs e)
        {
            Control SenderAsControl = sender as Control;
            NodeValue Input = SenderAsControl.Tag as NodeValue;
            if (this._ConnectionInProgress && this._SeekType == 1)
            {
                if (Input.Holder == this._ConnectionSeeker.Holder)
                {
                    this._ConnectionSeeker = null;
                    this._ConnectionInProgress = false;
                    return;
                }
                if (Input.Input!=null)
                {
                    Input.Input.Output = null;
                    Input.Input.Holder.Invalidate();
                }
                if(this._ConnectionSeeker.Output!=null)
                {
                    this._ConnectionSeeker.Output.Input = null;
                    this._ConnectionSeeker.Output.Holder.Invalidate();
                }
                this._ConnectionSeeker.Output = Input;
                Input.Input = this._ConnectionSeeker;
                this._ConnectionSeeker = null;
                this._ConnectionInProgress = false;
                SenderAsControl.Invalidate();
                this.Invalidate();
            }
            else if(!this._ConnectionInProgress)
            {
                this._ConnectionInProgress = true;
                this._ConnectionSeeker = Input;
                this._SeekType = 0;
            }
            else
            {
                
            }
        }
        private void Connect_Output_Click(object sender, EventArgs e)
        {
            Control SenderAsControl = sender as Control;
            NodeValue Output = SenderAsControl.Tag as NodeValue;
            if (this._ConnectionInProgress && this._SeekType == 0)
            {
                if (Output.Holder == this._ConnectionSeeker.Holder)
                {
                    this._ConnectionSeeker = null;
                    this._ConnectionInProgress = false;
                    return;
                }
                if (Output.Output != null)
                {
                    Output.Output.Input = null;
                    Output.Output.Holder.Invalidate();
                }
                if (this._ConnectionSeeker.Input != null)
                {
                    this._ConnectionSeeker.Input.Output = null;
                    this._ConnectionSeeker.Input.Holder.Invalidate();
                }
                this._ConnectionSeeker.Input = Output;
                Output.Output = this._ConnectionSeeker;
                this._ConnectionSeeker = null;
                this._ConnectionInProgress = false;
                SenderAsControl.Invalidate();
                this.Invalidate();
            }
            else if (!this._ConnectionInProgress)
            {
                this._ConnectionInProgress = true;
                this._ConnectionSeeker = Output;
                this._SeekType = 1;
            }
            else
            {
                
            }
        }
        private void NodeEditor_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_ConnectionInProgress) return;
            this._LastMouseLocation = e.Location;
        }
    }
}
