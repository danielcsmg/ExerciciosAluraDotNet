public class Raiz : IExpressao
{
    private IExpressao _numero;

    public Raiz(IExpressao numero)
    {
        _numero = numero;
    }

    public void Aceita(IVisitor impressora)
    {
        throw new NotImplementedException();
    }

    public int Avalia()
    {
        var numero = _numero.Avalia();
        if (numero < 0)
        {
            throw new ArgumentException("Não é possível encontrar a raiz de número negativo.");
        }

        return (int)Math.Sqrt(numero);
    }
}