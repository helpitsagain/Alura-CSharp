using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO
{
    partial class Program
    {
		static void CriarArquivo()
		{
			var caminhoNovoArquivo = "../contasExportadas.csv";

			using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
			{
				var contaComoString = "42,1337,87950.23,Luc Michels";
				var encoding = Encoding.UTF8;
				var bytes = encoding.GetBytes(contaComoString);

				fluxoDeArquivo.Write(bytes, 0, bytes.Length);
			}
		}

		static void CriarArquivoComWriter()
		{
			var caminhoNovoArquivo = "../contasExportadas.csv";

			using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.OpenOrCreate))
			using(var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
			{
				escritor.Write("42,1337,87950.23,Luc Michels");
				Console.WriteLine("Execução finalizada!!");
			}
		}
    }
}
