namespace CrudMinimalApi.Models.DTOs;

public class PedidoCreateDto
{
    public int ClienteId { get; set; }
    public DateTime DataPedido { get; set; }
    public List<int> ProdutosIds { get; set; }
}