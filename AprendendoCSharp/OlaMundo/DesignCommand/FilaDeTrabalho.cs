using OlaMundo.DesignCommand;

public class FilaDeTrabalho
{
    private IList<ICommand> _comandos = new List<ICommand>();

    public void Adiciona(ICommand comando)
    {
        _comandos.Add(comando);
    }

    public void Processa()
    {
        foreach (var comando in _comandos)
        {
            comando.Executa();
        }
    }
}