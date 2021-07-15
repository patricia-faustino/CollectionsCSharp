using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        //FIFO: First in first out
        //FILA
        static Queue<string> pedagio = new Queue<string>();
        static void Main(string[] args)
        {
            string veiculo = "van";

            Enfileirar(veiculo);
            Enfileirar("kombi");
            Enfileirar("guincho");
            Enfileirar("pickup");

            //carro liberado
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();


            Console.ReadLine();
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                //Peek: verifica quem vai ser o próximo a sair da fila
                if (pedagio.Peek() == "guincho")
                {
                    Console.WriteLine("Guincho está fazendo o pagamento");
                }
                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila {veiculo}");
                ImprimirFila();
            }
            
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila{veiculo}");
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("FILA:");

            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }
    }
}
