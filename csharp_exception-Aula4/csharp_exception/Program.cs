using csharp_exception.Titular;
using csharp_exception.Contas;
using csharp_exception;

#region Aulas anteriores
//try
//{
//    LeitorDeArquivo leitor = new LeitorDeArquivo("Texto que estamos lendo...");
//    leitor.LerProximaLinha();
//    leitor.LerProximaLinha();
//    leitor.LerProximaLinha();
//    leitor.Dispose();
//    var text = Console.ReadLine();
//    int[] meuArray = new int[5] 
//    { 
//        1, 2, 3, 4, 5 
//    };
//}
//catch (IOException)
//{
//    Console.WriteLine("Leitura interrompida...");
//}
//finally
//{

//}

//var teste = new Teste();
//teste.lista[0] = "aa";
//teste.lista[1] = "bb";
//teste.lista[2] = "cc";
//teste.lista[3] = "dd";
//teste.lista[4] = "ee";

//Console.WriteLine(teste[2]);
//Console.WriteLine(teste[3]);
//Console.WriteLine(teste[0]);


//public class Teste
//{
//    public string[] lista = new string[5];
//    // Cria uma referência da classe indexável, ou seja, cria um meio de buscar e criar um objeto de array.
//    public string this[int i]
//    {
//        get
//        {
//            return lista[i];
//        }
//    }
//}

//try
//{
//    ContaCorrente conta1 = new ContaCorrente(0, "1234-X");
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine("Parâmetro com erro" + ex.ParamName);
//    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
//    Console.WriteLine(ex.Message);

//}
#endregion


[Serializable]
public class MyException : Exception
{
	public MyException() { }
	public MyException(string message) : base(message) { }
	public MyException(string message, Exception inner) : base(message, inner) { }
	protected MyException(
	  System.Runtime.Serialization.SerializationInfo info,
	  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}
