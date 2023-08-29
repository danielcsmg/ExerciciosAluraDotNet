using OlaMundo.CalculoImpostos;

namespace OlaMundo.OrcamentoAtividade;

public interface IDesconto
{
    double Desconta(Orcamento orcamento);
    public IDesconto Proximo { get; set; }
}

public class DescontoPorMaisDeQuinhentosReais : IDesconto
{
    public IDesconto Proximo { get; set; }

    public DescontoPorMaisDeQuinhentosReais(IDesconto proximo)
    {
        Proximo = proximo;
    }

    public double Desconta(Orcamento orcamento)
    {
        if (orcamento.Valor > 500)
        {
            return orcamento.Valor * 0.07;
        }

        return Proximo.Desconta(orcamento);
    }
}

public class DescontoParaMaisDeCincoItens : IDesconto
{
    public IDesconto Proximo { get; set; }

    public DescontoParaMaisDeCincoItens(IDesconto proximo)
    {
        Proximo = proximo;
    }

    public double Desconta(Orcamento orcamento)
    {
        //if (orcamento.Itens.Count > 5)
        //{
        //    return orcamento.Valor * 0.1;
        //}

        return Proximo.Desconta(orcamento);
    }
}

public class SemDesconto : IDesconto
{
    public IDesconto Proximo { get; set; }

    public double Desconta(Orcamento orcamento)
    {
        return 0;
    }
}

public class CalculadorDeDescontos
{
    public static double Calcula(Orcamento orcamento)
    {
        IDesconto d4 = new SemDesconto();
        IDesconto d3 = new DescontoPorVendaCasada(d4);
        IDesconto d2 = new DescontoPorMaisDeQuinhentosReais(d3);
        IDesconto d1 = new DescontoParaMaisDeCincoItens(d2);

        return d1.Desconta(orcamento);
    }
}

internal class DescontoPorVendaCasada : IDesconto
{
    public IDesconto Proximo { get; set; }

    public DescontoPorVendaCasada(IDesconto proximo)
    {
        Proximo = proximo;
    }

    public double Desconta(Orcamento orcamento)
    {
        //var orcamentoContemLapis = orcamento.Itens.Any(i => i.Nome == "LAPIS");
        //var orcamentoContemCaneta = orcamento.Itens.Any(i => i.Nome == "CANETA");

        //if (orcamentoContemCaneta && orcamentoContemLapis)
        //{
        //    return orcamento.Valor * 0.05;
        //}

        return Proximo.Desconta(orcamento);
    }
}

public static class CalculandoDesconto
{
    public static void CalcularDescontoDoOrcamento()
    {
        Orcamento orcamento = new(100.0);
        //orcamento.AdicionaItem(new("CANETA", 250.0));
        //orcamento.AdicionaItem(new("LAPIS", 250.0));
        //orcamento.AdicionaItem(new("PAPEL", 250.0));
        //orcamento.AdicionaItem(new("CANETA AZUL", 250.0));

        var desconto = CalculadorDeDescontos.Calcula(orcamento);

        Console.WriteLine(desconto);
    }
}