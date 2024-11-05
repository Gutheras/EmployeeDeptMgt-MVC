using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Practice.Models;

namespace MVC_Practice.Data
{
    public class MVC_PracticeContext : DbContext
    {
        public MVC_PracticeContext (DbContextOptions<MVC_PracticeContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Practice.Models.Employee> Employee { get; set; } = default!;
        public DbSet<MVC_Practice.Models.Department> Department { get; set; } = default!;
    }
}
