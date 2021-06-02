using System;
using System.Threading;
using System.Threading.Tasks;

namespace Projeto
{
    class Program
    {
        static async Task Main(string[] args)
        {

            do
            {
                try
                {
                    await execute();

                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("Código de erro: " + e.GetType() + "\nMensagem: Foi inserido um valor com caractere no formato errado.");
                    Thread.Sleep(TimeSpan.FromSeconds(4));
                    Console.Clear();
                    await execute();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Código de erro: " + e.GetType() + "\nMensagem: " + e.Message);
                    Thread.Sleep(TimeSpan.FromSeconds(4));
                    Console.Clear();
                    await execute();
                }
                finally
                {
                    await sair();
                }
            }
            while (true);
        }
        static async Task execute()
        {
            Console.Clear();
            var valor = new Valores();
            Console.Write("Digite o primeiro valor: ");
            valor.Valor1 = Console.ReadLine();
            Console.Write("Digite o segundo valor: ");
            valor.Valor2 = Console.ReadLine();

            Console.Clear();
            Console.Write("Aguardando...");
            await Task.Delay(TimeSpan.FromSeconds(2));
            Console.Clear();

            Console.WriteLine("A soma é " + valor.soma(int.Parse(valor.Valor1), int.Parse(valor.Valor2)));
            Console.WriteLine("A subtração  é " + valor.subtracao(int.Parse(valor.Valor1), int.Parse(valor.Valor2)));
            Console.WriteLine("A multiplicação é " + valor.multiplicacao(Convert.ToInt32(valor.Valor1), Convert.ToInt32(valor.Valor2)));
            Console.WriteLine("A divisão  é " + valor.divisao(int.Parse(valor.Valor1), int.Parse(valor.Valor2)));
        }


        static async Task sair()
        {
            Console.WriteLine("\n\nDeseja sair do programa?\nSe sim, digite: S\nSe não, digite: N");
            ConsoleKey tecla;
            tecla = Console.ReadKey().Key;
            if (tecla == ConsoleKey.S)
            {
                Environment.Exit(1);
            }
            else if (tecla == ConsoleKey.N)
            {
                Console.Clear();
                Console.WriteLine("Retornando...");
                Thread.Sleep(TimeSpan.FromSeconds(2));
                //Console.Write("Thread ID: {0}\n", Thread.CurrentThread.ManagedThreadId);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção invalida");
                await Task.Delay(TimeSpan.FromSeconds(2));
                Console.Clear();
                await sair();
            }
        }
    }
}
