using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class Emprestimo
    {
        public string AmigoEmprestimo;
        public string RevistaEmprestada;
        public DateTime DataEmprestimo;
        public DateTime DataDevolucao;
        public string OpcaoDeResultado;
        public static List<Emprestimo> EmprestimoList = new List<Emprestimo>();

        public static void AdicionarEmprestimo(Emprestimo emprestimo)
        {
            EmprestimoList.Add(emprestimo);
        }

        public static void ExcluirEmprestimo(Emprestimo emprestimo)
        {
            EmprestimoList.Remove(emprestimo);
        }

        public static void ListarEmprestimo()
        {
            foreach (Emprestimo emprestimo in EmprestimoList)
            {
                Console.WriteLine(emprestimo.ObterInformacao());
            }
        }
        public string ObterInformacao()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return "-------------------------------" + "\n" +
               "Pessoa emprestada: " + AmigoEmprestimo + "\n" +
               "Revista emprestada: " + RevistaEmprestada + "\n" +
               "Data do " + OpcaoDeResultado + ": " + DataEmprestimo.ToString("dd/MM/yyyy") + "\n" +
               "Data de devolução: " + DataDevolucao.ToString("dd/MM/yyyy") + "\n";
        }
    }
}
