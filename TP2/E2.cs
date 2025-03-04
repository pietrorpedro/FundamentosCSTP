class E2
{
    public static void exercicio()
    {
        Console.WriteLine("Digite a sua data de nascimento (dd/mm/yyyy):");
        DateTime data = DateTime.Parse(Console.ReadLine());

        DateTime agora = DateTime.Now;
        DateTime proximoAniver = new DateTime(agora.Year, data.Month, data.Day);

        if (proximoAniver < agora)
        {
            proximoAniver = proximoAniver.AddYears(1);
        }

        int diasAte = (proximoAniver - agora).Days;

        Console.WriteLine($"Dias para o próximo aniversário: {diasAte}");
    }
}