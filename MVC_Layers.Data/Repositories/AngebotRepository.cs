using MVC_Layers.Data.Infrastructure;
using MVC_Layers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Layers.Data.Repositories
{
    public class AngebotRepository : RepositoryBase<Angebot>, IAngebotRepository
    {
        public AngebotRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface IAngebotRepository : IRepository<Angebot>
    {
    }
}
