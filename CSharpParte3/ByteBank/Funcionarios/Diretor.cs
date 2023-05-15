using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
		public new double Bonificacao { get; private set; } = 1;

		public override double GetBonificacao()
		{
			return Salario + base.GetBonificacao();
		}
    }
}