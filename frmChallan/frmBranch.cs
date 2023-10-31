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
using DataConnection;
using frmChallan.InterfaceLibrary;
namespace frmChallan
{
    public partial class frmBranch : Form
    {

        IDataRequestor Ibranchrequestor;
        public frmBranch()
        {
            InitializeComponent();
        }


        public frmBranch(IDataRequestor Initialequestor)
        {
            InitializeComponent();
            Ibranchrequestor = Initialequestor;
        }

        private void frmBranch_Load(object sender, EventArgs e)
        {
            LoadBranch();
        }

        private void LoadBranch()
        {
            List<tblBranch> BranchList = GlobalConfig.Idataconnection.Branch_Get_All;

            lstBranch.DataSource = null;

            lstBranch.DisplayMember = "Branch";
            lstBranch.ValueMember = "BranchID";
            lstBranch.DataSource = BranchList;
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try { 
            if (txtBranch.Text.Length <= 0)
            {
                MessageBox.Show("Branch field is blank", "Please Fill");
                txtBranch.Select();
                return;
            }

            tblBranch model = new tblBranch();
            model.Branch = txtBranch.Text;

            GlobalConfig.Idataconnection.CreateBranch(model);
            this.Close();
                Ibranchrequestor.GetBranch();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
