using AutoMapper;
using PopApp.Core.Dtos;
using PopApp.Core.Entities;

namespace PopAppBackend.Mapper
{
    /// <summary>
    /// Represent mapper config.
    /// </summary>
    public class MapperConfig : Profile
    {
        #region Ctor
        /// <summary>
        /// 
        /// </summary>
        public MapperConfig()
        {
            CreateMap<Company, CompanyDto>().ReverseMap();
            CreateMap<Container, ContainerDto>().ReverseMap();
            CreateMap<Document, DocumentDto>().ReverseMap();
            CreateMap<Freight, FreightDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Vessel, VesselDto>().ReverseMap();
        }
        #endregion
    }
}
