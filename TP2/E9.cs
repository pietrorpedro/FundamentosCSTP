class E9
{
    public static void exercicio()
    {
        Console.WriteLine("Salário bruto anual:");
        double salario = double.Parse(Console.ReadLine());

        double taxa = 0.0;
        if (salario <= 30000)
        {
            taxa = 0.0;
        }
        else if (salario <= 60000)
        {
            taxa = (salario - 30000) * 0.15;
        }
        else if (salario <= 96000)
        {
            taxa = (salario - 60000) * 0.20;
        }
        else
        {
            taxa = (salario - 96000) * 0.25;
        }

        double liquido = salario - taxa;

        Console.WriteLine($"Imposto total: {taxa:F2}");
        Console.WriteLine($"Salário líquido: {liquido:F2}");
    }
}