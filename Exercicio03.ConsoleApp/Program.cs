using System;

namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // linhas 9 a 13 = inicio e condicao do while para rodar o programa ate que o usuario deseje parar.

            bool fecharApp = false;

            while (fecharApp == false)
            {
                // linhas 17 a 34 = input de dados, conversao de tipos de dados para utilizacao e declaracao de variaveis utilizadas.

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

                // linhas 38 a 42 = output dos resultados.

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(inputNome + ", voce viveu {0} dias!", diasViv);
                Console.ResetColor();

                Console.WriteLine("");

                // linhas 46 a 76  = inicio e condicao do while de menu de escolha do usuario para sair da aplicao ou permanecer rodando a mesma.

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
