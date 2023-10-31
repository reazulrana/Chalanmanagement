using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLibrary
{
  public  class tblMaster
    {
        public int MID { get; set; }
        public string ChallanNo { get; set; }
        public DateTime TrDate { get; set; }
        public string TrType { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string ReceiveCondition { get; set; }
        public string Remarks { get; set; }

        public List<tblMasterDetails> ProductList;
        

    }
}
