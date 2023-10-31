namespace frmChallan
{
    partial class frmCannibalizedProductInformation
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCannibalizedInformation = new System.Windows.Forms.DataGridView();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.optDate = new System.Windows.Forms.RadioButton();
            this.optAll = new System.Windows.Forms.RadioButton();
            this.optDetails = new System.Windows.Forms.RadioButton();
            this.optSummery = new System.Windows.Forms.RadioButton();
            this.tblPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lnkReport = new System.Windows.Forms.LinkLabel();
            this.btnExport = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblTop = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCannibalizedInformation)).BeginInit();
            this.tblPanelMain.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblTop.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCannibalizedInformation
            // 
            this.dgvCannibalizedInformation.AllowUserToAddRows = false;
            this.dgvCannibalizedInformation.AllowUserToDeleteRows = false;
            this.dgvCannibalizedInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCannibalizedInformation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCannibalizedInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCannibalizedInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCannibalizedInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCannibalizedInformation.EnableHeadersVisualStyles = false;
            this.dgvCannibalizedInformation.GridColor = System.Drawing.Color.Lime;
            this.dgvCannibalizedInformation.Location = new System.Drawing.Point(3, 84);
            this.dgvCannibalizedInformation.MultiSelect = false;
            this.dgvCannibalizedInformation.Name = "dgvCannibalizedInformation";
            this.dgvCannibalizedInformation.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCannibalizedInformation.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvCannibalizedInformation.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCannibalizedInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCannibalizedInformation.Size = new System.Drawing.Size(678, 432);
            this.dgvCannibalizedInformation.TabIndex = 0;
            this.dgvCannibalizedInformation.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCannibalizedInformation_DataBindingComplete);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.CustomFormat = "dd-MMM-yy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(143, 6);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(140, 20);
            this.dtpStartDate.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.BackColor = System.Drawing.Color.Green;
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(560, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(109, 26);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Date";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTo.CustomFormat = "dd-MMM-yy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(429, 6);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(125, 20);
            this.dtpTo.TabIndex = 1;
            // 
            // optDate
            // 
            this.optDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.optDate.AutoSize = true;
            this.optDate.Location = new System.Drawing.Point(51, 3);
            this.optDate.Name = "optDate";
            this.optDate.Size = new System.Drawing.Size(48, 17);
            this.optDate.TabIndex = 4;
            this.optDate.Text = "Date";
            this.optDate.UseVisualStyleBackColor = true;
            this.optDate.CheckedChanged += new System.EventHandler(this.optDate_CheckedChanged);
            // 
            // optAll
            // 
            this.optAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.optAll.AutoSize = true;
            this.optAll.Checked = true;
            this.optAll.Location = new System.Drawing.Point(9, 5);
            this.optAll.Name = "optAll";
            this.optAll.Size = new System.Drawing.Size(36, 17);
            this.optAll.TabIndex = 5;
            this.optAll.TabStop = true;
            this.optAll.Text = "All";
            this.optAll.UseVisualStyleBackColor = true;
            this.optAll.CheckedChanged += new System.EventHandler(this.optAll_CheckedChanged);
            // 
            // optDetails
            // 
            this.optDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.optDetails.AutoSize = true;
            this.optDetails.Checked = true;
            this.optDetails.Location = new System.Drawing.Point(3, 3);
            this.optDetails.Name = "optDetails";
            this.optDetails.Size = new System.Drawing.Size(57, 17);
            this.optDetails.TabIndex = 7;
            this.optDetails.TabStop = true;
            this.optDetails.Text = "&Details";
            this.optDetails.UseVisualStyleBackColor = true;
            this.optDetails.CheckedChanged += new System.EventHandler(this.optDetails_CheckedChanged);
            // 
            // optSummery
            // 
            this.optSummery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.optSummery.AutoSize = true;
            this.optSummery.Location = new System.Drawing.Point(71, 4);
            this.optSummery.Name = "optSummery";
            this.optSummery.Size = new System.Drawing.Size(68, 17);
            this.optSummery.TabIndex = 6;
            this.optSummery.Text = "&Summery";
            this.optSummery.UseVisualStyleBackColor = true;
            this.optSummery.CheckedChanged += new System.EventHandler(this.optSummery_CheckedChanged);
            // 
            // tblPanelMain
            // 
            this.tblPanelMain.BackColor = System.Drawing.Color.SeaGreen;
            this.tblPanelMain.ColumnCount = 1;
            this.tblPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelMain.Controls.Add(this.dgvCannibalizedInformation, 0, 1);
            this.tblPanelMain.Controls.Add(this.pnlBottom, 0, 2);
            this.tblPanelMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tblPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelMain.ForeColor = System.Drawing.Color.White;
            this.tblPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tblPanelMain.Name = "tblPanelMain";
            this.tblPanelMain.RowCount = 3;
            this.tblPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tblPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tblPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPanelMain.Size = new System.Drawing.Size(684, 562);
            this.tblPanelMain.TabIndex = 9;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.DarkRed;
            this.pnlBottom.Controls.Add(this.lnkReport);
            this.pnlBottom.Controls.Add(this.btnExport);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.ForeColor = System.Drawing.Color.White;
            this.pnlBottom.Location = new System.Drawing.Point(3, 522);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(678, 37);
            this.pnlBottom.TabIndex = 2;
            // 
            // lnkReport
            // 
            this.lnkReport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lnkReport.AutoSize = true;
            this.lnkReport.Enabled = false;
            this.lnkReport.LinkColor = System.Drawing.Color.White;
            this.lnkReport.Location = new System.Drawing.Point(630, 12);
            this.lnkReport.Name = "lnkReport";
            this.lnkReport.Size = new System.Drawing.Size(39, 13);
            this.lnkReport.TabIndex = 1;
            this.lnkReport.TabStop = true;
            this.lnkReport.Text = "Report";
            this.lnkReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReport_LinkClicked);
            // 
            // btnExport
            // 
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(6, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(126, 25);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tblTop, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 75);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tblTop
            // 
            this.tblTop.ColumnCount = 5;
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.4026F));
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.5065F));
            this.tblTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.09091F));
            this.tblTop.Controls.Add(this.label1, 0, 0);
            this.tblTop.Controls.Add(this.dtpStartDate, 1, 0);
            this.tblTop.Controls.Add(this.label2, 2, 0);
            this.tblTop.Controls.Add(this.btnLoad, 4, 0);
            this.tblTop.Controls.Add(this.dtpTo, 3, 0);
            this.tblTop.Location = new System.Drawing.Point(3, 40);
            this.tblTop.Name = "tblTop";
            this.tblTop.RowCount = 1;
            this.tblTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblTop.Size = new System.Drawing.Size(672, 32);
            this.tblTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "End Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.97174F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.98268F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.02279F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.02279F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(672, 31);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Brand";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.optSummery);
            this.panel1.Controls.Add(this.optDetails);
            this.panel1.Location = new System.Drawing.Point(120, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 25);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.optAll);
            this.panel2.Controls.Add(this.optDate);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 25);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbCategory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(546, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 25);
            this.panel3.TabIndex = 14;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(0, 0);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(123, 21);
            this.cmbCategory.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbBrand);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(338, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(122, 25);
            this.panel4.TabIndex = 15;
            // 
            // cmbBrand
            // 
            this.cmbBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(0, 0);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(122, 21);
            this.cmbBrand.TabIndex = 0;
            // 
            // frmCannibalizedProductInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 562);
            this.Controls.Add(this.tblPanelMain);
            this.Name = "frmCannibalizedProductInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cannibalized Information";
            this.Load += new System.EventHandler(this.frmCannibalizedProductInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCannibalizedInformation)).EndInit();
            this.tblPanelMain.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tblTop.ResumeLayout(false);
            this.tblTop.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCannibalizedInformation;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.RadioButton optDate;
        private System.Windows.Forms.RadioButton optAll;
        private System.Windows.Forms.RadioButton optDetails;
        private System.Windows.Forms.RadioButton optSummery;
        private System.Windows.Forms.TableLayoutPanel tblPanelMain;
        private System.Windows.Forms.TableLayoutPanel tblTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel lnkReport;
    }
}