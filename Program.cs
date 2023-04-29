internal class Program
{
    private static void Main(string[] args)
    {
        //WriteLine é na linha de baixo
        //Write na mesma linha

        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        string idade = Console.ReadLine();

        Console.WriteLine($"Olá {nome}, você tem {idade} anos.");
    }

}