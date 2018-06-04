using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;

namespace Blog.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Post> Posts { get; set; }
    }
}
