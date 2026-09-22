//Exercícios de - Continue, Return e Break

//-1.Solicite numeros ate o usuario digitar 0; some apenas os positivos (continue)​
//- 2. Leia 5 nomes e pare com break ao encontrar 'Maria'; exiba a posicao​
//- 3.Crie um metodo EhPrimo(n) usando return antecipado​
//- 4. Imprima a tabuada do 1 ao 10 mas pule os multiplos de 3 (continue)​
//- 5. Implemente um jogo de adivinhar numero (1-100) com dicas e break ao acertar


//_______________________________________________________________________
Console.WriteLine("\n\tExercício 1\n");

string? strNumero;
int somaNumero = 0;

List<int> numeros = new List<int>();

do
{
    Console.WriteLine("\nEscreva números positivos a serem contabilizados, digite (0) para sair");
    strNumero = Console.ReadLine();

    if (int.TryParse(strNumero, out int intNumero)) {
        numeros.Add(intNumero);
    } else
    {
        Console.WriteLine($"Entrada: {strNumero}, inválida escreva um número inteiro válido!!");
        continue;
    }

} while (strNumero != "0");

foreach (int numero in numeros)
{
    if (numero <= 0)
    {
        continue;
    }
    somaNumero++;
}

Console.WriteLine($"Total de números positivos {somaNumero}\n");


//_______________________________________________________________________
//- 2. Leia 5 nomes e pare com break ao encontrar 'Maria'; exiba a posicao​
Console.WriteLine("\n\tExercício 2\n");

List<String> listaNomes = new List<string>();

listaNomes = ["Jheniffer Loss", "Ana Paula", "Rafaela Andrade", "Maria", "Bianca Jesus"];

for (int i = 0; i < listaNomes.Count; i++)
{
    if (listaNomes[i] == "Maria")
    {
        Console.WriteLine($"Maria foi encontrada na posição ({i + 1}) da lista. Total da lista == {listaNomes.Count}\n");
    }
}

//_______________________________________________________________________
//- 3.Crie um metodo EhPrimo(n) usando return antecipado​
Console.WriteLine("\n\tExercício 3\n");

bool ehPrimo(int n)
{
    if (n <= 1) return false;
    if (n <= 3) return true;
    if (n % 2 == 0 || n % 3 == 0) return false;

    for (int i = 5; i * i <= n; i += 6)
    {
        if (n % i == 0 || n % (i +  2) == 0)
        {
            return false;
        }
    }

    return true;
}

Console.WriteLine("Verifica se os números são primos");

Console.WriteLine(ehPrimo(1));
Console.WriteLine(ehPrimo(67));
Console.WriteLine(ehPrimo(69));
Console.WriteLine(ehPrimo(9843));
Console.WriteLine(ehPrimo(17));
Console.WriteLine(ehPrimo(51));
Console.WriteLine(ehPrimo(89));
Console.WriteLine(ehPrimo(101));

//_______________________________________________________________________
//- 4. Imprima a tabuada do 1 ao 10 mas pule os multiplos de 3 (continue)​
Console.WriteLine("\n\tExercício 4\n");
Console.WriteLine("\nTabuada do 1 ao 10 (a do 3 sendo exceção)\n");

for (int i = 1; i <= 10; i++)
{
    if (i == 3)
    {
        continue;
    }
    for (int j = 1; j <= 10; j++)
    {
        if (j == 3) 
        { 
            continue; 
        }
        Console.Write($"{j} X {i} = {i * j}\t");
    }
    Console.WriteLine("");
}

//_______________________________________________________________________
//- 5. Implemente um jogo de adivinhar numero (1-100) com dicas e break ao acertar

Console.WriteLine("\n\tExercício 5\n");

Console.WriteLine("JOGO DE ADIVINHAÇÂO DE NÚMERO, ESCOLHA UM NÚMERO DE 1 A 100 E BOA SORTE!!! :)");

Random rand = new Random();
int numeroAleatorio = rand.Next(1, 101);
string strEscolhido;
int tentativas = 0;

do
{
    Console.WriteLine("\nDigite 1 número para procurar");
    strEscolhido = Console.ReadLine();
    if (!int.TryParse(strEscolhido, out int intNumeroEscolhido))
    {
        Console.WriteLine($"Entrada: {strEscolhido}, inválida, escreva um número positivo sendo de 1 até 100");
        continue;
    }

    if (intNumeroEscolhido < 1 || intNumeroEscolhido > 100)
    {
        Console.WriteLine("Escreva um número de 1 até 100");
        continue;
    }

    tentativas++;
    
    if (numeroAleatorio == intNumeroEscolhido) break;
    if (numeroAleatorio > intNumeroEscolhido) Console.WriteLine($"O número é maior que {intNumeroEscolhido}"); 
    else { Console.WriteLine($"O número é menor que {intNumeroEscolhido}"); }

} while(true);

Console.WriteLine($"\nParabéns você adivinhou o número {numeroAleatorio} em {tentativas} tentativas");