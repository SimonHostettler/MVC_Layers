using MVC_Layers.Models;
using MVC_Layers.Service.Interfaces;
using MVC_Layers.Web.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using MVC_Layers.Web.Mappings;

namespace MVC_Layers.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAngebotService angebot_service;
        private readonly IKursService kurs_service;

        public HomeController(IAngebotService angebot_service, IKursService kurs_service)
        {
            this.angebot_service = angebot_service;
            this.kurs_service = kurs_service;
        }

        public ActionResult Index()
        {
            var kurse = kurs_service.GetKurse();
            var mapper = new AutoMapperConfiguration().GetConfigure();

            IEnumerable<KursViewModel> kurseVM = mapper.Map<IEnumerable<Kurs>, IEnumerable<KursViewModel>>(kurse);
            return View(kurseVM);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}