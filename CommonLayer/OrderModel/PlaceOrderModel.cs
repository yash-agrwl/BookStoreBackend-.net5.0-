using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.OrderModel
{
    public class PlaceOrderModel
    {
        public int BookID { get; set; }
        public int AddressID { get; set; }
        public int OrderQty { get; set; }
    }
}
