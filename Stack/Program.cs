using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var navegador = new Navegador();
            navegador.NavegarPara("google.com");
            navegador.NavegarPara("caelum.com.br");
            navegador.NavegarPara("alura.com.br");

            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();

            navegador.Proximo();

            Console.ReadLine();
        }
    }

    internal class Navegador
    {
        //Stack é uma pilha, ou seja, o primeiro elemento que entra é o último que sai
        //LIFO: Last in, first out

        private readonly Stack<string> historicoAnterior = new Stack<string>();

        private readonly Stack<string> historicoProximo = new Stack<string>();

        private string atual = "vazia";

        public Navegador()
        {
            Console.WriteLine($"Página atual: {atual}");
        }

        internal void Anterior()
        {
            if (historicoAnterior.Any())
            {
                historicoProximo.Push(atual);
                atual = historicoAnterior.Pop();
                Console.WriteLine($"Página atual: {atual}");
            }
            
        }

        internal void NavegarPara(string url)
        {
            historicoAnterior.Push(atual);
            atual = url;
            Console.WriteLine($"Página atual: {atual}");
        }

        internal void Proximo()
        {
            if (historicoProximo.Any()) {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                Console.WriteLine($"Página atual: {atual}");
            }
            
        }
    }
}
