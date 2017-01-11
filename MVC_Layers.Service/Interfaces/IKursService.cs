using MVC_Layers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Layers.Service.Interfaces
{
    public interface IKursService
    {
        IEnumerable<Kurs> GetKurse();
        Kurs GetKurs(int id);
        void CreateKurs(Kurs kurs);
        void SaveKurs();
    }
}
