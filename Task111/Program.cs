using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = ReadFile();
            int sum = people.Sum(i => i.GetAlter());

            Console.WriteLine("Durchschnitt beträgt: " + (sum/people.Length));

            Console.ReadLine(); 
        }

        static Person[] ReadFile()
        {
            List<Person> people = new List<Person>();

            var lines = File.ReadLines("Personen.txt");
            foreach (var line in lines)
            {
                people.Add(new Person
                {
                    Name = line.Split(':')[0],
                    Geburtstag = DateTime.Parse(line.Split(':')[1])
                });
            }

            return people.ToArray();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public DateTime Geburtstag { get; set; }

        public int GetAlter()
        {
            int alter = DateTime.Today.Year - Geburtstag.Year;
            if(DateTime.Today < Geburtstag.AddYears(alter))
                alter--;

            return alter;
        }
        
    }
}
