using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Layers.Models
{
    public class Kurs
    {
        public int KursID { get; set; }
        public string Code { get; set; }
        public DateTime StartZeit { get; set; }
        public DateTime EndZeit { get; set; }
        public int AngebotID { get; set; }
        public Angebot Angebot { get; set; }

        public Kurs()
        {
            // Konstruktor
        }
    }
}
