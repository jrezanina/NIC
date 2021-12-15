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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(3, 4);
            Point b = new Point(5, 6);
            Point c = new Point(7, 8);
            Trojuhelnik t = new Trojuhelnik(a, b, c);
        }
    }
}
