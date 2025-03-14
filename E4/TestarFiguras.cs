using E4;

class TestarFiguras
{
    static void Main()
    {
        Circulo circulo = new Circulo();
        circulo.Raio = 3.0;
        Console.WriteLine(circulo.CalcularArea());

        Esfera esfera = new Esfera();
        esfera.Raio = 5.0;
        Console.WriteLine(esfera.CalcularVolume());
    }
}