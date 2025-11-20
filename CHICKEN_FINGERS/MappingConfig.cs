using AutoMapper;
using CHICKEN_FINGERS.Dto;
using CHICKEN_FINGERS.Models;
using System.Formats.Tar;

namespace CHICKEN_FINGERS
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<Cliente, ClienteCreateDto>().ReverseMap();
            CreateMap<Cliente, ClienteUpdateDto>().ReverseMap();
            CreateMap<PedidoDetalle, PedidoDetalleDto>().ReverseMap();
            CreateMap<PedidoDetalle, PedidoDetalleCreateDto>().ReverseMap();
            CreateMap<PedidoDetalle, PedidoDetalleEliminarDto>().ReverseMap();
            CreateMap<Categoria, CategoriaDto>().ReverseMap();
            CreateMap<Categoria, CategoriaCreateDto>().ReverseMap();
            CreateMap<Categoria, CategoriaUpdateDto>().ReverseMap();
            CreateMap<TarjetaPunto, TarjetaPuntoDto>().ReverseMap();
            CreateMap<TarjetaPunto, TarjetaPuntoCreateDto>().ReverseMap();
        }
    }
}
