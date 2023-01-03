using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ContractorPostProduct
    {
        public int ContractorPostID { get; set; }

        public int ProductSystemID { get; set; }
        public int Quantity { get; set; }

        public ContractorPost ContractorPost { get; set; }

        public ProductSystem ProductSystem { get; set; }
    }
}
