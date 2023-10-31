using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenceExpireLibrary
{
public  static   class Licences
    {

        

        [Obsolete("Input Expire Date in to the parameter")]


        

        public static bool IsLicenceExpire(string ExpireDate)
        {


            bool blnFlag = false;


            DateTime expDate = Convert.ToDateTime("01-Jul-" +ExpireDate);



            if (DateTime.Now.Date > expDate)
            {

                blnFlag = true;

             
            }
            
            return blnFlag;
            
        }

    }
}
