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
using EnumerationLibrary;

namespace frmChallan
{
    public partial class frmCannibalized : Form
    {
        public frmCannibalized()
        {
            InitializeComponent();
        }




        ProductDetails tblModel;
        SaveStatus prdStatus;
        public frmCannibalized(ProductDetails model, SaveStatus ps)
        {
            InitializeComponent();
            tblModel = model;
            prdStatus = ps;
            LoadInformation();
        }


        private void LoadInformation()
        {
            lblChallanNo.Text = tblModel.ReceiveChallan;
            lblModel.Text = tblModel.Model;
            lblSerial.Text = tblModel.Serial;
            lblChallanNo.ForeColor = Color.White;

            dgvReceiveDetails.DataSource = tblModel.CannibalizedProducts;
            

        }


        private void wireupProductGridView()
        {

            tblModel.CannibalizedProducts = new List<tblCannibalized>();
            tblModel = GlobalConfig.Idataconnection.GetCannibalizad(tblModel);
            dgvReceiveDetails.DataSource = tblModel.CannibalizedProducts;
            dgvReceiveDetails.ClearSelection();
        }

        private void frmCannibalized_Load(object sender, EventArgs e)
        {
            //if (prdStatus == SaveStatus.Read)
            //{
            //    DisableControls();
            //}
            wireUpdaBranch();
            cmbBranch.Select();
            cmbStatus.SelectedIndex = 1;

        }

        private void wireUpdaBranch()
        {
            List<tblBranch> BranchList = GlobalConfig.Idataconnection.Branch_Get_All;

            cmbBranch.DataSource = null;
            cmbBranch.ValueMember = "BranchID";
            cmbBranch.DisplayMember = "Branch";
            cmbBranch.DataSource = BranchList;
            cmbBranch.SelectedIndex = -1;

        }


        private void wireupDataGrid(tblCannibalized parts)
        {


            tblModel.CannibalizedProducts = dgvReceiveDetails.DataSource as List<tblCannibalized>;

            tblModel.CannibalizedProducts.Add(parts);


            dgvReceiveDetails.DataSource = null;
            dgvReceiveDetails.DataSource = tblModel.CannibalizedProducts;









        }


        private void DisableControls()
        {
            tblProductInformation.Enabled = false;
            dgvReceiveDetails.Enabled = false;
            dgvReceiveDetails.ClearSelection();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isValidattion)
            {
                return;
            }

            tblCannibalized model = new tblCannibalized()
            {
                ChallanNo = lblChallanNo.Text,
                Model = lblModel.Text,
                Serial = lblSerial.Text,
                ReceivedDate = Convert.ToDateTime(dtpReceiveDate.Value.ToShortDateString()),
                ProductName = txtDescription.Text,
                PartNo = txtPartNo.Text,
                Branch = cmbBranch.Text,
                JobCode = txtJobNo.Text,
                Status = cmbStatus.Text,
                OrderQty = decimal.Parse(txtOrderQty.Text),
                OrderDate = Convert.ToDateTime(dtpOrderDate.Value.ToShortDateString()),
                Accessories = txtAccessries.Text
            };

            try { 
            model = GlobalConfig.Idataconnection.CannibalizedCreate(model);
                MessageBox.Show("Record Saved Successfully");
                            wireupDataGrid(model);
                Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Clear()
        {
            cmbBranch.SelectedIndex = -1;
            txtJobNo.Text = "";
            cmbStatus.SelectedIndex = 1;
            txtDescription.Text="";
            dtpReceiveDate.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            dtpOrderDate.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            txtOrderQty.Text = "0";
            txtAccessries.Text = "";
            txtPartNo.Text = "";
            


            txtAccessries.Text = "";


        }

        private bool isValidattion
        {
            get
            {
                bool blnFlag = true;
                decimal decOrderQty = 0;

                if (decimal.TryParse(txtOrderQty.Text, out decOrderQty) == false)
                {

                    MessageBox.Show("'Order Qty' is not a Number", "Invalid Format");
                    txtOrderQty.Select();
                    blnFlag = false;
                    return blnFlag;

                }


                if (txtDescription.Text.Length <= 0)
                {
                    MessageBox.Show("Description is Empty", "Missing Information");
                    txtDescription.Select();
                    blnFlag = false;

                    return blnFlag;
                }


                //if (txtPartNo.Text.Length <= 0)
                //{
                //    MessageBox.Show("Part No is Empty", "Missing Information");
                //    txtPartNo.Select();
                //    blnFlag = false;

                //    return blnFlag;
                //}


                if (cmbBranch.SelectedValue == null)
                {
                    MessageBox.Show("Branch Not fount in the List", "Incorrect Selection");
                    cmbBranch.Select();
                    blnFlag = false;
                    return blnFlag;
                }


                if (txtJobNo.Text.Length <= 0)
                {
                    MessageBox.Show("Job No is Empty", "Missing Information");
                    txtJobNo.Select();
                    blnFlag = false;
                    return blnFlag;
                }


                if (cmbStatus.Text.Length <= 0)
                {
                    MessageBox.Show("Job No is Empty", "Missing Information");
                    txtJobNo.Select();
                    blnFlag = false;
                    return blnFlag;
                }

                return blnFlag;

            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            
            //WireupFilterDatagrid_By_Description(); //it can be used later as required.
        }

        private void WireupFilterDatagrid_By_Description()
        {
            dgvFilterProduct.DataSource = null;
            dgvFilterProduct.Visible = false;
            if (txtDescription.Text.Length == 0)
            {

                return;

            }


            List<Product> prdlist = GlobalConfig.Idataconnection.GetAllProduct.Where(x => x.ProdName.ToLower().StartsWith(txtDescription.Text.ToLower())).ToList();


            if (prdlist.Count > 0)
            {
                dgvFilterProduct.DataSource = prdlist;
                dgvFilterProduct.Left = txtDescription.Left;
                dgvFilterProduct.Visible = true;
            }



        }






        private void WireupFilterDatagrid_By_PartNo()
        {
            dgvFilterProduct.DataSource = null;
            dgvFilterProduct.Visible = false;
            if (txtPartNo.Text.Length == 0)
            {

                return;

            }


            List<Product> prdlist = GlobalConfig.Idataconnection.GetAllProduct.Where(x => x.Code.ToLower().StartsWith(txtPartNo.Text.ToLower())).ToList();


            if (prdlist.Count > 0)
            {
                dgvFilterProduct.DataSource = prdlist;
                dgvFilterProduct.Left = txtPartNo.Left;
                dgvFilterProduct.Visible = true;
            }



        }


        private void dgvFilterProduct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            LoadSearial();
        }

        private void LoadSearial()
        {
            foreach (DataGridViewRow row in dgvFilterProduct.Rows)
            {

                dgvFilterProduct.Rows[row.Index].HeaderCell.Value = string.Format("{0}", row.Index + 1);



            }
            dgvFilterProduct.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);
        }

        private void txtPartNo_TextChanged(object sender, EventArgs e)
        {
            WireupFilterDatagrid_By_PartNo();
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //SelecteSearchProductList(); //it can be used later as required.
            }
        }

        void SelecteSearchProductList()
        {
            if (dgvFilterProduct.Visible == true)
            {
                dgvFilterProduct.Select();
                dgvFilterProduct.Rows[0].Selected = true;
            }
        }

        private void txtPartNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (dgvFilterProduct.Visible == true)
                {
                    dgvFilterProduct.Select();
                    dgvFilterProduct.Rows[0].Selected = true;
                }
                else
                {
                    btnAdd.Select();
                }
            }
        }

        private void dgvFilterProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                GetGridRow();
            }
                    }

        private void GetGridRow()
        {
          

                Product p = dgvFilterProduct.SelectedRows[0].DataBoundItem as Product;

                txtDescription.Text = p.ProdName;
                txtPartNo.Text = p.Code;
                dgvFilterProduct.Visible = false;
                dtpReceiveDate.Select();


            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dtpReceiveDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtpOrderDate.Select();
            }
        }

        private void cmbBranch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtJobNo.Select();
            }
        }

        private void txtJobNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbStatus.Select();
            }
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDescription.Select();
            }
        }

        private void dtpOrderDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtOrderQty.Select();
            }
        }

        private void txtOrderQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtAccessries.Select();
            }
        }

        private void txtAccessries_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPartNo.Select();
            }
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            
          
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NSANIMATION.Animations.DragControl(this.Handle);
            }
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                NSANIMATION.Animations.DragControl(this.Handle);
            }
        }

        private void dgvFilterProduct_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int intRowIndex = dgvFilterProduct.HitTest(e.X, e.Y).RowIndex;
            if (intRowIndex != -1)
            {
                GetGridRow();
            }
        }

        private void dgvReceiveDetails_MouseUp(object sender, MouseEventArgs e)
        {
            int introwindex = dgvReceiveDetails.HitTest(e.X, e.Y).RowIndex;


            if (introwindex == -1)
            {
                cntxDeleteRecord.Enabled = false;
            }
            else
            {
                cntxDeleteRecord.Enabled = true;
                dgvReceiveDetails.ClearSelection();
                dgvReceiveDetails.Rows[introwindex].Selected = true;
            }
        }

        private void cntxDeleteRecord_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            wireupProductGridView();
        }

        private void DeleteRecord()
        {
            if (dgvReceiveDetails.Rows.Count <= 0)
            {
                return;
            }
            if (dgvReceiveDetails.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No Row Selected in the Product List", "Invalid Selection");
                dgvReceiveDetails.Select();
                return;
            }

            tblCannibalized model = dgvReceiveDetails.SelectedRows[0].DataBoundItem as tblCannibalized;
            GlobalConfig.Idataconnection.DeleteCannibalizad(model);



        }

        private void txtDescription_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                //SelecteSearchProductList(); //it can be used later as required.
            }
        }

        private void lnkBranch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBranch frm = new frmBranch();
            frm.ShowDialog();
        }
    }
}
