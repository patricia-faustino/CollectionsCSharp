using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            /*List<string> aulas = new List<string>
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };*/

            //Array dinâmico: se acomoda de acordo com os elementos que contem
            List<string> aulas = new List<string>();

            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);

            Console.WriteLine($"A primeira aula é {aulas[0]}");
            Console.WriteLine($"A primeira aula é {aulas.First()}");

            Console.WriteLine($"A última aula é {aulas[aulas.Count - 1]}");
            Console.WriteLine($"A última aula é {aulas.Last()}");

            Console.ReadLine();
        }
        private static void Imprimir(List<string> aulas)
        {
            /*foreach(var aula in aulas)
            {
                Console.WriteLine(aula);
            }*/

            /*for(int i = 0; i < aulas.Count; i++)
            {
                Console.WriteLine(aulas[0]);
            }*/

            aulas.ForEach(aula => {
                Console.WriteLine(aula);
                });
        }
    }

}
