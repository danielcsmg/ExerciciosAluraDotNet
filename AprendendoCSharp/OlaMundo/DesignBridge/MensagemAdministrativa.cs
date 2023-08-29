namespace OlaMundo.DesignBridge;

public class MensagemAdministrativa : IMensagem
{
    public IEnviador Enviador { get; set; }

    private string _nome;

    public MensagemAdministrativa(string nome)
    {
        _nome = nome;
    }

    public void Envia()
    {
        Enviador.Envia(this);
    }

    public string Formata()
    {
        return String.Format($"Mensagem para o adm {_nome}");
    }
}
