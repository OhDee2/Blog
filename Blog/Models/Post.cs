using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Blog.Models
{
    public class Post
    {
        [BindNever]
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required]
        [StringLength(1000, ErrorMessage = "Body is required")]
        public string Body { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
    }
}
