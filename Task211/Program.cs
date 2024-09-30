//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Task211
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Stückzahl?");

//            var count = int.Parse(Console.ReadLine());

//            Console.WriteLine("Einzelpreis?");

//            var price = double.Parse(Console.ReadLine());

//            if (count >= 50)
//            {
//                Console.WriteLine("Endpreis mit 10% Rabatt: " + (count * price * 0.9));
//            }
//            else if (count >= 10)
//            {
//                Console.WriteLine("Endpreis mit 5% Rabatt: " + (count * price * 0.95));
//            }
//            else
//            {
//                Console.WriteLine("Endpreis: " + (count * price));
//            }

//            Console.ReadLine();
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4gewinnt
{
    internal class Program
    {

        public static bool Prüfen(char[,] map, char player)
        {
            int row = map.GetLength(0);
            int col = map.GetLength(1);
            // Horizontal
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col - 3; j++)
                {
                    if (map[i, j] == player && map[i, j + 1] == player && map[i, j + 2] == player && map[i, j + 3] == player)
                        return true;
                }
            }
            // Vertikal überprüfen
            for (int i = 0; i < row - 3; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (map[i, j] == player && map[i + 1, j] == player && map[i + 2, j] == player && map[i + 3, j] == player)
                        return true;
                }
            }

            // Diagonal  überprüfen
            for (int i = 0; i < row - 3; i++)
            {
                for (int j = 0; j < col - 3; j++)
                {
                    if (map[i, j] == player && map[i + 1, j + 1] == player && map[i + 2, j + 2] == player && map[i + 3, j + 3] == player)
                        return true;
                }
            }

            // Diagonal  überprüfen
            for (int i = 0; i < row - 3; i++)
            {
                for (int j = 3; j < col; j++)
                {
                    if (map[i, j] == player && map[i + 1, j - 1] == player && map[i + 2, j - 2] == player && map[i + 3, j - 3] == player)
                        return true;
                }
            }

            return false;
        }


        static void Main(string[] args)
        {
            //HAUPTMENÜ

            Console.WriteLine("\n\n\t\t\t\tWillkommen in das Hauptmenü");
            Console.WriteLine("\t\n\n\nGeben Sie Name des 1.Spieler ein");
            string player1 = Console.ReadLine();
            Console.WriteLine("\t\n\n\nGeben Sie Name des 2.Spieler ein");
            string player2 = Console.ReadLine();

            Console.WriteLine("\t\t\t\t\tPRESS ENTER!!!");
            Console.ReadLine();

            //ERSTELLUNG DES FELDES
            int col = 7;
            int row = 6;
            char[,] map = new char[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    map[i, j] = '.';
                }
            }




            // Initialisierung des feldes.
            bool SpielZuEnde = false;
            int zug = 0;
            while (!SpielZuEnde)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)

                    {
                        Console.Write("|" + map[i, j]);
                    }
                    Console.Write("|\n");
                }

                Console.WriteLine("0 1 2 3 4 5 6");


                // Welcher SPieler ist am Zug?
                char player = zug % 2 == 0 ? 'x' : 'o';

                Console.WriteLine($"player{(zug % 2) + 1}, suchen Sie sich ein Spalte aus");
                int spalte = 0;
                while (!SpielZuEnde)
                {
                    if (int.TryParse(Console.ReadLine(), out spalte) && spalte >= 0 && spalte < col)

                    {
                        if (map[0, spalte] == '.')
                        {

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Wählen Sie eine andere Spalte, die ist voll");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Ungültige Eingabe wählen Sie Spalte zwischen 0 und 6");
                    }
                }
                //Stein reinwerfen
                for (int i = 5; i >= 0; i--)
                {
                    if (map[i, spalte] == '.')
                    {
                        map[i, spalte] = player;
                        player = (Char)zug;

                    }
                }

                if (Prüfen(map, player))
                {
                    SpielZuEnde = true;
                    Console.WriteLine($"Spieler {(zug % 2) + 1} ({player}) hat gewonnen!");
                }

                zug++;
                if (zug == row * col)
                {
                    SpielZuEnde = true;
                    Console.WriteLine("Unentschieden.");
                }
            }

        }


    }

}




