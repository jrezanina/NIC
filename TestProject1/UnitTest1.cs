using NUnit.Framework;
using System.Drawing;

namespace TestProject1
{
    public class TrojuhelnikTest
    {
        [Test]
        public void Delka()
        {
            Point a = new Point(1, 2);
            Point b = new Point(1, 4);
            Point c = new Point(3, 4);
            Trojuhelnik.Trojuhelnik t = new Trojuhelnik.Trojuhelnik(a, b, c);

            double delka = t.DelkaStrany('a');

            Assert.AreEqual(2, delka);
        }
    }
}