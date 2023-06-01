using ByteBankIO.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // IO = Input e Output
using System.Globalization;
using System.Xml.Schema;

namespace ByteBankIO 
{ 
    partial class Program 
    { 
        static void Main(string[] args) 
        {
			var enderecoDoArquivo = "../contas.txt";

			var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

			var buffer = new byte[1024]; // 1 kb
			var bytesLivres = -1;
			var contaIteracoes = 0;

			while(bytesLivres != 0)
			{
				contaIteracoes++;
				bytesLivres = fluxoDoArquivo.Read(buffer, 0, buffer.Length);
				EscreverBuffer(buffer);
			}

			Console.WriteLine($"\nTotal de iterações: {contaIteracoes}");
				
        }

		static void EscreverBuffer(byte[] buffer)
		{
			var utf8 = new UTF8Encoding();
			var texto = utf8.GetString(buffer);
			
			// Console.WriteLine(texto);
			
			foreach(var meuByte in buffer)
			{
				Console.Write($"{meuByte}");
			}
		}
    }
} 
 