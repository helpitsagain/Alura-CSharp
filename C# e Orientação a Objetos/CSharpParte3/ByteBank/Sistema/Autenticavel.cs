using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank.Sistema
{
    public interface Autenticavel
    {
		public string? Senha { get; set; }

		public bool Autenticar(string senha)
		{
			return this.Senha == senha;
		}
    }
}