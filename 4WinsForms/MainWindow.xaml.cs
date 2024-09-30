using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _4WinsForms
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[,] map = new int[7, 6];
        Rectangle[,] rectangles = new Rectangle[7, 6];
        int winner = 0;
        Random r = new Random();

        public MainWindow()
        {        
            InitializeComponent();

            rectangles[0, 0] = field00;
            rectangles[0, 1] = field01;
            rectangles[0, 2] = field02;
            rectangles[0, 3] = field03;
            rectangles[0, 4] = field04;
            rectangles[0, 5] = field05;

            rectangles[1, 0] = field10;
            rectangles[1, 1] = field11;
            rectangles[1, 2] = field12;
            rectangles[1, 3] = field13;
            rectangles[1, 4] = field14;
            rectangles[1, 5] = field15;

            rectangles[2, 0] = field20;
            rectangles[2, 1] = field21;
            rectangles[2, 2] = field22;
            rectangles[2, 3] = field23;
            rectangles[2, 4] = field24;
            rectangles[2, 5] = field25;

            rectangles[3, 0] = field30;
            rectangles[3, 1] = field31;
            rectangles[3, 2] = field32;
            rectangles[3, 3] = field33;
            rectangles[3, 4] = field34;
            rectangles[3, 5] = field35;

            rectangles[4, 0] = field40;
            rectangles[4, 1] = field41;
            rectangles[4, 2] = field42;
            rectangles[4, 3] = field43;
            rectangles[4, 4] = field44;
            rectangles[4, 5] = field45;

            rectangles[5, 0] = field50;
            rectangles[5, 1] = field51;
            rectangles[5, 2] = field52;
            rectangles[5, 3] = field53;
            rectangles[5, 4] = field54;
            rectangles[5, 5] = field55;

            rectangles[6, 0] = field60;
            rectangles[6, 1] = field61;
            rectangles[6, 2] = field62;
            rectangles[6, 3] = field63;
            rectangles[6, 4] = field64;
            rectangles[6, 5] = field65;
        }

        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            ButtonAction(0);
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            ButtonAction(1);
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            ButtonAction(2);
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            ButtonAction(3);
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            ButtonAction(4);
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            ButtonAction(5);
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            ButtonAction(6);
        }

        void ButtonAction(int i)
        {
            if (!PlayStep(i, 1))
            {
                MessageBox.Show("Spalte voll! Andere Spalte wählen");
                return;
            }                

            winner = CheckForWin();
            if (winner == 0)
            {
                KIMove();
            }
            winner = CheckForWin();
            if (winner != 0)
            {
                MessageBox.Show("Der Gewinner ist Spieler " + winner);
                return;
            }
        }

        bool PlayStep(int row, int player)
        {
            for (int y = 5; y > -1; y--)
            {
                if (map[row, y] == 0)
                {
                    map[row, y] = player;
                    DrawMap();
                    return true;
                }
            }
            return false;
        }

        void DrawMap()
        {
            for (int y = 5; y > -1; y--)
            {
                for (int x = 0; x < 7; x++)
                {
                    //rectangles[x, y] = new Rectangle();

                    if (map[x, y] == 1)
                    {
                        rectangles[x, y].Fill = new SolidColorBrush(Colors.Red);    
                    }
                    else if (map[x, y] == 2)
                    {
                        rectangles[x, y].Fill = new SolidColorBrush(Colors.Green);
                    }
                    else
                    {
                        rectangles[x, y].Fill = new SolidColorBrush(Colors.Gray);
                    }
                }
            }
        }

        int CheckForWin()
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

        private bool PruefeRichtung(int row, int col, int deltaRow, int deltaCol, int spieler, int count)
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            map = new int[7, 6];
            DrawMap();
        }

        void KIMove()
        {
            //suche eigenen stein
            for (int y = 0; y < 6; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    //eigenen stein gefunden, versuche daneben zu spielen
                    if (map[x, y] == 2 && PlayBeside(x, y))
                    {
                        return;
                    }
                }
            }
            // Falls kein benachbarter Platz gefunden wird, spiele zufällig
            PlayStep(r.Next(0, 7), 2);
        }


        bool PlayBeside(int x, int y)
        {
            // Liste der möglichen Richtungen (rechts, links, oben, unten)
            int[,] richtungen = { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 } };

            for (int i = 0; i < 4; i++)
            {
                int newX = x + richtungen[i, 0];
                int newY = y + richtungen[i, 1];

                // ist es noch auf dem Spielfeld?
                if (newX >= 0 && newX < 7 && newY >= 0 && newY < 6)
                {
                    if (map[newX, newY] == 0)
                    {
                        PlayStep(newX, 2);
                        return true;
                    }
                }
            }

            return false; // Kein freier Platz
        }
    }
}
