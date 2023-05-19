using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public abstract class Funcionario
    {
		public static int TotalFuncionarios { get; private set; }
        public string? Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }
		public double Bonificacao { get; private set; } = 0.1;

		public Funcionario(double salario, string cpf)
		{
			CPF = cpf;
			Salario = salario;
			TotalFuncionarios++;
		}

		public abstract void AumentarSalario();

        internal protected abstract double GetBonificacao();
    }
}