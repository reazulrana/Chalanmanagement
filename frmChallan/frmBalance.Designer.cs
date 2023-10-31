namespace frmChallan
{
    partial class frmBalance
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProductBlance = new System.Windows.Forms.DataGridView();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntxProductMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntxReceiveDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxDeliveryDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.productBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.optDate = new System.Windows.Forms.RadioButton();
            this.optAll = new System.Windows.Forms.RadioButton();
            this.lnkExport = new System.Windows.Forms.LinkLabel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBotom = new System.Windows.Forms.Panel();
            this.tblpnlBotom = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStockInhand = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalReceive = new System.Windows.Forms.Label();
            this.lblTotalDelivery = new System.Windows.Forms.Label();
            this.lblBalanceTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductBlance)).BeginInit();
            this.cntxProductMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBalanceBindingSource)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlBotom.SuspendLayout();
            this.tblpnlBotom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductBlance
            // 
            this.dgvProductBlance.AllowUserToAddRows = false;
            this.dgvProductBlance.AllowUserToDeleteRows = false;
            this.dgvProductBlance.AutoGenerateColumns = false;
            this.dgvProductBlance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductBlance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductBlance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductBlance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductBlance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelDataGridViewTextBoxColumn,
            this.receivedDataGridViewTextBoxColumn,
            this.deliveredDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dgvProductBlance.ContextMenuStrip = this.cntxProductMenu;
            this.dgvProductBlance.DataSource = this.productBalanceBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductBlance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductBlance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductBlance.EnableHeadersVisualStyles = false;
            this.dgvProductBlance.GridColor = System.Drawing.Color.White;
            this.dgvProductBlance.Location = new System.Drawing.Point(0, 0);
            this.dgvProductBlance.Name = "dgvProductBlance";
            this.dgvProductBlance.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductBlance.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductBlance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductBlance.Size = new System.Drawing.Size(784, 395);
            this.dgvProductBlance.TabIndex = 0;
            this.dgvProductBlance.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvProductBlance_DataBindingComplete);
            this.dgvProductBlance.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProductBlance_MouseDoubleClick);
            this.dgvProductBlance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvProductBlance_MouseUp);
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receivedDataGridViewTextBoxColumn
            // 
            this.receivedDataGridViewTextBoxColumn.DataPropertyName = "Received";
            this.receivedDataGridViewTextBoxColumn.HeaderText = "Received";
            this.receivedDataGridViewTextBoxColumn.Name = "receivedDataGridViewTextBoxColumn";
            this.receivedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveredDataGridViewTextBoxColumn
            // 
            this.deliveredDataGridViewTextBoxColumn.DataPropertyName = "Delivered";
            this.deliveredDataGridViewTextBoxColumn.HeaderText = "Delivered";
            this.deliveredDataGridViewTextBoxColumn.Name = "deliveredDataGridViewTextBoxColumn";
            this.deliveredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cntxProductMenu
            // 
            this.cntxProductMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxReceiveDetails,
            this.cntxDeliveryDetails});
            this.cntxProductMenu.Name = "cntxProductMenu";
            this.cntxProductMenu.Size = new System.Drawing.Size(155, 48);
            // 
            // cntxReceiveDetails
            // 
            this.cntxReceiveDetails.Name = "cntxReceiveDetails";
            this.cntxReceiveDetails.Size = new System.Drawing.Size(154, 22);
            this.cntxReceiveDetails.Text = "&Receive Details";
            this.cntxReceiveDetails.Click += new System.EventHandler(this.cntxReceiveDetails_Click);
            // 
            // cntxDeliveryDetails
            // 
            this.cntxDeliveryDetails.Name = "cntxDeliveryDetails";
            this.cntxDeliveryDetails.Size = new System.Drawing.Size(154, 22);
            this.cntxDeliveryDetails.Text = "&Delivery Details";
            this.cntxDeliveryDetails.Click += new System.EventHandler(this.cntxDeliveryDetails_Click);
            // 
            // productBalanceBindingSource
            // 
            this.productBalanceBindingSource.DataSource = typeof(BussinessLibrary.SupportLibrary.ProductBalance);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Maroon;
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitle.Controls.Add(this.optDate);
            this.pnlTitle.Controls.Add(this.optAll);
            this.pnlTitle.Controls.Add(this.lnkExport);
            this.pnlTitle.Controls.Add(this.btnLoad);
            this.pnlTitle.Controls.Add(this.cmbCategory);
            this.pnlTitle.Controls.Add(this.cmbBrand);
            this.pnlTitle.Controls.Add(this.label5);
            this.pnlTitle.Controls.Add(this.label3);
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Controls.Add(this.picClose);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.ForeColor = System.Drawing.Color.White;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(784, 135);
            this.pnlTitle.TabIndex = 3;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            // 
            // optDate
            // 
            this.optDate.AutoSize = true;
            this.optDate.Location = new System.Drawing.Point(286, 82);
            this.optDate.Name = "optDate";
            this.optDate.Size = new System.Drawing.Size(48, 17);
            this.optDate.TabIndex = 11;
            this.optDate.Text = "Date";
            this.optDate.UseVisualStyleBackColor = true;
            this.optDate.CheckedChanged += new System.EventHandler(this.optDate_CheckedChanged);
            // 
            // optAll
            // 
            this.optAll.AutoSize = true;
            this.optAll.Checked = true;
            this.optAll.Location = new System.Drawing.Point(244, 83);
            this.optAll.Name = "optAll";
            this.optAll.Size = new System.Drawing.Size(36, 17);
            this.optAll.TabIndex = 10;
            this.optAll.TabStop = true;
            this.optAll.Text = "All";
            this.optAll.UseVisualStyleBackColor = true;
            this.optAll.CheckedChanged += new System.EventHandler(this.optAll_CheckedChanged);
            // 
            // lnkExport
            // 
            this.lnkExport.AutoSize = true;
            this.lnkExport.LinkColor = System.Drawing.Color.White;
            this.lnkExport.Location = new System.Drawing.Point(426, 112);
            this.lnkExport.Name = "lnkExport";
            this.lnkExport.Size = new System.Drawing.Size(37, 13);
            this.lnkExport.TabIndex = 9;
            this.lnkExport.TabStop = true;
            this.lnkExport.Text = "Export";
            this.lnkExport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExport_LinkClicked);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.White;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(244, 102);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(166, 26);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(62, 109);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(163, 21);
            this.cmbCategory.TabIndex = 7;
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(62, 82);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(163, 21);
            this.cmbBrand.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Brand";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stocks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // picClose
            // 
            this.picClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Image = global::frmChallan.Properties.Resources.Close;
            this.picClose.Location = new System.Drawing.Point(732, 19);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(43, 30);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(134, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(510, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Product Summery";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProductBlance);
            this.panel1.Controls.Add(this.pnlBotom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 427);
            this.panel1.TabIndex = 4;
            // 
            // pnlBotom
            // 
            this.pnlBotom.BackColor = System.Drawing.Color.Maroon;
            this.pnlBotom.Controls.Add(this.tblpnlBotom);
            this.pnlBotom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotom.ForeColor = System.Drawing.Color.White;
            this.pnlBotom.Location = new System.Drawing.Point(0, 395);
            this.pnlBotom.Name = "pnlBotom";
            this.pnlBotom.Size = new System.Drawing.Size(784, 32);
            this.pnlBotom.TabIndex = 1;
            // 
            // tblpnlBotom
            // 
            this.tblpnlBotom.BackColor = System.Drawing.Color.Green;
            this.tblpnlBotom.ColumnCount = 8;
            this.tblpnlBotom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tblpnlBotom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tblpnlBotom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tblpnlBotom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tblpnlBotom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tblpnlBotom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tblpnlBotom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblpnlBotom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpnlBotom.Controls.Add(this.label7, 6, 0);
            this.tblpnlBotom.Controls.Add(this.label2, 0, 0);
            this.tblpnlBotom.Controls.Add(this.lblStockInhand, 5, 0);
            this.tblpnlBotom.Controls.Add(this.label6, 4, 0);
            this.tblpnlBotom.Controls.Add(this.label4, 2, 0);
            this.tblpnlBotom.Controls.Add(this.lblTotalReceive, 1, 0);
            this.tblpnlBotom.Controls.Add(this.lblTotalDelivery, 3, 0);
            this.tblpnlBotom.Controls.Add(this.lblBalanceTotal, 7, 0);
            this.tblpnlBotom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlBotom.Location = new System.Drawing.Point(0, 0);
            this.tblpnlBotom.Name = "tblpnlBotom";
            this.tblpnlBotom.RowCount = 1;
            this.tblpnlBotom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlBotom.Size = new System.Drawing.Size(784, 32);
            this.tblpnlBotom.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(570, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Balance";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Receive:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStockInhand
            // 
            this.lblStockInhand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStockInhand.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockInhand.ForeColor = System.Drawing.Color.Lime;
            this.lblStockInhand.Location = new System.Drawing.Point(494, 0);
            this.lblStockInhand.Name = "lblStockInhand";
            this.lblStockInhand.Size = new System.Drawing.Size(70, 32);
            this.lblStockInhand.TabIndex = 9;
            this.lblStockInhand.Text = "label7";
            this.lblStockInhand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStockInhand.Click += new System.EventHandler(this.lblStockInhand_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(375, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Stock In Hand:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Delivery:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalReceive
            // 
            this.lblTotalReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalReceive.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReceive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotalReceive.Location = new System.Drawing.Point(113, 0);
            this.lblTotalReceive.Name = "lblTotalReceive";
            this.lblTotalReceive.Size = new System.Drawing.Size(70, 32);
            this.lblTotalReceive.TabIndex = 5;
            this.lblTotalReceive.Text = "label3";
            this.lblTotalReceive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalReceive.Click += new System.EventHandler(this.lblTotalReceive_Click);
            // 
            // lblTotalDelivery
            // 
            this.lblTotalDelivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalDelivery.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDelivery.ForeColor = System.Drawing.Color.Red;
            this.lblTotalDelivery.Location = new System.Drawing.Point(299, 0);
            this.lblTotalDelivery.Name = "lblTotalDelivery";
            this.lblTotalDelivery.Size = new System.Drawing.Size(70, 32);
            this.lblTotalDelivery.TabIndex = 7;
            this.lblTotalDelivery.Text = "label5";
            this.lblTotalDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalDelivery.Click += new System.EventHandler(this.lblTotalDelivery_Click);
            // 
            // lblBalanceTotal
            // 
            this.lblBalanceTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalanceTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceTotal.Location = new System.Drawing.Point(670, 4);
            this.lblBalanceTotal.Name = "lblBalanceTotal";
            this.lblBalanceTotal.Size = new System.Drawing.Size(111, 23);
            this.lblBalanceTotal.TabIndex = 13;
            // 
            // frmBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Balance";
            this.Load += new System.EventHandler(this.frmBalance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductBlance)).EndInit();
            this.cntxProductMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBalanceBindingSource)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlBotom.ResumeLayout(false);
            this.tblpnlBotom.ResumeLayout(false);
            this.tblpnlBotom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductBlance;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBalanceBindingSource;
        private System.Windows.Forms.ContextMenuStrip cntxProductMenu;
        private System.Windows.Forms.ToolStripMenuItem cntxReceiveDetails;
        private System.Windows.Forms.ToolStripMenuItem cntxDeliveryDetails;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStockInhand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalDelivery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalReceive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlBotom;
        private System.Windows.Forms.TableLayoutPanel tblpnlBotom;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton optDate;
        private System.Windows.Forms.RadioButton optAll;
        private System.Windows.Forms.LinkLabel lnkExport;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBalanceTotal;
    }
}