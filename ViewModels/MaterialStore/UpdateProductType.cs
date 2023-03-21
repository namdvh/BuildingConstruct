using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.MaterialStore
{
    public class UpdateProductType
    {
        //public int Id { get; set; }

        public string? Color { get; set; }
        public string? Size { get; set; }
        public string? Other { get; set; }
        public int Quantity { get; set; }

        //public string Name { get; set; }
    }
}



/// Tìm coi nếu như trong product id mà có color size other name == request
/// 
///     //Get list tyep cuar product do 
///     TH1 :  đã có  chỉnh quanties 
///           
///        null  
///     
///     TH2 :  null => New color new size new other => Quanties .
///     
///    final : disable những thằng còn lại 
/// 


// 3  // // 