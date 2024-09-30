//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            bool a=false, b=false, c=false;

//            if (a)
//            {
//                if (b)                
//                    if (c)                    
//                        Console.WriteLine("im here");
//            }

//            try
//            {
//                Console.WriteLine("Was soll ich rechnen?");

//                string op = Console.ReadLine();

//                int first = int.Parse(op.Split(' ')[0]);
//                int second = int.Parse(op.Split(' ')[2]);

//                if (op.Contains("+"))
//                {
//                    Console.WriteLine("Das Ergebnis lautet: " + (first + second));
//                }
//                else if (op.Contains("-"))
//                {
//                    Console.WriteLine("Das Ergebnis lautet: " + (first - second));
//                }
//                else if (op.Contains("*"))
//                {
//                    Console.WriteLine("Das Ergebnis lautet: " + (first * second));
//                }
//                else if (op.Contains("/"))
//                {
//                    Console.WriteLine("Das Ergebnis lautet: " + (first / second));
//                }
//                else
//                {
//                    Console.WriteLine("Fehler beim lesen");
//                }

//                Console.ReadLine();
//            }
//            catch 
//            {
//                throw new Exception("Fehler in der Syntax");
//            }

//        }
//    }
//}

using System;

namespace sortieren
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            int[] arraySortieren = new int[10];

            #region Zahlen in einem Array Initialisieren
            // Generieren des großen Arrays mit Zufallszahlen
            for (int i = 0; i < arraySortieren.Length; i++)
            {
                arraySortieren[i] = rnd.Next(0, 10); // Zufallszahlen zwischen 0 und 9
                Console.WriteLine(arraySortieren[i]);
            }
            #endregion

            int zwischenspeicher = 0;
            bool abgeschlossen = false;


            #region Logik
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < arraySortieren.Length; j++)
                {
                    if(j == 9)
                    {
                        break;
                    }

                    if (arraySortieren[j] > arraySortieren[j + 1])
                    {
                        // Zwischenspeicher nimmt den Aktuellen Index an
                        zwischenspeicher = arraySortieren[j + 1];
                        // Die Größere Zahl wird in den in den Nächst Tieferen Index Gesetzt (Sortiert)
                        arraySortieren[j + 1] = arraySortieren[j];
                        // Die Aktuelle Index zahl wird zum Zwischenspeicher
                        arraySortieren[j] = zwischenspeicher;
                    }
                }
                //abgeschlossen = true;
            }
            #endregion

            #region Debug
            for (int i = 0; i < arraySortieren.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\n{string.Join(", ", arraySortieren)}\n");
            }
            #endregion

            #region Ausgabe
            // Ausgabe der Häufigkeiten
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < arraySortieren.Length; i++)
            {
                Console.WriteLine($"Der Wert im Index {i} ist {arraySortieren[i]}");
            }
            #endregion
            Console.ReadKey(true);

            // Clean Console app Exit
            System.Environment.Exit(1);


        }
    }
}

/*

Erstellen Sie auch einen Programmablaufplan für die Aufgabe.

Aufgabe Sortieren
1) Erzeugen Sie für die folgende Aufgabe ein Array mit zufälligen ganzen Zahlen.

Legen Sie zunächst nur ein kleines Array an (z.B. mit 10 Werten), damit Sie die
Ergebnisse Ihrer Lösung von Hand überprüfen können.

Sortieren Sie anschließend das Array aufsteigend. Es werden immer zwei benachbarte
Elemente betrachtet. Wenn sie in falscher Ordnung stehen, werden sie vertauscht.

Dies wird mit allen Elementen des Arrays durchgeführt. Zum Schluss steht das größte
Element des Arrays am Ende des Arrays. Dieser Schritt wird solange wiederholt, bis
das gesamte Array komplett sortiert ist!

*/