namespace ByteBank.ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
    	{
			try
			{
			CarregarContas();
			}
			catch (Exception)
			{
				Console.WriteLine("CATCH NO MÉTODO MAIN");
			}
    	}

		private static void CarregarContas()
		{
			using(LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
			{
				leitor.LerProximaLinha();
			}
			
// ---------------------------------------------------------------------------
			// LeitorDeArquivo leitor = null;
			// try
			// {
			// 	leitor = new LeitorDeArquivo("contas.txt");

			// 	leitor.LerProximaLinha();
			// 	leitor.LerProximaLinha();
			// 	leitor.LerProximaLinha();
			// } catch(IOException) {
			// 	Console.WriteLine("Exceção do tipo IOException capturada.");
			// } finally {
			// 	Console.WriteLine("Executando o finally.");
			// 	if (leitor != null)
			// 	{
			// 		leitor.Fechar();				
			// 	}
			// }
		}
		
		private static void TestaInnerException()
		{
			try
			{
				ContaCorrente cStelle = new ContaCorrente(42, 1337);
				cStelle.Titular.Nome = "Stelle";
				ContaCorrente cMarch = new ContaCorrente(42, 1338);
				cMarch.Titular.Nome = "March";

				// cStelle.Transferir(-500, cMarch);
				// cStelle.Transferir(500, cMarch);
				// cStelle.Sacar(-200);
				// cStelle.Sacar(200);

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
			catch (OperacaoFinanceiraException e)
			{
				Console.WriteLine($"{e.Message}\n{e.StackTrace}");
			}
		}
    }
}