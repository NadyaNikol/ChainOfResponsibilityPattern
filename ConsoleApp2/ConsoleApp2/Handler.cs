using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp2
{
    public abstract class Handler
    {
        public Handler Successor { set; get; }
        public abstract void HandleRequest(Coin coin, ref int sum);
    }

    public class FiveCopecksHandler : Handler
    {
        public override void HandleRequest(Coin coin, ref int sum)
        {
            if (Abs(coin.Diameter - 10) < 1 && Abs(coin.Weight - 15) < 2)
            {
                sum += 5;
                Console.WriteLine($"Монета данного номинала принята, общая сумма составляет {sum}");
            }
            else if (Successor != null)
            {
               
                Successor.HandleRequest(coin, ref sum);
            }
            else
                Console.WriteLine($"Монета данного номинала не принята");
        }
    }
    public class TenCopecksHandler : Handler
    {
        public override void HandleRequest(Coin coin, ref int sum)
        {
            if (Abs(coin.Diameter - 20) < 1 && Abs(coin.Weight - 30) < 2)
            {
                sum += 10;
                Console.WriteLine($"Монета данного номинала принята, общая сумма составляет {sum}");
            }
            else if (Successor != null)
            {
                
                Successor.HandleRequest(coin, ref sum);
            }
            else
                Console.WriteLine($"Монета данного номинала не принята");
        }
    }

    public class TwentyFiveCopecksHandler : Handler
    {
        public override void HandleRequest(Coin coin, ref int sum)
        {
            if (Abs(coin.Diameter - 30) < 1 && Abs(coin.Weight - 45) < 2)
            {
                sum += 25;
                Console.WriteLine($"Монета данного номинала принята, общая сумма составляет {sum}");
            }
            else if (Successor != null)
            {
                
                Successor.HandleRequest(coin, ref sum);
            }
            else
                Console.WriteLine($"Монета данного номинала не принята");
        }
    }

    public class FiftyCopecksHandler : Handler
    {
        public override void HandleRequest(Coin coin, ref int sum)
        {
            if (Abs(coin.Diameter - 40) < 1 && Abs(coin.Weight - 50) < 2)
            {
                sum += 50;
                Console.WriteLine($"Монета данного номинала принята, общая сумма составляет {sum}");
            }
            else if (Successor != null)
            {
               
                Successor.HandleRequest(coin, ref sum);
            }
            else
                Console.WriteLine($"Монета данного номинала не принята");
        }
    }

}
