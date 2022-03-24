using AutoMapper;
using WebApplication4.Entities;
using WebApplication4.Entities.RequestModels;
using WebApplication4.Entities.ResponseModels;

namespace WebApplication4.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RCreateOrder, Order>();
            CreateMap<Order, TCreateOrder>();
            CreateMap<TCreateOrder, Order>()
                .ForMember(x => x.Id, x => x.Ignore());
        }
    }
}
