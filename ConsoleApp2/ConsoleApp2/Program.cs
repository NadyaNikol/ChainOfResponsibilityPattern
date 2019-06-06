using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Handler FiveCopecks = new FiveCopecksHandler();
            Handler TenCopecks = new TenCopecksHandler();
            Handler TwentyFiveCopecks = new TwentyFiveCopecksHandler();
            Handler FiftyCopecks = new FiftyCopecksHandler();

            FiveCopecks.Successor = TenCopecks;
            TenCopecks.Successor = TwentyFiveCopecks;
            TwentyFiveCopecks.Successor = FiftyCopecks;

            int s = 0;
            FiveCopecks.HandleRequest(new Coin(10,15), ref s);
            FiveCopecks.HandleRequest(new Coin(20, 30), ref s);
            FiveCopecks.HandleRequest(new Coin(30, 45), ref s);
            FiveCopecks.HandleRequest(new Coin(20, 40), ref s);

            Console.WriteLine($"Итоговая сумма {s}");
            Console.ReadKey();
        }
    }
}
