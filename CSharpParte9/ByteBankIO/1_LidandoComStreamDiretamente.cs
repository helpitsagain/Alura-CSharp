using ByteBankIO.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // IO = Input e Output

namespace ByteBankIO
{
    partial class Program
    {
        static void LidandoComFileStreamDiretamente(string caminho)
        {
			var enderecoDoArquivo = caminho;
			var contaIteracoes = 0;

			using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
			{
				var buffer = new byte[1024]; // 1 kb
				var bytesLidos = -1;

				while(bytesLidos != 0)
				{
					contaIteracoes++;
					bytesLidos = fluxoDoArquivo.Read(buffer, 0, buffer.Length);
					EscreverBuffer(buffer, bytesLidos);
				}
			}

			Console.WriteLine($"\nTotal de iterações: {contaIteracoes}");
        }

		static void EscreverBuffer(byte[] buffer, int bytesLidos)
		{
			var utf8 = new UTF8Encoding();
			var texto = utf8.GetString(buffer, 0, bytesLidos);
			
			Console.WriteLine(texto);
		}
    }
}