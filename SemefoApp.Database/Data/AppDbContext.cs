using Microsoft.EntityFrameworkCore;
using SemefoApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemefoApp.Database.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            Database.EnsureCreated();     
        }
        public DbSet<CuerpoModel> Cuerpos { get; set; }
    }
}
