using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1
{
    internal class Carro
    {
        public string Modelo;
        public string Cor;
        public string velocidade;


        public void ExibirInfo()
        {
            Console.WriteLine($"Modelo: {Modelo}, Cor: {Cor}");
        }

        public void acelerar(int velocidade)
        {
            this.velocidade += velocidade;
        }
    }
}
