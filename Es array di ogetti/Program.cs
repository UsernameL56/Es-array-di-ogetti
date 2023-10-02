using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classe;

namespace Es_array_di_ogetti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire il numero di alunni che si vogliono inserire: ");
            int n = int.Parse(Console.ReadLine());

            Studenti[] studenti = new Studenti[n];

            for(int i = 0; i < n; i++) 
            {
                Console.Clear();
                Console.WriteLine("Inserire il nome dello studente: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Inserire l'età dello studente: ");
                int eta = int.Parse(Console.ReadLine());

                Console.WriteLine("Inserire il votgo dello studente: ");
                int voto = int.Parse(Console.ReadLine());

                studenti[i] = new Studenti(nome, eta, voto);
            }

            Console.Clear();
            Console.WriteLine($"Elenco di tutti gli alunni: {studenti[0].Elenco(studenti)}");
            Console.WriteLine($"Media dei voti di tutti gli alunni: {studenti[0].Media(studenti)}");
        }
    }
}
