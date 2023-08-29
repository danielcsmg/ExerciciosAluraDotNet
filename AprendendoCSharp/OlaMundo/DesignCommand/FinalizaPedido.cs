using OlaMundo.DesignCommand;

internal class FinalizaPedido : ICommand
{
    private Pedido _pedido;

    public FinalizaPedido(Pedido pedido)
    {
        _pedido = pedido;
    }

    public void Executa()
    {
        _pedido.Finaliza();
        Console.WriteLine(_pedido.Status.ToString());
    }
}