using CrudMinimalApi.Data;
using CrudMinimalApi.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddDbContext<AppDbContext>(options =>
    {
        options.UseNpgsql("DefaultConnection");
    } );
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<ClienteCreateDtoValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<ClienteUpdateDtoValidator>();

var app = builder.Build();






app.Run();
