namespace CrudMinimalApi.Mappings;

using AutoMapper;
using CrudMinimalApi.Models;
using CrudMinimalApi.Models.DTOs;

public class ProdutoProfile : Profile
{
    public ProdutoProfile()
    {
        CreateMap<Produto, ProdutoReadDto>();
        CreateMap<ProdutoCreateDto, Produto>();
        CreateMap<ProdutoUpdateDto, Produto>();
        CreateMap<Produto, ProdutoUpdateDto>();
    }
}