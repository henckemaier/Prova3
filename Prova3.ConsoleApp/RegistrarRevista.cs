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

            Revista revista = new Revista();

            revista.Tipo = tipo;
            revista.Edicao = edicao;
            revista.Ano = ano;
            revista.CorCaixa = corCaixa;
            revista.EtiquetaCaixa = etiquetaCaixa;
            revista.NumCaixa = numCaixa;

            Revista.AdicionarRevista(revista);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Revista cadastrada!");
            Console.ResetColor();

            Console.ReadKey();
            MenuRevista.Apresentar();
        }
    }
}
