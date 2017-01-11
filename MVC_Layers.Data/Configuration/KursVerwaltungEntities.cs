using MVC_Layers.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Layers.Data.Configuration
{
    public class KursVerwaltungEntities : DbContext
    {
        public KursVerwaltungEntities() : base("KursVerwaltungEntities") { }

        public DbSet<Kurs> Kurse { get; set; }
        public DbSet<Angebot> Angebote { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KursConfiguration());
            modelBuilder.Configurations.Add(new AngebotConfiguration());
        }
    }
}
