using System;
using System.Threading;


namespace Projeto
{
    class Valores
    {
        private string valor1;
        private string valor2;

        public string Valor1
        {
            get { return valor1; }
            set { valor1 = value; }
        }
        public string Valor2
        {
            get { return valor2; }
            set { valor2 = value; }
        }
        public int soma(int a, int b)
        {
            return a + b;
        }
        public int subtracao(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                execute();
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Codigo de erro: " + e.GetType() + "\nMensagem: Foi inserido um valor com caractere no formato errado.");
                Thread.Sleep(TimeSpan.FromSeconds(4));
                Console.Clear();
                execute();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine("Erro ao executar: " + e.Message);
            }
        }
        public static void execute()
        {
            var valor = new Valores();
            Console.WriteLine("Digite o primeiro valor: ");
            valor.Valor1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor: ");
            valor.Valor2 = Console.ReadLine();

            Console.WriteLine("A soma é " + valor.soma(Convert.ToInt32(valor.Valor1), Convert.ToInt32(valor.Valor2)));
            Console.WriteLine("A subtração  é " + valor.subtracao(int.Parse(valor.Valor1), int.Parse(valor.Valor2)));
            Func<double, double, double> divisao = (double a, double b) =>
             {
                 return a / b;
             };
            Func<double, double, double> multiplicacao = (a, b) => a * b;
            Console.WriteLine("A divisão  é  {0} ", divisao(int.Parse(valor.Valor1), int.Parse(valor.Valor2)));
            Console.WriteLine("A multiplicação  é  {0} ", multiplicacao(int.Parse(valor.Valor1), int.Parse(valor.Valor2)));

            int[] lista = { int.Parse(valor.Valor1), int.Parse(valor.Valor2) };
            foreach (var i in lista)
            {
                System.Console.Write("LISTA: " + i + " ");
            }
        }
    }
}
