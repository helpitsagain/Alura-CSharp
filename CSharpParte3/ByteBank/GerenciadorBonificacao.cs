using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Funcionarios;


namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        public double _totalBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }
    }
}