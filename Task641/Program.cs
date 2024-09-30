using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task641
{
    internal class Program
    {
        static List<Position> positions = new List<Position>();        

        static void Main(string[] args)
        {
            Position begin = new Position { x = 0, y = 26 };
            Position end = new Position { x = 115, y = 0 };
            positions.Add(begin);
            positions.Add(end);

            Console.WriteLine($"Start: ({begin.x}, {begin.y})");
            FindPath(begin, end, begin);
            Console.WriteLine($"Ende erreicht: ({end.x}, {end.y})");
            
            foreach(var p in positions)
            {
                Console.SetCursorPosition(p.x, p.y + 2);
                Console.Write("X");
                Thread.Sleep(100);
            }

            Console.ReadLine();
        }
        static void FindPath(Position current, Position end, Position begin)
        {
            if (!positions.Any(x => x.x == current.x && x.y == current.y))
                positions.Add(current);
            
            if (IstNachbar(end, current))
            {
                return;
            }

            if (current.x == end.x && current.y == end.y)
            {
                return;
            }
            // Bewegung zur Mitte zwischen der aktuellen Position und der Endposition
            int midX = (current.x + end.x) / 2;
            int midY = (current.y + end.y) / 2;

            // Rekursiver Aufruf mit der neuen Position
            FindPath(new Position { x = midX, y = midY }, end, begin);
            FindPath(new Position { x = midX, y = midY }, current, begin);
        }

        static bool IstNachbar(Position a, Position b)
        {if (a.x - b.x == 1 || b.x - a.x == 1 || a.x == b.x)
            {
                if (a.y - b.y == 1 || b.y - a.y == 1 || a.y == b.y)
                {
                    return true;
                }
            }                        
            return false;
        }
    }

    class Position
    {
        public int x;
        public int y;
    }
}
