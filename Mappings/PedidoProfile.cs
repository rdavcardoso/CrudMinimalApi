namespace CrudMinimalApi.Mappings;

using AutoMapper;
using CrudMinimalApi.Models;
using CrudMinimalApi.Models.DTOs;


public class PedidoProfile : Profile
{
    public PedidoProfile()
    {
        CreateMap<Pedido, PedidoReadDto>();
        CreateMap<PedidoCreateDto, Pedido>();
        CreateMap<PedidoUpdateDto, Pedido>();
        CreateMap<Pedido,  PedidoUpdateDto>();
    }
    
}