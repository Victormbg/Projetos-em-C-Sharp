using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o primeiro valor: ");
                var a = Console.ReadLine();
                Console.WriteLine("Digite o segundo valor: ");
                var b = Console.ReadLine();
                Console.WriteLine("A soma é " + soma(Convert.ToInt32(a), Convert.ToInt32(b)));
                Console.WriteLine("A subtração  é " + subtracao(int.Parse(a), int.Parse(b)));
                Func<double, double, double> divisao = (double a, double b) =>
                 {
                     return a / b;
                 };
                Func<double, double, double> multiplicacao = (a, b) => a * b;
                Console.WriteLine("A divisão  é  {0} ", divisao(int.Parse(a), int.Parse(b)));
                Console.WriteLine("A multiplicação  é  {0} ", multiplicacao(int.Parse(a), int.Parse(b)));

                int[] lista = { int.Parse(a), int.Parse(b) };
                foreach (var i in lista)
                {
                    System.Console.Write(i + " ");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao executar: " + e.Message);
            }

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
