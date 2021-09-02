using Microsoft.EntityFrameworkCore;
using MVC_Bartender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Bartender.Data
{
    public class BarDbContext : DbContext
    {
        public BarDbContext(DbContextOptions<BarDbContext> options) : base(options)
        {
                
        }

        public DbSet<Cocktail> Cocktail { get; set; }

        public DbSet<MVC_Bartender.Models.Order> Order { get; set; }
    }
}
