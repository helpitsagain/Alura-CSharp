using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Cliente
    {
		public string? Nome { get; set; }
		public string? CPF { get; set; }
		public string? Profissao { get; set; }

		public Cliente(string cpf)
		{
			CPF = cpf;
		}
    }
}