using System.Text;
using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        //LerArquivo();
        EscreverArquivo();
    }

    static void EscreverArquivo()
    {
        var criar = new CriarArquivoExemplo();
        criar.CriarArquivo();
    }

    static void LerArquivo()
    {
        var enderecoDoArquivo = "contas.txt";
        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        var leitor = new StreamReader(fluxoDoArquivo);

        while (!leitor.EndOfStream)
        {
            var linha = leitor.ReadLine();
            var contaCorrente = ConverterStringConta(linha);

            contaCorrente.MostrarMensagem();
        }
    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        var utf8 = new UTF8Encoding();
        var texto = utf8.GetString(buffer, 0, bytesLidos);

        Console.Write(texto);
    }

    static ContaCorrente ConverterStringConta(string linha)
    {
        var campos = linha.Split(',');

        var agencia = campos[0];
        var numero = campos[1];
        var saldo = campos[2];
        var nomeTitular = campos[3];

        var agenciaToInt = int.Parse(agencia);
        var numeroToInt = int.Parse(numero);
        var saldoToDouble = double.Parse(saldo.Replace(".", ","));

        var titular = new Cliente();
        titular.Nome = nomeTitular;

        var resultado = new ContaCorrente(agenciaToInt, numeroToInt);
        resultado.Depositar(saldoToDouble);
        resultado.Titular = titular;

        return resultado;
    }
}