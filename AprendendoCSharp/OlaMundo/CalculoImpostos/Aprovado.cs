namespace OlaMundo.CalculoImpostos;

internal class Aprovado : EstadoDeUmOrcamento
{
    private bool _descontoAplicado = false;
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        if (_descontoAplicado)
        {
            throw new ApplicationException("Desconto já foi aplicado.");
        }
        orcamento.Valor *= 0.98;
        _descontoAplicado = DescontoJaAplicado();
    }

    public void Aprova(Orcamento orcamento)
    {
        throw new ApplicationException("Já está aprovado.");
    }

    public void Finaliza(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Finalizado();
    }

    public void Reprova(Orcamento orcamento)
    {
        throw new ApplicationException("Já está aprovado.");
    }

    private bool DescontoJaAplicado()
    {
        return true;
    }
}