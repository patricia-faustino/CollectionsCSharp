using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSomenteLeitura
{
    class Curso
    {
        private IList<Aula> aulas;
        private string nome;
        private string intrutor;


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


    }
}
