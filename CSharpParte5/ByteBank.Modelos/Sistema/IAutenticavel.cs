using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.Modelos.Sistema
{
    public interface IAutenticavel
    {
		public bool Autenticar(string senha);
    }
}