using Microsoft.EntityFrameworkCore;
using CrudMinimalApi.Models;

namespace CrudMinimalApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
    
    public DbSet<Produto> Produtos => Set<Produto>();
    public DbSet<Cliente> Clientes => Set<Cliente>();
    public DbSet<Pedido> Pedidos => Set<Pedido>();
    public DbSet<PedidoProduto> PedidoProdutos => Set<PedidoProduto>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PedidoProduto>()
            .HasKey(pp => new { pp.PedidoId, pp.ProdutoId });
        
        modelBuilder.Entity<PedidoProduto>()
            .HasOne(pp => pp.Pedido)
            .WithMany(p => p.Itens)
            .HasForeignKey(pp => pp.PedidoId);
        
        modelBuilder.Entity<PedidoProduto>()
            .HasOne(pp => pp.Produto)
            .WithMany(p => p.Pedidos)
            .HasForeignKey(pp => pp.ProdutoId);
    }
    
}