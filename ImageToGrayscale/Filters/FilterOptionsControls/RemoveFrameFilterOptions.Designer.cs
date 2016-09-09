namespace ImageToGrayscale.Filters.FilterOptionsControls
{
    partial class RemoveFrameFilterOptions
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
            this.numTop = new System.Windows.Forms.NumericUpDown();
            this.numLeft = new System.Windows.Forms.NumericUpDown();
            this.numRight = new System.Windows.Forms.NumericUpDown();
            this.numBottom = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnColorBlack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnColorWhite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numTop
            // 
            this.numTop.Location = new System.Drawing.Point(78, 13);
            this.numTop.Name = "numTop";
            this.numTop.Size = new System.Drawing.Size(78, 22);
            this.numTop.TabIndex = 0;
            this.numTop.ValueChanged += new System.EventHandler(this.numTop_ValueChanged);
            // 
            // numLeft
            // 
            this.numLeft.Location = new System.Drawing.Point(13, 69);
            this.numLeft.Name = "numLeft";
            this.numLeft.Size = new System.Drawing.Size(78, 22);
            this.numLeft.TabIndex = 1;
            this.numLeft.ValueChanged += new System.EventHandler(this.numLeft_ValueChanged);
            // 
            // numRight
            // 
            this.numRight.Location = new System.Drawing.Point(146, 69);
            this.numRight.Name = "numRight";
            this.numRight.Size = new System.Drawing.Size(78, 22);
            this.numRight.TabIndex = 3;
            this.numRight.ValueChanged += new System.EventHandler(this.numRight_ValueChanged);
            // 
            // numBottom
            // 
            this.numBottom.Location = new System.Drawing.Point(78, 124);
            this.numBottom.Name = "numBottom";
            this.numBottom.Size = new System.Drawing.Size(78, 22);
            this.numBottom.TabIndex = 2;
            this.numBottom.ValueChanged += new System.EventHandler(this.numBottom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Top";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Right";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bottom";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(250, 69);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(50, 23);
            this.btnColor.TabIndex = 8;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnColorBlack
            // 
            this.btnColorBlack.Location = new System.Drawing.Point(250, 98);
            this.btnColorBlack.Name = "btnColorBlack";
            this.btnColorBlack.Size = new System.Drawing.Size(50, 23);
            this.btnColorBlack.TabIndex = 9;
            this.btnColorBlack.Text = "black";
            this.btnColorBlack.UseVisualStyleBackColor = true;
            this.btnColorBlack.Click += new System.EventHandler(this.btnColorBlack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(250, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 31);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnColorWhite
            // 
            this.btnColorWhite.Location = new System.Drawing.Point(250, 124);
            this.btnColorWhite.Name = "btnColorWhite";
            this.btnColorWhite.Size = new System.Drawing.Size(50, 23);
            this.btnColorWhite.TabIndex = 11;
            this.btnColorWhite.Text = "white";
            this.btnColorWhite.UseVisualStyleBackColor = true;
            this.btnColorWhite.Click += new System.EventHandler(this.btnColorWhite_Click);
            // 
            // RemoveFrameFilterOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnColorWhite);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnColorBlack);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numRight);
            this.Controls.Add(this.numBottom);
            this.Controls.Add(this.numLeft);
            this.Controls.Add(this.numTop);
            this.Name = "RemoveFrameFilterOptions";
            this.Size = new System.Drawing.Size(332, 176);
            this.Load += new System.EventHandler(this.RemoveFrameFilterOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTop;
        private System.Windows.Forms.NumericUpDown numLeft;
        private System.Windows.Forms.NumericUpDown numRight;
        private System.Windows.Forms.NumericUpDown numBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnColorBlack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnColorWhite;
    }
}
