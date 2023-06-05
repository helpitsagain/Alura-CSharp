namespace _02_ByteBank;

class Program
{
    static void Main(string[] args)
    {
        ContaCorrente c = new ContaCorrente();
        
        c.titular = "Stelle";
        Console.WriteLine(c.titular);
        Console.WriteLine(c.saldo);
    }
}