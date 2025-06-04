namespace CrudMinimalApi.EndPoints;

using Microsoft.EntityFrameworkCore;
using CrudMinimalApi.Models;
using CrudMinimalApi.Models.DTOs;
using CrudMinimalApi.Data;

public static class ClienteEndpoints
{
    public static void MapClienteEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/clientes", async (AppDbContext db) =>
        {
            var clientes = await db.Clientes.ToListAsync();
            return Results.Ok(clientes);
        });
        
        app.MapGet("/clientes/{id}", async (int id, AppDbContext db) =>
        {
            var cliente = await db.Clientes.FindAsync(id);
            return cliente != null ? Results.Ok(cliente) : Results.NotFound();
        });
        
        app.MapPost("/clientes", async (ClienteCreateDto dto, AppDbContext db) =>
        {
            var cliente = new Cliente
            {
                Nome = dto.Nome,
                Email = dto.Email
            };
            
            db.Clientes.Add(cliente);
            await db.SaveChangesAsync();

            return Results.Created($"/clientes/{cliente.Id}", cliente);
        });
        
        app.MapPut("/clientes/{id}", async (int id, ClienteUpdateDto dto, AppDbContext db) =>
        {
            var cliente = await db.Clientes.FindAsync(id);
            if (cliente == null)
                return Results.NotFound();

            cliente.Nome = dto.Nome;
            cliente.Email = dto.Email;

            await db.SaveChangesAsync();

            return Results.NoContent();
        });
        
        app.MapDelete("/clientes/{id}", async (int id, AppDbContext db) =>
        {
            var cliente = await db.Clientes.FindAsync(id);
            if (cliente == null)
                return Results.NotFound();

            db.Clientes.Remove(cliente);
            await db.SaveChangesAsync();

            return Results.NoContent();
        });
        
    }
    
}