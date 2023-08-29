namespace OlaMundo.CalculoImpostos;

public class Orcamento
{
    public double Valor { get; set; }
    public EstadoDeUmOrcamento EstadoAtual { get; set; }

    public Orcamento(double valor)
    {
        this.EstadoAtual = new EmAprovacao();
        Valor = valor;
    }

    public void AplicaDescontoExtra()
    {
        EstadoAtual.AplicaDescontoExtra(this);
    }

    public void Aprova()
    {
        EstadoAtual.Aprova(this);
    }

    public void Reprova()
    {
        EstadoAtual.Reprova(this);
    }

    public void Finaliza()
    {
        EstadoAtual.Finaliza(this);
    }
}