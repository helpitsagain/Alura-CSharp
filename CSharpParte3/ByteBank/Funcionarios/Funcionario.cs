using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public double Salario { get; set; }
		public double Bonificacao { get; private set; } = 0.1;

        public virtual double GetBonificacao()
        {
            return Salario * Bonificacao;
        }
    }
}