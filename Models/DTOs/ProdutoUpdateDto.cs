namespace CrudMinimalApi.Models.DTOs;

public class ProdutoUpdateDto
{
    public  string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
}