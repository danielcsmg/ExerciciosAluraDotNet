using EstudoBancoDeDados.Models;

namespace EstudoBancoDeDados;
public class ProdutoDao : IProdutoDao, IDisposable
{
    private BancoContext contexto;

    public ProdutoDao()
    {
        this.contexto = new BancoContext();
    }

    public BancoContext GetContext()
    {
        return contexto;
    }

    public IList<Produto> Produtos()
    {
        return contexto.Produtos.ToList();
    }

    public void Remove(Produto p)
    {
        contexto.Produtos.Remove(p);
        contexto.SaveChanges();
    }

    public void Dispose()
    {
        contexto.Dispose();
    }

    public void Update(Produto p)
    {
        ChangeTrackerVisualizar();
        contexto.Produtos.Update(p);
        ChangeTrackerVisualizar();
        contexto.SaveChanges();
    }

    public void Add(Produto p)
    {
        ChangeTrackerVisualizar();
        contexto.Produtos.Add(p); 
        ChangeTrackerVisualizar();
        contexto.SaveChanges();
    }

    public void AddRange(params Produto[] p)
    {
        contexto.Produtos.AddRange(p);
        contexto.SaveChanges();
    }

    public void ChangeTrackerVisualizar()
    {
        Console.WriteLine("==================================");
        Console.WriteLine("===========  State  ==============");
        Console.WriteLine("==================================");
        foreach (var e in contexto.ChangeTracker.Entries())
        {
            Console.WriteLine(e);
            Console.WriteLine(e.State);
        }     
    }
}
