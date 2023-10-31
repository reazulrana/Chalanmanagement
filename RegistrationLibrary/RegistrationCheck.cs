using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkLibrary;
using System.Configuration;
using RegistrationLibrary;
namespace RegistrationLibrary
{

    public static class RegistrationCheck
    {




        private static string _IsRegistrationComplete;

        [Obsolete("Enter Key Name For appSetting into the input parameter")]
        public static bool IsRegistrationComplete(string strValue)
        {
            bool blnValidate = false;
            string cs = ConfigurationManager.AppSettings[strValue];


            if (cs == null)
            {
                blnValidate = false;
                return blnValidate;
            }



            string serialkey = NetworkLibrary.customNetworkInterface.GetHexa_Serial_Only_MAC_Numeric();

            if (cs == serialkey)
            {
                blnValidate = true;
            }


                      




            return blnValidate;
        }




        public static bool CheckSerialValidation(string InputVaue)
        {
            bool blnFlag = false;

            string CheckSerial = InputVaue;
            string serial = NetworkLibrary.customNetworkInterface.GetHexa_Serial_Only_MAC_Numeric();
            if (CheckSerial == serial)
            {

                blnFlag = true;
            }

            return blnFlag;
        }



    }
}
