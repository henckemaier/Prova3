using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class Revista
    {
        public string Tipo;
        public int Edicao;
        public string Ano;
        public string CorCaixa;
        public string EtiquetaCaixa;
        public int NumCaixa;
        public static List<Revista> RevistaList = new List<Revista>();

        public static void AdicionarRevista(Revista revista)
        {
            RevistaList.Add(revista);
        }

        public static void ExcluirRevista(Revista revista)
        {
            RevistaList.Remove(revista);
        }

        public static void ListarRevista()
        {
            foreach(Revista revista in RevistaList)
            {
                Console.WriteLine(revista.ObterInformacao());
            }
        }
        public string ObterInformacao()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return "======================" + "\n" + 
                "------Revista-------" + "\n" + 
                "Tipo: " + Tipo + "\n" + 
                "Edição: " + Edicao + "\n" + 
                "Ano: " + Ano + "\n" +
                "------Caixa-------" + "\n" + 
                "Cor da Caixa: " + CorCaixa + "\n" +
                "Etiqueta da Caixa: " + EtiquetaCaixa + "\n" + 
                "Numero da Caixa: " + NumCaixa + "\n" + 
                "======================" + "\n";

        }
    }
}