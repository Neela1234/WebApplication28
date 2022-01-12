using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication28.Models;

namespace WebApplication28.Data
{
    public class WebApplication28Context : DbContext
    {
        public WebApplication28Context (DbContextOptions<WebApplication28Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication28.Models.Employee> Employee { get; set; }
    }
}
