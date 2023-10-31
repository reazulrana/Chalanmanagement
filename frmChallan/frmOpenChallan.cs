using BussinessLibrary;
using DataConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmChallan.InterfaceLibrary;
namespace frmChallan
{
    public partial class frmOpenChallan : Form
    {



        public frmOpenChallan()
        {
            InitializeComponent();
        }


        IFormRequestor frmrequestor;
        public frmOpenChallan(IFormRequestor requestor)
        {
            InitializeComponent();
            frmrequestor = requestor;
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (optReceive.Checked == true)
            {
                wireupDatagridView("Receive");
            }
            else
            {
                wireupDatagridView("Delivery");
            }

        }


        private void wireupDatagridView(string ValueType)
        {


            dgvChallanDetails.DataSource = null;
            if (txtSearch.Text.Length <= 0)
            {
                dgvChallanDetails.Visible = false;
                return;
            }

            List<tblMaster> Output = GlobalConfig.Idataconnection.MasterDetailGetAll;
            List<tblMaster> FilterRecord = new List<tblMaster>();

            if (Output.Count > 0)
            {
                FilterRecord = Output.Where(x => x.TrType.ToLower() == ValueType.ToLower() && x.ChallanNo.ToLower().StartsWith(txtSearch.Text.ToLower())).ToList();
            }

            if (FilterRecord.Count > 0)
            {
                dgvChallanDetails.DataSource = FilterRecord;
                dgvChallanDetails.Visible = true;
            }
            else
            {
                dgvChallanDetails.Visible = false;
            }
        }

        private void frmOpenChallan_Load(object sender, EventArgs e)
        {
            optReceive.Checked = true;
            dgvChallanDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmOpenChallan_Resize(object sender, EventArgs e)
        {
            dgvChallanDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (dgvChallanDetails.Visible == true)
                {
                    dgvChallanDetails.Select();
                    dgvChallanDetails.Rows[0].Selected = true;
                }
            }
        }

        private void dgvChallanDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                openChallan();
            }
        }


        private void openChallan()
        {


            tblMaster model = dgvChallanDetails.SelectedRows[0].DataBoundItem as tblMaster;

            model = GlobalConfig.Idataconnection.MasterDetailGetSingle(model);

        
         
            frmrequestor.DockForm(model);
            this.Close();
            //frm.Show();






        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dgvChallanDetails.Visible == true)
            {
                if (dgvChallanDetails.SelectedRows.Count > 0)
                {
                    openChallan();
                }
            }

        }

        private void dgvChallanDetails_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int introwindex = dgvChallanDetails.HitTest(e.X, e.Y).RowIndex;

            if (introwindex != -1)
            {
                openChallan();
            }
        }
    }
}
