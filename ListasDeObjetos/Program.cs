using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var aulaIntro = new Aula("Introdução às Coleções", 18);
            var aulaModelando = new Aula("Modelando a Classe Aula", 20);
            var aulaSets = new Aula("Trabalhando com Conjuntos", 15);

            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);
            //Não é possível passar uma string como parametro, pois a lista é do tipo aula
            // seria possível se aula herdasse uma classe que recebesse uma string;
            //aulas.Add("Conclusão");

            Imprimir(aulas);

            //para usar o sort em uma lista de objetos precisamos implementar a interface IComparable
            aulas.Sort();
            Imprimir(aulas);

            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            Imprimir(aulas);

            Console.ReadLine();
        }

        private static void Imprimir(List<Aula> aulas)
        {
            Console.Clear();
            foreach(var aula in aulas)
            {
                //Para imprimir os dados de um objeto necessitamos implementar o método ToString
                Console.WriteLine(aula);
            }
        }
    }

    class Aula  : IComparable
    {
        private string titulo;
        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        public int CompareTo(object obj)
        {
            Aula that = obj as Aula;
            return this.titulo.CompareTo(that.titulo);
        }

        public override string ToString()
        {
            return $"Título: {titulo}, tempo: {tempo} minutos" ;
        }

        
    }
}
