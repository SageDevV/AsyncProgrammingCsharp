using System;
using System.Threading.Tasks;

namespace ProgramacaoAsync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Preparar o café da manhã:");
            PrepararCafeDaManha.TostarPão();
            PrepararCafeDaManha.PassarCafé();
            Console.WriteLine();
            Console.WriteLine("CAFÉ DA MANHÃ SERVIDO....");
            Console.WriteLine();
            Console.WriteLine("Tecle pra continuar...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Preparando café assincrono:");
            PrepararCafeAssincrono.TostarPaoAssincrono();
            PrepararCafeAssincrono.PassarCafeAssincrono();
            Console.WriteLine();
            Console.WriteLine("CAFÉ DA MANHÃ SERVIDO....");
            Console.WriteLine();
            Console.WriteLine("Tecle pra continuar...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Preparando café com task:");
            Task preparar = PrepararCafeAsyncTask.TostarPaoAsyncTask();
            
            PrepararCafeAsyncTask.PassarCafeAsyncTask();
            preparar.Wait();

            Console.WriteLine();
            Console.WriteLine("CAFÉ DA MANHÃ SERVIDO....");
            Console.WriteLine();
            Console.WriteLine("Tecle pra continuar...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
