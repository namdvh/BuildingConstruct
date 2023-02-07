﻿using Data.Enum;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace Data.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Address { get; set; }
        public Gender? Gender { get; set; }
        public DateTime? DOB { get; set; }
        public string? Avatar { get; set; }
        public Status Status { get; set; }
        public string? Token { get; set; }
        public string? IdNumber { get; set; }

        public DateTime LastModifiedAt { get; set; } = DateTime.Now;

        public Guid CreateBy { get; set; }

        public int? VerifyID { get; set; }

        public Verify? Verify { get; set; }

        public DateTime RefreshTokenExpiryTime { get; set; }

        public int? ContractorId { get; set; }
        [JsonIgnore]

        public Contractor Contractor { get; set; }

        public int? BuilderId { get; set; }
        [JsonIgnore]

        public Builder Builder { get; set; }

        public int? MaterialStoreID { get; set; }
        [JsonIgnore]
        public MaterialStore MaterialStore { get; set; }

        public List<PostCommitment>? PostCommitments { get; set; }

        public Provider? Provider { get; set; }



        public List<Cart> Carts { get; set; }
        public List<Save>? Saves { get; set; }

    }
}