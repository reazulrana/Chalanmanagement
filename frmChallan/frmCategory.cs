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
    public partial class frmCategory : Form
    {


        IDataRequestor ICategoryRequestor;
        public frmCategory()
        {
            InitializeComponent();
        }


        public frmCategory(IDataRequestor CategoryRequestor)
        {
            InitializeComponent();
            ICategoryRequestor = CategoryRequestor;
        }


        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadCategory();
            txtCategory.Select();
        }

        private void LoadCategory()
        {
            List<tblCategory> CategoryList = GlobalConfig.Idataconnection.Category_Get_All;


            lstCategory.DataSource = null;
            lstCategory.DisplayMember = "Category";
            lstCategory.ValueMember = "CategoryID";
            lstCategory.DataSource = CategoryList;


        }


        private void btnSave_Click(object sender, EventArgs e)
        {


            if (txtCategory.Text.Length <= 0)
            {
                MessageBox.Show("Category Field is Blank", "Fill Category");
                txtCategory.Select();
                return;
            }



            tblCategory model = new tblCategory();
            model.Category = txtCategory.Text;
            GlobalConfig.Idataconnection.CreateCategory(model);
            this.Close();
            if (ICategoryRequestor != null)
            {
                ICategoryRequestor.GetCategory();
            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
