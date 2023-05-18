namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
    	{
			try
			{
				ContaCorrente cStelle = new ContaCorrente(42, 1337);
				cStelle.Titular.Nome = "Stelle";
				ContaCorrente cMarch = new ContaCorrente(42, 1338);
				cMarch.Titular.Nome = "March";

				cStelle.Transferir(-50, cMarch);

				Console.WriteLine("Execução finalizada.\n");
			}
			catch (ArgumentException e)
			{
				Console.WriteLine($"Aconteceu uma exceção do tipo ArgumentException no argumento {e.ParamName}");
				if (e.ParamName == "agencia")
				{
					Console.WriteLine("Número de agência inválido. agência deve ser maior que 0.");
				}
				if (e.ParamName == "conta")
				{
					Console.WriteLine("Número de conta inválido. Conta deve ser maior que 0.");
				}
				Console.WriteLine(e.Message + "\n");
			}
			catch (SaldoInsuficienteException e)
			{
				Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
				Console.WriteLine(e.Message);
			}
    	}
    }
}