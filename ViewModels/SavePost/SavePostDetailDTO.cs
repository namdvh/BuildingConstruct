using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.BuilderPosts;
using ViewModels.ContractorPost;

namespace ViewModels.SavePost
{
    public class SavePostDetailDTO
    {
        public Guid UserId { get; set; }
        public List<ContractorPostDetailDTO>? cPost { get; set; }
        public List<BuilderPostDetailDTO>? bPost { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
