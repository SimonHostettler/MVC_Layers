﻿using AutoMapper;
using MVC_Layers.Models;
using MVC_Layers.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Layers.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        public DomainToViewModelMappingProfile()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Kurs, KursViewModel>();
                cfg.CreateMap<Angebot, AngebotViewModel>();
            });
        }
    }
}