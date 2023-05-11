namespace _0308_ConversaoTiposNumericos;
class Program
{
    static void Main(string[] args)
    {
        double salario = 1100.50;
        Console.WriteLine(salario);

        int salarioEmInt = (int)salario;
        Console.WriteLine(salarioEmInt);

        float altura = 1.85f;
        Console.WriteLine(altura);
    // Float não pode ser convertido implicitamente em Double:
        altura = (float)1.85;
        Console.WriteLine(altura);
    // Double pode ser convertido implicitamente em Float, mas fica esquisito:
        double alturaDouble = 1.85f;
        Console.WriteLine(alturaDouble);
    }
}
