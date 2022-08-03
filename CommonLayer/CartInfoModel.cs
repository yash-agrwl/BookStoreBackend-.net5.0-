using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public class CartInfoModel
    {
        public int CartID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public BookInfoModel BookData { get; set; }
        public int BookCount { get; set; }
    }
}
