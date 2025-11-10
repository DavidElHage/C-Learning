using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
   class VariaveisEConstantes {
        public static void Executar() {
            // area da circunferencia 
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é " + area);

            // Tipos Internos

            bool estaChovendo = true;
            Console.WriteLine("Está Chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("menor Valor Inteiro " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("Populacao " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("Populacao Mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Valor do Computador R$ " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000_000;
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia Entre as Estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#";
            Console.WriteLine(texto);


        }


    }
}
