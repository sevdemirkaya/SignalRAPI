using AutoMapper;
using SignalR.DtoLayer.DiscountDto;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.API.Mapping
{
    public class DiscountMapping : Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount, ResultDiscountDto>();
            CreateMap<Discount, CreateDiscountDto>();
            CreateMap<Discount, GetDiscountDto>();
            CreateMap<Discount, UpdateDiscountDto>();
        }

    }
}
