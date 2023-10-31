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
using frmChallan.InterfaceLibrary;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Configuration;

namespace frmChallan
{
    public partial class frmReceiveDetails : Form,IReceiveDetailsRequestor
    {
        List<ProductDetails> ReserveList = new List<ProductDetails>();
        List<ProductDetails> PDL;
        ReturnType rtp;
        public frmReceiveDetails()
        {
            InitializeComponent();

            LoadAllReceiveInformaiton();
           
        }

        IFormRequestor frmrequestor;
        List<ProductDetails> FilterPrductList = new List<ProductDetails>();


        public frmReceiveDetails(IFormRequestor requestor)
        {
            InitializeComponent();

            // Receive List Load on form Load
            LoadAllReceiveInformaiton();
            frmrequestor = requestor;

        }




        private void LoadAllReceiveInformaiton()
        {
            List<ProductDetails> pdl = GlobalConfig.Idataconnection.GetProductDetails_ByReceive();
            ReserveList = pdl;
            FilterPrductList = pdl;
            dgvReceiveDetails.DataSource = null;
            dgvReceiveDetails.DataSource = pdl;
            lblIndividualModel.Text = "All Product";


        
 

        }


     
        public frmReceiveDetails(List<ProductDetails> model)
        {
            InitializeComponent();
            PDL = model;
            wireupDataGridView();

        }

        public frmReceiveDetails(List<ProductDetails> model, ReturnType rtype, IFormRequestor requestor)
        {
            InitializeComponent();
            PDL = model;
            rtp = rtype;
            frmrequestor = requestor;
            wireupDataGridView();

        }



        private void frmReceiveDetails_Load(object sender, EventArgs e)
        {
            pnlGroupList.Visible = false;
            ReserveList = dgvReceiveDetails.DataSource as List<ProductDetails>;
            optReceiveChallan.Checked = true;
            txtFilter.Select();
            CheckGridItem();
            optAll.Checked = true;
        }

        private void CheckGridItem()
        {
            grpList.SetItemChecked(0, true);    //Receive Challan
            grpList.SetItemChecked(1, false);   //Brand
            grpList.SetItemChecked(2, false);   //Category
            grpList.SetItemChecked(3, true);    //Product Name
            grpList.SetItemChecked(4, false);   //Code
            grpList.SetItemChecked(5, true);    //Model
            grpList.SetItemChecked(6, true);    //Serial
            grpList.SetItemChecked(7, true);    //Receive Date
            grpList.SetItemChecked(8, true);    //Delivery Date
            grpList.SetItemChecked(9, true);   //Delivery Challan
            grpList.SetItemChecked(10, false);  //Source
            grpList.SetItemChecked(11, true);   //Destination
            grpList.SetItemChecked(12, false);  //Condition
            grpList.SetItemChecked(13, false);   //Remarks
            grpList.SetItemChecked(14, false);   //N.R Reason
            grpList.SetItemChecked(15, false);   //N.R Reason
            grpList.SetItemChecked(15, true);   //Can.Qty Reason
            grpList.SetItemChecked(16, true);   //Can.Qty Reason
            grpList.SetItemChecked(17, true);   //Can.Qty Reason



        }


        private void wireupDataGridView()
        {
            dgvReceiveDetails.DataSource = null;
            dgvReceiveDetails.DataSource = PDL;
            if (rtp == ReturnType.Single)
            {
                if (PDL != null)
                {
                    if (PDL.Count > 0)
                    {
                        lblIndividualModel.Text = lblIndividualModel.Text + " (" + PDL[0].Model + ")";
                    }
                }
            }

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvReceiveDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            LoadSerial();
        }

        private void LoadSerial()
        {

            foreach (DataGridViewRow row in dgvReceiveDetails.Rows)
            {

                dgvReceiveDetails.Rows[row.Index].HeaderCell.Value = string.Format("{0}", row.Index + 1);


            }


        }

        private void btnExport_Click(object sender, EventArgs e)
        {
         
            if (GlobalConfig.Idataconnection.isEx==true)
            {
                NSMSOFFICE.ExcelInformation.ExportGridView(dgvReceiveDetails, dgvReceiveDetails.Columns.Count,8000);
            }
            else { 
            NSMSOFFICE.ExcelInformation.ExportGridView(dgvReceiveDetails, dgvReceiveDetails.Columns.Count, dgvReceiveDetails.Rows.Count);
            }
        }


        private void btnHide_Click(object sender, EventArgs e)
        {


        }


        private void grpList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                if (e.CurrentValue == CheckState.Checked)
                {
                    dgvReceiveDetails.Columns[e.Index].Visible = false;
                }
                else
                {
                    dgvReceiveDetails.Columns[e.Index].Visible = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grpList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHide_Click_1(object sender, EventArgs e)
        {
            pnlGroupList.Visible = false;
            lblGridList.Enabled = true;
        }

        private void lblGridList_Click(object sender, EventArgs e)
        {

            pnlGroupList.Visible = true;
            //pnlBody.Controls.Add(pnlGroupList);
            pnlGroupList.Location = new Point(this.ClientSize.Width/2,this.ClientSize.Height/10);
            //pnlBody.BringToFront();
            lblGridList.Enabled = false;
            lblGridList.BringToFront();

        }

        private void dgvReceiveDetails_MouseUp(object sender, MouseEventArgs e)
        {

            int intRowIndex = dgvReceiveDetails.HitTest(e.X, e.Y).RowIndex;

            if (intRowIndex == -1)
            {
                cntxAddCannibalized.Enabled = false;
                cntxCannibalizedInfo.Enabled = false;
                cntxNotReturnable.Enabled = false;
                cntxCancelNotReturnable.Enabled = false;
                cntxEdit.Enabled = false;

            }
            else
            {
                dgvReceiveDetails.ClearSelection();
                dgvReceiveDetails.Rows[intRowIndex].Selected = true;
                cntxAddCannibalized.Enabled = true;
                cntxCannibalizedInfo.Enabled = true;
                cntxNotReturnable.Enabled = true;
                cntxCancelNotReturnable.Enabled = true;
                cntxEdit.Enabled = true;

            }




        }

        private void cntxAddCannibalized_Click(object sender, EventArgs e)
        {



            LoadCannibalized();



        }

        private void LoadCannibalized()
        {
            ProductDetails model = dgvReceiveDetails.SelectedRows[0].DataBoundItem as ProductDetails;
            model = GlobalConfig.Idataconnection.GetCannibalizad(model);

            if (frmrequestor != null)
            {
                frmrequestor.DockCannibalized(model, SaveStatus.Save);
            }


        }

        private void cntxCannibalizedInfo_Click(object sender, EventArgs e)
        {
            ProductDetails model = dgvReceiveDetails.SelectedRows[0].DataBoundItem as ProductDetails;
            model = GlobalConfig.Idataconnection.GetCannibalizad(model);
         frmCannibalizedInfo frm = new frmCannibalizedInfo(model);
                frm.ShowDialog();
         

        }

        private void dgvReceiveDetails_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int intRowIndex = dgvReceiveDetails.HitTest(e.X, e.Y).RowIndex;

            if (intRowIndex != -1)
            {
                LoadCannibalized();

            }


        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

            filterRecord();
        }

        private void filterRecord()
        {

            if (txtFilter.Text.Length == 0)
            {
                resetDatagridView();
                return;
            }

            //optAll.Checked = true;

            List<ProductDetails> prdl = FilterPrductList;
            

            if (optReceiveChallan.Checked == true)
            {
                prdl = prdl.Where(x => x.ReceiveChallan != null & x.ReceiveChallan.ToLower().StartsWith(txtFilter.Text.ToLower())).ToList();
            }


            if (optModel.Checked == true)
            {
                prdl = prdl.Where(x => x.Model != null & x.Model.ToLower().StartsWith(txtFilter.Text.ToLower())).ToList();
            }


            if (optSerial.Checked == true)
            {
                prdl = prdl.Where(x => x.Serial != null & x.Serial.ToLower().StartsWith(txtFilter.Text.ToLower())).ToList();
            }


            if (optDescription.Checked == true)
            {
                prdl = prdl.Where(x => x.ProductName != null & x.ProductName.ToLower().StartsWith(txtFilter.Text.ToLower())).ToList();
            }


            if (optJobCode.Checked == true)
            {

         
                prdl = prdl.Where(x => x.JobCode != null).ToList();

                prdl = prdl.Where(x => x.JobCode.ToLower().Contains(txtFilter.Text.ToLower())).ToList();
            }

            if (optBranch.Checked == true)
            {


                prdl = prdl.Where(x => x.Branch != null).ToList();

                prdl = prdl.Where(x => x.Branch.ToLower().StartsWith(txtFilter.Text.ToLower())).ToList();
            }

            //Datasource Is Update
            //Please Add Some Line
            dgvReceiveDetails.DataSource = null;
            dgvReceiveDetails.DataSource = prdl;




        }


        private void resetDatagridView()
        {
            dgvReceiveDetails.DataSource = null;

            dgvReceiveDetails.DataSource = FilterPrductList;
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NSANIMATION.Animations.DragControl(this.Handle);
            }
        }

        private void lblIndividualModel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NSANIMATION.Animations.DragControl(this.Handle);
            }
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NSANIMATION.Animations.DragControl(this.Handle);
            }
        }

        private void optReturnableProduct_CheckedChanged(object sender, EventArgs e)
        {
            List<ProductDetails> pdls = ReserveList.Where(x => x.ProductReturn != null && x.ProductReturn.ToLower() == "Return Completed".ToLower()).ToList();
            FilterReturnable_NotReturnable_Product(pdls);
        }

        private void FilterReturnable_NotReturnable_Product(List<ProductDetails> models)
        {
            FilterPrductList = new List<ProductDetails>();
            dgvReceiveDetails.DataSource = null;
            dgvReceiveDetails.DataSource = models;
            FilterPrductList = models;

        }

        private void optNotReturnableProduct_CheckedChanged(object sender, EventArgs e)
        {
            List<ProductDetails> pdls = ReserveList.Where(x => x.NonReturn != null && x.NonReturn.ToLower() == "Not Returnable".ToLower()).ToList();


            FilterReturnable_NotReturnable_Product(pdls);
        }

        private void optAll_CheckedChanged(object sender, EventArgs e)
        {

            FilterReturnable_NotReturnable_Product(ReserveList);
        }

        private void cntxNotReturnable_Click(object sender, EventArgs e)
        {
            CreateNotReturn();
        }


        private void CreateNotReturn()
        {
            ProductDetails product = dgvReceiveDetails.SelectedRows[0].DataBoundItem as ProductDetails;




            

            try
            {
                if (product != null)
                {


                    if(product.DeliveryChallan!=null)
                    {
                        MessageBox.Show("The product is already delivered", "Fail");
                        return;
                    }



                    tblNotReturn np = new tblNotReturn();
                    np.Model = product.Model;
                    np.Serial = product.Serial;
                    np.ChallanNo = product.ReceiveChallan;



                    string strReason = Microsoft.VisualBasic.Interaction.InputBox("Enter Reason for Not Return", "Not Returnable", "", (dgvReceiveDetails.Left + dgvReceiveDetails.Width) / 2, (dgvReceiveDetails.Top + dgvReceiveDetails.Height) / 2);


                    np.NRReason = strReason;

                    GlobalConfig.Idataconnection.CreateNotReturn(np);
                    LoadAllReceiveInformaiton();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        private void cntxCancelNotReturnable_Click(object sender, EventArgs e)
        {
            try { 
            DeleteNotReturn();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteNotReturn()
        {
            ProductDetails product = dgvReceiveDetails.SelectedRows[0].DataBoundItem as ProductDetails;

            try
            {
                if (product != null)
                {
                    tblNotReturn np = new tblNotReturn();
                    np.Model = product.Model;
                    np.Serial = product.Serial;
                    np.ChallanNo = product.ReceiveChallan;

                    GlobalConfig.Idataconnection.DeleteNotReturn(np);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void optSerial_CheckedChanged(object sender, EventArgs e)
        {
            SelectFilterText();
        }

        void SelectFilterText()
        {
            txtFilter.Text = "";
            txtFilter.Select();
        }

        private void optDescription_CheckedChanged(object sender, EventArgs e)
        {
            SelectFilterText();
        }

        private void optModel_CheckedChanged(object sender, EventArgs e)
        {
            SelectFilterText();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SelectFilterText();
        }

        private void cntxEdit_Click(object sender, EventArgs e)
        {
            wireupEdit();
            
        }

        void wireupEdit()
        {

            ProductDetails tmd = dgvReceiveDetails.SelectedRows[0].DataBoundItem as ProductDetails;

            tblMasterDetails tmodel = GlobalConfig.Idataconnection.GetMasterDetails_by_Challan_Model_Serial(tmd);


            if (tmodel != null)
            {


                frmUpdateDetails frm = new frmUpdateDetails(tmodel, tmd, this);
                frm.ShowDialog();

            }



        }

        public void RefreshList()
        {
            LoadAllReceiveInformaiton();
        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void optNonCannibalized_CheckedChanged(object sender, EventArgs e)
        {
            List<ProductDetails> pdls = ReserveList.Where(x => string.IsNullOrEmpty(x.TotalCannibalized)).ToList();
            FilterReturnable_NotReturnable_Product(pdls);
        }

        private void optCannibalized_CheckedChanged(object sender, EventArgs e)
        {
            List<ProductDetails> pdls = ReserveList.Where(x => !string.IsNullOrEmpty(x.TotalCannibalized)).ToList();
            FilterReturnable_NotReturnable_Product(pdls);
        }

        private void pnlTitle_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.BringToFront();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.BringToFront();
        }

        private void lblIndividualModel_Click(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.BringToFront();
        }

        private void pnlTitle_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void optJobCode_CheckedChanged(object sender, EventArgs e)
        {
            txtFilter.Select();
        }

        private void optBranch_CheckedChanged(object sender, EventArgs e)
        {
            txtFilter.Select();
        }
    }
}

