using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaStelle = new ContaCorrente();
            contaStelle.titular = "Stelle";

            ContaCorrente contaLuc = new ContaCorrente();
            contaLuc.titular = "Luc";
            
            Console.WriteLine("---------- Sacar() ----------");
            bool resultadoSacar = contaStelle.Sacar(75);
            Console.WriteLine(resultadoSacar);
            resultadoSacar = contaLuc.Sacar(110);
            Console.WriteLine(resultadoSacar);

            Console.WriteLine("\n---------- Depositar() ----------");
            bool resultadoDepositar = contaStelle.Depositar(200);
            Console.WriteLine(resultadoDepositar);
            resultadoDepositar = contaLuc.Depositar(-10);
            Console.WriteLine(resultadoDepositar);

            Console.WriteLine("\n---------- Transferir() ----------");
            bool resultadoTransferir = contaStelle.Transferir(100, contaLuc);
            Console.WriteLine(resultadoTransferir);
            resultadoTransferir = contaLuc.Transferir(250, contaStelle);
            Console.WriteLine(resultadoTransferir);
        }
    }
}