using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task441
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lotto-Tip-Generator");

            int[] tips = new int[6];

            var r = new Random();
            for (int i = 0; i < 6; i++)
            {
                var n = r.Next(0,50);
                while(tips.Where(t => t == n).Any())
                {
                    n = r.Next(0, 50);
                }

                tips[i] = n;
                Console.WriteLine(tips[i]);

                
            }

            Console.ReadLine();
        }
    }
}
