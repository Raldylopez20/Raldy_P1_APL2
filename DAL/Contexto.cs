using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Raldy_P1_APL2.Models;
using Microsoft.EntityFrameworkCore;

namespace Raldy_P1_APL2.DAL
{
    public class Contexto : DbContext
    {

        public DbSet<Productos> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data/Productos.db");
        }
    }
}
