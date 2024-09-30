namespace Task15A
{
    internal class Punkt
    {
        private int _x;
        private int _y;

        public Punkt(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int GetX() => _x;
        public int GetY() => _y;

    }
}