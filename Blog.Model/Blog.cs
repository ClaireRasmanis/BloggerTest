using System;
using System.Collections.Generic;

namespace Blogger.DataModel
{
    public class Blog
    {
        public int BlogId { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
        
        public DateTime Created { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}
