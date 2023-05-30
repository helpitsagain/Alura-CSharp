using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using ByteBank.Extensoes;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.Modelos.Sistema;
using ByteBank.SistemaAgencia;


internal class Program
{
	private static void Main(string[] args)
	{
		List<int> idades = new List<int>();
		idades.Add(1);	
		idades.Add(11);	
		idades.Add(21);	
		idades.Add(31);	
		idades.Add(41);	
		idades.Add(51);	
		idades.Add(61);	
		idades.Add(71);	
		idades.Add(81);	
		idades.Add(91);	

		idades.AdicionarVarios(2, 12, 22, 32, 42, 52, 62, 72, 82, 92);

		for(int i = 0; i < idades.Count; i++)
		{
			Console.WriteLine(idades[i]);
		}

		List<ContaCorrente> contas = new List<ContaCorrente>();

		contas.AdicionarVarios(new ContaCorrente(42, 1337)
							 , new ContaCorrente(42, 1338) 
							 , new ContaCorrente(42, 1339) 
							 , new ContaCorrente(42, 1340) 
							 , new ContaCorrente(42, 1341) 
							 , new ContaCorrente(42, 1342));

		foreach (ContaCorrente conta in contas)
		{
			Console.WriteLine(conta.Conta);
		}

	}

	static void TestaListaObject()
	{
		ListaObject listaIdades = new ListaObject();

		listaIdades.Adicionar(15);
		listaIdades.Adicionar(21);
		listaIdades.Adicionar(19);
		listaIdades.AdicionarVarios(42, 31, 18, 9);

		listaIdades.Adicionar("String é um tipo inválido");
		for(int i = 0; i < listaIdades.Tamanho; i++)
		{
			int idade = (int)listaIdades[i];
			Console.WriteLine($"Idade no índice {i}: {idade}");
		}
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

	static void SomarVarios(params int[] numeros)
	{
		int somatorio = 0;
		foreach(int numero in numeros)
		{
			somatorio += numero;
		}
		Console.WriteLine($"Somatório = {somatorio}");
	}

	static void TestaListaContaCorrente()
	{
		ListaContaCorrente lista = new ListaContaCorrente();
		ContaCorrente contaDoLuc = new ContaCorrente(2901, 98976);

		ContaCorrente[] contas = new ContaCorrente[]
		{
			contaDoLuc,
			new ContaCorrente(42,1338),
			new ContaCorrente(42,1339),
			new ContaCorrente(42,1340),
			new ContaCorrente(42,1341),
			new ContaCorrente(42,1342),
			new ContaCorrente(42,1343),
			new ContaCorrente(42,1344)
		};

		lista.AdicionarVarios(contas);
		lista.ExibirLista();

		ContaCorrente[] contasUmCincoQuatro = lista[1, 5, 4];

		foreach (var conta in contasUmCincoQuatro)
		{
			Console.WriteLine($"{conta.Agencia} / {conta.Conta}");
		}
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