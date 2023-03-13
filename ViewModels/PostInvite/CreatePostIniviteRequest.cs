using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.PostInvite
{
    public class CreatePostIniviteRequest
    {
        public int? ContractorId { get; set; }
        public int? BuilderId { get; set; }
        public int? ContractorPostId { get; set; }
    }
}
