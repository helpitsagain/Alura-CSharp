using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorArgumentosURL
    {
		private readonly string _argumentos;
		public string URL { get; }

		public ExtratorArgumentosURL(string url)
		{
			if (string.IsNullOrEmpty(url))
			{
				throw new ArgumentException("URL precisa ser informada.", nameof(url));
			}

			this.URL = url;
			int indiceInterrogacao = url.IndexOf('?');
			_argumentos = url.Substring(indiceInterrogacao + 1);
		}
    }
}