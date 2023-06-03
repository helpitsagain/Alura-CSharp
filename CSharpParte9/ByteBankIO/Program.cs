using ByteBankIO.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // IO = Input e Output
using System.Globalization;
using System.Xml.Schema;
using System.Xml;

namespace ByteBankIO
{
	partial class Program
	{
		static void Main(string[] args)
		{
			var linhas = File.ReadAllLines("../contas.txt");
			Console.WriteLine(linhas.Length);

			foreach (var linha in linhas)
			{
				var linhaFormatada = linha.Replace(';', ' ');
				Console.WriteLine(linhaFormatada);
			}

			var bytesLidos = File.ReadAllBytes("../contas.txt");
			Console.WriteLine($"O arquivo contas.txt tem {bytesLidos.Length} bytes.");

			File.WriteAllText("../contas.copia.txt", "Cópia de contas.txt\n\n");
			File.AppendAllLines("../contas.copia.txt", linhas);
		}
	}
}
