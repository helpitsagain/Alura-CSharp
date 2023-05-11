namespace _0608_ForEncadeado;
class Program
{
    static void Main(string[] args)
    {
        for (int contaLinha = 0; contaLinha < 10; contaLinha++)
        {
            for (int contaColuna = 0; contaColuna <= contaLinha; contaColuna++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }

        Console.WriteLine();

        for (int contaLinha = 0; contaLinha < 10; contaLinha++)
        {
            for (int contaColuna = 0; contaColuna < 10; contaColuna++)
            {
                Console.Write("*");

                if (contaColuna >= contaLinha)
                {
                    break;
                }
            }
            Console.WriteLine("");
        }
    }
}
