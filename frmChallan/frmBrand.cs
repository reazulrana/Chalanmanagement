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
using BussinessLibrary;
using DataConnection;

namespace frmChallan
{
    public partial class frmBrand : Form
    {


        IDataRequestor iBrandRequestor;

        public frmBrand()
        {
            InitializeComponent();
        }


        public frmBrand(IDataRequestor brandRequestor)
        {
            InitializeComponent();
            iBrandRequestor = brandRequestor;
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {
            loadBrand();
            txtbrand.Select();
        }

        private void loadBrand()
        {
            List<tblBrand> BrandList = GlobalConfig.Idataconnection.Brand_Get_All;

            lstBrand.DataSource = null;
            lstBrand.DisplayMember = "Brand";
            lstBrand.ValueMember = "BrandID";
            lstBrand.DataSource = BrandList;


        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbrand.Text.Length <= 0)
                {
                    MessageBox.Show("Brand is Blank", "Fill The Brand");
                    txtbrand.Select();
                    return;
                }

                tblBrand model = new tblBrand();
                model.Brand = txtbrand.Text;
                GlobalConfig.Idataconnection.CreateBrand(model);
                this.Close();
                iBrandRequestor.GetBrand();

            }
            catch (Exception ex)
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
