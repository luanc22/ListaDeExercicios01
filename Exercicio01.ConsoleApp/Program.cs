using System;

namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // linhas 9 a 13 = inicio e condicao do while para rodar o programa ate que o usuario deseje parar.

            bool fecharApp = false;

            while (fecharApp == false)
            {
                // linhas 17 a 32 = input de dados, conversao de tipos de dados para utilizacao e declaracao de variaveis utilizadas.

                Console.WriteLine("===== Imobiliaria Imobilis =====");
                Console.WriteLine("");
                Console.WriteLine("Programa para calcular a area do terreno.");
                Console.WriteLine("");

                Console.Write("Digite, em metros, a largura de base do terreno: ");
                string baseTerr = Console.ReadLine();
                Console.Write("Digite, em metros, a largura de altura do terreno: ");
                string altrTerr = Console.ReadLine();

                double baseTerrNum = double.Parse(baseTerr);
                double altrTerrNum = double.Parse(altrTerr);

                double areaTerr = baseTerrNum * altrTerrNum;

                Console.WriteLine("");

                // linhas 36 a 38 = output dos resultados.

                Console.WriteLine("A area do terreno, em metros, eh: {0}", areaTerr);

                Console.WriteLine("");

                // linhas 42 a 72 = inicio e condicao do while de menu de escolha do usuario para sair da aplicao ou permanecer rodando a mesma.

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
