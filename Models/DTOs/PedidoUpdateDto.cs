namespace CrudMinimalApi.Models.DTOs;

public class PedidoUpdateDto
{
    public DateTime DataPedido { get; set; }
    public List<int> ProdutosIds { get; set; }
}