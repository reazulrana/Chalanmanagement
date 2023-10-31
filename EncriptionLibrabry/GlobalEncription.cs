using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncriptionLibrabry
{


  public  enum EncriptionMode
    {
        MD5,
        Hash

    }
    public static class GlobalEncription
    {

        public static IEncription EncriptCode { get; private set; }

        public static void InitialEnCription(EncriptionMode EMode)
        {
            if (EMode == EncriptionMode.MD5)
            {
                EncriptCode = new EncriptionMD5();
            }
        }

    }
}
