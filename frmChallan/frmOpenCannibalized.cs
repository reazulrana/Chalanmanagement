using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;
using frmChallan.InterfaceLibrary;
using BussinessLibrary.SupportLibrary;
using DataConnection;
using EnumerationLibrary;

namespace frmChallan
{
    public partial class frmOpenCannibalized : Form
    {
        public frmOpenCannibalized()
        {
            InitializeComponent();
        }

        IFormRequestor formrequestor;
        public frmOpenCannibalized(IFormRequestor requestor)
        {
            InitializeComponent();

            formrequestor = requestor;


            wireupDateGridView();
            txtModel.Select();
        }



        private void wireupDateGridView()
        {
            List<ProductDetails> ListProductDetails = GlobalConfig.Idataconnection.GetProductDetails_ByReceive();

            dgvProductList.DataSource = null;
            dgvProductList.DataSource = ListProductDetails;



         


        }
        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {

            NSANIMATION.Animations.DragControl(this.Handle);

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            LoadNewCannibalized();

            // formrequestor.DockForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlHeader_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

            FilterDataGridView();

        }

        private void FilterDataGridView()
        {


            List<ProductDetails> prdlist = GlobalConfig.Idataconnection.GetProductDetails_ByReceive().Where(x=>x.Model!=null && x.Model.ToLower().StartsWith(txtModel.Text) && x.Serial!=null && x.Serial.ToLower().StartsWith(txtSerial.Text)).ToList() ;

            dgvProductList.DataSource = null;
            dgvProductList.DataSource = prdlist;





        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridView();
        }

        private void dgvProductList_MouseUp(object sender, MouseEventArgs e)
        {
            int intRowIndex = dgvProductList.HitTest(e.X, e.Y).RowIndex;


            if (intRowIndex == -1)
            {
                cntxOpen.Enabled = false;
                cntxRead.Enabled = false;
            }
            else
            {
                dgvProductList.ClearSelection();
                dgvProductList.Rows[intRowIndex].Selected = true;
                cntxOpen.Enabled = true;
                cntxRead.Enabled = true;

            }


        }

        private void cntxOpen_Click(object sender, EventArgs e)
        {
            LoadNewCannibalized();
        }

        private void LoadNewCannibalized()
        {


            if (dgvProductList.Rows.Count <= 0)
            {
                MessageBox.Show("No Record Found in the Product List","Not Found");
                return;
            }

            if (dgvProductList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No Row Selected in the Product List","Invalid Selection");
                dgvProductList.Select();
                    return;
            }


            ProductDetails model = dgvProductList.SelectedRows[0].DataBoundItem as ProductDetails;

            model = GlobalConfig.Idataconnection.GetCannibalizad(model);



            if (formrequestor != null)
            {
                this.Close();
                formrequestor.DockCannibalized(model, SaveStatus.Save);

            }

        }




        private void LoadReadCannibalized()
        {


            if (dgvProductList.Rows.Count <= 0)
            {
                MessageBox.Show("No Record Found in the Product List", "Not Found");
                return;
            }

            if (dgvProductList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No Row Selected in the Product List", "Invalid Selection");
                dgvProductList.Select();
                return;
            }


            ProductDetails model = dgvProductList.SelectedRows[0].DataBoundItem as ProductDetails;

            model = GlobalConfig.Idataconnection.GetCannibalizad(model);



            if (formrequestor != null)
            {
                this.Close();
                formrequestor.DockCannibalized(model, SaveStatus.Read);

            }

        }


        private void dgvProductList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try {

                int intRowIndex = dgvProductList.HitTest(e.X, e.Y).RowIndex;

            if (intRowIndex != -1)
            {
                    LoadNewCannibalized();
            }
                   }
            catch
            {

            }
        }

        private void cntxRead_Click(object sender, EventArgs e)
        {
            LoadReadCannibalized();
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NSANIMATION.Animations.DragControl(this.Handle);
            }
        }

        private void pnlHeader2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NSANIMATION.Animations.DragControl(this.Handle);
            }
        }

        private void txtSerial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (dgvProductList.Rows.Count > 0)
                {

                    dgvProductList.Select();
                    dgvProductList.Rows[0].Selected = true;
                }
            }
        }

        private void dgvProductList_KeyDown(object sender, KeyEventArgs e)
        {
            LoadNewCannibalized();
        }
    }
}
