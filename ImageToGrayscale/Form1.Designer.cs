namespace ImageToGrayscale
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
            this.btnDownloadImage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.pictureBoxRaw = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelRaw = new System.Windows.Forms.Panel();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoadFilters = new System.Windows.Forms.Button();
            this.btnSaveFilters = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.filterOptionPanel = new System.Windows.Forms.Panel();
            this.btnRemoveFilter = new System.Windows.Forms.Button();
            this.listBoxFilter = new System.Windows.Forms.ListBox();
            this.buttonAddFilter = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnParseRegions = new System.Windows.Forms.Button();
            this.textBoxRegions = new System.Windows.Forms.TextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.textBoxParse = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBoxRegion = new System.Windows.Forms.PictureBox();
            this.pictureBoxRegionItem0 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRegionItem1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRegionItem2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRegionItem3 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBoxApplyFilters = new System.Windows.Forms.PictureBox();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxCharacters = new System.Windows.Forms.TextBox();
            this.labelCharacters = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaw)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelRaw.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegionItem0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegionItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegionItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegionItem3)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApplyFilters)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDownloadImage
            // 
            this.btnDownloadImage.Location = new System.Drawing.Point(442, 23);
            this.btnDownloadImage.Name = "btnDownloadImage";
            this.btnDownloadImage.Size = new System.Drawing.Size(75, 25);
            this.btnDownloadImage.TabIndex = 0;
            this.btnDownloadImage.Text = "Download Image";
            this.btnDownloadImage.UseVisualStyleBackColor = true;
            this.btnDownloadImage.Click += new System.EventHandler(this.btnDownloadImage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 26);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 13);
            this.lblUrl.TabIndex = 2;
            this.lblUrl.Text = "URL:";
            // 
            // pictureBoxRaw
            // 
            this.pictureBoxRaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRaw.Location = new System.Drawing.Point(7, 6);
            this.pictureBoxRaw.Name = "pictureBoxRaw";
            this.pictureBoxRaw.Size = new System.Drawing.Size(117, 49);
            this.pictureBoxRaw.TabIndex = 2;
            this.pictureBoxRaw.TabStop = false;
            this.pictureBoxRaw.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxRaw_Paint);
            this.pictureBoxRaw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRaw_MouseDown);
            this.pictureBoxRaw.MouseEnter += new System.EventHandler(this.pictureBoxRaw_MouseEnter);
            this.pictureBoxRaw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRaw_MouseMove);
            this.pictureBoxRaw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRaw_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origin:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(94, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 25);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(523, 23);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 25);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelRaw);
            this.groupBox1.Controls.Add(this.lblHeight);
            this.groupBox1.Controls.Add(this.lblWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDownloadImage);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblUrl);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 95);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1. Open Image File";
            // 
            // panelRaw
            // 
            this.panelRaw.AutoScroll = true;
            this.panelRaw.Controls.Add(this.pictureBoxRaw);
            this.panelRaw.Location = new System.Drawing.Point(602, 22);
            this.panelRaw.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panelRaw.Name = "panelRaw";
            this.panelRaw.Size = new System.Drawing.Size(293, 66);
            this.panelRaw.TabIndex = 7;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(137, 64);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(50, 64);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 5;
            this.lblWidth.Text = "Width";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoadFilters);
            this.groupBox2.Controls.Add(this.btnSaveFilters);
            this.groupBox2.Controls.Add(this.btnMoveDown);
            this.groupBox2.Controls.Add(this.btnMoveUp);
            this.groupBox2.Controls.Add(this.filterOptionPanel);
            this.groupBox2.Controls.Add(this.btnRemoveFilter);
            this.groupBox2.Controls.Add(this.listBoxFilter);
            this.groupBox2.Controls.Add(this.buttonAddFilter);
            this.groupBox2.Controls.Add(this.cmbFilter);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 464);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2. Add filters";
            // 
            // btnLoadFilters
            // 
            this.btnLoadFilters.Location = new System.Drawing.Point(258, 261);
            this.btnLoadFilters.Name = "btnLoadFilters";
            this.btnLoadFilters.Size = new System.Drawing.Size(84, 25);
            this.btnLoadFilters.TabIndex = 14;
            this.btnLoadFilters.Text = "Load";
            this.btnLoadFilters.UseVisualStyleBackColor = true;
            this.btnLoadFilters.Click += new System.EventHandler(this.btnLoadFilters_Click);
            // 
            // btnSaveFilters
            // 
            this.btnSaveFilters.Location = new System.Drawing.Point(259, 229);
            this.btnSaveFilters.Name = "btnSaveFilters";
            this.btnSaveFilters.Size = new System.Drawing.Size(84, 25);
            this.btnSaveFilters.TabIndex = 13;
            this.btnSaveFilters.Text = "Save";
            this.btnSaveFilters.UseVisualStyleBackColor = true;
            this.btnSaveFilters.Click += new System.EventHandler(this.btnSaveFilters_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(259, 126);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(84, 25);
            this.btnMoveDown.TabIndex = 12;
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(259, 94);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(84, 25);
            this.btnMoveUp.TabIndex = 11;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // filterOptionPanel
            // 
            this.filterOptionPanel.AutoScroll = true;
            this.filterOptionPanel.Location = new System.Drawing.Point(349, 31);
            this.filterOptionPanel.Name = "filterOptionPanel";
            this.filterOptionPanel.Size = new System.Drawing.Size(277, 426);
            this.filterOptionPanel.TabIndex = 10;
            // 
            // btnRemoveFilter
            // 
            this.btnRemoveFilter.Location = new System.Drawing.Point(259, 63);
            this.btnRemoveFilter.Name = "btnRemoveFilter";
            this.btnRemoveFilter.Size = new System.Drawing.Size(84, 25);
            this.btnRemoveFilter.TabIndex = 9;
            this.btnRemoveFilter.Text = "Remove";
            this.btnRemoveFilter.UseVisualStyleBackColor = true;
            this.btnRemoveFilter.Click += new System.EventHandler(this.btnRemoveFilter_Click);
            // 
            // listBoxFilter
            // 
            this.listBoxFilter.DisplayMember = "Name";
            this.listBoxFilter.FormattingEnabled = true;
            this.listBoxFilter.Location = new System.Drawing.Point(19, 61);
            this.listBoxFilter.Name = "listBoxFilter";
            this.listBoxFilter.Size = new System.Drawing.Size(234, 394);
            this.listBoxFilter.TabIndex = 8;
            this.listBoxFilter.SelectedIndexChanged += new System.EventHandler(this.listBoxFilter_SelectedIndexChanged);
            // 
            // buttonAddFilter
            // 
            this.buttonAddFilter.Location = new System.Drawing.Point(259, 31);
            this.buttonAddFilter.Name = "buttonAddFilter";
            this.buttonAddFilter.Size = new System.Drawing.Size(84, 25);
            this.buttonAddFilter.TabIndex = 7;
            this.buttonAddFilter.Text = "Add";
            this.buttonAddFilter.UseVisualStyleBackColor = true;
            this.buttonAddFilter.Click += new System.EventHandler(this.buttonAddFilter_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(59, 31);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(194, 21);
            this.cmbFilter.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Filters:";
            // 
            // btnParseRegions
            // 
            this.btnParseRegions.Location = new System.Drawing.Point(6, 22);
            this.btnParseRegions.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnParseRegions.Name = "btnParseRegions";
            this.btnParseRegions.Size = new System.Drawing.Size(117, 25);
            this.btnParseRegions.TabIndex = 14;
            this.btnParseRegions.Text = "Parse Regions";
            this.btnParseRegions.UseVisualStyleBackColor = true;
            this.btnParseRegions.Click += new System.EventHandler(this.btnParseRegions_Click);
            // 
            // textBoxRegions
            // 
            this.textBoxRegions.Location = new System.Drawing.Point(129, 22);
            this.textBoxRegions.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxRegions.Name = "textBoxRegions";
            this.textBoxRegions.Size = new System.Drawing.Size(116, 20);
            this.textBoxRegions.TabIndex = 15;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(6, 42);
            this.btnParse.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(251, 25);
            this.btnParse.TabIndex = 12;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // textBoxParse
            // 
            this.textBoxParse.Location = new System.Drawing.Point(7, 70);
            this.textBoxParse.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxParse.Name = "textBoxParse";
            this.textBoxParse.Size = new System.Drawing.Size(250, 20);
            this.textBoxParse.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelCharacters);
            this.groupBox5.Controls.Add(this.textBoxCharacters);
            this.groupBox5.Controls.Add(this.pictureBoxRegion);
            this.groupBox5.Controls.Add(this.btnParse);
            this.groupBox5.Controls.Add(this.textBoxParse);
            this.groupBox5.Location = new System.Drawing.Point(650, 315);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(274, 264);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Step 4. Recognition";
            // 
            // pictureBoxRegion
            // 
            this.pictureBoxRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRegion.Location = new System.Drawing.Point(6, 95);
            this.pictureBoxRegion.Name = "pictureBoxRegion";
            this.pictureBoxRegion.Size = new System.Drawing.Size(251, 160);
            this.pictureBoxRegion.TabIndex = 8;
            this.pictureBoxRegion.TabStop = false;
            // 
            // pictureBoxRegionItem0
            // 
            this.pictureBoxRegionItem0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRegionItem0.Location = new System.Drawing.Point(7, 65);
            this.pictureBoxRegionItem0.Name = "pictureBoxRegionItem0";
            this.pictureBoxRegionItem0.Size = new System.Drawing.Size(55, 77);
            this.pictureBoxRegionItem0.TabIndex = 17;
            this.pictureBoxRegionItem0.TabStop = false;
            // 
            // pictureBoxRegionItem1
            // 
            this.pictureBoxRegionItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRegionItem1.Location = new System.Drawing.Point(68, 65);
            this.pictureBoxRegionItem1.Name = "pictureBoxRegionItem1";
            this.pictureBoxRegionItem1.Size = new System.Drawing.Size(55, 77);
            this.pictureBoxRegionItem1.TabIndex = 18;
            this.pictureBoxRegionItem1.TabStop = false;
            // 
            // pictureBoxRegionItem2
            // 
            this.pictureBoxRegionItem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRegionItem2.Location = new System.Drawing.Point(129, 65);
            this.pictureBoxRegionItem2.Name = "pictureBoxRegionItem2";
            this.pictureBoxRegionItem2.Size = new System.Drawing.Size(55, 77);
            this.pictureBoxRegionItem2.TabIndex = 19;
            this.pictureBoxRegionItem2.TabStop = false;
            // 
            // pictureBoxRegionItem3
            // 
            this.pictureBoxRegionItem3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRegionItem3.Location = new System.Drawing.Point(190, 65);
            this.pictureBoxRegionItem3.Name = "pictureBoxRegionItem3";
            this.pictureBoxRegionItem3.Size = new System.Drawing.Size(55, 77);
            this.pictureBoxRegionItem3.TabIndex = 20;
            this.pictureBoxRegionItem3.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBoxApplyFilters);
            this.groupBox6.Controls.Add(this.btnApplyFilters);
            this.groupBox6.Controls.Add(this.btnSave);
            this.groupBox6.Location = new System.Drawing.Point(650, 115);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(274, 194);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Step 3. Apply filters";
            // 
            // pictureBoxApplyFilters
            // 
            this.pictureBoxApplyFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxApplyFilters.Location = new System.Drawing.Point(6, 61);
            this.pictureBoxApplyFilters.Name = "pictureBoxApplyFilters";
            this.pictureBoxApplyFilters.Size = new System.Drawing.Size(251, 121);
            this.pictureBoxApplyFilters.TabIndex = 9;
            this.pictureBoxApplyFilters.TabStop = false;
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.Location = new System.Drawing.Point(6, 28);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(82, 25);
            this.btnApplyFilters.TabIndex = 8;
            this.btnApplyFilters.Text = "Apply Filters";
            this.btnApplyFilters.UseVisualStyleBackColor = true;
            this.btnApplyFilters.Click += new System.EventHandler(this.btnApplyFilters_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBoxRegionItem0);
            this.groupBox3.Controls.Add(this.pictureBoxRegionItem1);
            this.groupBox3.Controls.Add(this.btnParseRegions);
            this.groupBox3.Controls.Add(this.pictureBoxRegionItem3);
            this.groupBox3.Controls.Add(this.textBoxRegions);
            this.groupBox3.Controls.Add(this.pictureBoxRegionItem2);
            this.groupBox3.Location = new System.Drawing.Point(656, 585);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 164);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 4. Recognition";
            this.groupBox3.Visible = false;
            // 
            // textBoxCharacters
            // 
            this.textBoxCharacters.Location = new System.Drawing.Point(71, 18);
            this.textBoxCharacters.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBoxCharacters.Name = "textBoxCharacters";
            this.textBoxCharacters.Size = new System.Drawing.Size(186, 20);
            this.textBoxCharacters.TabIndex = 14;
            this.textBoxCharacters.Text = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-";
            // 
            // labelCharacters
            // 
            this.labelCharacters.AutoSize = true;
            this.labelCharacters.Location = new System.Drawing.Point(6, 21);
            this.labelCharacters.Name = "labelCharacters";
            this.labelCharacters.Size = new System.Drawing.Size(61, 13);
            this.labelCharacters.TabIndex = 15;
            this.labelCharacters.Text = "Characters:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 587);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "OCR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaw)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelRaw.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegionItem0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegionItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegionItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegionItem3)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApplyFilters)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDownloadImage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.PictureBox pictureBoxRaw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnParseRegions;
        private System.Windows.Forms.TextBox textBoxRegions;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TextBox textBoxParse;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBoxRegion;
        private System.Windows.Forms.PictureBox pictureBoxRegionItem0;
        private System.Windows.Forms.PictureBox pictureBoxRegionItem1;
        private System.Windows.Forms.PictureBox pictureBoxRegionItem2;
        private System.Windows.Forms.PictureBox pictureBoxRegionItem3;
        private System.Windows.Forms.ListBox listBoxFilter;
        private System.Windows.Forms.Button buttonAddFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox pictureBoxApplyFilters;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.Button btnRemoveFilter;
        private System.Windows.Forms.Panel filterOptionPanel;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLoadFilters;
        private System.Windows.Forms.Button btnSaveFilters;
        private System.Windows.Forms.Panel panelRaw;
        private System.Windows.Forms.Label labelCharacters;
        private System.Windows.Forms.TextBox textBoxCharacters;
    }
}

