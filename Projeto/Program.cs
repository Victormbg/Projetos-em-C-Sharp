using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            String a = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor: ");
            String b = Console.ReadLine();
            Console.WriteLine("A soma é " + soma(Convert.ToInt32(a), Convert.ToInt32(b)));
            Console.WriteLine("A subtração  é " + subtracao(Convert.ToInt32(a), Convert.ToInt32(b)));
        }
        public static int soma(int a, int b)
        {
            return a + b;
        }
        public static int subtracao(int a, int b)
        {
            return a - b;
        }
    }
}
