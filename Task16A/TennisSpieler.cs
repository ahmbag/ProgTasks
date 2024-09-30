using System;

namespace Task16A
{
    internal class TennisSpieler
    {
        private string _name;
        private int _alter;
        private TennisSpieler _verfolger;

        public TennisSpieler(string name, int alter, TennisSpieler verfolger = null)
        {
            _name = name;
            _alter = alter;
            _verfolger = verfolger;
        }
        public string GetName() => _name;

        public int AltersDifferenz(TennisSpieler t)
        {
            return _alter - t._alter;
        }

        public void Ausgabe()
        {
            if(_verfolger != null) 
                Console.WriteLine("Spieler: {0}, sein Verfolger: {1}", _name, _verfolger._name);
            else
                Console.WriteLine("Spieler: {0}, kein Verfolger", _name);
        }

        public bool IstLetzter()
        {
            return _verfolger == null;
        }
    }
}