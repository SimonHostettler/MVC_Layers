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
    public class KursService : IKursService
    {
        private readonly IKursRepository kursRepository;
        private readonly IAngebotRepository angebotRepository;
        private readonly IUnitOfWork unitOfWork;


        public KursService(IKursRepository kursRepository, IAngebotRepository angebotRepository,
                IUnitOfWork unitOfWork)
        {
            this.kursRepository = kursRepository;
            this.angebotRepository = angebotRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Kurs> GetKurse()
        {
            return kursRepository.GetAll();
        }

        public Kurs GetKurs(int id)
        {
            return kursRepository.GetById(id);
        }

        public void CreateKurs(Kurs kurs)
        {
            kurs.StartZeit = DateTime.Now;
            kursRepository.Add(kurs);
        }

        public void SaveKurs()
        {
            unitOfWork.Commit();
        }
    }
}
