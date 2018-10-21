using System.Linq;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostRepository _postRepository;

        public HomeController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        
        public IActionResult Index()
        {
            var posts = _postRepository.GetAllPosts().OrderBy(p => p.Date);

            var homeViewModel = new HomeViewModel()
            {
                Title = "James' Blog",
                Posts = posts.ToList() 
            };

            return View(homeViewModel);
        }
    }
}
