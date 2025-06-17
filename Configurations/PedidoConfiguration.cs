using CrudMinimalApi.Models;

namespace CrudMinimalApi.Configurations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
{
    public void Configure(EntityTypeBuilder<Pedido> builder)
    {
        // Nome da tabela
        builder.ToTable("Pedidos");
        
        // Chave Primária
        builder.HasKey(p => p.Id);
        
        // Propriedade Obrigatória
        builder.Property(p => p.Data).IsRequired();
        
        // Relacionamento: Pedido -> PedidoProduto (1:N)
        builder.HasMany(p => p.Itens)
            .WithOne(pp => pp.Pedido)
            .HasForeignKey(pp => pp.PedidoId);
    }
    
}