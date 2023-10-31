using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmChallan.InterfaceLibrary
{
   public interface IDataRequestor
    {
        void GetBranch();
        void GetBrand();
        void GetCategory();
        void GetModel();

    }
}
