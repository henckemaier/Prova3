using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class Amigo
    {
        public int Id;
        public string Nome;
        public string NomeResponsavel;
        public string Telefone;
        public string Endereco;
        public static List<Amigo> AmigosList = new List<Amigo>();

        public static void AdicionarAmigo(Amigo amigo)
        {
            AmigosList.Add(amigo);
        }

        public static void ExcluirAmigo(Amigo amigo)
        {
            AmigosList.Remove(amigo);
        }

        public static void ListarAmigos()
        {
            foreach(Amigo amigo in AmigosList)
            {
                Console.WriteLine(amigo.ObterInformacao());
            }
        }
        public string ObterInformacao()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return "-----------------------" + "\n" + 
                "id: " + Id + "\n" + 
                "Nome: " + Nome + "\n" + 
                "Nome Responsavel: " + NomeResponsavel + "\n" + 
                "Telefone: " + Telefone + "\n"+ 
                "Endereço: " + Endereco + "\n";
        }
    }
}
