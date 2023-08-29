namespace OlaMundo.Notas;

public class NotasBuilder
{
}
class NotaFiscalBuilder
{
    public string Cnpj { get; internal set; }
    public DateTime Data { get; internal set; }
    public double Impostos { get; internal set; }
    public string Observacoes { get; internal set; }
    public string RazaoSocial { get; internal set; }
    public double ValorTotal { get; internal set; }
    public IList<ItemDaNota> TodosItens { get; internal set; } = new List<ItemDaNota>();

    public NotaFiscal Constroi()
    {
        return new NotaFiscal(Cnpj, Data, Impostos, Observacoes, RazaoSocial, ValorTotal, TodosItens);
    }
    public NotaFiscalBuilder ParaEmpresa(string razaoSocial) 
    {
        RazaoSocial = razaoSocial;
        return this; // retorno eu mesmo, o próprio builder, para que o cliente continue utilizando
    }

    public NotaFiscalBuilder ComCnpj(string cnpj) 
    {
        Cnpj = cnpj;
        return this;
    }

    public NotaFiscalBuilder ComItem(ItemDaNota item) 
    {
        TodosItens.Add(item);
        ValorTotal += item.Valor;
        Impostos += item.Valor * 0.05;
        return this;
    }

    public NotaFiscalBuilder NaData(DateTime date) 
    {
        Data = date;
        return this;
    }

    public NotaFiscalBuilder ComObservacao(string obs) 
    {
        Observacoes = obs;
        return this;
    }

    public NotaFiscalBuilder ComRazaoSocial(string razaoSocial) 
    {
        RazaoSocial = razaoSocial;
        return this;
    }
}

