using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLibrary.SupportLibrary
{
   public class ProductBalance
    {
        public string Model { get; set; }
        public int Received { get; set; }
        public int Delivered { get; set; }
        public int Stock { get { return Received - Delivered; } }



    }
}
