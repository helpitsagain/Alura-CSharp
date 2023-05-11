namespace _0504_Booleanos;
class Program
{
    static void Main(string[] args)
    {
        int idade = 14;
        int quantidadePessoas = 2;
        bool maiorIdade = idade >= 18;
        bool acompanhado = quantidadePessoas >= 2;

        if (maiorIdade || acompanhado) {
            Console.WriteLine("Maior de idade ou menor acompanhado, entrada permitida.");
        } else {
            Console.WriteLine("Menor de idade, entrada negada.");
        }
    }
}
