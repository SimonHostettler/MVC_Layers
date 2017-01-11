using MVC_Layers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Layers.Service.Interfaces
{
    public interface IAngebotService
    {
        IEnumerable<Angebot> GetAngebote();
        Angebot GetAngebot(int id);
        void CreateAngebot(Angebot angebot);
        void SaveAngebot();
    }
}
