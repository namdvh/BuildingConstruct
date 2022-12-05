using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Users
{
    public class RegisterRequestDTO
    {
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string RoleID { get; set; }
        public string Password { get; set; }
    }
}
