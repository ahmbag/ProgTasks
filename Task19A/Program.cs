using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19A
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Backwaren {
        string Name;
        double Preis;
    }

    class Konditoreiwaren : Backwaren {
        int Kuehltemperatur;
        DateTime Mindesthaltbarkeit;
    }

    class Brote : Backwaren {
        int Gewicht;
        string Mehlsorte;
    }
    class Fruehstuecksbackwerk : Backwaren {
        int Abkühldauer;
    }

    class Salzbackwaren : Fruehstuecksbackwerk {
        int Salzgehalt;
    }
    class Süßbackwaren : Fruehstuecksbackwerk{
        int Zuckergehalt;
        int Lagertemperatur;
    }
}
