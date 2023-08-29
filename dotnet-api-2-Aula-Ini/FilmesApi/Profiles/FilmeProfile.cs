using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles;

public class FilmeProfile : Profile
{
	public FilmeProfile()
	{
		CreateMap<CreateFilmeDto, FilmeAPI>();
        CreateMap<UpdateFilmeDto, FilmeAPI>();
        CreateMap<FilmeAPI, UpdateFilmeDto>();
        CreateMap<FilmeAPI, ReadFilmeDto>()
            .ForMember(filmeDto => filmeDto.Sessoes,
            opt => opt.MapFrom(filme => filme.Sessoes));
    }
}
