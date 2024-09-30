using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task212
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Antworten sie mit Ja (j oder J) oder Nein (n oder N):");

            var resp = Console.ReadLine().ToUpper();

            if (resp == "J")
            {
                Console.WriteLine("Sie haben mit ja geantwortet");
            }
            else if (resp == "N")
            {
                Console.WriteLine("Sie haben mit nein geantwortet");
            }
            else
            {
                Console.WriteLine("Sie haben eine falsche Eingabe gemacht.");
            }

            Console.ReadLine();
        }
    }
}
