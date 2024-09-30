using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task252
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                for (int i = 0; i <= 100; ++i)
                {
                    string line = "\r{0}%   loading [";
                    for (int j = 0; j <= Math.Round((i / 10.0)); ++j)
                    {
                        line += "0";
                    }
                    for (int j = 0; j < 10 - Math.Round((i / 10.0)); ++j)
                    {
                        line += "-";
                    }
                    line += "]";
                    Console.Write(line, i);
                    Thread.Sleep(10);
                }

                Console.WriteLine("\nWillkommen");
                Console.WriteLine("1.) DateTime");
                Console.WriteLine("2.) Calc");
                Console.WriteLine("3.) Ende");

                Console.WriteLine("Bitte Menüpunkt auswählen");

                var resume = Console.ReadKey();

                if (resume.KeyChar == '1')
                {
                    while (true)
                    {
                        Console.WriteLine("\nDateTime");
                        Console.WriteLine("1.) Deutsche Uhrzeit");
                        Console.WriteLine("2.) UTC Uhrzeit");
                        Console.WriteLine("3.) zurück");

                        var men1 = Console.ReadKey();

                        if (men1.KeyChar == '1')
                        {
                            Console.WriteLine("\n" + DateTime.Now.ToString());
                        }
                        else if (men1.KeyChar == '2')
                        {
                            Console.WriteLine("\n" + DateTime.UtcNow.ToString());
                        }
                        else if (men1.KeyChar == '3')
                        {
                            break;
                        }
                    }
                }
                else if (resume.KeyChar == '2')
                {
                    while (true)
                    {
                        Console.WriteLine("\nCalc");
                        Console.WriteLine("1.) Wurzel");
                        Console.WriteLine("2.) Gerade/Ungerade?");
                        Console.WriteLine("3.) zurück");

                        var men1 = Console.ReadKey();

                        if (men1.KeyChar == '1')
                        {
                            Console.WriteLine("\nAus welcher Zahl soll ich die Wurzel ziehen?");
                            Console.WriteLine(Math.Sqrt(double.Parse(Console.ReadLine())));
                        }
                        else if (men1.KeyChar == '2')
                        {
                            Console.WriteLine("\nWelche Zahl soll ich prüfen?");
                            Console.WriteLine(double.Parse(Console.ReadLine()) % 2 == 0 ?
                                "Zahl ist gerade" : "Zahl ist ungerade");
                        }
                        else if (men1.KeyChar == '3')
                        {
                            break;
                        }
                    }
                }
                else if (resume.KeyChar == '3')
                {
                    return;
                }
            }
        }
    }
}
