namespace ShadySolutions.UI.NodeEditor
{
    partial class NodeValueVector
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
            this.ValueVector = new System.Windows.Forms.PictureBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ValueVector)).BeginInit();
            this.SuspendLayout();
            // 
            // ValueVector
            // 
            this.ValueVector.BackgroundImage = global::ShadySolutions.UI.NodeEditor.Properties.Resources.point_icon;
            this.ValueVector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ValueVector.Dock = System.Windows.Forms.DockStyle.Right;
            this.ValueVector.Location = new System.Drawing.Point(160, 0);
            this.ValueVector.Margin = new System.Windows.Forms.Padding(0);
            this.ValueVector.Name = "ValueVector";
            this.ValueVector.Size = new System.Drawing.Size(20, 20);
            this.ValueVector.TabIndex = 3;
            this.ValueVector.TabStop = false;
            this.ValueVector.Click += new System.EventHandler(this.ValueVector_Click);
            // 
            // ValueLabel
            // 
            this.ValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ValueLabel.Location = new System.Drawing.Point(105, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(55, 20);
            this.ValueLabel.TabIndex = 4;
            this.ValueLabel.Text = "Vector";
            this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ValueLabel.Click += new System.EventHandler(this.ValueVector_Click);
            // 
            // NodeValueVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.ValueVector);
            this.Name = "NodeValueVector";
            this.Controls.SetChildIndex(this.ValueVector, 0);
            this.Controls.SetChildIndex(this.ValueLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ValueVector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ValueVector;
        private System.Windows.Forms.Label ValueLabel;
    }
}
