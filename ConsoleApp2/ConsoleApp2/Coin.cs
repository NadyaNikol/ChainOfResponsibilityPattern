namespace ConsoleApp2
{
    public class Coin
    {
        
        public int Diameter { set; get; }
        public int Weight { get; set; }

        public Coin (int diam, int w)
        {
            this.Diameter = diam;
            this.Weight = w;
        }
    }
}