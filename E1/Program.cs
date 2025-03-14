
using E1;

class Program
{
    static void Main()
    {
        Carro carro = new Carro();

        carro.Modelo = "Kombi";
        carro.Cor = "Branco";

        carro.ExibirInfo();
    }
}