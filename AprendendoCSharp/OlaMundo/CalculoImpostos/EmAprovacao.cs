namespace OlaMundo.CalculoImpostos;

internal class EmAprovacao : EstadoDeUmOrcamento
{
    private bool _descontoAplicado = false;
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        if (_descontoAplicado)
        {
            throw new ApplicationException("Desconto já foi aplicado.");
        }
        orcamento.Valor *= 0.95;
        _descontoAplicado = DescontoJaAplicado();
    }

    private bool DescontoJaAplicado()
    {
        return true;
    }

    public void Aprova(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Aprovado();
    }

    public void Finaliza(Orcamento orcamento)
    {
        throw new ApplicationException("Não pode ser finalizado sem aprovação.");
    }

    public void Reprova(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Reprovado();
    }

}