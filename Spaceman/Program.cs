using System;
using System.Threading;
using System.IO;
using System.Linq;
using System.Text;


namespace hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(90, 30);
            Console.SetBufferSize(90, 30);
            Console.OutputEncoding = Encoding.UTF8;
            int[] score;
            string[] player;
            Initializer();
            player[] playerHighscore = new player[5];
            LoadHighscore(ref playerHighscore);
            ZeigeStartBild(playerHighscore);
            ErmittelSpieler(out player, out score);
            while (true)
            {
                GameLogic(ref player, ref score);

                Console.Clear();
                player[] scoreboard = CombineArrays(player, score);
                Console.Clear();
                ShowScoreboard(scoreboard);

                //vergleicht und updated highscores
                playerHighscore = CheckScoreBoard(scoreboard, playerHighscore);
                Console.ReadLine();
                Console.Clear();

                Console.Clear();
                Console.WriteLine("Wollte ihr noch einen Flug starten?");
                string frage = Console.ReadLine();
                if (frage.ToLower() == "nein" || frage.ToLower() == "n")
                {
                    break;
                };
                Console.Clear();

            }
            ShowHighscore(playerHighscore);
            SaveHighscore(playerHighscore);

        }
        static void ZeigeStartBild(player[] playerHighscore)
        {
            /** Eigenschaften der Console wird festgelegt:
             *  Größe des Konsolenfensters auf 90 Spalten und 30 Zeilen.
             **/
            string[][] startBild =
                {
            new string[]{
                "  /$$$$$$  /$$$$$$$   /$$$$$$   /$$$$$$  /$$$$$$$$ /$$      /$$  /$$$$$$  /$$   /$$",
                " /$$__  $$| $$__  $$ /$$__  $$ /$$__  $$| $$_____/| $$$    /$$$ /$$__  $$| $$$ | $$",
                "| $$  \\__/| $$  \\ $$| $$  \\ $$| $$  \\__/| $$      | $$$$  /$$$$| $$  \\ $$| $$$$| $$",
                "|  $$$$$$ | $$$$$$$/| $$$$$$$$| $$      | $$$$$   | $$ $$/$$ $$| $$$$$$$$| $$ $$ $$",
                " \\____  $$| $$____/ | $$__  $$| $$      | $$__/   | $$  $$$| $$| $$__  $$| $$  $$$$",
                " /$$  \\ $$| $$      | $$  | $$| $$    $$| $$      | $$\\  $ | $$| $$  | $$| $$\\  $$$",
                "|  $$$$$$/| $$      | $$  | $$|  $$$$$$/| $$$$$$$$| $$ \\/  | $$| $$  | $$| $$ \\  $$",
                " \\______/ |__/      |__/  |__/ \\______/ |________/|__/     |__/|__/  |__/|__/  \\__/"},
            new string[]{
                " $$$$$$\\  $$$$$$$\\   $$$$$$\\   $$$$$$\\  $$$$$$$$\\ $$\\      $$\\  $$$$$$\\  $$\\   $$\\ ",
                "$$  __$$\\ $$  __$$\\ $$  __$$\\ $$  __$$\\ $$  _____|$$$\\    $$$ |$$  __$$\\ $$$\\  $$ |",
                "$$ /  \\__|$$ |  $$ |$$ /  $$ |$$ /  \\__|$$ |      $$$$\\  $$$$ |$$ /  $$ |$$$$\\ $$ |",
                "\\$$$$$$\\  $$$$$$$  |$$$$$$$$ |$$ |      $$$$$\\    $$\\$$\\$$ $$ |$$$$$$$$ |$$ $$\\$$ |",
                " \\____$$\\ $$  ____/ $$  __$$ |$$ |      $$  __|   $$ \\$$$  $$ |$$  __$$ |$$ \\$$$$ |",
                "$$\\   $$ |$$ |      $$ |  $$ |$$ |  $$\\ $$ |      $$ |\\$  /$$ |$$ |  $$ |$$ |\\$$$ |",
                "\\$$$$$$  |$$ |      $$ |  $$ |\\$$$$$$  |$$$$$$$$\\ $$ | \\_/ $$ |$$ |  $$ |$$ | \\$$ |",
                " \\______/ \\__|      \\__|  \\__| \\______/ \\________|\\__|     \\__|\\__|  \\__|\\__|  \\__|"},
            };

            Console.WriteLine();

            /***
             * For-Schleife stellt den  Startbildschirm 10 Mal dar. 
             * Sie wechselt zwischen den zwei ASCII Grafiken aus startBild-Array
             * 
             * Äußere Schleife: for (int j = 0; j < 10; j++) 
             * 
             * Diese Schleife sorgt dafür, dass der gesamte Inhalt  10 Mal angezeigt wird.
             * j = Anzahl der Wiederholungen 
             * 
             * 
             * Mittlere Schleife: 
             * Diese Schleife durchläuft jedes Element im startBild-Array. 
             * "startBild" entspricht ein zweidimensionales String-Array.
             * sprite ist dabei jeweils eines der beiden Arrays.
             * Die Schleife wechselt also zwischen den zwei verschiedenen Grafiken im startBild-Array.
             * 
             * 
             * Innerste Schleife:
             * 
             * Diese Schleife durchläuft jede Zeile der aktuellen Grafik(sprite)
             * sprite.Length = Anzahl der Zeilen in der aktuellen Grafik.
             * 
             * */


            for (int j = 0; j < 20; j++)
            {
                foreach (var sprite in startBild)
                {
                    for (int i = 0; i < sprite.Length; i++)
                    {


                        Console.SetCursorPosition(4, 0 + i);
                        Console.WriteLine(sprite[i]);

                        /*****
                         *  Bedingung  i ==  0 hat, dann ist es  die erste Zeile des aktuellen ASCII-Art-Bildes, das gerade durch die innere Schleife 
                         *  (for (int i = 0; i < sprite.Length; i++)) durchlaufen wird.
                         *  Wenn i == 0 wahr ist wird der nachfolgende Block ausgeführt.... "Drücken Sie Enter...etc.  und das Laden und Anzeigen des Highscores.
                         * * ****/

                        if (i == 0)
                        {
                            Console.SetCursorPosition(24, 10);
                            Console.WriteLine("Drücken Sie Enter um das Spiel zu starten!");

                            ShowHighscore(playerHighscore);
                        }
                    }
                    Thread.Sleep(50); // Thread.Sleep(500) bewirkt eine  Pausierung von 500ms.
                }
            }

            Console.ReadLine();
            Console.Clear();

        }

        /*****
         * Gesamtablauf der Methode:
         * Spieleranzahl abfragen:
         * Ein zweidimensionales Array mit der Größe [spielerAnzahl, 2] wird erstellt
         * Schleife zur Namenseingabe:
         * Return:  Rückgabe des Arrays:  Das Array mit n Spielernamen  .
         ****/
        static void ErmittelSpieler(out string[] player, out int[] score)
        {

            Console.WriteLine("Wie viele Astronauten nehmen an den Flug teil?");
            int spielerAnzahl = int.Parse(Console.ReadLine());
            player = new string[spielerAnzahl];
            score = new int[spielerAnzahl];
            for (int i = 0; i < spielerAnzahl; i++)
            {
                Console.WriteLine("Wie heißt der " + (i + 1) + ". Astronaut?");
                player[i] = Console.ReadLine();
            }
        }
        static void GameLogic(ref string[] player, ref int[] scores)
        {

            //Initialisieren aller Variablen
            bool startSequenzOver;                  // Dafür verantwortlich das dass Spielfeld geschrieben wird, bevor der Spieler Eingaben tätigen kann.
            string before;                          // String Array der zum überprüfen da ist, ob eine Veränderung nach der Spieler Eingabe vorahnden ist.
            string output;                          // Nimmt den String nach der Spieler Eingabe entgegen, prüft diesen und bringt ihn auf den Screen.
            string input;                           // Alle bisher Eingegebenen Buchstaben des Spielers.
            int attempts;                           // Versuche die noch übrig sind.

            //Settings
            int maxAttempts = 8;                    // Anzahl der Versuche
            int penalty = 5;                        // Strafpunkte
            int points = 10;                        // Punkte beim Hit
            int bonusPoints = 10;                   // Bonus Punkte wenn keine falschen Buchstaben genannt wurden

            for (int i = 0; i < player.Length; i++)
            {
                // Setzt alles für den Spieler zurück.
                Console.Clear();
                startSequenzOver = false;
                input = "";
                before = "";
                output = "";
                attempts = maxAttempts;

                // Nimmt ein neues Wort das gesucht wird
                string searchedWord = GetRandomWord();
                int x = 45 - ((searchedWord.Length * 5) / 2); //Berechnung der Positionen des Cursors, für Darstellung der Kästchen.



                while (true)
                {
                    //Nur Text der sagt wer am Zug ist und die Anzahl der Punkte dieses Spielers
                    DrawScreen(player[i], scores[i], attempts);

                    //Eingabe des Spieler erst wenn der Screen initialisiert wurde.
                    if (startSequenzOver)
                    {
                        input += InputChar();
                    }
                    output = CheckStringWithPlayerInput(searchedWord, input);

                    int counter = 0; //Verantwortlich um x Koordinaten vom Cursor zu setzen.

                    //Zeichnet leere Felder / gefundene Buchstaben auf den Screen
                    foreach (char c in output)
                    {
                        Console.SetCursorPosition(x + counter * 5, 11);
                        Console.Write("┌───┐");
                        Console.SetCursorPosition(x + counter * 5, 12);
                        Console.Write($"│ {c} │");
                        Console.SetCursorPosition(x + counter * 5, 13);
                        Console.Write("└───┘");

                        counter++;
                    }

                    // Berechnung der Punkte und Versuche erst nachdem der Screen initialisiert wurde.
                    if (startSequenzOver)
                    {
                        if (before == output) // Wenn der String nach der Nutzereingabe = dem String vor der Nutzereingabe ist, hat er einen falschen Buchstaben gewählt. 
                        {
                            scores[i] -= penalty;
                            if (attempts == 0) break; // Spiel des aktuellen Spielers zuende wenn keine Verusche mehr übrig sind und ein weiterer Fehlversuch stattfand.
                            else attempts--;
                        }
                        else scores[i] += points;
                    }
                    before = output;            // Übertargung des Stringes damit "Vor NutzerEingabe" aktuell bleibt. 
                    startSequenzOver = true;    // Bildschirm wurde beschrieben.
                    if (searchedWord == output) // Wenn das Wort gefunden wurde, wird die Runde des Spielers beendet und es wird überprüft ob Bonuspunkte gewährt werden.
                    {
                        if (attempts == maxAttempts) scores[i] += bonusPoints;
                        break;
                    }

                    //Test
                    string[][] spaceman =
                    {
                new string[]
                {
                "                   ",
                "                ",
                "              ",
                "              ",
                "                  ",
                "               ",
                "              ",
                "        o          ",
                "       /|\\      ",
                "       / \\       "
                },
                new string[]
                {
                "            ",
                "               ",
                "               ",
                "                   ",
                "                  ",
                "     \\=====/  ",
                "               ",
                "        o          ",
                "       /|\\      ",
                "       / \\       "
                },
                new string[]
                {
                "             ",
                "             ",
                "                ",
                "  _____________    ",
                " /__0___0___0__\\ ",
                "     \\=====/   ",
                "                ",
                "        o       ",
                "       /|\\       ",
                "       / \\        "
                },
                new string[]
                {
                "       ___   ",
                "     .=   =.  ",
                "     |     |  ",
                "  ___|_____|___    ",
                " /__0___0___0__\\ ",
                "     \\=====/  ",
                "               ",
                "        o          ",
                "       /|\\      ",
                "       / \\       "
                },
                new string[]
                {
                "       ___   ",
                "     .=   =.  ",
                "     | \\ / |  ",
                "  ___|_(\")_|___   ",
                " /__0___0___0__\\ ",
                "     \\=====/   ",
                "               ",
                "        o        ",
                "       /|\\      ",
                "       / \\       "
                },
                new string[]
                {
                "       ___   ",
                "     .=   =.  ",
                "     | \\ / |  ",
                "  ___|_(\")_|___   ",
                " /__0___0___0__\\ ",
                "    /\\=====/\\ ",
                "   /         \\ ",
                "  /     o     \\ ",
                " /     /|\\     \\ ",
                "/      / \\      \\"
                },
                new string[]
                {
                "       ___   ",
                "     .=   =.  ",
                "     | \\ / |  ",
                "  ___|_(\")_|___   ",
                " /__0___0___0__\\ ",
                "    /\\=====/\\    ",
                "   /    o    \\ ",
                "  /    /|\\    \\ ",
                " /     / \\     \\ ",
                "/               \\ "
                },
                new string[]
                {
                "       ___   ",
                "     .=   =.  ",
                "     | \\ / |  ",
                "  ___|_(\")_|___   ",
                " /__0___0___0__\\ ",
                "    /\\=====/\\ ",
                "   /         \\ ",
                "  /           \\ ",
                " /             \\ ",
                "/               \\"
                },
                new string[]
                {
                "       ___   ",
                "     .=   =.  ",
                "     | \\ / |  ",
                "  ___|_(\")_|___   ",
                " /__0___0___0__\\ ",
                "     \\=====/     ",
                "                  ",
                "                  ",
                "                  ",
                "                   "
                }

            };
                    int y = 0;
                    foreach (var sprite in spaceman[maxAttempts - attempts])
                    {
                        Console.SetCursorPosition(3, 20 + y);
                        Console.Write(sprite);
                        y++;

                    }
                }
            }
        }
        /// <summary>
        /// Methode die ein Zeichen als Eingabe des Spielers fordert und zurückgibt sofern die Bedingungen erfüllt sind.
        /// </summary>
        /// <returns></returns>
        /// 
        static char InputChar()
        {
            while (true)
            {
                bool keyValid = false;
                char input = ' ';
                Console.SetCursorPosition(34, 15);
                Console.Write("Wähle einen Buchstaben");

                Console.SetCursorPosition(43, 16);
                Console.Write("┌───┐");
                Console.SetCursorPosition(43, 17);
                Console.Write($"│   │");
                Console.SetCursorPosition(43, 18);
                Console.Write("└───┘");

                while (!keyValid)
                {
                    Console.SetCursorPosition(45, 17);
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.Enter && char.IsLetter(input))
                    {
                        keyValid = true;
                    }

                    else if (char.IsLetter(keyInfo.KeyChar))
                    {
                        input = keyInfo.KeyChar;
                    }
                    else
                    {
                        Console.SetCursorPosition(45, 17);
                        Console.Write(input);
                    }
                }
                char character = input;

                if (char.IsLetter(character) && (char.ToLower(character) >= 'a' && char.ToLower(character) <= 'z'))
                {
                    return character;
                }
            }
        }

        //Schreibt auf den Bildschirm diverse Stats des Spielers
        static void DrawScreen(string player, int score, int attempts)
        {
            Console.SetCursorPosition(40, 2);
            Console.Write("Am Zug ist:");
            Console.SetCursorPosition(45 - player.Length / 2, 3);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(player);
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(42, 5);
            Console.Write("Punkte:");
            Console.SetCursorPosition(38, 8);
            Console.Write("Versuche übrig");
            Console.SetCursorPosition(40, 6);
            Console.Write($"          ");
            Console.SetCursorPosition(45 - (score.ToString()).Length / 2, 6);
            Console.Write($"{score}");
            Console.SetCursorPosition(45, 9);
            Console.Write(attempts);
        }


        /// <summary>
        /// Vergleicht die Eingegebenen zeichen des Users mit dem gesuchten Wort und 
        /// gibt einen String mit den erratenen Zeichen und sonst leeren Feldern zurück
        /// </summary>
        /// <param name="word"></param>
        /// <param name="characters"></param>
        /// <returns></returns>
        static string CheckStringWithPlayerInput(string word, string characters)
        {
            string output = "";
            bool hit = false;

            foreach (char word_c in word)
            {
                foreach (char c in characters)
                {
                    if (char.ToLower(c) == char.ToLower(word_c))
                    {
                        hit = true;
                        break;
                    }
                }
                output += hit ? word_c : ' ';   // Wenn der Buchstabe passt, wird dieser im Output String angegeben, ansonsten wird ein Leerzeichen genommen.
                hit = false;                    // Hit wird zurückgesetzt
            }
            Console.SetCursorPosition(44 - characters.Length / 2, 21);
            for (int i = 0; i < characters.Length; i++)     //Schreibt die bisher Eingegebenen Buchstaben des Spielers auf den Screen.
            {
                Console.Write($"{characters[i]} ");

            }

            return output;
        }

        //Gibt ein zufällige Wort aus
        static string GetRandomWord()
        {
            Random rand = new Random();
            string[] wordlist = new string[]
            {
                "Stern",
                "Planet",
                "Galaxie",
                "Komet",
                "Meteorit",
                "Asteroid",
                "Mond",
                "Supernova",
                "Pulsar",
                "Quasar",
                "Neutron",
                "Schwarzesloch",
                "Exoplanet",
                "Raum",
                "Universum",
                "Milchstraße",
                "Sonnensystem",
                "Kosmos",
                "Lichtjahr",
                "Gravitation",
                "Raumstation",
                "Astronaut",
                "Erde",
                "Jupiter",
                "Mars",
                "Venus",
                "Saturn",
                "Merkur",
                "Uranus",
                "Neptun",
                "Pluto",
                "Hubble",
                "Teleskop",
                "Raumfahrt",
                "Kapsel",
                "Orbit",
                "Raketenschub",
                "Galaxienhaufen",
                "Dunkelheit",
                "Strahlung",
                "Magnetfeld",
                "Ozean",
                "Weltraumanzug",
                "Weltraumkapsel",
                "Schwerkraft",
                "Kollision",
                "Rotverschiebung",
                "Zeitdilatation",
                "Raumschiff",
                "Sternenstaub",
                "Supererde",
                "Gasriese",
                "Proton",
                "Elektron",
                "Interstellar",
                "Raumsonde",
                "Umlaufbahn",
                "Krater",
                "Raumforschung",
                "Spacetime",
                "Galaktisch",
                "Astrophysik",
                "Vakuum",
                "Energie",
                "Partikel",
                "Duesternis",
                "Dunkelenergie",
                "Sternbild",
                "Raketentriebwerk",
                "Solaranlage",
                "Mondfinsternis",
                "Sonnenfinsternis",
                "Nebel",
                "Stille",
                "Radiowellen",
                "Lichtkegel",
                "Mondgestein",
                "Weltraummuell",
                "Atmosphaere",
                "Astrobiologie",
                "Orbitalstation",
                "Andromeda",
                "Galaxienrand",
                "Raumgleiter",
                "Lichtkugel",
                "Planetenring",
                "Zwergstern",
                "Sonnenwind",
                "Kosmologie",
                "Astronomie",
                "Stratosphaere",
                "Planetenkern",
                "Planetenumlauf",
                "Kuiperguertel",
                "Raumwelle"

            };

            return wordlist[rand.Next(wordlist.Length)];
        }
        private static void Initializer()
        {
            if (!File.Exists("highscore.txt"))
            {
                File.Create("highscore.txt");
            }
        }

        //sortiert board nach punkten
        //sortiert board nach punkten
        private static player[] SortBoard(player[] board)
        {
            player[] temp = new player[board.Length];
            for (int i = 0; i < board.Length; i++)
            {
                player biggest = new player();
                foreach (player player in board)
                {
                    //if (biggest == null) biggest = player;
                    if (player == null) continue;
                    if (player.points > biggest.points && !temp.Any(y => (y != null && y.name == player.name)))
                        biggest = player;
                }

                temp[i] = biggest;
            }

            return temp;
        }

        //vergleicht scoreboard mit highscores und gibt dann array mit den 5 besten zurück
        private static player[] CheckScoreBoard(player[] playerScoreboard, player[] playerHighscore)
        {
            player[] temp = new player[10];

            int c = 0;
            foreach (player player in playerScoreboard)
            {
                temp[c] = player;
                c++;
            }
            foreach (player player in playerHighscore)
            {
                temp[c] = player;
                c++;
            }

            var sorted = SortBoard(temp);

            return sorted.Take(5).ToArray();
        }

        //zeigt highscores
        private static void ShowHighscore(player[] playerHighscore)
        {
            Console.SetCursorPosition(40, 15);
            Console.WriteLine("HIGHSCORE");
            Console.WriteLine();
            String zeile = "";
            int zeileText = 16;
            foreach (var p in playerHighscore)
            {
                zeile = p.name + " " + p.points;
                Console.SetCursorPosition((90 - zeile.Length) / 2, zeileText);
                Console.WriteLine(zeile);
                zeileText++;
            }
        }

        //zeigt scoreboard, NICHT GETESTET
        private static void ShowScoreboard(player[] playerHighscore)
        {
            Console.SetCursorPosition(40, 15);
            Console.WriteLine("SCOREBOARD");
            Console.WriteLine();
            String zeile = "";
            int zeileText = 16;
            foreach (var p in playerHighscore)
            {
                zeile = p.name + " " + p.points;
                Console.SetCursorPosition((90 - zeile.Length) / 2, zeileText);
                Console.WriteLine(zeile);
                zeileText++;
            }
        }

        //lädt die highscores aus highscore.txt ins array
        private static void LoadHighscore(ref player[] playerHighscore)
        {
            StreamReader highscore = new StreamReader("highscore.txt");
            String zeile = highscore.ReadLine();
            int c = 0;
            while (zeile != null)
            {
                playerHighscore[c] = (new player
                {
                    name = zeile.Split(' ')[0],
                    points = int.Parse(zeile.Split(' ')[1])
                });
                zeile = highscore.ReadLine();
                c++;
                if (c == 5)
                {
                    break;
                }
            }
            highscore.Close();
        }

        //speichert highscores in der highscore.txt
        private static void SaveHighscore(player[] playerHighscore)
        {
            File.WriteAllText("highscore.txt", string.Empty);
            StreamWriter sw = new StreamWriter("highscore.txt");

            foreach (player player in playerHighscore)
            {
                sw.WriteLine(player.name + " " + player.points);
            }

            sw.Close();
        }
        private static player[] CombineArrays(string[] player, int[] score)
        {
            player[] temp = new player[score.Length];
            for (int i = 0; i < player.Length; i++)
            {
                temp[i] = new player { name = player[i], points = score[i] };
            }

            return SortBoard(temp);
        }
    }
    class player
    {
        public string name;
        public int points;
    }
}