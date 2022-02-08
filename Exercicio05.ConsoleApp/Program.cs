using System;

namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // linhas 9 a 13 = inicio e condicao do while para rodar o programa ate que o usuario deseje parar.

            bool fecharApp = false;

            while (fecharApp == false)
            {
                // linhas 17 a 29 = input de dados, conversao de tipos de dados para utilizacao e declaracao de variaveis utilizadas.

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

                // linhas 33 a 43 = output dos resultados.

                Console.WriteLine("O salario inicial eh {0}.", inputSalNum);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O salario apos o aumento eh {0}.", Math.Round(valorAumento, 2));
                Console.ResetColor();
                
                Console.ForegroundColor= ConsoleColor.Red;  
                Console.WriteLine("O salario apos a deducao do imposto eh {0}.", Math.Round(valorImposto, 2));
                Console.ResetColor();

                Console.WriteLine("");

                // linhas 47 a 77 = inicio e condicao do while de menu de escolha do usuario para sair da aplicao ou permanecer rodando a mesma apos o uso.

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
