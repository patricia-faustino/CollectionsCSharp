using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetNoModelo
{
    class Aluno
    {
        private string nome;

        private int numeroMatricula;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public int NumeroMatricula
        {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }
        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public override string ToString()
        {
            return $"[Nome: {nome}, Matrícula: {numeroMatricula}]"; 
        }

        //sobrescrevendo do default do equals
        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;

            if (outro == null)
                return false;

            return this.nome.Equals(outro.nome);
        }

        // !! a rapidez da busca depende do CÓDIGO DE DISPERSÃO!
        // se implementar o equals implementar o HashCode

        //Dois objetos que são iguais possuem o mesmo hash code.
        //PORÉM, o contrário não é verdadeiro:
        //Dois objetos com o mesmo hash codes não são necessariamente iguais!!
        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }

    }
}
