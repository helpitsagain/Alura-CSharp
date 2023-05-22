using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.Modelos.Sistema;

string url = "pagina?argumentos";
Console.WriteLine(url);

string argumentos = url.Substring(7);
Console.WriteLine(argumentos);