using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank
{
	public class ContaCorrente
	{
		public static double TaxaOperacao { get; private set; }
		public static int QuantidadeContasCriadas { get; private set; }
		public Cliente Titular{ get; set; } = new Cliente("");
	    public int Agencia{ get; set; }
	    public int Conta{ get; set; }
	    private double _saldo = 100;
		public double Saldo 
		{
			get 
			{ 
				return _saldo;
			}
			set
			{ 
				if (value < 0) return; 
				_saldo = value; 
			} 
		}

		public ContaCorrente (int agencia, int conta)
		{
			Agencia = agencia;
			Conta = conta;
			TaxaOperacao = 30 / QuantidadeContasCriadas;
			QuantidadeContasCriadas++;
		}

	    public bool Sacar(double valor)
	    {
	        if (valor > this._saldo)
	        {
	            Console.WriteLine("Saldo insuficiente.");
	            return false;
	        }

	        this._saldo -= valor;
	        Console.WriteLine("Saque efetuado de " + this.Titular + ". Saldo restante: R$" + this._saldo);
	        return true;
	    }

		public bool Depositar(double valor)
		{
			if (valor <= 0)
			{
				Console.WriteLine("Valor inválido.");
				return false;
			}

			this._saldo += valor;
			Console.WriteLine("Depósito efetuado para " + this.Titular + ". Novo saldo: R$" + this._saldo);
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

// Getters & Setters não precisam ser definidos aqui, podendo ser inseridos
// diretamente na declaração das propriedades!
		// public double GetSaldo()
		// {
		// 	return this.saldo;
		// }
		// public void SetSaldo(double saldo)
		// {
		// 	if (saldo < 0)
		// 	{
		// 		return;
		// 	}

		// 	this.saldo = saldo;
		// }
	}
}