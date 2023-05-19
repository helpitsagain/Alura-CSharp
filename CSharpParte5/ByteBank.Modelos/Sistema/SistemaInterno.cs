using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.Modelos.Sistema
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel autenticavel, string senha)
		{
			bool usuarioAutenticado = autenticavel.Autenticar(senha);

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