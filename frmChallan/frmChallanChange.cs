using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLibrary;
using BussinessLibrary.SupportLibrary;
using DataConnection;
using frmChallan.InterfaceLibrary;

namespace frmChallan
{
    public partial class frmChallanChange : Form
    {
        public frmChallanChange()
        {
            InitializeComponent();
        }

        IUpdateChallanRequestor updaterequestor;
        string Retrivechallan = "";
        public frmChallanChange(string ChallanNo,IUpdateChallanRequestor requestor)
        {
            InitializeComponent();
            Retrivechallan = ChallanNo;
            updaterequestor = requestor;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChallanChange_Load(object sender, EventArgs e)
        {
            try { 
            wireupCombobox();
            cmbChallan.Select();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

        }

        void wireupCombobox()
        {
            List<tblMaster> MasterList = GlobalConfig.Idataconnection.GetAlltblMaster;


            cmbChallan.DataSource = null;
            cmbChallan.DisplayMember = "ChallanNo";
            cmbChallan.ValueMember = "MID";
            cmbChallan.DataSource = MasterList;
            cmbChallan.SelectedIndex = -1;

            if (Retrivechallan.Length > 0)
            {
                cmbChallan.Text = Retrivechallan;
                LoadChallan();
            }




        }

        private void cmbChallan_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadChallan();
        }

        void LoadChallan()
        {
            txtPreviousChallan.Text = cmbChallan.Text;
            txtChangeChallan.Text = cmbChallan.Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                GlobalConfig.Idataconnection.ChangeChallanNo(txtPreviousChallan.Text, txtChangeChallan.Text);
                this.Close();
                if (updaterequestor != null)
                {
                    updaterequestor.RefreshChallan(txtChangeChallan.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
