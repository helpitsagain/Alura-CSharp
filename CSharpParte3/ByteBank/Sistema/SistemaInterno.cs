using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank.Sistema
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string senha)
		{
			bool usuarioAutenticado = funcionario.Autenticar(senha);

			if (!usuarioAutenticado)
			{
				Console.WriteLine("Senha inválida.");
				return false;
			}

			Console.WriteLine("Bem-vindo ao sistema!");
			return true;
		}
    }
}