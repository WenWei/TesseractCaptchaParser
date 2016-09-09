namespace ImageToGrayscale.Filters.FilterOptionsControls
{
    partial class BinarizationFilterOptions
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
            if(disposing && (components != null))
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
            this.lblThreshold = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.LabelThreshold = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(41, 40);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(23, 12);
            this.lblThreshold.TabIndex = 9;
            this.lblThreshold.Text = "200";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(70, 19);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(168, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 200;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // LabelThreshold
            // 
            this.LabelThreshold.AutoSize = true;
            this.LabelThreshold.Location = new System.Drawing.Point(12, 19);
            this.LabelThreshold.Name = "LabelThreshold";
            this.LabelThreshold.Size = new System.Drawing.Size(52, 12);
            this.LabelThreshold.TabIndex = 10;
            this.LabelThreshold.Text = "Threshold";
            // 
            // BinarizationFilterOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelThreshold);
            this.Controls.Add(this.lblThreshold);
            this.Controls.Add(this.trackBar1);
            this.Name = "BinarizationFilterOptions";
            this.Size = new System.Drawing.Size(248, 86);
            this.Load += new System.EventHandler(this.BinarizationFilterOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label LabelThreshold;
    }
}
