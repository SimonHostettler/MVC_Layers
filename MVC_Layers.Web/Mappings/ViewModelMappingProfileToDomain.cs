using AutoMapper;
using MVC_Layers.Models;
using MVC_Layers.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Layers.Web.Mappings
{
    public class ViewModelMappingProfileToDomain : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelMappingProfileToDomain"; }
        }

        public ViewModelMappingProfileToDomain()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<KursViewModel, Kurs>();
                cfg.CreateMap<AngebotViewModel, Angebot>();
            });
        }
    }
}