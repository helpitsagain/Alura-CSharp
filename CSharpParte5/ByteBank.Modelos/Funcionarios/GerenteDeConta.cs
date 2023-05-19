using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Modelos.Sistema;

namespace ByteBank.Modelos.Funcionarios
{
    public class GerenteDeConta : Funcionario, Autenticavel
    {
		public string? Senha { get; set; }
        public GerenteDeConta(string cpf) : base(4000, cpf){}

		public override void AumentarSalario()
		{
			Salario *= 1.05;
		}

		public override double GetBonificacao()
		{
			return Salario * 0.25;
		}

    }
}