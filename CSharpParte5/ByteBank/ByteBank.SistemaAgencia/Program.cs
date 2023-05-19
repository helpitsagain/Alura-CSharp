using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.Modelos.Sistema;

ContaCorrente c = new ContaCorrente(42, 1337);
Console.WriteLine(c.Agencia);

Diretor d = new Diretor("01351848003");
d.Nome = "Diretoooor";
Console.WriteLine(d.Nome);

ParceiroComercial p = new ParceiroComercial();
p.Senha = "123";
Console.WriteLine(p.Autenticar("123"));

// AutenticacaoHelper a = new AutenticacaoHelper();
// Console.WriteLine(a.CompararSenhas("123", "123"));
