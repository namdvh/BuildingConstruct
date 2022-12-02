namespace Data.Entities
{
    public class MaterialStore
    {
        public int Id { get; set; }

        public string? Webstie { get; set; }

        public string? Description { get; set; }

        public string? TaxCode { get; set; }

        public string? Experience { get; set; }

        public string? Image { get; set; }

        public User User { get; set; }
    }
}