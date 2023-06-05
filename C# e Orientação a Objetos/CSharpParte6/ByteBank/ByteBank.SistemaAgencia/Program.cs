using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
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

////////////////////////////////////////////////////////////
// Remove & ToLower & ToUpper
/*
string urlParametros = "http://www.bytebank.com.br/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

ExtratorArgumentosURL ext = new ExtratorArgumentosURL(urlParametros);

string valor = ext.GetValor("moedaOrigem");
Console.WriteLine($"Valor de moedaOrigem: {valor}");

valor = ext.GetValor("moedaDestino");
Console.WriteLine($"Valor de moedaDestino: {valor}");

valor = ext.GetValor("valor");
Console.WriteLine($"Valor de valor: {valor}");
*/
////////////////////////////////////////////////////////////
// StartsWith & EndsWith
/*
string urlByteBank = "http://www.bytebank.com.br/cambio";
Console.WriteLine(urlByteBank.StartsWith("http://www.bytebank"));
Console.WriteLine(urlByteBank.EndsWith("cambio/"));
Console.WriteLine(urlByteBank.Contains("bytebank"));
*/
////////////////////////////////////////////////////////////
// Expressões regulares
string textoTeste = "Meu nome é Luc e meu telefone é 99245-8521!!!";

string padrao1 = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
Match resultado = Regex.Match(textoTeste, padrao1);
Console.WriteLine("Resultado com padrão 1: " + resultado.Value);

string padrao2 = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
resultado = Regex.Match(textoTeste, padrao2);
Console.WriteLine("Resultado com padrão 2: " + resultado.Value);

string padrao3 = "[0-9]{4}[-][0-9]{4}";
resultado = Regex.Match(textoTeste, padrao3);
Console.WriteLine("Resultado com padrão 3: " + resultado.Value);

string padrao4 = "[0-9]{4,5}-{0,1}[0-9]{4}";
resultado = Regex.Match(textoTeste, padrao4);
Console.WriteLine("Resultado com padrão 4: " + resultado.Value);

string padrao5 = "[0-9]{4,5}-?[0-9]{4}";
resultado = Regex.Match(textoTeste, padrao5);
Console.WriteLine("Resultado com padrão 4: " + resultado.Value);
