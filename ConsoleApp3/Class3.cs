using System;
using SharpLab

namespace SharpLab
{
    internal class Book
    {
        private string title;
        Person author;
        private DateTime datePublication;

        public global::System.String Title { get => title; set => title = value; }
        public Person Author { get => author; set => author = value; }
        public DateTime DatePublication { get => datePublication; set => datePublication = value; }

        // 00/00/0000 00:00:00 

        public void View()
        {
            Console.WriteLine($"Tytul:\t{Title}" + $"\nAuthor:\t";
            Author.View();
            Console.WriteLine("\ndata wydania:\t{datePublication}");
        }
    }
    public Book(string title, Person author, DateTime datePublication)
    {
        this.title = title;
        this.author = author;
        this.datePublication = datePublication;
    }
}