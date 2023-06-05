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
        static void UsarStreamDeEntrada()
        {
            using(var fluxoDeEntrada = Console.OpenStandardInput())
			using(var fs = new FileStream("../entradaConsole.txt", FileMode.Create))
			using(var escritor = new StreamWriter(fs, Encoding.UTF8))
			{
				var buffer = new byte[1024];
				
				var continua = true;
				while(continua)
				{
					var bytesLidos = fluxoDeEntrada.Read(buffer, 0, buffer.Length);

					escritor.WriteLine(fluxoDeEntrada);
					escritor.Flush();

					Console.WriteLine($"Bytes lidos: {bytesLidos}");

					if(bytesLidos == 1) { continua = false; }
				}

			}
        }
    }
}
