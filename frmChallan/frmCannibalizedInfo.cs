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
namespace frmChallan
{
    public partial class frmCannibalizedInfo : Form
    {




        ProductDetails pd;
        public frmCannibalizedInfo(ProductDetails p)
        {
            InitializeComponent();
            pd = p;
        }

        private void frmCannibalizedInfo_Load(object sender, EventArgs e)
        {
            if (pd != null)
            {

                txtModel.Text = pd.Model;
                txtSerial.Text = pd.Serial;
                dgvCannibalizedProductList.DataSource = pd.CannibalizedProducts;
                dgvCannibalizedProductList.ClearSelection();
            }
        }
    }
}
