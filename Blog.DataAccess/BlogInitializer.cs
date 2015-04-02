using System.Collections.Generic;
using System.Data.Entity;
using Blogger.DataModel;
using MyBlog = Blogger.DataModel.Blog;

namespace Blogger.DataAccess
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        public override void InitializeDatabase(BlogContext context)
        {
            base.InitializeDatabase(context);
        }

        protected override void Seed(BlogContext context)
        {
            ICollection<Post> clairePosts = new []
            {
                new Post { Content = "Hello", Title = "Hello", Author = "Claire" }, 
                new Post { Content = "How are you", Title = "How are you" }, 
                new Post { Content = "Goodbye", Title = "Goodbye" },
                new Post { Title = "No content" },
                new Post { Content = "No title" }
            };

            var blogs = new []
            {
              new MyBlog { Author = "Claire", Name = "Claire's Blog", Posts = clairePosts },
              new MyBlog { Author = "Ali", Name = "Ali's Blog" },
              new MyBlog { Author = "Krishna", Name = "Krishna's Blog" }
            };
            
            context.Blogs.AddRange(blogs);
            context.SaveChanges();
        }
    }
}
