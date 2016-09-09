namespace TesseractDemo
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpen = new System.Windows.Forms.Button();
            this.pictureBoxRaw = new System.Windows.Forms.PictureBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaw)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(106, 70);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(163, 46);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pictureBoxRaw
            // 
            this.pictureBoxRaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRaw.Location = new System.Drawing.Point(106, 128);
            this.pictureBoxRaw.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pictureBoxRaw.Name = "pictureBoxRaw";
            this.pictureBoxRaw.Size = new System.Drawing.Size(160, 122);
            this.pictureBoxRaw.TabIndex = 1;
            this.pictureBoxRaw.TabStop = false;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(323, 70);
            this.btnParse.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(163, 46);
            this.btnParse.TabIndex = 2;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 128);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 268);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 910);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.pictureBoxRaw);
            this.Controls.Add(this.btnOpen);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox pictureBoxRaw;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TextBox textBox1;
    }
}

