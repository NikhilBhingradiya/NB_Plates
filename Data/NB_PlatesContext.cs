using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using NB_Plates.Models;

namespace NB_Plates.Data
{
    public class NB_PlatesContext : DbContext
    {
        public NB_PlatesContext(DbContextOptions<NB_PlatesContext> options)
            : base(options)
        {
        }

        public DbSet<Plates> Plates { get; set; }
    }
}
