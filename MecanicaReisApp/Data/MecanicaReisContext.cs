using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MecanicaReisApp.Models.Entities;

namespace MecanicaReisApp.Data
{
    public class MecanicaReisContext : DbContext
    {
        public MecanicaReisContext (DbContextOptions<MecanicaReisContext> options)
            : base(options)
        {
        }

        public DbSet<MecanicaReisApp.Models.Entities.Client> Client { get; set; }
    }
}
