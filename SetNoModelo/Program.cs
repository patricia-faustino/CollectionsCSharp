using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetNoModelo
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Colecoes", "Marcelo Oliveira");

            csharpColecoes.Adicionar(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adicionar(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adicionar(new Aula("Modelando com Coleções", 24));

            Aluno aluno1 = new Aluno("Vanessa Tonini", 34672);
            Aluno aluno2 = new Aluno("Ana Losnak", 56173);
            Aluno aluno3 = new Aluno("Rafael Nercessian", 17645);

            //Matricular
            csharpColecoes.Matricula(aluno1);
            csharpColecoes.Matricula(aluno2);
            csharpColecoes.Matricula(aluno3);

            //Imprimindo os alunos matriculados
            Console.WriteLine("Imprimindo os alunos matriculados");
            foreach(var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }


            Console.ReadLine();
        }
    }
}
