namespace CrudMinimalApi.Models;

public class Pedido
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }
    public DateTime DataPedido { get; set; }
    public List<PedidoProduto> Itens { get; set; } = new List<PedidoProduto>();
}