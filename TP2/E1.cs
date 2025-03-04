
class E1
{
    public static void exercicio()
    {
        Console.WriteLine("Digite a sua data de nascimento (dd/mm/yyyy):");
        DateTime data = DateTime.Parse(Console.ReadLine());

        DateTime now = DateTime.Now;

        int anos = now.Year - data.Year;
        if (now.Month < data.Month || (now.Month == data.Month && now.Day < data.Day))
        {
            anos--;
        }

        int meses = now.Month - data.Month;
        if (now.Day < data.Day)
        {
            meses--;
        }

        if (meses < 0)
        {
            meses += 12;
        }

        int dias = (now - data.AddYears(anos).AddMonths(meses)).Days;

        Console.WriteLine($"Idade: {anos} \nMeses: {meses} \nDias: {dias}");
    }
}