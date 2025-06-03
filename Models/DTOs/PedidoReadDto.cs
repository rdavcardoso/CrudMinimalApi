namespace CrudMinimalApi.Models.DTOs;

public class PedidoReadDto
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public DateTime DataPedido { get; set; }
    public List<PedidoItemReadDto> Itens { get; set; } = new List<PedidoItemReadDto>();
}