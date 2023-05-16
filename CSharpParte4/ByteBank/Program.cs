namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
    	{
			Metodo();
    	}
    //Teste com a cadeia de chamada:
    //Metodo -> TestaDivisao -> Dividir
        
		static void Metodo()
		{
			TestaDivisao(0);
		}
		
		static void TestaDivisao(int divisor)
		{
			try
			{
				int resultado = Dividir(10, divisor);
				Console.WriteLine("A divisão de 10 por " + divisor + " é igual a " + resultado);
			}
			catch (DivideByZeroException err)
			{
				Console.WriteLine("\nExceção capturada em TestaDivisao.");
				Console.WriteLine(err.Message);
			}
		}
		
		static int Dividir(int numero, int divisor)
		{
			return numero / divisor;
		}
    }
}