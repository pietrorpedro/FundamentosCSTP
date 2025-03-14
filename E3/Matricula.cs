using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3
{
    internal class Matricula
    {
        public string NomeDoAluno;
        public string Curso;
        public int NumeroMatricula;
        public string Situacao;
        public string DataInicial;

        public void Trancar()
        {
            this.Situacao = "Trancada";
        }

        public void Reativar()
        {
            this.Situacao = "Ativa";
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {NomeDoAluno}, Curso: {Curso}, Matricula: {NumeroMatricula}, Situação: {Situacao}, Data Inicial: {DataInicial}");
        }
    }
}
