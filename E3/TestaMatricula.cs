using E3;

class TestaMatricula
{
    static void Main()
    {
        Matricula matricula = new Matricula();
        matricula.NomeDoAluno = "Pietro";
        matricula.Curso = "Engenharia de Software";
        matricula.NumeroMatricula = 111222333;
        matricula.DataInicial = "24/01/2024";
        matricula.Situacao = "Ativa";

        matricula.ExibirInformacoes();

        matricula.Trancar();
        matricula.ExibirInformacoes();

        matricula.Reativar();
        matricula.ExibirInformacoes();
    }
}