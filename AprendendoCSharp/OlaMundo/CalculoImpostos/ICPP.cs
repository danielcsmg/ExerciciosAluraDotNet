namespace OlaMundo.CalculoImpostos;
class ICPP : TemplateDeImpostoCondicional
{
    public ICPP() : base() { }
    public ICPP(Imposto OutroImposto) : base(OutroImposto) { }

    public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor > 500;
    }
    public override double MaximaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.07 + CalculaOutroImposto(orcamento);
    }
    public override double MinimaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.05 + CalculaOutroImposto(orcamento);
    }
}
