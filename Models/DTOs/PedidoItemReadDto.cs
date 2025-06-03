namespace CrudMinimalApi.Models.DTOs;

public class PedidoItemReadDto
{
    public int ProdutoId { get; set; }
    public string Nome { get; set; } = string.Empty;
    public int Quantidade { get; set; }
}