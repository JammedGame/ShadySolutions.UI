namespace ShadySolutions.UI.NodeEditor
{
    partial class NodeValueColor
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
            this.ValueColorPicker = new System.Windows.Forms.Button();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValueColorPicker
            // 
            this.ValueColorPicker.BackColor = System.Drawing.Color.Red;
            this.ValueColorPicker.Dock = System.Windows.Forms.DockStyle.Right;
            this.ValueColorPicker.FlatAppearance.BorderSize = 0;
            this.ValueColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValueColorPicker.ForeColor = System.Drawing.Color.White;
            this.ValueColorPicker.Location = new System.Drawing.Point(142, 0);
            this.ValueColorPicker.Name = "ValueColorPicker";
            this.ValueColorPicker.Size = new System.Drawing.Size(38, 20);
            this.ValueColorPicker.TabIndex = 3;
            this.ValueColorPicker.UseVisualStyleBackColor = false;
            this.ValueColorPicker.Click += new System.EventHandler(this.ValueColorPicker_Click);
            // 
            // ValueLabel
            // 
            this.ValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ValueLabel.Location = new System.Drawing.Point(105, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(37, 20);
            this.ValueLabel.TabIndex = 5;
            this.ValueLabel.Text = "Color";
            this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ValueLabel.Click += new System.EventHandler(this.ValueColorPicker_Click);
            // 
            // NodeValueColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.ValueColorPicker);
            this.Name = "NodeValueColor";
            this.Controls.SetChildIndex(this.ValueColorPicker, 0);
            this.Controls.SetChildIndex(this.ValueLabel, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ValueColorPicker;
        private System.Windows.Forms.Label ValueLabel;
    }
}
