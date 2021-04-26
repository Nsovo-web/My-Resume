using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyResume.Models;

namespace MyResume.Data
{
    public class MyResumeContext : DbContext
    {
        public MyResumeContext (DbContextOptions<MyResumeContext> options)
            : base(options)
        {
        }

        public DbSet<MyResume.Models.Movie> Movie { get; set; }
    }
}
