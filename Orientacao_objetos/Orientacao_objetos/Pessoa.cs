using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    internal class Pessoa
    {
        public string nome;
        public int idade;
        public float altura;
        private static int maioridade = 18; // Sendo estático serve para todas as instâncias

        // Construtor
        public Pessoa() {}

        public Pessoa (string nome, int idade, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }

        public void Cumprimentar()
        {
            Console.WriteLine("Seja bem vindo " + this.nome);
        }

        public int AnoMaiorIdade(int anoAtual)
        {
            Console.WriteLine(this.nome + " você tem " + this.idade + " anos");
            return this.idade >= maioridade ? anoAtual + (maioridade - this.idade) : anoAtual - this.idade;
        }

        // Parâmetro por referencia
        public void AdicionarValor(ref int numero)
        {
            Console.WriteLine("Feliz Aniversário!!!");
            numero++;
        }

        // This (que faz referência a classe) 
        // assim parâmetro e variaveis podem ter o mesmo nome
        public void VerificaNome(string nome)
        {
            if (this.nome == nome)
            {
                Console.WriteLine("Nomes iguais");
            } else
            {
                Console.WriteLine("Nomes diferentes");
            }
        }
    }
}
