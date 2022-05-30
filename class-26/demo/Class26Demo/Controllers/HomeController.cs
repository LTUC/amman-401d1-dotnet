using Class26Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Class26Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name, string job)
        {
            Person person = new Person { Name = name, Job = job };
            return View(person);
        }

        public IActionResult List()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { Name = "Yousef", Job = "Software Architect" });
            people.Add(new Person { Name = "Yahia", Job = "Software Developer" });
            people.Add(new Person { Name = "Haneen", Job = "Project manager" });
            people.Add(new Person { Name = "Waseem", Job = "Product Owner" });
            people.Add(new Person { Name = "Ola", Job = "Software Architect" });
            return View(people);
        }

        public IActionResult Article()
        {
            Article article = new Article
            {
                Title = "This is my first article",
                Author = "Shadi",
                Text = "I am writing this article to show the view models"
            };

            Blog blog = new Blog
            {
                Title = "The first blog",
                Description = "This was used to contain articles using view models"
            };

            BlogArticleVM blogArticle = new BlogArticleVM
            {
                Blog = blog,
                Article = article
            };

            return View(blogArticle);
        }
    }
}
