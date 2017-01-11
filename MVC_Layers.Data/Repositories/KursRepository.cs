using MVC_Layers.Data.Infrastructure;
using MVC_Layers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Layers.Data.Repositories
{
    public class KursRepository : RepositoryBase<Kurs>, IKursRepository
    {
        public KursRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public Kurs GetKursByCode(string kursCode)
        {
            return this.DbContext.Kurse.FirstOrDefault(k => k.Code == kursCode);
        }
    }

    public interface IKursRepository : IRepository<Kurs>
    {
        Kurs GetKursByCode(string kursCode);
    }
}
