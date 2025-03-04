class E8 {
    public static void exercicio() {
        Console.Write("Digite a nota de 0 a 10: ");
        double nota = double.Parse(Console.ReadLine());

        if (nota < 4) {
            Console.WriteLine("Insuficiente");
        } else if (nota < 6) {
            Console.WriteLine("Regular");
        } else if (nota < 8) {
            Console.WriteLine("Bom");
        } else {
            Console.WriteLine("Excelente");
        }
    }
}