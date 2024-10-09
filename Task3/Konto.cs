using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Konto
    {
        private string _name;
        private string _vorname;
        private int _kontonummer;
        private double _kontostand;
        private DateTime _created;
        private double _habenszinssatz;

        public Konto(string name, string vorname, int kontonummer, double habenszinssatz)
        {
            _name = name;
            _vorname = vorname;
            _kontonummer = kontonummer;
            _kontostand = 0;
            _created = DateTime.Now;
            _habenszinssatz = habenszinssatz;
        }

        public void Einzahlen(double b) => _kontostand += b;
        public void Auszahlen(double b) => _kontostand -= b;
        public double Zinsen() => _kontostand * _habenszinssatz * 
            ((DateTime.Now-_created).Days / 365);
        public double Kontostand() => _kontostand;

        public void SetZinssatz(double zinssatz) => _habenszinssatz = zinssatz;
    }
}
