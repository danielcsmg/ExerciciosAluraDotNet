using EstudoBancoDeDados.Models;

namespace EstudoBancoDeDados;
public interface IProdutoDao
{
    void Add(Produto p);
    void AddRange(params Produto[] p);
    void Remove(Produto p);
    void Update(Produto p);
    IList<Produto> Produtos();
}
