using MVC_Layers.Data.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Layers.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        KursVerwaltungEntities dbContext;
        public KursVerwaltungEntities Init()
        {
            return dbContext ?? (dbContext = new KursVerwaltungEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
