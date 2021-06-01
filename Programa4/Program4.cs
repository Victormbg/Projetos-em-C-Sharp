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
            Func<double, double, double> divisao = (double a, double b) =>
            {
                return a / b;
            };
            Func<double, double, double> multiplicacao = (a, b) => a * b;

            Console.WriteLine("Soma é " + soma(Convert.ToInt32(a), Convert.ToInt32(b)));
            Console.WriteLine("A divisão  é  {0} ", divisao(int.Parse(a), int.Parse(b)));
            Console.WriteLine("A multiplicação  é  {0} ", multiplicacao(int.Parse(a), int.Parse(b)));
            int[] lista = { int.Parse(a), int.Parse(b) };
            foreach (var i in lista)
            {
                System.Console.Write("LISTA: " + i + " ");
            }

        }
        public static int soma(int a, int b)
        {
            return a + b;
        }
    }
}