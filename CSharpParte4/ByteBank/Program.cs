namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
    	{
			try
			{
				ContaCorrente cc = new ContaCorrente(0, 0);


				Console.WriteLine("Execução finalizada.");
			}
			catch(ArgumentException e)
			{
				Console.WriteLine("Aconteceu uma exceção do tipo ArgumentException no argumento " + e.ParamName);
				Console.WriteLine(e.Message + "\n");
			}
			
			// Metodo();
    	}
    // Teste com a cadeia de chamada:
    // Metodo -> TestaDivisao -> Dividir
        
		static void Metodo()
		{
			try
			{
				TestaDivisao(0);
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine(e.Message + "\n");
			}
		}
		
		static void TestaDivisao(int divisor)
		{
			int resultado = Dividir(10, divisor);
			Console.WriteLine("A divisão de 10 por " + divisor + " é igual a " + resultado);
		}
		
		static int Dividir(int numero, int divisor)
		{
			return numero / divisor;
		}
    }
}