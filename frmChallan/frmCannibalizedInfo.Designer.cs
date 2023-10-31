namespace frmChallan
{
    partial class frmCannibalizedInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCannibalizedProductList = new System.Windows.Forms.DataGridView();
            this.canIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.challanNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCannibalizedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCannibalizedProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCannibalizedBindingSource)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // dgvCannibalizedProductList
            // 
            this.dgvCannibalizedProductList.AllowUserToAddRows = false;
            this.dgvCannibalizedProductList.AllowUserToDeleteRows = false;
            this.dgvCannibalizedProductList.AutoGenerateColumns = false;
            this.dgvCannibalizedProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCannibalizedProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.canIDDataGridViewTextBoxColumn,
            this.challanNoDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.serialDataGridViewTextBoxColumn,
            this.receivedDateDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.partNoDataGridViewTextBoxColumn,
            this.branchDataGridViewTextBoxColumn,
            this.jobCodeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.orderQtyDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.accessoriesDataGridViewTextBoxColumn});
            this.dgvCannibalizedProductList.DataSource = this.tblCannibalizedBindingSource;
            this.dgvCannibalizedProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCannibalizedProductList.Location = new System.Drawing.Point(0, 0);
            this.dgvCannibalizedProductList.Name = "dgvCannibalizedProductList";
            this.dgvCannibalizedProductList.ReadOnly = true;
            this.dgvCannibalizedProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCannibalizedProductList.Size = new System.Drawing.Size(684, 265);
            this.dgvCannibalizedProductList.TabIndex = 12;
            // 
            // canIDDataGridViewTextBoxColumn
            // 
            this.canIDDataGridViewTextBoxColumn.DataPropertyName = "CanID";
            this.canIDDataGridViewTextBoxColumn.HeaderText = "CanID";
            this.canIDDataGridViewTextBoxColumn.Name = "canIDDataGridViewTextBoxColumn";
            this.canIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.canIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // challanNoDataGridViewTextBoxColumn
            // 
            this.challanNoDataGridViewTextBoxColumn.DataPropertyName = "ChallanNo";
            this.challanNoDataGridViewTextBoxColumn.HeaderText = "ChallanNo";
            this.challanNoDataGridViewTextBoxColumn.Name = "challanNoDataGridViewTextBoxColumn";
            this.challanNoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // receivedDateDataGridViewTextBoxColumn
            // 
            this.receivedDateDataGridViewTextBoxColumn.DataPropertyName = "ReceivedDate";
            this.receivedDateDataGridViewTextBoxColumn.HeaderText = "ReceivedDate";
            this.receivedDateDataGridViewTextBoxColumn.Name = "receivedDateDataGridViewTextBoxColumn";
            this.receivedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partNoDataGridViewTextBoxColumn
            // 
            this.partNoDataGridViewTextBoxColumn.DataPropertyName = "PartNo";
            this.partNoDataGridViewTextBoxColumn.HeaderText = "PartNo";
            this.partNoDataGridViewTextBoxColumn.Name = "partNoDataGridViewTextBoxColumn";
            this.partNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // branchDataGridViewTextBoxColumn
            // 
            this.branchDataGridViewTextBoxColumn.DataPropertyName = "Branch";
            this.branchDataGridViewTextBoxColumn.HeaderText = "Branch";
            this.branchDataGridViewTextBoxColumn.Name = "branchDataGridViewTextBoxColumn";
            this.branchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobCodeDataGridViewTextBoxColumn
            // 
            this.jobCodeDataGridViewTextBoxColumn.DataPropertyName = "JobCode";
            this.jobCodeDataGridViewTextBoxColumn.HeaderText = "JobCode";
            this.jobCodeDataGridViewTextBoxColumn.Name = "jobCodeDataGridViewTextBoxColumn";
            this.jobCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderQtyDataGridViewTextBoxColumn
            // 
            this.orderQtyDataGridViewTextBoxColumn.DataPropertyName = "OrderQty";
            this.orderQtyDataGridViewTextBoxColumn.HeaderText = "OrderQty";
            this.orderQtyDataGridViewTextBoxColumn.Name = "orderQtyDataGridViewTextBoxColumn";
            this.orderQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accessoriesDataGridViewTextBoxColumn
            // 
            this.accessoriesDataGridViewTextBoxColumn.DataPropertyName = "Accessories";
            this.accessoriesDataGridViewTextBoxColumn.HeaderText = "Accessories";
            this.accessoriesDataGridViewTextBoxColumn.Name = "accessoriesDataGridViewTextBoxColumn";
            this.accessoriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblCannibalizedBindingSource
            // 
            this.tblCannibalizedBindingSource.DataSource = typeof(BussinessLibrary.tblCannibalized);
            // 
            // txtModel
            // 
            this.txtModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtModel.Location = new System.Drawing.Point(64, 35);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(190, 20);
            this.txtModel.TabIndex = 14;
            // 
            // txtSerial
            // 
            this.txtSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSerial.Location = new System.Drawing.Point(64, 61);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(190, 20);
            this.txtSerial.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.Gray;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(2, 6);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label13.Size = new System.Drawing.Size(691, 21);
            this.label13.TabIndex = 25;
            this.label13.Text = "Product Information";
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.label13);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.txtModel);
            this.pnlTop.Controls.Add(this.txtSerial);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(684, 92);
            this.pnlTop.TabIndex = 27;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.dgvCannibalizedProductList);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 92);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(684, 265);
            this.pnlBottom.TabIndex = 28;
            // 
            // frmCannibalizedInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 357);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCannibalizedInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cannibalized Information";
            this.Load += new System.EventHandler(this.frmCannibalizedInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCannibalizedProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCannibalizedBindingSource)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCannibalizedProductList;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource tblCannibalizedBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn canIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn challanNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessoriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
    }
}