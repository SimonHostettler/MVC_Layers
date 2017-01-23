using MVC_Layers.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Layers.Data
{
    public class StoreSeedData : DropCreateDatabaseIfModelChanges<KursVerwaltungEntities>
    {
        protected override void Seed(KursVerwaltungEntities context)
        {


            context.Commit();
        }

        private static List<Angebot> GetAngebote()
        {
            return new List<Angebot> {
                new Angebot {
                    AngebotTitel = "Excel 2015",
                },
                new Angebot {
                    AngebotTitel = "Word 2015"
                }
            };
        }

        private static List<Kurs> GetKurse()
        {
            return new List<Kurs> {
                new Kurs {
                   AngebotID = 1,
                   Code = "EXC-1000",
                   StartZeit = new DateTime(2017,06,22,8,0,0),
                   EndZeit = new DateTime(2017,06,22,17,0,0),
                },
              new Kurs {
                   AngebotID = 1,
                   Code = "EXC-1001",
                   StartZeit = new DateTime(2017,06,22,10,0,0),
                   EndZeit = new DateTime(2017,06,22,14,30,0),
                },
              new Kurs {
                   AngebotID = 1,
                   Code = "EXC-1002",
                   StartZeit = new DateTime(2017,06,24,15,30,0),
                   EndZeit = new DateTime(2017,06,24,22,30,0),
                },
              new Kurs {
                   AngebotID = 1,
                   Code = "WOR-1003",
                   StartZeit = new DateTime(2017,07,22,10,0,0),
                   EndZeit = new DateTime(2017,07,22,12,00,0),
                },
            };
        }
    }
}
