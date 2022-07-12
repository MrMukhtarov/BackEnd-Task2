using Microsoft.EntityFrameworkCore;
using SQL_Connection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQL_Connection.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>option):base(option)
        {

        }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comments> Comments { get; set; }
    }
}
