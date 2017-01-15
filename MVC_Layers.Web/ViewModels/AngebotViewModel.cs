using MVC_Layers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Layers.Web.ViewModels
{
    public class AngebotViewModel
    {
        public int AngebotID { get; set; }
        public string AngebotTitel { get; set; }

        public List<Kurs> Kurse { get; set; }
    }
}