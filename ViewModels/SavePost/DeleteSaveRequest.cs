﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.SavePost
{
    public class DeleteSaveRequest
    {
        public int? ContractorPostId { get; set; }
        public int? BuilderPostId { get; set; }
    }
}
