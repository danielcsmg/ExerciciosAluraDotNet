namespace OlaMundo.CalculoImpostos;

internal class Reprovado : EstadoDeUmOrcamento
{
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        throw new ApplicationException("Orçamento reprovado. Não é possível aplicar desconto.");
    }

    public void Aprova(Orcamento orcamento)
    {
        throw new ApplicationException("Já está reprovado. Não é possível aprová-lo.");
    }

    public void Finaliza(Orcamento orcamento)
    {
        orcamento.EstadoAtual = new Finalizado();
    }

    public void Reprova(Orcamento orcamento)
    {
        throw new ApplicationException("Já está reprovado.");
    }
}