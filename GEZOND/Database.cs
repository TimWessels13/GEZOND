using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEZOND
{
    class Database : DbContext
    {
        public DbSet<Huisartsen> Huisartsen { get; set; }
        public DbSet<Klanten> Klanten { get; set; }
        public DbSet<Medicatie> Medicatie { get; set; }
        public DbSet<Verzekering> Verzekering { get; set; }
    }
}
