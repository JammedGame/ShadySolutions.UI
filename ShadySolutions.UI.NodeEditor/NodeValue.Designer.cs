namespace ShadySolutions.UI.NodeEditor
{
    partial class NodeValue
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
            this.TextLabel = new System.Windows.Forms.Label();
            this.NodeOutputConnector = new System.Windows.Forms.PictureBox();
            this.NodeInputConnector = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NodeOutputConnector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NodeInputConnector)).BeginInit();
            this.SuspendLayout();
            // 
            // TextLabel
            // 
            this.TextLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TextLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel.ForeColor = System.Drawing.Color.Transparent;
            this.TextLabel.Location = new System.Drawing.Point(20, 0);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(85, 20);
            this.TextLabel.TabIndex = 0;
            this.TextLabel.Text = "Value_Text";
            this.TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NodeOutputConnector
            // 
            this.NodeOutputConnector.BackgroundImage = global::ShadySolutions.UI.NodeEditor.Properties.Resources.join_blue;
            this.NodeOutputConnector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NodeOutputConnector.Dock = System.Windows.Forms.DockStyle.Right;
            this.NodeOutputConnector.Location = new System.Drawing.Point(180, 0);
            this.NodeOutputConnector.Margin = new System.Windows.Forms.Padding(0);
            this.NodeOutputConnector.Name = "NodeOutputConnector";
            this.NodeOutputConnector.Size = new System.Drawing.Size(20, 20);
            this.NodeOutputConnector.TabIndex = 2;
            this.NodeOutputConnector.TabStop = false;
            this.NodeOutputConnector.Paint += new System.Windows.Forms.PaintEventHandler(this.NodeOutputConnector_Paint);
            this.NodeOutputConnector.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NodeOutputConnector_MouseClick);
            // 
            // NodeInputConnector
            // 
            this.NodeInputConnector.BackgroundImage = global::ShadySolutions.UI.NodeEditor.Properties.Resources.join;
            this.NodeInputConnector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NodeInputConnector.Dock = System.Windows.Forms.DockStyle.Left;
            this.NodeInputConnector.Location = new System.Drawing.Point(0, 0);
            this.NodeInputConnector.Margin = new System.Windows.Forms.Padding(0);
            this.NodeInputConnector.Name = "NodeInputConnector";
            this.NodeInputConnector.Size = new System.Drawing.Size(20, 20);
            this.NodeInputConnector.TabIndex = 1;
            this.NodeInputConnector.TabStop = false;
            this.NodeInputConnector.Paint += new System.Windows.Forms.PaintEventHandler(this.NodeInputConnector_Paint);
            this.NodeInputConnector.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NodeInputConnector_MouseClick);
            // 
            // NodeValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.NodeOutputConnector);
            this.Controls.Add(this.NodeInputConnector);
            this.Name = "NodeValue";
            this.Size = new System.Drawing.Size(200, 20);
            ((System.ComponentModel.ISupportInitialize)(this.NodeOutputConnector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NodeInputConnector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.PictureBox NodeInputConnector;
        private System.Windows.Forms.PictureBox NodeOutputConnector;
    }
}
