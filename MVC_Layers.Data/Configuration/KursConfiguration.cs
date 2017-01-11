using MVC_Layers.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Layers.Data
{
    public class KursConfiguration : EntityTypeConfiguration<Kurs>
    {
        public KursConfiguration()
        {
            ToTable("Kurs");
            Property(k => k.Code).IsRequired();
            Property(k => k.StartZeit).IsRequired();
            Property(k => k.EndZeit).IsRequired();
            Property(k => k.AngebotID);
        }
    }
}

