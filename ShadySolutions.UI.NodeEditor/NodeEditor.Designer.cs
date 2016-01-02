namespace ShadySolutions.UI.NodeEditor
{
    partial class NodeEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PaintTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PaintTimer
            // 
            this.PaintTimer.Enabled = true;
            this.PaintTimer.Interval = 20;
            this.PaintTimer.Tick += new System.EventHandler(this.PaintTimer_Tick);
            // 
            // NodeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Name = "NodeEditor";
            this.Size = new System.Drawing.Size(719, 534);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.NodeEditor_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NodeEditor_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NodeEditor_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer PaintTimer;
    }
}
