using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0304
{
    internal class BüffelBeobachter : IBeobachter
    {
        bool zuTrocken = false;
        bool imStall = false;
        bool flussUnsicher = false;

        public void Update(double wasserstand)
        {
            //zu trocken
            if (wasserstand <= 0.3) {
                zuTrocken = true;
                imStall = false;
                flussUnsicher = false ;
                Console.WriteLine("Büffelwacht: Büffel haben durst!");
            }
            else if(wasserstand > 0.3 && wasserstand < 5)
            {
                zuTrocken = false;
                imStall = false;
                flussUnsicher = false;
                Console.WriteLine("Büffelwacht: Büffeln gehts prächtig!");
            }
            //in den stall
            else if(wasserstand >5 && wasserstand <= 7)
            {
                zuTrocken=false;
                imStall = true;
                flussUnsicher = false ;
                Console.WriteLine("Büffelwacht: Ab in den Stall!");
            }
            //vom fluss entfernen
            else
            {
                zuTrocken=false;
                imStall = false;
                flussUnsicher = true ;
                Console.WriteLine("Büffelwacht: Zeit für den Umzug!");
            }
        }
    }
}
