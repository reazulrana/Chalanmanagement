using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLibrary.SupportLibrary;
using DataConnection;
using frmChallan.InterfaceLibrary;
using EnumerationLibrary;

namespace frmChallan
{
    public partial class frmBalance : Form
    {
        public frmBalance()
        {
            InitializeComponent();
        }

        public IFormRequestor formrequetor;
        public frmBalance(IFormRequestor requestor)
        {
            InitializeComponent();
            formrequetor = requestor;

        }

        private void frmBalance_Load(object sender, EventArgs e)
        {
            wireupDataGridView();
            WireupBrandCategory();
        }



        private void SumBalance()
        {
            lblBalanceTotal.Text = "0";
            if (dgvProductBlance.Rows.Count <= 0)
            {
                return;
            }
            if (dgvProductBlance.DataSource == null)
            {
                return;
            }

            List<ProductBalance> ListBalance = dgvProductBlance.DataSource as List<ProductBalance>;

            double balance = 0;
            foreach (ProductBalance p in ListBalance)
            {
                balance += p.Stock;

            }


            lblBalanceTotal.Text = balance.ToString();




        }


        void WireupBrandCategory()
        {
            cmbBrand.DataSource = null;
            cmbBrand.DisplayMember = "Brand";
            cmbBrand.ValueMember = "BrandID";
            cmbBrand.DataSource = GlobalConfig.Idataconnection.Brand_Get_All;
            cmbBrand.SelectedIndex = -1;


            cmbCategory.DataSource = null;
            cmbCategory.DisplayMember = "Category";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DataSource = GlobalConfig.Idataconnection.Category_Get_All;
            cmbCategory.SelectedIndex = -1;



        }

        private void wireupDataGridView()
        {
            try
            {
                List<ProductBalance> ProductBlanceList = GlobalConfig.Idataconnection.GetProductBalance;
                dgvProductBlance.DataSource = null;

                dgvProductBlance.DataSource = ProductBlanceList;

                double dblReceiveQty = 0;
                double dblDeliveryQty = 0;
                double dblStockInHand = 0;

                foreach (ProductBalance pd in ProductBlanceList)
                {

                    dblReceiveQty += pd.Received;
                    dblDeliveryQty += pd.Delivered;
                    dblStockInHand += pd.Stock;


                }

                lblTotalReceive.Text = dblReceiveQty.ToString();
                lblTotalDelivery.Text = dblDeliveryQty.ToString();
                lblStockInhand.Text = dblStockInHand.ToString();
                SumBalance(); // Sum Balance Column for all Model
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void dgvProductBlance_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {



            LoadSerial();



        }



        private void LoadSerial()
        {


            foreach (DataGridViewRow row in dgvProductBlance.Rows)
            {


                dgvProductBlance.Rows[row.Index].HeaderCell.Value = string.Format("{0}", row.Index + 1);




            }
        }

        private void dgvProductBlance_MouseUp(object sender, MouseEventArgs e)
        {
            int introwindex = dgvProductBlance.HitTest(e.X, e.Y).RowIndex;


            if (introwindex == -1)
            {
                cntxReceiveDetails.Enabled = false;
                cntxDeliveryDetails.Enabled = false;

            }
            else
            {
                cntxReceiveDetails.Enabled = true;
                cntxDeliveryDetails.Enabled = true;

                dgvProductBlance.ClearSelection();
                dgvProductBlance.Rows[introwindex].Selected = true;

            }
        }

        private void cntxReceiveDetails_Click(object sender, EventArgs e)
        {


            LoadProduct();


        }

        private void LoadProduct()
        {
            ProductBalance pb = dgvProductBlance.SelectedRows[0].DataBoundItem as ProductBalance;

            // Get All Model Details;
            List<ProductDetails> PDL = GlobalConfig.Idataconnection.GetProductDetails_ByReceive(pb.Model);

            try
            {
                if (formrequetor != null)
                {
                    formrequetor.DockForm(PDL);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductBlance_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int introwindex = dgvProductBlance.HitTest(e.X, e.Y).RowIndex;

            if (introwindex != -1)
            {
                LoadProduct();
            }

        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void lblTitle_MouseUp(object sender, MouseEventArgs e)
        {
            NSANIMATION.Animations.DragControl(Handle);
        }

        private void lblStockInhand_Click(object sender, EventArgs e)
        {
            List<ProductDetails> prd = GlobalConfig.Idataconnection.GetProductDetails_ByReceive().Where(x => x.DeliveryDate == null).ToList();

            if (formrequetor != null)
            {
                this.Close();
                formrequetor.NotReturnd(prd, ReturnType.Many);

            }

        }

        private void lblTotalDelivery_Click(object sender, EventArgs e)
        {
            loadDeliveryProduct();
        }

        private void loadDeliveryProduct()
        {
            List<ProductDetails> prd = GlobalConfig.Idataconnection.GetProductDetails_ByReceive().Where(x => x.DeliveryDate != null).ToList();

            if (formrequetor != null)
            {
                this.Close();
                formrequetor.NotReturnd(prd, ReturnType.Many);

            }
        }

        private void lblTotalReceive_Click(object sender, EventArgs e)
        {
            List<ProductDetails> prd = GlobalConfig.Idataconnection.GetProductDetails_ByReceive().OrderBy(x => x.Model).OrderBy(x => x.ReceiveDate).ToList();

            if (formrequetor != null)
            {
                this.Close();
                formrequetor.NotReturnd(prd, ReturnType.Many);

            }
        }

        private void cntxDeliveryDetails_Click(object sender, EventArgs e)
        {


            try
            {
                ProductBalance pb = dgvProductBlance.SelectedRows[0].DataBoundItem as ProductBalance;

                // Get All Model Details;
                List<ProductDetails> PDL = GlobalConfig.Idataconnection.GetProductDetails_ByReceive(pb.Model).Where(x => x.DeliveryDate != null).ToList();
                if (PDL.Count > 0)
                {
                    if (formrequetor != null)
                    {
                        formrequetor.DockForm(PDL);
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("This product is '(0)' QTY deliverd", "invalid");
                    return;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
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

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NSANIMATION.Animations.DragControl(this.Handle);
            }
        }

        private void optAll_CheckedChanged(object sender, EventArgs e)
        {
            DisableCombobox();
        }
        void DisableCombobox()
        {
            cmbBrand.Enabled = false;
            cmbCategory.Enabled = false;

        }
        void EnableCombobox()
        {
            cmbBrand.Enabled = true;
            cmbCategory.Enabled = true;

        }

        private void optDate_CheckedChanged(object sender, EventArgs e)
        {
            EnableCombobox();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (optAll.Checked == true)
            {
                wireupDataGridView();
            }
            else if (optDate.Checked == true)
            {
                FilterBlance();
            }
        }

        void FilterBlance()
        {
            try
            {
                if (cmbBrand.Text.Length <= 0)
                {
                    cmbBrand.Text = "";
                }

                if (cmbCategory.Text.Length <= 0)
                {
                    cmbCategory.Text = "";
                }

                ProductDetails p = new ProductDetails();
                if (cmbBrand.SelectedValue != null)
                {
                    p.Brand = cmbBrand.Text;
                }

                if (cmbCategory.SelectedValue != null)
                {
                    p.Category = cmbCategory.Text;
                }


                dgvProductBlance.DataSource = null;
                dgvProductBlance.DataSource = GlobalConfig.Idataconnection.GetProductBalancebyFilter(p);
                SumBalance(); // Sum Balance Column for all Model
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lnkExport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(GlobalConfig.Idataconnection.isEx == true) { 
            NSMSOFFICE.ExcelInformation.ExportGridView(dgvProductBlance, dgvProductBlance.Columns.Count, 8000);
            }
            else
            {
                NSMSOFFICE.ExcelInformation.ExportGridView(dgvProductBlance, dgvProductBlance.Columns.Count, dgvProductBlance.Rows.Count);
            }
        }
    }
}
