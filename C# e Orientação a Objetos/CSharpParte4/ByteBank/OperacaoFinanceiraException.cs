using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.ContaCorrente
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException() {}

		public OperacaoFinanceiraException(string mensagem)
			: base(mensagem) {}

		public OperacaoFinanceiraException(string mensagem, Exception excecaoInterna)
			: base(mensagem, excecaoInterna) {}
    }
}