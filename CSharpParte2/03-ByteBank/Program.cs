namespace _03_ByteBank;
class Program
{
    static void Main(string[] args)
    {
        ContaCorrente contaDaStelle = new ContaCorrente();
        contaDaStelle.titular   = "Stelle";
        contaDaStelle.agencia   = 42;
        contaDaStelle.conta     = 1337;

        ContaCorrente contaDaMarch = new ContaCorrente();
        contaDaStelle.titular   = "Stelle";
        contaDaStelle.agencia   = 42;
        contaDaStelle.conta     = 1337;

        ContaCorrente contaDaMarch2 = contaDaMarch;

        Console.WriteLine("Comparação de referências: " + (contaDaStelle == contaDaMarch));
        Console.WriteLine("Comparação de valores: " + (contaDaMarch == contaDaMarch2));

        contaDaMarch.saldo = 300;
        Console.WriteLine(contaDaMarch.saldo);
        Console.WriteLine(contaDaMarch2.saldo);
    }
}
