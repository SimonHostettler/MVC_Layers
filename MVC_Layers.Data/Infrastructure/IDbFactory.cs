using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Layers.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        KursVerwaltungEntities Init();
    }
}
