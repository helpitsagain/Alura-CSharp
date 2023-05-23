using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.Modelos.Sistema;
using ByteBank.SistemaAgencia;


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