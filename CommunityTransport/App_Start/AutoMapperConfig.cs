using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using CommunityTransport.Models;
using GUI.Models;

namespace GUI.App_Start
{
        public static class AutoMapperWebConfiguration
        {
            public static void Configure()
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.AddProfile(new PlanningProfile());
                    cfg.AddProfile(new SubscriptionProfile());
                    cfg.AddProfile(new PaiementProfile());


                });
            }
        }
        public class PlanningProfile : Profile
        {
            protected override void Configure()
            {
            Mapper
            .CreateMap<planning, PlanningViewModels>();
            //.ForMember(des => des.NumberOrders, opt => opt.MapFrom(src => src.Orders.Count));
            Mapper
          .CreateMap<PlanningViewModels, planning>();
        }
        }
    public class SubscriptionProfile : Profile
    {
        protected override void Configure()
        {
            Mapper
           .CreateMap<subscription, SubscriptionViewModels>();
            Mapper
           .CreateMap<SubscriptionViewModels, subscription>();
        }
    }

    public class PaiementProfile : Profile
    {
        protected override void Configure()
        {
            Mapper
           .CreateMap<paiement, PaiementViewModels>();
            Mapper
           .CreateMap<PaiementViewModels, paiement>();
        }
    }
}