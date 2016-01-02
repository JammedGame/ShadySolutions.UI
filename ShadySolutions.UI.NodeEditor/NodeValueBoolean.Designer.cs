namespace ShadySolutions.UI.NodeEditor
{
    partial class NodeValueBoolean
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
            this.ValueBoolean = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ValueBoolean
            // 
            this.ValueBoolean.AutoSize = true;
            this.ValueBoolean.Dock = System.Windows.Forms.DockStyle.Right;
            this.ValueBoolean.Location = new System.Drawing.Point(165, 0);
            this.ValueBoolean.Name = "ValueBoolean";
            this.ValueBoolean.Size = new System.Drawing.Size(15, 20);
            this.ValueBoolean.TabIndex = 2;
            this.ValueBoolean.UseVisualStyleBackColor = true;
            this.ValueBoolean.CheckedChanged += new System.EventHandler(this.ValueCheck_CheckedChanged);
            // 
            // NodeValueBoolean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ValueBoolean);
            this.Name = "NodeValueBoolean";
            this.Controls.SetChildIndex(this.ValueBoolean, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ValueBoolean;
    }
}
