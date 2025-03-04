class E10 {
    public static void exercicio() {
        Console.Write("Número para a contagem: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i >= 0; i--)
        {
            Console.Write(i);
            if (i != 0) Console.Write(", ");
        }
    }
}