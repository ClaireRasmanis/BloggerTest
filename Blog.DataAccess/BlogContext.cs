using System.Data.Entity;

namespace Blogger.DataAccess
{
    public class BlogContext : DbContext
    {
        public DbSet<Blogger.DataModel.Blog> Blogs { get; set; }

        public BlogContext()
            : base("Server=(LocalDB)\\v11.0; Integrated Security=True; MultipleActiveResultSets=True; Database=Blogs")
        {
          //  Database.CreateIfNotExists();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add<DateTime2Convention>();
        }
    }
}
