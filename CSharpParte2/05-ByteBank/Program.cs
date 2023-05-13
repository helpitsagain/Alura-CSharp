using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_ByteBank;
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.titular.nome = "Stelle";
            conta.saldo = 500;
            conta.agencia = 42;
            conta.conta = 1337;

            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.titular.nome);
        }
    }