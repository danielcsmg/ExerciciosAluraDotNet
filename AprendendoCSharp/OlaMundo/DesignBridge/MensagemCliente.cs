namespace OlaMundo.DesignBridge;

public class MensagemCliente : IMensagem
{
    public IEnviador Enviador { get; set; }

    private string _nome;

    public MensagemCliente(string nome)
    {
        _nome = nome;
    }

    public void Envia()
    {
        Enviador.Envia(this);
    }

    public string Formata()
    {
        return String.Format($"Mensagem para o cliente {_nome}");
    }
}
