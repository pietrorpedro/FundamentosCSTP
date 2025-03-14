using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2
{
    internal class Ingresso
    {
        public string nomeDoShow;
        public double preco;
        public int quantidadeDisponivel;

        public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
        {
            this.nomeDoShow = nomeDoShow;
            this.preco = preco;
            this.quantidadeDisponivel = quantidadeDisponivel;
        }

        public void AlterarPreco(double novoPreco)
        {
            this.preco = novoPreco;
        }

        public void AlterarQuantidade(int novaQuantidade)
        {
            this.quantidadeDisponivel = novaQuantidade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome do show: {nomeDoShow}, Preço: {preco}, Quantidade disponível: {quantidadeDisponivel}");
        }

        public string GetNomeDoShow()
        {
            return nomeDoShow;
        }

        public void SetNomeDoShow(string novoNome)
        {
            nomeDoShow = novoNome;
        }

        public double GetPreco()
        {
            return preco;
        }

        public void SetPreco(double novoPreco)
        {
            preco = novoPreco;
        }

        public int GetQuantidadeDisponivel()
        {
            return quantidadeDisponivel;
        }

        public void SetQuantidadeDisponivel(int novaQtd)
        {
            quantidadeDisponivel = novaQtd;
        }
    }
}
