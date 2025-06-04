namespace CrudMinimalApi.EndPoints;
using CrudMinimalApi.Models.DTOs;

public static class PedidoEndpoints
{
    public static void MapPedidoEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/pedidos", () => {/*Listar Pedidos*/});
        
        app.MapGet("/pedidos/{id}", (int id) => {/*Obter pedido por ID*/});
        
        app.MapPost("/pedidos", (PedidoCreateDto dto) => {/*Cria Pedido*/});
        
        app.MapPut("/pedidos/{id}", (PedidoUpdateDto dto) => {/*Atualiza Pedido*/});
        
        app.MapDelete("/pedidos/{id}", (int id) => {/*Deleta Pedido*/});
        
    }
    
}