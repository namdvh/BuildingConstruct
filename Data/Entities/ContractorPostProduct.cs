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

        public int ProductID { get; set; }

        public ContractorPost ContractorPost { get; set; }

        public Products Products { get; set; }
    }
}
