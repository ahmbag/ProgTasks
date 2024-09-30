using System;

namespace Task911
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bruch b1 = new Bruch { Zaehler = 1, Nenner = 2 };
            Bruch b2 = new Bruch { Zaehler = 3, Nenner = 4 };
            b1.Ausgabe();
            b2.Ausgabe();

            var add = b1.AddBruch(b2);
            add.Ausgabe();

            var sub = b1.SubBruch(b2);
            sub.Ausgabe();

            var mul = b1.MulBruch(b2);
            mul.Ausgabe();

            var div = b1.DivBruch(b2);
            div.Ausgabe();

            Console.ReadLine();
        }        
    }

    class Bruch
    {
        public int Nenner;
        public int Zaehler;

        public void Ausgabe()
        {
            Console.WriteLine(Zaehler + "/" + Nenner);
        }

        static Bruch Kehrwert(Bruch bruch)
        {
            return new Bruch { Nenner = bruch.Zaehler, Zaehler = bruch.Nenner };
        }

        static Bruch KuerzeBruch(Bruch b)
        {
            int ggt = GGT(b.Zaehler, b.Nenner);
            var temp = new Bruch
            {
                Zaehler = ggt < 0 ? (b.Zaehler /= ggt) * -1 : b.Zaehler /= ggt,
                Nenner = Math.Abs(b.Nenner /= ggt)
            };

            return temp;
        }

        public Bruch AddBruch(Bruch bruch2)
        {
            return KuerzeBruch(new Bruch
            {
                Zaehler = (Zaehler * bruch2.Nenner +
                            bruch2.Zaehler * Nenner),
                Nenner = (Nenner * bruch2.Nenner)
            });
        }

        public Bruch SubBruch(Bruch bruch2)
        {
            return KuerzeBruch(new Bruch
            {
                Zaehler = (Zaehler * bruch2.Nenner -
                            bruch2.Zaehler * Nenner),
                Nenner = (Nenner * bruch2.Nenner)
            });
        }

        public Bruch MulBruch(Bruch bruch2)
        {
            return KuerzeBruch(new Bruch
            {
                Zaehler = Zaehler * bruch2.Zaehler,
                Nenner = Nenner * bruch2.Nenner
            });
        }

        public Bruch DivBruch(Bruch bruch2)
        {
            var bruch1 = new Bruch { Nenner = Nenner, Zaehler = Zaehler };
            bruch2 = Kehrwert(bruch2);
            return KuerzeBruch(bruch1.MulBruch(bruch2));
        }

        static int GGT(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
