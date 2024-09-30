using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task711
{
    internal class Program
    {
        struct Datum
        {
            public int tag;
            public int monat;
            public int jahr;
        }

        static void Main(string[] args)
        {
            List<Datum> list = new List<Datum>();

            for (int m = 0; m < 12; m++)
            {
                for (int d = 0; d < 31; d++)
                {
                    if (m == 1 && d > 27)
                    {
                        continue;
                    }
                    list.Add(new Datum
                    {
                        tag = d,
                        monat = m,
                        jahr = 2014
                    });
                }
            }

            foreach (Datum datum in list) { 
                Console.WriteLine(
                    "Tag: " +  (datum.tag+1) + 
                    " Monat: " + (datum.monat+1) +
                    " Jahr: " + datum.jahr
                    );
                Thread.Sleep(100);
            }

            Console.ReadLine();
        }
    }
}
