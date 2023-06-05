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
	public static List<Filme> filmes = new List<Filme>();

	[HttpPost]
	public void AdicionarFilme([FromBody] Filme filme)
	{
		filmes.Add(filme);
		Console.WriteLine($"Título: {filme.Titulo}\nDuração: {filme.Duracao} minutos.");
	}
}