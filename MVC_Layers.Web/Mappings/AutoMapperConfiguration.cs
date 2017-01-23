using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Layers.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public IMapper GetConfigure()
        {
            var autoMapper = new DomainMappingProfile();
            return autoMapper.GetDomainMappingProfile().CreateMapper();
        }
    }
}