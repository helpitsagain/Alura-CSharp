using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using FilmesApi.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]

public class FilmeControllers : ControllerBase
{
	private static List<Filme> filmes = new List<Filme>();
	private static int id = 0;

	[HttpPost]
	public CreatedAtActionResult AdicionarFilme([FromBody] Filme filme)
	{
		filme.Id = id++;
		filmes.Add(filme);
		Console.WriteLine($"Título: {filme.Titulo} | Duração: {filme.Duracao} minutos | ID: #{filme.Id}");
		return CreatedAtAction(nameof(RecuperarFilmePorId), 
								new { id = filme.Id }, 
								filme);
	}

	[HttpGet]
	public IEnumerable<Filme> RecuperarFilmes([FromQuery] int skip = 0,
												[FromQuery] int take = 10)
	{
		return filmes.Skip(skip).Take(take);		
	}

	[HttpGet("{id}")]
	public IActionResult? RecuperarFilmePorId(int id)
	{
		var filme = filmes.FirstOrDefault(filme => filme.Id == id);
		
		if(filme == null) return NotFound();

		return Ok(filme);
	}
}