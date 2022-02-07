using System;

namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool fecharApp = false;

            while (fecharApp == false)
            {
                Console.WriteLine("===== Conversor de Temperatura =====");
                Console.WriteLine("");
                Console.WriteLine("Programa para converter a temperatura.");
                Console.WriteLine("");

                Console.Write("Digite a temperatura em celsius: ");
                string inputCel = Console.ReadLine();
                double inputCelNum = double.Parse(inputCel);

                double CelToFahr = (inputCelNum * 1.8) + 32;
                Console.WriteLine("");
                Console.WriteLine("A temperatura em Fahrenheit fica {0}.", CelToFahr);

                Console.WriteLine("");
                Console.WriteLine("Caso deseje continuar a usar o programa, digite 1 e aperte ENTER.");
                Console.WriteLine("Caso deseje fechar o programa, digite 0 e aperte ENTER.");

                Console.Write("Opcao escolhida: ");
                string inputFecharApp = Console.ReadLine();

                if (inputFecharApp == "0")
                {
                    fecharApp = true;
                }
                else
                {
                    Console.Clear();
                    continue;
                }
            }

        }
    }
}
