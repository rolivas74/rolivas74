using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiJuguetes.Models;
using Microsoft.EntityFrameworkCore;

namespace apiJuguetes.Context
{
    public class AppJuguetesContext: DbContext
    {
        public AppJuguetesContext(DbContextOptions<AppJuguetesContext> options): base(options) 
        {

        }
        public DbSet<Juguetes> juguetes { get; set; }
    }
}
