using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FilmesApi.Dados;
using FilmesApi.Modelos;

namespace FilmesApi.Perfis;

public class FilmePerfil : Profile
{
	public FilmePerfil()
	{
		CreateMap<CriarFilmeDto, Filme>();
	}
}