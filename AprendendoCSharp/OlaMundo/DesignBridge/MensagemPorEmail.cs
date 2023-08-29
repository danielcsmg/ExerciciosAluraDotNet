namespace OlaMundo.DesignBridge;

public class MensagemPorEmail : IEnviador
{
    public void Envia(IMensagem mensagem)
    {
        Console.WriteLine("Enviando mensagem por e-mail");
        Console.WriteLine(mensagem.Formata());
    }
}