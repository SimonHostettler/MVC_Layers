using MVC_Layers.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Layers.Data
{
    public class AngebotConfiguration : EntityTypeConfiguration<Angebot>
    {
        public AngebotConfiguration()
        {
            ToTable("Angebot");
            Property(k => k.AngebotTitel).IsRequired().HasMaxLength(100);
        }
    }
}

