using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class RegistrarEmprestimo
    {
        public static void Apresentar()
        {
            Console.Clear();

            Console.WriteLine("Insira o amigo que pegou a revista: ");
            string amigoEmprestimo = Console.ReadLine();

            Console.WriteLine("Insira a revista emprestada: ");
            string revistaEmprestada = Console.ReadLine();

            Console.WriteLine("Data do emprestimo setada para: " + DateTime.Now.ToString("dd/MM/yyyy"));
            DateTime dataEmprestimo = DateTime.Now;

            Console.WriteLine("Insira a data da devolução: ");
            DateTime dataDevolucao = DateTime.Parse(Console.ReadLine());

            Emprestimo emprestimo = new Emprestimo();

            emprestimo.AmigoEmprestimo = amigoEmprestimo;
            emprestimo.RevistaEmprestada = revistaEmprestada;
            emprestimo.DataEmprestimo = dataEmprestimo;
            emprestimo.DataDevolucao = dataDevolucao;
 
            Emprestimo.AdicionarEmprestimo(emprestimo);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Emprestimo cadastrada!");
            Console.ResetColor();

            Console.ReadKey();
            MenuEmprestimo.Apresentar();
        }
    }
}
