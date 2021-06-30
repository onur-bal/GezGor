using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GezGor.Models
{
    public class GezGorContext : DbContext
    {
        public GezGorContext() : base("name=BaglantiCumlem")
        {
            
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<GezGorContext>());
        }

        public DbSet<Ulke> Ulkeler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }

    }
}
