using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
		{
		}

		public override void AumentarSalario()
		{
			Salario *= 1.2;
		}

		internal protected override double GetBonificacao()
		{
			return Salario * 0.1;
		}
    }
}