using ByteBankIO.Modelos;
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
        static void UsarStreamReader(string caminho) 
        {
			var enderecoDoArquivo = caminho;

			using(var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
			using(var leitor = new StreamReader(fluxoDoArquivo))
			{
				while (!leitor.EndOfStream)
				{
					var linha = leitor.ReadLine();
					Console.WriteLine(linha);
				}
			}
		}
    }
}
