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
using BussinessLibrary;
using BussinessLibrary.SupportLibrary;
using frmChallan.InterfaceLibrary;

namespace frmChallan
{
    public partial class frmUpdateDetails : Form, IUpdateChallanRequestor
    {
        public frmUpdateDetails()
        {
            InitializeComponent();
        }

        tblMasterDetails PreviousRecord;
        ProductDetails ProductDetailsModel;
        IReceiveDetailsRequestor ReceiveRequestor;
        public frmUpdateDetails(tblMasterDetails model, ProductDetails PDM, IReceiveDetailsRequestor requestor)
        {
            InitializeComponent();

            PreviousRecord = model;
            ProductDetailsModel = PDM;
            ReceiveRequestor = requestor;
        }


        private void frmUpdateDetails_Load(object sender, EventArgs e)
        {
            wireupModel();
            cmbBrand.Select();
            wireupComboBox();
        }

        private void wireupModel()
        {
            
       
            lblChallanNo.Text = PreviousRecord.ChallanNo;
            lblBrand.Text = PreviousRecord.Brand;
            lblCategory.Text = PreviousRecord.Category;
            lblDescription.Text = PreviousRecord.ProductName;  // Define Database Field ProductName=Description
            lblModel.Text = PreviousRecord.Model;
            lblSerial.Text = PreviousRecord.Serial;
            lblLocatiion.Text = PreviousRecord.Code; // Define Database Field Code=Location
            lblReceiveChallan.Text = PreviousRecord.ReceiveChallan;
            txtDescription.Text = PreviousRecord.ProductName;  // Define Database Field ProductName=Description
            txtSerial.Text = PreviousRecord.Serial;  // Define Database Field ProductName=Description
            txtLocation.Text = PreviousRecord.Code;// Define Database Field Code=Location
            
            
            lblProductStatus.Text = "Product Not Delivered";

            if (ProductDetailsModel.DeliveryChallan != null)
            {
                lblProductStatus.Text = "Product Delivered";
                lblDeliveryChallanMID.Text = GlobalConfig.Idataconnection.GetMasterDetailsID(ProductDetailsModel).ToString();
                lblDeliveryChallan.Text = ProductDetailsModel.DeliveryChallan;
                txtReceiveChallan.Text = ProductDetailsModel.ReceiveChallan;
                               
            }

        }



        private void wireupComboBox()
        {

            LoadBrand();
            LoadCategory();
            LoadModel();

        }

        private void LoadBrand()
        {

            cmbBrand.DataSource = null;

            List<tblBrand> BrandList = GlobalConfig.Idataconnection.Brand_Get_All;

            cmbBrand.DisplayMember = "Brand";
            cmbBrand.ValueMember = "BrandID";
            cmbBrand.DataSource = BrandList;

            cmbBrand.Text = PreviousRecord.Brand;

        }


        private void LoadCategory()
        {

            cmbCategory.DataSource = null;

            List<tblCategory> CategoryList = GlobalConfig.Idataconnection.Category_Get_All;

            cmbCategory.DisplayMember = "Category";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DataSource = CategoryList;

            cmbCategory.Text = PreviousRecord.Category;

        }

        private void LoadModel()
        {

            cmbModel.DataSource = null;

            List<tblModel> ModelList = GlobalConfig.Idataconnection.Model_Get_All;

            cmbModel.DisplayMember = "Model";
            cmbModel.ValueMember = "ModelID";
            cmbModel.DataSource = ModelList;

            cmbModel.Text = PreviousRecord.Model;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            tblMasterDetails prModel = new tblMasterDetails();

            prModel.ChallanNo = lblChallanNo.Text;
            if (cmbBrand.SelectedValue == null)
            {
                prModel.Brand = lblBrand.Text;
            }
            else
            {
                prModel.Brand = cmbBrand.Text;
            }


            if (cmbCategory.SelectedValue == null)
            {
                prModel.Category = lblCategory.Text;
            }
            else
            {
                prModel.Category = cmbCategory.Text;
            }


            if (cmbModel.SelectedValue == null)
            {
                prModel.Model = lblModel.Text;
            }
            else
            {
                prModel.Model = cmbModel.Text;
            }

            if (txtDescription.Text.Length <= 0)
            {
                prModel.ProductName = lblDescription.Text;
            }
            else
            {
                prModel.ProductName = txtDescription.Text;
            }

            if (txtSerial.Text.Length <= 0)
            {
                prModel.Serial = lblSerial.Text;
            }
            else
            {
                prModel.Serial = txtSerial.Text;
            }


            if (txtLocation.Text.Length <= 0)
            {
                prModel.Code = lblLocatiion.Text;
            }
            else
            {
                prModel.Code = txtLocation.Text;
            }

       

            try
            {
                //Update Receive Challan
                GlobalConfig.Idataconnection.UpdateMasterDetails(PreviousRecord, prModel);

                //Update Delivery Challan
                if (lblDeliveryChallanMID.Text.Length > 0)
                {

                    if (txtReceiveChallan.Text.Length <= 0)
                    {
                        prModel.ReceiveChallan = "";
                    }
                    else
                    {
                        prModel.ReceiveChallan = txtReceiveChallan.Text;
                    }

                    PreviousRecord.MDID = int.Parse(lblDeliveryChallanMID.Text);
                    prModel.ChallanNo = lblDeliveryChallan.Text;
                    prModel.ReceiveChallan = lblChallanNo.Text;

                    GlobalConfig.Idataconnection.UpdateMasterDetails(PreviousRecord, prModel);
                };
                MessageBox.Show("Record Update Successfully");

                this.Close();
                if (ReceiveRequestor != null)
                {
                    ReceiveRequestor.RefreshList();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void lnkBrand_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBrand frm = new frmBrand();
            frm.ShowDialog();
        }

        private void lnkCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.ShowDialog();
        }

        private void lnkModel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmModel frm = new frmModel();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RefreshChallan(string challanno)
        {
            lblChallanNo.Text = challanno;
            PreviousRecord.ChallanNo = challanno;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChallanChange frm = new frmChallanChange(lblChallanNo.Text, this);
            frm.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            cmbBrand.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            cmbModel.SelectedIndex = -1;
            txtDescription.Text = "";
            txtSerial.Text = "";
            txtLocation.Text = "";
            txtReceiveChallan.Text = "";


        }
    }




}
