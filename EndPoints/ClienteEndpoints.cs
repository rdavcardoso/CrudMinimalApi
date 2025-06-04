namespace CrudMinimalApi.EndPoints;
using CrudMinimalApi.Models.DTOs;

public static class ClienteEndpoints
{
    public static void MapClienteEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/clientes", () => { /*Listar Clientes*/ });
        
        app.MapGet("/clientes/{id}", (int id) => {/*Obter Cliente por ID*/});
        
        app.MapPost("/clientes", (ClienteCreateDto dto) => {/*Criar Cliente*/});
        
        app.MapPut("/clientes/{id}", (int id, ClienteUpdateDto dto) => {/*Atualizar Cliente*/});
        
        app.MapDelete("/clientes/{id}", (int id) => {/*Deletar Cliente*/});
        
    }
    
}