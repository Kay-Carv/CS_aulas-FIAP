//-  1.Solicite dois numeros ao usuario e exiba a soma, subtracao, multiplicacao e divisao
//-  2. Converta a entrada com TryParse e trate erros com mensagem amigavel
//-  3. Calcule a media de 3 notas e diga se o aluno foi aprovado (media >= 6)
//-  4. Declare uma variavel nullable (int?) e use ?? para padronizar o valor
//-  5. Demonstre cast explicito de double para int e observe a perda

namespace Aula1 {
    public class Aula3
    {
        static void Main()
        {
            string? str1;
            string? str2;

            Console.WriteLine("Escreva o primeiro número: ");
            str1 = Console.ReadLine();

            Console.WriteLine("Escreva o segundo número: ");
            str2 = Console.ReadLine();

            //int num1 = int.Parse(str1);
            //int num2 = int.Parse(str2);

            //Não foi possível converter o número
            if (int.TryParse(str1, out int num1))
            {
                Console.WriteLine($"Variável {str1} convertido para inteiro: {num1}");
            }
            else
            {
                Console.WriteLine($"Não foi possível converte o número: {str1}");
            }

            if (int.TryParse(str2, out int num2))
            {
                Console.WriteLine($"Variável {str2} convertido para inteiro: {num2}");
            }
            else
            {
                Console.WriteLine($"Não foi possível converte o número: {str2}");
            }

            int operacaoSoma = num1 + num2;
            int operacaoSubtracao = num1 - num2;
            int operacaoDivisao = num1 / num2;
            int operacaoMultiplicacao = num1 * num2;

            Console.WriteLine($"Soma: {operacaoSoma}");
            Console.WriteLine($"Subtração: {operacaoSubtracao}");
            Console.WriteLine($"Divisão: {operacaoDivisao}");
            Console.WriteLine($"Multiplicação: {operacaoMultiplicacao}");


            //Exercício 3
            Console.WriteLine("Verificando média de notas");
            double nota1 = 5.6;
            double nota2 = 9.6;
            double nota3 = 6.2;

            double somaNotas = nota1 + nota2 + nota3;
            double media = somaNotas / 3;

            if (media >= 6)
            {
                Console.WriteLine($"O aluno passou de ano com média de: {media}");
            }
            else
            {
                Console.WriteLine($"O aluno reprovou de ano com média de: {media}");
            }


            //Exercício 4
            int? variavelNullable = null;
            int valorPadraoNulo = variavelNullable ?? 0;

            Console.WriteLine($"Variável nula com valor padrão igual a zero: {valorPadraoNulo}");

            //Exercício 5 5. Demonstre cast explicito de double para int e observe a perda
            double numDecimal = 5.69;
            Console.WriteLine($"Valor do tipo double: {numDecimal}");
            int numInteiro = (int)numDecimal;
            Console.WriteLine($"Mesmo valor double transformado para inteiro: {numInteiro}");
        }

    }
}