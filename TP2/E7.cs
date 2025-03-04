class E7 {
    public static void exercicio() {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
            Console.WriteLine("par");
        else
            Console.WriteLine("ímpar");
    }
}