using EstudoBancoDeDados.Models;

namespace EstudoBancoDeDados;
public class PromocaoProduto
{
    public int PromocaoId { get; set; }
    public Promocao Promocoes { get; set; }
    public int ProdutoId { get; set; }
    public Produto Produtos { get; set; }
}
