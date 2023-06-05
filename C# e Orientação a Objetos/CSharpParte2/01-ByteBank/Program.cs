namespace _01_ByteBank;

class Program
{
    static void Main(string[] args)
    {
        ContaCorrente c = new ContaCorrente();
        c.titular = "Stelle";
        c.agencia = 1337;
        c.conta = 42;
        c.saldo = 100;
        Console.WriteLine(c.titular);
        Console.WriteLine(c.agencia);
        Console.WriteLine(c.conta);
        Console.WriteLine(c.saldo);
    }
}