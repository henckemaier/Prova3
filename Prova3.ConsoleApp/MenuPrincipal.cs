using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class MenuPrincipal
    {

        public static void ApresentarMenu()
        {
            while (true)
            {
                string opcao = Console.ReadLine();

                Console.Clear();

                string logo = "─▄▀─▄▀ \n" +
                              "──▀──▀ \n" +
                              "█▀▀▀▀▀█▄\n" +
                              "█░░░░░█─█\n" +
                              "▀▄▄▄▄▄▀▀\n";

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(logo);
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Clube do Livro");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("[1] Ver amigos");

                Console.WriteLine("[2] Ver revistas");

                Console.WriteLine("[3] Ver emprestimos");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[s] Sair");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("Digite o Comando: ");

                if (opcao == "1")
                {
                    MenuAmigo.Apresentar();
                }
                else if (opcao == "2")
                {
                    MenuRevista.Apresentar();
                }
                else if (opcao == "3")
                {
                    MenuEmprestimo.Apresentar();
                }
                else if(opcao == "s")
                {
                    break;
                }
            }
        }
    }
}


