namespace _0605_For;
class Program
{
    static void Main(string[] args)
    {
        double valorInvestido = 1000;
        double fatorRendimento = 0.0036;
        int tempoDecorrido = 0;

        for (int i = 1; i <= 120; ++i)
        {
            valorInvestido *= 1 + fatorRendimento;
            tempoDecorrido = i;
            
            if (i % 12 == 0)
            {
                Console.WriteLine("Após " + i + " meses seu fator de rendimento será de " + fatorRendimento*100 + "% ao mês.");
                fatorRendimento += 0.0005;
            }
        }

        Console.WriteLine("\nApós " + tempoDecorrido + " meses seu valor investido será de de R$" + valorInvestido);
    }
}
