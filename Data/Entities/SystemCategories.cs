using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class SystemCategories
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Enum.TypeEnum Type { get; set; }
        [JsonIgnore]
        public List<ProductSystemCategories> ProductSystemCategories { get; set; }
    }
}
