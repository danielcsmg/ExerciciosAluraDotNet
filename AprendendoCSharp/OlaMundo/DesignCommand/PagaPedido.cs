using OlaMundo.DesignCommand;

public class PagaPedido : ICommand
{
    private Pedido _pedido;

    public PagaPedido(Pedido pedido)
    {
        _pedido = pedido;
    }

    public void Executa()
    {
        _pedido.Paga();
        Console.WriteLine(_pedido.Status.ToString());
    }
}