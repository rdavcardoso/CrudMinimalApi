namespace CrudMinimalApi.Mappings;

using AutoMapper;
using CrudMinimalApi.Models;
using CrudMinimalApi.Models.DTOs;

public class ProdutoProfile : Profile
{
    public ProdutoProfile()
    {
        CreateMap<Produto, ProdutoDto>();
        CreateMap<ProdutoCreateDto, Produto>();
        CreateMap<ProdutoCreateDto, Produto>();
        CreateMap<Produto, ProdutoCreateDto>();
    }
}