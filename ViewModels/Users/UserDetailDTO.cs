using Data.Entities;
using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Users
{
    public class UserDetailDTO
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Address { get; set; }
        public Gender? Gender { get; set; }
        public DateTime? DOB { get; set; }
        public string? Avatar { get; set; }
        public Status? Status { get; set; }
        public string? IdNumber { get; set; }
        public string? Phone { get; set; }

        public DetailBuilder? Builder { get; set; }
        public DetailContractor? Contractor { get; set; }
        public DetailMaterialStore? DetailMaterialStore { get; set; }
    }

    public class DetailBuilder
    {
        public int Id { get; set; }

        public Place? Place { get; set; }

        public List<BuilderSkillsDTO>? BuilderSkills { get; set; }

        public string TypeName { get; set; }

        public string? ExperienceDetail { get; set; }
        public int? Experience { get; set; }

        public string? Certificate { get; set; }


    }


    public class DetailContractor
    {
        public int Id { get; set; }

        public string? CompanyName { get; set; }

        public string? Description { get; set; }

        public string? Website { get; set; }

    }

    public class DetailMaterialStore
    {
        public int Id { get; set; }

        public string? Website { get; set; }

        public string? Description { get; set; }

        public string? TaxCode { get; set; }

        public string? Experience { get; set; }

        public string? Image { get; set; }

        public Place Place { get; set; }


    }
}
