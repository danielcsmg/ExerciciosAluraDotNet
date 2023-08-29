using EstudoBancoDeDados;
using EstudoBancoDeDados.Models;

var sair = false;

while (!sair)
{

    Console.WriteLine("Opções:");
    Console.WriteLine("Consultar Produtos - tecle '0'");
    Console.WriteLine("Salvar Produto - tecle '1'");
    Console.WriteLine("Editar Produto - tecle '2'");
    Console.WriteLine("Deletar Produtos - tecle '3'");
    Console.WriteLine("Deletar Todos Os Produtos - tecle '4'");
    Console.WriteLine("Testar Add, Remove E Change Tracker - tecle '5'");
    Console.WriteLine("Sair - aperte qualquer tecla");

    var opt = Console.ReadLine();
    switch (opt)
    {
        case "0":
            {
                ConsultarProduto();
                break;
            }
        case "1":
            {
                SalvarProduto();
                break;
            }
        case "2":
            {
                EditarProduto();
                break;
            }
        case "3":
            {
                DeletarProdutos();
                break;
            }
        case "4":
            {
                DeletarTodosOsProdutos();
                break;
            }
        case "5":
            {
                TestarAddRemoveEChangeTracker();
                break;
            }
        default:
            {
                sair = true;
                break;
            }
    }
};

void EditarProduto()
{
    using (var repo = new ProdutoDao())
    {
        IList<Produto> produtos = repo.Produtos();

        var produto = produtos.FirstOrDefault();
        produto.Nome = "Valor Editado";
        produto.Categoria = "Categoria Editada";
        repo.Update(produto);
    }
}

void DeletarProdutos()
{
    using (var repo = new ProdutoDao())
    {
        IList<Produto> produtos = repo.Produtos();

        foreach (var produto in produtos)
        {
            if (produto.Categoria == "Alimento")
                repo.Remove(produto);
        }
    }
}
void DeletarTodosOsProdutos()
{
    using (var repo = new ProdutoDao())
    {
        IList<Produto> produtos = repo.Produtos();

        foreach (var produto in produtos)
        {
            repo.Remove(produto);
        }
    }
}

void TestarAddRemoveEChangeTracker()
{
    var prod = new Produto()
    {
        Nome = "Prod Novo",
        Categoria = "Categ Nova",
        PrecoUnitario = 1.39
    };

    using (var repo = new ProdutoDao())
    {
        repo.GetContext().Produtos.Add(prod);
        repo.ChangeTrackerVisualizar();
        repo.GetContext().Produtos.Remove(prod);
        repo.ChangeTrackerVisualizar();
        Console.WriteLine("###################\n\n\n\n");
        var entry = repo.GetContext().Entry(prod);
        Console.WriteLine(entry.State);
        repo.GetContext().SaveChanges();
        Console.WriteLine("\n\n\n\n\n###################");

        entry = repo.GetContext().Entry(prod);
        Console.WriteLine(entry.State);
    }
}

void ConsultarProduto()
{
    using (var repo = new ProdutoDao())
    {
        IList<Produto> produtos = repo.Produtos();

        Console.WriteLine($"Quantidade de itens: {produtos.Count()}.");

        foreach (var produto in produtos)
        {
            Console.WriteLine($"{produto.Nome} - {produto.PrecoUnitario}");
        }
    }
}

void SalvarProduto()
{
    var prod = new Produto();
    var prod2 = new Produto();
    var prod3 = new Produto();
    var prod4 = new Produto();

    prod.Nome = "Uno";
    prod.Categoria = "Carro";
    prod.PrecoUnitario = 13_000.30;

    prod2.Nome = "Lili";
    prod2.Categoria = "Boneca";
    prod2.PrecoUnitario = 80.34;

    prod3.Nome = "Alface";
    prod3.Categoria = "Alimento";
    prod3.PrecoUnitario = 1.76;

    prod4.Nome = "Cimento";
    prod4.Categoria = "Material de Construção";
    prod4.PrecoUnitario = 36.41;

    using (var repo = new ProdutoDao())
    {
        repo.Add(prod);
        repo.AddRange(prod2, prod3, prod4);
    }
}
