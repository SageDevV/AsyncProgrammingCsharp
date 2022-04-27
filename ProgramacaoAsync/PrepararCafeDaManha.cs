using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramacaoAsync
{
    public static class PrepararCafeDaManha
    {
        public static void TostarPão()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"tostando pão {i}...");
                Thread.Sleep(1000);
            }
            Console.WriteLine("PÃO PRONTO");
            Console.WriteLine();
        }

        public static void PassarCafé()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"passando café {i}...");
                Thread.Sleep(1000);
            }
            Console.WriteLine("CAFÉ PRONTO");
            Console.WriteLine();
        }
    }
}
