using Basti.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Basti.Web.Data
{
    public class BastiDbContext : DbContext
    {
        public BastiDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}
