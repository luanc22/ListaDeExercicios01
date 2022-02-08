using System;

namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // linhas 11 a 27 = input de dados, conversao de tipos de dados para utilizacao e declaracao de variaveis utilizadas.

            Console.WriteLine("===== Padaria Hotpao =====");
            Console.WriteLine("");
            Console.WriteLine("Programa para a quantidade de paes e broas vendidos diariamente.");
            Console.WriteLine("");

            Console.Write("Digite a quantidade de paes vendidos no dia: ");
            string qtdPaes = Console.ReadLine();
            Console.Write("Digite a quantidade de broas vendidas no dia: ");
            string qtdBroas = Console.ReadLine();

            double qtdPaesNum = double.Parse(qtdPaes);
            double qtdBroasNum = double.Parse(qtdBroas);

            double somaTotal = (qtdPaesNum * 0.12) + (qtdBroasNum * 1.5);
            double qtdGuardar = somaTotal * 0.10;

            Console.WriteLine("");

            // linhas 33 a 57 = condicoes para cada situacao + output do resultado.

            if (somaTotal <= 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O valor total do dia foi de {0} centavos.", Math.Round(somaTotal, 2));
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O valor total do dia foi de {0} reais.", Math.Round(somaTotal, 2));
                Console.ResetColor();
            }

            if (qtdGuardar <= 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O valor a guardar na poupanca eh {0} centavos.", Math.Round(qtdGuardar, 2));
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O valor a guardar na poupanca eh {0} reais.", Math.Round(qtdGuardar, 2));
                Console.ResetColor();
            }

            Console.WriteLine("");

            // linhas 61 e 62 = finalizacao do programa.

            Console.WriteLine("Aperte ENTER para fechar o programa.");
            Console.ReadLine();

        }
    }
}
