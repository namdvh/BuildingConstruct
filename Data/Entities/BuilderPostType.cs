using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class BuilderPostType
    {
        public int BuilderPostID { get; set; }

        public int TypeID { get; set; }

        public BuilderPost BuilderPosts { get; set; }

        public Type Types { get; set; }

        
    }
}
