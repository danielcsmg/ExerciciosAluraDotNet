namespace OlaMundo.Musica;

public class NotasMusicais
{
    private static IDictionary<string, INota> notas =
        new Dictionary<string, INota>()
        {
            { "do", new Do() },
            { "re", new Re() },
            { "mi", new Mi() },
            { "fa", new Fa() },
            { "sol", new Sol() },
            { "la", new La() },
            { "si", new Si() }
        };

    public KeyValuePair<INota, int> Pega(string nome, int tempo)
    {
        return new KeyValuePair<INota, int>(notas[nome], tempo);
    }
}
