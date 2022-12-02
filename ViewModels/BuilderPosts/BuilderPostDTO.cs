using Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.BuilderPosts
{
    public class BuilderPostDTO
    {
        public int Id { get; set; }

        public PostCategories PostCategories { get; set; }
        public Place Place { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Field { get; set; }

        public int BuilderID { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public string Avatar { get; set; }
    }
}
