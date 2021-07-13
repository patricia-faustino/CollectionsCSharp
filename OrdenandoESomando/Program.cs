using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenandoESomando
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo");
            csharpColecoes.Adicionar(new Aula("Trabalhando com Listas", 21));
            Imprimir(csharpColecoes.Aulas);

            csharpColecoes.Adicionar(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adicionar(new Aula("Modelanmdo com Coleções", 12));

            Imprimir(csharpColecoes.Aulas);

            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);

            //ordenar a cópia

            aulasCopiadas.Sort();
            Imprimir(aulasCopiadas);

            // totalizar tempo do curso
            Console.WriteLine(csharpColecoes.TempoTotal);

            Console.WriteLine(csharpColecoes);

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
