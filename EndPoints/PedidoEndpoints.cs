﻿namespace CrudMinimalApi.EndPoints;

using Microsoft.EntityFrameworkCore;
using CrudMinimalApi.Models;
using CrudMinimalApi.Models.DTOs;
using CrudMinimalApi.Data;

public static class PedidoEndpoints
{
    public static void MapPedidoEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/pedidos", async (AppDbContext db) =>
        {
            var pedidos = await db.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.Itens)
                .ThenInclude(pp => pp.Produto)
                .ToListAsync();
                
            return Results.Ok(pedidos);
        });
        
        app.MapGet("/pedidos/{id}", async (int id, AppDbContext db) =>
        {
            var pedido = await db.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.Itens)
                .ThenInclude(pp => pp.Produto)
                .FirstOrDefaultAsync(p => p.Id == id);
            
            return pedido != null ? Results.Ok(pedido) : Results.NotFound();
        });
        
        app.MapPost("/pedidos", async (PedidoCreateDto dto, AppDbContext db) =>
        {
            var cliente = await db.Clientes.FindAsync(dto.ClienteId);
            if (cliente == null)
                return Results.BadRequest("Cliente não encontrado.");

            var pedido = new Pedido
            {
                ClienteId = dto.ClienteId,
                Data = DateTime.UtcNow,
                Itens = dto.ProdutosIds.Select(produtoId => new PedidoProduto
                {
                    ProdutoId = produtoId
                }).ToList()
            };

            db.Pedidos.Add(pedido);
            await db.SaveChangesAsync();

            return Results.Created($"/pedidos/{pedido.Id}", pedido);
        });
        
        app.MapPut("/pedidos/{id}", async (int id, PedidoUpdateDto dto, AppDbContext db) =>
        {
            var pedido = await db.Pedidos
                .Include(p => p.Itens)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (pedido == null)
                return Results.NotFound();
            
            //Atualizando Produtos
            pedido.Itens.Clear();
            pedido.Itens = dto.ProdutosIds.Select(produtoId => new PedidoProduto
            {
                ProdutoId = produtoId
            }).ToList();

            await db.SaveChangesAsync();

            return Results.NoContent();
        });
        
        app.MapDelete("/pedidos/{id}", async (int id, AppDbContext db) =>
        {
            var pedido = await db.Pedidos.FindAsync(id);
            if (pedido == null)
                return Results.NotFound();

            db.Pedidos.Remove(pedido);
            await db.SaveChangesAsync();

            return Results.NoContent();

        });
        
    }
    
}