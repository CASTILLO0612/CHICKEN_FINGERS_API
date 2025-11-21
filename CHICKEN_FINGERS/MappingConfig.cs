using AutoMapper;
using CHICKEN_FINGERS.Dto;
using CHICKEN_FINGERS.Models;

namespace CHICKEN_FINGERS
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<Cliente, ClienteCreateDto>().ReverseMap();
            CreateMap<Cliente, ClienteUpdateDto>().ReverseMap();
            CreateMap<Pedido, PedidoDto>().ReverseMap();
            CreateMap<Pedido, PedidoCreateDto>().ReverseMap();
            CreateMap<Pedido, PedidoUpdateDto>().ReverseMap();
            CreateMap<Producto, ProductoDto>().ReverseMap();
            CreateMap<Producto, ProductoCreateDto>().ReverseMap();
            CreateMap<Producto, ProductoUpdateDto>().ReverseMap();
            CreateMap<MetodoPago, MetodoPagoDto>().ReverseMap();
            CreateMap<MetodoPago, MetodoPagoCreateDto>().ReverseMap();
            CreateMap<MetodoPago, MetodoPagoUpdateDto>().ReverseMap();
            CreateMap<PedidoDetalle, PedidoDetalleDto>().ReverseMap();
            CreateMap<PedidoDetalle, PedidoDetalleCreateDto>().ReverseMap();
            CreateMap<TarjetaPunto, TarjetaPuntoDto>().ReverseMap();
            CreateMap<TarjetaPunto, TarjetaPuntoCreateDto>().ReverseMap();
            CreateMap<Categoria, CategoriaDto>().ReverseMap();
            CreateMap<Categoria, CategoriaCreateDto>().ReverseMap();
            CreateMap<Categoria, CategoriaUpdateDto>().ReverseMap();
            CreateMap<PedidoMetodoPago, PedidoMetodoPagoDto>().ReverseMap();
            CreateMap<PedidoMetodoPago, PedidoMetodoPagoCreateDto>().ReverseMap();
        }
    }
}
