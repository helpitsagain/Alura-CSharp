namespace _0401_CaracteresTextos;
class Program
{
    static void Main(string[] args)
    {
    // Caractere
        char primeiraLetra = 'a';
        Console.WriteLine(primeiraLetra);
        primeiraLetra = (char)42;
        Console.WriteLine(primeiraLetra);
        primeiraLetra = (char)(42+7);
        Console.WriteLine(primeiraLetra);
        
    // String
        string titulo = "Eu tô com sono aaaaaaaaaaa " + 424242;
        Console.WriteLine(titulo);

        string cursosProgramacao = " - .NET" + 
            " - Java" + 
            " - JavaScript";
        Console.WriteLine(cursosProgramacao);
        cursosProgramacao = @" - .NET
 - Java
 - JavaScript";
         Console.WriteLine(cursosProgramacao);
    }
}
