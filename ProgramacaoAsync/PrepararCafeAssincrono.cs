using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramacaoAsync
{
    public static class PrepararCafeAssincrono
    {
        public static void TostarPaoAssincrono()
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Tostando pão assincrono...{i}");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("PÃO PRONTO...");                
                Console.WriteLine();
            });
        }

        public static void PassarCafeAssincrono()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Passando café ...{i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("CAFÉ PRONTO");
            Console.WriteLine();
        }
    }
}
