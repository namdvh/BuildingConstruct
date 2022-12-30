using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Users
{
    public class UpdateRoleRequest
    {   
        public string UserId { get; set; }
        public string RoleId { get; set; }
    }
}
