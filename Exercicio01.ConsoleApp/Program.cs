using System;

namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool fecharApp = false;

            while (fecharApp == false)
            {
                Console.WriteLine("===== Imobiliaria Imobilis =====");
                Console.WriteLine("");
                Console.WriteLine("Programa para calcular a area do terreno.");
                Console.WriteLine("");

                Console.Write("Digite, em metros, a largura de base do terreno: ");
                string baseTerr = Console.ReadLine();
                Console.Write("Digite, em metros, a largura de altura do terreno: ");
                string altrTerr = Console.ReadLine();
                Console.WriteLine("");

                double baseTerrNum = double.Parse(baseTerr);
                double altrTerrNum = double.Parse(altrTerr);

                double areaTerr = baseTerrNum * altrTerrNum;

                Console.WriteLine("A area do terreno, em metros, eh: {0}", areaTerr);

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
