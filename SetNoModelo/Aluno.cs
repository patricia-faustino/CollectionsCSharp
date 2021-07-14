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

    }
}
