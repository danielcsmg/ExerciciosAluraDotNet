public class TesteMain
{
    static void Main()
    {
        Cliente cliente = new Cliente();
        cliente.Nome = "victor";
        cliente.Endereco = "Rua Vergueiro";
        cliente.DataDeNascimento = DateTime.Now;

        GeradorDeXml gerador = new GeradorDeXml();
        var xml = gerador.GeraXml(cliente);

        Console.WriteLine(xml);
    }
}