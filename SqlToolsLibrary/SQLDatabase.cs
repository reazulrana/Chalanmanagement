using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace SqlToolsLibrary
{
    public static class SQLDatabase
    {
        static string ConString = "";


        public static void BackupDatabase(string Destination, string CheckIsOpenConnectionString)
        {

            ConString = CheckIsOpenConnectionString;
            string dbName = "";
            string BackUpName = "";


            foreach (char c in Destination)
            {
                if (c == Convert.ToChar("'"))
                {
                    MessageBox.Show("You have to remove this character from Destination Folder Name (')");
                    return;
                }
            }


            using (SqlConnection con = NewSqlConnection)
            {
                dbName = con.Database;

                if (!isDatabaseExists)
                {

                    MessageBox.Show("Database is not exists to the server (" + dbName + ")", "File Not Found");
                    return;
                }


                try
                {





                    BackUpName = dbName + "_Backup.bak";

                    string checkFileExists = Destination + @"\" + BackUpName;
                    string strBackup = "Backup Database " + dbName + " To Disk ='" + Destination + @"\" + BackUpName + "'";

                    if (File.Exists(checkFileExists))
                    {

                        if (MessageBox.Show("File (" + BackUpName + ") is found to the folder; Do want to overwrite", "File Duplication", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        {
                            return;
                        }

                        File.Delete(checkFileExists);
                    }

                    using (SqlCommand com = new SqlCommand(strBackup, con))
                    {

                        com.CommandType = CommandType.Text;
                        con.Open();
                        com.ExecuteNonQuery();
                        MessageBox.Show("Database Back up Sucessfully");
                    }
                }
                catch
                {
                    throw new Exception();
                }
            }




        }




        public static void RestoreDatabase(string filename, string CheckIsOpenConnectionString)
        {

            string dbName = "";
            string BackUpName = "";
            string connection = ConfigurationManager.ConnectionStrings["DBMaster"].ConnectionString;

            ConString = CheckIsOpenConnectionString;


            using (SqlConnection cons = NewSqlConnection)
            {
                dbName = cons.Database;
            }

            using (SqlConnection con = new SqlConnection(connection))
            {


                if (isDatabaseExists)
                {

                    MessageBox.Show("Database is exists to the server (" + dbName + ")", "File is found");
                    return;
                }


                try
                {

                    using (SqlCommand com = new SqlCommand())
                    {

                        com.Connection = con;


                        string strBackup = "Restore Database " + dbName + " from Disk ='" + filename + "'";
                        com.CommandText = strBackup;
                        com.CommandType = CommandType.Text;
                        con.Open();
                        com.ExecuteNonQuery();
                        MessageBox.Show("Database Restored Sucessfully");
                    }
                }
                catch
                {
                    throw new Exception();
                }
            }




        }







        public static void RestoreDatabaseFirstTime(string filename, string CheckIsOpenConnectionString)
        {

            string dbName = "";
            string BackUpName = "";
            string connection = ConfigurationManager.ConnectionStrings["DBMaster"].ConnectionString;

            ConString = CheckIsOpenConnectionString;


            using (SqlConnection cons = NewSqlConnection)
            {
                dbName = cons.Database;
            }

            using (SqlConnection con = new SqlConnection(connection))
            {
                                                
                try
                {

                    using (SqlCommand com = new SqlCommand())
                    {

                        com.Connection = con;


                        string strBackup = "Restore Database " + dbName + " from Disk ='" + filename + "'";
                        com.CommandText = strBackup;
                        com.CommandType = CommandType.Text;
                        con.Open();
                        com.ExecuteNonQuery();
                 
                    }
                }
                catch
                {
                    throw new Exception();
                }
            }




        }


        static bool isDatabaseExists // Check Database Exist
        {
            get
            {
                bool blnFlag = true;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    try
                    {


                        con.Open();


                    }
                    catch
                    {
                        blnFlag = false;
                    }
                }

                return blnFlag;
            }
        }

        private static SqlConnection NewSqlConnection
        {
            get
            {

                return new SqlConnection(ConString);
            }
        }
    }
}
