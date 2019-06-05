using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Receiver
    {
        bool fiveCopecksHandler = false;
        bool tenCopecksHandler = false;
        bool twentyFiveCopecksHandler = false;
        bool fiftyCopecksHandler = false;

        public Receiver()
        {
            Random rnd = new Random();

            switch (rnd.Next(1, 4))
            {
                case 1: fiveCopecksHandler = true; break;
                case 2: tenCopecksHandler = true; break;
                case 3: twentyFiveCopecksHandler = true; break;
                case 4: fiftyCopecksHandler = true; break;
                default:
                    break;
            }
        }
    }
}
