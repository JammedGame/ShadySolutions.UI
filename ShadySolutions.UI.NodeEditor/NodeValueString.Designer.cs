namespace ShadySolutions.UI.NodeEditor
{
    partial class NodeValueString
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
            this.ValueString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ValueString
            // 
            this.ValueString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ValueString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValueString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueString.Location = new System.Drawing.Point(105, 0);
            this.ValueString.Name = "ValueString";
            this.ValueString.Size = new System.Drawing.Size(75, 20);
            this.ValueString.TabIndex = 3;
            this.ValueString.TextChanged += new System.EventHandler(this.ValueString_TextChanged);
            // 
            // NodeValueString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ValueString);
            this.Name = "NodeValueString";
            this.Controls.SetChildIndex(this.ValueString, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ValueString;
    }
}
