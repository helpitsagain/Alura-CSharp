using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmesApi.Modelos;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Dados;

public class FilmeContexto : DbContext
{
	public FilmeContexto(DbContextOptions<FilmeContexto> opcoes)
		:base(opcoes)
	{
		
	}

	public DbSet<Filme> Filmes { get; set; }
}