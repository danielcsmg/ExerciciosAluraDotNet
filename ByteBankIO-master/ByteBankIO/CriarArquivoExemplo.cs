using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO;

public class CriarArquivoExemplo
{
    public string caminhoArquivo = "textoescrito.txt";

    public void CriarArquivo()
    {
        Console.WriteLine("Bem vindo!");
        var i = 0;
        using(var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            while(true)
            {

                var escrita = $"linha {i} foi escrita...";

                escritor.WriteLine(escrita);

                escritor.Flush();

                Console.ReadLine();

                Console.WriteLine(escrita);

                i++;
            }
        }
    }
}
