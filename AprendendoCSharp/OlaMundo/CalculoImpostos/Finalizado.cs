namespace OlaMundo.CalculoImpostos;

internal class Finalizado : EstadoDeUmOrcamento
{
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        throw new ApplicationException("Orçamento finalizado. Não é possível aplicar desconto.");
    }

    public void Aprova(Orcamento orcamento)
    {
        throw new ApplicationException("Orçamento finalizado. Entre em contato com o adm.");
    }

    public void Finaliza(Orcamento orcamento)
    {
        throw new ApplicationException("Orçamento finalizado. Entre em contato com o adm.");
    }

    public void Reprova(Orcamento orcamento)
    {
        throw new ApplicationException("Orçamento finalizado. Entre em contato com o adm.");
    }
}