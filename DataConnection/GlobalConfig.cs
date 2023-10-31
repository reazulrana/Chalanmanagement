using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace DataConnection
{
    public static class GlobalConfig
    {

        public enum DatabaseType
        {
            Sql,
            Access
        }


        public static IDataConnection Idataconnection { get; set; }




        public static void InitializeConnection(DatabaseType dbtype)
        {

            //string s = ConfigurationManager.AppSettings["e"];


            //string td = "31-07-" + s;
            //DateTime t =Convert.ToDateTime(td);
            //if (DateTime.Now.Date > t)
            //{
            //    return;
            //}


            if (dbtype == DatabaseType.Sql)
            {
                Idataconnection = new SQLConnection();
            }
        }


    }
}
