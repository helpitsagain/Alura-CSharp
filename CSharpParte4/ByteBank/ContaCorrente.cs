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
		public Cliente? Titular{ get; private set; }
		public int Agencia { get; }
		public int Conta { get; }
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
			if (agencia <= 0)
			{
				ArgumentException excecao = new ArgumentException("Agência deve ser maior do que 0.", nameof(agencia));
				throw excecao;
			}
			if (conta <= 0)
			{
				ArgumentException excecao = new ArgumentException("Número deve ser maior do que 0.", nameof(conta));
				throw excecao;
			}

			Agencia = agencia;
			Conta = conta;
			QuantidadeContasCriadas++;
			TaxaOperacao = 30 / QuantidadeContasCriadas;
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