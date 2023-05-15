using ByteBank.Funcionarios;

namespace ByteBank;
class Program
{
    static void Main(string[] args)
    {
        GerenciadorBonificacao g = new GerenciadorBonificacao();

        Funcionario danHeng = new Funcionario();
        danHeng.Nome = "Dan Heng";
        danHeng.CPF = "123.456.789-10";
        danHeng.Salario = 2000;
        Console.WriteLine(danHeng.Nome + ": R$" + danHeng.GetBonificacao());
        g.Registrar(danHeng);

        Diretor stelle = new Diretor();
        stelle.Nome = "Stelle";
        stelle.CPF = "109.876.543-21";
        stelle.Salario = 5000;
        Console.WriteLine(stelle.Nome + ": R$" + stelle.GetBonificacao());
        g.Registrar(stelle);

        Console.WriteLine("Total de bonificações: R$" + g._totalBonificacao);


    }
}
