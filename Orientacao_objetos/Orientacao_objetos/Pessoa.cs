using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        // Destrutor
        ~ Pessoa() {
            Console.WriteLine("Pessoa foi destruida");
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

        // Params permite eu passsar diversos parametros para a função
        public void MostrarIdades(params int[] idades)
        {
            Console.Write("Suas idades: ");
            for (int i = 0; i < idades.Length; i++)
            {
                Console.Write($"{idades[i]}, ");
            }
            Console.WriteLine("anos");
        }

        // Parâmetro por referencia
        // O parâmetro ou argumento deve ser inicializado antes de ser passado para ref.	
        // No método não é necessário atribuir ou inicializar o valor antes de retornar
        // ao método de chamada.
        // Passar um valor por ref é útil quando é necessário modificar o parâmetro de passagem.
        // Quando usamos ref, os dados podem ser passados bidirecionalmente.
        public void AdicionarValor(ref int numero)
        {
            Console.WriteLine("Feliz Aniversário!!!");
            numero++;
        }

        // Parâmetro por out
        // Não é obrigatório inicializar um parâmetro ou argumento antes de ser passado
        // Em seu método é necessário atribuir ou inicializar um valor antes de retornar
        // ao método de chamada.
        // Útil quando precisamos retornar vários valores de uma função ou método.

        public void AdicionarValorOut(out int numero)
        {
            Console.WriteLine("Feliz Aniversário!!!");
            numero = 1;
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
