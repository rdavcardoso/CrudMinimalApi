namespace CrudMinimalApi.Models.DTOs;

public class PedidoReadDto
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public DateTime DataPedido { get; set; }
    public List<ProdutoReadDto> Itens { get; set; } = new List<ProdutoReadDto>();
}