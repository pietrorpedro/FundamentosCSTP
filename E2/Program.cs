using E2;

class Program
{
    static void Main()
    {
        // 4:
        Ingresso ingresso = new Ingresso("substituido depois", 1, 1);
        ingresso.nomeDoShow = "Show Metallica";
        ingresso.preco = 549.99;
        ingresso.quantidadeDisponivel = 1200;

        ingresso.AlterarPreco(600);
        ingresso.AlterarQuantidade(1000);
        ingresso.ExibirInformacoes();

        // 5:
        Ingresso ingresso5 = new Ingresso("substituido depois", 1, 1);
        ingresso.SetNomeDoShow("Show de Rock");
        ingresso.SetPreco(150.0);
        ingresso.SetQuantidadeDisponivel(500);

        Console.WriteLine($"Nome: {ingresso.GetNomeDoShow()}");
        Console.WriteLine($"Preço: R${ingresso.GetPreco()}");
        Console.WriteLine($"Quantidade: {ingresso.GetQuantidadeDisponivel()}");

        ingresso.SetPreco(180.0);
        ingresso.SetQuantidadeDisponivel(450);

        Console.WriteLine($"Novo Preço: R${ingresso.GetPreco()}");
        Console.WriteLine($"Nova Quantidade: {ingresso.GetQuantidadeDisponivel()}");

        // 6:
        Ingresso ingresso6 = new Ingresso("Show Slipknot", 400, 300);
        ingresso6.ExibirInformacoes();
    }
}