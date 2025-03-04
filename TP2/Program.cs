namespace TP2 {
    class Program {
        static void Main(String[] args) {
            Console.WriteLine("Escolha um exercício para executar:");
            Console.WriteLine("1 até 12");

            String escolha = Console.ReadLine();

            switch(escolha) {
                case "1":
                    E1.exercicio();
                    break;
                case "2":
                    E2.exercicio();
                    break;
                case "3":
                    E3.exercicio();
                    break;
                case "4":
                    E4.exercicio();
                    break;
                case "5":
                    E5.exercicio();
                    break;
                case "6":
                    E6.exercicio();
                    break;
                case "7":
                    E7.exercicio();
                    break;
                case "8":
                    E8.exercicio();
                    break;
                case "9":
                    E9.exercicio();
                    break;
                case "10":
                    E10.exercicio();
                    break;
                case "11":
                    E11.exercicio();
                    break;
                case "12":
                    E12.exercicio();
                    break;
            }
        }
    }
}