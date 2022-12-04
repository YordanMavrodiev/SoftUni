using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();
            int NumofCom = int.Parse(Console.ReadLine());
            Article article = new Article(list[0],list[1],list[2]);
            for (int i = 0; i < NumofCom; i++)
            {
                List<string> command = Console.ReadLine().Split(": ",StringSplitOptions.RemoveEmptyEntries).ToList();
                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        article.Rename(command[1]);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(article.ToString());
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
        public void Edit(string newcont)
        {
            this.Content = newcont;
        
        }
        public void ChangeAuthor(string newauthor)
        {
            this.Author = newauthor;

        }
        public void Rename(string newname)
        {
            this.Title = newname;

        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }


    }
}
