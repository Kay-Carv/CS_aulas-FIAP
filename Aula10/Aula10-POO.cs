// ===============================
// Resoluções de exercícios da aula 10 - Programação Orientada a Objetos
// ===============================

//-  1.Crie uma classe ContaBancaria com campos privados e properties publicas

//-  2. Implemente validacao na property Saldo (nao pode ser negativo)

//-  3. Adicione metodos Depositar e Sacar com regras de negocio

public class ContaBancaria
{
    private string _titular;
    private string _categoria;
    private double _saldo;
    public double Saldo
    {
        get => _saldo;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Saldo muito baixo para a ação");
            }
            _saldo = value;
        }
    }

//-  4. Crie uma classe Produto com auto-properties e uma propriedade calculada PrecoFinal
    public void Depositar (double valorDeposito)
    {
        Saldo += valorDeposito;
    }
    public void Sacar (double valorResgate)
    {
        Saldo -= valorResgate;
    }

}

public class Produto {
    public required string Nome { get; set; }
    public double Preco { get; set; }
    public double Desconto { get; set; }

    public double PrecoFinal
    {
        get
        {
            return Preco - (Preco * Desconto);
        }
    }
}


//-  5. Defina um record Cliente com Nome, Email, Telefone
public record Cliente(string Nome, string Email, int Telefone);



//-  6.Demonstre que duas instancias de record iguais sao consideradas equivalentes
public class Program
{
    public static void Main()
    {
        Cliente cliente1 = new Cliente("Ana Paula", "ana.paula@email.com", 123456789);
        Cliente cliente2 = new Cliente("Ana Paula", "ana.paula@email.com", 123456789);

        bool saoIguais = cliente1 == cliente2;
        Console.WriteLine($"Cliente 1 é igual ao cliente 2? {saoIguais}");
    }
}
