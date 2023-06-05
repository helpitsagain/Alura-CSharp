using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.ContaCorrente
{
    public class Cliente
    {
		public string? Nome { get; set; } = "";
		public string? CPF { get; }
		public string? Profissao { get; set; }

		// public Cliente()
		// {
		// 	Console.Write("Insira o CPF do cliente: ");
		// 	string cpf = Console.ReadLine();
		// 	if (cpf == "")
		// 	{
		// 		throw new ArgumentException($"O campo {nameof(cpf)} precisa ser informado.", nameof(cpf));
		// 	}

		// 	Console.Write("Insira o nome do cliente: ");
		// 	string nome = Console.ReadLine();
		// 	if (nome == "")
		// 	{
		// 		throw new ArgumentException($"O campo {nameof(nome)} precisa ser informado.",nameof(nome));
		// 	}

		// 	Nome = nome;
		// 	CPF = cpf;
		// }
    }
}