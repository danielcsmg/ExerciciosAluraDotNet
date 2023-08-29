namespace OlaMundo.CalculoImpostos;

public interface EstadoDeUmOrcamento
{
    void AplicaDescontoExtra(Orcamento orcamento);
    void Aprova(Orcamento orcamento);
    void Reprova(Orcamento orcamento);
    void Finaliza(Orcamento orcamento);
}