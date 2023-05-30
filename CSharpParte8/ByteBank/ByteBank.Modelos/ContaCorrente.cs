using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
	public class ContaCorrente : IComparable
	{
		public static double TaxaOperacao { get; private set; }
		public int ContadorSaquesNaoPermitidos { get; private set; }
		public int ContadorTransferenciasNaoPermitidas { get; private set; }
		public static int QuantidadeContasCriadas { get; private set; }
		public Cliente Titular{ get; private set; } = new Cliente();
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
				if (value < 0) { return; } 
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

	    public void Sacar(double valor)
	    {
			if (valor < 0)
			{
				throw new ArgumentException("Valor inválido. Saque deve ser de um valor positivo.", nameof(valor));
			}
	        if (valor > this._saldo)
	        {
				ContadorSaquesNaoPermitidos++;
	            throw new SaldoInsuficienteException(valor, this.Saldo);
	        }

	        this._saldo -= valor;
	        Console.WriteLine($"Saque efetuado de {this.Titular.Nome}. Saldo restante: R${this._saldo}");
	    }

		public bool Depositar(double valor)
		{
			if (valor <= 0)
			{
				Console.WriteLine("Valor inválido.");
				return false;
			}

			this._saldo += valor;
			Console.WriteLine($"Depósito efetuado para {this.Titular.Nome}. Novo saldo: R${this._saldo}");
			return true;
		}
		
		public void Transferir(double valor, ContaCorrente destino)
		{
			if (valor < 0)
			{
				throw new ArgumentException("Valor inválido. Transferência deve ser de um valor positivo.", nameof(valor));
			}

			try
			{
			this.Sacar(valor);
			}
			catch (SaldoInsuficienteException e)
			{
				ContadorTransferenciasNaoPermitidas++;
				throw new OperacaoFinanceiraException("Operação não realizada.", e);
			}
			destino.Depositar(valor);
		}

		public override bool Equals(object obj)
		{
			ContaCorrente outraConta = obj as ContaCorrente;

			if(outraConta == null)
			{
				return false;
			}

			return this.Conta == outraConta.Conta && this.Agencia == outraConta.Agencia;
		}
		
		// override object.GetHashCode
		public override int GetHashCode()
		{
			// TODO: write your implementation of GetHashCode() here
			throw new System.NotImplementedException();
			return base.GetHashCode();
		}

		public int CompareTo(object? obj)
		{
			var outraConta = obj as ContaCorrente;

			if(this.Conta < outraConta.Conta || outraConta == null)
			{
				return -1;
			}

			if(this.Conta == outraConta.Conta)
			{
				return 0;
			}

			return +1;
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