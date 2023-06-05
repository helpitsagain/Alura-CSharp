using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_ByteBank
{
	public class ContaCorrente
	{
		public Cliente titular = new Cliente();
	    public int agencia;
	    public int conta;
	    public double saldo = 100;

	    public bool Sacar(double valor)
	    {
	        if (valor > this.saldo)
	        {
	            Console.WriteLine("Saldo insuficiente.");
	            return false;
	        }

	        this.saldo -= valor;
	        Console.WriteLine("Saque efetuado de " + this.titular + ". Saldo restante: R$" + this.saldo);
	        return true;
	    }

		public bool Depositar(double valor)
		{
			if (valor <= 0)
			{
				Console.WriteLine("Valor inválido.");
				return false;
			}

			this.saldo += valor;
			Console.WriteLine("Depósito efetuado para " + this.titular + ". Novo saldo: R$" + this.saldo);
			return true;
		}
		public bool Transferir(double valor, ContaCorrente destino)
		{
			if (!this.Sacar(valor))
			{
				return false;
			}

			destino.Depositar(valor);
			return true;
		}
	}
}