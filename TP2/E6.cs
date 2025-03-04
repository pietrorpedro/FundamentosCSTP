class E6
{
    public static void exercicio()
    {
        Console.Write("Digite seu peso (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite sua altura (cm): ");
        double alturaCm = Convert.ToDouble(Console.ReadLine());
        
        double alturaM = alturaCm / 100;
        double imc = peso / (alturaM * alturaM);
        
        string classificacao;
        if (imc < 18.5) classificacao = "Abaixo do peso";
        else if (imc < 24.9) classificacao = "Peso normal";
        else if (imc < 29.9) classificacao = "Sobrepeso";
        else if (imc < 34.9) classificacao = "Obesidade grau 1";
        else if (imc < 39.9) classificacao = "Obesidade grau 2";
        else classificacao = "Obesidade grau 3";
        
        Console.WriteLine($"Seu IMC é: {imc:F2} - {classificacao}");
    }
}