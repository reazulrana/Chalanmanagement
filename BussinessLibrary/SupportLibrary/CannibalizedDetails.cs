using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLibrary.SupportLibrary
{
    public class CannibalizedDetails
    {


        private DateTime? _ReceiveDate;

        public string ChallanNo { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
        public string Code { get; set; }

        public string ReceivedDate
        {
            get
            {

                string receivedate = "";
                foreach (tblCannibalized tb in ListCannibalized)
                {
                    receivedate += tb.ReceivedDate.Value.ToString("dd-MM-yy") + "; ";
                }


                if (receivedate.Length >= 2)
                {
                    receivedate = receivedate.Substring(0, receivedate.Length - 2);
                }

                return receivedate;
            }
        }
        public string ProductName
        {
            get
            {
                string productname = "";
                foreach (tblCannibalized tb in ListCannibalized)
                {
                    productname += tb.ProductName + "; ";
                }

                if (productname.Length >= 2)
                {
                    productname = productname.Substring(0, productname.Length - 2);
                }

                return productname;

            }
        }
        public string PartNo
        {
            get
            {
                string partno = "";
                foreach (tblCannibalized tb in ListCannibalized)
                {
                    if (tb.PartNo != null && tb.PartNo.Length!=0)
                    {
                        partno += tb.PartNo + "; ";
                    }
                }


                if (partno.Length >= 2)
                {
                    partno = partno.Substring(0, partno.Length - 2);
                }


                return partno;
            }
        }
        public string Branch
        {
            get
            {
                string branch = "";
                foreach (tblCannibalized tb in ListCannibalized)
                {
                    branch += tb.Branch + "; ";
                }


                if (branch.Length >= 2)
                {
                    branch = branch.Substring(0, branch.Length - 2);
                }


                return branch;

            }
        }
        public string JobCode
        {
            get
            {
                string jobcode = "";
                foreach (tblCannibalized tb in ListCannibalized)
                {
                    jobcode += tb.JobCode + "; ";
                }

                if (jobcode.Length >= 2)
                {
                    jobcode = jobcode.Substring(0, jobcode.Length - 2);
                }


                return jobcode;

            }
        }
        public string Status
        {
            get
            {
                string strstatus = "";

                foreach (tblCannibalized tb in ListCannibalized)
                {
                    strstatus += tb.Status + ",";
                }

                if (strstatus.Length >= 1)
                {
                    strstatus = strstatus.Substring(0,strstatus.Length - 1);
                }


                return strstatus;
            }
        }
        public string OrderQty { get {
                string strOrderqty= "";

                foreach (tblCannibalized tb in ListCannibalized)
                {
                    strOrderqty += tb.OrderQty + ",";
                }

                if (strOrderqty.Length >= 1)
                {
                    strOrderqty = strOrderqty.Substring(0, strOrderqty.Length - 1);
                }


                return strOrderqty;
            } }
        public string OrderDate { get
            {
                string strOrderDate = "";

                foreach (tblCannibalized tb in ListCannibalized)
                {
                    strOrderDate += tb.OrderDate.Value.ToString("dd-MM-yy") + ",";
                }

                if (strOrderDate.Length >= 1)
                {
                    strOrderDate = strOrderDate.Substring(0, strOrderDate.Length - 1);
                }


                return strOrderDate;
            } }
        
        public string Accessories
        {
            get
            {
                string strAccessories = "";
                

                foreach (tblCannibalized tb in ListCannibalized)
                {
                    strAccessories += tb.Accessories + ",";
                }

                if (strAccessories.Length >= 1)
                {
                    strAccessories = strAccessories.Substring(0, strAccessories.Length - 1);
                }


                return strAccessories;
            }
        }
        public List<tblCannibalized> ListCannibalized { get; set; } = new List<tblCannibalized>();
        
    }
}
