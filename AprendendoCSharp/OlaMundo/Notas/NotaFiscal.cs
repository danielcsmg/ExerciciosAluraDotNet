namespace OlaMundo.Notas;

public class NotaFiscal
{
    public string Cnpj { get; internal set; }
    public DateTime Data { get; internal set; }
    public double Impostos { get; internal set; }
    public string Observacoes { get; internal set; }
    public string RazaoSocial { get; internal set; }
    public double ValorTotal { get; internal set; }
    public IList<ItemDaNota> TodosItens { get; internal set; } = new List<ItemDaNota>();

    public NotaFiscal(string cnpj, DateTime data, double impostos, string observacoes, string razaoSocial, double valorTotal, IList<ItemDaNota> todosItens)
    {
        TodosItens = todosItens;
        Cnpj = cnpj;
        Data = data;
        Impostos = impostos;
        Observacoes = observacoes;
        RazaoSocial = razaoSocial;
        ValorTotal = valorTotal;
    }
}