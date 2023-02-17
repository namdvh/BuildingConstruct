namespace Data.Entities
{
    public class ProductType
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Products Products { get; set; }

        public int ProductID { get; set; }
        public BillDetail? BillDetails { get; set; }


        public int Quantity { get; set; }


        public List<Cart>? Carts { get; set; }
    }
}
