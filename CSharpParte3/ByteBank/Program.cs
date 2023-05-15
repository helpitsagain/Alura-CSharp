﻿using ByteBank.Funcionarios;

namespace ByteBank;
class Program
{
    static void Main(string[] args)
    {
        CalcularBonificacao();
    }

	public static void CalcularBonificacao()
	{
		GerenciadorBonificacao g = new GerenciadorBonificacao();

		Designer march = new Designer("235.874.254-69");
		march.Nome = "March";

		Diretor himeko = new Diretor("000.000.000-01");
		himeko.Nome = "Himeko";

		Auxiliar stelle = new Auxiliar("999.999.999-99");
		stelle.Nome = "Stelle";

		GerenteDeConta welt = new GerenteDeConta("123.456.789-10");
		welt.Nome = "Welt";

		Desenvolvedor danHeng = new Desenvolvedor("109.876.543-21");
		danHeng.Nome = "Dan Heng";

		g.Registrar(march);
		g.Registrar(welt);
		g.Registrar(stelle);
		g.Registrar(himeko);
		g.Registrar(danHeng);

		Console.WriteLine("Total de bonificações do mês: R${0}"
			, g.GetTotalBonificacao());
	}
}
