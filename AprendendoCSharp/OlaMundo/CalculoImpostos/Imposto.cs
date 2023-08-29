namespace OlaMundo.CalculoImpostos;

public abstract class Imposto
{
    public readonly Imposto? OutroImposto;

    protected Imposto(Imposto outroImposto)
    {
        OutroImposto = outroImposto;
    }

    protected Imposto() {
        OutroImposto = null;
    }

    public abstract double Calcula(Orcamento orcamento);

    public double CalculaOutroImposto(Orcamento orcamento)
    {
        if (OutroImposto is null)
        {
            return 0;
        }

        return OutroImposto.Calcula(orcamento);
    }
}