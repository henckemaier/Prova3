using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class MenuAmigo
    {
        public static void Apresentar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Gerenciamento de amigos");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("1 -> Cadastrar");
            Console.WriteLine("2 -> Listar");
            Console.WriteLine("3 -> Exlcluir");
            Console.WriteLine();
            Console.WriteLine("0 -> Sair");
            Console.WriteLine();
            Console.Write("Opção: ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 0)
            {
                Environment.Exit(0);
            }
            else if (opcao == 1)
            {
                RegistrarAmigo.Apresentar();
            }
            else if (opcao == 2)
            {
                ListarAmigos.Apresentar();
            }


        }
    }
}
