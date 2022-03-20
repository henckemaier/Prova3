using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class RegistrarRevista
    {
        public static void Apresentar()
        {
            Console.Clear();

            Console.WriteLine("Insira um tipo: ");
            string tipo = Console.ReadLine();

            Console.WriteLine("Insira a edição: ");
            int edicao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o ano: ");
            string ano = Console.ReadLine();

            Console.WriteLine("Insira a cor da caixa: ");
            string corCaixa = Console.ReadLine();

            Console.WriteLine("Insira a etiqueta: ");
            string etiquetaCaixa = Console.ReadLine();

            Console.WriteLine("Insira o numero da caixa: ");
            int numCaixa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a categoria da revista: ");
            Console.WriteLine("[1] Novidade");
            Console.WriteLine("[2] Bom estado");
            Console.WriteLine("[3] Antiga");
            string opcaoCategoria = Console.ReadLine();

            Revista revista = new Revista();

            if(opcaoCategoria == "1")
            {
                revista.Tipo = tipo;
                revista.Edicao = edicao;
                revista.Ano = ano;
                revista.CorCaixa = corCaixa;
                revista.EtiquetaCaixa = etiquetaCaixa;
                revista.NumCaixa = numCaixa;
                revista.OpcaoCategoria = "Novidade";

                Revista.AdicionarRevista(revista);
            }
            else if (opcaoCategoria == "2")
            {
                revista.Tipo = tipo;
                revista.Edicao = edicao;
                revista.Ano = ano;
                revista.CorCaixa = corCaixa;
                revista.EtiquetaCaixa = etiquetaCaixa;
                revista.NumCaixa = numCaixa;
                revista.OpcaoCategoria = "Bom estado";

                Revista.AdicionarRevista(revista);
            }
            else if (opcaoCategoria == "3")
            {
                revista.Tipo = tipo;
                revista.Edicao = edicao;
                revista.Ano = ano;
                revista.CorCaixa = corCaixa;
                revista.EtiquetaCaixa = etiquetaCaixa;
                revista.NumCaixa = numCaixa;
                revista.OpcaoCategoria = "Antiga";

                Revista.AdicionarRevista(revista);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Revista cadastrada!");
            Console.ResetColor();

            Console.ReadKey();
            MenuRevista.Apresentar();
        }
    }
}
