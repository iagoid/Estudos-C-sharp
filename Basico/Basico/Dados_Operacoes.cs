using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basico
{
    internal class Dados_Operacoes
    {

        // Struct
        struct Pessoa
        {
            public string nome;
            public int idade;
            private float altura;
        }

        public static void DadosEOperacoes()
        {
            #region Tipos de dados
            // Inteiro com sinal
            sbyte num1 = 127;
            short num2 = 32767;
            int num3 = 2_147_483_647;
            long num4 = 9_223_372_036_854_775_807;

            // Inteiro sem sinal(positivo)
            byte num5 = 255;
            ushort num6 = 65_535;
            uint num7 = 4_294_967_295;
            ulong num8 = 18_446_744_073_709_551_615;

            num1++; // Se eu adicionar um numero além do limite ele 
            Console.WriteLine(num1);

            // Ponto flutuante
            float real1 = 3.402823e38f; //32bits
            double real2 = 1.79769313486232e307;//64bits
            decimal real3 = 79228162514264337593543950335m;//128bits


            // String e char
            char letra = 'A';
            char letra2 = '\u0041';
            string palavra = "Olá tudo bem?";
            string palavra2 = null;

            // Booleanos
            bool booleano = true;

            // Var
            // O tipo é definido de acordo com o dado que entra nele
            // var variante1;//Não posso declarar sem valor
            var variante2 = "Eae";
            // var variante2 = 1; // Não posso mudar de valor
            var variante3 = 123;


            // Object
            // Valor padrão null, é a base de todos os tipos
            // onde podemos atribuir qualquer valor
            object obj = 123;
            obj = 123.12f;
            obj = 'A';
            obj = "123";
            obj = true;


            // Constantes
            const string constanteString = "NÃO DÁ PRA ALTERAR";
            const int constanteInt = 123;


            // Atribuindo valores ao struct
            Pessoa p2 = new Pessoa()
            {
                nome = "Lucas",
                idade = num3,
            };
            Pessoa p1 = new Pessoa();
            p1.nome = "Iago";
            p1.idade = 20;

            // p1.altura não pode ser atribuida pois é private
            #endregion

            #region Conversões de Tipo
            // Casting, pode ocorrer perda de dados
            float numeroFloat = 257.232f;
            int numeroInt = (int)numeroFloat; // Perde casas decimais
            byte numeroByte = (byte)numeroInt; // Converte para abrangencia dos bytes (pega o modulo do tamanho suportado)
            char letraChar = (char)97; // Converte para char conforme tabela ASCII

            Console.WriteLine("Numero convertido int = " + numeroInt);
            Console.WriteLine("Numero convertido byte = " + numeroByte);
            Console.WriteLine("Numero convertido char = " + letraChar);


            // Parse String -> Numeros
            numeroInt = int.Parse("1986");
            numeroByte = byte.Parse("128");
            numeroFloat = float.Parse("1,12");


            // Classe Convert -> Converte qualquer tipo para qualquer outro tipo
            // Cuidado que alguns valores não podem ser convertidos para outros
            Convert.ToDecimal("2232");
            Convert.ToDouble(2232.54435);
            Convert.ToBoolean(12);
            Convert.ToString(true);
            Convert.ToUInt64('1');
            #endregion

            #region Operadores, Incremento
            // Operadores + - / * %
            int incremento = 0, decremento = 0;
            Console.WriteLine(incremento++); // 0 
            Console.WriteLine(++incremento); // 2
            Console.WriteLine(decremento--); // 0
            Console.WriteLine(--decremento); // -2


            // Operadoder de atribuição
            int valor;
            valor = 10; // 10
            valor += 10; // 20
            valor -= 10; // 10
            valor /= 10; // 1
            valor *= 10; // 10
            valor %= 10; // 10

            // Operadores de igualdade == !=

            // Operadores relacionais > < >= <=

            // Operadores Lógicos && || & |
            /*
             * if(condição1 || condição2 || condição3)
             * Se a condição1 for verdadeira, as condições 2 e 3 NÃO serão verificadas.
             * if(condição1 | condição2 | condição3)
             * Isso verificará as condições 2 e 3, mesmo que 1 já seja verdadeiro. 
             *  aumento de desempenho usando-as.
            */
            #endregion
        }
    }
}
