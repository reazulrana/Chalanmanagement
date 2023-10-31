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
using BussinessLibrary.SupportLibrary;
using DataConnection;
using EnumerationLibrary;
//using frmRegistrationCode.Registration;
//using frmRegistrationCode;
using System.Configuration;
using LicenceExpireLibrary;
using EncriptionLibrabry;
namespace frmChallan
{
    public partial class frmMainIndex : Form, IFormRequestor //, IRegistration
    {
        public frmMainIndex()
        {
            InitializeComponent();


        }



        private void btnReceiveChallan_Click(object sender, EventArgs e)
        {
            frmReciveProduct frm = new frmReciveProduct();

            //this.pnlBody.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            this.pnlBody.Controls.Add(frm);
            frm.TopMost = true;
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void frmMainIndex_Load(object sender, EventArgs e)
        {
            try
            {




                //if (!RegistrationLibrary.RegistrationCheck.IsRegistrationComplete("MSerial"))
                //{
                //    frmRegistration frm = new frmRegistration(this);

                //    frm.ShowDialog();
                //}


                //Get Value from Appsetting
                string ed = Veri();





                if (ed != null)
                {
                  //  ed = GlobalEncription.EncriptCode.Decryption(ed);
                    if (Licences.IsLicenceExpire(ed))
                    {

                        if (GlobalConfig.Idataconnection.GetSecurity == null)
                        {
                            GlobalConfig.Idataconnection.InsertSecurity("CheckOpen");
                        }
                        GlobalConfig.Idataconnection.UpdateSecurity("Unchecked");

                    }
                  

                }



                if (GlobalConfig.Idataconnection.GetSecurity != null)
                {

                    if (GlobalConfig.Idataconnection.GetSecurity.SecurityNo.ToLower() != "CheckOpen".ToLower())
                    {
                        this.Close();

                    }

                }
          







            }





            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + " "+ ex.TargetSite,ex.Message);


            }
        }

        //Verification of Expiration Date
        private string Veri()
        {
            return ConfigurationManager.AppSettings["e"];
        }

        public void NotReturnd(List<ProductDetails> model, ReturnType returntype)
        {


            frmReceiveDetails frm = new frmReceiveDetails(model, returntype, this);

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(frm);
            frm.Show();



        }
        private void btnOpenChallan_Click(object sender, EventArgs e)
        {
            frmOpenChallan frm = new frmOpenChallan(this);
            frm.ShowDialog();
        }

        public void DockForm(tblMaster model)
        {

            frmReciveProduct frm = new frmReciveProduct(model, "Edit");



            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.txtChallanNo.Enabled = false;
            if (model.TrType.ToLower() == "delivery")
            {
                frm.dgvProductList.Columns[8].Visible = false;
            }

            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(frm);
            frm.lblTitle.Text = "Edit " + model.TrType + " Challan";
            frm.Show();

        }

        private void btnDeliveryChallan_Click(object sender, EventArgs e)
        {
            frmReciveProduct frm = new frmReciveProduct();
            frm.lblTrType.Text = "Delivery";
            frm.lblTitle.Text = "New Delivery Challan";
            frm.TopLevel = false;
            //frm.FormBorderStyle = FormBorderStyle.None;
            //  frm.dgvProductList.Columns[8].Visible = false;
            //this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.TopMost = true;
            frm.BringToFront();
            frm.Show();
        
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmBalance frm = new frmBalance(this);
            frm.ShowDialog();
        }

        public void DockForm(List<ProductDetails> model)
        {

            frmReceiveDetails frm = new frmReceiveDetails(model, ReturnType.Single, this);

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(frm);
            frm.Show();








        }


        public void DockForm(ProductDetails model)
        {

        }
        private void btnOpenCanibalized_Click(object sender, EventArgs e)
        {
            frmOpenCannibalized frm = new frmOpenCannibalized(this);
            frm.ShowDialog();
        }

        private void btnAllReceive_Click(object sender, EventArgs e)
        {

            frmReceiveDetails frm = new frmReceiveDetails(this);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            //this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(frm);
            frm.TopMost = true;
            frm.BringToFront();
            frm.Show();


        }

        public void DockCannibalized(ProductDetails model, SaveStatus state)
        {


            try
            {

                frmCannibalized frm = new frmCannibalized(model, state);


                //this.pnlBody.Controls.Clear();

                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                this.pnlBody.Controls.Add(frm);
                frm.Show();
                frm.BringToFront();

            }
            catch
            {



            }
        }

 
        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
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

        private void lblTitle_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pnlHeader_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        public void CloseApplication()
        {

            this.Close();
        }

        //public void RegistrationComplete(frmRegistration form, string ExpireDate)
        //{
        //    form.Close();

        //    string Serial = "MSerial";
        //    string exp = "ex";

        //    try
        //    {
        //        GlobalConfig.Idataconnection.InitialDatabaseRestore();
        //        GlobalConfig.Idataconnection.InsertSecurity("CheckOpen");
        //    }
        //    catch (Exception excep)
        //    {
        //        MessageBox.Show(excep.Message);
        //        return;
        //    }

        //    string ms = ConfigurationManager.AppSettings[Serial];

        //    string ex = ConfigurationManager.AppSettings[exp];




        //    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //    if (ms != null)
        //    {

        //        config.AppSettings.Settings.Remove(Serial);
        //        config.Save(ConfigurationSaveMode.Modified);

        //    }

        //    config.AppSettings.Settings.Add(Serial, NetworkLibrary.customNetworkInterface.GetHexa_Serial_Only_MAC_Numeric());
        //    config.Save(ConfigurationSaveMode.Modified);



        //    if (ex != null)
        //    {
        //        config.AppSettings.Settings.Remove(exp);
        //        config.Save(ConfigurationSaveMode.Modified);

        //    }

        //    config.AppSettings.Settings.Add(exp, ExpireDate);
        //    config.Save(ConfigurationSaveMode.Modified);

        //    ConfigurationManager.RefreshSection("appSettings");

        //    try
        //    {
        //        GlobalConfig.Idataconnection.InitialDatabaseRestore();
        //        GlobalConfig.Idataconnection.InsertSecurity("CheckOpen");
        //    }
        //    catch (Exception excep)
        //    {
        //        MessageBox.Show(excep.Message);
        //    }



        //}

        private void frmMainIndex_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
            //this.Parent = null;
            //e.Cancel = true;
        }


        private void btnnotAvailableProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show(NetworkLibrary.customNetworkInterface.GetLocalIP());

            string strEncription = EncriptionLibrabry.GlobalEncription.EncriptCode.Encryption("Rana");


            MessageBox.Show(strEncription);


            string strDecryption = EncriptionLibrabry.GlobalEncription.EncriptCode.Decryption(strEncription);


            MessageBox.Show(strDecryption);

        }

        private void btnAllCannibalized_Click(object sender, EventArgs e)
        {
            frmCannibalizedProductInformation frm = new frmCannibalizedProductInformation();

            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            //this.pnlBody.Controls.Clear();
            this.pnlBody.Controls.Add(frm);
            frm.Show();
        }

        private void mnuBackupDatabase_Click(object sender, EventArgs e)
        {
            frmBackupDatabase frm = new frmBackupDatabase();
            frm.ShowDialog();

        }

        //public void RegistrationComplete(frmRegistration form, string ExpireDate)
        //{
        //    form.Close();

        //    string Serial = "MSerial";
        //    string exp = "ex";


        //    string ms = ConfigurationManager.AppSettings[Serial];

        //    string ex = ConfigurationManager.AppSettings[exp];




        //    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //    if (ms != null)
        //    {

        //        config.AppSettings.Settings.Remove(Serial);
        //        config.Save(ConfigurationSaveMode.Modified);

        //    }

        //    config.AppSettings.Settings.Add(Serial, NetworkLibrary.customNetworkInterface.GetHexa_Serial_Only_MAC_Numeric());
        //    config.Save(ConfigurationSaveMode.Modified);



        //    if (ex != null)
        //    {
        //        config.AppSettings.Settings.Remove(exp);
        //        config.Save(ConfigurationSaveMode.Modified);

        //    }

        //    config.AppSettings.Settings.Add(exp, GlobalEncription.EncriptCode.Encryption(ExpireDate));
        //    config.Save(ConfigurationSaveMode.Modified);

        //    ConfigurationManager.RefreshSection("appSettings");

        //    try
        //    {
        //        GlobalConfig.Idataconnection.InitialDatabaseRestore();
        //        if (GlobalConfig.Idataconnection.GetSecurity == null)
        //        {
        //            GlobalConfig.Idataconnection.InsertSecurity("CheckOpen");
        //        }

        //    }
        //    catch (Exception excep)
        //    {
        //        MessageBox.Show(excep.Message);
        //    }

        //}
    }
}
