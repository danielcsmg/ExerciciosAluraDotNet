public class MensagemPorSMS : IEnviador
{
    public void Envia(IMensagem mensagem)
    {
        Console.WriteLine("Enviando mensagem por SMS");
        Console.WriteLine(mensagem.Formata());
    }
}