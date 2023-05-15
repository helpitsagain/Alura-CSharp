using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
		public new double Bonificacao { get; private set; } = 1;

		public Diretor( string cpf) : base(5000, cpf) 
		{
		}

		public override void AumentarSalario()
		{
			Salario *= 1.15;
		}

		public override double GetBonificacao()
		{
			return Salario * 0.5;
		}
    }
}