using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Dados;

public class CriarFilmeDto
{
	[Required(ErrorMessage = "O título do filme é obrigatório!")]
	public string Titulo { get; set; }

	[Required(ErrorMessage = "O gênero do filme é obrigatório!")]
	[StringLength(50, ErrorMessage = "O gênero do filme não deve exceder 50 caracteres.")]
	public string Genero { get; set; }
	
	[Required(ErrorMessage = "A duração do filme é obrigatória!")]
	[Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
	public int Duracao { get; set; }
}