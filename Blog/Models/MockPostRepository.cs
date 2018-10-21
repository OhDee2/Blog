using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class MockPostRepository : IPostRepository
    {
        private List<Post> _posts;

        public MockPostRepository()
        {
            if (_posts == null)
            {
                InitialisePosts();
            }
        }

        private void InitialisePosts()
        {
            _posts = new List<Post>
            {
                new Post { Id = 1, Body = "This is a post", Date = new DateTime(), Title = "Test Post"},
                new Post { Id = 2, Body = "This is a post", Date = new DateTime(), Title = "Test Post"},
                new Post { Id = 3, Body = "This is a post", Date = new DateTime(), Title = "Test Post"},
                new Post { Id = 4, Body = "This is a post", Date = new DateTime(), Title = "Test Post"},
            };
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return _posts;
        }

        public Post GetPostById(int postId)
        {
            return _posts.FirstOrDefault(p => p.Id == postId);
        }

        public void AddPost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
