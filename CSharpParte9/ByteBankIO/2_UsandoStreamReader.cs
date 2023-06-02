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
			using(var leitor = new StreamReader(fluxoDoArquivo, Encoding.UTF8))
			{
				while (!leitor.EndOfStream)
				{
					var linha = leitor.ReadLine();
					var conta = ConverterStringParaContaCorrente(linha);
					Console.WriteLine($"Conta {conta.Numero} | Agência {conta.Agencia} | "
									+ $"Saldo R${conta.Saldo} | Titular: {conta.Titular.Nome}");
				}
			}
		}

		static ContaCorrente ConverterStringParaContaCorrente(string linha)
		{
			string[] campos = linha.Split(',');

			var agencia = campos[0];
			var numero = campos[1];
			var saldo = campos[2];
			var titular = campos[3];

			var agenciaInt = int.Parse(agencia);
			var numeroInt = int.Parse(numero);
			var resultado = new ContaCorrente(agenciaInt, numeroInt);
			
			var saldoInt = double.Parse(saldo);
			resultado.Depositar(saldoInt);

			resultado.Titular = new Cliente();
			resultado.Titular.Nome = titular;

			return resultado;
		}
    }
}
