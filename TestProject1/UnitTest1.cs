using NUnit.Framework;
using System.Drawing;
using Trojuhelnik;

namespace TestProject1
{
    public class TrojuhelnikTest
    {
        [Test]
        public void DelkaStran_pro_spravny_parametr_vraci_spravny_vysledek()
        {
            Point a = new Point(1, 2);
            Point b = new Point(1, 4);
            Point c = new Point(3, 4);
            Trojuhelnik.Trojuhelnik t = new Trojuhelnik.Trojuhelnik(a, b, c);

            double delka = t.DelkaStrany('a');

            Assert.AreEqual(2, delka);
        }
        [Test]
        public void DelkaStran_pro_spatny_parametr_vraci_nulu()
        {
            Point a = new Point(1, 2);
            Point b = new Point(1, 4);
            Point c = new Point(3, 4);
            Trojuhelnik.Trojuhelnik t = new Trojuhelnik.Trojuhelnik(a, b, c);

            double delka = t.DelkaStrany('d');

            Assert.AreEqual(0, delka);
        }
        [Test]
        public void Kontrola_správné_sestrojitelnosti_podle_delky_stran()
        {
            Point a = new Point(1, 2);
            Point b = new Point(1, 4);
            Point c = new Point(3, 4);
            Trojuhelnik.Trojuhelnik t = new Trojuhelnik.Trojuhelnik(a, b, c);

            bool sestro = t.Sestrojitelnost();

            Assert.True(sestro);
        }
        [Test]
        public void Kontrola_nesprávné_sestrojitelnosti_podle_delky_stran()
        {
            Point a = new Point(1, 2);
            Point b = new Point(1, 2);
            Point c = new Point(3, 4);
            Trojuhelnik.Trojuhelnik t = new Trojuhelnik.Trojuhelnik(a, b, c);
            bool sestro = t.Sestrojitelnost();

            Assert.False(sestro);



        }

    }
}