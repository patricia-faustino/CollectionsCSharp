using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicionariosA1
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
            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine($"O aluno a1 {aluno1} está matriculado?");
            Console.WriteLine(csharpColecoes.EstaMatriculado(aluno1));

            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            Console.WriteLine($"Tonini está matriculada? {csharpColecoes.EstaMatriculado(tonini)}");
            Console.WriteLine(aluno1.Equals(tonini));

            Console.Clear();

            Aluno aluno56173 = csharpColecoes.BuscarMatriculado(56173);

            Console.WriteLine($"aluno56173: {aluno56173}");

            // Quem é o aluno 5618?
            Aluno aluno5618 = csharpColecoes.BuscarMatriculado(5618);
            Console.WriteLine("Quem é o aluno 5618?");
            Console.WriteLine($"aluno5618: {aluno5618}");

            //A chave no dicionário é única
            Aluno fabio = new Aluno("Fabio Gushilen", 56173);

            //csharpColecoes.Matricula(fabio);

            csharpColecoes.substituirAluno(fabio);

            Console.WriteLine("Quem é o Aluno 56173 agora?");
            Console.WriteLine(csharpColecoes.BuscarMatriculado(56173));

            Console.ReadLine();
        }
    }
}
