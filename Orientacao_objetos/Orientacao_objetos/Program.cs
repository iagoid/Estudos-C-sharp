using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_objetos
{
    internal class Program
    {
        delegate void Operacao(int num1, int num2);

        static void Main(string[] args)
        {
            // Para adicionar um arquivo de classe basta 
            // clicar com o botão direito no projeto-->add-->class
            Pessoa clsPessoa = new Pessoa("Cleiton", 20, 1.80f); // Construtor
            clsPessoa.nome = "Lucas";
      
            Pessoa clsPessoa1 = new Pessoa()
            {
                nome = "Iago",
                idade = 20
            };
            clsPessoa1.Cumprimentar();

            int anoVotar = clsPessoa1.AnoMaiorIdade(DateTime.Now.Year);
            Console.WriteLine("Maior de idade em " + anoVotar);

            clsPessoa1.MostrarIdades(1, 33, 54, 54, 65, 343);

            clsPessoa1.AdicionarValor(ref clsPessoa1.idade); // Passar ref aqui
            clsPessoa1.AdicionarValorOut(out int idade); // Passar valor por out
            Console.WriteLine($"Idade de saida do out {idade}");

            clsPessoa1.AnoMaiorIdade(DateTime.Now.Year);
            clsPessoa.VerificaNome("Emerson");

            #region Sobrecarga de Metodos
            Sobrecarga clsSobrecarga = new Sobrecarga();
            clsSobrecarga.MetodoComSobrecarga(1111111);
            clsSobrecarga.MetodoComSobrecarga("Metodo com sobrecarga");
            clsSobrecarga.MetodoComSobrecarga("Ocorre quando um metodo recebe", "diferentes tipos ou números de parâmetros");
            Console.WriteLine("\n\n");
            #endregion

            #region Delegate
            // Acaba se comportando como uma "lista" de metodos
            // ao executar chama todos os metodos adicionados
            Delegate d = new Delegate();
            Operacao conta = null;

            conta += d.Somar;
            conta += d.Subtrair;
            conta += d.Multiplicar;
            conta += d.Dividir;

            conta(10, 5);
            conta -= d.Subtrair;
            conta -= d.Multiplicar;
            conta -= d.Dividir;
            conta(20, 5);
            #endregion

            #region Classes estatica
            ClasseEstatica.taxa = 10;
            Console.WriteLine("Taxa --> "+ ClasseEstatica.Adicionar(100));
            Console.WriteLine("Taxa --> "+ ClasseEstatica.Diminuir(50));
            #endregion

            #region Getters e Setters
            Get_Set clsGetSet = new Get_Set();
            clsGetSet.Nome = "Iago";
            clsGetSet.Descricao = "Programador";
            clsGetSet.Idade = 20;
            Console.WriteLine(clsGetSet.Nome + " " + clsGetSet.Idade + " anos - " +
                clsGetSet.Descricao + " " + clsGetSet.ValorPadrao);
            #endregion

            #region Herança
            // Veiculo clsVeiculo = new Veiculo(); // Não posso pois é abstrata
            Carro clsCarro = new Carro();
            Bicicleta clsBicicleta = new Bicicleta();
            clsCarro.Acelerar(); // Metodo abstrato
            clsCarro.Freiar(); // Metodo herdado
            clsCarro.LigarMotor(); // Metodo próprio

            clsBicicleta.Acelerar(); // Metodo abstrato
            clsBicicleta.Freiar(); // Metodo herdado
            clsBicicleta.Pedalar(); // Metodo próprio


            CachorroCaramelo clsCaramelo = new CachorroCaramelo();
            Shitzu clsShitzu = new Shitzu();

            Console.WriteLine("\nCaramelo ");
            clsCaramelo.Ambiente(); // Não pode modificar, herdando de CanisLupusFamiliaris
            clsCaramelo.Curiosidade(); // Modificou o metodo

            Console.WriteLine("\nShit-zu ");
            clsShitzu.Ambiente(); // Não pode modificar, herdando de CanisLupusFamiliaris
            clsShitzu.Curiosidade(); // Usou o metodo padrão nos mamíferos
            #endregion

            #region Polimorfismo
            // Cada forma tem um comportamento difernte 
            // conforme a sua instância
            Forma af = new Forma();
            Forma bf = new Triangulo();
            Forma cf = new Circulo();
            Forma df = new Retangulo();

            af.Desenhar();
            bf.Desenhar();
            cf.Desenhar();
            df.Desenhar();

            #endregion

            Console.Read();
        }
    }

    // Também é possível criar duas classes em um mesmo arquivo
    // Mas não é muito recomendado
    class MinhaClasse
    {}
}
