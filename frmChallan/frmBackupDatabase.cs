using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataConnection;

namespace frmChallan
{
    public partial class frmBackupDatabase : Form
    {
        public frmBackupDatabase()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {


            if (txtDestination.Text.Length == 0)
            {
                MessageBox.Show("No Destination is selected","Miising Path");
                return;
            }


            try {
                GlobalConfig.Idataconnection.BackupDatabase(txtDestination.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + ex.StackTrace,"Exception");
            }
        }



        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (txtRestore.Text.Length == 0)
            {
                MessageBox.Show("No Source is selected", "Miising Path");
                return;
            }


            try
            {
                GlobalConfig.Idataconnection.RestoreDatabase(txtRestore.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRestoreDot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "(*.bak)|*.bak";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtRestore.Text = openFileDialog1.FileName;




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                txtDestination.Text = fbDialog.SelectedPath;
            }
        }
    }
}
