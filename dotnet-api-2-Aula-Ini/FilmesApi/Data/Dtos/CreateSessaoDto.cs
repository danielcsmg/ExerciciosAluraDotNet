using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateSessaoDto
{
    [Required(ErrorMessage = "Campo de id do filme obrigatório.")]
    public int FilmeAPIId { get; set; }
    [Required(ErrorMessage = "Campo de id do cinema obrigatório.")]
    public int CinemaId { get; set; }
}
