using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExploreCalifornia.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {

        [Route("")]
        public IActionResult Index()
        {
            var posts = new[]
            {
                new Post
                {
                    Title = "My blog post",
                    Posted = DateTime.Now,
                    Author = "Mike & Alexander",
                    Body ="yo watup"
                },
                new Post
                {
                    Title = "My blog post 2",
                    Posted = DateTime.Now,
                    Author = "Mike & Alexander2",
                    Body ="yo watup 2"
                },
            };
            
            return View(posts);
        }

        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            var post = new Post
            {
                Title = "My blog post",
                Posted = DateTime.Now,
                Author = "Jess Chadwick",
                Body = "This is a great blog post, don't you think?",
            };
            return View(post);
        }

        [Route("Create")]
        public IActionResult Create()
        {
            return View();
        }
    }
}




