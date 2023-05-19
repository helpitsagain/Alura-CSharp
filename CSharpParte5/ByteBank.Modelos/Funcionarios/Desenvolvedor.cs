using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
	public class Desenvolvedor : Funcionario
	{
		public Desenvolvedor( string cpf) : base(3500, cpf)
		{
		}

		public override void AumentarSalario()
		{
			Salario *= 0.11;
		}

		public override double GetBonificacao()
		{
			return Salario * 0.18;
		}
	}
}