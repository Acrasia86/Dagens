using Dagens.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dagens.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext context;

        public CategoryController(ApplicationDbContext context)
        {
            this.context = context;
        }



        [HttpGet("{id}")]
        public IActionResult Categories(int id)
        {
            var articleCategory = context.Category
                .Include(x => x.CategoryArticles)
                .ThenInclude(x => x.Article)
                .FirstOrDefault(x => x.Id == id);

            return View(articleCategory);
        }
    }
}
