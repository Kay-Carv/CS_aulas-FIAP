//1.Peça a nota de um aluno e classifique o resultado: Aprovado(nota maior ou igual a 7),
//recuperação(nota maior ou igual a 5 e menor que 7) ou Reprovado(nota menor que 5).

//2.Solicite um número de 1 a 7 e exiba o dia da semana correspondente usando switch.

//3.Use uma switch expression para converter um código HTTP em uma mensagem. [Professor: informe os códigos e
//as mensagens que devem ser usados.]

//4.Solicite três números e exiba o maior valor usando o operador ternário.

//5.Calcule o IMC de uma pessoa e exiba a categoria correspondente usando uma estrutura if/else
//encadeada. Tabela de IMC Completa — Classificação OMS com Exemplos
public class Program
{
    static void Main()
    {
        Console.WriteLine("Escreva a nota do aluno para avaliar seu desempenho final");
        string? str1 = Console.ReadLine();

        if (int.TryParse(str1, out var nota1)) {
            Console.WriteLine($"Variável {str1} convertido para inteiro: {nota1}");
        } else {
            Console.WriteLine($"Não foi possível converte o número: {str1}");
        }

        if (nota1 >= 7) {
            Console.WriteLine("Aluno aprovado");
        } else if (nota1 >= 5 && nota1 < 7) {
            Console.WriteLine("Aluno em recuperação");
        } else if (nota1 < 5) {
            Console.WriteLine("Aluno reprovado");
        } else {
            Console.WriteLine("erro");
        }

        Console.WriteLine("Digite o número (de 1 a 7) para saber o dia da semana");
        string? str2 = Console.ReadLine();
        if (int.TryParse(str2, out var numSemana)){
            Console.WriteLine("Variável convertida");
        } else {
            Console.WriteLine("Não foi possível converter");
        }

        switch (numSemana)
        {
            case 1:
                Console.WriteLine("Segunda");
                break;
            case 2:
                Console.WriteLine("Terça");
                break;
            case 3:
                Console.WriteLine("Quarta");
                break; 
            case 4:
                Console.WriteLine("Quinta");
                break;
            case 5:
                Console.WriteLine("Graças a deus é sexta feira");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default: Console.WriteLine("Não é dia");
                break;
        }

        int codeOK = 200;
        int codeDefault = 404;
        int codeInterno = 500;

        string obterMenssagemHTTPs(int codigo) => codigo switch
        {
            200 => "OK - Sucesso",
            404 => "Não encontrado",
            500 => "Erro no servidor",
            _ => "Código desconhecido"
        };

        Console.WriteLine(obterMenssagemHTTPs(codeOK));
        Console.WriteLine(obterMenssagemHTTPs(codeDefault));
        Console.WriteLine(obterMenssagemHTTPs(codeInterno));

        Console.WriteLine("Escreva 3 números para achar o maior valor");
        string? str3 = Console.ReadLine();
        string? str4 = Console.ReadLine();
        string? str5 = Console.ReadLine();

        int valor1 = 0, valor2 = 0, valor3 = 0;

        if (int.TryParse(str3, out valor1))
        {
            Console.WriteLine($"Variável {str3} convertido para inteiro: {valor1}");
        }
        else
        {
            Console.WriteLine($"Não foi possível converte o número: {str3}");
        }

        if (int.TryParse(str4, out valor2))
        {
            Console.WriteLine($"Variável {str4} convertido para inteiro: {valor2}");
        }
        else
        {
            Console.WriteLine($"Não foi possível converte o número: {str4}");
        }

        if (int.TryParse(str5, out valor3))
        { 
            Console.WriteLine($"Variável {str5} convertido para inteiro: {valor3}");
        }
        else
        { 
            Console.WriteLine($"Não foi possível converte o número: {str5}");
        }

        int maiorValor = (valor1 > valor2)
                ? (valor1 > valor3 ? valor1 : valor3)
                : (valor2 > valor3 ? valor2 : valor3);

        Console.WriteLine($"O maior valor é {maiorValor}");
    }
}