using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumofCom = int.Parse(Console.ReadLine());
            List<Article> list = new List<Article>();
            for (int i = 0; i < NumofCom; i++)
            {
                List<string> read = Console.ReadLine().Split(", ").ToList();
                Article article = new Article(read[0], read[1], read[2]);
                list.Add(article);
            }
            
            
                foreach (var item in list)
                {
                    Console.WriteLine(item.ToString());
                }
            
            
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }


    }
}
