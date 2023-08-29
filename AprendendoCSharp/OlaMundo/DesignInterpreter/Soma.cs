public class Soma : IExpressao
{
    public IExpressao Esquerda { get; private set; }
    public IExpressao Direita { get; private set; }

    public Soma(IExpressao esquerda, IExpressao direita)
    {
        Esquerda = esquerda;
        Direita = direita;
    }

    public int Avalia()
    {
        int direita = Direita.Avalia();
        int esquerda = Esquerda.Avalia();
        return esquerda + direita;
    }

    public void Aceita(IVisitor impressora)
    {
        impressora.ImprimeSoma(this);
    }
}