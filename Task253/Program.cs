using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task253
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Willkommen zum Fubonacci-Calculator! \n" +
                    "Bitte geben Sie ein, wie viele Fibonacci-Zahlen ausgegeben werden sollen");

                int count = int.Parse(Console.ReadLine());
                List<int> listFibo = new List<int>();
                listFibo.Add(0);
                listFibo.Add(1);

                for (int i = 2; i <= count; i++)
                {
                    listFibo.Add(listFibo[i - 1] + listFibo[i - 2]);
                }

                for (int i = 0; i < listFibo.Count; i++)
                {
                    Console.WriteLine(listFibo[i]);
                }

                Console.WriteLine("Beliebige Taste drücken für erneute Ausführung, e für exit");
                var resume = Console.ReadKey();

                if (resume.KeyChar == 'e')
                {
                    break;
                }
            }
        }
    }
}
