namespace CrudMinimalApi.Models;

public class Pedido
{
    public int Id { get; set; }
    public int IdCliente { get; set; }
    public DateTime DataPedido { get; set; }
    public decimal ValorTotal { get; set; }
}