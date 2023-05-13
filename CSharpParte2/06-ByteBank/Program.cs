using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_ByteBank;
	public class Program
	{
		static void Main(string[] args)
		{
			Cliente cliente = new Cliente();
			cliente.Nome = "Stelle";
			cliente.CPF = "123.456.789-10";
			ContaCorrente conta = new ContaCorrente();
			conta.Saldo = -10;
			conta.Titular = cliente;
			Console.WriteLine(conta.Saldo);
			Console.WriteLine(conta.Titular.Nome);
			Console.WriteLine(conta.Agencia);
			Console.WriteLine(conta.Conta);
		}
	}