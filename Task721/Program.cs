using System;
namespace Task721
{
    internal class Program
    {
        struct Bruch
        {
            public int ganz;
            public int zaehler;
            public int nenner;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Erster Bruch? Bsp 1 1/2 oder 3/4");
            Bruch b1 = BruchParser(Console.ReadLine());
            Console.WriteLine("Zweiter Bruch?");
            Bruch b2 = BruchParser(Console.ReadLine());
            AusgabeBruch(b1);
            AusgabeBruch(b2);

            var dou = BruchZuDouble(b1);
            Console.WriteLine(dou);

            var add = AddBruch(b1, b2);
            AusgabeBruch(add);

            var sub = SubBruch(b1, b2);
            AusgabeBruch(sub);

            var mul = MulBruch(b1, b2);
            AusgabeBruch(mul);

            var div = DivBruch(b1, b2);
            AusgabeBruch(div);

            Console.ReadLine();
        }

        static Bruch BruchParser(string s)
        {
            if (int.Parse(s.Split('/')[1]) == 0)
            {
                throw new Exception("Nenner darf nicht 0 sein !!!");
            }
            if (s.Contains(" "))
            {
                return new Bruch
                {
                    ganz = int.Parse(s.Split(' ')[0]),
                    zaehler = int.Parse(s.Split(' ')[1].Split('/')[0]),
                    nenner = int.Parse(s.Split(' ')[1].Split('/')[1])
                };
            }
            else
            {
                return new Bruch
                {
                    zaehler = int.Parse(s.Split('/')[0]),
                    nenner = int.Parse(s.Split('/')[1])
                };
            }
        }

        static void AusgabeBruch(Bruch bruch)
        {
            if (bruch.ganz != 0)
                Console.Write(
                    bruch.ganz + " ");
            if (bruch.zaehler != 0)
                Console.Write(
                    bruch.zaehler + "/" +
                    bruch.nenner);
            Console.Write("\n");
        }

        static double BruchZuDouble(Bruch bruch)
        {
            if (bruch.ganz != 0)
                return (bruch.ganz * bruch.nenner + bruch.zaehler) * 1.0 / bruch.nenner;
            return bruch.zaehler * 1.0 / bruch.nenner * 1.0;
        }

        static Bruch AddBruch(Bruch bruch1, Bruch bruch2)
        {
            bruch1 = GanzZuZaehler(bruch1);
            bruch2 = GanzZuZaehler(bruch2);
            return KuerzeBruch(new Bruch
            {
                zaehler = (bruch1.zaehler * bruch2.nenner +
                            bruch2.zaehler * bruch1.nenner),
                nenner = (bruch1.nenner * bruch2.nenner)
            });
        }

        static Bruch SubBruch(Bruch bruch1, Bruch bruch2)
        {
            bruch1 = GanzZuZaehler(bruch1);
            bruch2 = GanzZuZaehler(bruch2);
            return KuerzeBruch(new Bruch
            {
                zaehler = (bruch1.zaehler * bruch2.nenner -
                            bruch2.zaehler * bruch1.nenner),
                nenner = (bruch1.nenner * bruch2.nenner)
            });
        }

        static Bruch MulBruch(Bruch bruch1, Bruch bruch2)
        {
            bruch1 = GanzZuZaehler(bruch1);
            bruch2 = GanzZuZaehler(bruch2);
            return KuerzeBruch(new Bruch
            {
                zaehler = bruch1.zaehler * bruch2.zaehler,
                nenner = bruch1.nenner * bruch2.nenner
            });
        }

        static Bruch DivBruch(Bruch bruch1, Bruch bruch2)
        {
            bruch1 = GanzZuZaehler(bruch1);
            bruch2 = GanzZuZaehler(bruch2);
            bruch2 = UmkehrBruch(bruch2);
            return KuerzeBruch(MulBruch(bruch1, bruch2));
        }

        static Bruch UmkehrBruch(Bruch b)
        {
            b = GanzZuZaehler(b);
            return KuerzeBruch(new Bruch
            {
                zaehler = b.zaehler < 0 ? b.nenner * -1 : b.nenner,
                nenner = Math.Abs(b.zaehler)
            });
        }

        static Bruch KuerzeBruch(Bruch b)
        {
            int ggt = GGT(b.zaehler, b.nenner);
            var temp = new Bruch
            {
                zaehler = ggt < 0 ? (b.zaehler /= ggt) * -1 : b.zaehler /= ggt,
                nenner = Math.Abs(b.nenner /= ggt)
            };

            return FasseZusammen(temp);
        }

        private static Bruch FasseZusammen(Bruch bruch)
        {
            if (bruch.zaehler > bruch.nenner)
            {
                var ggt = WOPR(bruch.zaehler, bruch.nenner);

                return new Bruch
                {
                    ganz = ggt,
                    zaehler = bruch.zaehler - (bruch.nenner * ggt),
                    nenner = bruch.nenner
                };
            }
            return bruch;
        }

        private static int WOPR(int zaehler, int nenner)
        {
            return zaehler / nenner;
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

        private static Bruch GanzZuZaehler(Bruch bruch)
        {
            if (bruch.ganz != 0)
            {
                bruch.zaehler = bruch.zaehler + bruch.ganz * bruch.nenner;
            }
            return bruch;
        }
    }
}
