using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicionariosA1
{
    class Curso
    {
        //implementando um dicionário de alunos
        private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();

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
            this.alunos.Add(aluno);
            this.dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
        }

        public Curso(string nome, string intrutor)
        {
            this.aulas = new List<Aula>();
            this.nome = nome;
            this.intrutor = intrutor;
        }

        internal Aluno BuscarMatriculado(int numeroMatricula)
        {
            //[<chave do dicionário>]: pode adicionar e substituir itens

            Aluno aluno = null;

            //TryGetValue tentar trazer um valor, boa opção para não gerar exceção para o usuário
            this.dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);
            return aluno;
        }

        internal void substituirAluno(Aluno aluno)
        {
            this.dicionarioAlunos[aluno.NumeroMatricula] = aluno;
        }

        internal void Adicionar(Aula aula)
        {
            this.aulas.Add(aula);
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        public override string ToString()
        {
            return $"Curso: {nome}, Tempo Total: {TempoTotal}, Aulas: {string.Join(", ", aulas)}";
        }


    }
}
