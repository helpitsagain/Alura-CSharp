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
            ContaCorrente cc = new ContaCorrente();
            cc.titular = "Luc";

            Console.WriteLine(cc.saldo);
            cc.Sacar(1000);
            Console.WriteLine(cc.saldo);
        }
    }
}