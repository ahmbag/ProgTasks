using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4Wins
{
    internal class Program
    {
        static int[,] map = new int[7, 6];

        static void Main(string[] args)
        {
            ClearLine(10);

            var winner = CheckForWin();
            var r = new Random();

            while(winner == 0)
            {
                DrawMap();

                //human step
                Console.SetCursorPosition(0, 10);
                
                Console.WriteLine("Du bist an der Reihe! Welche Spalte?");

                PlayStep(int.Parse(Console.ReadKey().KeyChar.ToString()), 1);

                winner = CheckForWin();
                ClearLine(10);
                //computer step
                if (winner == 0)
                {
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("Computer an der Reihe...");
                    Thread.Sleep(1000);
                    PlayStep(r.Next(0, 6), 2);
                }

                winner = CheckForWin();
            }
            if (winner != 0)
            {
                Console.SetCursorPosition(0, 10);
                Console.WriteLine("The winner is player " + winner);
            }

            Console.ReadLine();
        }

        static void ClearLine(int l)
        {
            Console.SetCursorPosition(0, l);
            for(int i = 0; i < 50; i++)
            {
                Console.Write(".");
            }
        }

        static int CheckForWin()
        {
            for (int y = 0; y < 6; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if (map[x, y] == 1 || map[x, y] == 2)
                    {
                        if (PruefeRichtung(y, x, 0, 1, map[x, y], 1) ||  // Horizontal
                            PruefeRichtung(y, x, 1, 0, map[x, y], 1) ||  // Vertikal
                            PruefeRichtung(y, x, 1, 1, map[x, y], 1) ||  // Diagonal rechts unten
                            PruefeRichtung(y, x, 1, -1, map[x, y], 1))   // Diagonal links unten
                        {
                            return map[x, y];  // Gewinner gefunden
                        }
                    }
                }
            }

            return 0;
        }

        private static bool PruefeRichtung(int row, int col, int deltaRow, int deltaCol, int spieler, int count)
        {
            if (count == 4)
            {
                return true;
            }

            int neuerRow = row + deltaRow;
            int neuerCol = col + deltaCol;

            if (neuerRow < 0 || neuerRow >= 6 || neuerCol < 0 || neuerCol >= 7)
            {
                return false; // Außerhalb des Spielfelds
            }

            if (map[neuerCol, neuerRow] == spieler)
            {
                return PruefeRichtung(neuerRow, neuerCol, deltaRow, deltaCol, spieler, count + 1);
            }
            return false;
        }

        static void PlayStep(int row, int player)
        {
            for (int y = 5; y > -1; y--)
            {
                if (map[row,y] == 0)
                {
                    map[row,y] = player;
                    DrawMap();
                    return;
                }
            }
        }

        static void DrawMap()
        {
            for (int y = 5; y > -1; y--)
            {
                for (int x = 0; x < 7; x++)
                {
                    Console.SetCursorPosition(x, y);
                    if (map[x, y] == 1)
                    {
                        Console.Write("X");
                    }
                    else if (map[x, y] == 2)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
