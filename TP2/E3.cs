
class E3
{
    public static void exercicio()
    {
        Console.WriteLine("Digite a primeira data (dd/mm/yyyy):");
        DateTime data1 = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda data (dd/mm/yyyy):");
        DateTime data2 = DateTime.Parse(Console.ReadLine());

        TimeSpan dif = data2 - data1;

        int anos = (int)(dif.TotalDays / 365.25);
        int meses = (int)((dif.TotalDays % 365.25) / 30.44);
        int dias = (int)((dif.TotalDays % 365.25) % 30.44);

        Console.WriteLine($"Anos: {anos} \nMeses: {meses} \nDias: {dias}");

    }
}
