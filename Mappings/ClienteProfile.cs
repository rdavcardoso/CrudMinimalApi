namespace CrudMinimalApi.Mappings;

using AutoMapper;
using CrudMinimalApi.Models;
using CrudMinimalApi.Models.DTOs;

public class ClienteProfile : Profile
{
    public ClienteProfile()
    {
        CreateMap<Cliente, ClienteReadDto>();
        CreateMap<ClienteCreateDto, Cliente>();
        CreateMap<ClienteUpdateDto, Cliente>();
        CreateMap<Cliente, ClienteUpdateDto>();
    }
    
}