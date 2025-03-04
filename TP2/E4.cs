
class E4
{

    public static void exercicio()
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Digite o telefone: ");
        string telefone = Console.ReadLine();

        Console.Write("Digite o e-mail: ");
        string email = Console.ReadLine();

        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Telefone: {telefone}");
        Console.WriteLine($"E-mail: {email}");
    }
}

