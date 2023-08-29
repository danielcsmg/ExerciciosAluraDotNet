public class Divisao : IExpressao
{
    private IExpressao _esquerda;
    private IExpressao _direita;

    public Divisao(IExpressao esquerda, IExpressao direita)
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

        if (direita == 0)
        {
            throw new DivideByZeroException("Não é possível dividir por zero.");
        }

        return esquerda / direita;
    }
}
