using System;

namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Padaria Hotpao =====");
            Console.WriteLine("");
            Console.WriteLine("Programa para a quantidade de paes e broas vendidos diariamente.");
            Console.WriteLine("");

            Console.Write("Digite a quantidade de paes vendidos no dia: ");
            string qtdPaes = Console.ReadLine();
            Console.Write("Digite a quantidade de broas vendidas no dia: ");
            string qtdBroas = Console.ReadLine();
            Console.WriteLine("");

            double qtdPaesNum = double.Parse(qtdPaes);
            double qtdBroasNum = double.Parse(qtdBroas);

            double somaTotal = (qtdPaesNum * 0.12) + (qtdBroasNum * 1.5);
            double qtdGuardar = somaTotal * 0.10;

            if (somaTotal <= 1)
            {
                Console.WriteLine("O valor total do dia foi de {0} centavos.", Math.Round(somaTotal, 2));
            }
            else
            {
                Console.WriteLine("O valor total do dia foi de {0} reais.", Math.Round(somaTotal, 2));
            }

            if (qtdGuardar <= 1)
            {
                Console.WriteLine("O valor a guardar na poupanca eh {0} centavos.", Math.Round(qtdGuardar, 2));
            }
            else
            {
                Console.WriteLine("O valor a guardar na poupanca eh {0} reais.", Math.Round(qtdGuardar, 2));
            }

            Console.WriteLine("");
            Console.WriteLine("Aperte ENTER para fechar o programa.");
            Console.ReadLine();

        }
    }
}
