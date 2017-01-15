using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Layers.Models
{
    public class Angebot
    {
        public int AngebotID { get; set; }
        public string AngebotTitel { get; set; }

        public virtual List<Kurs> Kurse { get; set; }

    }
}
