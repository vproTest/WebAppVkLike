using System.Collections.Generic;
using System.Data.Entity;
using WebAppVkLike.Models;

namespace WebAppVkLike.EFClasses
{
    public class LikeInitializer : DropCreateDatabaseIfModelChanges<LikeContext>
    {
        protected override void Seed(LikeContext context)
        {
            Page first = new Page { Name = "FirstPage" };
            Page second = new Page { Name = "SecondPage" };
            context.Pages.AddRange(new List<Page> { first, second });
            context.SaveChanges();
        }
    }
}