using System;

namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool fecharApp = false;

            while (fecharApp == false)
            {
                Console.WriteLine("===== Leitor de Dias =====");
                Console.WriteLine("");
                Console.WriteLine("Programa para calcular a quantidade de dias vividos.");
                Console.WriteLine("");

                Console.WriteLine("Qual o seu nome?");
                Console.Write("Digite aqui: ");
                string inputNome = Console.ReadLine();

                Console.WriteLine("");

                Console.Write("Quantidade de anos: ");
                string inputAno = Console.ReadLine();
                int inputAnoNum = int.Parse(inputAno);

                int diasViv = inputAnoNum * 365;

                Console.WriteLine("");
                Console.WriteLine(inputNome + ", voce viveu {0} dias!", diasViv);

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
