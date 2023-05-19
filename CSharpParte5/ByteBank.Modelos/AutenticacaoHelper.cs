using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
	public class AutenticacaoHelper
	{
		internal bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
		{
			return senhaVerdadeira == senhaTentativa;
		}
	}
}