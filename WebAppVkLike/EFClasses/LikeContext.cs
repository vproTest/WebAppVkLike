using System.Data.Entity;
using WebAppVkLike.Models;

namespace WebAppVkLike.EFClasses
{
    public class LikeContext : DbContext
    {
        public LikeContext()
        {
            Database.SetInitializer(new LikeInitializer());
        }

        public DbSet<Like> Likes { get; set; }
        public DbSet<Page> Pages { get; set; }
    }
}