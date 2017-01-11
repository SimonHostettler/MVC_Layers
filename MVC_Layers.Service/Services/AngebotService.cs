using MVC_Layers.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Layers.Models;
using MVC_Layers.Data.Repositories;
using MVC_Layers.Data.Infrastructure;

namespace MVC_Layers.Service
{
    public class AngebotService : IAngebotService
    {
        private readonly IKursRepository kursRepository;
        private readonly IAngebotRepository angebotRepository;
        private readonly IUnitOfWork unitOfWork;


        public AngebotService(IKursRepository kursRepository, IAngebotRepository angebotRepository,
                IUnitOfWork unitOfWork)
        {
            this.kursRepository = kursRepository;
            this.angebotRepository = angebotRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Angebot> GetAngebote()
        {
            throw new NotImplementedException();
        }

        public Angebot GetAngebot(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateAngebot(Angebot angebot)
        {
            throw new NotImplementedException();
        }

        public void SaveAngebot()
        {
            throw new NotImplementedException();
        }
    }
}
