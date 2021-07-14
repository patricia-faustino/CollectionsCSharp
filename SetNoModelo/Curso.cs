using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetNoModelo
{
    class Curso
    {
        private ISet<Aluno> alunos = new HashSet<Aluno>();

        private IList<Aula> aulas;

        private string nome;

        private string intrutor;

        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        public IList<Aula> Aulas
        {
            //Lista somente de leitura, mas nossa lista deve ser do tipo IList
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Instrutor
        {
            get { return intrutor; }
            set { intrutor = value; }
        }
        public int TempoTotal
        {
            get
            {
                /*int total = 0;
                foreach(var aula in aulas)
                {
                    total += aula.Tempo;
                }
                return total;*/
                // LINQ = Language Integrated Query
                //Consulta Integrada à Linguagem

                return aulas.Sum(aula => aula.Tempo);
            }
        }

        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public Curso(string nome, string intrutor)
        {
            this.aulas = new List<Aula>();
            this.nome = nome;
            this.intrutor = intrutor;
        }

        internal void Adicionar(Aula aula)
        {
            this.aulas.Add(aula);
        }

        public override string ToString()
        {
            return $"Curso: {nome}, Tempo Total: {TempoTotal}, Aulas: {string.Join(", ", aulas)}";
        }


    }
}
