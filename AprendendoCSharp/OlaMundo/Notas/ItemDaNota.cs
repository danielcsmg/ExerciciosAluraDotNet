namespace OlaMundo.Notas;

public class ItemDaNota
{
    public string Nome { get; internal set; }
    public double Valor { get; internal set; }

    public ItemDaNota(string nome, double valor)
    {
        Nome = nome;
        Valor = valor;
    }
    public ItemDaNota() { }

    public ItemDaNota ComNome(string nome)
    {
        Nome = nome;
        return this;
    }

    public ItemDaNota ComValor(double valor)
    {
        Valor = valor;
        return this;
    }

    public ItemDaNota Constroi()
    {
        return new ItemDaNota(Nome, Valor);
    }
}