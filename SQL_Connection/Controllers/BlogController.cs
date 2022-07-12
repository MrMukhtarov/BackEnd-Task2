using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQL_Connection.DAL;
using SQL_Connection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQL_Connection.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BlogController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Blog> model = _context.Blogs.ToList();
            return View(model);
        }
        public IActionResult Detail(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            Blog blog = _context.Blogs.Include(x => x.Comments).FirstOrDefault(x => x.Id == Id);
            if (blog == null) return NotFound();
            return View(blog);
        }
    }
}
