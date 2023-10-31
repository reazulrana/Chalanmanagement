using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLibrary.SupportLibrary
{
    public class ProductDetails
    {
        ////Main.Model,
        //Main.Serial,
        //main.[Receive] as ReceiveDate,
        //Main.Delivery as DeliveryDate,
        //Main.[Source],
        //Main.Destination,
        //Main.ReceiveCondition as condition,
        //Main.Remarks


        public string ReceiveChallan { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string ProductName { get; set; }
        public string Code { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryChallan { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string Condition { get; set; }
        public string Remarks { get; set; }
        public string NonReturn { get; set; }
        public string NRReason { get; set; }
        private string _branch;
        private string _JobCode;
        public List<tblCannibalized> CannibalizedProducts = new List<tblCannibalized>();


        public string ProductReturn
        {
            get
            {

                if (DeliveryDate != null)
                {

                    return "Return Completed";
                }
                else if (NonReturn != null)
                {
                    return NonReturn;
                }
                else
                {
                    return "Returnable";
                }
            }
        }
        public string Branch
        {
            get
            {
                return _branch;
            }
            set
            {
                _branch = value;
            }


        }

        public string JobCode
        {
            get
            {
                return _JobCode;
            }
            set
            {
                _JobCode = value;
            }

        }
        public string TotalCannibalized
        {
            get
            {

                string strCanQty = "";

                //if (CannibalizedProducts.Count > 0)
                //{
                //    strCanQty = CannibalizedProducts.Count.ToString();
                //}

                //return strCanQty;

                foreach (tblCannibalized tb in CannibalizedProducts)
                {

                    strCanQty += tb.ProductName + ",";

                 
                }

                if (strCanQty.Length > 1)
                {
                    strCanQty = strCanQty.Substring(0, strCanQty.Length - 1);
                }
                
                return strCanQty;
            }
        }

      

       

      

    }
}
