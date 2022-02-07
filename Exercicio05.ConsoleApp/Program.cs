using System;

namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool fecharApp = false;

            while (fecharApp == false)
            {
                Console.WriteLine("===== Calculadora de salario =====");
                Console.WriteLine("");
                Console.WriteLine("Programa para calcular o salario dos funcionarios.");
                Console.WriteLine("");

                Console.Write("Insira o salario do funcionario aqui: ");
                string inputSal = Console.ReadLine();
                double inputSalNum = double.Parse(inputSal);

                double valorAumento = inputSalNum + (inputSalNum * 0.15);
                double valorImposto = valorAumento - (valorAumento * 0.08);

                Console.WriteLine("");
                Console.WriteLine("O salario inicial eh {0}.", inputSalNum);
                Console.WriteLine("O salario apos o aumento eh {0}.", Math.Round(valorAumento, 2));
                Console.WriteLine("O salario apos a deducao do imposto eh {0}.", Math.Round(valorImposto, 2));

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
