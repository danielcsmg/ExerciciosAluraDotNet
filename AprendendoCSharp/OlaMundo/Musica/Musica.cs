namespace OlaMundo.Musica;

public class Musica
{
    public IList<KeyValuePair<INota, int>> Musica1()
    {
        NotasMusicais notas = new NotasMusicais();

        IList<KeyValuePair<INota, int>> doReMiFa = new List<KeyValuePair<INota, int>>() {
            notas.Pega("do", 300),
            notas.Pega("re", 300),
            notas.Pega("mi", 300),
            notas.Pega("fa", 300),
            notas.Pega("fa", 300),
            notas.Pega("fa", 300),

            notas.Pega("do", 300),
            notas.Pega("re", 300),
            notas.Pega("do", 300),
            notas.Pega("re", 300),
            notas.Pega("re", 300),
            notas.Pega("re", 300),

            notas.Pega("do", 300),
            notas.Pega("sol", 300),
            notas.Pega("fa", 300),
            notas.Pega("mi", 300),
            notas.Pega("mi", 300),
            notas.Pega("mi", 300),

            notas.Pega("do", 300),
            notas.Pega("re", 300),
            notas.Pega("mi", 300),
            notas.Pega("fa", 300),
            notas.Pega("fa", 300),
            notas.Pega("fa", 300)
        };

        return doReMiFa;
    }
}
