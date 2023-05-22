using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Modelos.Sistema;

namespace ByteBank.Modelos
{
	public class ParceiroComercial : IAutenticavel
	{
		private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
		public string? Senha { get; set; }

		public bool Autenticar(string senha)
		{
			return _autenticacaoHelper.CompararSenhas(this.Senha, senha);
		}
	}
}