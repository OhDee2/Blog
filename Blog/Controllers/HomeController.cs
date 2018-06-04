using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostRepository _postRepository;

        public HomeController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        // GET: /<controller>/
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
