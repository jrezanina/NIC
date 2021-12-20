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
        [Test]
        public void Spravny_vypocet_obvodu_trojuhelniku()
        {
            Point a = new Point(2, 4);
            Point b = new Point(5, 6);
            Point c = new Point(7, 8);
            Trojuhelnik.Trojuhelnik t = new Trojuhelnik.Trojuhelnik(a, b, c);

            double obvod = t.Obvod();

            Assert.AreEqual(12.837102637643028, obvod);
        }

        [Test]
        public void Kontrola_pravouhlosti_trojuhelniku()
        {
            //vytvoříme pravoúhlý trojúhelník
            Point a = new Point(1, 1);
            Point b = new Point(4, 1);
            Point c = new Point(4, 5);
            Trojuhelnik.Trojuhelnik t = new Trojuhelnik.Trojuhelnik(a, b, c);

            bool pravo = t.Pravouhlost();

            Assert.True(pravo);
        }

        [Test]
        public void Kontrola_nepravouhlosti_trojuhelniku()
        {
            Point a = new Point(1, 2);
            Point b = new Point(1, 4);
            Point c = new Point(3, 4);
            Trojuhelnik.Trojuhelnik t = new Trojuhelnik.Trojuhelnik(a, b, c);

            bool pravo = t.Pravouhlost();

            Assert.False(pravo);
        }

        [Test]
        public void Spravny_vypocet_obsahu_trojhelniku()
        {
            Point a = new Point(1, 1);
            Point b = new Point(4, 1);
            Point c = new Point(4, 5);
            Trojuhelnik.Trojuhelnik t = new Trojuhelnik.Trojuhelnik(a, b, c);

            double obsah = t.Obsah();

            Assert.AreEqual(6, obsah);
        }

        
    }
}