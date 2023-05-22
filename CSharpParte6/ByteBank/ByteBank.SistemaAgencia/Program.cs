using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.Modelos.Sistema;
using ByteBank.SistemaAgencia;

// // testando String.IsNullOrEmpty
// string? nula = null;
// string vazia = "";
// string naoNula = "string";
// Console.WriteLine(String.IsNullOrEmpty(nula));
// Console.WriteLine(String.IsNullOrEmpty(vazia));
// Console.WriteLine(String.IsNullOrEmpty(naoNula));

string palavra = "moedaOrigem=dolar&moedaDestino=real";
Console.WriteLine($"Palavra:.............................{palavra}");
string nomeArgumento = "moedaOrigem";
// string nomeArgumento = "moedaDestino";
Console.WriteLine($"Argumento:...........................{nomeArgumento}\n");

int indiceArgumento = palavra.IndexOf(nomeArgumento);
Console.WriteLine($"Índice do argumento:.................{indiceArgumento}");
string substringArgumento = palavra.Substring(indiceArgumento);
Console.WriteLine($"Substring com índice do argumento:...{substringArgumento}\n");

int indiceValor = nomeArgumento.Length + 1;
Console.WriteLine($"Índice do valor:.....................{indiceValor}");
string substringValor = substringArgumento.Substring(indiceValor);
Console.WriteLine($"Substring com índice do valor:.......{substringValor}\n");

int fimArgumento = substringValor.IndexOf('&');
Console.WriteLine($"Fim do argumento na substring:.......{fimArgumento}");
string valorArgumento;
if (fimArgumento > 0)
{
	valorArgumento = substringValor.Substring(0, fimArgumento);
} else {
	valorArgumento = substringArgumento.Substring(indiceValor);
}
Console.WriteLine($"Valor do argumento:..................{valorArgumento}");
