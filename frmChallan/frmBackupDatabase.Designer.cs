namespace frmChallan
{
    partial class frmBackupDatabase
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
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.lblRestore = new System.Windows.Forms.Label();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDot = new System.Windows.Forms.LinkLabel();
            this.btnRestoreDot = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(90, 94);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(273, 20);
            this.txtDestination.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Destination";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.White;
            this.btnBackup.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(90, 117);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(125, 26);
            this.btnBackup.TabIndex = 5;
            this.btnBackup.Text = "Back Up";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.White;
            this.btnRestore.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(90, 48);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(125, 26);
            this.btnRestore.TabIndex = 9;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblRestore
            // 
            this.lblRestore.AutoSize = true;
            this.lblRestore.Location = new System.Drawing.Point(24, 30);
            this.lblRestore.Name = "lblRestore";
            this.lblRestore.Size = new System.Drawing.Size(44, 13);
            this.lblRestore.TabIndex = 8;
            this.lblRestore.Text = "Restore";
            // 
            // txtRestore
            // 
            this.txtRestore.Location = new System.Drawing.Point(90, 26);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(273, 20);
            this.txtRestore.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDot
            // 
            this.btnDot.AutoSize = true;
            this.btnDot.Location = new System.Drawing.Point(231, 121);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(93, 13);
            this.btnDot.TabIndex = 10;
            this.btnDot.TabStop = true;
            this.btnDot.Text = "Select Destination";
            this.btnDot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnDot_LinkClicked);
            // 
            // btnRestoreDot
            // 
            this.btnRestoreDot.AutoSize = true;
            this.btnRestoreDot.Location = new System.Drawing.Point(231, 55);
            this.btnRestoreDot.Name = "btnRestoreDot";
            this.btnRestoreDot.Size = new System.Drawing.Size(123, 13);
            this.btnRestoreDot.TabIndex = 11;
            this.btnRestoreDot.TabStop = true;
            this.btnRestoreDot.Text = "Select Database Source";
            this.btnRestoreDot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnRestoreDot_LinkClicked);
            // 
            // frmBackupDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(428, 161);
            this.Controls.Add(this.btnRestoreDot);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.lblRestore);
            this.Controls.Add(this.txtRestore);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDestination);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackupDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Back up Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbDialog;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label lblRestore;
        private System.Windows.Forms.TextBox txtRestore;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel btnDot;
        private System.Windows.Forms.LinkLabel btnRestoreDot;
    }
}