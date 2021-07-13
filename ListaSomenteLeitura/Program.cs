using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSomenteLeitura
{
    class Program
    {
        static void Main(string[] args)
        {

            Curso csharpColecoes = new Curso("C# Collections", "Marcelo");
            csharpColecoes.Adicionar(new Aula("Trabalhando com Listas", 21));
            Imprimir(csharpColecoes.Aulas);

            Console.ReadLine();
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                //Para imprimir os dados de um objeto necessitamos implementar o método ToString
                Console.WriteLine(aula);
            }
        }
    }
}
    

