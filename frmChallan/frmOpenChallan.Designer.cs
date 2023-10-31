namespace frmChallan
{
    partial class frmOpenChallan
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.optReceive = new System.Windows.Forms.RadioButton();
            this.optDelivery = new System.Windows.Forms.RadioButton();
            this.dgvChallanDetails = new System.Windows.Forms.DataGridView();
            this.mIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.challanNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiveConditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChallanDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(57, 46);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(306, 46);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(135, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "&Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(447, 46);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // optReceive
            // 
            this.optReceive.AutoSize = true;
            this.optReceive.Location = new System.Drawing.Point(87, 23);
            this.optReceive.Name = "optReceive";
            this.optReceive.Size = new System.Drawing.Size(65, 17);
            this.optReceive.TabIndex = 4;
            this.optReceive.TabStop = true;
            this.optReceive.Text = "Receive";
            this.optReceive.UseVisualStyleBackColor = true;
            // 
            // optDelivery
            // 
            this.optDelivery.AutoSize = true;
            this.optDelivery.Location = new System.Drawing.Point(158, 23);
            this.optDelivery.Name = "optDelivery";
            this.optDelivery.Size = new System.Drawing.Size(63, 17);
            this.optDelivery.TabIndex = 5;
            this.optDelivery.TabStop = true;
            this.optDelivery.Text = "Delivery";
            this.optDelivery.UseVisualStyleBackColor = true;
            // 
            // dgvChallanDetails
            // 
            this.dgvChallanDetails.AllowUserToAddRows = false;
            this.dgvChallanDetails.AllowUserToDeleteRows = false;
            this.dgvChallanDetails.AllowUserToResizeRows = false;
            this.dgvChallanDetails.AutoGenerateColumns = false;
            this.dgvChallanDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChallanDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChallanDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChallanDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChallanDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mIDDataGridViewTextBoxColumn,
            this.challanNoDataGridViewTextBoxColumn,
            this.trDateDataGridViewTextBoxColumn,
            this.trTypeDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.receiveConditionDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dgvChallanDetails.DataSource = this.tblMasterBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChallanDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChallanDetails.EnableHeadersVisualStyles = false;
            this.dgvChallanDetails.Location = new System.Drawing.Point(57, 72);
            this.dgvChallanDetails.Name = "dgvChallanDetails";
            this.dgvChallanDetails.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChallanDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChallanDetails.RowHeadersVisible = false;
            this.dgvChallanDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChallanDetails.Size = new System.Drawing.Size(573, 224);
            this.dgvChallanDetails.TabIndex = 6;
            this.dgvChallanDetails.Visible = false;
            this.dgvChallanDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvChallanDetails_KeyDown);
            this.dgvChallanDetails.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvChallanDetails_MouseDoubleClick);
            // 
            // mIDDataGridViewTextBoxColumn
            // 
            this.mIDDataGridViewTextBoxColumn.DataPropertyName = "MID";
            this.mIDDataGridViewTextBoxColumn.HeaderText = "MID";
            this.mIDDataGridViewTextBoxColumn.Name = "mIDDataGridViewTextBoxColumn";
            this.mIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // challanNoDataGridViewTextBoxColumn
            // 
            this.challanNoDataGridViewTextBoxColumn.DataPropertyName = "ChallanNo";
            this.challanNoDataGridViewTextBoxColumn.HeaderText = "Challan";
            this.challanNoDataGridViewTextBoxColumn.Name = "challanNoDataGridViewTextBoxColumn";
            this.challanNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trDateDataGridViewTextBoxColumn
            // 
            this.trDateDataGridViewTextBoxColumn.DataPropertyName = "TrDate";
            this.trDateDataGridViewTextBoxColumn.HeaderText = "Tr. Date";
            this.trDateDataGridViewTextBoxColumn.Name = "trDateDataGridViewTextBoxColumn";
            this.trDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trTypeDataGridViewTextBoxColumn
            // 
            this.trTypeDataGridViewTextBoxColumn.DataPropertyName = "TrType";
            this.trTypeDataGridViewTextBoxColumn.HeaderText = "Tr. Type";
            this.trTypeDataGridViewTextBoxColumn.Name = "trTypeDataGridViewTextBoxColumn";
            this.trTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.trTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            this.sourceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiveConditionDataGridViewTextBoxColumn
            // 
            this.receiveConditionDataGridViewTextBoxColumn.DataPropertyName = "ReceiveCondition";
            this.receiveConditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            this.receiveConditionDataGridViewTextBoxColumn.Name = "receiveConditionDataGridViewTextBoxColumn";
            this.receiveConditionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblMasterBindingSource
            // 
            this.tblMasterBindingSource.DataSource = typeof(BussinessLibrary.tblMaster);
            // 
            // frmOpenChallan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(642, 308);
            this.Controls.Add(this.dgvChallanDetails);
            this.Controls.Add(this.optDelivery);
            this.Controls.Add(this.optReceive);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmOpenChallan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Challan";
            this.Load += new System.EventHandler(this.frmOpenChallan_Load);
            this.Resize += new System.EventHandler(this.frmOpenChallan_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChallanDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton optReceive;
        private System.Windows.Forms.RadioButton optDelivery;
        private System.Windows.Forms.DataGridView dgvChallanDetails;
        private System.Windows.Forms.BindingSource tblMasterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn challanNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiveConditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
    }
}