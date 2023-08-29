namespace FilmesApi.Models;

public class Sessao
{
    public int Id { get; set; }
    public int FilmeAPIId { get; set; }
    public virtual FilmeAPI FilmeAPI { get; set; }
    public int? CinemaId { get; set; }
    public virtual Cinema Cinema { get; set; }

}
