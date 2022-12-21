namespace Data.Entities
{
    public class Products
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitInStock { get; set; }

        public string? Image { get; set; }

        public string? Description { get; set; }

        public string? Brand { get; set; }

        public int SoldQuantities { get; set; }

        public int? MaterialStoreID { get; set; }

        public MaterialStore MaterialStore { get; set; }

        public List<ContractorPostProduct>? ContractorPostProducts { get; set; }

        public List<ProductCategories>? ProductCategories { get; set; }

    }
}
