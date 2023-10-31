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
using System.Net;
using System.Net.NetworkInformation;
using BussinessLibrary.SupportLibrary;

namespace frmChallan
{
    public partial class frmReciveProduct : Form, IDataRequestor
    {



        string TransactionType = "";
        tblMaster editmodel;
        List<tblMasterDetails> ListOfProduct;
        public frmReciveProduct()
        {
            InitializeComponent();
            ListOfProduct = new List<tblMasterDetails>();
            TransactionType = "New";
        }





        public frmReciveProduct(tblMaster model, string trType)
        {
            InitializeComponent();

            ListOfProduct = new List<tblMasterDetails>();
            editmodel = model;
            TransactionType = trType;

        }



        private void EditMode(tblMaster model)
        {
            txtChallanNo.Text = model.ChallanNo;
            dtpChallanDate.Value = model.TrDate;
            cmbSourceFrom.Text = model.Source;
            cmbDestinationTo.Text = model.Destination;
            lblTrType.Text = model.TrType;
            ListOfProduct.AddRange(model.ProductList);
            wireupGridview();
            txtRemarks.Text = model.Remarks;
            EditMode();

        }

        private void NewMode()
        {

            btnSave.Text = "&New";
            TransactionType = "New";
        }


        private void EditMode()
        {

            btnSave.Text = "&Update";
            TransactionType = "Edit";
        }

        private void lnkBranchAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBranch frm = new frmBranch(this);
            frm.ShowDialog();
        }

        private void frmReciveProduct_Load(object sender, EventArgs e)
        {


            optNewProduct.Checked = true;
            txtChallanNo.Select();
            GetBranch();
            GetBrand();
            GetCategory();
            GetModel();
            if (TransactionType.ToLower() == "Edit".ToLower())
            {
                EditMode(editmodel);
            }

            if (lblTrType.Text.ToLower() == "Delivery".ToLower())
            {
                lblReceiveChallan.Visible = true;
                txtReceiveChallan.Visible = true;
                dgvProductList.Columns[8].Visible = true; //Receive Challan Visible


            }

         
        }

        public void GetBranch()
        {
            LoadDestinationTo();
            LoadSourceFrom();
        }

        private void ClearAll()
        {
            ListOfProduct = new List<tblMasterDetails>();
            txtChallanNo.Text = "";
            cmbSourceFrom.SelectedIndex = -1;
            cmbSourceFrom.SelectedIndex = -1;
            cmbDestinationTo.SelectedIndex = -1;
            ClearProductInformation();
            wireupGridview();
            optNewProduct.Select();
            txtRemarks.Text = "";
            cmbBrand.Text = "";
            cmbCategory.Text = "";
            txtDescription.Text = "";
            txtSerial.Text = "";
            cmbModel.Text = "";
            txtCode.Text = ""; //Location Field
            txtReceiveChallan.Text = "";

        }
        private void LoadDestinationTo()
        {
            List<tblBranch> Destinationbranch = GlobalConfig.Idataconnection.Branch_Get_All;
            string currentDestination = cmbDestinationTo.Text;
            cmbDestinationTo.DataSource = null;

            cmbDestinationTo.DisplayMember = "Branch";
            cmbDestinationTo.ValueMember = "BranchID";
            cmbDestinationTo.DataSource = Destinationbranch;
            cmbDestinationTo.SelectedIndex = -1;
            cmbDestinationTo.Text = currentDestination.ToUpper();

        }

        private void LoadSourceFrom()
        {


            List<tblBranch> Sourcebranch = GlobalConfig.Idataconnection.Branch_Get_All;
            string CurrentSource = cmbSourceFrom.Text;
            cmbSourceFrom.DataSource = null;
            cmbSourceFrom.DisplayMember = "Branch";
            cmbSourceFrom.ValueMember = "BranchID";
            cmbSourceFrom.DataSource = Sourcebranch;
            cmbSourceFrom.SelectedIndex = -1;
            cmbSourceFrom.Text = CurrentSource.ToUpper(); ;


        }

        private void lnkBrandAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBrand frm = new frmBrand(this);
            frm.ShowDialog();
        }
        public void GetBrand()
        {



            List<tblBrand> ListBrand = GlobalConfig.Idataconnection.Brand_Get_All;
            string CurrentBrand = cmbBrand.Text;

            cmbBrand.DataSource = null;
            cmbBrand.DisplayMember = "Brand";
            cmbBrand.ValueMember = "BrandID";
            cmbBrand.DataSource = ListBrand;
            cmbBrand.SelectedIndex = -1;
            cmbBrand.Text = CurrentBrand.ToUpper();

        }


        public void GetCategory()
        {

            List<tblCategory> ListCategory = GlobalConfig.Idataconnection.Category_Get_All;
            string CurrentCategry = cmbCategory.Text;

            cmbCategory.DataSource = null;
            cmbCategory.DisplayMember = "Category";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DataSource = ListCategory;
            cmbCategory.SelectedIndex = -1;
            cmbCategory.Text = CurrentCategry.ToUpper();

        }

        private void lnkCategoryAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCategory frm = new frmCategory(this);
            frm.ShowDialog();
        }

        private void lnkModelAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmModel frm = new frmChallan.frmModel(this);
            frm.ShowDialog();
        }

        public void GetModel()
        {
            List<tblModel> ListCategory = GlobalConfig.Idataconnection.Model_Get_All;
            string CurrentModel = cmbModel.Text;

            cmbModel.DataSource = null;
            cmbModel.DisplayMember = "Model";
            cmbModel.ValueMember = "ModelID";
            cmbModel.DataSource = ListCategory;
            cmbModel.SelectedIndex = -1;
            cmbModel.Text = CurrentModel.ToUpper();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductList.SelectedRows.Count > 0)
                {
                    RemoveItem();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (lblTrType.Text.ToLower() == "Delivery".ToLower())
            {
                          
            if (dgvProductList.Rows.Count > 0)
            {
                
                        
                        foreach(DataGridViewRow dtr in dgvProductList.Rows)
                        {
                            if (dtr.Cells[6].Value != null)
                            {
                                if(dtr.Cells[6].Value.ToString().ToLower()== txtSerial.Text.ToString().ToLower() && dtr.Cells[5].Value.ToString().ToLower() ==cmbModel.Text.ToLower())
                                {
                                    MessageBox.Show("Serial Is Duplicate");
                            lblMessage.Text = "Duplicat Serial: " + txtSerial.Text + " And Model: " + cmbModel.Text;
                                    return;
                                }
                            }
                        }
                        
                        
                        //MessageBox.Show(d.Cells[6].Value.ToString());
                    }
            }


            try
                {









                    ReceiveChallan();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
      



        private void SerialDataGrid(DataGridView grid)
        {


            foreach (DataGridViewRow row in grid.Rows)
            {


                grid.Rows[row.Index].HeaderCell.Value = string.Format("{0}", row.Index + 1).ToString();

            }

        }

        private void ClearProductInformation()
        {
            if (lblTrType.Text.ToLower() == "Receive".ToLower())
            {


                cmbBrand.SelectedIndex = -1;
                cmbCategory.SelectedIndex = -1;
                txtDescription.Text = "";
                cmbModel.SelectedIndex = -1;
                txtCode.Text = "";
            }
            txtSerial.Text = "";

        }


        private void ReceiveChallan()
        {
            if (!IsValidate)
            {
                return;
            }




            List<string> SerialList = txtSerial.Text.Split(',').ToList();


            //ListOfProduct = new List<tblMasterDetails>();

            foreach (string serial in SerialList)
            {
                tblMasterDetails ProductModel = new tblMasterDetails();
                ProductModel.Brand = cmbBrand.Text;
                ProductModel.Category = cmbCategory.Text;
                ProductModel.ProductName = txtDescription.Text;
                ProductModel.Code = txtCode.Text;
                ProductModel.Model = cmbModel.Text;
                ProductModel.Serial = serial;
                if (lblTrType.Text.ToLower() == "Delivery".ToLower())
                {
                    ProductModel.ReceiveChallan = txtReceiveChallan.Text;
                    txtReceiveChallan.Text = "";
                }

                if (lblTrType.Text.ToLower() == "Receive".ToLower())
                {


                    if (IsDuplicateSerial(SerialList, ProductModel))
                    {
                        return;
                    }
                }
                //ProductModel.IsReturnable = true;

                // Add All Product into Product List to wireup productlist gridview

                ListOfProduct.Add(ProductModel);
            }
            // wireup with dgvproductList

            wireupGridview();
            ClearProductInformation();
            if (lblTrType.Text.ToLower() == "Delivery".ToLower())
            {
                txtSerial.Select();

            }
            else
            {
                cmbBrand.Select();
            }


        }

        private bool IsDuplicateSerial(List<string> ListofSerial, tblMasterDetails model)
        {
            lblMessage.Text = "";
            lblMessage.BackColor = label1.BackColor;
            lblMessage.ForeColor = Color.Black;
            int intCount = 0;
            foreach (string str in ListofSerial)
            {


                if (str == model.Serial)

                {
                    intCount += 1;
                }
                if (intCount >= 2)
                {

                    lblMessage.Text = model.Serial;
                    FormatMessage();

                    return true;
                }



            }


            ProductDetails pd = GlobalConfig.Idataconnection.Check_Serial_Duplication(model);

            if (pd == null)
            {
                return false;
            }

            else
            {
                StringBuilder str = new StringBuilder();

                str.Append("Receive Challan: " + pd.ReceiveChallan);
                str.Append(" ; Model: " + pd.Model);
                str.AppendLine(" ; Serial: " + pd.Serial);
                str.Append("Receive Date: " + pd.ReceiveDate.Value.ToShortDateString());


                lblMessage.Text = "Previous Receive Information :: " + str.ToString();
                lblMessage.BackColor = Color.Red;
                lblMessage.Font = new Font("Times New Roman", 11, FontStyle.Bold);
                lblMessage.ForeColor = Color.White;
                lblMessage.TextAlign = ContentAlignment.MiddleLeft;
                return true;
            }



            return false;
        }

        
        private void FormatMessage()
        {
            lblMessage.BackColor = Color.Red;
            lblMessage.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            lblMessage.ForeColor = Color.White;
        }

        private void wireupGridview()
        {
            dgvProductList.DataSource = null;
            lblMessage.Text = "";
            ListOfProduct = ListOfProduct.OrderBy(x => x.Serial).ToList();
            dgvProductList.DataSource = ListOfProduct;
            lblMessage.Text = "Total Record Inserted : " + dgvProductList.Rows.Count;
            FormatMessage();

        }
        private bool IsValidate
        {
            get
            {

                bool blnFlag = true;



                if (cmbBrand.Text.Length > 0)
                {
                    cmbBrand.Text = cmbBrand.Text;
                };



                if (cmbBrand.SelectedValue == null)
                {
                    blnFlag = false;
                    MessageBox.Show("Brand Not Found", "Select Brand");
                    cmbBrand.Select();
                    return blnFlag;
                }




                if (cmbCategory.Text.Length > 0)
                {
                    cmbCategory.Text = cmbCategory.Text;
                };

                if (cmbCategory.SelectedValue == null)
                {
                    blnFlag = false;
                    MessageBox.Show("Category Not Found", "Select Category");
                    cmbCategory.Select();
                    return blnFlag;
                }

                if (txtDescription.Text.Length <= 0)
                {
                    blnFlag = false;
                    MessageBox.Show("Description Not Found", "Type Description");
                    txtDescription.Select();
                    return blnFlag;
                }


                if (cmbModel.Text.Length > 0)
                {
                    cmbModel.Text = cmbModel.Text;
                };

                if (cmbModel.Text.Length <= 0)
                {
                    blnFlag = false;
                    MessageBox.Show("Model Not Found", "Select Model");
                    cmbModel.Select();
                    return blnFlag;
                }


                if (txtSerial.Text.Length <= 0)
                {
                    blnFlag = false;
                    MessageBox.Show("Serial Not Found", "Type Serial");
                    txtSerial.Select();
                    return blnFlag;

                }

                if (lblTrType.Text.ToLower() == "Delivery".ToLower())
                {

                    if (txtReceiveChallan.Text.Length <= 0)
                    {
                        blnFlag = false;
                        MessageBox.Show("'Receive Challan' No Not Found", "Missing Receive Challan");
                        txtSerial.Select();
                        return blnFlag;
                    }
                }




                return blnFlag;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!AllValidation)
            {
                return;
            }



            tblMaster Mastermodel = new tblMaster();


            Mastermodel.ChallanNo = txtChallanNo.Text;
            Mastermodel.TrDate = Convert.ToDateTime(dtpChallanDate.Value.ToShortDateString());
            Mastermodel.Source = cmbSourceFrom.Text;
            Mastermodel.Destination = cmbDestinationTo.Text;
            Mastermodel.ProductList = (List<tblMasterDetails>)dgvProductList.DataSource;
            Mastermodel.TrType = lblTrType.Text;

            if (optNewProduct.Checked == true)
            {
                Mastermodel.ReceiveCondition = "New";
            }
            else if (optRepairProduct.Checked == true)
            {
                Mastermodel.ReceiveCondition = "Repair";
            }
            else
            {
                Mastermodel.ReceiveCondition = "New";
            }

            Mastermodel.Remarks = txtRemarks.Text;
            try
            {
                if (TransactionType.ToLower() == "New".ToLower())
                {
                    GlobalConfig.Idataconnection.CreateReceiveChallan(Mastermodel);
                    MessageBox.Show("Record Save Successfully", "Insert");
                }
                else
                {
                    GlobalConfig.Idataconnection.UpdateReceiveChallan(Mastermodel);
                    MessageBox.Show("Record Save Successfully", "Update");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }




            ClearAll();
        }

        private bool AllValidation
        {
            get
            {

                bool blnflag = true;


                if (txtChallanNo.Text.Length <= 0)
                {
                    blnflag = false;
                    MessageBox.Show("Challan Field is Empty", "Type Challan Number");
                    txtChallanNo.Select();
                    return blnflag;
                }


                if (cmbSourceFrom.Text.Length > 0)
                {
                    cmbSourceFrom.Text = cmbSourceFrom.Text;

                }


                if (cmbSourceFrom.SelectedValue == null)
                {
                    blnflag = false;
                    MessageBox.Show("Source Field is not correct", "Select Source");
                    cmbSourceFrom.Select();
                    return blnflag;
                }


                if (cmbDestinationTo.Text.Length > 0)
                {
                    cmbDestinationTo.Text = cmbDestinationTo.Text;

                }

                if (cmbDestinationTo.SelectedValue == null)
                {
                    blnflag = false;
                    MessageBox.Show("Destination Field is not correct", "Select Destination");
                    cmbDestinationTo.Select();
                    return blnflag;
                }

                if (!IsRadioButtonSelect)
                {
                    blnflag = false;
                    MessageBox.Show("Product Type Not Selectd", "Select Product Type");
                    optNewProduct.Select();
                    return blnflag;
                }




                if (dgvProductList.Rows.Count <= 0)
                {
                    blnflag = false;
                    MessageBox.Show("No product is listed in the product list", "Add Product");
                    cmbBrand.Select();
                    return blnflag;
                }


                return blnflag;
            }


        }

        private bool IsRadioButtonSelect
        {
            get
            {
                bool blnFlag = false;

                if (optNewProduct.Checked == true)
                {
                    blnFlag = true;
                    return blnFlag;
                }
                if (optRepairProduct.Checked == true)
                {
                    blnFlag = true;
                    return blnFlag;
                }


                return blnFlag;
            }
        }
        private void frmReciveProduct_Resize(object sender, EventArgs e)
        {

            dgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }



        private void dgvProductList_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                int intRowindex = dgvProductList.HitTest(e.X, e.Y).RowIndex;

                if (intRowindex == -1)
                {
                    cntxEditDelete.Enabled = false;

                }
                else
                {
                    dgvProductList.ClearSelection();
                    cntxEditDelete.Enabled = true;

                    dgvProductList.Rows[intRowindex].Selected = true;

                }
            }
            catch
            {

            }
        }

        private void cntxDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RemoveItem()
        {
            tblMasterDetails model = (tblMasterDetails)dgvProductList.SelectedRows[0].DataBoundItem;

            ListOfProduct.Remove(model);
            wireupGridview();
        }

        private void txtChallanNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtpChallanDate.Select();
            }
        }

        private void dtpChallanDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbSourceFrom.Select();
            }
        }

        private void cmbSourceFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbDestinationTo.Select();
            }
        }

        private void cmbDestinationTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbBrand.Select();
            }
        }

        private void cmbBrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbCategory.Select();
            }
        }

        private void cmbCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDescription.Select();
            }
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCode.Select();
            }
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbModel.Select();
            }
        }

        private void cmbModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSerial.Select();
            }
        }

        private void txtSerial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (lblTrType.Text.ToLower() == "Delivery".ToLower())
                {
                    SelectSerchProductList();

                }

                else
                {
                    btnAdd.Select();
                }

            }
        }

        private void txtRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSave.Select();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {


            if (dgvProductList.Rows.Count > 0)
            {
                if (MessageBox.Show("Are you sure to close", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }

            




        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are Sure to Reset. If reset then all the existing data will be lost", "Warrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClearAll();
            }
        }


        private void dgvProductList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            SerialDataGrid(dgvProductList);
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            if (lblTrType.Text.ToLower() == "Delivery".ToLower())
            {
                SearchSerialNo();
            }

        }


        private void SearchSerialNo()
        {

            dgvSearchProductList.DataSource = null;
            dgvSearchProductList.Visible = false;
            if (txtSerial.Text.Length <= 0)
            {
                return;
            }
            List<ProductDetails> PDL = new List<ProductDetails>();
            
            PDL = GlobalConfig.Idataconnection.GetProductDetails_BySerial(txtSerial.Text).ToList();
            


            if (PDL.Count > 0)
            {
                dgvSearchProductList.DataSource = PDL;
                dgvSearchProductList.Visible = true;
                dgvProductList.Location = new Point(txtSerial.Left, txtSerial.Top + txtSerial.Height);
            }


        }

        private void dgvSearchProductList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadSearchProduct();
            }
        }

        private void LoadSearchProduct()
        {

            ProductDetails pd = dgvSearchProductList.SelectedRows[0].DataBoundItem as ProductDetails;



            cmbBrand.Text = pd.Brand;
            cmbCategory.Text = pd.Category;
            txtDescription.Text = pd.ProductName;
            txtCode.Text = pd.Code;
            cmbModel.Text = pd.Model;
            txtSerial.Text = pd.Serial;
            dgvSearchProductList.DataSource = null;
            dgvSearchProductList.Visible = false;

            if (lblTrType.Text.ToLower() == "Delivery".ToLower())
            {
                txtReceiveChallan.Text = pd.ReceiveChallan;
            }





        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NSANIMATION.Animations.DragControl(this.Handle);
            }
        }

        private void lblTrType_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NSANIMATION.Animations.DragControl(this.Handle);
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if (dgvProductList.Rows.Count > 0)
            {
                if (MessageBox.Show("Are you sure to close", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }

        }

        private void txtSerial_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                SelectSerchProductList();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (txtSerial.Text.Length > 0)
                { 
                btnAdd.Select();
                    
                }
            }

        }

        private void SelectSerchProductList()
        {
            if (lblTrType.Text.ToLower() == "Delivery".ToLower())
            {
                if (dgvSearchProductList.Visible == true)
                {
                    dgvSearchProductList.Select();
                    dgvSearchProductList.ClearSelection();
                    dgvSearchProductList.Rows[0].Selected = true;
                }

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmReciveProduct_Activated(object sender, EventArgs e)
        {
      
        }

        private void frmReciveProduct_MouseUp(object sender, MouseEventArgs e)
        {
     
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.BringToFront();
        }

        private void tableLayoutPanel7_Click(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.BringToFront();
        }

        private void lblTrType_Click(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.BringToFront();
        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
