﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateCinemaDto
{
    [Required(ErrorMessage = "Campo de nome obrigatório.")]
    public string Nome { get; set; }
}
