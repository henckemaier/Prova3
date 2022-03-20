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

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(">>==============================<<");
            Console.ResetColor();
            Amigo.ListarAmigos();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(">>==============================<<");
            Console.ResetColor();

            string amigoEmprestimo = Console.ReadLine();


            //Console.WriteLine("Amigo já cadastrado em um emprestimo.");
            //RegistrarEmprestimo.Apresentar();



            Console.WriteLine("Insira a revista emprestada: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(">>==============================<<");
            Console.ResetColor();
            Revista.ListarRevista();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(">>==============================<<");
            Console.ResetColor();

            string revistaEmprestada = Console.ReadLine();

            Console.WriteLine("Deseja fazer: [1]Emprestimo [2]Reserva");
            OpcaoEmprestimoReserva(amigoEmprestimo, revistaEmprestada); //Escolher emprestimo ou reserva

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Emprestimo cadastrada!");
            Console.ResetColor();

            Console.ReadKey();
            MenuEmprestimo.Apresentar();
        }
        #region Escolher emprestimo ou reserva
        private static void OpcaoEmprestimoReserva(string amigoEmprestimo, string revistaEmprestada)
        {
            string opcaoEmpRes = Console.ReadLine();

            if (opcaoEmpRes == "1")
            {
                Console.WriteLine("Data do emprestimo setada para: " + DateTime.Now.ToString("dd/MM/yyyy"));
                DateTime dataEmprestimo = DateTime.Now;

                Console.WriteLine("Insira a data da devolução: ");
                DateTime dataDevolucao = DateTime.Parse(Console.ReadLine());


                Emprestimo emprestimo = new Emprestimo();

                emprestimo.OpcaoDeResultado = " emprestimo ";
                emprestimo.AmigoEmprestimo = amigoEmprestimo;
                emprestimo.RevistaEmprestada = revistaEmprestada;
                emprestimo.DataEmprestimo = dataEmprestimo;
                emprestimo.DataDevolucao = dataDevolucao;


                Emprestimo.AdicionarEmprestimo(emprestimo);

            }
            else if (opcaoEmpRes == "2")
            {


                Console.WriteLine("Data da reserva setada para: " + DateTime.Now.ToString("dd/MM/yyyy"));
                DateTime dataEmprestimo = DateTime.Now;

                Console.WriteLine("Data da devolução: " + DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"));
                DateTime dataDevolucao = DateTime.Now.AddDays(2);

                Emprestimo emprestimo = new Emprestimo();

                emprestimo.OpcaoDeResultado = " reserva ";
                emprestimo.AmigoEmprestimo = amigoEmprestimo;
                emprestimo.RevistaEmprestada = revistaEmprestada;
                emprestimo.DataEmprestimo = dataEmprestimo;
                emprestimo.DataDevolucao = dataDevolucao;

                Emprestimo.AdicionarEmprestimo(emprestimo);
            }
        }
        #endregion 
    }
}
