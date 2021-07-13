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

            /*  string[] aulas = new string[]
              {
                  aulaIntro,
                  aulaModelando,
                  aulaSets
              };*/

            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            Imprimir(aulas);

            //Primeira posição array
            Console.WriteLine(aulas[0]);
            Console.WriteLine(aulas[aulas.Length - 1]);

            aulas[0] = "Trabalhando com arrays";
            Console.WriteLine(aulas[0]);

            //Primeira ocorrência deste objeto
            Console.WriteLine($"Aula modelando está no índice {Array.IndexOf(aulas, aulaModelando)}");

            //Última ocorrência deste objeto
            Console.WriteLine($"Aula modelando está no índice {Array.LastIndexOf(aulas, aulaModelando)}");

            //Reverte a ordem do array
            Array.Reverse(aulas);
            Imprimir(aulas);

            //Reverte a ordem do array
            Array.Reverse(aulas);
            Imprimir(aulas);

            //Reduzindo tamanho de array
            //um novo array é criado com uma nova referência e novo tamanho
            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);

            //ordenando o array
            Array.Sort(aulas);
            Imprimir(aulas);

            //Cópia itens do array
            //Array.Copy(<array_copiado>, <indice_inicial_da_copia>, <array_que_recebe_a_copia>, <indice_inical>, <quantidade_de_elementos_copiados>);
            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            Imprimir(copia);

            //copia identica do array
            string[] clone = aulas.Clone() as string[];
            Imprimir(clone);

            // limpar um array
            // Array.Clear(<array_que_vai_ser_limpo>, <indice_inical>, <quantidade_de_elementos_que_serão_limpos>));
            Array.Clear(clone, 1, 2);
            Imprimir(clone);

            Console.ReadLine();
        }
        private static void Imprimir(string[] aulas)
        {

            /*foreach(var aula in aulas)
            {
                Console.WriteLine(aula);
            }*/

            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }

        }
    }

}
