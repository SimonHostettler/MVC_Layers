using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Layers.Web.ViewModels
{
    public class KursViewModel
    {
        public int KursID { get; set; }
        public string Code { get; set; }
        public DateTime StartZeit { get; set; }
        public DateTime EndZeit { get; set; }
        public int AngebotID { get; set; }
    }
}