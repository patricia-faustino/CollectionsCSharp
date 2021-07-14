using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPoderDosSets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conjuntos são mais rápidos para fazer buscas por elementos
            //ISet e HashSet são classes genericas dependendo que se seja colocado um tipo
            ISet<string> alunos = new HashSet<string>();
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            Console.WriteLine(alunos);
            Console.WriteLine(string.Join(", ", alunos));

            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");

            Console.WriteLine(string.Join(", ", alunos));

            // ordem


            //removendo ana, adicionando marcelo
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");
            Console.WriteLine(string.Join(", ", alunos));

            //adicionando elemento repetido
            alunos.Add("Fabio Gushiken");

            //ordenando
            //alunos.Sort();

            List<string> alunosEmLista = new List<string>(alunos);
            alunosEmLista.Sort();
            Console.WriteLine(string.Join(", ", alunosEmLista));

            Console.ReadLine();
        }

      
    }
}
