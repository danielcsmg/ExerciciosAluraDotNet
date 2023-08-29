public class Numero : IExpressao
{

    public int Valor;
    public Numero(int numero)
    {
        Valor = numero;
    }

    public void Aceita(IVisitor impressora)
    {
        impressora.ImprimeNumero(this);
    }

    public int Avalia()
    {
        return Valor;
    }
}