using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace NetworkLibrary
{
    public static class customNetworkInterface
    {




        public static string GetLocalIP()
        {
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());

            string ipaddress = "";
            foreach (IPAddress ip in ipHost.AddressList)
            {

                if (ip.AddressFamily.ToString().ToLower() == "InterNetwork".ToLower())
                {
                    ipaddress = ip.ToString();
                }
            
            }
            return ipaddress;
        }

        public static string GetMACAddress()
        {
            NetworkInterface[] nic = NetworkInterface.GetAllNetworkInterfaces();

            string serial = nic[0].GetPhysicalAddress().ToString();

            if (serial == "")
            {
                serial = "123456";
            }

            return serial;

        }



        public static string GetHexa_Serial_Only_MAC_Numeric()
        {
            //
            return GetMACAddressNumber(GetMACAddress());
            
        }



        public static string GetMACAddressNumber(string Mac)
        {
            string strdigit = "";
            foreach (char chr in Mac)
            {

                if (Char.IsDigit(chr))
                {
                    strdigit += ((int)chr).ToString("X");
                }

            }


            if (strdigit.Length >= 12)
            {

                strdigit = Get_Twelve_Digit(strdigit);


            }

            if (strdigit.Length == 11)
            {
                strdigit = Get_Eleven_Digit(strdigit);
            }


            if (strdigit.Length == 10)
            {
                strdigit = Get_Ten_Digit(strdigit);
            }

            if (strdigit.Length == 9)
            {
                strdigit = Get_Nine_Digit(strdigit);
            }

            if (strdigit.Length == 8)
            {
                strdigit = Get_Eight_Digit(strdigit);
            }



            if (strdigit.Length == 7)
            {
                strdigit = Get_Seven_Digit(strdigit);
            }


            if (strdigit.Length == 6)
            {
                strdigit = Get_Six_Digit(strdigit);
            }



            if (strdigit.Length == 5)
            {
                strdigit = Get_Five_Digit(strdigit);
            }




            return strdigit;
        }




        static string Get_Twelve_Digit(string value)
        {


            string str1 = value.Substring(0, 3);
            string str2 = value.Substring(3, 3);
            string str3 = value.Substring(6, 3);
            string str4 = value.Substring(9, 3);

            value = str1 + "-" + str2 + "-" + str3 + "-" + str4;

            return value;
        }


        static string Get_Eleven_Digit(string value)
        {


            string str1 = value.Substring(0, 3);
            string str2 = value.Substring(3, 3);
            string str3 = value.Substring(6, 3);
            string str4 = value.Substring(9, 2);

            value = str1 + "-" + str2 + "-" + str3 + "-" + str4;

            return value;
        }
        static string Get_Ten_Digit(string value)
        {


            string str1 = value.Substring(0, 3);
            string str2 = value.Substring(3, 3);
            string str3 = value.Substring(6, 4);


            value = str1 + "-" + str2 + "-" + str3;

            return value;
        }


        static string Get_Nine_Digit(string value)
        {


            string str1 = value.Substring(0, 3);
            string str2 = value.Substring(3, 3);
            string str3 = value.Substring(6, 3);


            value = str1 + "-" + str2 + "-" + str3;

            return value;
        }


        static string Get_Eight_Digit(string value)
        {


            string str1 = value.Substring(0, 3);
            string str2 = value.Substring(3, 3);
            string str3 = value.Substring(6, 2);


            value = str1 + "-" + str2 + "-" + str3;

            return value;
        }


        static string Get_Seven_Digit(string value)
        {


            string str1 = value.Substring(0, 3);
            string str2 = value.Substring(3, 4);



            value = str1 + "-" + str2;

            return value;
        }


        static string Get_Six_Digit(string value)
        {


            string str1 = value.Substring(0, 3);
            string str2 = value.Substring(3, 3);



            value = str1 + "-" + str2;

            return value;
        }


        static string Get_Five_Digit(string value)
        {


            string str1 = value.Substring(0, 3);
            string str2 = value.Substring(3, 2);



            value = str1 + "-" + str2;

            return value;
        }



    }
}
