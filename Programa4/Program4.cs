using System;

namespace dotnetcore
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            String a = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor: ");
            String b = Console.ReadLine();
            Console.WriteLine("Soma é " + soma(Convert.ToInt32(a), Convert.ToInt32(b)));
        }
        public static int soma(int a, int b)
        {
            return a + b;
        }
    }
}