using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_GeradorDeChavePix;

/// <summary>
/// Classe que gera chave PIX
/// </summary>
public static class GeradorPix
{
    /// <summary>
    /// Método que retorna chave PIX aleatória
    /// </summary>
    /// <returns>Retorna uma chaves no formato string.</returns>
    public static string GetChavePix()
    {
        return Guid.NewGuid().ToString();
    }

    /// <summary>
    /// Método que retorna chaves PIX aleatórias
    /// </summary>
    /// <param name="numerChaves">Número de chaves a serem geradas.</param>
    /// <returns>Lista de chaves no formato de Lista de strings.</returns>
    public static List<string> GetChavePix(int numeroChave)
    {
        if (numeroChave <= 0)
        {
            return null;
        }
        else
        {
            var chaves = new List<string>();
            for (int i = 0; i < numeroChave; i++)
            {
                chaves.Add(Guid.NewGuid().ToString());
            }
            return chaves;
        }
    }
}
