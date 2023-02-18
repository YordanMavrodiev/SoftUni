using System;
using System.Linq;

namespace WallDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] wall = new char[n,n];
            int positionrow = 0;
            int positioncol = 0;
            int holescount = 0;
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    
                    wall[i, j] = line[j];
                    if (line[j]=='V')
                    {
                        positionrow = i;
                        positioncol = j;
                    }
                }
            }
            string command = Console.ReadLine();
            bool isVankoDed = false;
            holescount++;
            int rodcount = 0;
            wall[positionrow, positioncol] = '*';
            while (command!="End")
            {
                switch (command)
                {
                    case "up": 
                        {
                            positionrow--;
                            if (positioncol >= n || positioncol < 0 || positionrow >= n || positionrow < 0)
                            {
                                positionrow++;
                                break;
                            }
                            else if (wall[positionrow, positioncol]=='-')
                            {
                                holescount++;
                                wall[positionrow, positioncol] = '*';
                            }
                            else if (wall[positionrow, positioncol]=='R')
                            {
                                Console.WriteLine("Vanko hit a rod!");
                                rodcount++;
                                positionrow++;
                            }
                            else if (wall[positionrow, positioncol] == 'C')
                            {
                                holescount++;
                                wall[positionrow, positioncol] = 'E';
                                isVankoDed = true;
                            }
                            else if (wall[positionrow, positioncol] == '*')
                            {
                                Console.WriteLine($"The wall is already destroyed at position [{positionrow}, {positioncol}]!");
                            }
                        
                        
                        
                        }
                        break;
                    case "down":
                        {
                            positionrow++;
                            if (positioncol >= n || positioncol < 0 || positionrow >= n || positionrow < 0)
                            {
                                positionrow--;
                                break;
                            }
                            else if (wall[positionrow, positioncol] == '-')
                            {
                                holescount++;
                                wall[positionrow, positioncol] = '*';
                            }
                            else if (wall[positionrow, positioncol] == 'R')
                            {
                                Console.WriteLine("Vanko hit a rod!");
                                rodcount++;
                                positionrow--;
                            }
                            else if (wall[positionrow, positioncol] == 'C')
                            {
                                holescount++;
                                wall[positionrow, positioncol] = 'E';
                                isVankoDed = true;
                            }
                            else if (wall[positionrow, positioncol] == '*')
                            {
                                Console.WriteLine($"The wall is already destroyed at position [{positionrow}, {positioncol}]!");
                            }



                        }
                        break;
                    case "left":
                        {
                            positioncol--;
                            if (positioncol >= n || positioncol < 0 || positionrow >= n || positionrow < 0)
                            {
                                positioncol++;
                                break;
                            }
                            else if (wall[positionrow, positioncol] == '-')
                            {
                                holescount++;
                                wall[positionrow, positioncol] = '*';
                            }
                            else if (wall[positionrow, positioncol] == 'R')
                            {
                                Console.WriteLine("Vanko hit a rod!");
                                rodcount++;
                                positioncol++;
                            }
                            else if (wall[positionrow, positioncol] == 'C')
                            {
                                holescount++;
                                wall[positionrow, positioncol] = 'E';
                                isVankoDed = true;
                            }
                            else if (wall[positionrow, positioncol] == '*')
                            {
                                Console.WriteLine($"The wall is already destroyed at position [{positionrow}, {positioncol}]!");
                            }



                        }
                        break;
                    case "right":
                        {
                            positioncol++;
                            if (positioncol>=n|| positioncol <0||positionrow>=n||positionrow<0)
                            {
                                positioncol--;
                                break;
                            }
                            else if (wall[positionrow, positioncol] == '-')
                            {
                                holescount++;
                                wall[positionrow, positioncol] = '*';
                            }
                            else if (wall[positionrow, positioncol] == 'R')
                            {
                                Console.WriteLine("Vanko hit a rod!");
                                rodcount++;
                                positioncol--;
                            }
                            else if (wall[positionrow, positioncol] == 'C')
                            {
                                holescount++;
                                wall[positionrow, positioncol] = 'E';
                                isVankoDed = true;
                            }
                            else if (wall[positionrow, positioncol] == '*')
                            {
                                Console.WriteLine($"The wall is already destroyed at position [{positionrow}, {positioncol}]!");
                            }



                        }
                        break;



                    default:
                        break;
                }
                if (isVankoDed)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if (isVankoDed)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holescount} hole(s).");
                wall[positionrow, positioncol] = 'E';
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {holescount} hole(s) and he hit only {rodcount} rod(s).");
                wall[positionrow, positioncol] = 'V';
            }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(wall[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
