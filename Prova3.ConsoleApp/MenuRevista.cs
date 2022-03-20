using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class MenuRevista
    {
        public static void Apresentar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Gerenciamento de revistas");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("[1] Cadastrar");
            Console.WriteLine("[2] Listar");
            Console.WriteLine("[3] Excluir");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[s] Sair");
            Console.ResetColor();
            Console.WriteLine();
            Console.Write("Digite o Comando: ");

            string opcao = Console.ReadLine();

            if (opcao == "s")
            {
                Environment.Exit(0);
            }
            else if (opcao == "1")
            {
                RegistrarRevista.Apresentar();
            }
            else if (opcao == "2")
            {
                ListarRevistas.Apresentar();
            }
        }
    }
}
