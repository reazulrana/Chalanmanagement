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
    public partial class frmModel : Form
    {

        IDataRequestor IModelRequestor;
        public frmModel()
        {
            InitializeComponent();
        }

        public frmModel(IDataRequestor ModelRequestor)
        {
            InitializeComponent();
            IModelRequestor = ModelRequestor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtModel.Text.Length <= 0)
            {
                MessageBox.Show("Model Field is Blank", "Fill the Model");
                txtModel.Select();
                return;
            }


            tblModel model = new tblModel();

            model.Model = txtModel.Text;

            GlobalConfig.Idataconnection.CreateModel(model);
            this.Close();
            IModelRequestor.GetModel();

        }

        private void frmModel_Load(object sender, EventArgs e)
        {
            LoadModel();
            txtModel.Select();
        }

        private void LoadModel()
        {
            List<tblModel> ModelList = GlobalConfig.Idataconnection.Model_Get_All;

            lstModel.DataSource = null;
            lstModel.DisplayMember = "Model";
            lstModel.ValueMember = "ModelID";
            lstModel.DataSource = ModelList;

                    }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
