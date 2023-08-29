using System.Collections.Generic;
using System.Linq;
using Alura.Filmes.App.Negocio;

namespace Alura.Filmes.App.Extensions
{
    public static class ClassificacaoExtensions
    {
        private static IDictionary<string, Classificacao> mapa = new Dictionary<string, Classificacao>
        {
            { "G", Classificacao.Livre },
            { "PG", Classificacao.MaiorQue10 },
            { "PG-13", Classificacao.MaiorQue13 },
            { "R", Classificacao.MaiorQue14 },
            { "NC-17", Classificacao.MaiorQue18 }
        };
        public static string ParaString(this Classificacao valor)
        {
            return mapa.FirstOrDefault(c => c.Value.Equals(valor)).Key;
        }

        public static Classificacao ParaValor(this string texto)
        {
            return mapa.FirstOrDefault(c => c.Key.Equals(texto)).Value;
        }
    }
}
