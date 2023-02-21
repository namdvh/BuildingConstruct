using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class Cart
    {
        public int Id { get; set; } 

        public Guid UserID { get; set; }

        public int ProductID { get; set; }

        public int? TypeID { get; set; }

        public User User { get; set; }

        public Products Products { get; set; }

        public int Quantity { get; set; }

        public ProductType? ProductType { get; set; }

        public DateTime LastModifiedAt { get; set; } = DateTime.Now;

    }
}
