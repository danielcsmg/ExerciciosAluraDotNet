namespace OlaMundo.CalculoImpostos;

public class IHIT : TemplateDeImpostoCondicional
{
    public IHIT() : base() { }
    public IHIT(Imposto OutroImposto) : base(OutroImposto) { }

    public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor > 500 && TemMaisDeDoisItensDeMesmoNome(orcamento);
    }
    public override double MaximaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.13 + 100.0 + CalculaOutroImposto(orcamento);
    }
    public override double MinimaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.1; // * orcamento.Itens.Count() + CalculaOutroImposto(orcamento);
    }

    private bool TemMaisDeDoisItensDeMesmoNome(Orcamento orcamento)
    {
        //var cont = 0;
        //foreach(var item in orcamento.Itens)
        //{
        //    cont++;
        //    if(cont >= orcamento.Itens.Count())
        //    {
        //        return false;
        //    }

        //    if (orcamento.Itens.Skip(cont).Any(i => item.Nome.Equals(i.Nome)))
        //    {
        //        return true;
        //    }
        //}
        return false;
    }
}
