using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class RegistrarAmigo
    {
        public static void Apresentar()
        {
            Console.Clear();
            Console.WriteLine("Insira um ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira um nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira o nome do responsavel: ");
            string nomeResponsavel = Console.ReadLine();

            Console.WriteLine("Insira o telefone: ");
            string telefone = Console.ReadLine();

            Console.WriteLine("Insira o endereço: ");
            string endereco = Console.ReadLine();

            Amigo amigo = new Amigo();

            amigo.Id = id;
            amigo.Nome = nome; 
            amigo.NomeResponsavel = nomeResponsavel;
            amigo.Telefone = telefone;
            amigo.Endereco = endereco;

            Amigo.AdicionarAmigo(amigo);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Amigo cadastrado!");
            Console.ResetColor();

            Console.ReadKey();
            MenuAmigo.Apresentar();
        }
    }
}
