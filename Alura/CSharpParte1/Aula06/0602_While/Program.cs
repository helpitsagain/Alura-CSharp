namespace _0602_While;
class Program
{
    static void Main(string[] args)
    {
        double valorInvestido = 1000;
        double rendimento = 0.0036; // 0.36% = 0.0036

        int i = 0;
        while (i < 12)
        {
            i++;
            valorInvestido += valorInvestido * rendimento;
            if (i < 2)
            {
                Console.WriteLine("Apôs 1 mês, seu valor investido será de R$" + valorInvestido);   
            } else
            {
                Console.WriteLine("Apõs " + i + " meses, seu valor investido será de R$" + valorInvestido);
            }
        }

        // Console.ReadKey();
    }
}
