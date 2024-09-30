using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galgenman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = "";
            Dictionary<string, int> highscores = new Dictionary<string, int>();
            List<string> words = new List<string>();
            //Start game

            Initializer();

            StartGame(ref user, ref highscores);
            
            LoadHighscores(ref highscores);

            LoadWords(ref words);

            bool running = true;

            while (running)
            {
                string word = GetRandomWord(words);               

                running = StartRound(word);

                if (running)
                {
                    Console.WriteLine("Gewonnen!");
                    UpdateHighscore(user, ref highscores);
                }
            }

            Console.ReadLine();
        }

        private static void UpdateHighscore(string user, ref Dictionary<string, int> highscores)
        {
            int points = highscores.Where(x=>x.Key == user).FirstOrDefault().Value;

            highscores.Remove(user);

            highscores.Add(user, points+1);

            var sw = new StreamWriter(@"highscores.txt", true);
            foreach(var h in highscores)
            {
                sw.WriteLine(h.Key + ";" + h.Value);
            }
            sw.Close();

        }

        private static bool StartRound(string word)
        {
            int errors = 0;
            List<char> chars = new List<char>();
            chars.Add(' ');

            WriteWord(word, chars);

            Console.WriteLine("");

            while (errors < 50) {
                int missing = 50;

                Console.WriteLine("\nBuchstabe?");

                char userinput = Console.ReadKey().KeyChar;

                chars.Add(userinput);

                if (word.Contains(userinput))
                {
                    missing = WriteWord(word, chars);
                }
                else
                {
                    Console.WriteLine("Nicht drin! Noch " + (5-errors) + " Versuche");
                    errors++;
                }

                if (missing == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static int WriteWord(string word, List<char> chars)
        {
            Console.WriteLine("");
            word = word.ToLower();
            int missing = 0;

            foreach (char w in word)
            {
                if (chars.Contains(w))
                {
                    Console.Write(w + " ");
                }
                else
                {
                    Console.Write("_ ");
                    missing++;
                }                
            }
            return missing;
        }

        private static string GetRandomWord(List<string> words)
        {
            return words.PickRandom().ToString();
        }

        private static void Initializer()
        {
            if (!File.Exists("words.txt"))
            {
                File.Create("words.txt");
            }

            if (!File.Exists("highscores.txt"))
            {
                File.Create("highscores.txt");
            }
        }

        private static void LoadWords(ref List<string> words)
        {
            
            var lines = File.ReadLines("words.txt");
            foreach (var line in lines)
            {
                words.Add(line);
            }

            Console.WriteLine(words.Count + " Wörter geladen");
        }

        private static void LoadHighscores(ref Dictionary<string, int> highscores)
        {         
            var lines = File.ReadLines("highscores.txt");
            foreach (var line in lines)
            {
                highscores.Add(line.Split(';')[0], int.Parse(line.Split(';')[1]));
            }
            //highscores.OrderBy(x => x.Value);

            int c = 1;
            foreach (var h in highscores.OrderByDescending(key => key.Value))
            {
                Console.WriteLine(c + ". " + h.Key + " : " + h.Value);
                c++;
            }
        }

        private static void StartGame(ref string user, ref Dictionary<string, int> highscores)
        {
            Console.WriteLine("Galgenmännchen Tournament 2000");
            Console.WriteLine("Nickname eingeben:");

            user = Console.ReadLine();

            highscores.Add(user, 0);
        }


    }
}
