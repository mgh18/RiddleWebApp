using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RiddleWebApp.Models;

namespace RiddleWebApp.Data
{
    public class ApplicationDbContextContext : DbContext
    {
        public ApplicationDbContextContext (DbContextOptions<ApplicationDbContextContext> options)
            : base(options)
        {
        }

        public DbSet<RiddleWebApp.Models.Riddle> Riddle { get; set; } = default!;
    }
}
