namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
    	{
			try
			{
				Metodo();
			}
			catch(Exception e)
			{
				Console.WriteLine("Aconteceu um erro!");
				Console.WriteLine(e.Message);
			}
    	}
    //Teste com a cadeia de chamada:
    //Metodo -> TestaDivisao -> Dividir
        
		static void Metodo()
		{
			TestaDivisao(0);
		}
		
		static void TestaDivisao(int divisor)
		{
			int resultado = Dividir(10, divisor);
			Console.WriteLine("A divisão de 10 por " + divisor + " é igual a " + resultado);
		}
		
		static int Dividir(int numero, int divisor)
		{
			try
			{
				return numero / divisor;
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Exceção com número = " + numero + " e divisor = " + divisor
					+ " capturada na função Dividir.");
				throw;
			}
		}
    }
}