using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBankIO.Modelos
{
    public class ContaCorrente
    {
		public Cliente? Titular{ get; set; }
		public int Agencia { get; }
		public int Numero { get; }
		public double Saldo { get; private set; }

		public ContaCorrente (int agencia, int numero)
		{
			Agencia = agencia;
			Numero = numero;
		}

		public void Depositar(double valor)
		{
			if (valor <= 0)
			{
				Console.WriteLine("Valor inválido.");
			}

			Saldo += valor;
			Console.WriteLine($"Depósito efetuado. Novo saldo: R${Saldo}");
		}

		public void Sacar(double valor)
	    {
			if (valor < 0)
			{
				throw new ArgumentException("Valor inválido. Saque deve ser de um valor positivo.", nameof(valor));
			}
	        if (valor > Saldo)
	        {
	            throw new InvalidOperationException("Saldo insuficiente.");
	        }

	        Saldo -= valor;
	        Console.WriteLine($"Saque efetuado. Saldo restante: R${Saldo}");
	    }
    }
}