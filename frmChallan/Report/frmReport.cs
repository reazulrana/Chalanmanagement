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
using Microsoft.Reporting.WinForms;
namespace frmChallan.Report
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }


        List<CannibalizedDetails> CanDetails;
        string BN = "";
        string Cn = "";
        string DTR = "";
        public frmReport(List<CannibalizedDetails> CannReport, string brand, string category,string DateRange)
        {
            InitializeComponent();
            CanDetails = CannReport;
            BN = brand;
            Cn = category;
            DTR = DateRange;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

            try
            {
                //CannibalizedDetailsBindingSource.DataSource = CanDetails;

                ReportDataSource rds = new ReportDataSource("Cannibalized", CanDetails);


                rdlcReportViewer.LocalReport.DataSources.Clear();
                
                ReportParameter[] rparam = new ReportParameter[]
                {
                    new ReportParameter("Brand",BN.ToString()),
                    new ReportParameter("Category",Cn.ToString()),
                    new ReportParameter("Date",DTR.ToString()),

                    };

                rdlcReportViewer.LocalReport.SetParameters(rparam);
                rdlcReportViewer.LocalReport.DataSources.Add(rds);

                this.rdlcReportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
