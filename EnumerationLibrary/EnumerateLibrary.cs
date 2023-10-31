using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationLibrary
{
 


    public enum SaveStatus
    {
        Save,
        Update,
        Delete,
        Read
    }

    public enum ProductStatus
    {
        Receive,
        Repair,
        Delivery
    }

    public enum ReturnType
    {
        Single,
        Many
    }


}
