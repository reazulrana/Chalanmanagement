using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataConnection
{
   static class HelperConnection
    {

        public static string GetConnection(string ConnectionName)
        {
            return ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;
        }
    }
}
