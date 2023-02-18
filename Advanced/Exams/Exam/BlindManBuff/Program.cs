using System;
using System.Linq;

namespace BlindManBuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];
            int positionrow = 0;
            int positioncol = 0;
            int totalOpponents = 0;
            char[,] playground = new char[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(" ");
                string line = string.Join("", arr);
                for (int j = 0; j < m; j++)
                {

                    playground[i, j] = line[j];
                    if (line[j]=='B')
                    {
                        positionrow = i;

                        positioncol = j;
                    }
                    if (playground[i, j] == 'P')
                    {
                        totalOpponents++;
                    }
                }
                
            }
            int moves = 0;
            int touchedCount = 0;
            
            string command = Console.ReadLine();
            
            while (command != "Finish")
            {
                if (command == "left" && positioncol - 1 >= 0)
                {
                    if (playground[positionrow, positioncol - 1] == '-')
                    {
                        playground[positionrow, positioncol] = '-';
                        positioncol--;
                        playground[positionrow, positioncol] = 'B';
                        moves++;
                    }
                    else if (playground[positionrow, positioncol - 1] == 'P')
                    {
                        playground[positionrow, positioncol] = '-';
                        positioncol--;
                        playground[positionrow, positioncol] = 'B';
                        touchedCount++;
                        moves++;
                    }
                }
                else if (command == "right" && positioncol + 1 < m)
                {
                    if (playground[positionrow, positioncol + 1] == '-')
                    {
                        playground[positionrow, positioncol] = '-';
                        positioncol++;
                        playground[positionrow, positioncol] = 'B';
                        moves++;
                    }
                    else if (playground[positionrow, positioncol + 1] == 'P')
                    {
                        playground[positionrow, positioncol] = '-';
                        positioncol++;
                        playground[positionrow, positioncol] = 'B';
                        touchedCount++;
                        moves++;
                    }
                }
                if (command == "up" && positionrow - 1 >= 0)
                {
                    if (playground[positionrow - 1, positioncol] == '-')
                    {
                        playground[positionrow, positioncol] = '-';
                        positionrow--;
                        playground[positionrow, positioncol] = 'B';
                        moves++;
                    }
                    else if (playground[positionrow - 1, positioncol] == 'P')
                    {
                        playground[positionrow, positioncol] = '-';
                        positionrow--;
                        playground[positionrow, positioncol] = 'B';
                        touchedCount++;
                        moves++;
                    }
                }
                if (command == "down" && positionrow + 1 < m)
                {
                    if (playground[positionrow + 1, positioncol] == '-')
                    {
                        playground[positionrow, positioncol] = '-';
                        positionrow++;
                        playground[positionrow, positioncol] = 'B';
                        moves++;
                    }
                    else if (playground[positionrow + 1, positioncol] == 'P')
                    {
                        playground[positionrow, positioncol] = '-';
                        positionrow++;
                        playground[positionrow, positioncol] = 'B';
                        touchedCount++;
                        moves++;
                    }
                }

                if (touchedCount == totalOpponents)
                {
                    break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {touchedCount} Moves made: {moves}");
        }
    }
}
