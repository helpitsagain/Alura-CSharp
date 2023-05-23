using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Modelos.Funcionarios;


namespace ByteBank.Modelos
{
    public class GerenciadorBonificacao
    {
        public double _totalBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

		public double GetTotalBonificacao()
		{
			return _totalBonificacao;
		}
    }
}