using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
// using ByteBank.Extensoes;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.Modelos.Sistema;
using ByteBank.SistemaAgencia;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;

internal class Program
{
	private static void Main(string[] args)
	{
		var idades = new List<int>();
		
		idades.AdicionarVarios(10, 20, 30);
		idades.AdicionarVarios(1, 99);

		for(int i = 0; i < idades.Count; i++)
		{
			Console.WriteLine(idades[i]);
		}

		idades.Sort();

		Console.WriteLine("\n-------------\n");
		for(int i = 0; i < idades.Count; i++)
		{
			Console.WriteLine(idades[i]);
		}
		
		
		
		Console.WriteLine("\n-------------\n");
		var nomes = new List<string>()
		{
			"Stelle",
			"March",
			"Dan Heng",
			"Welt",
			"Himeko"
		};

		foreach (var nome in nomes)
		{
			Console.WriteLine(nome);
		}
		Console.WriteLine("\n-------------\n");
		nomes.Sort();

		foreach (var nome in nomes)
		{
			Console.WriteLine(nome);
		}
		


		Console.WriteLine("\n-------------\n");
		var contas = new List<ContaCorrente>()
		{
			new ContaCorrente(42, 5),
			new ContaCorrente(45, 4),
			new ContaCorrente(43, 2),
			new ContaCorrente(41, 3),
			new ContaCorrente(44, 1),
		};

		foreach (var conta in contas)
		{
			Console.WriteLine($"Agência: {conta.Agencia} | Conta: {conta.Conta}");
		}

		contas.Sort();

		Console.WriteLine("\n-------------\n");
		foreach (var conta in contas)
		{
			Console.WriteLine($"Agência: {conta.Agencia} | Conta: {conta.Conta}");
		}

		contas.Sort(new ComparadorContaCorrentePorAgencia());

		Console.WriteLine("\n-------------\n");
		foreach (var conta in contas)
		{
			Console.WriteLine($"Agência: {conta.Agencia} | Conta: {conta.Conta}");
		}
		

		Console.WriteLine("\n-------------\n");
		Console.WriteLine($"Encerrado em {DateTime.Now.TimeOfDay}");
	}

	static void SomarNumeros(int[] lista)
	{
		for (int i = 0; i < lista.Length -1; i += 2)
		{
			int numero1 = lista[i];
			int numero2 = lista[i + 1];
			Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
		}
	}

	static int SomarVarios(params int[] numeros)
	{
		int somatorio = 0;
		foreach(int numero in numeros)
		{
			somatorio += numero;
		}

		return somatorio;
	}

	static void TestaArrayContaCorrente()
	{
		ContaCorrente[] contas = new ContaCorrente[]{
			new ContaCorrente(42, 1337),
			new ContaCorrente(42, 1338),
			new ContaCorrente(42, 1339),
			new ContaCorrente(42, 1340),
			new ContaCorrente(42, 1341)
		};

		for (int i = 0; i < contas.Length; i++)
		{
			ContaCorrente contaAtual = contas[i];
			Console.WriteLine($"Conta {i}: {contaAtual.Conta}");
		}
	}

	static void TestaArrayInt()
	{
		int[] idades = new int[5];

		idades[0] = 29;
		idades[1] = 26;
		idades[2] = 22;
		idades[3] = 21;
		idades[4] = 24;

		double acumulador = 0;
		for (int i = 0; i < idades.Length; i++)
		{
			int idade = idades[i];
			acumulador += idade;
			Console.WriteLine(acumulador);
			Console.WriteLine($"Acessando o array idades[] no índice {i}.");
			Console.WriteLine($"Valor de idades[{i}] = {idade}.\n");
		}
		Console.WriteLine($"Média de idades (equação): {acumulador / idades.Length}");
		Console.WriteLine($"Média de idades (função): {idades.Average()}");
	}
}