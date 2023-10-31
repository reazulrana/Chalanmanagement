using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmChallan.InterfaceLibrary
{
  public  interface IUpdateChallanRequestor
    {

        void RefreshChallan(string challanno);
    }
}
