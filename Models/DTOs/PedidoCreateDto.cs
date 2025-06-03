namespace CrudMinimalApi.Models.DTOs;

public class PedidoCreateDto
{
    public int ClienteId { get; set; }
    public List<int> ProdutoIds { get; set; }
}