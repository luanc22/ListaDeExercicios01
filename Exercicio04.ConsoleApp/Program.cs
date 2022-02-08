using System;

namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // linhas 9 a 13 = inicio e condicao do while para rodar o programa ate que o usuario deseje parar.

            bool fecharApp = false;

            while (fecharApp == false)
            {
                // linhas 17 a 28 = input de dados, conversao de tipos de dados para utilizacao e declaracao de variaveis utilizadas.

                Console.WriteLine("===== Conversor de Temperatura =====");
                Console.WriteLine("");
                Console.WriteLine("Programa para converter a temperatura.");
                Console.WriteLine("");

                Console.Write("Digite a temperatura em celsius: ");
                string inputCel = Console.ReadLine();
                double inputCelNum = double.Parse(inputCel);

                double CelToFahr = (inputCelNum * 1.8) + 32;

                Console.WriteLine("");

                // linhas 32 a 45 = output dos resultados.

                if (inputCelNum <= 15)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("A temperatura em Fahrenheit fica {0}.", CelToFahr);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A temperatura em Fahrenheit fica {0}.", CelToFahr);
                    Console.ResetColor();
                }

                Console.WriteLine("");

                // linhas 49 a 79 = inicio e condicao do while de menu de escolha do usuario para sair da aplicao ou permanecer rodando a mesma.

                bool opcaoValida = false;

                while (opcaoValida == false)
                {
                    Console.WriteLine("Caso deseje realizar outra operacao, digite 1 e aperte ENTER.");
                    Console.WriteLine("Caso deseje fechar o programa, digite 0 e aperte ENTER.");
                    Console.Write("Opcao escolhida: ");
                    string fecharBotao = Console.ReadLine();

                    if (fecharBotao == "0")
                    {
                        fecharApp = true;
                        opcaoValida = true;
                    }
                    else if (fecharBotao == "1")
                    {
                        Console.Clear();
                        opcaoValida = true;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opcao invalida, selecione uma opcao valida!");
                        Console.ResetColor();
                        Console.WriteLine("");
                        Console.WriteLine("Aperte ENTER para prosseguir.");
                        Console.ReadLine();
                        continue;
                    }
                }
            }
        }
    }
}
