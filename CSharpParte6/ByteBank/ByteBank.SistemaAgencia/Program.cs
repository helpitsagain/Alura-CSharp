using System.ComponentModel.DataAnnotations;
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
string urlParametros = "http://www.bytebank.com.br/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

ExtratorArgumentosURL ext = new ExtratorArgumentosURL(urlParametros);

string valor = ext.GetValor("moedaOrigem");
Console.WriteLine($"Valor de moedaOrigem: {valor}");

valor = ext.GetValor("moedaDestino");
Console.WriteLine($"Valor de moedaDestino: {valor}");

valor = ext.GetValor("valor");
Console.WriteLine($"Valor de valor: {valor}");

////////////////////////////////////////////////////////////
// StartsWith & EndsWith
string urlByteBank = "http://www.bytebank.com.br/cambio";
Console.WriteLine(urlByteBank.StartsWith("http://www.bytebank"));
Console.WriteLine(urlByteBank.EndsWith("cambio/"));
Console.WriteLine(urlByteBank.Contains("bytebank"));
