using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
		public SaldoInsuficienteException(){}

        public SaldoInsuficienteException(string mensagem) 
			: base(mensagem){}
		
		public SaldoInsuficienteException(double valorSaque, double saldo)
			: this("Saldo de R$" + saldo + " insuficiente para realizar a operação no valor de R$" + valorSaque + "."){}
			
		public SaldoInsuficienteException(string mensagem, Exception excecaoInterna)
			: base(mensagem, excecaoInterna){}
    }
}