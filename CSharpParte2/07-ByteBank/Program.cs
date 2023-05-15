namespace _07_ByteBank;
class Program
{
    static void Main(string[] args)
    {
		ContaCorrente c = new ContaCorrente(42, 1337, "12345678910");
		Console.WriteLine(ContaCorrente.QuantidadeContasCriadas);
		
		ContaCorrente c2 = new ContaCorrente(42, 1337, "12345678910");
		Console.WriteLine(ContaCorrente.QuantidadeContasCriadas);

		ContaCorrente c3 = new ContaCorrente(42, 1337, "12345678910");
		Console.WriteLine(ContaCorrente.QuantidadeContasCriadas);

    }
}
