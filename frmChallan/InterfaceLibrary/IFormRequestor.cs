using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLibrary;
using BussinessLibrary.SupportLibrary;
using EnumerationLibrary;
namespace frmChallan.InterfaceLibrary
{
 public   interface IFormRequestor
    {
        void DockForm(tblMaster model);
        void DockForm(List<ProductDetails> model);
        void NotReturnd(List<ProductDetails> model,ReturnType returntype);
        void DockForm(ProductDetails model);
        void DockCannibalized(ProductDetails model, SaveStatus state);

    }
}
