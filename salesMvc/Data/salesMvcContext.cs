using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using salesMvc.Models;

namespace salesMvc.Data
{
    public class salesMvcContext : DbContext
    {
        public salesMvcContext (DbContextOptions<salesMvcContext> options)
            : base(options)
        {
        }

        public DbSet<salesMvc.Models.Department> Department { get; set; } = default!;
    }
}
