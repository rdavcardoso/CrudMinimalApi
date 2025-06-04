namespace CrudMinimalApi.EndPoints;
using CrudMinimalApi.Models;
using CrudMinimalApi.Models.DTOs;
using CrudMinimalApi.Data;


public static class ProdutoEndpoints
{
    public static void MapProdutoEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/produtos", () => {/*Listar Produtos*/} );
        
        app.MapGet("/produtos/{id}", (int id) => {/*Obter Produtos por ID*/});
        
        app.MapPost("/produtos", (ProdutoCreateDto dto) => {/*Criar Produto*/});
        
        app.MapPut("/produtos/{id}", (int id, ProdutoUpdateDto dto) => {/*Atualizar Produto*/});
        
        app.MapDelete("/produtos/{id}", (int id) => {/*Deletar Produto*/});
    }
    
}