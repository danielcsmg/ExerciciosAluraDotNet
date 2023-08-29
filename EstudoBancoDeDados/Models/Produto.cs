using System.ComponentModel.DataAnnotations;

namespace EstudoBancoDeDados.Models;

public class Produto
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public double PrecoUnitario { get; set; }
    public string Unidade { get; set; }
    public IList<PromocaoProduto> PromocaoProduto { get; set; }
}
