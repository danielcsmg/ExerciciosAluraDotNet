public class Multiplicacao : IExpressao
{
    private IExpressao _esquerda;
    private IExpressao _direita;

    public Multiplicacao(IExpressao esquerda, IExpressao direita)
    {
        _esquerda = esquerda;
        _direita = direita;
    }

    public void Aceita(IVisitor impressora)
    {
        throw new NotImplementedException();
    }

    public int Avalia()
    {
        int direita = _direita.Avalia();
        int esquerda = _esquerda.Avalia();
        return esquerda * direita;
    }
}
