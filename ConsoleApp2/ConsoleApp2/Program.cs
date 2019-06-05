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


            FiveCopecks.HandleRequest(new Coin(10,15), 0);
            TenCopecks.HandleRequest(new Coin(20,30), 0);
            TwentyFiveCopecks.HandleRequest(new Coin(30,45), 0);
            TenCopecks.HandleRequest(new Coin(20,40), 0);
            FiftyCopecks.HandleRequest(new Coin(40,50), 0);

            Console.ReadKey();
        }
    }
}
