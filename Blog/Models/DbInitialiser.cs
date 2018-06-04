using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public static class DbInitialiser
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Posts.Any())
            {
                context.AddRange(
                    new Post { Body = "This is a post", Date = new DateTime(), Title = "Test Post" },
                    new Post { Body = "This is a post", Date = new DateTime(), Title = "Test Post" },
                    new Post { Body = "This is a post", Date = new DateTime(), Title = "Test Post" },
                    new Post { Body = "This is a post", Date = new DateTime(), Title = "Test Post" });

                context.SaveChanges();
            }
        }
    }
}
