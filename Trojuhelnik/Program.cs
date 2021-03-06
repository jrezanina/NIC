using System;
using System.Drawing;
/// <summary>
/// \mainpage Sestrojení trojúhelníku
///  Naše práce obsahuje zjištění délek stran, zjištění obvodu, obsahu a zda je trojúhelník sestavitelný.
///  \author Jan Řezanina
///  \author Lucie Šlesingerová
///  \author Kateřina Křížanová
/// </summary>
namespace Trojuhelnik
{
    /// <summary>
    /// @brief Třída Trojuhelník slouží k deklaraci a k určení podmínek pro správnou funkčnost.
    /// </summary>
    public class Trojuhelnik
    {
        private Point a;
        private Point b;
        private Point c;

        /// <summary>
        /// @brief Deklarace bodů trojúhelníku.
        /// </summary>
        /// <param name="a">Je proměnná pro bod A trojuhelníku.</param>
        /// <param name="b">Je proměnná pro bod B trojuhelníku.</param>
        /// <param name="c">Je proměnná pro bod C trojuhelníku.</param>

        public Trojuhelnik(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        /// <summary>
        /// @brief Metoda pro výpočet délky stran.
        /// </summary>
        /// <param name="strana">Hodnota strana nese informaci, o kterou stranu se jedná.</param>
        /// <returns>Vrací délky stran trojúhelníků pomocí určených vrcholů nebo 0 v případě špatného zadání.</returns>
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

        /// <summary>
        /// @brief Metoda pro zjištění sestrojitelnosti trojúhelníku.
        /// Podmínka if zjištuje, zda je součet dvou stran větší nez třetí strana.
        /// </summary>
        /// <returns>Vrací True nebo False, podle toho, zda jde trojúhelník sestrojit nebo ne.</returns>
        public bool Sestrojitelnost()
        {         
            if ((DelkaStrany('a') + DelkaStrany('b')) > DelkaStrany('c') &&
                (DelkaStrany('c') + DelkaStrany('b')) > DelkaStrany('a') &&
                (DelkaStrany('c') + DelkaStrany('a')) > DelkaStrany('b'))
                return true;
            else
                return false;
        }

        /// <summary>
        /// @brief Metoda, která vypočítá obvod trojúhelníku pomocí délky sran.
        /// Obvod je vypočítaný součtem všech tří stran.
        /// </summary>
        /// <returns>Vrací obvod trojúhelníku.</returns>
        public double Obvod()
        {
            return DelkaStrany('a') + DelkaStrany('b') + DelkaStrany('c');
        }

        /// <summary>
        /// @brief Metoda, která zjištuje, zda je trojúhelník pravoúhlý.
        /// Podmínka if zjišťuje, zda se druhá mocnina jedné strany rovná součtu druhých mocnin ostatních stran.
        /// </summary>
        /// <returns>Vrací True nebo False, podle toho, zda jde trojúhelník sestrojit nebo ne.</returns>
        public bool Pravouhlost()
        {
            if (Math.Pow(DelkaStrany('a'), 2) == ((Math.Pow(DelkaStrany('b'), 2) + Math.Pow(DelkaStrany('c'), 2))) ||
                Math.Pow(DelkaStrany('c'), 2) == ((Math.Pow(DelkaStrany('a'), 2) + Math.Pow(DelkaStrany('b'), 2))) ||
                Math.Pow(DelkaStrany('b'), 2) == ((Math.Pow(DelkaStrany('a'), 2) + Math.Pow(DelkaStrany('c'), 2))))
                return true;
            else
                return false;
        }

        /// <summary>
        /// @brief Metoda, která počítá obsah trojúhelníku.
        /// Obsah se vypočítává s využitím délek stran.
        /// </summary>
        /// <returns>Vrací obsah trojúhelníku.</returns>
        public double Obsah()
        {
            double p = (DelkaStrany('a') + DelkaStrany('b') + DelkaStrany('c')) / 2;

            return Math.Sqrt(p * (p - DelkaStrany('a')) * (p - DelkaStrany('b')) * (p - DelkaStrany('c')));

        }
    }
    /// <summary>
    /// @brief Třída Program je pro část kódu, s kterou se bude operovat.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metoda Main, kde probíhá přiřazení hodnot k proměnným a vypsání informací.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Point a = new Point(1, 1);
            Point b = new Point(4, 1);
            Point c = new Point(4, 5);
            Trojuhelnik t = new Trojuhelnik(a, b, c);

            Console.WriteLine($"Délka strany a: {t.DelkaStrany('a')}");
            Console.WriteLine($"Délka strany b: {t.DelkaStrany('b')}");
            Console.WriteLine($"Délka strany c: {t.DelkaStrany('c')}");

            if (t.Sestrojitelnost() == true)
            {
                Console.WriteLine($"Trojuhelník lze sestrojit.");
                Console.WriteLine($"Obvod trojúhelníku je: {t.Obvod()}");

                if (t.Pravouhlost() == true)
                {
                    Console.WriteLine($"Trojuhelník je pravoúhlý.");
                }
                else
                {
                    Console.WriteLine($"Trojuhelník není pravoúhlý.");
                }

                Console.WriteLine($"Obsah trojúhelníku je: {t.Obsah()}");
            }
            else
            {
                Console.WriteLine($"Trojuhelník nelze sestrojit.");
            }

            
        }
    }
}