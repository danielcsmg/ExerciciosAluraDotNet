namespace OlaMundo.CalculoImpostos;

class IKCV : TemplateDeImpostoCondicional
{
    public IKCV() : base() { }
    public IKCV(Imposto OutroImposto) : base(OutroImposto) { }
    public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor > 500 && TemItemMaiorQue100ReaisNo(orcamento);
    }
    public override double MaximaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.10 + CalculaOutroImposto(orcamento);
    }
    public override double MinimaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.06 + CalculaOutroImposto(orcamento);
    }

    private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento)
    {
        //return orcamento.Itens.Any(i => i.Valor >= 100.0);
        return false;
    }
}