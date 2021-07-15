using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frutas = new List<string>
            {
                "abacate", "banana", "caqui", "damasco",  "figo"
            };

            foreach(var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            //Para adicões e remoções o List perde desempenho, há uma opção que é o LinkedList

            //instanciando uma nova lista ligada: dias da semana
            LinkedList<string> dias = new LinkedList<string>();
            //adicionando um dia qualquer: "quarta"
            //Para adicionar o primeiro elemento utilizamos o AddFirst
            var d4 = dias.AddFirst("quarta");

            //mas e o valor "quarta"? está na propriedade d4.Value
            Console.WriteLine("d4.Value: " + d4.Value);

            var d2 = dias.AddBefore(d4, "segunda");

            var d3 = dias.AddAfter(d2, "terça");

            var d6 = dias.AddAfter(d4, "sexta");

            var d7 = dias.AddAfter(d6, "sábado");

            var d5 = dias.AddBefore(d6, "quinta");

            var d1 = dias.AddBefore(d2, "domingo");

            // O LinkedList não dá suporte para trabalharmos com for
            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            //para fazer buscas especificas podemos utilizar o Find mas perdemos desempenho 

            var quarta = dias.Find("quarta");

            dias.Remove("quarta");
            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            Console.ReadLine();

        }
    }
}
