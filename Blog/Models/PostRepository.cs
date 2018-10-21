using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Blog.Models
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _appDbContext;

        public PostRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return _appDbContext.Posts;
        }

        public Post GetPostById(int postId)
        {
            return _appDbContext.Posts.FirstOrDefault(p => p.Id == postId);
        }

        public void AddPost(Post post)
        {
            _appDbContext.Posts.Add(post);
            _appDbContext.SaveChanges();
        }
    }
}
