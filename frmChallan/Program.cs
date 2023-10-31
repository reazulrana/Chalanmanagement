using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataConnection;
using BussinessLibrary;
using EncriptionLibrabry;
namespace frmChallan
{

    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>


    
        [STAThread]

        

                static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalConfig.InitializeConnection(GlobalConfig.DatabaseType.Sql);
            GlobalEncription.InitialEnCription(EncriptionMode.MD5);
            Application.Run(new frmMainIndex());

    

        }
    }
}
