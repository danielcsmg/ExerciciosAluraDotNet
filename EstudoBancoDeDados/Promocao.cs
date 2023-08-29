using System.ComponentModel.DataAnnotations;

namespace EstudoBancoDeDados;
public class Promocao
{
    [Key]
    public int Id { get; set; }
    public DateTime DataDeInicio { get; set; }
    public DateTime DataDeFim { get; set; }
    public string Descricao { get; set; }
    public IList<PromocaoProduto> PromocaoProduto { get; set; }
}
