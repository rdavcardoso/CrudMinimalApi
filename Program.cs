using CrudMinimalApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddDbContext<AppDbContext>(options =>
    {
        options.UseNpgsql("DefaultConnection");
    } );

var app = builder.Build();






app.Run();
