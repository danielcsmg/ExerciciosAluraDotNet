public class Pedido
{
    public string Cliente { get; internal set; }
    public double Valor { get; internal set; }
    public Status Status { get; internal set; }
    public DateTime DataFinalizacao { get; internal set; }

    public Pedido(string nome, double valor)
    {
        Cliente = nome;
        Valor = valor;
        Status = Status.Novo;
    }

    public void Paga()
    {
        Status = Status.Pago;
    }

    public void Finaliza()
    {
        Status = Status.Entregue;
        DataFinalizacao = DateTime.Now;
    }
}