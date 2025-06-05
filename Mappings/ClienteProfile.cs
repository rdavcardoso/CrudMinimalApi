namespace CrudMinimalApi.Mappings;

using AutoMapper;
using CrudMinimalApi.Models;
using CrudMinimalApi.Models.DTOs;

public class ClienteProfile : Profile
{
    public ClienteProfile()
    {
        CreateMap<Cliente, ClienteDto>();
        CreateMap<ClienteCreateDto, Cliente>();
        CreateMap<ClienteCreateDto, Cliente>();
        CreateMap<Cliente, ClienteCreateDto>();
    }
    
}