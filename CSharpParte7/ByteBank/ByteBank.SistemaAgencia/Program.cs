using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.Modelos.Sistema;
using ByteBank.SistemaAgencia;






internal class Program
{
	private static void Main(string[] args)
	{
		ListaContaCorrente lista = new ListaContaCorrente();
		ContaCorrente contaDoLuc = new ContaCorrente(2901, 98976);

		lista.Adicionar(contaDoLuc);
		lista.Adicionar(new ContaCorrente(42, 1337));
		lista.Adicionar(new ContaCorrente(42, 1337));
		lista.Adicionar(new ContaCorrente(42, 1337));
		lista.Adicionar(new ContaCorrente(42, 1337));
		lista.Adicionar(new ContaCorrente(42, 1337));
		lista.Adicionar(new ContaCorrente(42, 1337));
		lista.Adicionar(new ContaCorrente(42, 1337));
		lista.Adicionar(new ContaCorrente(42, 1337));

		lista.MeuMetodo(numero: 5);

		lista.ExibirLista();

		lista.Remover(contaDoLuc);

		lista.ExibirLista();


		SomarNumeros(new int[] { 1, 2, 3, 4, 5});
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