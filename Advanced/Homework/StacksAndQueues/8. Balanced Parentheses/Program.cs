using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Balanced_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string parenthesis = Console.ReadLine();
            bool isit=false;
            if (parenthesis.Length%2==0)
            {
                for (int i = 0; i < parenthesis.Length / 2; i++)
                {
                    for (int j = parenthesis.Length-1; j >= parenthesis.Length / 2; j--)
                    {
                        if (parenthesis[i].ToString() =="{" && parenthesis[j].ToString()=="}")
                        {
                            isit = true;
                        }
                        else if(parenthesis[i].ToString() == "[" && parenthesis[j].ToString() == "]") isit = true;
                        else if (parenthesis[i].ToString() == "(" && parenthesis[j].ToString() == ")") isit = true;
                        else isit = false;
                    }
                }
                if (isit==true)
                {
                    Console.WriteLine("YES");
                }
                else Console.WriteLine("NO");
            }
            else Console.WriteLine("NO");
            */
            var input = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();
            bool valid = false;
            foreach (var y in input)
            {
                if (stack.Any())
                {
                    char check = stack.Peek();
                    if (check == '{' && y == '}')
                    {
                        stack.Pop();
                        continue;
                    }
                    else if (check == '[' && y == ']')
                    {
                        stack.Pop();
                        continue;
                    }
                    else if (check == '(' && y == ')')
                    {
                        stack.Pop();
                        continue;
                    }
                }
                stack.Push(y);
            }
            if (!stack.Any())
            {
                valid = true;
            }
            if (valid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
