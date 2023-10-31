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
using BussinessLibrary;
using DataConnection;
using frmChallan.Report;
using System.Configuration;

namespace frmChallan
{
    public partial class frmCannibalizedProductInformation : Form
    {
        public frmCannibalizedProductInformation()
        {
            InitializeComponent();
        }

        private void frmCannibalizedProductInformation_Load(object sender, EventArgs e)
        {
            DisableDate();
            LoadInitialData();
            LoadCannibalizedDetails();
            LoadBrandCategory();
        }
        void LoadBrandCategory()
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

        void LoadInitialData()
        {
            dgvCannibalizedInformation.DataBindings.Clear();
            dgvCannibalizedInformation.Refresh();
            dgvCannibalizedInformation.DataSource = null;
            ProductDetails p = new ProductDetails();
            dgvCannibalizedInformation.DataSource = GlobalConfig.Idataconnection.Cannibalized_Product_Summery_All(p);
            dgvCannibalizedInformation.Columns[4].HeaderText = "Location";
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {





            LoadDate();
        }

        private void optAll_CheckedChanged(object sender, EventArgs e)
        {
            DisableDate();
        }

        private void EnableDate()
        {
            dtpStartDate.Enabled = true;
            dtpTo.Enabled = true;
        }

        private void DisableDate()
        {

            dtpStartDate.Enabled = false;
            dtpTo.Enabled = false;
        }

        private void optDate_CheckedChanged(object sender, EventArgs e)
        {
            EnableDate();
        }

        private void LoadDate()
        {
            if (optDetails.Checked == true)
            {
                LoadCannibalizedDetails();
            }
            else
            {
                LoadCannibalizedSummery();
            }
        }

        private void LoadCannibalizedSummery()
        {
            dgvCannibalizedInformation.DataSource = null;

            TimeSpan ts = dtpTo.Value.Subtract(dtpStartDate.Value);


            double CountDay = ts.TotalDays;

            if (CountDay <= -1)
            {
                MessageBox.Show("Second Date is Smaller Than First Date");
                return;
            }








            ProductDetails p = new ProductDetails();


            if (cmbBrand.Text.Length <= 0)
            {
                cmbBrand.Text = "";
            }

            if (cmbCategory.Text.Length <= 0)
            {
                cmbCategory.Text = "";
            }

            if (cmbBrand.SelectedValue == null)
            {
                cmbBrand.Text = "";
            }
            if (cmbCategory.SelectedValue == null)
            {
                cmbCategory.Text = "";
            }




            if (cmbBrand.SelectedValue !=null)
            {
                p.Brand = cmbBrand.Text;
            }

            if (cmbCategory.SelectedValue != null)
            {
                p.Category = cmbCategory.Text;
            }



            if (optAll.Checked == true)
            {
                dgvCannibalizedInformation.DataSource = GlobalConfig.Idataconnection.Cannibalized_Product_Summery_All(p);
                dgvCannibalizedInformation.Columns[3].HeaderText = "Location";
            }
            else
            {
                dgvCannibalizedInformation.DataSource = GlobalConfig.Idataconnection.Cannibalized_Product_Summery_By_Date(dtpStartDate.Value.ToString("yyyy-MMM-dd"), dtpTo.Value.ToString("yyyy-MMM-dd"),p);
                dgvCannibalizedInformation.Columns[3].HeaderText = "Location";

            }


            //if (dgvCannibalizedInformation.Columns.Count > 0)
            //{
            //    dgvCannibalizedInformation.Columns[4].Visible = false;
            //}
        }

        void LoadCannibalizedDetails()
        {
            dgvCannibalizedInformation.DataSource = null;
            TimeSpan ts = dtpTo.Value.Subtract(dtpStartDate.Value);


            double CountDay = ts.TotalDays;



            ProductDetails p = new ProductDetails();

            if (cmbBrand.SelectedValue != null)
            {
                p.Brand = cmbBrand.Text;
            }

            if (cmbCategory.SelectedValue != null)
            {
                p.Category = cmbCategory.Text;
            }



            if (CountDay <= -1)
            {
                MessageBox.Show("Second Date is Smaller Than First Date");
                return;
            }

            if (optAll.Checked == true)
            {
                dgvCannibalizedInformation.DataSource = GlobalConfig.Idataconnection.Cannibalized_Product_All(p);
            }
            else
            {
                dgvCannibalizedInformation.DataSource = GlobalConfig.Idataconnection.Cannibalized_Product_ReceiveDate(dtpStartDate.Value.ToString("yyyy-MMM-dd"), dtpTo.Value.ToString("yyyy-MMM-dd"),p);

            }

            if (dgvCannibalizedInformation.Columns.Count > 0)
            {
                dgvCannibalizedInformation.Columns[0].Visible = false;
                dgvCannibalizedInformation.Columns[4].HeaderText = "Location";
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {


            if (GlobalConfig.Idataconnection.isEx == true)
            {
                NSMSOFFICE.ExcelInformation.ExportGridView(dgvCannibalizedInformation, dgvCannibalizedInformation.Columns.Count,8000);
            }
            else
            {
                NSMSOFFICE.ExcelInformation.ExportGridView(dgvCannibalizedInformation, dgvCannibalizedInformation.Columns.Count, dgvCannibalizedInformation.Rows.Count);
            }
           
        }

        private void lnkReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (optSummery.Checked == true)
            {

              List<CannibalizedDetails> details = dgvCannibalizedInformation.DataSource as List<CannibalizedDetails>;





                string strBrand = "";
                string strCategory = "";

                string strDate = "";

                if (cmbBrand.SelectedValue != null)
                {
                    strBrand = cmbBrand.Text;
                }
                else
                {
                    strBrand ="All";
                }

                if (cmbCategory.SelectedValue != null)
                {
                    strCategory = cmbCategory.Text;
                }
                else
                {
                    strCategory = "All";
                }

                if (optAll.Checked == true)
                {
                    strDate = "All";
                }
                else
                {
                    strDate = dtpStartDate.Value.ToShortDateString().ToString() + " To " + dtpTo.Value.ToShortDateString().ToString();
                }




                Report.frmReport frm = new Report.frmReport(details, strBrand, strCategory, strDate);
                frm.ShowDialog();

                //frm.ShowDialog();

            }
        }

        private void optDetails_CheckedChanged(object sender, EventArgs e)
        {
            lnkReport.Enabled = false;
        }

        private void optSummery_CheckedChanged(object sender, EventArgs e)
        {
            lnkReport.Enabled = true;
        }

        private void dgvCannibalizedInformation_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SerialDataGrid(dgvCannibalizedInformation);
        }

        private void SerialDataGrid(DataGridView grid)
        {


            foreach (DataGridViewRow row in grid.Rows)
            {


                grid.Rows[row.Index].HeaderCell.Value = string.Format("{0}", row.Index + 1).ToString();
                            }

        }
    }
}
