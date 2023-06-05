using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.Modelos.Sistema;
using Humanizer;

DateTime dataPagamento = new DateTime(2023, 12, 31);
Console.WriteLine(dataPagamento);

DateTime dataCorrente = DateTime.Now;
Console.WriteLine(dataCorrente);

TimeSpan diferenca = dataPagamento - dataCorrente;
diferenca = TimeSpan.FromMinutes(45);
string mensagem = $"Vencimento em {TimeSpanHumanizeExtensions.Humanize(diferenca)}";
Console.WriteLine(mensagem);