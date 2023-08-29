namespace OlaMundo.Musica;

public class Piano
{
    public static void Toca(IList<KeyValuePair<INota, int>> notas)
    {
        foreach (var nota in notas)
        {
            Console.Beep(nota.Key.Frequencia, nota.Value);
        }
    }
}
