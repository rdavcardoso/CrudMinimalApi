namespace CrudMinimalApi.Models.DTOs;

public class PedidoCreateDto
{
    public int IdCliente { get; set; }
    public DateTime DataPedido { get; set; }
    public decimal ValorTotal { get; set; }
}