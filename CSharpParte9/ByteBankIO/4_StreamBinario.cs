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
        static void EscritorBinario()
        {
            using(var fs = new FileStream("../testaBinario.txt", FileMode.Create))
			using(var escritor = new BinaryWriter(fs))
			{
				escritor.Write(42);
				escritor.Write(1337);
				escritor.Write(1978.97);
				escritor.Write("Stelle Ron");
			}
        }

        static void LeitorBinario()
        {
			using(var fs = new FileStream("../testaBinario.txt", FileMode.Open))
			using(var leitor = new BinaryReader(fs))
			{
				var agencia = leitor.ReadInt32();
				var numero = leitor.ReadInt32();
				var saldo = leitor.ReadDouble();
				var titular = leitor.ReadString();

				Console.WriteLine($"{agencia}/1{numero} | {titular} | R${saldo}");
			}
        }

    }
}
