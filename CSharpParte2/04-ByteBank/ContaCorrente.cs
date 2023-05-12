namespace _04_ByteBank;

public class ContaCorrente
{
    public string titular = "";
    public int agencia;
    public int conta;
    public double saldo = 100;

    public bool Sacar(double valor)
    {
        if (valor > this.saldo)
        {
            return false;
        }

        this.saldo -= valor;
        
        return true;
    }
}
