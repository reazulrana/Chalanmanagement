namespace frmChallan
{
    partial class frmReceiveDetails
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
            this.dgvReceiveDetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryChallan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCannibalized = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntxAddCannibalized = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxCannibalizedInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxNotReturnable = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxCancelNotReturnable = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.productDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.optJobCode = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.optCannibalized = new System.Windows.Forms.RadioButton();
            this.optNonCannibalized = new System.Windows.Forms.RadioButton();
            this.optAll = new System.Windows.Forms.RadioButton();
            this.optReturnableProduct = new System.Windows.Forms.RadioButton();
            this.optNotReturnableProduct = new System.Windows.Forms.RadioButton();
            this.optReceiveChallan = new System.Windows.Forms.RadioButton();
            this.optSerial = new System.Windows.Forms.RadioButton();
            this.optDescription = new System.Windows.Forms.RadioButton();
            this.optModel = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblIndividualModel = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlGroupList = new System.Windows.Forms.Panel();
            this.grpList = new System.Windows.Forms.CheckedListBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.pnlBodyBottom = new System.Windows.Forms.Panel();
            this.lblGridList = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.optBranch = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiveDetails)).BeginInit();
            this.cntxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.pnlBody.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlGroupList.SuspendLayout();
            this.pnlBodyBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReceiveDetails
            // 
            this.dgvReceiveDetails.AllowUserToAddRows = false;
            this.dgvReceiveDetails.AllowUserToDeleteRows = false;
            this.dgvReceiveDetails.AutoGenerateColumns = false;
            this.dgvReceiveDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceiveDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceiveDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReceiveDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiveDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Brand,
            this.Category,
            this.ProductName,
            this.Code,
            this.modelDataGridViewTextBoxColumn,
            this.serialDataGridViewTextBoxColumn,
            this.receiveDateDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.DeliveryChallan,
            this.sourceDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.NRReason,
            this.ProductReturn,
            this.TotalCannibalized,
            this.JobCode,
            this.Branch});
            this.dgvReceiveDetails.ContextMenuStrip = this.cntxMenu;
            this.dgvReceiveDetails.DataSource = this.productDetailsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceiveDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReceiveDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReceiveDetails.EnableHeadersVisualStyles = false;
            this.dgvReceiveDetails.GridColor = System.Drawing.Color.White;
            this.dgvReceiveDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvReceiveDetails.Name = "dgvReceiveDetails";
            this.dgvReceiveDetails.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceiveDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReceiveDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceiveDetails.Size = new System.Drawing.Size(597, 352);
            this.dgvReceiveDetails.TabIndex = 1;
            this.dgvReceiveDetails.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvReceiveDetails_DataBindingComplete);
            this.dgvReceiveDetails.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvReceiveDetails_MouseDoubleClick);
            this.dgvReceiveDetails.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvReceiveDetails_MouseUp);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ReceiveChallan";
            this.Column1.HeaderText = "R. Challan";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Visible = false;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Description";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Location";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Visible = false;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serialDataGridViewTextBoxColumn
            // 
            this.serialDataGridViewTextBoxColumn.DataPropertyName = "Serial";
            this.serialDataGridViewTextBoxColumn.HeaderText = "Serial";
            this.serialDataGridViewTextBoxColumn.Name = "serialDataGridViewTextBoxColumn";
            this.serialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiveDateDataGridViewTextBoxColumn
            // 
            this.receiveDateDataGridViewTextBoxColumn.DataPropertyName = "ReceiveDate";
            this.receiveDateDataGridViewTextBoxColumn.HeaderText = "Rcvd Date";
            this.receiveDateDataGridViewTextBoxColumn.Name = "receiveDateDataGridViewTextBoxColumn";
            this.receiveDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "Del. Date";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DeliveryChallan
            // 
            this.DeliveryChallan.DataPropertyName = "DeliveryChallan";
            this.DeliveryChallan.HeaderText = "D.Challan";
            this.DeliveryChallan.Name = "DeliveryChallan";
            this.DeliveryChallan.ReadOnly = true;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            this.sourceDataGridViewTextBoxColumn.ReadOnly = true;
            this.sourceDataGridViewTextBoxColumn.Visible = false;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            this.conditionDataGridViewTextBoxColumn.Visible = false;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NRReason
            // 
            this.NRReason.DataPropertyName = "NRReason";
            this.NRReason.HeaderText = "N.R Reason";
            this.NRReason.Name = "NRReason";
            this.NRReason.ReadOnly = true;
            this.NRReason.Visible = false;
            // 
            // ProductReturn
            // 
            this.ProductReturn.DataPropertyName = "ProductReturn";
            this.ProductReturn.HeaderText = "Return Product";
            this.ProductReturn.Name = "ProductReturn";
            this.ProductReturn.ReadOnly = true;
            // 
            // TotalCannibalized
            // 
            this.TotalCannibalized.DataPropertyName = "TotalCannibalized";
            this.TotalCannibalized.HeaderText = "Cannibalized";
            this.TotalCannibalized.Name = "TotalCannibalized";
            this.TotalCannibalized.ReadOnly = true;
            // 
            // JobCode
            // 
            this.JobCode.DataPropertyName = "JobCode";
            this.JobCode.HeaderText = "JobCode";
            this.JobCode.Name = "JobCode";
            this.JobCode.ReadOnly = true;
            // 
            // Branch
            // 
            this.Branch.DataPropertyName = "Branch";
            this.Branch.HeaderText = "Branch";
            this.Branch.Name = "Branch";
            this.Branch.ReadOnly = true;
            // 
            // cntxMenu
            // 
            this.cntxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxAddCannibalized,
            this.cntxCannibalizedInfo,
            this.cntxNotReturnable,
            this.cntxCancelNotReturnable,
            this.cntxEdit});
            this.cntxMenu.Name = "con";
            this.cntxMenu.Size = new System.Drawing.Size(194, 114);
            // 
            // cntxAddCannibalized
            // 
            this.cntxAddCannibalized.Image = global::frmChallan.Properties.Resources.Plus_sign;
            this.cntxAddCannibalized.Name = "cntxAddCannibalized";
            this.cntxAddCannibalized.Size = new System.Drawing.Size(193, 22);
            this.cntxAddCannibalized.Text = "&New Canibalized";
            this.cntxAddCannibalized.Click += new System.EventHandler(this.cntxAddCannibalized_Click);
            // 
            // cntxCannibalizedInfo
            // 
            this.cntxCannibalizedInfo.Image = global::frmChallan.Properties.Resources.status;
            this.cntxCannibalizedInfo.Name = "cntxCannibalizedInfo";
            this.cntxCannibalizedInfo.Size = new System.Drawing.Size(193, 22);
            this.cntxCannibalizedInfo.Text = "&Cannibalized Info";
            this.cntxCannibalizedInfo.Click += new System.EventHandler(this.cntxCannibalizedInfo_Click);
            // 
            // cntxNotReturnable
            // 
            this.cntxNotReturnable.Image = global::frmChallan.Properties.Resources.can;
            this.cntxNotReturnable.Name = "cntxNotReturnable";
            this.cntxNotReturnable.Size = new System.Drawing.Size(193, 22);
            this.cntxNotReturnable.Text = "Not &Returnable";
            this.cntxNotReturnable.Click += new System.EventHandler(this.cntxNotReturnable_Click);
            // 
            // cntxCancelNotReturnable
            // 
            this.cntxCancelNotReturnable.Image = global::frmChallan.Properties.Resources.Close_Window_32px;
            this.cntxCancelNotReturnable.Name = "cntxCancelNotReturnable";
            this.cntxCancelNotReturnable.Size = new System.Drawing.Size(193, 22);
            this.cntxCancelNotReturnable.Text = "Ca&ncel Not Returnable";
            this.cntxCancelNotReturnable.Click += new System.EventHandler(this.cntxCancelNotReturnable_Click);
            // 
            // cntxEdit
            // 
            this.cntxEdit.Image = global::frmChallan.Properties.Resources.Pencil_32px;
            this.cntxEdit.Name = "cntxEdit";
            this.cntxEdit.Size = new System.Drawing.Size(193, 22);
            this.cntxEdit.Text = "&Edit";
            this.cntxEdit.Click += new System.EventHandler(this.cntxEdit_Click);
            // 
            // productDetailsBindingSource
            // 
            this.productDetailsBindingSource.DataSource = typeof(BussinessLibrary.SupportLibrary.ProductDetails);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Maroon;
            this.pnlTitle.Controls.Add(this.optBranch);
            this.pnlTitle.Controls.Add(this.optJobCode);
            this.pnlTitle.Controls.Add(this.panel2);
            this.pnlTitle.Controls.Add(this.optReceiveChallan);
            this.pnlTitle.Controls.Add(this.optSerial);
            this.pnlTitle.Controls.Add(this.optDescription);
            this.pnlTitle.Controls.Add(this.optModel);
            this.pnlTitle.Controls.Add(this.label2);
            this.pnlTitle.Controls.Add(this.txtFilter);
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Controls.Add(this.picClose);
            this.pnlTitle.Controls.Add(this.lblIndividualModel);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.ForeColor = System.Drawing.Color.White;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(599, 172);
            this.pnlTitle.TabIndex = 2;
            this.pnlTitle.Click += new System.EventHandler(this.pnlTitle_Click);
            this.pnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitle_Paint_1);
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            // 
            // optJobCode
            // 
            this.optJobCode.AutoSize = true;
            this.optJobCode.Location = new System.Drawing.Point(417, 89);
            this.optJobCode.Name = "optJobCode";
            this.optJobCode.Size = new System.Drawing.Size(70, 17);
            this.optJobCode.TabIndex = 12;
            this.optJobCode.TabStop = true;
            this.optJobCode.Text = "Job Code";
            this.optJobCode.UseVisualStyleBackColor = true;
            this.optJobCode.CheckedChanged += new System.EventHandler(this.optJobCode_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.optCannibalized);
            this.panel2.Controls.Add(this.optNonCannibalized);
            this.panel2.Controls.Add(this.optAll);
            this.panel2.Controls.Add(this.optReturnableProduct);
            this.panel2.Controls.Add(this.optNotReturnableProduct);
            this.panel2.Location = new System.Drawing.Point(18, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 29);
            this.panel2.TabIndex = 11;
            // 
            // optCannibalized
            // 
            this.optCannibalized.AutoSize = true;
            this.optCannibalized.Location = new System.Drawing.Point(427, 6);
            this.optCannibalized.Name = "optCannibalized";
            this.optCannibalized.Size = new System.Drawing.Size(85, 17);
            this.optCannibalized.TabIndex = 12;
            this.optCannibalized.TabStop = true;
            this.optCannibalized.Text = "&Cannibalized";
            this.optCannibalized.UseVisualStyleBackColor = true;
            this.optCannibalized.CheckedChanged += new System.EventHandler(this.optCannibalized_CheckedChanged);
            // 
            // optNonCannibalized
            // 
            this.optNonCannibalized.AutoSize = true;
            this.optNonCannibalized.Location = new System.Drawing.Point(313, 6);
            this.optNonCannibalized.Name = "optNonCannibalized";
            this.optNonCannibalized.Size = new System.Drawing.Size(108, 17);
            this.optNonCannibalized.TabIndex = 11;
            this.optNonCannibalized.TabStop = true;
            this.optNonCannibalized.Text = "&Non Cannibalized";
            this.optNonCannibalized.UseVisualStyleBackColor = true;
            this.optNonCannibalized.CheckedChanged += new System.EventHandler(this.optNonCannibalized_CheckedChanged);
            // 
            // optAll
            // 
            this.optAll.AutoSize = true;
            this.optAll.Location = new System.Drawing.Point(9, 6);
            this.optAll.Name = "optAll";
            this.optAll.Size = new System.Drawing.Size(36, 17);
            this.optAll.TabIndex = 10;
            this.optAll.TabStop = true;
            this.optAll.Text = "All";
            this.optAll.UseVisualStyleBackColor = true;
            this.optAll.CheckedChanged += new System.EventHandler(this.optAll_CheckedChanged);
            // 
            // optReturnableProduct
            // 
            this.optReturnableProduct.AutoSize = true;
            this.optReturnableProduct.Location = new System.Drawing.Point(51, 6);
            this.optReturnableProduct.Name = "optReturnableProduct";
            this.optReturnableProduct.Size = new System.Drawing.Size(117, 17);
            this.optReturnableProduct.TabIndex = 8;
            this.optReturnableProduct.TabStop = true;
            this.optReturnableProduct.Text = "Returnable Product";
            this.optReturnableProduct.UseVisualStyleBackColor = true;
            this.optReturnableProduct.CheckedChanged += new System.EventHandler(this.optReturnableProduct_CheckedChanged);
            // 
            // optNotReturnableProduct
            // 
            this.optNotReturnableProduct.AutoSize = true;
            this.optNotReturnableProduct.Location = new System.Drawing.Point(174, 6);
            this.optNotReturnableProduct.Name = "optNotReturnableProduct";
            this.optNotReturnableProduct.Size = new System.Drawing.Size(137, 17);
            this.optNotReturnableProduct.TabIndex = 9;
            this.optNotReturnableProduct.TabStop = true;
            this.optNotReturnableProduct.Text = "&Not Returnable Product";
            this.optNotReturnableProduct.UseVisualStyleBackColor = true;
            this.optNotReturnableProduct.CheckedChanged += new System.EventHandler(this.optNotReturnableProduct_CheckedChanged);
            // 
            // optReceiveChallan
            // 
            this.optReceiveChallan.AutoSize = true;
            this.optReceiveChallan.Location = new System.Drawing.Point(109, 90);
            this.optReceiveChallan.Name = "optReceiveChallan";
            this.optReceiveChallan.Size = new System.Drawing.Size(103, 17);
            this.optReceiveChallan.TabIndex = 7;
            this.optReceiveChallan.TabStop = true;
            this.optReceiveChallan.Text = "Receive Challan";
            this.optReceiveChallan.UseVisualStyleBackColor = true;
            // 
            // optSerial
            // 
            this.optSerial.AutoSize = true;
            this.optSerial.Location = new System.Drawing.Point(362, 90);
            this.optSerial.Name = "optSerial";
            this.optSerial.Size = new System.Drawing.Size(51, 17);
            this.optSerial.TabIndex = 6;
            this.optSerial.TabStop = true;
            this.optSerial.Text = "Serial";
            this.optSerial.UseVisualStyleBackColor = true;
            this.optSerial.CheckedChanged += new System.EventHandler(this.optSerial_CheckedChanged);
            // 
            // optDescription
            // 
            this.optDescription.AutoSize = true;
            this.optDescription.Location = new System.Drawing.Point(278, 90);
            this.optDescription.Name = "optDescription";
            this.optDescription.Size = new System.Drawing.Size(78, 17);
            this.optDescription.TabIndex = 5;
            this.optDescription.TabStop = true;
            this.optDescription.Text = "Description";
            this.optDescription.UseVisualStyleBackColor = true;
            this.optDescription.CheckedChanged += new System.EventHandler(this.optDescription_CheckedChanged);
            // 
            // optModel
            // 
            this.optModel.AutoSize = true;
            this.optModel.Location = new System.Drawing.Point(218, 90);
            this.optModel.Name = "optModel";
            this.optModel.Size = new System.Drawing.Size(54, 17);
            this.optModel.TabIndex = 4;
            this.optModel.TabStop = true;
            this.optModel.Text = "Model";
            this.optModel.UseVisualStyleBackColor = true;
            this.optModel.CheckedChanged += new System.EventHandler(this.optModel_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter Record";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(109, 114);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(478, 20);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter Record";
            // 
            // picClose
            // 
            this.picClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Image = global::frmChallan.Properties.Resources.Close;
            this.picClose.Location = new System.Drawing.Point(557, 22);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(30, 24);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.toolTip1.SetToolTip(this.picClose, "Close");
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // lblIndividualModel
            // 
            this.lblIndividualModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIndividualModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIndividualModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndividualModel.Location = new System.Drawing.Point(205, 52);
            this.lblIndividualModel.Name = "lblIndividualModel";
            this.lblIndividualModel.Size = new System.Drawing.Size(234, 25);
            this.lblIndividualModel.TabIndex = 1;
            this.lblIndividualModel.Text = "By Individual Model";
            this.lblIndividualModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIndividualModel.Click += new System.EventHandler(this.lblIndividualModel_Click);
            this.lblIndividualModel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblIndividualModel_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(180, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(288, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Receive Information";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseMove);
            // 
            // pnlBody
            // 
            this.pnlBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBody.Controls.Add(this.panel1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 172);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(599, 354);
            this.pnlBody.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlGroupList);
            this.panel1.Controls.Add(this.dgvReceiveDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 352);
            this.panel1.TabIndex = 3;
            // 
            // pnlGroupList
            // 
            this.pnlGroupList.BackColor = System.Drawing.Color.Teal;
            this.pnlGroupList.Controls.Add(this.grpList);
            this.pnlGroupList.Controls.Add(this.btnHide);
            this.pnlGroupList.Location = new System.Drawing.Point(207, 27);
            this.pnlGroupList.Name = "pnlGroupList";
            this.pnlGroupList.Size = new System.Drawing.Size(297, 294);
            this.pnlGroupList.TabIndex = 5;
            // 
            // grpList
            // 
            this.grpList.BackColor = System.Drawing.Color.Teal;
            this.grpList.ForeColor = System.Drawing.Color.White;
            this.grpList.FormattingEnabled = true;
            this.grpList.Items.AddRange(new object[] {
            "Receive Challan",
            "Brand",
            "Category",
            "Product Name",
            "Location",
            "Model",
            "Serial",
            "Receive Date",
            "Delivery Date",
            "Delivery Challan",
            "Source",
            "Destination",
            "Condition",
            "Remarks",
            "Job Code",
            "Branch",
            "N.R Reason",
            "Return Product",
            "Cannibalized"});
            this.grpList.Location = new System.Drawing.Point(3, 6);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(291, 259);
            this.grpList.TabIndex = 1;
            this.grpList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.grpList_ItemCheck);
            this.grpList.SelectedIndexChanged += new System.EventHandler(this.grpList_SelectedIndexChanged);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHide.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.Location = new System.Drawing.Point(4, 266);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(289, 23);
            this.btnHide.TabIndex = 0;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click_1);
            // 
            // pnlBodyBottom
            // 
            this.pnlBodyBottom.BackColor = System.Drawing.Color.Teal;
            this.pnlBodyBottom.Controls.Add(this.lblGridList);
            this.pnlBodyBottom.Controls.Add(this.btnExport);
            this.pnlBodyBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBodyBottom.Location = new System.Drawing.Point(0, 526);
            this.pnlBodyBottom.Name = "pnlBodyBottom";
            this.pnlBodyBottom.Size = new System.Drawing.Size(599, 36);
            this.pnlBodyBottom.TabIndex = 2;
            // 
            // lblGridList
            // 
            this.lblGridList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGridList.AutoSize = true;
            this.lblGridList.ForeColor = System.Drawing.Color.White;
            this.lblGridList.Location = new System.Drawing.Point(513, 15);
            this.lblGridList.Name = "lblGridList";
            this.lblGridList.Size = new System.Drawing.Size(75, 13);
            this.lblGridList.TabIndex = 1;
            this.lblGridList.Text = "Show Grid List";
            this.lblGridList.Click += new System.EventHandler(this.lblGridList_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Teal;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(3, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(71, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // optBranch
            // 
            this.optBranch.AutoSize = true;
            this.optBranch.Location = new System.Drawing.Point(493, 90);
            this.optBranch.Name = "optBranch";
            this.optBranch.Size = new System.Drawing.Size(59, 17);
            this.optBranch.TabIndex = 13;
            this.optBranch.TabStop = true;
            this.optBranch.Text = "Branch";
            this.optBranch.UseVisualStyleBackColor = true;
            this.optBranch.CheckedChanged += new System.EventHandler(this.optBranch_CheckedChanged);
            // 
            // frmReceiveDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 562);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlBodyBottom);
            this.Name = "frmReceiveDetails";
            this.Text = "All Receive Information";
            this.Load += new System.EventHandler(this.frmReceiveDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiveDetails)).EndInit();
            this.cntxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDetailsBindingSource)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.pnlBody.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlGroupList.ResumeLayout(false);
            this.pnlBodyBottom.ResumeLayout(false);
            this.pnlBodyBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReceiveDetails;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblIndividualModel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBodyBottom;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ContextMenuStrip cntxMenu;
        private System.Windows.Forms.Panel pnlGroupList;
        private System.Windows.Forms.CheckedListBox grpList;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.BindingSource productDetailsBindingSource;
        private System.Windows.Forms.Label lblGridList;
        private System.Windows.Forms.ToolStripMenuItem cntxAddCannibalized;
        private System.Windows.Forms.ToolStripMenuItem cntxCannibalizedInfo;
        private System.Windows.Forms.RadioButton optReceiveChallan;
        private System.Windows.Forms.RadioButton optSerial;
        private System.Windows.Forms.RadioButton optDescription;
        private System.Windows.Forms.RadioButton optModel;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem cntxNotReturnable;
        private System.Windows.Forms.ToolStripMenuItem cntxCancelNotReturnable;
        private System.Windows.Forms.RadioButton optNotReturnableProduct;
        private System.Windows.Forms.RadioButton optReturnableProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton optAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem cntxEdit;
        private System.Windows.Forms.RadioButton optCannibalized;
        private System.Windows.Forms.RadioButton optNonCannibalized;
        private System.Windows.Forms.RadioButton optJobCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryChallan;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCannibalized;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch;
        private System.Windows.Forms.RadioButton optBranch;
    }
}