using CommonLayer.BookModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.OrderModel
{
    public class OrderInfoModel
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public BookInfoModel BookData { get; set; }
        public int AddressId { get; set; }
        public int OrderQty { get; set; }
        public float TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
