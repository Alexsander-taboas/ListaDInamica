using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista Dinâmica : : Principal
            Lista Agenda = new Lista();

            // cadastrar valores
            Agenda.Inserir("C");
            Agenda.Inserir("B");
            Agenda.Inserir("A");
            Agenda.Inserir("E");
            Agenda.Inserir("D");

            // cadastrar valores em uma posição expecífica
            //Agenda.Inserir("--------------",2);

            // impressão da lista a partir do primeiro elemento
            //Agenda.Imprimir();

            // Excluindo o último registro
            //Agenda.Excluir();

            // impressão da lista depois da 1a. exclusão
            //Console.Clear(); // limpa a tela do console
            Agenda.Imprimir();

            // Excluindo o último registro
            //Agenda.Excluir(2);

            // impressão da lista depois da 1a. exclusão
            Console.WriteLine();
            Console.WriteLine("Após ordenação");
            Agenda.Ordenar();
            //Console.Clear(); // limpa a tela do console
            Agenda.Imprimir();


            // Procurando por um valor na LISTA
            if (Agenda.Pesquisar("Z"))
            {
                Console.WriteLine("Achei o valor pesquisado.");
            }
            else
            {
                Console.WriteLine("Nâo achei o valor.");
            }


            Console.WriteLine("Pressione uma tecla para continuar!");
            Console.ReadKey();

        }
    }
}
