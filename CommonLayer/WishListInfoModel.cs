namespace CommonLayer
{
    public class WishListInfoModel
    {
        public int WishListID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public BookInfoModel BookData { get; set; }
    }
}
