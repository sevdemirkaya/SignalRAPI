using AutoMapper;
using SignalR.DtoLayer.AboutDTO;
using SignalRAPI.SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.API.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDto>();
            CreateMap<About, CreateAboutDto>();
            CreateMap<About, GetAboutDto>();
            CreateMap<About, UpdateAboutDto>();
        }
    }
}
