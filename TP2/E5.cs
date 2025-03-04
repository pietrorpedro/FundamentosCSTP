class E5
{

    public static void exercicio()
    {
        Console.WriteLine("Digite a temperatura (Celsius):");
        double celcius = double.Parse(Console.ReadLine());

        double fah = celcius * 9 / 5 + 32;
        double kelvin = celcius + 273.15;

        Console.WriteLine($"Fahrenheit: {fah:F2} \nKelvin: {kelvin:F2}");
    }
}