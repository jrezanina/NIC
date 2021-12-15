using System;
using System.Drawing;

namespace Trojuhelnik
{
    class Trojuhelnik
    {
        private Point a;
        private Point b;
        private Point c;
        public Trojuhelnik(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double DelkaStrany(char strana)
        {
            if (strana == 'a')
                return Math.Sqrt((Math.Pow(b.X - c.X, 2) + Math.Pow(b.Y - c.Y, 2)));
            else if (strana == 'b')
                return Math.Sqrt((Math.Pow(c.X - a.X, 2) + Math.Pow(c.Y - a.Y, 2)));
            else if (strana == 'c')
                return Math.Sqrt((Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2)));
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(3, 4);
            Point b = new Point(5, 6);
            Point c = new Point(7, 8);
            Trojuhelnik t = new Trojuhelnik(a, b, c);

            Console.WriteLine("Trojúhleník");
            Console.WriteLine($"Délka strany a: {t.DelkaStrany('a')}");
            Console.WriteLine($"Délka strany b: {t.DelkaStrany('b')}");
            Console.WriteLine($"Délka strany c: {t.DelkaStrany('c')}");
        }
    }
}
