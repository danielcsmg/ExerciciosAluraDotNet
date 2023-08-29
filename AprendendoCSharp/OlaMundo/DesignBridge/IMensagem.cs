public interface IMensagem
{
    public IEnviador Enviador { get; set; }
    public void Envia();
    string Formata();
}