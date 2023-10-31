using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLibrary
{
   public class tblCannibalized
    {
        public int CanID { get; set; }
        public string ChallanNo { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
        public string Code { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string ProductName { get; set; }
        public string PartNo { get; set; }
        public string Branch { get; set; }
        public string JobCode { get; set; }
        public string Status { get; set; }
        public decimal OrderQty { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Accessories { get; set; }
    }
}
