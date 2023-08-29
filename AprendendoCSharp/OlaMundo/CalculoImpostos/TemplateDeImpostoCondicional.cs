namespace OlaMundo.CalculoImpostos;

public abstract class TemplateDeImpostoCondicional : Imposto
{
    public TemplateDeImpostoCondicional() : base() { }
    
    public TemplateDeImpostoCondicional(Imposto OutroImposto) : base(OutroImposto) { }
    override public double Calcula(Orcamento orcamento)
    {
        if (DeveUsarMaximaTaxacao(orcamento))
        {
            return MaximaTaxacao(orcamento);
        }

        return MinimaTaxacao(orcamento);
    }

    public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
    public abstract double MaximaTaxacao(Orcamento orcamento);
    public abstract double MinimaTaxacao(Orcamento orcamento);
}