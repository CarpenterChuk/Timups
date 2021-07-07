using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Timups.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
        }
        public DbSet<Watch> Watches { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
