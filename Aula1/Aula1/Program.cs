//Console.WriteLine("Hello, World!");

// Aula 1: C# Software Developmente
class Program {
    static void Main(string[] args){
        //Variáveis locais
        string nome;
        string curso;
        int idade;

        //Dados usuáio
        Console.WriteLine("Salve");
        Console.WriteLine("Qual o seu nome?");

        nome = Console.ReadLine();

        Console.WriteLine("Bem vindo " + nome);
        Console.WriteLine("Qual a sua idade? ");
        idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Qual o seu curso? ");
        curso = Console.ReadLine();

        //Printa dados de usuário no console 
        Console.WriteLine("===Dados Usuário===");
        Console.WriteLine($"Nome: {nome} \nIdade: {idade} \nCurso: {curso}");
    }
}