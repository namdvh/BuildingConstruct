using Data.Entities;
using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Identification
{
    public class IdentificationDTO
    {
        public int Id { get; set; }

        public string? FaceImage { get; set; }

        public string? FrontID { get; set; }

        public string? BackID { get; set; }

        public string? BusinessLicense { get; set; }

        public Guid? UserID { get; set; }

        public IdentificateType IdentificateType { get; set; }

        public bool PreCodition { get; set; }

        public Status Status { get; set; }

        public DateTime LastModifiedAt { get; set; }

    }
}
