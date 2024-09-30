using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static int width = 20;
    static int height = 20;
    static int[] snakeX = new int[100];
    static int[] snakeY = new int[100];
    static int snakeLength = 3;
    static int foodX;
    static int foodY;
    static string direction = "RIGHT";
    static Random random = new Random();

    static void Main()
    {
        // Initiale Position der Schlange
        snakeX[0] = 5;
        snakeY[0] = 5;

        // Platzieren des ersten Futters
        PlaceFood();

        // Spielschleife
        while (true)
        {
            DrawBoard();
            Input();
            Logic();

            Thread.Sleep(200); // Steuerung der Spielgeschwindigkeit
        }
    }

    static void DrawBoard()
    {
        Console.Clear();
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (x == snakeX[0] && y == snakeY[0])
                {
                    Console.Write("O"); // Kopf der Schlange
                }
                else if (IsSnakePart(x, y))
                {
                    Console.Write("o"); // Körper der Schlange
                }
                else if (x == foodX && y == foodY)
                {
                    Console.Write("X"); // Futter
                }
                else
                {
                    Console.Write("."); // Leerer Raum
                }
            }
            Console.WriteLine();
        }
    }

    static void Input()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    if (direction != "RIGHT") direction = "LEFT";
                    break;
                case ConsoleKey.RightArrow:
                    if (direction != "LEFT") direction = "RIGHT";
                    break;
                case ConsoleKey.UpArrow:
                    if (direction != "DOWN") direction = "UP";
                    break;
                case ConsoleKey.DownArrow:
                    if (direction != "UP") direction = "DOWN";
                    break;
            }
        }
    }

    static void Logic()
    {
        // Bewegung der Schlange
        for (int i = snakeLength - 1; i > 0; i--)
        {
            snakeX[i] = snakeX[i - 1];
            snakeY[i] = snakeY[i - 1];
        }

        switch (direction)
        {
            case "LEFT":
                snakeX[0]--;
                break;
            case "RIGHT":
                snakeX[0]++;
                break;
            case "UP":
                snakeY[0]--;
                break;
            case "DOWN":
                snakeY[0]++;
                break;
        }

        // Überprüfen auf Kollision mit den Wänden
        if (snakeX[0] < 0 || snakeX[0] >= width || snakeY[0] < 0 || snakeY[0] >= height)
        {
            GameOver();
        }

        // Überprüfen auf Kollision mit sich selbst
        for (int i = 1; i < snakeLength; i++)
        {
            if (snakeX[0] == snakeX[i] && snakeY[0] == snakeY[i])
            {
                GameOver();
            }
        }

        // Überprüfen, ob das Futter erreicht wurde
        if (snakeX[0] == foodX && snakeY[0] == foodY)
        {
            snakeLength++;
            PlaceFood();
        }
    }

    static bool IsSnakePart(int x, int y)
    {
        for (int i = 1; i < snakeLength; i++)
        {
            if (snakeX[i] == x && snakeY[i] == y)
            {
                return true;
            }
        }
        return false;
    }

    static void PlaceFood()
    {
        foodX = random.Next(0, width);
        foodY = random.Next(0, height);
    }

    static void GameOver()
    {
        Console.Clear();
        Console.WriteLine("Game Over!");
        Console.WriteLine("Deine Punktzahl: " + (snakeLength - 3));
        Environment.Exit(0);
    }
}