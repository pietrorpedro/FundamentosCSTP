class E12
{
    public static void exercicio()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);

        bool ganhou = false;
        do
        {
            Console.WriteLine("Digite a sua tentativa:");
            int tentativa = int.Parse(Console.ReadLine());

            if (tentativa == numeroAleatorio)
            {
                ganhou = true;
            }
            else
            {
                if (tentativa < numeroAleatorio)
                {
                    Console.WriteLine("Seu número é menor do que o número aleatório");
                }
                if (tentativa > numeroAleatorio)
                {
                    Console.WriteLine("Seu número é maior do que o número aleatório");
                }
            }

        } while (!ganhou);

        Console.WriteLine($"Você ganhou! O número era: {numeroAleatorio}");
    }
}