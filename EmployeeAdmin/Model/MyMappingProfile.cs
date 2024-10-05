using AutoMapper;

namespace EmployeeAdmin.Model
{
    public class MyMappingProfile : Profile
    {
        public MyMappingProfile()
        {

            CreateMap<Address,AddressDTO>();
            CreateMap<EmployeeMapper, EmployeeMapperDTO>().ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address ?? new Address()
            { City = "N/A", Country = "N/A", State = "N/A" }
            ));

            CreateMap<Product, ProductDTO>().ForMember(dest => dest.Price, opt =>
            {

                opt.PreCondition(src => src.InStock);
                opt.MapFrom(src => src.Price);
            });
            CreateMap<Order, OrderDTO>().AfterMap((src, dest) =>
            {
                dest.Status = src.TotalAmount > 1000 ? "premium" : "standard";
            });

            CreateMap<ProductDataDTO, ProductData>().ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => "System"))
                .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => GetCurrentDateTime()));
        }

        private DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
    }
}
