public class Impressora : IVisitor
{
    public void ImprimeSoma(Soma soma)
    {
        Console.Write("(");
        Console.Write("+ ");
        soma.Direita.Aceita(this);
        Console.Write(" ");
        soma.Esquerda.Aceita(this);
        Console.Write(")");
    }

    public void ImprimeSubtracao(Subtracao subtracao)
    {
        Console.Write("(");
        Console.Write("- ");
        subtracao.Direita.Aceita(this);
        Console.Write(" ");
        subtracao.Esquerda.Aceita(this);
        Console.Write(")");
    }

    public void ImprimeNumero(Numero numero)
    {
        Console.Write(numero.Valor);
    }
}