using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using AutoMapper;
using FilmesApi.Dados;
using FilmesApi.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]

public class FilmeControllers : ControllerBase
{
	private FilmeContexto _contexto;
	private IMapper _mapper;

	public FilmeControllers(FilmeContexto contexto, IMapper mapper)
	{
		_contexto = contexto;
		_mapper = mapper;
	}

	[HttpPost]
	public IActionResult AdicionarFilme([FromBody] CriarFilmeDto filmeDto)
	{
		Filme filme = _mapper.Map<Filme>(filmeDto);
		_contexto.Filmes.Add(filme);
		_contexto.SaveChanges();

		Console.WriteLine($"Título: {filme.Titulo} | Duração: {filme.Duracao} minutos | ID: #{filme.Id}");
		
		return CreatedAtAction(nameof(RecuperarFilmePorId), 
			new { id = filme.Id }, 
			filme);
	}

	[HttpGet]
	public IEnumerable<Filme> RecuperarFilmes([FromQuery] int skip = 0,
		[FromQuery] int take = 10)
	{
		return _contexto.Filmes.Skip(skip).Take(take);		
	}

	[HttpGet("{id}")]
	public IActionResult? RecuperarFilmePorId(int id)
	{
		var filme = _contexto.Filmes.FirstOrDefault(filme => filme.Id == id);
		
		if(filme == null) return NotFound();

		return Ok(filme);
	}
}