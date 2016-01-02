namespace ShadySolutions.UI.NodeEditor
{
    partial class NodeValueFloat
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
            this.ValueFloat = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ValueFloat)).BeginInit();
            this.SuspendLayout();
            // 
            // ValueFloat
            // 
            this.ValueFloat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ValueFloat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValueFloat.DecimalPlaces = 2;
            this.ValueFloat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueFloat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueFloat.ForeColor = System.Drawing.Color.White;
            this.ValueFloat.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ValueFloat.Location = new System.Drawing.Point(105, 0);
            this.ValueFloat.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.ValueFloat.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.ValueFloat.Name = "ValueFloat";
            this.ValueFloat.Size = new System.Drawing.Size(75, 20);
            this.ValueFloat.TabIndex = 3;
            this.ValueFloat.ValueChanged += new System.EventHandler(this.ValueFloat_ValueChanged);
            // 
            // NodeValueFloat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ValueFloat);
            this.Name = "NodeValueFloat";
            this.Controls.SetChildIndex(this.ValueFloat, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ValueFloat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ValueFloat;
    }
}
