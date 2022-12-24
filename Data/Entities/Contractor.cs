﻿namespace Data.Entities
{
    public class Contractor:BaseEntity
    {
        public int Id { get; set; }

        public string? CompanyName { get; set; }

        public string? Description { get; set; }

        public string? Website { get; set; }

        public User? User { get; set; }

        public List<ContractorPost> ContractorPosts { get; set; }
    }
}